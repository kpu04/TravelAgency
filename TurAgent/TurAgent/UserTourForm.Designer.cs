namespace TurAgent
{
    partial class UserTourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTourForm));
            TourDataGrid = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Hotel = new DataGridViewTextBoxColumn();
            Расстояние = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ResetButton = new Button();
            SortByCode = new Button();
            InversSortCheckBox = new CheckBox();
            Order = new Button();
            SortingComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TourDataGrid).BeginInit();
            SuspendLayout();
            // 
            // TourDataGrid
            // 
            TourDataGrid.BackgroundColor = Color.White;
            TourDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TourDataGrid.Columns.AddRange(new DataGridViewColumn[] { Code, Country, City, Hotel, Расстояние, Price, Days });
            TourDataGrid.Location = new Point(30, 25);
            TourDataGrid.Margin = new Padding(5);
            TourDataGrid.Name = "TourDataGrid";
            TourDataGrid.RowHeadersWidth = 51;
            TourDataGrid.RowTemplate.Height = 29;
            TourDataGrid.Size = new Size(931, 486);
            TourDataGrid.TabIndex = 1;
            // 
            // Code
            // 
            Code.HeaderText = "Код";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.Width = 125;
            // 
            // Country
            // 
            Country.HeaderText = "Страна";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.Width = 125;
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // Hotel
            // 
            Hotel.HeaderText = "Гостиница";
            Hotel.MinimumWidth = 6;
            Hotel.Name = "Hotel";
            Hotel.Width = 125;
            // 
            // Расстояние
            // 
            Расстояние.HeaderText = "Способ перевозки";
            Расстояние.MinimumWidth = 6;
            Расстояние.Name = "Расстояние";
            Расстояние.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Days
            // 
            Days.HeaderText = "Дни";
            Days.MinimumWidth = 6;
            Days.Name = "Days";
            Days.Width = 125;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(985, 200);
            SearchTextBox.Margin = new Padding(5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(215, 39);
            SearchTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ControlLightLight;
            SearchButton.Location = new Point(1222, 195);
            SearchButton.Margin = new Padding(5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(271, 51);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = SystemColors.ControlLightLight;
            ResetButton.Location = new Point(1222, 267);
            ResetButton.Margin = new Padding(5);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(271, 46);
            ResetButton.TabIndex = 10;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // SortByCode
            // 
            SortByCode.BackColor = SystemColors.ControlLightLight;
            SortByCode.Location = new Point(1015, 89);
            SortByCode.Margin = new Padding(5);
            SortByCode.Name = "SortByCode";
            SortByCode.Size = new Size(271, 46);
            SortByCode.TabIndex = 11;
            SortByCode.Text = "Сортировать";
            SortByCode.UseVisualStyleBackColor = false;
            SortByCode.Click += SortByCode_Click;
            // 
            // InversSortCheckBox
            // 
            InversSortCheckBox.AutoSize = true;
            InversSortCheckBox.BackColor = Color.Transparent;
            InversSortCheckBox.Location = new Point(1313, 95);
            InversSortCheckBox.Margin = new Padding(5);
            InversSortCheckBox.Name = "InversSortCheckBox";
            InversSortCheckBox.Size = new Size(275, 36);
            InversSortCheckBox.TabIndex = 12;
            InversSortCheckBox.Text = "В обратном порядке";
            InversSortCheckBox.UseVisualStyleBackColor = false;
            // 
            // Order
            // 
            Order.BackColor = SystemColors.ControlLightLight;
            Order.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Order.Location = new Point(1276, 441);
            Order.Margin = new Padding(5);
            Order.Name = "Order";
            Order.Size = new Size(326, 57);
            Order.TabIndex = 13;
            Order.Text = "Заказать путёвку!";
            Order.UseVisualStyleBackColor = false;
            Order.Click += Order_Click;
            // 
            // SortingComboBox
            // 
            SortingComboBox.FormattingEnabled = true;
            SortingComboBox.Items.AddRange(new object[] { "Код", "Страна", "Город", "Гостинница", "Способ перевозки", "Цена", "Дни" });
            SortingComboBox.Location = new Point(1233, 25);
            SortingComboBox.Margin = new Padding(5);
            SortingComboBox.Name = "SortingComboBox";
            SortingComboBox.Size = new Size(243, 40);
            SortingComboBox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(1015, 25);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Сортировать по";
            // 
            // UserTourForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1616, 525);
            Controls.Add(label1);
            Controls.Add(SortingComboBox);
            Controls.Add(Order);
            Controls.Add(InversSortCheckBox);
            Controls.Add(SortByCode);
            Controls.Add(ResetButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(TourDataGrid);
            Margin = new Padding(5);
            Name = "UserTourForm";
            Text = "Информация о турах";
            ((System.ComponentModel.ISupportInitialize)TourDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TourDataGrid;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Hotel;
        private DataGridViewTextBoxColumn Расстояние;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Days;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button ResetButton;
        private Button SortByCode;
        private CheckBox InversSortCheckBox;
        private Button Order;
        private ComboBox SortingComboBox;
        private Label label1;
    }
}