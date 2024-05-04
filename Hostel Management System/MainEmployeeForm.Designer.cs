namespace Hostel_Management_System
{
    partial class MainEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEmployeeForm));
            this.MenuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.FoodItemBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingCrudPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BookingBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingViewBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingEditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingDeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuBar = new System.Windows.Forms.Timer(this.components);
            this.MainBoxPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.UserNamelb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CLoseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menuBarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MenuPanel.SuspendLayout();
            this.BookingCrudPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.MainBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.FoodItemBtn);
            this.MenuPanel.Controls.Add(this.LogOutBtn);
            this.MenuPanel.Controls.Add(this.BookingCrudPanel);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.MenuPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            this.MenuPanel.MouseLeave += new System.EventHandler(this.MenuPanel_MouseLeave);
            // 
            // FoodItemBtn
            // 
            this.FoodItemBtn.AutoRoundedCorners = true;
            this.FoodItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.FoodItemBtn.BorderColor = System.Drawing.Color.White;
            this.FoodItemBtn.BorderRadius = 18;
            this.FoodItemBtn.BorderThickness = 1;
            this.FoodItemBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.invoice_6951854;
            this.FoodItemBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodItemBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.FoodItemBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodItemBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodItemBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodItemBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodItemBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodItemBtn.FillColor = System.Drawing.Color.White;
            this.FoodItemBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.FoodItemBtn, "FoodItemBtn");
            this.FoodItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodItemBtn.Name = "FoodItemBtn";
            this.FoodItemBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodItemBtn.UseTransparentBackground = true;
            this.FoodItemBtn.Click += new System.EventHandler(this.FoodItemBtn_Click);
            this.FoodItemBtn.MouseHover += new System.EventHandler(this.FoodItemBtn_MouseHover);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.AutoRoundedCorners = true;
            this.LogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.BorderColor = System.Drawing.Color.White;
            this.LogOutBtn.BorderRadius = 16;
            this.LogOutBtn.BorderThickness = 1;
            this.LogOutBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.logout_11262058;
            this.LogOutBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogOutBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.FillColor = System.Drawing.Color.White;
            this.LogOutBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.LogOutBtn, "LogOutBtn");
            this.LogOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.LogOutBtn.IndicateFocus = true;
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LogOutBtn.UseTransparentBackground = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // BookingCrudPanel
            // 
            resources.ApplyResources(this.BookingCrudPanel, "BookingCrudPanel");
            this.BookingCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingCrudPanel.Controls.Add(this.BookingBtn);
            this.BookingCrudPanel.Controls.Add(this.BookingAddBtn);
            this.BookingCrudPanel.Controls.Add(this.BookingViewBtn);
            this.BookingCrudPanel.Controls.Add(this.BookingEditBtn);
            this.BookingCrudPanel.Controls.Add(this.BookingDeleteBtn);
            this.BookingCrudPanel.Name = "BookingCrudPanel";
            this.BookingCrudPanel.MouseLeave += new System.EventHandler(this.UserCrudPanel_MouseLeave);
            // 
            // BookingBtn
            // 
            this.BookingBtn.AutoRoundedCorners = true;
            this.BookingBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingBtn.BorderColor = System.Drawing.Color.White;
            this.BookingBtn.BorderRadius = 16;
            this.BookingBtn.BorderThickness = 1;
            this.BookingBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.dollar_5926633;
            this.BookingBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingBtn.FillColor = System.Drawing.Color.White;
            this.BookingBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.BookingBtn, "BookingBtn");
            this.BookingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingBtn.Name = "BookingBtn";
            this.BookingBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookingBtn.UseTransparentBackground = true;
            this.BookingBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            this.BookingBtn.MouseLeave += new System.EventHandler(this.AddUserBtn_MouseLeave);
            this.BookingBtn.MouseHover += new System.EventHandler(this.AddUserBtn_MouseHover);
            // 
            // BookingAddBtn
            // 
            this.BookingAddBtn.AutoRoundedCorners = true;
            this.BookingAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingAddBtn.BorderColor = System.Drawing.Color.White;
            this.BookingAddBtn.BorderRadius = 16;
            this.BookingAddBtn.BorderThickness = 1;
            this.BookingAddBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.add_button_11519998;
            this.BookingAddBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingAddBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingAddBtn.FillColor = System.Drawing.Color.White;
            this.BookingAddBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.BookingAddBtn, "BookingAddBtn");
            this.BookingAddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingAddBtn.IndicateFocus = true;
            this.BookingAddBtn.Name = "BookingAddBtn";
            this.BookingAddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookingAddBtn.UseTransparentBackground = true;
            this.BookingAddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BookingViewBtn
            // 
            this.BookingViewBtn.AutoRoundedCorners = true;
            this.BookingViewBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingViewBtn.BorderColor = System.Drawing.Color.White;
            this.BookingViewBtn.BorderRadius = 16;
            this.BookingViewBtn.BorderThickness = 1;
            this.BookingViewBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.magnifying_glass_4950569;
            this.BookingViewBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingViewBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingViewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingViewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingViewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingViewBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingViewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingViewBtn.FillColor = System.Drawing.Color.White;
            this.BookingViewBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.BookingViewBtn, "BookingViewBtn");
            this.BookingViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingViewBtn.IndicateFocus = true;
            this.BookingViewBtn.Name = "BookingViewBtn";
            this.BookingViewBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookingViewBtn.UseTransparentBackground = true;
            this.BookingViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // BookingEditBtn
            // 
            this.BookingEditBtn.AutoRoundedCorners = true;
            this.BookingEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingEditBtn.BorderColor = System.Drawing.Color.White;
            this.BookingEditBtn.BorderRadius = 16;
            this.BookingEditBtn.BorderThickness = 1;
            this.BookingEditBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.loop_6812057;
            this.BookingEditBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingEditBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingEditBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingEditBtn.FillColor = System.Drawing.Color.White;
            this.BookingEditBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.BookingEditBtn, "BookingEditBtn");
            this.BookingEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingEditBtn.IndicateFocus = true;
            this.BookingEditBtn.Name = "BookingEditBtn";
            this.BookingEditBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookingEditBtn.UseTransparentBackground = true;
            this.BookingEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BookingDeleteBtn
            // 
            this.BookingDeleteBtn.AutoRoundedCorners = true;
            this.BookingDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookingDeleteBtn.BorderColor = System.Drawing.Color.White;
            this.BookingDeleteBtn.BorderRadius = 16;
            this.BookingDeleteBtn.BorderThickness = 1;
            this.BookingDeleteBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.delete_10337552;
            this.BookingDeleteBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookingDeleteBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.BookingDeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookingDeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookingDeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingDeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookingDeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookingDeleteBtn.FillColor = System.Drawing.Color.White;
            this.BookingDeleteBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.BookingDeleteBtn, "BookingDeleteBtn");
            this.BookingDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.BookingDeleteBtn.IndicateFocus = true;
            this.BookingDeleteBtn.Name = "BookingDeleteBtn";
            this.BookingDeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookingDeleteBtn.UseTransparentBackground = true;
            this.BookingDeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoRoundedCorners = true;
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.BorderThickness = 10;
            this.guna2GradientPanel1.Controls.Add(this.CLoseBtn);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.menuBarBtn);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            resources.ApplyResources(this.guna2GradientPanel1, "guna2GradientPanel1");
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // menuBar
            // 
            this.menuBar.Enabled = true;
            this.menuBar.Interval = 40;
            this.menuBar.Tick += new System.EventHandler(this.menuBar_Tick);
            // 
            // MainBoxPanel
            // 
            this.MainBoxPanel.Controls.Add(this.UserNamelb);
            this.MainBoxPanel.Controls.Add(this.guna2CirclePictureBox1);
            resources.ApplyResources(this.MainBoxPanel, "MainBoxPanel");
            this.MainBoxPanel.Name = "MainBoxPanel";
            this.MainBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainBoxPanel_Paint);
            // 
            // UserNamelb
            // 
            this.UserNamelb.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.UserNamelb, "UserNamelb");
            this.UserNamelb.Name = "UserNamelb";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Hostel_Management_System.Properties.Resources.man_user_circle_icon1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // CLoseBtn
            // 
            this.CLoseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CLoseBtn.BackgroundImage = global::Hostel_Management_System.Properties.Resources.delete_button__2_;
            resources.ApplyResources(this.CLoseBtn, "CLoseBtn");
            this.CLoseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CLoseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CLoseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CLoseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CLoseBtn.FillColor = System.Drawing.Color.Empty;
            this.CLoseBtn.ForeColor = System.Drawing.Color.White;
            this.CLoseBtn.Name = "CLoseBtn";
            this.CLoseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CLoseBtn.UseTransparentBackground = true;
            this.CLoseBtn.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // menuBarBtn
            // 
            this.menuBarBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBarBtn.BackgroundImage = global::Hostel_Management_System.Properties.Resources.icons8_menu_48;
            resources.ApplyResources(this.menuBarBtn, "menuBarBtn");
            this.menuBarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBarBtn.FillColor = System.Drawing.Color.Empty;
            this.menuBarBtn.ForeColor = System.Drawing.Color.White;
            this.menuBarBtn.Name = "menuBarBtn";
            this.menuBarBtn.UseTransparentBackground = true;
            this.menuBarBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MainEmployeeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.MainBoxPanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainEmployeeForm";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.BookingCrudPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.MainBoxPanel.ResumeLayout(false);
            this.MainBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel MenuPanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button menuBarBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton CLoseBtn;
        private System.Windows.Forms.Timer menuBar;
        private Guna.UI2.WinForms.Guna2GradientButton BookingBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MainBoxPanel;
        private System.Windows.Forms.FlowLayoutPanel BookingCrudPanel;
        private Guna.UI2.WinForms.Guna2GradientButton BookingAddBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingViewBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingEditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingDeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton LogOutBtn;
        private Guna.UI2.WinForms.Guna2GradientButton FoodItemBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserNamelb;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}

