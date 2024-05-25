namespace Hostel_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.UserNamelb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.FoodItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FoodItemBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FoodAddForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FoodViewForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FoodEditForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FoodDeleteForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UserSettingBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeCrudPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EmployeeBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeViewBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeEditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeDeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EmployeeSalaryForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RoomBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingCrudPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BookingBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingViewBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingEditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BookingDeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DashBoardBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.CLoseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuBarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.menuBar = new System.Windows.Forms.Timer(this.components);
            this.CheckMaximumAndMinimum = new System.Windows.Forms.Timer(this.components);
            this.MainBoxPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.FoodItemPanel.SuspendLayout();
            this.EmployeeCrudPanel.SuspendLayout();
            this.BookingCrudPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.UserNamelb);
            this.MenuPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.MenuPanel.Controls.Add(this.FoodItemPanel);
            this.MenuPanel.Controls.Add(this.UserSettingBtn);
            this.MenuPanel.Controls.Add(this.LogOutBtn);
            this.MenuPanel.Controls.Add(this.EmployeeCrudPanel);
            this.MenuPanel.Controls.Add(this.RoomBtn);
            this.MenuPanel.Controls.Add(this.BookingCrudPanel);
            this.MenuPanel.Controls.Add(this.DashBoardBtn);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.MenuPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.MouseLeave += new System.EventHandler(this.MenuPanel_MouseLeave);
            // 
            // UserNamelb
            // 
            this.UserNamelb.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.UserNamelb, "UserNamelb");
            this.UserNamelb.ForeColor = System.Drawing.Color.White;
            this.UserNamelb.Name = "UserNamelb";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Hostel_Management_System.Properties.Resources.man_user_circle_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // FoodItemPanel
            // 
            resources.ApplyResources(this.FoodItemPanel, "FoodItemPanel");
            this.FoodItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodItemPanel.Controls.Add(this.FoodItemBtn);
            this.FoodItemPanel.Controls.Add(this.FoodAddForm);
            this.FoodItemPanel.Controls.Add(this.FoodViewForm);
            this.FoodItemPanel.Controls.Add(this.FoodEditForm);
            this.FoodItemPanel.Controls.Add(this.FoodDeleteForm);
            this.FoodItemPanel.Name = "FoodItemPanel";
            // 
            // FoodItemBtn
            // 
            this.FoodItemBtn.AutoRoundedCorners = true;
            this.FoodItemBtn.BackColor = System.Drawing.Color.Transparent;
            this.FoodItemBtn.BorderColor = System.Drawing.Color.White;
            this.FoodItemBtn.BorderRadius = 18;
            this.FoodItemBtn.BorderThickness = 1;
            this.FoodItemBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.burger_1037762;
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
            this.FoodItemBtn.MouseHover += new System.EventHandler(this.FoodItemBtn_MouseHover);
            // 
            // FoodAddForm
            // 
            this.FoodAddForm.AutoRoundedCorners = true;
            this.FoodAddForm.BackColor = System.Drawing.Color.Transparent;
            this.FoodAddForm.BorderColor = System.Drawing.Color.White;
            this.FoodAddForm.BorderRadius = 16;
            this.FoodAddForm.BorderThickness = 1;
            this.FoodAddForm.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.add_button_11519998;
            this.FoodAddForm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodAddForm.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.FoodAddForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodAddForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodAddForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodAddForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodAddForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodAddForm.FillColor = System.Drawing.Color.White;
            this.FoodAddForm.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.FoodAddForm, "FoodAddForm");
            this.FoodAddForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodAddForm.IndicateFocus = true;
            this.FoodAddForm.Name = "FoodAddForm";
            this.FoodAddForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodAddForm.UseTransparentBackground = true;
            this.FoodAddForm.Click += new System.EventHandler(this.FoodAddForm_Click);
            // 
            // FoodViewForm
            // 
            this.FoodViewForm.AutoRoundedCorners = true;
            this.FoodViewForm.BackColor = System.Drawing.Color.Transparent;
            this.FoodViewForm.BorderColor = System.Drawing.Color.White;
            this.FoodViewForm.BorderRadius = 16;
            this.FoodViewForm.BorderThickness = 1;
            this.FoodViewForm.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.magnifying_glass_4950569;
            this.FoodViewForm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodViewForm.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.FoodViewForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodViewForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodViewForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodViewForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodViewForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodViewForm.FillColor = System.Drawing.Color.White;
            this.FoodViewForm.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.FoodViewForm, "FoodViewForm");
            this.FoodViewForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodViewForm.IndicateFocus = true;
            this.FoodViewForm.Name = "FoodViewForm";
            this.FoodViewForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodViewForm.UseTransparentBackground = true;
            this.FoodViewForm.Click += new System.EventHandler(this.FoodViewForm_Click);
            // 
            // FoodEditForm
            // 
            this.FoodEditForm.AutoRoundedCorners = true;
            this.FoodEditForm.BackColor = System.Drawing.Color.Transparent;
            this.FoodEditForm.BorderColor = System.Drawing.Color.White;
            this.FoodEditForm.BorderRadius = 16;
            this.FoodEditForm.BorderThickness = 1;
            this.FoodEditForm.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.loop_6812057;
            this.FoodEditForm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodEditForm.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.FoodEditForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodEditForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodEditForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodEditForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodEditForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodEditForm.FillColor = System.Drawing.Color.White;
            this.FoodEditForm.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.FoodEditForm, "FoodEditForm");
            this.FoodEditForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodEditForm.IndicateFocus = true;
            this.FoodEditForm.Name = "FoodEditForm";
            this.FoodEditForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodEditForm.UseTransparentBackground = true;
            this.FoodEditForm.Click += new System.EventHandler(this.FoodEditForm_Click);
            // 
            // FoodDeleteForm
            // 
            this.FoodDeleteForm.AutoRoundedCorners = true;
            this.FoodDeleteForm.BackColor = System.Drawing.Color.Transparent;
            this.FoodDeleteForm.BorderColor = System.Drawing.Color.White;
            this.FoodDeleteForm.BorderRadius = 16;
            this.FoodDeleteForm.BorderThickness = 1;
            this.FoodDeleteForm.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.delete_10337552;
            this.FoodDeleteForm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodDeleteForm.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.FoodDeleteForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodDeleteForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodDeleteForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodDeleteForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodDeleteForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodDeleteForm.FillColor = System.Drawing.Color.White;
            this.FoodDeleteForm.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.FoodDeleteForm, "FoodDeleteForm");
            this.FoodDeleteForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.FoodDeleteForm.IndicateFocus = true;
            this.FoodDeleteForm.Name = "FoodDeleteForm";
            this.FoodDeleteForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FoodDeleteForm.UseTransparentBackground = true;
            this.FoodDeleteForm.Click += new System.EventHandler(this.FoodDeleteForm_Click);
            // 
            // UserSettingBtn
            // 
            this.UserSettingBtn.AutoRoundedCorners = true;
            this.UserSettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserSettingBtn.BorderColor = System.Drawing.Color.White;
            this.UserSettingBtn.BorderRadius = 16;
            this.UserSettingBtn.BorderThickness = 1;
            this.UserSettingBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.setting_7436334;
            this.UserSettingBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserSettingBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.UserSettingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserSettingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserSettingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserSettingBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserSettingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserSettingBtn.FillColor = System.Drawing.Color.White;
            this.UserSettingBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.UserSettingBtn, "UserSettingBtn");
            this.UserSettingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.UserSettingBtn.IndicateFocus = true;
            this.UserSettingBtn.Name = "UserSettingBtn";
            this.UserSettingBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserSettingBtn.UseTransparentBackground = true;
            this.UserSettingBtn.Click += new System.EventHandler(this.UserSettingBtn_Click);
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
            // EmployeeCrudPanel
            // 
            resources.ApplyResources(this.EmployeeCrudPanel, "EmployeeCrudPanel");
            this.EmployeeCrudPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeBtn);
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeAddBtn);
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeViewBtn);
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeEditBtn);
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeDeleteBtn);
            this.EmployeeCrudPanel.Controls.Add(this.EmployeeSalaryForm);
            this.EmployeeCrudPanel.Name = "EmployeeCrudPanel";
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.AutoRoundedCorners = true;
            this.EmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeeBtn.BorderRadius = 16;
            this.EmployeeBtn.BorderThickness = 1;
            this.EmployeeBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.employee_2573030;
            this.EmployeeBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeBtn, "EmployeeBtn");
            this.EmployeeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeBtn.UseTransparentBackground = true;
            this.EmployeeBtn.MouseHover += new System.EventHandler(this.EmployeeBtn_MouseHover);
            // 
            // EmployeeAddBtn
            // 
            this.EmployeeAddBtn.AutoRoundedCorners = true;
            this.EmployeeAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeAddBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeeAddBtn.BorderRadius = 16;
            this.EmployeeAddBtn.BorderThickness = 1;
            this.EmployeeAddBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.add_button_11519998;
            this.EmployeeAddBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeAddBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeAddBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeAddBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeAddBtn, "EmployeeAddBtn");
            this.EmployeeAddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeAddBtn.IndicateFocus = true;
            this.EmployeeAddBtn.Name = "EmployeeAddBtn";
            this.EmployeeAddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeAddBtn.UseTransparentBackground = true;
            this.EmployeeAddBtn.Click += new System.EventHandler(this.EmployeeAddBtn_Click);
            // 
            // EmployeeViewBtn
            // 
            this.EmployeeViewBtn.AutoRoundedCorners = true;
            this.EmployeeViewBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeViewBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeeViewBtn.BorderRadius = 16;
            this.EmployeeViewBtn.BorderThickness = 1;
            this.EmployeeViewBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.magnifying_glass_4950569;
            this.EmployeeViewBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeViewBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeViewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeViewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeViewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeViewBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeViewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeViewBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeViewBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeViewBtn, "EmployeeViewBtn");
            this.EmployeeViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeViewBtn.IndicateFocus = true;
            this.EmployeeViewBtn.Name = "EmployeeViewBtn";
            this.EmployeeViewBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeViewBtn.UseTransparentBackground = true;
            this.EmployeeViewBtn.Click += new System.EventHandler(this.EmployeeViewBtn_Click);
            // 
            // EmployeeEditBtn
            // 
            this.EmployeeEditBtn.AutoRoundedCorners = true;
            this.EmployeeEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeEditBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeeEditBtn.BorderRadius = 16;
            this.EmployeeEditBtn.BorderThickness = 1;
            this.EmployeeEditBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.loop_6812057;
            this.EmployeeEditBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeEditBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeEditBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeEditBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeEditBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeEditBtn, "EmployeeEditBtn");
            this.EmployeeEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeEditBtn.IndicateFocus = true;
            this.EmployeeEditBtn.Name = "EmployeeEditBtn";
            this.EmployeeEditBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeEditBtn.UseTransparentBackground = true;
            this.EmployeeEditBtn.Click += new System.EventHandler(this.EmployeeEditBtn_Click);
            // 
            // EmployeeDeleteBtn
            // 
            this.EmployeeDeleteBtn.AutoRoundedCorners = true;
            this.EmployeeDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeDeleteBtn.BorderColor = System.Drawing.Color.White;
            this.EmployeeDeleteBtn.BorderRadius = 16;
            this.EmployeeDeleteBtn.BorderThickness = 1;
            this.EmployeeDeleteBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.delete_10337552;
            this.EmployeeDeleteBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeDeleteBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeDeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeDeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeDeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeDeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeDeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeDeleteBtn.FillColor = System.Drawing.Color.White;
            this.EmployeeDeleteBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeDeleteBtn, "EmployeeDeleteBtn");
            this.EmployeeDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeDeleteBtn.IndicateFocus = true;
            this.EmployeeDeleteBtn.Name = "EmployeeDeleteBtn";
            this.EmployeeDeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeDeleteBtn.UseTransparentBackground = true;
            this.EmployeeDeleteBtn.Click += new System.EventHandler(this.EmployeeDeleteBtn_Click);
            // 
            // EmployeeSalaryForm
            // 
            this.EmployeeSalaryForm.AutoRoundedCorners = true;
            this.EmployeeSalaryForm.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeSalaryForm.BorderColor = System.Drawing.Color.White;
            this.EmployeeSalaryForm.BorderRadius = 16;
            this.EmployeeSalaryForm.BorderThickness = 1;
            this.EmployeeSalaryForm.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.wage_3230435;
            this.EmployeeSalaryForm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeSalaryForm.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.EmployeeSalaryForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeSalaryForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeSalaryForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeSalaryForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeSalaryForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeSalaryForm.FillColor = System.Drawing.Color.White;
            this.EmployeeSalaryForm.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.EmployeeSalaryForm, "EmployeeSalaryForm");
            this.EmployeeSalaryForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.EmployeeSalaryForm.IndicateFocus = true;
            this.EmployeeSalaryForm.Name = "EmployeeSalaryForm";
            this.EmployeeSalaryForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeSalaryForm.UseTransparentBackground = true;
            this.EmployeeSalaryForm.Click += new System.EventHandler(this.EmployeeSalaryForm_Click);
            // 
            // RoomBtn
            // 
            this.RoomBtn.AutoRoundedCorners = true;
            this.RoomBtn.BackColor = System.Drawing.Color.Transparent;
            this.RoomBtn.BorderColor = System.Drawing.Color.White;
            this.RoomBtn.BorderRadius = 16;
            this.RoomBtn.BorderThickness = 1;
            this.RoomBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.bed_6844919;
            this.RoomBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.RoomBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomBtn.FillColor = System.Drawing.Color.White;
            this.RoomBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.RoomBtn, "RoomBtn");
            this.RoomBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.RoomBtn.IndicateFocus = true;
            this.RoomBtn.Name = "RoomBtn";
            this.RoomBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RoomBtn.UseTransparentBackground = true;
            this.RoomBtn.Click += new System.EventHandler(this.RoomBtn_Click);
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
            this.BookingBtn.Click += new System.EventHandler(this.Booking_Click);
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
            // DashBoardBtn
            // 
            this.DashBoardBtn.AutoRoundedCorners = true;
            this.DashBoardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardBtn.BorderColor = System.Drawing.Color.White;
            this.DashBoardBtn.BorderRadius = 16;
            this.DashBoardBtn.BorderThickness = 1;
            this.DashBoardBtn.CustomImages.Image = global::Hostel_Management_System.Properties.Resources.dashboard;
            this.DashBoardBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashBoardBtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.DashBoardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashBoardBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashBoardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashBoardBtn.FillColor = System.Drawing.Color.White;
            this.DashBoardBtn.FillColor2 = System.Drawing.Color.White;
            resources.ApplyResources(this.DashBoardBtn, "DashBoardBtn");
            this.DashBoardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(209)))));
            this.DashBoardBtn.IndicateFocus = true;
            this.DashBoardBtn.Name = "DashBoardBtn";
            this.DashBoardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DashBoardBtn.UseTransparentBackground = true;
            this.DashBoardBtn.Click += new System.EventHandler(this.DashBoardBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
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
            // CLoseBtn
            // 
            this.CLoseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CLoseBtn.BackgroundImage = global::Hostel_Management_System.Properties.Resources.delete_button__2_;
            resources.ApplyResources(this.CLoseBtn, "CLoseBtn");
            this.CLoseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
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
            // menuBar
            // 
            this.menuBar.Enabled = true;
            this.menuBar.Interval = 40;
            this.menuBar.Tick += new System.EventHandler(this.menuBar_Tick);
            // 
            // CheckMaximumAndMinimum
            // 
            this.CheckMaximumAndMinimum.Enabled = true;
            this.CheckMaximumAndMinimum.Tick += new System.EventHandler(this.CheckMaximumAndMinimum_Tick);
            // 
            // MainBoxPanel
            // 
            resources.ApplyResources(this.MainBoxPanel, "MainBoxPanel");
            this.MainBoxPanel.Name = "MainBoxPanel";
            this.MainBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainBoxPanel_Paint);
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.FoodItemPanel.ResumeLayout(false);
            this.EmployeeCrudPanel.ResumeLayout(false);
            this.BookingCrudPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel MenuPanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button menuBarBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton CLoseBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DashBoardBtn;
        private System.Windows.Forms.Timer menuBar;
        private System.Windows.Forms.Timer CheckMaximumAndMinimum;
        private Guna.UI2.WinForms.Guna2GradientButton BookingBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MainBoxPanel;
        private System.Windows.Forms.FlowLayoutPanel BookingCrudPanel;
        private Guna.UI2.WinForms.Guna2GradientButton BookingAddBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingViewBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingEditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BookingDeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton RoomBtn;
        private System.Windows.Forms.FlowLayoutPanel EmployeeCrudPanel;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeAddBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeViewBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeEditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeDeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton LogOutBtn;
        private System.Windows.Forms.FlowLayoutPanel FoodItemPanel;
        private Guna.UI2.WinForms.Guna2GradientButton FoodItemBtn;
        private Guna.UI2.WinForms.Guna2GradientButton FoodAddForm;
        private Guna.UI2.WinForms.Guna2GradientButton FoodViewForm;
        private Guna.UI2.WinForms.Guna2GradientButton FoodEditForm;
        private Guna.UI2.WinForms.Guna2GradientButton FoodDeleteForm;
        private Guna.UI2.WinForms.Guna2GradientButton UserSettingBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EmployeeSalaryForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserNamelb;
    }
}

