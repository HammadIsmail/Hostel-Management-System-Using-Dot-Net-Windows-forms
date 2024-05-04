namespace Hostel_Management_System
{
    partial class AddEmployeeForm
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
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.DateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RankBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CNICBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.AddressBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SalaryBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AddressErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ContactErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CNICErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SalaryErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.AutoRoundedCorners = true;
            this.AddButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddButton.BorderRadius = 18;
            this.AddButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddButton.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(572, 509);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 38);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "ADD";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateBox
            // 
            this.DateBox.AutoRoundedCorners = true;
            this.DateBox.BackColor = System.Drawing.Color.Transparent;
            this.DateBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.BorderRadius = 17;
            this.DateBox.Checked = true;
            this.DateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DateBox.ForeColor = System.Drawing.Color.White;
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBox.Location = new System.Drawing.Point(285, 509);
            this.DateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 36);
            this.DateBox.TabIndex = 18;
            this.DateBox.UseTransparentBackground = true;
            this.DateBox.Value = new System.DateTime(2024, 4, 30, 22, 58, 15, 110);
            // 
            // RankBox
            // 
            this.RankBox.AutoRoundedCorners = true;
            this.RankBox.BackColor = System.Drawing.Color.Transparent;
            this.RankBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.RankBox.BorderRadius = 17;
            this.RankBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RankBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RankBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RankBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RankBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RankBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RankBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RankBox.ItemHeight = 30;
            this.RankBox.Items.AddRange(new object[] {
            "Colley",
            "Manager",
            "Sweeper",
            "Waiter"});
            this.RankBox.Location = new System.Drawing.Point(530, 434);
            this.RankBox.Name = "RankBox";
            this.RankBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RankBox.Size = new System.Drawing.Size(247, 36);
            this.RankBox.Sorted = true;
            this.RankBox.StartIndex = 1;
            this.RankBox.TabIndex = 17;
            // 
            // GenderBox
            // 
            this.GenderBox.AutoRoundedCorners = true;
            this.GenderBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.GenderBox.BorderRadius = 17;
            this.GenderBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenderBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderBox.ItemHeight = 30;
            this.GenderBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GenderBox.Location = new System.Drawing.Point(530, 293);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderBox.Size = new System.Drawing.Size(247, 36);
            this.GenderBox.Sorted = true;
            this.GenderBox.StartIndex = 0;
            this.GenderBox.TabIndex = 14;
            // 
            // CNICBox
            // 
            this.CNICBox.AutoRoundedCorners = true;
            this.CNICBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.CNICBox.BorderRadius = 17;
            this.CNICBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CNICBox.DefaultText = "";
            this.CNICBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CNICBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CNICBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CNICBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CNICBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CNICBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CNICBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CNICBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CNICBox.Location = new System.Drawing.Point(530, 228);
            this.CNICBox.Name = "CNICBox";
            this.CNICBox.PasswordChar = '\0';
            this.CNICBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CNICBox.PlaceholderText = "CNIC";
            this.CNICBox.SelectedText = "";
            this.CNICBox.Size = new System.Drawing.Size(247, 36);
            this.CNICBox.TabIndex = 13;
            this.CNICBox.TextChanged += new System.EventHandler(this.CNICBox_TextChanged);
            // 
            // ContactBox
            // 
            this.ContactBox.AutoRoundedCorners = true;
            this.ContactBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.ContactBox.BorderRadius = 17;
            this.ContactBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactBox.DefaultText = "";
            this.ContactBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContactBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactBox.Location = new System.Drawing.Point(285, 293);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.PasswordChar = '\0';
            this.ContactBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactBox.PlaceholderText = "Contact No";
            this.ContactBox.SelectedText = "";
            this.ContactBox.Size = new System.Drawing.Size(207, 36);
            this.ContactBox.TabIndex = 12;
            this.ContactBox.TextChanged += new System.EventHandler(this.ContactBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.NameBox.BorderRadius = 17;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Location = new System.Drawing.Point(285, 228);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(207, 36);
            this.NameBox.TabIndex = 10;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Hostel_Management_System.Properties.Resources.add_user_91876071;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(466, 66);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(109, 92);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // AddressBox
            // 
            this.AddressBox.AutoRoundedCorners = true;
            this.AddressBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddressBox.BorderRadius = 19;
            this.AddressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressBox.DefaultText = "";
            this.AddressBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressBox.Location = new System.Drawing.Point(530, 355);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.PasswordChar = '\0';
            this.AddressBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressBox.PlaceholderText = "Address";
            this.AddressBox.SelectedText = "";
            this.AddressBox.Size = new System.Drawing.Size(247, 40);
            this.AddressBox.TabIndex = 20;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // SalaryBox
            // 
            this.SalaryBox.AutoRoundedCorners = true;
            this.SalaryBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.SalaryBox.BorderRadius = 17;
            this.SalaryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalaryBox.DefaultText = "";
            this.SalaryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SalaryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SalaryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SalaryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SalaryBox.Location = new System.Drawing.Point(285, 359);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.PasswordChar = '\0';
            this.SalaryBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaryBox.PlaceholderText = "Salary";
            this.SalaryBox.SelectedText = "";
            this.SalaryBox.Size = new System.Drawing.Size(207, 36);
            this.SalaryBox.TabIndex = 21;
            this.SalaryBox.TextChanged += new System.EventHandler(this.SalaryBox_TextChanged);
            // 
            // NameErrorlb
            // 
            this.NameErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.NameErrorlb.ForeColor = System.Drawing.Color.Red;
            this.NameErrorlb.Location = new System.Drawing.Point(301, 270);
            this.NameErrorlb.Name = "NameErrorlb";
            this.NameErrorlb.Size = new System.Drawing.Size(3, 2);
            this.NameErrorlb.TabIndex = 22;
            this.NameErrorlb.Text = null;
            this.NameErrorlb.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // AddressErrorlb
            // 
            this.AddressErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.AddressErrorlb.ForeColor = System.Drawing.Color.Red;
            this.AddressErrorlb.Location = new System.Drawing.Point(544, 401);
            this.AddressErrorlb.Name = "AddressErrorlb";
            this.AddressErrorlb.Size = new System.Drawing.Size(3, 2);
            this.AddressErrorlb.TabIndex = 23;
            this.AddressErrorlb.Text = null;
            // 
            // ContactErrorlb
            // 
            this.ContactErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.ContactErrorlb.ForeColor = System.Drawing.Color.Red;
            this.ContactErrorlb.Location = new System.Drawing.Point(301, 335);
            this.ContactErrorlb.Name = "ContactErrorlb";
            this.ContactErrorlb.Size = new System.Drawing.Size(3, 2);
            this.ContactErrorlb.TabIndex = 24;
            this.ContactErrorlb.Text = null;
            // 
            // CNICErrorlb
            // 
            this.CNICErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.CNICErrorlb.ForeColor = System.Drawing.Color.Red;
            this.CNICErrorlb.Location = new System.Drawing.Point(544, 270);
            this.CNICErrorlb.Name = "CNICErrorlb";
            this.CNICErrorlb.Size = new System.Drawing.Size(3, 2);
            this.CNICErrorlb.TabIndex = 25;
            this.CNICErrorlb.Text = null;
            this.CNICErrorlb.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // SalaryErrorlb
            // 
            this.SalaryErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.SalaryErrorlb.ForeColor = System.Drawing.Color.Red;
            this.SalaryErrorlb.Location = new System.Drawing.Point(301, 401);
            this.SalaryErrorlb.Name = "SalaryErrorlb";
            this.SalaryErrorlb.Size = new System.Drawing.Size(3, 2);
            this.SalaryErrorlb.TabIndex = 26;
            this.SalaryErrorlb.Text = null;
            // 
            // Password
            // 
            this.Password.AutoRoundedCorners = true;
            this.Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.Password.BorderRadius = 17;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(285, 434);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(207, 36);
            this.Password.TabIndex = 27;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // PasswordErrorlb
            // 
            this.PasswordErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.PasswordErrorlb.ForeColor = System.Drawing.Color.Coral;
            this.PasswordErrorlb.Location = new System.Drawing.Point(301, 477);
            this.PasswordErrorlb.Name = "PasswordErrorlb";
            this.PasswordErrorlb.Size = new System.Drawing.Size(3, 2);
            this.PasswordErrorlb.TabIndex = 28;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.PasswordErrorlb);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.SalaryErrorlb);
            this.Controls.Add(this.CNICErrorlb);
            this.Controls.Add(this.ContactErrorlb);
            this.Controls.Add(this.AddressErrorlb);
            this.Controls.Add(this.NameErrorlb);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.RankBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.CNICBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBox;
        private Guna.UI2.WinForms.Guna2ComboBox RankBox;
        private Guna.UI2.WinForms.Guna2ComboBox GenderBox;
        private Guna.UI2.WinForms.Guna2TextBox CNICBox;
        private Guna.UI2.WinForms.Guna2TextBox ContactBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2TextBox AddressBox;
        private Guna.UI2.WinForms.Guna2TextBox SalaryBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel AddressErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel ContactErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel CNICErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel SalaryErrorlb;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordErrorlb;
    }
}