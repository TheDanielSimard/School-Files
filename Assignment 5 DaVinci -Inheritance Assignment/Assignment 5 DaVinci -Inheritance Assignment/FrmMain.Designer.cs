
namespace Assignment_5_DaVinci__Inheritance_Assignment
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grpHousing = new System.Windows.Forms.GroupBox();
            this.radLondon = new System.Windows.Forms.RadioButton();
            this.radRome = new System.Windows.Forms.RadioButton();
            this.radParis = new System.Windows.Forms.RadioButton();
            this.radOffCampus = new System.Windows.Forms.RadioButton();
            this.radOnCampus = new System.Windows.Forms.RadioButton();
            this.grpResidence = new System.Windows.Forms.GroupBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuition = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumberCredits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpHousing.SuspendLayout();
            this.grpResidence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHousing
            // 
            this.grpHousing.Controls.Add(this.radLondon);
            this.grpHousing.Controls.Add(this.radRome);
            this.grpHousing.Controls.Add(this.radParis);
            this.grpHousing.Location = new System.Drawing.Point(336, 283);
            this.grpHousing.Name = "grpHousing";
            this.grpHousing.Size = new System.Drawing.Size(96, 100);
            this.grpHousing.TabIndex = 1;
            this.grpHousing.TabStop = false;
            this.grpHousing.Text = "Housing";
            // 
            // radLondon
            // 
            this.radLondon.AutoCheck = false;
            this.radLondon.AutoSize = true;
            this.radLondon.Location = new System.Drawing.Point(7, 68);
            this.radLondon.Name = "radLondon";
            this.radLondon.Size = new System.Drawing.Size(89, 17);
            this.radLondon.TabIndex = 2;
            this.radLondon.TabStop = true;
            this.radLondon.Text = "London Dorm";
            this.radLondon.UseVisualStyleBackColor = true;
            // 
            // radRome
            // 
            this.radRome.AutoCheck = false;
            this.radRome.AutoSize = true;
            this.radRome.Location = new System.Drawing.Point(7, 44);
            this.radRome.Name = "radRome";
            this.radRome.Size = new System.Drawing.Size(81, 17);
            this.radRome.TabIndex = 1;
            this.radRome.TabStop = true;
            this.radRome.Text = "Rome Dorm";
            this.radRome.UseVisualStyleBackColor = true;
            // 
            // radParis
            // 
            this.radParis.AutoCheck = false;
            this.radParis.AutoSize = true;
            this.radParis.Location = new System.Drawing.Point(7, 20);
            this.radParis.Name = "radParis";
            this.radParis.Size = new System.Drawing.Size(76, 17);
            this.radParis.TabIndex = 0;
            this.radParis.TabStop = true;
            this.radParis.Text = "Paris Dorm";
            this.radParis.UseVisualStyleBackColor = true;
            // 
            // radOffCampus
            // 
            this.radOffCampus.AutoCheck = false;
            this.radOffCampus.AutoSize = true;
            this.radOffCampus.Location = new System.Drawing.Point(7, 20);
            this.radOffCampus.Name = "radOffCampus";
            this.radOffCampus.Size = new System.Drawing.Size(80, 17);
            this.radOffCampus.TabIndex = 0;
            this.radOffCampus.TabStop = true;
            this.radOffCampus.Text = "Off Campus";
            this.radOffCampus.UseVisualStyleBackColor = true;
            this.radOffCampus.CheckedChanged += new System.EventHandler(this.radOffCampus_CheckedChanged);
            // 
            // radOnCampus
            // 
            this.radOnCampus.AutoCheck = false;
            this.radOnCampus.AutoSize = true;
            this.radOnCampus.Location = new System.Drawing.Point(7, 44);
            this.radOnCampus.Name = "radOnCampus";
            this.radOnCampus.Size = new System.Drawing.Size(80, 17);
            this.radOnCampus.TabIndex = 1;
            this.radOnCampus.TabStop = true;
            this.radOnCampus.Text = "On Campus";
            this.radOnCampus.UseVisualStyleBackColor = true;
            this.radOnCampus.CheckedChanged += new System.EventHandler(this.radOnCampus_CheckedChanged);
            // 
            // grpResidence
            // 
            this.grpResidence.Controls.Add(this.radOnCampus);
            this.grpResidence.Controls.Add(this.radOffCampus);
            this.grpResidence.Location = new System.Drawing.Point(336, 210);
            this.grpResidence.Name = "grpResidence";
            this.grpResidence.Size = new System.Drawing.Size(96, 67);
            this.grpResidence.TabIndex = 0;
            this.grpResidence.TabStop = false;
            this.grpResidence.Text = "Residence";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(336, 390);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(78, 17);
            this.chkAuto.TabIndex = 2;
            this.chkAuto.Text = "Automobile";
            this.chkAuto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(101, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tuition Fee";
            // 
            // txtTuition
            // 
            this.txtTuition.Location = new System.Drawing.Point(19, 237);
            this.txtTuition.Multiline = true;
            this.txtTuition.Name = "txtTuition";
            this.txtTuition.ReadOnly = true;
            this.txtTuition.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTuition.Size = new System.Drawing.Size(278, 176);
            this.txtTuition.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(81, 440);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 46);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Fee";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(420, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Name:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(308, 177);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 13);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Number Of Credits:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(420, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtNumberCredits
            // 
            this.txtNumberCredits.Location = new System.Drawing.Point(420, 174);
            this.txtNumberCredits.Name = "txtNumberCredits";
            this.txtNumberCredits.Size = new System.Drawing.Size(150, 20);
            this.txtNumberCredits.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(330, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "DaVinci College";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberCredits);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTuition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.grpHousing);
            this.Controls.Add(this.grpResidence);
            this.Name = "FrmMain";
            this.Text = "DaVince College";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpHousing.ResumeLayout(false);
            this.grpHousing.PerformLayout();
            this.grpResidence.ResumeLayout(false);
            this.grpResidence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHousing;
        private System.Windows.Forms.RadioButton radLondon;
        private System.Windows.Forms.RadioButton radRome;
        private System.Windows.Forms.RadioButton radParis;
        private System.Windows.Forms.RadioButton radOffCampus;
        private System.Windows.Forms.RadioButton radOnCampus;
        private System.Windows.Forms.GroupBox grpResidence;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberCredits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTuition;
        private System.Windows.Forms.Label label1;
    }
}

