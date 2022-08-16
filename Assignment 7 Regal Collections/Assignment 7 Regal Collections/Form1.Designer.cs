
namespace Assignment_7_Regal_Collections
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFindInvoice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindInvoice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnRemoveCancel = new System.Windows.Forms.Button();
            this.btnTotalInvoices = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cboInvoiceNumber = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // btnFindInvoice
            // 
            this.btnFindInvoice.Location = new System.Drawing.Point(130, 60);
            this.btnFindInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindInvoice.Name = "btnFindInvoice";
            this.btnFindInvoice.Size = new System.Drawing.Size(246, 30);
            this.btnFindInvoice.TabIndex = 2;
            this.btnFindInvoice.Text = "Find Invoice";
            this.btnFindInvoice.UseVisualStyleBackColor = true;
            this.btnFindInvoice.Click += new System.EventHandler(this.btnFindInvoice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Find Invoice #:";
            // 
            // txtFindInvoice
            // 
            this.txtFindInvoice.Location = new System.Drawing.Point(130, 29);
            this.txtFindInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindInvoice.Name = "txtFindInvoice";
            this.txtFindInvoice.Size = new System.Drawing.Size(246, 23);
            this.txtFindInvoice.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 100);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(246, 23);
            this.txtID.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(158, 160);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(246, 23);
            this.txtDate.TabIndex = 7;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(158, 220);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(246, 23);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(412, 36);
            this.btnAddSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(100, 30);
            this.btnAddSave.TabIndex = 9;
            this.btnAddSave.Text = "Add";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnRemoveCancel
            // 
            this.btnRemoveCancel.Location = new System.Drawing.Point(412, 96);
            this.btnRemoveCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCancel.Name = "btnRemoveCancel";
            this.btnRemoveCancel.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveCancel.TabIndex = 10;
            this.btnRemoveCancel.Text = "Remove";
            this.btnRemoveCancel.UseVisualStyleBackColor = true;
            this.btnRemoveCancel.Click += new System.EventHandler(this.btnRemoveCancel_Click);
            // 
            // btnTotalInvoices
            // 
            this.btnTotalInvoices.Location = new System.Drawing.Point(412, 156);
            this.btnTotalInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalInvoices.Name = "btnTotalInvoices";
            this.btnTotalInvoices.Size = new System.Drawing.Size(100, 30);
            this.btnTotalInvoices.TabIndex = 11;
            this.btnTotalInvoices.Text = "Total Invoices";
            this.btnTotalInvoices.UseVisualStyleBackColor = true;
            this.btnTotalInvoices.Click += new System.EventHandler(this.btnTotalInvoices_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(412, 216);
            this.btnDisplayAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(100, 30);
            this.btnDisplayAll.TabIndex = 12;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(523, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tlExit
            // 
            this.tlExit.Name = "tlExit";
            this.tlExit.Size = new System.Drawing.Size(93, 22);
            this.tlExit.Text = "Exit";
            this.tlExit.Click += new System.EventHandler(this.tlExit_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnFindInvoice);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.txtFindInvoice);
            this.grpSearch.Location = new System.Drawing.Point(28, 254);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearch.Size = new System.Drawing.Size(385, 132);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // cboInvoiceNumber
            // 
            this.cboInvoiceNumber.FormattingEnabled = true;
            this.cboInvoiceNumber.Location = new System.Drawing.Point(158, 40);
            this.cboInvoiceNumber.Name = "cboInvoiceNumber";
            this.cboInvoiceNumber.Size = new System.Drawing.Size(246, 25);
            this.cboInvoiceNumber.TabIndex = 15;
            this.cboInvoiceNumber.SelectedIndexChanged += new System.EventHandler(this.cboInvoiceNumber_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 411);
            this.Controls.Add(this.cboInvoiceNumber);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnTotalInvoices);
            this.Controls.Add(this.btnRemoveCancel);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFindInvoice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnRemoveCancel;
        private System.Windows.Forms.Button btnTotalInvoices;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlExit;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cboInvoiceNumber;
    }
}

