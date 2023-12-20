namespace ManagerStudentApp.View.Pages
{
    partial class UC_ListStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "List student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter:";
            // 
            // cbComboBox
            // 
            this.cbComboBox.BackColor = System.Drawing.Color.Transparent;
            this.cbComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbComboBox.ItemHeight = 30;
            this.cbComboBox.Location = new System.Drawing.Point(814, 156);
            this.cbComboBox.Name = "cbComboBox";
            this.cbComboBox.Size = new System.Drawing.Size(207, 36);
            this.cbComboBox.TabIndex = 2;
            this.cbComboBox.TextOffset = new System.Drawing.Point(2, 0);
            this.cbComboBox.SelectionChangeCommitted += new System.EventHandler(this.cbComboBox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Classroom :";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.AllowUserToResizeRows = false;
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisplay.ColumnHeadersHeight = 30;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColAddress,
            this.ColGender,
            this.Column6,
            this.ColClassroom,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisplay.EnableHeadersVisualStyles = false;
            this.dgvDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvDisplay.Location = new System.Drawing.Point(69, 258);
            this.dgvDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDisplay.MultiSelect = false;
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisplay.RowHeadersVisible = false;
            this.dgvDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplay.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDisplay.RowTemplate.Height = 100;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(955, 396);
            this.dgvDisplay.TabIndex = 4;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.FillWeight = 85.47237F;
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.FillWeight = 85.47237F;
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "Address";
            this.ColAddress.FillWeight = 85.47237F;
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.MinimumWidth = 6;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            // 
            // ColGender
            // 
            this.ColGender.DataPropertyName = "Gender";
            this.ColGender.FillWeight = 85.47237F;
            this.ColGender.HeaderText = "Gender";
            this.ColGender.MinimumWidth = 6;
            this.ColGender.Name = "ColGender";
            this.ColGender.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.FillWeight = 85.47237F;
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ColClassroom
            // 
            this.ColClassroom.DataPropertyName = "Classroom";
            this.ColClassroom.FillWeight = 85.47237F;
            this.ColClassroom.HeaderText = "Classroom";
            this.ColClassroom.MinimumWidth = 6;
            this.ColClassroom.Name = "ColClassroom";
            this.ColClassroom.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Picture";
            this.Column7.FillWeight = 187.1658F;
            this.Column7.HeaderText = "Picture";
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 67;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(170)))), ((int)(((byte)(247)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 3;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Image = global::ManagerStudentApp.Properties.Resources.icons8_pencil_50;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.Location = new System.Drawing.Point(224, 198);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 3;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelete.Image = global::ManagerStudentApp.Properties.Resources.icons8_trash_48;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.Location = new System.Drawing.Point(69, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderRadius = 10;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.IconRight = global::ManagerStudentApp.Properties.Resources.icons8_search_50;
            this.txtFilter.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtFilter.Location = new System.Drawing.Point(709, 204);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilter.PlaceholderText = "&Search here ...";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(315, 39);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagerStudentApp.Properties.Resources.icons8_three_people_96;
            this.pictureBox1.Location = new System.Drawing.Point(260, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UC_ListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbComboBox);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ListStudent";
            this.Size = new System.Drawing.Size(1092, 706);
            this.Load += new System.EventHandler(this.UC_ListStudent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UC_ListStudent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbComboBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClassroom;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}
