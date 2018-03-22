namespace VKPlayer
{
    partial class Login
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
            this.vkLogin = new System.Windows.Forms.TextBox();
            this.vkPass = new System.Windows.Forms.TextBox();
            this.buttLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vkLogin
            // 
            this.vkLogin.Location = new System.Drawing.Point(88, 83);
            this.vkLogin.Name = "vkLogin";
            this.vkLogin.Size = new System.Drawing.Size(100, 20);
            this.vkLogin.TabIndex = 0;
            // 
            // vkPass
            // 
            this.vkPass.Location = new System.Drawing.Point(88, 121);
            this.vkPass.Name = "vkPass";
            this.vkPass.Size = new System.Drawing.Size(100, 20);
            this.vkPass.TabIndex = 1;
            // 
            // buttLogin
            // 
            this.buttLogin.Location = new System.Drawing.Point(88, 159);
            this.buttLogin.Name = "buttLogin";
            this.buttLogin.Size = new System.Drawing.Size(100, 23);
            this.buttLogin.TabIndex = 2;
            this.buttLogin.Text = "Войти";
            this.buttLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttLogin);
            this.Controls.Add(this.vkPass);
            this.Controls.Add(this.vkLogin);
            this.Name = "Login";
            this.Text = "Авторизация VK.com";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vkLogin;
        private System.Windows.Forms.TextBox vkPass;
        private System.Windows.Forms.Button buttLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}