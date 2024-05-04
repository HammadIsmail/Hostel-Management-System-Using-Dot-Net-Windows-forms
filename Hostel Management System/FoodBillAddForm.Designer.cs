namespace Hostel_Management_System
{
    partial class FoodBillAddForm
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
            this.AddFoodItemBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PrintBillBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FoodItemCategoryBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.QuantityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BillGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ViewAllBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FoodItemNameBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CustomerNameErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuantityErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PriceBox = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodItemBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFoodItemBtn
            // 
            this.AddFoodItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddFoodItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFoodItemBtn.Image = global::Hostel_Management_System.Properties.Resources.fast_food_11065986;
            this.AddFoodItemBtn.ImageRotate = 0F;
            this.AddFoodItemBtn.Location = new System.Drawing.Point(422, 21);
            this.AddFoodItemBtn.Name = "AddFoodItemBtn";
            this.AddFoodItemBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddFoodItemBtn.Size = new System.Drawing.Size(180, 141);
            this.AddFoodItemBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddFoodItemBtn.TabIndex = 27;
            this.AddFoodItemBtn.TabStop = false;
            this.AddFoodItemBtn.UseTransparentBackground = true;
            this.AddFoodItemBtn.Click += new System.EventHandler(this.AddFoodItemBtn_Click);
            // 
            // PrintBillBtn
            // 
            this.PrintBillBtn.AutoRoundedCorners = true;
            this.PrintBillBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PrintBillBtn.BorderRadius = 16;
            this.PrintBillBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PrintBillBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.PrintBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBillBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PrintBillBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBillBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBillBtn.Location = new System.Drawing.Point(68, 471);
            this.PrintBillBtn.Name = "PrintBillBtn";
            this.PrintBillBtn.Size = new System.Drawing.Size(103, 34);
            this.PrintBillBtn.TabIndex = 26;
            this.PrintBillBtn.Text = "Print ";
            this.PrintBillBtn.Click += new System.EventHandler(this.PrintBillBtn_Click);
            // 
            // FoodItemCategoryBox
            // 
            this.FoodItemCategoryBox.AutoRoundedCorners = true;
            this.FoodItemCategoryBox.BackColor = System.Drawing.Color.Transparent;
            this.FoodItemCategoryBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodItemCategoryBox.BorderRadius = 17;
            this.FoodItemCategoryBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodItemCategoryBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FoodItemCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodItemCategoryBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FoodItemCategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FoodItemCategoryBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FoodItemCategoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FoodItemCategoryBox.ItemHeight = 30;
            this.FoodItemCategoryBox.Location = new System.Drawing.Point(243, 325);
            this.FoodItemCategoryBox.Name = "FoodItemCategoryBox";
            this.FoodItemCategoryBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FoodItemCategoryBox.Size = new System.Drawing.Size(144, 36);
            this.FoodItemCategoryBox.Sorted = true;
            this.FoodItemCategoryBox.TabIndex = 25;
            this.FoodItemCategoryBox.SelectedIndexChanged += new System.EventHandler(this.FoodItemCategoryBox_SelectedIndexChanged);
            // 
            // QuantityBox
            // 
            this.QuantityBox.AutoRoundedCorners = true;
            this.QuantityBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.QuantityBox.BorderRadius = 17;
            this.QuantityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityBox.DefaultText = "";
            this.QuantityBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantityBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityBox.Location = new System.Drawing.Point(243, 401);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.PasswordChar = '\0';
            this.QuantityBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantityBox.PlaceholderText = "Quantity";
            this.QuantityBox.SelectedText = "";
            this.QuantityBox.Size = new System.Drawing.Size(144, 36);
            this.QuantityBox.TabIndex = 24;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.AutoRoundedCorners = true;
            this.CustomerNameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.CustomerNameBox.BorderRadius = 17;
            this.CustomerNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameBox.DefaultText = "";
            this.CustomerNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameBox.Location = new System.Drawing.Point(53, 261);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.PasswordChar = '\0';
            this.CustomerNameBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerNameBox.PlaceholderText = "Customer Name";
            this.CustomerNameBox.SelectedText = "";
            this.CustomerNameBox.Size = new System.Drawing.Size(334, 36);
            this.CustomerNameBox.TabIndex = 28;
            this.CustomerNameBox.TextChanged += new System.EventHandler(this.CustomerNameBox_TextChanged);
            // 
            // SearchErrorlb
            // 
            this.SearchErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.SearchErrorlb.ForeColor = System.Drawing.Color.Red;
            this.SearchErrorlb.Location = new System.Drawing.Point(570, 295);
            this.SearchErrorlb.Name = "SearchErrorlb";
            this.SearchErrorlb.Size = new System.Drawing.Size(3, 2);
            this.SearchErrorlb.TabIndex = 74;
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
            this.SearchBtn.Location = new System.Drawing.Point(920, 252);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(49, 37);
            this.SearchBtn.TabIndex = 73;
            this.SearchBtn.UseTransparentBackground = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BillGridView
            // 
            this.BillGridView.AllowUserToAddRows = false;
            this.BillGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BillGridView.Location = new System.Drawing.Point(491, 328);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.ReadOnly = true;
            this.BillGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.Size = new System.Drawing.Size(526, 177);
            this.BillGridView.TabIndex = 72;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.BillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.BillGridView.ThemeStyle.ReadOnly = true;
            this.BillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.ThemeStyle.RowsStyle.Height = 22;
            this.BillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillGridView_CellClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(479, 318);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(549, 198);
            this.guna2HtmlLabel1.TabIndex = 71;
            this.guna2HtmlLabel1.Text = null;
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
            this.ViewAllBtn.Location = new System.Drawing.Point(865, 252);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(49, 37);
            this.ViewAllBtn.TabIndex = 70;
            this.ViewAllBtn.UseTransparentBackground = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
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
            this.SearchBox.Location = new System.Drawing.Point(553, 252);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(305, 36);
            this.SearchBox.TabIndex = 69;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // FoodItemNameBox
            // 
            this.FoodItemNameBox.AutoRoundedCorners = true;
            this.FoodItemNameBox.BackColor = System.Drawing.Color.Transparent;
            this.FoodItemNameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodItemNameBox.BorderRadius = 17;
            this.FoodItemNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodItemNameBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FoodItemNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodItemNameBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FoodItemNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FoodItemNameBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FoodItemNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FoodItemNameBox.ItemHeight = 30;
            this.FoodItemNameBox.Location = new System.Drawing.Point(58, 325);
            this.FoodItemNameBox.Name = "FoodItemNameBox";
            this.FoodItemNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FoodItemNameBox.Size = new System.Drawing.Size(144, 36);
            this.FoodItemNameBox.Sorted = true;
            this.FoodItemNameBox.TabIndex = 75;
            this.FoodItemNameBox.SelectedIndexChanged += new System.EventHandler(this.FoodItemNameBox_SelectedIndexChanged);
            // 
            // CustomerNameErrorlb
            // 
            this.CustomerNameErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameErrorlb.ForeColor = System.Drawing.Color.Red;
            this.CustomerNameErrorlb.Location = new System.Drawing.Point(68, 303);
            this.CustomerNameErrorlb.Name = "CustomerNameErrorlb";
            this.CustomerNameErrorlb.Size = new System.Drawing.Size(3, 2);
            this.CustomerNameErrorlb.TabIndex = 77;
            this.CustomerNameErrorlb.Text = null;
            // 
            // QuantityErrorlb
            // 
            this.QuantityErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.QuantityErrorlb.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorlb.Location = new System.Drawing.Point(257, 443);
            this.QuantityErrorlb.Name = "QuantityErrorlb";
            this.QuantityErrorlb.Size = new System.Drawing.Size(3, 2);
            this.QuantityErrorlb.TabIndex = 78;
            this.QuantityErrorlb.Text = null;
            // 
            // PriceBox
            // 
            this.PriceBox.AutoRoundedCorners = true;
            this.PriceBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PriceBox.BorderRadius = 17;
            this.PriceBox.BorderThickness = 1;
            this.PriceBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PriceBox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PriceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PriceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PriceBox.FillColor = System.Drawing.Color.White;
            this.PriceBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PriceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.PriceBox.Location = new System.Drawing.Point(53, 401);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(149, 36);
            this.PriceBox.TabIndex = 79;
            this.PriceBox.Text = "Price";
            this.PriceBox.UseTransparentBackground = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DeleteBtn.BorderRadius = 16;
            this.DeleteBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeleteBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(243, 471);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 34);
            this.DeleteBtn.TabIndex = 80;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Add
            // 
            this.Add.AutoRoundedCorners = true;
            this.Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.Add.BorderRadius = 16;
            this.Add.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(157, 531);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 34);
            this.Add.TabIndex = 81;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // FoodBillAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityErrorlb);
            this.Controls.Add(this.CustomerNameErrorlb);
            this.Controls.Add(this.FoodItemNameBox);
            this.Controls.Add(this.SearchErrorlb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.AddFoodItemBtn);
            this.Controls.Add(this.PrintBillBtn);
            this.Controls.Add(this.FoodItemCategoryBox);
            this.Controls.Add(this.QuantityBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodBillAddForm";
            this.Text = "FoodBillAddForm";
            this.Load += new System.EventHandler(this.FoodBillAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodItemBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox AddFoodItemBtn;
        private Guna.UI2.WinForms.Guna2Button PrintBillBtn;
        private Guna.UI2.WinForms.Guna2ComboBox FoodItemCategoryBox;
        private Guna.UI2.WinForms.Guna2TextBox QuantityBox;
        private Guna.UI2.WinForms.Guna2TextBox CustomerNameBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel SearchErrorlb;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView BillGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button ViewAllBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2ComboBox FoodItemNameBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel CustomerNameErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityErrorlb;
        private Guna.UI2.WinForms.Guna2Button PriceBox;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button Add;
    }
}