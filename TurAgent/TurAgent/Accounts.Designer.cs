namespace TurAgent
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            AccountsGridView = new DataGridView();
            AddAccount = new Button();
            DeleteAccount = new Button();
            ChangeAccount = new Button();
            SortButton = new Button();
            SortComboBox = new ComboBox();
            InverseCheckBox = new CheckBox();
            SearchTextBox = new TextBox();
            Search = new Button();
            Reset = new Button();
            label1 = new Label();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)AccountsGridView).BeginInit();
            SuspendLayout();
            // 
            // AccountsGridView
            // 
            AccountsGridView.BackgroundColor = Color.White;
            AccountsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountsGridView.Columns.AddRange(new DataGridViewColumn[] { Login, Password, Role });
            AccountsGridView.Location = new Point(20, 34);
            AccountsGridView.Margin = new Padding(5);
            AccountsGridView.Name = "AccountsGridView";
            AccountsGridView.ReadOnly = true;
            AccountsGridView.RowHeadersWidth = 51;
            AccountsGridView.RowTemplate.Height = 29;
            AccountsGridView.Size = new Size(428, 267);
            AccountsGridView.TabIndex = 0;
            // 
            // AddAccount
            // 
            AddAccount.BackColor = SystemColors.ControlLightLight;
            AddAccount.Location = new Point(20, 332);
            AddAccount.Margin = new Padding(5);
            AddAccount.Name = "AddAccount";
            AddAccount.Size = new Size(291, 46);
            AddAccount.TabIndex = 1;
            AddAccount.Text = "Добавить аккаунт";
            AddAccount.UseVisualStyleBackColor = false;
            AddAccount.Click += AddAccount_Click;
            // 
            // DeleteAccount
            // 
            DeleteAccount.BackColor = SystemColors.ControlLightLight;
            DeleteAccount.Location = new Point(321, 332);
            DeleteAccount.Margin = new Padding(5);
            DeleteAccount.Name = "DeleteAccount";
            DeleteAccount.Size = new Size(291, 46);
            DeleteAccount.TabIndex = 2;
            DeleteAccount.Text = "Удалить аккаунт";
            DeleteAccount.UseVisualStyleBackColor = false;
            DeleteAccount.Click += DeleteAccount_Click;
            // 
            // ChangeAccount
            // 
            ChangeAccount.BackColor = SystemColors.ControlLightLight;
            ChangeAccount.Location = new Point(622, 332);
            ChangeAccount.Margin = new Padding(5);
            ChangeAccount.Name = "ChangeAccount";
            ChangeAccount.Size = new Size(291, 46);
            ChangeAccount.TabIndex = 3;
            ChangeAccount.Text = "Изменить данные";
            ChangeAccount.UseVisualStyleBackColor = false;
            ChangeAccount.Click += ChangeAccount_Click;
            // 
            // SortButton
            // 
            SortButton.BackColor = SystemColors.ControlLightLight;
            SortButton.Location = new Point(466, 101);
            SortButton.Margin = new Padding(5);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(240, 46);
            SortButton.TabIndex = 4;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = false;
            SortButton.Click += SortButton_Click;
            // 
            // SortComboBox
            // 
            SortComboBox.BackColor = SystemColors.ControlLightLight;
            SortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Логин", "Роль" });
            SortComboBox.Location = new Point(679, 34);
            SortComboBox.Margin = new Padding(5);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(243, 40);
            SortComboBox.TabIndex = 5;
            // 
            // InverseCheckBox
            // 
            InverseCheckBox.AutoSize = true;
            InverseCheckBox.BackColor = Color.Transparent;
            InverseCheckBox.Location = new Point(716, 107);
            InverseCheckBox.Margin = new Padding(5);
            InverseCheckBox.Name = "InverseCheckBox";
            InverseCheckBox.Size = new Size(275, 36);
            InverseCheckBox.TabIndex = 6;
            InverseCheckBox.Text = "В обратном порядке";
            InverseCheckBox.UseVisualStyleBackColor = false;
            InverseCheckBox.CheckedChanged += InverseCheckBox_CheckedChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(466, 205);
            SearchTextBox.Margin = new Padding(5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(201, 39);
            SearchTextBox.TabIndex = 7;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.ControlLightLight;
            Search.Location = new Point(677, 201);
            Search.Margin = new Padding(5);
            Search.Name = "Search";
            Search.Size = new Size(203, 46);
            Search.TabIndex = 8;
            Search.Text = "Поиск";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // Reset
            // 
            Reset.BackColor = SystemColors.ControlLightLight;
            Reset.Location = new Point(677, 255);
            Reset.Margin = new Padding(5);
            Reset.Name = "Reset";
            Reset.Size = new Size(203, 46);
            Reset.TabIndex = 9;
            Reset.Text = "Сброс";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(466, 34);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 10;
            label1.Text = "Сортировать по";
            // 
            // Login
            // 
            Login.HeaderText = "Логин";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.ReadOnly = true;
            Login.SortMode = DataGridViewColumnSortMode.NotSortable;
            Login.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.SortMode = DataGridViewColumnSortMode.NotSortable;
            Password.Width = 125;
            // 
            // Role
            // 
            Role.HeaderText = "Роль";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            Role.SortMode = DataGridViewColumnSortMode.NotSortable;
            Role.Width = 125;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(998, 419);
            Controls.Add(label1);
            Controls.Add(Reset);
            Controls.Add(Search);
            Controls.Add(SearchTextBox);
            Controls.Add(InverseCheckBox);
            Controls.Add(SortComboBox);
            Controls.Add(SortButton);
            Controls.Add(ChangeAccount);
            Controls.Add(DeleteAccount);
            Controls.Add(AddAccount);
            Controls.Add(AccountsGridView);
            Margin = new Padding(5);
            Name = "Accounts";
            Text = "Список аккаунтов";
            ((System.ComponentModel.ISupportInitialize)AccountsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AccountsGridView;
        private Button AddAccount;
        private Button DeleteAccount;
        private Button ChangeAccount;
        private Button SortButton;
        private ComboBox SortComboBox;
        private CheckBox InverseCheckBox;
        private TextBox SearchTextBox;
        private Button Search;
        private Button Reset;
        private Label label1;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
    }
}