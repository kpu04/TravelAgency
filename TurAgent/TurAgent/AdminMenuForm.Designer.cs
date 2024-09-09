namespace TurAgent
{
    partial class AdminMenuForm
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

        private Button Tours;
        private Button WorkWithAccountsButton;
        private Button WorkJournalButton;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            Tours = new Button();
            WorkWithAccountsButton = new Button();
            WorkJournalButton = new Button();
            SuspendLayout();
            // 
            // Tours
            // 
            Tours.BackColor = SystemColors.ControlLightLight;
            Tours.Location = new Point(83, 51);
            Tours.Margin = new Padding(5);
            Tours.Name = "Tours";
            Tours.Size = new Size(328, 46);
            Tours.TabIndex = 0;
            Tours.Text = "Туристические поездки";
            Tours.UseVisualStyleBackColor = false;
            Tours.Click += Tours_Click;
            // 
            // WorkWithAccountsButton
            // 
            WorkWithAccountsButton.BackColor = SystemColors.ControlLightLight;
            WorkWithAccountsButton.Location = new Point(83, 192);
            WorkWithAccountsButton.Margin = new Padding(5);
            WorkWithAccountsButton.Name = "WorkWithAccountsButton";
            WorkWithAccountsButton.Size = new Size(328, 46);
            WorkWithAccountsButton.TabIndex = 1;
            WorkWithAccountsButton.Text = "Аккаунты";
            WorkWithAccountsButton.UseVisualStyleBackColor = false;
            WorkWithAccountsButton.Click += WorkWithAccountsButton_Click;
            // 
            // WorkJournalButton
            // 
            WorkJournalButton.BackColor = SystemColors.ControlLightLight;
            WorkJournalButton.Location = new Point(86, 122);
            WorkJournalButton.Margin = new Padding(5);
            WorkJournalButton.Name = "WorkJournalButton";
            WorkJournalButton.Size = new Size(325, 46);
            WorkJournalButton.TabIndex = 2;
            WorkJournalButton.Text = "Клиенты";
            WorkJournalButton.UseVisualStyleBackColor = false;
            WorkJournalButton.Click += WorkJournalButton_Click;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(526, 312);
            Controls.Add(WorkJournalButton);
            Controls.Add(WorkWithAccountsButton);
            Controls.Add(Tours);
            Margin = new Padding(5);
            Name = "AdminMenuForm";
            Text = "Меню администратора";
            ResumeLayout(false);
        }

        #endregion///
        ///

    }
}