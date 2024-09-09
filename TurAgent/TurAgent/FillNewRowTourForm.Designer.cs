namespace TurAgent
{
    partial class FillNewRowTourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillNewRowTourForm));
            Save = new Button();
            CodeTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            HotelTextBox = new TextBox();
            TransportTextBox = new TextBox();
            PriceTextBox = new TextBox();
            DaysTextBox = new TextBox();
            CodeLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            HotelLabel = new Label();
            TransportLabel = new Label();
            PriceLabel = new Label();
            DaysLabel = new Label();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // Save
            // 
            Save.BackColor = SystemColors.ControlLightLight;
            Save.DialogResult = DialogResult.OK;
            Save.Location = new Point(666, 192);
            Save.Margin = new Padding(5);
            Save.Name = "Save";
            Save.Size = new Size(153, 46);
            Save.TabIndex = 1;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(62, 96);
            CodeTextBox.Margin = new Padding(5);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(201, 39);
            CodeTextBox.TabIndex = 2;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(260, 96);
            CountryTextBox.Margin = new Padding(5);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(201, 39);
            CountryTextBox.TabIndex = 3;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(447, 96);
            CityTextBox.Margin = new Padding(5);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(201, 39);
            CityTextBox.TabIndex = 4;
            // 
            // HotelTextBox
            // 
            HotelTextBox.Location = new Point(644, 96);
            HotelTextBox.Margin = new Padding(5);
            HotelTextBox.Name = "HotelTextBox";
            HotelTextBox.Size = new Size(201, 39);
            HotelTextBox.TabIndex = 5;
            // 
            // TransportTextBox
            // 
            TransportTextBox.Location = new Point(840, 96);
            TransportTextBox.Margin = new Padding(5);
            TransportTextBox.Name = "TransportTextBox";
            TransportTextBox.Size = new Size(201, 39);
            TransportTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(1038, 96);
            PriceTextBox.Margin = new Padding(5);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(201, 39);
            PriceTextBox.TabIndex = 7;
            // 
            // DaysTextBox
            // 
            DaysTextBox.Location = new Point(1237, 96);
            DaysTextBox.Margin = new Padding(5);
            DaysTextBox.Name = "DaysTextBox";
            DaysTextBox.Size = new Size(201, 39);
            DaysTextBox.TabIndex = 8;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.BackColor = Color.Transparent;
            CodeLabel.Location = new Point(119, 59);
            CodeLabel.Margin = new Padding(5, 0, 5, 0);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(55, 32);
            CodeLabel.TabIndex = 9;
            CodeLabel.Text = "Код";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.BackColor = Color.Transparent;
            CountryLabel.Location = new Point(299, 59);
            CountryLabel.Margin = new Padding(5, 0, 5, 0);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(91, 32);
            CountryLabel.TabIndex = 10;
            CountryLabel.Text = "Страна";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.BackColor = Color.Transparent;
            CityLabel.Location = new Point(492, 59);
            CityLabel.Margin = new Padding(5, 0, 5, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(80, 32);
            CityLabel.TabIndex = 11;
            CityLabel.Text = "Город";
            // 
            // HotelLabel
            // 
            HotelLabel.AutoSize = true;
            HotelLabel.BackColor = Color.Transparent;
            HotelLabel.Location = new Point(666, 59);
            HotelLabel.Margin = new Padding(5, 0, 5, 0);
            HotelLabel.Name = "HotelLabel";
            HotelLabel.Size = new Size(128, 32);
            HotelLabel.TabIndex = 12;
            HotelLabel.Text = "Гостиница";
            // 
            // TransportLabel
            // 
            TransportLabel.AutoSize = true;
            TransportLabel.BackColor = Color.Transparent;
            TransportLabel.Location = new Point(879, 59);
            TransportLabel.Margin = new Padding(5, 0, 5, 0);
            TransportLabel.Name = "TransportLabel";
            TransportLabel.Size = new Size(133, 32);
            TransportLabel.TabIndex = 13;
            TransportLabel.Text = "Перевозка";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.BackColor = Color.Transparent;
            PriceLabel.Location = new Point(1067, 59);
            PriceLabel.Margin = new Padding(5, 0, 5, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(127, 32);
            PriceLabel.TabIndex = 14;
            PriceLabel.Text = "Цена (у.е.)";
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.BackColor = Color.Transparent;
            DaysLabel.Location = new Point(1315, 59);
            DaysLabel.Margin = new Padding(5, 0, 5, 0);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(59, 32);
            DaysLabel.TabIndex = 15;
            DaysLabel.Text = "Дни";
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = SystemColors.ControlLightLight;
            ChangeButton.Location = new Point(840, 192);
            ChangeButton.Margin = new Padding(5);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(153, 46);
            ChangeButton.TabIndex = 16;
            ChangeButton.Text = "Изменить";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // FillNewRowTourForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1514, 275);
            Controls.Add(ChangeButton);
            Controls.Add(DaysLabel);
            Controls.Add(PriceLabel);
            Controls.Add(TransportLabel);
            Controls.Add(HotelLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(CodeLabel);
            Controls.Add(DaysTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(TransportTextBox);
            Controls.Add(HotelTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(CodeTextBox);
            Controls.Add(Save);
            Margin = new Padding(5);
            Name = "FillNewRowTourForm";
            Text = "Добавление тура";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Save;
        private TextBox CodeTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox HotelTextBox;
        private TextBox TransportTextBox;
        private TextBox PriceTextBox;
        private TextBox DaysTextBox;
        private Label CodeLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label HotelLabel;
        private Label TransportLabel;
        private Label PriceLabel;
        private Label DaysLabel;
        private Button ChangeButton;
    }
}