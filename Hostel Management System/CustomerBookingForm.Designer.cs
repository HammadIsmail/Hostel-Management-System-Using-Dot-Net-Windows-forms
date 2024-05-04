namespace Hostel_Management_System
{
    partial class CustomerBookingForm
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
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PaymentErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ContactErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CNICErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NameErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PaymentBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RoomNoBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FacilityTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CNICBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Hostel_Management_System.Properties.Resources.man_user_circle_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(458, 32);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(144, 125);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddBtn.BorderRadius = 24;
            this.AddBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(446, 541);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(156, 51);
            this.AddBtn.TabIndex = 31;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PaymentErrorlb
            // 
            this.PaymentErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.PaymentErrorlb.ForeColor = System.Drawing.Color.Red;
            this.PaymentErrorlb.Location = new System.Drawing.Point(314, 459);
            this.PaymentErrorlb.Name = "PaymentErrorlb";
            this.PaymentErrorlb.Size = new System.Drawing.Size(3, 2);
            this.PaymentErrorlb.TabIndex = 30;
            this.PaymentErrorlb.Text = null;
            // 
            // ContactErrorlb
            // 
            this.ContactErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.ContactErrorlb.ForeColor = System.Drawing.Color.Red;
            this.ContactErrorlb.Location = new System.Drawing.Point(314, 318);
            this.ContactErrorlb.Name = "ContactErrorlb";
            this.ContactErrorlb.Size = new System.Drawing.Size(3, 2);
            this.ContactErrorlb.TabIndex = 29;
            this.ContactErrorlb.Text = null;
            // 
            // CNICErrorlb
            // 
            this.CNICErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.CNICErrorlb.ForeColor = System.Drawing.Color.Red;
            this.CNICErrorlb.Location = new System.Drawing.Point(558, 242);
            this.CNICErrorlb.Name = "CNICErrorlb";
            this.CNICErrorlb.Size = new System.Drawing.Size(3, 2);
            this.CNICErrorlb.TabIndex = 28;
            this.CNICErrorlb.Text = null;
            // 
            // NameErrorlb
            // 
            this.NameErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.NameErrorlb.ForeColor = System.Drawing.Color.Red;
            this.NameErrorlb.Location = new System.Drawing.Point(314, 243);
            this.NameErrorlb.Name = "NameErrorlb";
            this.NameErrorlb.Size = new System.Drawing.Size(3, 2);
            this.NameErrorlb.TabIndex = 27;
            this.NameErrorlb.Text = null;
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
            this.PaymentBox.Location = new System.Drawing.Point(295, 417);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.PasswordChar = '\0';
            this.PaymentBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentBox.PlaceholderText = "Payment";
            this.PaymentBox.SelectedText = "";
            this.PaymentBox.Size = new System.Drawing.Size(207, 36);
            this.PaymentBox.TabIndex = 26;
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
            this.PrintBtn.Location = new System.Drawing.Point(540, 481);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(247, 45);
            this.PrintBtn.TabIndex = 25;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // DateBox
            // 
            this.DateBox.AutoRoundedCorners = true;
            this.DateBox.BackColor = System.Drawing.Color.Transparent;
            this.DateBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.BorderRadius = 21;
            this.DateBox.Checked = true;
            this.DateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DateBox.ForeColor = System.Drawing.Color.White;
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateBox.Location = new System.Drawing.Point(295, 481);
            this.DateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 45);
            this.DateBox.TabIndex = 24;
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
            this.RoomNoBox.Location = new System.Drawing.Point(540, 417);
            this.RoomNoBox.Name = "RoomNoBox";
            this.RoomNoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomNoBox.Size = new System.Drawing.Size(247, 36);
            this.RoomNoBox.Sorted = true;
            this.RoomNoBox.TabIndex = 23;
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
            this.RoomTypeBox.Location = new System.Drawing.Point(295, 350);
            this.RoomTypeBox.Name = "RoomTypeBox";
            this.RoomTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RoomTypeBox.Size = new System.Drawing.Size(207, 36);
            this.RoomTypeBox.Sorted = true;
            this.RoomTypeBox.StartIndex = 0;
            this.RoomTypeBox.TabIndex = 22;
            // 
            // FacilityTypeBox
            // 
            this.FacilityTypeBox.AutoRoundedCorners = true;
            this.FacilityTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.FacilityTypeBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FacilityTypeBox.BorderRadius = 17;
            this.FacilityTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacilityTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FacilityTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacilityTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FacilityTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FacilityTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FacilityTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FacilityTypeBox.ItemHeight = 30;
            this.FacilityTypeBox.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.FacilityTypeBox.Location = new System.Drawing.Point(540, 350);
            this.FacilityTypeBox.Name = "FacilityTypeBox";
            this.FacilityTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FacilityTypeBox.Size = new System.Drawing.Size(247, 36);
            this.FacilityTypeBox.Sorted = true;
            this.FacilityTypeBox.StartIndex = 0;
            this.FacilityTypeBox.TabIndex = 21;
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
            this.GenderBox.Location = new System.Drawing.Point(540, 276);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderBox.Size = new System.Drawing.Size(247, 36);
            this.GenderBox.Sorted = true;
            this.GenderBox.StartIndex = 0;
            this.GenderBox.TabIndex = 20;
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
            this.CNICBox.Location = new System.Drawing.Point(540, 200);
            this.CNICBox.Name = "CNICBox";
            this.CNICBox.PasswordChar = '\0';
            this.CNICBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CNICBox.PlaceholderText = "CNIC";
            this.CNICBox.SelectedText = "";
            this.CNICBox.Size = new System.Drawing.Size(247, 36);
            this.CNICBox.TabIndex = 19;
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
            this.ContactBox.Location = new System.Drawing.Point(295, 276);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.PasswordChar = '\0';
            this.ContactBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactBox.PlaceholderText = "Contact No";
            this.ContactBox.SelectedText = "";
            this.ContactBox.Size = new System.Drawing.Size(207, 36);
            this.ContactBox.TabIndex = 18;
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
            this.NameBox.Location = new System.Drawing.Point(295, 200);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.ReadOnly = true;
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(207, 36);
            this.NameBox.TabIndex = 17;
            // 
            // CustomerBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1046, 595);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PaymentErrorlb);
            this.Controls.Add(this.ContactErrorlb);
            this.Controls.Add(this.CNICErrorlb);
            this.Controls.Add(this.NameErrorlb);
            this.Controls.Add(this.PaymentBox);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.RoomNoBox);
            this.Controls.Add(this.RoomTypeBox);
            this.Controls.Add(this.FacilityTypeBox);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.CNICBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerBookingForm";
            this.Text = "CustomerBookingForm";
            this.Load += new System.EventHandler(this.CustomerBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel PaymentErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel ContactErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel CNICErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameErrorlb;
        private Guna.UI2.WinForms.Guna2TextBox PaymentBox;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateBox;
        private Guna.UI2.WinForms.Guna2ComboBox RoomNoBox;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeBox;
        private Guna.UI2.WinForms.Guna2ComboBox FacilityTypeBox;
        private Guna.UI2.WinForms.Guna2ComboBox GenderBox;
        private Guna.UI2.WinForms.Guna2TextBox CNICBox;
        private Guna.UI2.WinForms.Guna2TextBox ContactBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
    }
}