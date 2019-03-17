namespace InvitationProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtName5 = new System.Windows.Forms.TextBox();
            this.txtName6 = new System.Windows.Forms.TextBox();
            this.txtName7 = new System.Windows.Forms.TextBox();
            this.txtName8 = new System.Windows.Forms.TextBox();
            this.txtName9 = new System.Windows.Forms.TextBox();
            this.txtName10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail10 = new System.Windows.Forms.TextBox();
            this.txtEmail9 = new System.Windows.Forms.TextBox();
            this.txtEmail8 = new System.Windows.Forms.TextBox();
            this.txtEmail7 = new System.Windows.Forms.TextBox();
            this.txtEmail6 = new System.Windows.Forms.TextBox();
            this.txtEmail5 = new System.Windows.Forms.TextBox();
            this.txtEmail4 = new System.Windows.Forms.TextBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtExportedFilePath = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnExportedFilePath = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.txtAttchPath1 = new System.Windows.Forms.TextBox();
            this.txtAttchPath2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAttchPath3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnAttchFile1 = new System.Windows.Forms.Button();
            this.btnAttchFile2 = new System.Windows.Forms.Button();
            this.btnAttchFile3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnChange.Location = new System.Drawing.Point(198, 473);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(124, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Edit PDF";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "แกน X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "แกน Y:";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(85, 347);
            this.numX.Maximum = new decimal(new int[] {
            595,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(87, 20);
            this.numX.TabIndex = 3;
            this.numX.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(85, 371);
            this.numY.Maximum = new decimal(new int[] {
            842,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(87, 20);
            this.numY.TabIndex = 4;
            this.numY.Value = new decimal(new int[] {
            586,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font Size:";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(235, 346);
            this.numFontSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(87, 20);
            this.numFontSize.TabIndex = 6;
            this.numFontSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(4, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Setting";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(43, 43);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(276, 20);
            this.txtName1.TabIndex = 1;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(43, 69);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(276, 20);
            this.txtName2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(43, 95);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(276, 20);
            this.txtName3.TabIndex = 3;
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(43, 121);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(276, 20);
            this.txtName4.TabIndex = 4;
            // 
            // txtName5
            // 
            this.txtName5.Location = new System.Drawing.Point(43, 147);
            this.txtName5.Name = "txtName5";
            this.txtName5.Size = new System.Drawing.Size(276, 20);
            this.txtName5.TabIndex = 5;
            // 
            // txtName6
            // 
            this.txtName6.Location = new System.Drawing.Point(43, 173);
            this.txtName6.Name = "txtName6";
            this.txtName6.Size = new System.Drawing.Size(276, 20);
            this.txtName6.TabIndex = 6;
            // 
            // txtName7
            // 
            this.txtName7.Location = new System.Drawing.Point(43, 199);
            this.txtName7.Name = "txtName7";
            this.txtName7.Size = new System.Drawing.Size(276, 20);
            this.txtName7.TabIndex = 7;
            // 
            // txtName8
            // 
            this.txtName8.Location = new System.Drawing.Point(43, 225);
            this.txtName8.Name = "txtName8";
            this.txtName8.Size = new System.Drawing.Size(276, 20);
            this.txtName8.TabIndex = 8;
            // 
            // txtName9
            // 
            this.txtName9.Location = new System.Drawing.Point(43, 251);
            this.txtName9.Name = "txtName9";
            this.txtName9.Size = new System.Drawing.Size(276, 20);
            this.txtName9.TabIndex = 9;
            // 
            // txtName10
            // 
            this.txtName10.Location = new System.Drawing.Point(43, 277);
            this.txtName10.Name = "txtName10";
            this.txtName10.Size = new System.Drawing.Size(276, 20);
            this.txtName10.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "8";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 399);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "ตำแหน่งไฟล์ต้นฉบับ";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(31, 415);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(210, 20);
            this.txtFilePath.TabIndex = 31;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(247, 413);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 32;
            this.btnFilePath.Text = "เลือกไฟล์";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Font Size:";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(235, 373);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(87, 21);
            this.cbColor.TabIndex = 34;
            this.cbColor.Text = "BLACK";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.Location = new System.Drawing.Point(331, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Email";
            // 
            // txtEmail10
            // 
            this.txtEmail10.Location = new System.Drawing.Point(351, 277);
            this.txtEmail10.Name = "txtEmail10";
            this.txtEmail10.Size = new System.Drawing.Size(276, 20);
            this.txtEmail10.TabIndex = 20;
            // 
            // txtEmail9
            // 
            this.txtEmail9.Location = new System.Drawing.Point(351, 251);
            this.txtEmail9.Name = "txtEmail9";
            this.txtEmail9.Size = new System.Drawing.Size(276, 20);
            this.txtEmail9.TabIndex = 19;
            // 
            // txtEmail8
            // 
            this.txtEmail8.Location = new System.Drawing.Point(351, 225);
            this.txtEmail8.Name = "txtEmail8";
            this.txtEmail8.Size = new System.Drawing.Size(276, 20);
            this.txtEmail8.TabIndex = 18;
            // 
            // txtEmail7
            // 
            this.txtEmail7.Location = new System.Drawing.Point(351, 199);
            this.txtEmail7.Name = "txtEmail7";
            this.txtEmail7.Size = new System.Drawing.Size(276, 20);
            this.txtEmail7.TabIndex = 17;
            // 
            // txtEmail6
            // 
            this.txtEmail6.Location = new System.Drawing.Point(351, 173);
            this.txtEmail6.Name = "txtEmail6";
            this.txtEmail6.Size = new System.Drawing.Size(276, 20);
            this.txtEmail6.TabIndex = 16;
            // 
            // txtEmail5
            // 
            this.txtEmail5.Location = new System.Drawing.Point(351, 147);
            this.txtEmail5.Name = "txtEmail5";
            this.txtEmail5.Size = new System.Drawing.Size(276, 20);
            this.txtEmail5.TabIndex = 15;
            // 
            // txtEmail4
            // 
            this.txtEmail4.Location = new System.Drawing.Point(351, 121);
            this.txtEmail4.Name = "txtEmail4";
            this.txtEmail4.Size = new System.Drawing.Size(276, 20);
            this.txtEmail4.TabIndex = 14;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(351, 95);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(276, 20);
            this.txtEmail3.TabIndex = 13;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(351, 69);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(276, 20);
            this.txtEmail2.TabIndex = 12;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(351, 43);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(276, 20);
            this.txtEmail1.TabIndex = 11;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(651, 95);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(304, 295);
            this.txtMessage.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label20.Location = new System.Drawing.Point(647, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 20);
            this.label20.TabIndex = 47;
            this.label20.Text = "Message";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.Location = new System.Drawing.Point(647, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 20);
            this.label21.TabIndex = 48;
            this.label21.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(651, 43);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(304, 20);
            this.txtSubject.TabIndex = 21;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(405, 334);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(347, 337);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Email:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(348, 364);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 52;
            this.label23.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(405, 361);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 24;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSend.Location = new System.Drawing.Point(785, 399);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(170, 50);
            this.btnSend.TabIndex = 25;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtExportedFilePath
            // 
            this.txtExportedFilePath.Location = new System.Drawing.Point(31, 450);
            this.txtExportedFilePath.Name = "txtExportedFilePath";
            this.txtExportedFilePath.ReadOnly = true;
            this.txtExportedFilePath.Size = new System.Drawing.Size(210, 20);
            this.txtExportedFilePath.TabIndex = 62;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 436);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "ตำแหน่งไฟล์ส่งออก";
            // 
            // btnExportedFilePath
            // 
            this.btnExportedFilePath.Location = new System.Drawing.Point(247, 448);
            this.btnExportedFilePath.Name = "btnExportedFilePath";
            this.btnExportedFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnExportedFilePath.TabIndex = 63;
            this.btnExportedFilePath.Text = "เลือกไฟล์";
            this.btnExportedFilePath.UseVisualStyleBackColor = true;
            this.btnExportedFilePath.Click += new System.EventHandler(this.btnExportedFilePath_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(348, 386);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(74, 13);
            this.lb.TabIndex = 64;
            this.lb.Text = "เอกสารแนบ1:";
            // 
            // txtAttchPath1
            // 
            this.txtAttchPath1.Location = new System.Drawing.Point(350, 403);
            this.txtAttchPath1.Name = "txtAttchPath1";
            this.txtAttchPath1.ReadOnly = true;
            this.txtAttchPath1.Size = new System.Drawing.Size(201, 20);
            this.txtAttchPath1.TabIndex = 65;
            // 
            // txtAttchPath2
            // 
            this.txtAttchPath2.Location = new System.Drawing.Point(350, 439);
            this.txtAttchPath2.Name = "txtAttchPath2";
            this.txtAttchPath2.ReadOnly = true;
            this.txtAttchPath2.Size = new System.Drawing.Size(201, 20);
            this.txtAttchPath2.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "เอกสารแนบ2:";
            // 
            // txtAttchPath3
            // 
            this.txtAttchPath3.Location = new System.Drawing.Point(351, 475);
            this.txtAttchPath3.Name = "txtAttchPath3";
            this.txtAttchPath3.ReadOnly = true;
            this.txtAttchPath3.Size = new System.Drawing.Size(201, 20);
            this.txtAttchPath3.TabIndex = 69;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(348, 459);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 68;
            this.label24.Text = "เอกสารแนบ3:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(651, 475);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(304, 20);
            this.progressBar.TabIndex = 70;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(648, 455);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 71;
            this.lbStatus.Text = "Status:";
            // 
            // btnAttchFile1
            // 
            this.btnAttchFile1.Location = new System.Drawing.Point(557, 401);
            this.btnAttchFile1.Name = "btnAttchFile1";
            this.btnAttchFile1.Size = new System.Drawing.Size(69, 23);
            this.btnAttchFile1.TabIndex = 72;
            this.btnAttchFile1.Text = "เลือกไฟล์";
            this.btnAttchFile1.UseVisualStyleBackColor = true;
            this.btnAttchFile1.Click += new System.EventHandler(this.btnAttchFile1_Click);
            // 
            // btnAttchFile2
            // 
            this.btnAttchFile2.Location = new System.Drawing.Point(557, 437);
            this.btnAttchFile2.Name = "btnAttchFile2";
            this.btnAttchFile2.Size = new System.Drawing.Size(69, 23);
            this.btnAttchFile2.TabIndex = 73;
            this.btnAttchFile2.Text = "เลือกไฟล์";
            this.btnAttchFile2.UseVisualStyleBackColor = true;
            this.btnAttchFile2.Click += new System.EventHandler(this.btnAttchFile2_Click);
            // 
            // btnAttchFile3
            // 
            this.btnAttchFile3.Location = new System.Drawing.Point(557, 473);
            this.btnAttchFile3.Name = "btnAttchFile3";
            this.btnAttchFile3.Size = new System.Drawing.Size(69, 23);
            this.btnAttchFile3.TabIndex = 74;
            this.btnAttchFile3.Text = "เลือกไฟล์";
            this.btnAttchFile3.UseVisualStyleBackColor = true;
            this.btnAttchFile3.Click += new System.EventHandler(this.btnAttchFile3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 503);
            this.Controls.Add(this.btnAttchFile3);
            this.Controls.Add(this.btnAttchFile2);
            this.Controls.Add(this.btnAttchFile1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtAttchPath3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtAttchPath2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAttchPath1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnExportedFilePath);
            this.Controls.Add(this.txtExportedFilePath);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtEmail10);
            this.Controls.Add(this.txtEmail9);
            this.Controls.Add(this.txtEmail8);
            this.Controls.Add(this.txtEmail7);
            this.Controls.Add(this.txtEmail6);
            this.Controls.Add(this.txtEmail5);
            this.Controls.Add(this.txtEmail4);
            this.Controls.Add(this.txtEmail3);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName10);
            this.Controls.Add(this.txtName9);
            this.Controls.Add(this.txtName8);
            this.Controls.Add(this.txtName7);
            this.Controls.Add(this.txtName6);
            this.Controls.Add(this.txtName5);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Name = "Form1";
            this.Text = "PDF Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtName5;
        private System.Windows.Forms.TextBox txtName6;
        private System.Windows.Forms.TextBox txtName7;
        private System.Windows.Forms.TextBox txtName8;
        private System.Windows.Forms.TextBox txtName9;
        private System.Windows.Forms.TextBox txtName10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail10;
        private System.Windows.Forms.TextBox txtEmail9;
        private System.Windows.Forms.TextBox txtEmail8;
        private System.Windows.Forms.TextBox txtEmail7;
        private System.Windows.Forms.TextBox txtEmail6;
        private System.Windows.Forms.TextBox txtEmail5;
        private System.Windows.Forms.TextBox txtEmail4;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtExportedFilePath;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnExportedFilePath;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtAttchPath1;
        private System.Windows.Forms.TextBox txtAttchPath2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAttchPath3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnAttchFile1;
        private System.Windows.Forms.Button btnAttchFile2;
        private System.Windows.Forms.Button btnAttchFile3;
    }
}

