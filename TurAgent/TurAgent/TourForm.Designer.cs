namespace TurAgent
{
    partial class TourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourForm));
            TourDataGrid = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Hotel = new DataGridViewTextBoxColumn();
            Расстояние = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            AddRow = new Button();
            DeleteRow = new Button();
            ChangeButton = new Button();
            SortByCode = new Button();
            InversSortCheckBox = new CheckBox();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ResetButton = new Button();
            SortingComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TourDataGrid).BeginInit();
            SuspendLayout();
            // 
            // TourDataGrid
            // 
            TourDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TourDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            TourDataGrid.BackgroundColor = Color.White;
            TourDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TourDataGrid.Columns.AddRange(new DataGridViewColumn[] { Code, Country, City, Hotel, Расстояние, Price, Days });
            TourDataGrid.Location = new Point(20, 19);
            TourDataGrid.Margin = new Padding(5);
            TourDataGrid.Name = "TourDataGrid";
            TourDataGrid.RowHeadersWidth = 51;
            TourDataGrid.RowTemplate.Height = 29;
            TourDataGrid.Size = new Size(930, 463);
            TourDataGrid.TabIndex = 0;
            // 
            // Code
            // 
            Code.HeaderText = "Код";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Country
            // 
            Country.HeaderText = "Страна";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Hotel
            // 
            Hotel.HeaderText = "Гостиница";
            Hotel.MinimumWidth = 6;
            Hotel.Name = "Hotel";
            Hotel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Расстояние
            // 
            Расстояние.HeaderText = "Способ перевозки";
            Расстояние.MinimumWidth = 6;
            Расстояние.Name = "Расстояние";
            Расстояние.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            Price.HeaderText = "Цена";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Days
            // 
            Days.HeaderText = "Дни";
            Days.MinimumWidth = 6;
            Days.Name = "Days";
            Days.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AddRow
            // 
            AddRow.BackColor = SystemColors.ControlLightLight;
            AddRow.Location = new Point(960, 426);
            AddRow.Margin = new Padding(5);
            AddRow.Name = "AddRow";
            AddRow.Size = new Size(236, 56);
            AddRow.TabIndex = 1;
            AddRow.Text = "Добавить тур";
            AddRow.UseVisualStyleBackColor = false;
            AddRow.Click += AddRow_Click;
            // 
            // DeleteRow
            // 
            DeleteRow.BackColor = SystemColors.ControlLightLight;
            DeleteRow.Location = new Point(1474, 426);
            DeleteRow.Margin = new Padding(5);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(236, 56);
            DeleteRow.TabIndex = 2;
            DeleteRow.Text = "Удалить тур";
            DeleteRow.UseVisualStyleBackColor = false;
            DeleteRow.Click += DeleteRow_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = SystemColors.ControlLightLight;
            ChangeButton.Location = new Point(1215, 426);
            ChangeButton.Margin = new Padding(5);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(238, 56);
            ChangeButton.TabIndex = 3;
            ChangeButton.Text = "Изменить тур";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // SortByCode
            // 
            SortByCode.BackColor = SystemColors.ControlLightLight;
            SortByCode.Location = new Point(981, 113);
            SortByCode.Margin = new Padding(5);
            SortByCode.Name = "SortByCode";
            SortByCode.Size = new Size(245, 46);
            SortByCode.TabIndex = 4;
            SortByCode.Text = "Сортировать";
            SortByCode.UseVisualStyleBackColor = false;
            SortByCode.Click += SortByCode_Click;
            // 
            // InversSortCheckBox
            // 
            InversSortCheckBox.AutoSize = true;
            InversSortCheckBox.BackColor = Color.Transparent;
            InversSortCheckBox.Location = new Point(1246, 119);
            InversSortCheckBox.Margin = new Padding(5);
            InversSortCheckBox.Name = "InversSortCheckBox";
            InversSortCheckBox.Size = new Size(275, 36);
            InversSortCheckBox.TabIndex = 6;
            InversSortCheckBox.Text = "В обратном порядке";
            InversSortCheckBox.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(981, 242);
            SearchTextBox.Margin = new Padding(5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(215, 39);
            SearchTextBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ControlLightLight;
            SearchButton.Location = new Point(1215, 238);
            SearchButton.Margin = new Padding(5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(218, 46);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = SystemColors.ControlLightLight;
            ResetButton.Location = new Point(1456, 238);
            ResetButton.Margin = new Padding(5);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(218, 46);
            ResetButton.TabIndex = 9;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // SortingComboBox
            // 
            SortingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortingComboBox.FormattingEnabled = true;
            SortingComboBox.Items.AddRange(new object[] { "Код", "Страна", "Город", "Гостинница", "Способ перевозки", "Цена", "Дни" });
            SortingComboBox.Location = new Point(1190, 48);
            SortingComboBox.Margin = new Padding(5);
            SortingComboBox.Name = "SortingComboBox";
            SortingComboBox.Size = new Size(243, 40);
            SortingComboBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(981, 48);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 11;
            label1.Text = "Сортировать по";
            // 
            // TourForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1729, 502);
            Controls.Add(label1);
            Controls.Add(SortingComboBox);
            Controls.Add(ResetButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(InversSortCheckBox);
            Controls.Add(SortByCode);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteRow);
            Controls.Add(AddRow);
            Controls.Add(TourDataGrid);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "TourForm";
            Text = "Информация о турах";
            ((System.ComponentModel.ISupportInitialize)TourDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddRow;
        private Button DeleteRow;
        private DataGridView TourDataGrid;
        private Button ChangeButton;
        private Button SortByCode;
        private CheckBox InversSortCheckBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button ResetButton;
        private ComboBox SortingComboBox;
        private Label label1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Hotel;
        private DataGridViewTextBoxColumn Расстояние;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Days;
    }
}