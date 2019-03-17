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
using System.Threading;

namespace InvitationProject
{
    public partial class Form1 : Form
    {
        MailMessage msg;
        string strFilePath;
        string strAttchPath1;
        string strAttchPath2;
        string strAttchPath3;
        Random randInt = new Random();
        int randNum;

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
            lbStatus.Text = "Status:";
            progressBar.Value = 0;
            //int status = 0;
            //int newFileName = 1;
            if (!string.IsNullOrWhiteSpace(strFilePath))
            {
                for (int i = 1; i < 11; i++)
                {
                    TextBox txtName = (TextBox)this.Controls.Find("txtName" + i, true)[0];
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        count++;
                        PdfReader reader = new PdfReader(strFilePath);
                        Document doc = new Document(PageSize.A4);

                        //FileStream fs = new FileStream((newFileName++)+".pdf", FileMode.Create, FileAccess.Write);
                        FileStream fs = new FileStream(txtExportedFilePath.Text + @"\หนังสือเชิญ" + txtName.Text + ".pdf", FileMode.Create, FileAccess.Write);
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
                       
                        string text = txtName.Text;

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
                    }
                    randNum = randInt.Next(128, 312);
                    Thread.Sleep(randNum);
                    //switch (status)
                    //{
                    //    case 0:
                    //        lbStatus.Text = "Status: Processing.";
                    //        status++;
                    //        break;
                    //    case 1:
                    //        lbStatus.Text = "Status: Processing..";
                    //        status++;
                    //        break;
                    //    case 2:
                    //        lbStatus.Text = "Status: Processing...";
                    //        status = 0;
                    //        break;
                    //    default:
                    //        lbStatus.Text = "Status: " + Convert.ToString(status);
                    //        break;
                    //}
                    progressBar.Value = i*10;
                }
                if (count == 0)
                {
                    MessageBox.Show("กรุณากรอกชื่ออย่างน้อย 1 ชื่อ");
                    lbStatus.Text = "Status:";
                }
                else
                {
                    lbStatus.Text = "Status: Completed";
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกไฟล์ต้นฉบับ");
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            int count = 0;
            lbStatus.Text = "Status:";
            progressBar.Value = 0;
            //int status = 0;
            for (int i = 1; i < 11; i++)
            {
                TextBox txtName = (TextBox)this.Controls.Find("txtName" + i, true)[0];
                TextBox txtEmail = (TextBox)this.Controls.Find("txtEmail" + i, true)[0];
                if ((!string.IsNullOrWhiteSpace(txtName.Text)) && (!string.IsNullOrWhiteSpace(txtEmail.Text)))
                {
                    count++;
                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text),
                        EnableSsl = true
                    };

                    var message = new MailMessage(txtEmail.Text, txtEmail.Text)
                    {
                        Subject = txtSubject.Text,
                        Body = "เรียน " + txtName.Text + Environment.NewLine + txtMessage.Text
                    };

                    message.Attachments.Add(new Attachment(txtExportedFilePath.Text + @"\หนังสือเชิญ" + txtName.Text + ".pdf"));
                    if (strAttchPath1 != "" && strAttchPath1 != null)
                        message.Attachments.Add(new Attachment(strAttchPath1));
                    if (strAttchPath2 != "" && strAttchPath2 != null)
                        message.Attachments.Add(new Attachment(strAttchPath2));
                    if (strAttchPath3 != "" && strAttchPath3 != null)
                        message.Attachments.Add(new Attachment(strAttchPath3));
                    client.Send(message);
                }
                randNum = randInt.Next(500, 1024);
                Thread.Sleep(randNum);

                //switch (status)
                //{
                //    case 0:
                //        lbStatus.Text = "Status: Processing.";
                //        break;
                //    case 1:
                //        lbStatus.Text = "Status: Processing..";
                //        break;
                //    case 2:
                //        lbStatus.Text = "Status: Processing...";
                //        status = 0;
                //        break;
                //    default:
                //        lbStatus.Text = "Status: Processing...";
                //        break;
                //}
                progressBar.Value = i * 10;
            }
            if (count == 0)
            {
                MessageBox.Show("กรุณากรอกชื่อและEmail");
                lbStatus.Text = "Status:";
            }
            else
            {
                lbStatus.Text = "Status: Completed";
            }

    //var client = new SmtpClient("smtp.gmail.com", 587)
    //{
    //    Credentials = new NetworkCredential("suwanon.c@gmail.com", "e8FF6740"),
    //    EnableSsl = true
    //};
    //var message = new MailMessage("zeroonez1team@gmail.com", "zeroonez1team@gmail.com")
    //{
    //    Subject = "Test sending invitation email",
    //    Body = "testing"
    //};
    //message.Attachments.Add(new Attachment("ทดสอบ.pdf"));
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

        private void btnAttchFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strAttchPath1 = openFileDialog.FileName;
                txtAttchPath1.Text = strAttchPath1;
            }
        }

        private void btnAttchFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strAttchPath2 = openFileDialog.FileName;
                txtAttchPath2.Text = strAttchPath2;
            }
        }

        private void btnAttchFile3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strAttchPath3 = openFileDialog.FileName;
                txtAttchPath3.Text = strAttchPath3;
            }
        }
    }
}
