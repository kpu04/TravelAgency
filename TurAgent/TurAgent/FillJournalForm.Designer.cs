namespace TurAgent
{
    partial class FillJournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillJournalForm));
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            PatronymicTextBox = new TextBox();
            PassporNumTextBox = new TextBox();
            TourCodeTextBox = new TextBox();
            SurnameLabel = new Label();
            NameLabel = new Label();
            PatronymicLabel = new Label();
            PassportNumLabel = new Label();
            CodeOfTour = new Label();
            SaveButton = new Button();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(20, 123);
            SurnameTextBox.Margin = new Padding(5);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(201, 39);
            SurnameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(218, 123);
            NameTextBox.Margin = new Padding(5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(201, 39);
            NameTextBox.TabIndex = 1;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(416, 123);
            PatronymicTextBox.Margin = new Padding(5);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(201, 39);
            PatronymicTextBox.TabIndex = 2;
            // 
            // PassporNumTextBox
            // 
            PassporNumTextBox.Location = new Point(614, 123);
            PassporNumTextBox.Margin = new Padding(5);
            PassporNumTextBox.Name = "PassporNumTextBox";
            PassporNumTextBox.Size = new Size(201, 39);
            PassporNumTextBox.TabIndex = 3;
            // 
            // TourCodeTextBox
            // 
            TourCodeTextBox.Location = new Point(812, 123);
            TourCodeTextBox.Margin = new Padding(5);
            TourCodeTextBox.Name = "TourCodeTextBox";
            TourCodeTextBox.Size = new Size(201, 39);
            TourCodeTextBox.TabIndex = 4;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.BackColor = Color.Transparent;
            SurnameLabel.Location = new Point(54, 85);
            SurnameLabel.Margin = new Padding(5, 0, 5, 0);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(113, 32);
            SurnameLabel.TabIndex = 5;
            SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Location = new Point(276, 86);
            NameLabel.Margin = new Padding(5, 0, 5, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(61, 32);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Имя";
            // 
            // PatronymicLabel
            // 
            PatronymicLabel.AutoSize = true;
            PatronymicLabel.BackColor = Color.Transparent;
            PatronymicLabel.Location = new Point(457, 85);
            PatronymicLabel.Margin = new Padding(5, 0, 5, 0);
            PatronymicLabel.Name = "PatronymicLabel";
            PatronymicLabel.Size = new Size(117, 32);
            PatronymicLabel.TabIndex = 7;
            PatronymicLabel.Text = "Отчество";
            // 
            // PassportNumLabel
            // 
            PassportNumLabel.AutoSize = true;
            PassportNumLabel.BackColor = Color.Transparent;
            PassportNumLabel.Location = new Point(613, 86);
            PassportNumLabel.Margin = new Padding(5, 0, 5, 0);
            PassportNumLabel.Name = "PassportNumLabel";
            PassportNumLabel.Size = new Size(197, 32);
            PassportNumLabel.TabIndex = 8;
            PassportNumLabel.Text = "Номер паспорта";
            // 
            // CodeOfTour
            // 
            CodeOfTour.AutoSize = true;
            CodeOfTour.BackColor = Color.Transparent;
            CodeOfTour.Location = new Point(845, 85);
            CodeOfTour.Margin = new Padding(5, 0, 5, 0);
            CodeOfTour.Name = "CodeOfTour";
            CodeOfTour.Size = new Size(110, 32);
            CodeOfTour.TabIndex = 9;
            CodeOfTour.Text = "Код тура";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.ControlLightLight;
            SaveButton.DialogResult = DialogResult.OK;
            SaveButton.Location = new Point(343, 184);
            SaveButton.Margin = new Padding(5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(159, 46);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = SystemColors.ControlLightLight;
            ChangeButton.DialogResult = DialogResult.OK;
            ChangeButton.Location = new Point(512, 184);
            ChangeButton.Margin = new Padding(5);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(153, 46);
            ChangeButton.TabIndex = 11;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // FillJournalForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1042, 306);
            Controls.Add(ChangeButton);
            Controls.Add(SaveButton);
            Controls.Add(CodeOfTour);
            Controls.Add(PassportNumLabel);
            Controls.Add(PatronymicLabel);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            Controls.Add(TourCodeTextBox);
            Controls.Add(PassporNumTextBox);
            Controls.Add(PatronymicTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(SurnameTextBox);
            Margin = new Padding(5);
            Name = "FillJournalForm";
            Text = "Заказ путёвки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private TextBox PatronymicTextBox;
        private TextBox PassporNumTextBox;
        private TextBox TourCodeTextBox;
        private Label SurnameLabel;
        private Label NameLabel;
        private Label PatronymicLabel;
        private Label PassportNumLabel;
        private Label CodeOfTour;
        private Button SaveButton;
        private Button ChangeButton;
    }
}