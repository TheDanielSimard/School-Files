
namespace Assignment_7_Regal_Collections
{
    partial class frmDisplay
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
            this.txtNewDisplay = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewDisplay
            // 
            this.txtNewDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtNewDisplay.Multiline = true;
            this.txtNewDisplay.Name = "txtNewDisplay";
            this.txtNewDisplay.ReadOnly = true;
            this.txtNewDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNewDisplay.Size = new System.Drawing.Size(578, 286);
            this.txtNewDisplay.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(237, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNewDisplay);
            this.Name = "frmDisplay";
            this.Text = "frmDisplay";
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewDisplay;
        private System.Windows.Forms.Button btnClose;
    }
}