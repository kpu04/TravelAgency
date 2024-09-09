namespace TurAgent
{
    partial class AuthorisationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorisationForm));
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            Enter = new Button();
            CreateAccountLinkLabel = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(373, 285);
            LoginTextBox.Margin = new Padding(5);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(201, 39);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(373, 398);
            PasswordTextBox.Margin = new Padding(5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(201, 39);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(369, 228);
            LoginLabel.Margin = new Padding(5, 0, 5, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(209, 40);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Введите логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(362, 346);
            PasswordLabel.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(228, 40);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Введите пароль";
            // 
            // Enter
            // 
            Enter.BackColor = SystemColors.ControlLightLight;
            Enter.Location = new Point(399, 459);
            Enter.Margin = new Padding(5);
            Enter.Name = "Enter";
            Enter.Size = new Size(153, 46);
            Enter.TabIndex = 4;
            Enter.Text = "Войти";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // CreateAccountLinkLabel
            // 
            CreateAccountLinkLabel.AutoSize = true;
            CreateAccountLinkLabel.BackColor = Color.White;
            CreateAccountLinkLabel.Location = new Point(386, 545);
            CreateAccountLinkLabel.Margin = new Padding(5, 0, 5, 0);
            CreateAccountLinkLabel.Name = "CreateAccountLinkLabel";
            CreateAccountLinkLabel.Size = new Size(192, 32);
            CreateAccountLinkLabel.TabIndex = 5;
            CreateAccountLinkLabel.TabStop = true;
            CreateAccountLinkLabel.Text = "Создать аккаунт";
            CreateAccountLinkLabel.LinkClicked += CreateAccountLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(915, 135);
            label1.TabIndex = 6;
            label1.Text = "Вас приветствует туристическое агенство PnP travel! \r\nПожалуйста, войдите в аккаунт для дальнейшей работы\r\nс нашими ресурсами =)\r\n";
            // 
            // AuthorisationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(929, 646);
            Controls.Add(label1);
            Controls.Add(CreateAccountLinkLabel);
            Controls.Add(Enter);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "AuthorisationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button Enter;
        private LinkLabel CreateAccountLinkLabel;
        private Label label1;
    }
}