namespace HotelManager
{
    partial class fService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fService));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupService = new System.Windows.Forms.GroupBox();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxServiceType = new MetroFramework.Controls.MetroComboBox();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCLose1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnServiceType = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsert = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.saveService = new System.Windows.Forms.SaveFileDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.groupService.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.comboboxID);
            this.groupService.Controls.Add(this.comboBoxServiceType);
            this.groupService.Controls.Add(this.txbName);
            this.groupService.Controls.Add(this.txbPrice);
            this.groupService.Controls.Add(this.label16);
            this.groupService.Controls.Add(this.label15);
            this.groupService.Controls.Add(this.label13);
            this.groupService.Controls.Add(this.label20);
            this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupService.ForeColor = System.Drawing.Color.Black;
            this.groupService.Location = new System.Drawing.Point(4, 144);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(208, 256);
            this.groupService.TabIndex = 41;
            this.groupService.TabStop = false;
            this.groupService.Text = "Thông tin dịch vụ";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(15, 43);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(175, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Green;
            this.comboboxID.TabIndex = 60;
            this.comboboxID.UseSelectable = true;
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.BackColor = System.Drawing.Color.White;
            this.comboBoxServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServiceType.ForeColor = System.Drawing.Color.SeaGreen;
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.ItemHeight = 24;
            this.comboBoxServiceType.Location = new System.Drawing.Point(15, 157);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(175, 30);
            this.comboBoxServiceType.Style = MetroFramework.MetroColorStyle.Green;
            this.comboBoxServiceType.TabIndex = 56;
            this.comboBoxServiceType.UseCustomBackColor = true;
            this.comboBoxServiceType.UseCustomForeColor = true;
            this.comboBoxServiceType.UseSelectable = true;
            this.comboBoxServiceType.UseStyleColors = true;
            // 
            // txbName
            // 
            this.txbName.BorderColorFocused = System.Drawing.Color.Black;
            this.txbName.BorderColorIdle = System.Drawing.Color.Black;
            this.txbName.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txbName.BorderThickness = 1;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.isPassword = false;
            this.txbName.Location = new System.Drawing.Point(15, 99);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 29);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbName.Enter += new System.EventHandler(this.TxbName_Enter);
            this.txbName.Leave += new System.EventHandler(this.TxbName_Leave);
            // 
            // txbPrice
            // 
            this.txbPrice.BorderColorFocused = System.Drawing.Color.Black;
            this.txbPrice.BorderColorIdle = System.Drawing.Color.Black;
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(15, 209);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(175, 29);
            this.txbPrice.TabIndex = 59;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPrice.Enter += new System.EventHandler(this.TxbPrice_Enter);
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrice_KeyPress);
            this.txbPrice.Leave += new System.EventHandler(this.TxbPrice_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã dịch vụ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên dịch vụ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(15, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 25);
            this.label13.TabIndex = 57;
            this.label13.Text = "Giá:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(15, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 25);
            this.label20.TabIndex = 58;
            this.label20.Text = "Loại dịch vụ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(4, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 90);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 13;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(235, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 29);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.Black;
            this.txbSearch.BorderColorIdle = System.Drawing.Color.Black;
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(19, 49);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(175, 29);
            this.txbSearch.TabIndex = 27;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã/Tên dịch vụ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewService);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(440, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 347);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Dịch Vụ";
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewService.ColumnHeadersHeight = 29;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPrice,
            this.col,
            this.colNameServiceType,
            this.colIdServiceType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.GridColor = System.Drawing.Color.White;
            this.dataGridViewService.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewService.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewService.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(524, 314);
            this.dataGridViewService.TabIndex = 28;
            this.dataGridViewService.SelectionChanged += new System.EventHandler(this.DataGridViewService_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.FillWeight = 30F;
            this.colID.HeaderText = "Mã";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 71;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 30F;
            this.colName.HeaderText = "Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.DataPropertyName = "price_new";
            this.colPrice.FillWeight = 30F;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 72;
            // 
            // col
            // 
            this.col.DataPropertyName = "price";
            this.col.FillWeight = 30F;
            this.col.HeaderText = "price";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.Visible = false;
            this.col.Width = 125;
            // 
            // colNameServiceType
            // 
            this.colNameServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameServiceType.DataPropertyName = "nameServiceType";
            this.colNameServiceType.FillWeight = 30F;
            this.colNameServiceType.HeaderText = "Loại dịch vụ";
            this.colNameServiceType.MinimumWidth = 6;
            this.colNameServiceType.Name = "colNameServiceType";
            this.colNameServiceType.ReadOnly = true;
            // 
            // colIdServiceType
            // 
            this.colIdServiceType.DataPropertyName = "idServiceType";
            this.colIdServiceType.FillWeight = 30F;
            this.colIdServiceType.HeaderText = "";
            this.colIdServiceType.MinimumWidth = 6;
            this.colIdServiceType.Name = "colIdServiceType";
            this.colIdServiceType.ReadOnly = true;
            this.colIdServiceType.Visible = false;
            this.colIdServiceType.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCLose1);
            this.groupBox2.Controls.Add(this.btnServiceType);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(218, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 256);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnCLose1
            // 
            this.btnCLose1.AutoRoundedCorners = true;
            this.btnCLose1.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose1.BorderRadius = 13;
            this.btnCLose1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCLose1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCLose1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCLose1.FillColor = System.Drawing.Color.Black;
            this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCLose1.ForeColor = System.Drawing.Color.White;
            this.btnCLose1.Location = new System.Drawing.Point(21, 209);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(175, 29);
            this.btnCLose1.TabIndex = 78;
            this.btnCLose1.Text = "Đóng";
            this.btnCLose1.Click += new System.EventHandler(this.BtnCLose1_Click);
            // 
            // btnServiceType
            // 
            this.btnServiceType.AutoRoundedCorners = true;
            this.btnServiceType.BackColor = System.Drawing.Color.Transparent;
            this.btnServiceType.BorderRadius = 13;
            this.btnServiceType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServiceType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServiceType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServiceType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServiceType.FillColor = System.Drawing.Color.Black;
            this.btnServiceType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnServiceType.ForeColor = System.Drawing.Color.White;
            this.btnServiceType.Location = new System.Drawing.Point(21, 157);
            this.btnServiceType.Name = "btnServiceType";
            this.btnServiceType.Size = new System.Drawing.Size(175, 29);
            this.btnServiceType.TabIndex = 77;
            this.btnServiceType.Text = "Sửa Loại Dịch Vụ";
            this.btnServiceType.Click += new System.EventHandler(this.BtnServiceType_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 13;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(21, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 29);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoRoundedCorners = true;
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BorderRadius = 13;
            this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsert.FillColor = System.Drawing.Color.Black;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(21, 43);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(175, 29);
            this.btnInsert.TabIndex = 75;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.BtnInsertService_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 46);
            this.label6.TabIndex = 45;
            this.label6.Text = "Quản Lí Dịch Vụ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 43);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(965, 12);
            this.bunifuSeparator1.TabIndex = 55;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // saveService
            // 
            this.saveService.FileName = "Danh sách dịch vụ";
            this.saveService.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 24;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fService";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FService_FormClosing);
            this.groupService.ResumeLayout(false);
            this.groupService.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private MetroFramework.Controls.MetroComboBox comboBoxServiceType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.SaveFileDialog saveService;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdServiceType;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnCLose1;
        private Guna.UI2.WinForms.Guna2Button btnServiceType;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnInsert;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
    }
}