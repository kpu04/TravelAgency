namespace TurAgent
{
    partial class FillAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillAccountForm));
            LogimTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RoleTextBox = new TextBox();
            RoleLabel = new Label();
            AddAccount = new Button();
            ChangeAccount = new Button();
            SuspendLayout();
            // 
            // LogimTextBox
            // 
            LogimTextBox.Location = new Point(65, 90);
            LogimTextBox.Margin = new Padding(5);
            LogimTextBox.Name = "LogimTextBox";
            LogimTextBox.Size = new Size(201, 39);
            LogimTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(263, 90);
            PasswordTextBox.Margin = new Padding(5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(201, 39);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Location = new Point(135, 53);
            LoginLabel.Margin = new Padding(5, 0, 5, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(81, 32);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Location = new Point(320, 53);
            PasswordLabel.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(96, 32);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Пароль";
            // 
            // RoleTextBox
            // 
            RoleTextBox.Location = new Point(462, 90);
            RoleTextBox.Margin = new Padding(5);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(201, 39);
            RoleTextBox.TabIndex = 4;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.BackColor = Color.Transparent;
            RoleLabel.Location = new Point(526, 53);
            RoleLabel.Margin = new Padding(5, 0, 5, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(66, 32);
            RoleLabel.TabIndex = 5;
            RoleLabel.Text = "Роль";
            // 
            // AddAccount
            // 
            AddAccount.BackColor = SystemColors.ControlLightLight;
            AddAccount.DialogResult = DialogResult.OK;
            AddAccount.Location = new Point(179, 162);
            AddAccount.Margin = new Padding(5);
            AddAccount.Name = "AddAccount";
            AddAccount.Size = new Size(153, 46);
            AddAccount.TabIndex = 6;
            AddAccount.Text = "Сохранить";
            AddAccount.UseVisualStyleBackColor = false;
            AddAccount.Click += AddAccount_Click;
            // 
            // ChangeAccount
            // 
            ChangeAccount.BackColor = SystemColors.ControlLightLight;
            ChangeAccount.DialogResult = DialogResult.OK;
            ChangeAccount.Location = new Point(379, 162);
            ChangeAccount.Margin = new Padding(5);
            ChangeAccount.Name = "ChangeAccount";
            ChangeAccount.Size = new Size(153, 46);
            ChangeAccount.TabIndex = 7;
            ChangeAccount.Text = "Изменить";
            ChangeAccount.UseVisualStyleBackColor = false;
            ChangeAccount.Click += ChangeAccount_Click;
            // 
            // FillAccountForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(717, 274);
            Controls.Add(ChangeAccount);
            Controls.Add(AddAccount);
            Controls.Add(RoleLabel);
            Controls.Add(RoleTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LogimTextBox);
            Margin = new Padding(5);
            Name = "FillAccountForm";
            Text = "Добавление аккаунта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogimTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox RoleTextBox;
        private Label RoleLabel;
        private Button AddAccount;
        private Button ChangeAccount;
    }
}