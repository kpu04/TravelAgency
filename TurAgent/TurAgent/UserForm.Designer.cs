namespace TurAgent
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            TourInfo = new Button();
            ComeBack = new Button();
            HelpButton = new Button();
            SuspendLayout();
            // 
            // TourInfo
            // 
            TourInfo.BackColor = SystemColors.ControlLightLight;
            TourInfo.Location = new Point(77, 80);
            TourInfo.Margin = new Padding(5);
            TourInfo.Name = "TourInfo";
            TourInfo.Size = new Size(335, 46);
            TourInfo.TabIndex = 0;
            TourInfo.Text = "Информация о турах";
            TourInfo.UseVisualStyleBackColor = false;
            TourInfo.Click += TourInfo_Click;
            // 
            // ComeBack
            // 
            ComeBack.BackColor = SystemColors.ControlLightLight;
            ComeBack.Location = new Point(77, 268);
            ComeBack.Margin = new Padding(5);
            ComeBack.Name = "ComeBack";
            ComeBack.Size = new Size(335, 46);
            ComeBack.TabIndex = 1;
            ComeBack.Text = "Выйти из аккаунта";
            ComeBack.UseVisualStyleBackColor = false;
            ComeBack.Click += ComeBack_Click;
            // 
            // HelpButton
            // 
            HelpButton.BackColor = SystemColors.ControlLightLight;
            HelpButton.Location = new Point(77, 150);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(335, 46);
            HelpButton.TabIndex = 2;
            HelpButton.Text = "Техническая поддержка";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(487, 398);
            Controls.Add(HelpButton);
            Controls.Add(ComeBack);
            Controls.Add(TourInfo);
            Margin = new Padding(5);
            Name = "UserForm";
            Text = "Меню пользователя";
            ResumeLayout(false);
        }

        #endregion

        private Button TourInfo;
        private Button ComeBack;
        private Button HelpButton;
    }
}