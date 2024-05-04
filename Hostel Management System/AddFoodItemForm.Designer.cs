namespace Hostel_Management_System
{
    partial class AddFoodItemForm
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
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddFoodItemBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CategoryBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PriceErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CategoryErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuantityErrorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodItemBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddBtn.BorderRadius = 21;
            this.AddBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddBtn.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(450, 472);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 45);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.QuantityBox.Location = new System.Drawing.Point(558, 378);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.PasswordChar = '\0';
            this.QuantityBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuantityBox.PlaceholderText = "Quantity";
            this.QuantityBox.SelectedText = "";
            this.QuantityBox.Size = new System.Drawing.Size(247, 36);
            this.QuantityBox.TabIndex = 14;
            this.QuantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.AutoRoundedCorners = true;
            this.PriceBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.PriceBox.BorderRadius = 17;
            this.PriceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBox.DefaultText = "";
            this.PriceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceBox.Location = new System.Drawing.Point(288, 378);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.PasswordChar = '\0';
            this.PriceBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceBox.PlaceholderText = "Price";
            this.PriceBox.SelectedText = "";
            this.PriceBox.Size = new System.Drawing.Size(207, 36);
            this.PriceBox.TabIndex = 13;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
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
            this.NameBox.Location = new System.Drawing.Point(288, 304);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(207, 36);
            this.NameBox.TabIndex = 11;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // AddFoodItemBtn
            // 
            this.AddFoodItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddFoodItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFoodItemBtn.Image = global::Hostel_Management_System.Properties.Resources.fast_food_11065986;
            this.AddFoodItemBtn.ImageRotate = 0F;
            this.AddFoodItemBtn.Location = new System.Drawing.Point(459, 92);
            this.AddFoodItemBtn.Name = "AddFoodItemBtn";
            this.AddFoodItemBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddFoodItemBtn.Size = new System.Drawing.Size(180, 141);
            this.AddFoodItemBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddFoodItemBtn.TabIndex = 21;
            this.AddFoodItemBtn.TabStop = false;
            this.AddFoodItemBtn.UseTransparentBackground = true;
            this.AddFoodItemBtn.Click += new System.EventHandler(this.AddFoodItemBtn_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.AutoRoundedCorners = true;
            this.CategoryBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.CategoryBox.BorderRadius = 17;
            this.CategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryBox.DefaultText = "";
            this.CategoryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryBox.Location = new System.Drawing.Point(558, 304);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.PasswordChar = '\0';
            this.CategoryBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CategoryBox.PlaceholderText = "Add Category Name";
            this.CategoryBox.SelectedText = "";
            this.CategoryBox.Size = new System.Drawing.Size(247, 36);
            this.CategoryBox.TabIndex = 22;
            this.CategoryBox.TextChanged += new System.EventHandler(this.CategoryBox_TextChanged);
            // 
            // NameErrorlb
            // 
            this.NameErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.NameErrorlb.ForeColor = System.Drawing.Color.Red;
            this.NameErrorlb.Location = new System.Drawing.Point(305, 346);
            this.NameErrorlb.Name = "NameErrorlb";
            this.NameErrorlb.Size = new System.Drawing.Size(3, 2);
            this.NameErrorlb.TabIndex = 23;
            // 
            // PriceErrorlb
            // 
            this.PriceErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.PriceErrorlb.ForeColor = System.Drawing.Color.Red;
            this.PriceErrorlb.Location = new System.Drawing.Point(305, 420);
            this.PriceErrorlb.Name = "PriceErrorlb";
            this.PriceErrorlb.Size = new System.Drawing.Size(3, 2);
            this.PriceErrorlb.TabIndex = 24;
            // 
            // CategoryErrorlb
            // 
            this.CategoryErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.CategoryErrorlb.ForeColor = System.Drawing.Color.Red;
            this.CategoryErrorlb.Location = new System.Drawing.Point(572, 346);
            this.CategoryErrorlb.Name = "CategoryErrorlb";
            this.CategoryErrorlb.Size = new System.Drawing.Size(3, 2);
            this.CategoryErrorlb.TabIndex = 25;
            // 
            // QuantityErrorlb
            // 
            this.QuantityErrorlb.BackColor = System.Drawing.Color.Transparent;
            this.QuantityErrorlb.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorlb.Location = new System.Drawing.Point(572, 420);
            this.QuantityErrorlb.Name = "QuantityErrorlb";
            this.QuantityErrorlb.Size = new System.Drawing.Size(3, 2);
            this.QuantityErrorlb.TabIndex = 26;
            // 
            // AddFoodItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1062, 634);
            this.Controls.Add(this.QuantityErrorlb);
            this.Controls.Add(this.CategoryErrorlb);
            this.Controls.Add(this.PriceErrorlb);
            this.Controls.Add(this.NameErrorlb);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.AddFoodItemBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFoodItemForm";
            this.Text = "AddFoodItemForm";
            this.Load += new System.EventHandler(this.AddFoodItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddFoodItemBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox QuantityBox;
        private Guna.UI2.WinForms.Guna2TextBox PriceBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox AddFoodItemBtn;
        private Guna.UI2.WinForms.Guna2TextBox CategoryBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel NameErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel PriceErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel CategoryErrorlb;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuantityErrorlb;
    }
}