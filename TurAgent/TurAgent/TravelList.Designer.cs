namespace TurAgent
{
    partial class TravelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelList));
            AddRow = new Button();
            PersonalTravelList = new DataGridView();
            Surname = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            PassportNumber = new DataGridViewTextBoxColumn();
            TravelCode = new DataGridViewTextBoxColumn();
            DeleteRow = new Button();
            ChangeButton = new Button();
            SortButton = new Button();
            InvSortCheckBox = new CheckBox();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ResetButton = new Button();
            SortingComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PersonalTravelList).BeginInit();
            SuspendLayout();
            // 
            // AddRow
            // 
            AddRow.BackColor = SystemColors.ControlLightLight;
            AddRow.ForeColor = SystemColors.ControlText;
            AddRow.Location = new Point(36, 420);
            AddRow.Margin = new Padding(5);
            AddRow.Name = "AddRow";
            AddRow.Size = new Size(234, 46);
            AddRow.TabIndex = 1;
            AddRow.Text = "Добавить клиента";
            AddRow.UseVisualStyleBackColor = false;
            AddRow.Click += AddRow_Click;
            // 
            // PersonalTravelList
            // 
            PersonalTravelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PersonalTravelList.BackgroundColor = Color.White;
            PersonalTravelList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonalTravelList.Columns.AddRange(new DataGridViewColumn[] { Surname, Name, MiddleName, PassportNumber, TravelCode });
            PersonalTravelList.Location = new Point(23, 19);
            PersonalTravelList.Margin = new Padding(5);
            PersonalTravelList.Name = "PersonalTravelList";
            PersonalTravelList.ReadOnly = true;
            PersonalTravelList.RowHeadersWidth = 51;
            PersonalTravelList.RowTemplate.Height = 29;
            PersonalTravelList.Size = new Size(989, 381);
            PersonalTravelList.TabIndex = 0;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            Surname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Name
            // 
            Name.HeaderText = "Имя";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "Отчество";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            MiddleName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PassportNumber
            // 
            PassportNumber.HeaderText = "Номер паспорта";
            PassportNumber.MinimumWidth = 6;
            PassportNumber.Name = "PassportNumber";
            PassportNumber.ReadOnly = true;
            PassportNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TravelCode
            // 
            TravelCode.HeaderText = "Код поездки";
            TravelCode.MinimumWidth = 6;
            TravelCode.Name = "TravelCode";
            TravelCode.ReadOnly = true;
            TravelCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteRow
            // 
            DeleteRow.BackColor = SystemColors.ControlLightLight;
            DeleteRow.ForeColor = SystemColors.ControlText;
            DeleteRow.Location = new Point(337, 420);
            DeleteRow.Margin = new Padding(5);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(234, 46);
            DeleteRow.TabIndex = 2;
            DeleteRow.Text = "Удалить клиента";
            DeleteRow.UseVisualStyleBackColor = false;
            DeleteRow.Click += DeleteRow_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.BackColor = SystemColors.ControlLightLight;
            ChangeButton.ForeColor = SystemColors.ControlText;
            ChangeButton.Location = new Point(637, 420);
            ChangeButton.Margin = new Padding(5);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(341, 46);
            ChangeButton.TabIndex = 3;
            ChangeButton.Text = "Изменить данные клиента";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // SortButton
            // 
            SortButton.BackColor = SystemColors.ControlLightLight;
            SortButton.ForeColor = SystemColors.ControlText;
            SortButton.Location = new Point(1034, 92);
            SortButton.Margin = new Padding(5);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(234, 46);
            SortButton.TabIndex = 4;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = false;
            SortButton.Click += SortButton_Click;
            // 
            // InvSortCheckBox
            // 
            InvSortCheckBox.AutoSize = true;
            InvSortCheckBox.BackColor = Color.Transparent;
            InvSortCheckBox.Location = new Point(1278, 98);
            InvSortCheckBox.Margin = new Padding(5);
            InvSortCheckBox.Name = "InvSortCheckBox";
            InvSortCheckBox.Size = new Size(275, 36);
            InvSortCheckBox.TabIndex = 5;
            InvSortCheckBox.Text = "В обратном порядке";
            InvSortCheckBox.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(1043, 189);
            SearchTextBox.Margin = new Padding(5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(201, 39);
            SearchTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ControlLightLight;
            SearchButton.ForeColor = SystemColors.ControlText;
            SearchButton.Location = new Point(1264, 185);
            SearchButton.Margin = new Padding(5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(203, 46);
            SearchButton.TabIndex = 7;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = SystemColors.ControlLightLight;
            ResetButton.ForeColor = SystemColors.ControlText;
            ResetButton.Location = new Point(1264, 241);
            ResetButton.Margin = new Padding(5);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(203, 46);
            ResetButton.TabIndex = 8;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // SortingComboBox
            // 
            SortingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortingComboBox.FormattingEnabled = true;
            SortingComboBox.Items.AddRange(new object[] { "Фамилия", "Имя", "Отчество", "Номер паспорта", "Код поездки" });
            SortingComboBox.Location = new Point(1233, 31);
            SortingComboBox.Margin = new Padding(5);
            SortingComboBox.Name = "SortingComboBox";
            SortingComboBox.Size = new Size(243, 40);
            SortingComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(1034, 34);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 10;
            label1.Text = "Сортировать по";
            // 
            // TravelList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1568, 480);
            Controls.Add(label1);
            Controls.Add(SortingComboBox);
            Controls.Add(ResetButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(InvSortCheckBox);
            Controls.Add(SortButton);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteRow);
            Controls.Add(AddRow);
            Controls.Add(PersonalTravelList);
            Margin = new Padding(5);
            Name = new DataGridViewTextBoxColumn();
            Name.HeaderText = "Имя";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)PersonalTravelList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddRow;
        private DataGridView PersonalTravelList;
        private Button DeleteRow;
        private Button ChangeButton;
        private Button SortButton;
        private CheckBox InvSortCheckBox;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button ResetButton;
        private ComboBox SortingComboBox;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn PassportNumber;
        private DataGridViewTextBoxColumn TravelCode;
        private Label label1;
    }
}