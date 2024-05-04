namespace Hostel_Management_System
{
    partial class EditBookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RoomNoBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FacilityBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CNICBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PaymentBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ViewAllBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BookingGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CNICErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ContactErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PaymentErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintBtn
            // 
            this.PrintBtn.AutoRoundedCorners = true;
            this.PrintBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PrintBtn.BorderRadius = 21;
            this.PrintBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PrintBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.PrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Location = new System.Drawing.Point(439, 546);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(182, 45);
            this.PrintBtn.TabIndex = 18;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DateBox
            // 
            this.DateBox.AutoRoundedCorners = true;
            this.DateBox.BackColor = System.Drawing.Color.Transparent;
            this.DateBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.BorderRadius = 19;
            this.DateBox.Checked = true;
            this.DateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DateBox.ForeColor = System.Drawing.Color.White;
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBox.Location = new System.Drawing.Point(168, 546);
            this.DateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 41);
            this.DateBox.TabIndex = 17;
            this.DateBox.UseTransparentBackground = true;
            this.DateBox.Value = new System.DateTime(2024, 4, 30, 22, 58, 15, 110);
            // 
            // RoomNoBox
            // 
            this.RoomNoBox.AutoRoundedCorners = true;
            this.RoomNoBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomNoBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.RoomNoBox.BorderRadius = 17;
            this.RoomNoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomNoBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomNoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNoBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNoBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomNoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomNoBox.ItemHeight = 30;
            this.RoomNoBox.Location = new System.Drawing.Point(787, 451);
            this.RoomNoBox.Name = "RoomNoBox";
            this.RoomNoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomNoBox.Size = new System.Drawing.Size(247, 36);
            this.RoomNoBox.Sorted = true;
            this.RoomNoBox.TabIndex = 16;
            this.RoomNoBox.DropDown += new System.EventHandler(this.RoomNoBox_DropDown);
            // 
            // RoomTypeBox
            // 
            this.RoomTypeBox.AutoRoundedCorners = true;
            this.RoomTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomTypeBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.RoomTypeBox.BorderRadius = 17;
            this.RoomTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomTypeBox.ItemHeight = 30;
            this.RoomTypeBox.Items.AddRange(new object[] {
            "Double Bed",
            "Single Bed",
            "Triple Bed"});
            this.RoomTypeBox.Location = new System.Drawing.Point(28, 451);
            this.RoomTypeBox.Name = "RoomTypeBox";
            this.RoomTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomTypeBox.Size = new System.Drawing.Size(207, 36);
            this.RoomTypeBox.Sorted = true;
            this.RoomTypeBox.StartIndex = 0;
            this.RoomTypeBox.TabIndex = 15;
            // 
            // FacilityBox
            // 
            this.FacilityBox.AutoRoundedCorners = true;
            this.FacilityBox.BackColor = System.Drawing.Color.Transparent;
            this.FacilityBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FacilityBox.BorderRadius = 17;
            this.FacilityBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacilityBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FacilityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FacilityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FacilityBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FacilityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FacilityBox.ItemHeight = 30;
            this.FacilityBox.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.FacilityBox.Location = new System.Drawing.Point(273, 451);
            this.FacilityBox.Name = "FacilityBox";
            this.FacilityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FacilityBox.Size = new System.Drawing.Size(247, 36);
            this.FacilityBox.Sorted = true;
            this.FacilityBox.StartIndex = 0;
            this.FacilityBox.TabIndex = 14;
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
            this.GenderBox.Location = new System.Drawing.Point(787, 384);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderBox.Size = new System.Drawing.Size(247, 36);
            this.GenderBox.Sorted = true;
            this.GenderBox.StartIndex = 0;
            this.GenderBox.TabIndex = 13;
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
            this.CNICBox.Location = new System.Drawing.Point(273, 384);
            this.CNICBox.Name = "CNICBox";
            this.CNICBox.PasswordChar = '\0';
            this.CNICBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CNICBox.PlaceholderText = "CNIC";
            this.CNICBox.SelectedText = "";
            this.CNICBox.Size = new System.Drawing.Size(247, 36);
            this.CNICBox.TabIndex = 12;
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
            this.ContactBox.Location = new System.Drawing.Point(542, 384);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.PasswordChar = '\0';
            this.ContactBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactBox.PlaceholderText = "Contact No";
            this.ContactBox.SelectedText = "";
            this.ContactBox.Size = new System.Drawing.Size(207, 36);
            this.ContactBox.TabIndex = 11;
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
            this.NameBox.Location = new System.Drawing.Point(28, 384);
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
            this.guna2CirclePictureBox1.Image = global::Hostel_Management_System.Properties.Resources.loop_6812057;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(510, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(109, 92);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 19;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // PaymentBox
            // 
            this.PaymentBox.AutoRoundedCorners = true;
            this.PaymentBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PaymentBox.BorderRadius = 17;
            this.PaymentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PaymentBox.DefaultText = "";
            this.PaymentBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PaymentBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PaymentBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PaymentBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PaymentBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaymentBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaymentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PaymentBox.Location = new System.Drawing.Point(542, 451);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.PasswordChar = '\0';
            this.PaymentBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentBox.PlaceholderText = "Payment";
            this.PaymentBox.SelectedText = "";
            this.PaymentBox.Size = new System.Drawing.Size(207, 36);
            this.PaymentBox.TabIndex = 23;
            this.PaymentBox.TextChanged += new System.EventHandler(this.PaymentBox_TextChanged);
            // 
            // SearchErrorlb
            // 
            this.SearchErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.SearchErrorlb.ForeColor = System.Drawing.Color.Red;
            this.SearchErrorlb.Location = new System.Drawing.Point(627, 220);
            this.SearchErrorlb.Name = "SearchErrorlb";
            this.SearchErrorlb.Size = new System.Drawing.Size(3, 2);
            this.SearchErrorlb.TabIndex = 75;
            this.SearchErrorlb.Text = null;
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoRoundedCorners = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImage = global::Hostel_Management_System.Properties.Resources.magnifying_glass_49505692;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.SearchBtn.BorderRadius = 17;
            this.SearchBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Empty;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(675, 186);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(49, 37);
            this.SearchBtn.TabIndex = 74;
            this.SearchBtn.UseTransparentBackground = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.AutoRoundedCorners = true;
            this.ViewAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViewAllBtn.BackgroundImage = global::Hostel_Management_System.Properties.Resources.loop_68120571;
            this.ViewAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewAllBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.ViewAllBtn.BorderRadius = 17;
            this.ViewAllBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewAllBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.ViewAllBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewAllBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewAllBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewAllBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewAllBtn.FillColor = System.Drawing.Color.Empty;
            this.ViewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ViewAllBtn.ForeColor = System.Drawing.Color.White;
            this.ViewAllBtn.Location = new System.Drawing.Point(609, 186);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(49, 37);
            this.ViewAllBtn.TabIndex = 73;
            this.ViewAllBtn.UseTransparentBackground = true;
            // 
            // BookingGridView
            // 
            this.BookingGridView.AllowUserToAddRows = false;
            this.BookingGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BookingGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookingGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookingGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingGridView.Location = new System.Drawing.Point(59, 252);
            this.BookingGridView.Name = "BookingGridView";
            this.BookingGridView.ReadOnly = true;
            this.BookingGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BookingGridView.RowHeadersVisible = false;
            this.BookingGridView.Size = new System.Drawing.Size(962, 106);
            this.BookingGridView.TabIndex = 72;
            this.BookingGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookingGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookingGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookingGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookingGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookingGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BookingGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookingGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.BookingGridView.ThemeStyle.ReadOnly = true;
            this.BookingGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingGridView.ThemeStyle.RowsStyle.Height = 22;
            this.BookingGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingGridView_CellClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 242);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(985, 127);
            this.guna2HtmlLabel1.TabIndex = 71;
            this.guna2HtmlLabel1.Text = null;
            // 
            // SearchBox
            // 
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.SearchBox.BorderRadius = 17;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Location = new System.Drawing.Point(314, 186);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(284, 36);
            this.SearchBox.TabIndex = 70;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // NameErrorlb
            // 
            this.NameErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.NameErrorlb.ForeColor = System.Drawing.Color.Red;
            this.NameErrorlb.Location = new System.Drawing.Point(38, 426);
            this.NameErrorlb.Name = "NameErrorlb";
            this.NameErrorlb.Size = new System.Drawing.Size(3, 2);
            this.NameErrorlb.TabIndex = 76;
            this.NameErrorlb.Text = null;
            // 
            // CNICErrorlb
            // 
            this.CNICErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.CNICErrorlb.ForeColor = System.Drawing.Color.Red;
            this.CNICErrorlb.Location = new System.Drawing.Point(283, 426);
            this.CNICErrorlb.Name = "CNICErrorlb";
            this.CNICErrorlb.Size = new System.Drawing.Size(3, 2);
            this.CNICErrorlb.TabIndex = 77;
            this.CNICErrorlb.Text = null;
            // 
            // ContactErrorlb
            // 
            this.ContactErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.ContactErrorlb.ForeColor = System.Drawing.Color.Red;
            this.ContactErrorlb.Location = new System.Drawing.Point(553, 426);
            this.ContactErrorlb.Name = "ContactErrorlb";
            this.ContactErrorlb.Size = new System.Drawing.Size(3, 2);
            this.ContactErrorlb.TabIndex = 78;
            this.ContactErrorlb.Text = null;
            // 
            // PaymentErrorlb
            // 
            this.PaymentErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.PaymentErrorlb.ForeColor = System.Drawing.Color.Red;
            this.PaymentErrorlb.Location = new System.Drawing.Point(553, 493);
            this.PaymentErrorlb.Name = "PaymentErrorlb";
            this.PaymentErrorlb.Size = new System.Drawing.Size(3, 2);
            this.PaymentErrorlb.TabIndex = 79;
            this.PaymentErrorlb.Text = null;
            // 
            // EditBtn
            // 
            this.EditBtn.AutoRoundedCorners = true;
            this.EditBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EditBtn.BorderRadius = 21;
            this.EditBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EditBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(676, 542);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(182, 45);
            this.EditBtn.TabIndex = 80;
            this.EditBtn.Text = "Edit";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.PaymentErrorlb);
            this.Controls.Add(this.ContactErrorlb);
            this.Controls.Add(this.CNICErrorlb);
            this.Controls.Add(this.NameErrorlb);
            this.Controls.Add(this.SearchErrorlb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.BookingGridView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PaymentBox);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.RoomNoBox);
            this.Controls.Add(this.RoomTypeBox);
            this.Controls.Add(this.FacilityBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.CNICBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBookingForm";
            this.Load += new System.EventHandler(this.EditBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBox;
        private Guna.UI2.WinForms.Guna2ComboBox RoomNoBox;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeBox;
        private Guna.UI2.WinForms.Guna2ComboBox FacilityBox;
        private Guna.UI2.WinForms.Guna2ComboBox GenderBox;
        private Guna.UI2.WinForms.Guna2TextBox CNICBox;
        private Guna.UI2.WinForms.Guna2TextBox ContactBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PaymentBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel SearchErrorlb;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button ViewAllBtn;
        private Guna.UI2.WinForms.Guna2DataGridView BookingGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel CNICErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel ContactErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel PaymentErrorlb;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
    }
}