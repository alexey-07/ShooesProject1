namespace ProjectMain
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbImage = new PictureBox();
            panelMain = new Panel();
            txtPassword = new TextBox();
            lbPassword = new Label();
            lbLogin = new Label();
            btnGuest = new Button();
            btnLogin = new Button();
            txtLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Image = (Image)resources.GetObject("pbImage.Image");
            pbImage.Location = new Point(139, 12);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(120, 90);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(txtLogin);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(lbPassword);
            panelMain.Controls.Add(lbLogin);
            panelMain.Controls.Add(btnGuest);
            panelMain.Controls.Add(btnLogin);
            panelMain.Location = new Point(35, 108);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(315, 226);
            panelMain.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(133, 78);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(58, 19);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Пароль";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(136, 11);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Логин";
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.Chartreuse;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(81, 176);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(170, 30);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(81, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 30);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(81, 33);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(170, 26);
            txtLogin.TabIndex = 5;
            txtLogin.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(panelMain);
            Controls.Add(pbImage);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Panel panelMain;
        private TextBox textBox2;
        private TextBox txtPassword;
        private Label lbPassword;
        private Label lbLogin;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtLogin;
    }
}