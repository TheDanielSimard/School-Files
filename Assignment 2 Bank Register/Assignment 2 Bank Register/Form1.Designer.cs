
namespace Assignment_2_Bank_Register
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.txt_deposit = new System.Windows.Forms.TextBox();
            this.txt_withdrawl = new System.Windows.Forms.TextBox();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.lbl_withdrawl = new System.Windows.Forms.Label();
            this.lbl_starting = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_starting = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(61, 276);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update Account";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(61, 305);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(150, 23);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(217, 305);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(327, 276);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(150, 23);
            this.btn_display.TabIndex = 3;
            this.btn_display.Text = "Display Register";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // txt_deposit
            // 
            this.txt_deposit.Location = new System.Drawing.Point(61, 250);
            this.txt_deposit.Name = "txt_deposit";
            this.txt_deposit.Size = new System.Drawing.Size(72, 20);
            this.txt_deposit.TabIndex = 4;
            // 
            // txt_withdrawl
            // 
            this.txt_withdrawl.Location = new System.Drawing.Point(139, 250);
            this.txt_withdrawl.Name = "txt_withdrawl";
            this.txt_withdrawl.Size = new System.Drawing.Size(72, 20);
            this.txt_withdrawl.TabIndex = 5;
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(76, 234);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(43, 13);
            this.lbl_deposit.TabIndex = 6;
            this.lbl_deposit.Text = "Deposit";
            // 
            // lbl_withdrawl
            // 
            this.lbl_withdrawl.AutoSize = true;
            this.lbl_withdrawl.Location = new System.Drawing.Point(148, 234);
            this.lbl_withdrawl.Name = "lbl_withdrawl";
            this.lbl_withdrawl.Size = new System.Drawing.Size(54, 13);
            this.lbl_withdrawl.TabIndex = 7;
            this.lbl_withdrawl.Text = "Withdrawl";
            // 
            // lbl_starting
            // 
            this.lbl_starting.AutoSize = true;
            this.lbl_starting.Location = new System.Drawing.Point(76, 181);
            this.lbl_starting.Name = "lbl_starting";
            this.lbl_starting.Size = new System.Drawing.Size(82, 13);
            this.lbl_starting.TabIndex = 8;
            this.lbl_starting.Text = "Starting Deposit";
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(76, 128);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(87, 13);
            this.lbl_account.TabIndex = 9;
            this.lbl_account.Text = "Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // txt_starting
            // 
            this.txt_starting.Location = new System.Drawing.Point(164, 178);
            this.txt_starting.Name = "txt_starting";
            this.txt_starting.Size = new System.Drawing.Size(75, 20);
            this.txt_starting.TabIndex = 11;
            // 
            // txt_account
            // 
            this.txt_account.Location = new System.Drawing.Point(164, 125);
            this.txt_account.Name = "txt_account";
            this.txt_account.ReadOnly = true;
            this.txt_account.Size = new System.Drawing.Size(75, 20);
            this.txt_account.TabIndex = 12;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(164, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(75, 20);
            this.txt_name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            // 
            // txt_display
            // 
            this.txt_display.Location = new System.Drawing.Point(245, 27);
            this.txt_display.Multiline = true;
            this.txt_display.Name = "txt_display";
            this.txt_display.ReadOnly = true;
            this.txt_display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_display.Size = new System.Drawing.Size(315, 243);
            this.txt_display.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Banking Register";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(77, 181);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(46, 13);
            this.lbl_balance.TabIndex = 18;
            this.lbl_balance.Text = "Balance";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(164, 178);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(75, 20);
            this.txt_balance.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 354);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.txt_starting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_starting);
            this.Controls.Add(this.lbl_withdrawl);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.txt_withdrawl);
            this.Controls.Add(this.txt_deposit);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_update);
            this.Name = "Form1";
            this.Text = "Bank Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_deposit;
        private System.Windows.Forms.TextBox txt_withdrawl;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label lbl_withdrawl;
        private System.Windows.Forms.Label lbl_starting;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_starting;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.TextBox txt_balance;
    }
}

