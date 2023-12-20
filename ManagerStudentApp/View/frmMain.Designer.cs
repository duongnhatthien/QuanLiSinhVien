namespace ManagerStudentApp.View
{
    partial class frmMain
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
            this.panelDrag = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.btnViewScore = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddScore = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cpbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnListInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateCourse = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.btnListStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnClassroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDrag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(207)))), ((int)(((byte)(212)))));
            this.panelDrag.Controls.Add(this.btnMinimize);
            this.panelDrag.Controls.Add(this.btnMaximize);
            this.panelDrag.Controls.Add(this.btnClose);
            this.panelDrag.Controls.Add(this.label1);
            this.panelDrag.Controls.Add(this.pictureBox1);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1333, 55);
            this.panelDrag.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGER STUDENT | APP";
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(241, 55);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1092, 707);
            this.panelContainer.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.panelDrag;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Instructor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Classroom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course:";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnViewScore);
            this.panel1.Controls.Add(this.btnAddScore);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnListInstructor);
            this.panel1.Controls.Add(this.btnCreateCourse);
            this.panel1.Controls.Add(this.btnAddInstructor);
            this.panel1.Controls.Add(this.btnListStudent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.btnClassroom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 707);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Grades";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblDisplayName);
            this.panel2.Controls.Add(this.cpbAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 100);
            this.panel2.TabIndex = 9;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(84, 48);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(74, 21);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Account";
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.Color.Transparent;
            this.btnViewScore.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnViewScore.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnViewScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewScore.FillColor = System.Drawing.Color.Transparent;
            this.btnViewScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewScore.ForeColor = System.Drawing.Color.Black;
            this.btnViewScore.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnViewScore.Image = global::ManagerStudentApp.Properties.Resources.icons8_score_50;
            this.btnViewScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewScore.Location = new System.Drawing.Point(0, 521);
            this.btnViewScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.PressedColor = System.Drawing.Color.Transparent;
            this.btnViewScore.Size = new System.Drawing.Size(245, 53);
            this.btnViewScore.TabIndex = 8;
            this.btnViewScore.Text = "View Score";
            this.btnViewScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.BackColor = System.Drawing.Color.Transparent;
            this.btnAddScore.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAddScore.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAddScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddScore.FillColor = System.Drawing.Color.Transparent;
            this.btnAddScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddScore.ForeColor = System.Drawing.Color.Black;
            this.btnAddScore.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnAddScore.Image = global::ManagerStudentApp.Properties.Resources.icons8_grades_50;
            this.btnAddScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddScore.Location = new System.Drawing.Point(0, 468);
            this.btnAddScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddScore.Size = new System.Drawing.Size(245, 53);
            this.btnAddScore.TabIndex = 7;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ManagerStudentApp.Properties.Resources.icons8_logout_48;
            this.pictureBox2.Location = new System.Drawing.Point(171, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cpbAvatar
            // 
            this.cpbAvatar.ImageRotate = 0F;
            this.cpbAvatar.Location = new System.Drawing.Point(12, 24);
            this.cpbAvatar.Name = "cpbAvatar";
            this.cpbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbAvatar.Size = new System.Drawing.Size(64, 64);
            this.cpbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpbAvatar.TabIndex = 0;
            this.cpbAvatar.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnDashboard.Image = global::ManagerStudentApp.Properties.Resources.icons8_chart_50;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(0, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Size = new System.Drawing.Size(245, 53);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnListInstructor
            // 
            this.btnListInstructor.BackColor = System.Drawing.Color.Transparent;
            this.btnListInstructor.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnListInstructor.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnListInstructor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListInstructor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListInstructor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListInstructor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListInstructor.FillColor = System.Drawing.Color.Transparent;
            this.btnListInstructor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnListInstructor.ForeColor = System.Drawing.Color.Black;
            this.btnListInstructor.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnListInstructor.Image = global::ManagerStudentApp.Properties.Resources.icons8_list_50;
            this.btnListInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListInstructor.Location = new System.Drawing.Point(0, 252);
            this.btnListInstructor.Margin = new System.Windows.Forms.Padding(0);
            this.btnListInstructor.Name = "btnListInstructor";
            this.btnListInstructor.PressedColor = System.Drawing.Color.Transparent;
            this.btnListInstructor.Size = new System.Drawing.Size(245, 53);
            this.btnListInstructor.TabIndex = 4;
            this.btnListInstructor.Text = "  List instructor";
            this.btnListInstructor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListInstructor.Click += new System.EventHandler(this.btnListInstructor_Click);
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCourse.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCreateCourse.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnCreateCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateCourse.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreateCourse.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCourse.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnCreateCourse.Image = global::ManagerStudentApp.Properties.Resources.icons8_book_50;
            this.btnCreateCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreateCourse.Location = new System.Drawing.Point(0, 396);
            this.btnCreateCourse.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.PressedColor = System.Drawing.Color.Transparent;
            this.btnCreateCourse.Size = new System.Drawing.Size(245, 53);
            this.btnCreateCourse.TabIndex = 6;
            this.btnCreateCourse.Text = "Create new course";
            this.btnCreateCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAddInstructor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInstructor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInstructor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddInstructor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddInstructor.FillColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddInstructor.ForeColor = System.Drawing.Color.Black;
            this.btnAddInstructor.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnAddInstructor.Image = global::ManagerStudentApp.Properties.Resources.icons8_add_50;
            this.btnAddInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddInstructor.Location = new System.Drawing.Point(0, 199);
            this.btnAddInstructor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.Size = new System.Drawing.Size(245, 53);
            this.btnAddInstructor.TabIndex = 3;
            this.btnAddInstructor.Text = "Add new instructor";
            this.btnAddInstructor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // btnListStudent
            // 
            this.btnListStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnListStudent.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnListStudent.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnListStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnListStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnListStudent.ForeColor = System.Drawing.Color.Black;
            this.btnListStudent.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnListStudent.Image = global::ManagerStudentApp.Properties.Resources.icons8_list_50;
            this.btnListStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListStudent.Location = new System.Drawing.Point(0, 74);
            this.btnListStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnListStudent.Name = "btnListStudent";
            this.btnListStudent.PressedColor = System.Drawing.Color.Transparent;
            this.btnListStudent.Size = new System.Drawing.Size(245, 53);
            this.btnListStudent.TabIndex = 1;
            this.btnListStudent.Text = "  List student";
            this.btnListStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListStudent.Click += new System.EventHandler(this.btnListStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnAddStudent.Image = global::ManagerStudentApp.Properties.Resources.icons8_add_50;
            this.btnAddStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 127);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.Size = new System.Drawing.Size(245, 53);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "  Add new students";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnClassroom
            // 
            this.btnClassroom.BackColor = System.Drawing.Color.Transparent;
            this.btnClassroom.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnClassroom.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnClassroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClassroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClassroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClassroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClassroom.FillColor = System.Drawing.Color.Transparent;
            this.btnClassroom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClassroom.ForeColor = System.Drawing.Color.Black;
            this.btnClassroom.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnClassroom.Image = global::ManagerStudentApp.Properties.Resources.icons8_classroom_50;
            this.btnClassroom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClassroom.Location = new System.Drawing.Point(0, 324);
            this.btnClassroom.Margin = new System.Windows.Forms.Padding(0);
            this.btnClassroom.Name = "btnClassroom";
            this.btnClassroom.PressedColor = System.Drawing.Color.Transparent;
            this.btnClassroom.Size = new System.Drawing.Size(245, 53);
            this.btnClassroom.TabIndex = 5;
            this.btnClassroom.Text = "Classroom";
            this.btnClassroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClassroom.Click += new System.EventHandler(this.btnClassroom_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::ManagerStudentApp.Properties.Resources.icons8_minimize_100;
            this.btnMinimize.Location = new System.Drawing.Point(1251, 12);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::ManagerStudentApp.Properties.Resources.icons8_maximize_1001;
            this.btnMaximize.Location = new System.Drawing.Point(1213, 12);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 30);
            this.btnMaximize.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::ManagerStudentApp.Properties.Resources.icons8_cancel_100;
            this.btnClose.Location = new System.Drawing.Point(1288, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagerStudentApp.Properties.Resources.icons8_menu_501;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1333, 762);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2Button btnListStudent;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddInstructor;
        private Guna.UI2.WinForms.Guna2Button btnListInstructor;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnClassroom;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnCreateCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDisplayName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbAvatar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnAddScore;
        private Guna.UI2.WinForms.Guna2Button btnViewScore;
    }
}