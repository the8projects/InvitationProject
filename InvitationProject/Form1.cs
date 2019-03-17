using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;
using System.Net.Mail;

namespace InvitationProject
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string strFilePath;

        public Form1()
        {
            InitializeComponent();
            cbColor.Items.Add("BLACK");
            cbColor.Items.Add("DARK_GRAY");
            cbColor.Items.Add("RED");
            cbColor.Items.Add("BLUE");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int count = 0;
            //int newFileName = 1;
            if (strFilePath != "" && strFilePath != null)
            {
                for (int i = 1; i < 11; i++)
                {
                    TextBox txtBox = (TextBox)this.Controls.Find("txtName" + i, true)[0];
                    if (txtBox.Text != "" && txtBox.Text != null)
                    {
                        count++;
                        PdfReader reader = new PdfReader(strFilePath);
                        Document doc = new Document(PageSize.A4);

                        //FileStream fs = new FileStream((newFileName++)+".pdf", FileMode.Create, FileAccess.Write);
                        FileStream fs = new FileStream("ExportedFiles/"+txtBox.Text + ".pdf", FileMode.Create, FileAccess.Write);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        PdfContentByte cb = writer.DirectContent;  
                        PdfImportedPage page = writer.GetImportedPage(reader, 1);
                        cb.AddTemplate(page, 0, 0);
                        BaseFont bf = BaseFont.CreateFont("THSarabunNewBold.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        switch (cbColor.Text)
                        {
                            case "BLACK":
                                cb.SetColorFill(BaseColor.BLACK);
                                break;
                            case "DARK_GRAY":
                                cb.SetColorFill(BaseColor.DARK_GRAY);
                                break;
                            case "RED":
                                cb.SetColorFill(BaseColor.RED);
                                break;
                            case "BLUE":
                                cb.SetColorFill(BaseColor.BLUE);
                                break;
                            default:
                                cb.SetColorFill(BaseColor.DARK_GRAY);
                                break;
                        }
                        cb.SetFontAndSize(bf, Convert.ToInt32(numFontSize.Value));

                        cb.BeginText();
                       
                        string text = txtBox.Text;

                        cb.ShowTextAligned(0, text, Convert.ToInt32(numX.Value), Convert.ToInt32(numY.Value), 0);
                        cb.EndText();

                        //ถ้าเอกสารมี 2 หน้า
                        doc.NewPage();
                        PdfContentByte cb2 = writer.DirectContent;
                        PdfImportedPage page2 = writer.GetImportedPage(reader, 2);
                        cb2.AddTemplate(page2, 1, 1);
                        cb2.BeginText();
                        cb2.EndText();

                        doc.Close();
                        fs.Close();
                        writer.Close();
                        reader.Close();
                        /*
                        Document doc = new Document(PageSize.A4, 100, 100, 100, 100);
                        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Append));
                        doc.Open();
                        Paragraph paragraph = new Paragraph("This is my first line using Paragraph100.");
                        doc.Add(paragraph);
                        doc.Close();*/
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("กรุณากรอกชื่ออย่างน้อย 1 ชื่อ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกไฟล์ต้นฉบับ");
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txtUsername.Text, txtPassword.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chkSSL.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtUsername.Text + txtSmtp.Text.Replace("smtp","@"), "Lucy", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtEmail1.Text));
            msg.Subject = txtSubject.Text;
            msg.Body = txtMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = openFileDialog.FileName;
                txtFilePath.Text = strFilePath;
            }
        }

        private void btnExportedFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtExportedFilePath.Text = folderBrowser.SelectedPath;
            }  
        }
    }
}
