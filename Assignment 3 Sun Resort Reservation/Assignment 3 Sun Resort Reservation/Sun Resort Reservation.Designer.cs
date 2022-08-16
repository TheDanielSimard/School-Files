
namespace Assignment_3_Sun_Resort_Reservation
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.radDouble = new System.Windows.Forms.RadioButton();
            this.radQueen = new System.Windows.Forms.RadioButton();
            this.radKing = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.tlTip = new System.Windows.Forms.ToolTip(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lstCreditCard = new System.Windows.Forms.ListBox();
            this.txtReservation = new System.Windows.Forms.TextBox();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment_3_Sun_Resort_Reservation.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zip:";
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout,
            this.mnuContact});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(567, 24);
            this.mnuStrip.TabIndex = 9;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(93, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 20);
            this.mnuAbout.Text = "About Sun Resorts";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuContact
            // 
            this.mnuContact.Name = "mnuContact";
            this.mnuContact.Size = new System.Drawing.Size(77, 20);
            this.mnuContact.Text = "Contact Us";
            this.mnuContact.Click += new System.EventHandler(this.mnuContact_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.radDouble);
            this.grpBox.Controls.Add(this.radQueen);
            this.grpBox.Controls.Add(this.radKing);
            this.grpBox.Location = new System.Drawing.Point(12, 239);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(248, 50);
            this.grpBox.TabIndex = 10;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Select Bed Size:";
            // 
            // radDouble
            // 
            this.radDouble.AutoCheck = false;
            this.radDouble.AutoSize = true;
            this.radDouble.Location = new System.Drawing.Point(190, 18);
            this.radDouble.Name = "radDouble";
            this.radDouble.Size = new System.Drawing.Size(52, 16);
            this.radDouble.TabIndex = 2;
            this.radDouble.TabStop = true;
            this.radDouble.Text = "Double";
            this.radDouble.UseVisualStyleBackColor = true;
            // 
            // radQueen
            // 
            this.radQueen.AutoCheck = false;
            this.radQueen.AutoSize = true;
            this.radQueen.Location = new System.Drawing.Point(94, 18);
            this.radQueen.Name = "radQueen";
            this.radQueen.Size = new System.Drawing.Size(50, 16);
            this.radQueen.TabIndex = 1;
            this.radQueen.TabStop = true;
            this.radQueen.Text = "Queen";
            this.radQueen.UseVisualStyleBackColor = true;
            // 
            // radKing
            // 
            this.radKing.AutoCheck = false;
            this.radKing.AutoSize = true;
            this.radKing.Location = new System.Drawing.Point(7, 18);
            this.radKing.Name = "radKing";
            this.radKing.Size = new System.Drawing.Size(41, 16);
            this.radKing.TabIndex = 0;
            this.radKing.TabStop = true;
            this.radKing.Text = "King";
            this.radKing.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Check In:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Check Out:";
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(12, 296);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(129, 16);
            this.chkMember.TabIndex = 13;
            this.chkMember.Text = "AARP Or AAA Member:";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // dtpIn
            // 
            this.dtpIn.Location = new System.Drawing.Point(60, 214);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(200, 19);
            this.dtpIn.TabIndex = 14;
            this.dtpIn.ValueChanged += new System.EventHandler(this.dtpIn_ValueChanged);
            // 
            // dtpOut
            // 
            this.dtpOut.Location = new System.Drawing.Point(342, 212);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(200, 19);
            this.dtpOut.TabIndex = 15;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 19);
            this.txtName.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(342, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 19);
            this.txtAddress.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(342, 129);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 19);
            this.txtCity.TabIndex = 18;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(342, 178);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(81, 19);
            this.txtState.TabIndex = 19;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(461, 178);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(81, 19);
            this.txtZip.TabIndex = 20;
            // 
            // lstCreditCard
            // 
            this.lstCreditCard.FormattingEnabled = true;
            this.lstCreditCard.ItemHeight = 12;
            this.lstCreditCard.Location = new System.Drawing.Point(12, 318);
            this.lstCreditCard.Name = "lstCreditCard";
            this.lstCreditCard.Size = new System.Drawing.Size(120, 52);
            this.lstCreditCard.TabIndex = 21;
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(296, 237);
            this.txtReservation.Multiline = true;
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.ReadOnly = true;
            this.txtReservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReservation.Size = new System.Drawing.Size(246, 103);
            this.txtReservation.TabIndex = 22;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(337, 346);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(157, 23);
            this.btnReservation.TabIndex = 23;
            this.btnReservation.Text = "Reserve Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Credit Card Number:";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(138, 351);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(112, 19);
            this.txtCard.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 380);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.txtReservation);
            this.Controls.Add(this.lstCreditCard);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.chkMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStrip);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sun Resort Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuContact;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton radDouble;
        private System.Windows.Forms.RadioButton radQueen;
        private System.Windows.Forms.RadioButton radKing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.ToolTip tlTip;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstCreditCard;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label8;
    }
}

