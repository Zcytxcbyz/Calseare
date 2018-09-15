namespace Calseare
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.textsign = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonsign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textsign
            // 
            this.textsign.Location = new System.Drawing.Point(78, 12);
            this.textsign.Name = "textsign";
            this.textsign.PasswordChar = '*';
            this.textsign.Size = new System.Drawing.Size(100, 21);
            this.textsign.TabIndex = 0;
            this.textsign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsign_KeyDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(19, 15);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 12);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // buttonsign
            // 
            this.buttonsign.Location = new System.Drawing.Point(78, 39);
            this.buttonsign.Name = "buttonsign";
            this.buttonsign.Size = new System.Drawing.Size(75, 23);
            this.buttonsign.TabIndex = 2;
            this.buttonsign.Text = "Sign in";
            this.buttonsign.UseVisualStyleBackColor = true;
            this.buttonsign.Click += new System.EventHandler(this.buttonsign_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 71);
            this.Controls.Add(this.buttonsign);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textsign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsign;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonsign;
    }
}