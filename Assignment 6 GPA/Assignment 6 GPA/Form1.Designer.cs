
namespace Assignment_6_GPA
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
            this.Points = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnLambdaExpression = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(12, 27);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(36, 13);
            this.Points.TabIndex = 0;
            this.Points.Text = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(95, 24);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 20);
            this.txtPoints.TabIndex = 3;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(95, 80);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 20);
            this.txtCredits.TabIndex = 4;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(48, 136);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(180, 113);
            this.txtDisplay.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 307);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(40, 350);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(155, 23);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(249, 22);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(155, 23);
            this.btnInterface.TabIndex = 8;
            this.btnInterface.Text = "Using Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(249, 81);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(155, 23);
            this.btnDelegate.TabIndex = 9;
            this.btnDelegate.Text = "Using Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnLambdaExpression
            // 
            this.btnLambdaExpression.Location = new System.Drawing.Point(249, 140);
            this.btnLambdaExpression.Name = "btnLambdaExpression";
            this.btnLambdaExpression.Size = new System.Drawing.Size(155, 48);
            this.btnLambdaExpression.TabIndex = 10;
            this.btnLambdaExpression.Text = "Lambda Expression\r\ntrue.false\r\n";
            this.btnLambdaExpression.UseVisualStyleBackColor = true;
            this.btnLambdaExpression.Click += new System.EventHandler(this.btnLambdaExpression_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(249, 224);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(155, 23);
            this.btnLambda.TabIndex = 11;
            this.btnLambda.Text = "Using Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnLambdaExpression);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Points);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnLambdaExpression;
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnExit;
    }
}

