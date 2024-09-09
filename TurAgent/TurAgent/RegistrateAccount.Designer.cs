namespace TurAgent
{
    partial class RegistrateAccount
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
            RegistrateButton = new Button();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // RegistrateButton
            // 
            RegistrateButton.BackColor = SystemColors.ControlLightLight;
            RegistrateButton.DialogResult = DialogResult.OK;
            RegistrateButton.Location = new Point(121, 328);
            RegistrateButton.Margin = new Padding(5);
            RegistrateButton.Name = "RegistrateButton";
            RegistrateButton.Size = new Size(239, 46);
            RegistrateButton.TabIndex = 0;
            RegistrateButton.Text = "Зарегистрировать";
            RegistrateButton.UseVisualStyleBackColor = false;
            RegistrateButton.Click += RegistrateButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(121, 266);
            PasswordTextBox.Margin = new Padding(5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(233, 39);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(122, 162);
            LoginTextBox.Margin = new Padding(5);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(236, 39);
            LoginTextBox.TabIndex = 2;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.Location = new Point(97, 117);
            LoginLabel.Margin = new Padding(5, 0, 5, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(276, 40);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "Введите ваш логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(122, 221);
            PasswordLabel.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(232, 40);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Введите пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 46);
            label1.Name = "label1";
            label1.Size = new Size(363, 45);
            label1.TabIndex = 5;
            label1.Text = "Регистрация аккаунта";
            // 
            // RegistrateAccount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 398);
            Controls.Add(label1);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(RegistrateButton);
            Margin = new Padding(5);
            Name = "RegistrateAccount";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrateButton;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label label1;
    }
}