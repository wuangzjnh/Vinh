namespace HotelManager
{
    partial class fServiceType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fServiceType));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupServiceType = new System.Windows.Forms.GroupBox();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnUpdateServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewServiceType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.saveServiceType = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupServiceType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).BeginInit();
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(5, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 194);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.Black;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.Black;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.Black;
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(26, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txbSearch.Location = new System.Drawing.Point(26, 79);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(175, 29);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã/Tên loại dịch vụ:";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Huỷ Tìm";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(26, 118);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TabStop = false;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupServiceType
            // 
            this.groupServiceType.Controls.Add(this.comboboxID);
            this.groupServiceType.Controls.Add(this.label1);
            this.groupServiceType.Controls.Add(this.txbName);
            this.groupServiceType.Controls.Add(this.label16);
            this.groupServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupServiceType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupServiceType.ForeColor = System.Drawing.Color.Black;
            this.groupServiceType.Location = new System.Drawing.Point(5, 277);
            this.groupServiceType.Name = "groupServiceType";
            this.groupServiceType.Size = new System.Drawing.Size(223, 201);
            this.groupServiceType.TabIndex = 46;
            this.groupServiceType.TabStop = false;
            this.groupServiceType.Text = "Thông tin loại dịch vụ";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(26, 75);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(175, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Green;
            this.comboboxID.TabIndex = 0;
            this.comboboxID.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên loại dịch vụ:";
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
            this.txbName.Location = new System.Drawing.Point(26, 153);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 29);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã loại dịch vụ:";
            // 
            // btnUpdateServiceType
            // 
            this.btnUpdateServiceType.ActiveBorderThickness = 1;
            this.btnUpdateServiceType.ActiveCornerRadius = 20;
            this.btnUpdateServiceType.ActiveFillColor = System.Drawing.Color.Black;
            this.btnUpdateServiceType.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateServiceType.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUpdateServiceType.BackColor = System.Drawing.Color.White;
            this.btnUpdateServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateServiceType.BackgroundImage")));
            this.btnUpdateServiceType.ButtonText = "Cập Nhật";
            this.btnUpdateServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServiceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateServiceType.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.IdleBorderThickness = 1;
            this.btnUpdateServiceType.IdleCornerRadius = 20;
            this.btnUpdateServiceType.IdleFillColor = System.Drawing.Color.Black;
            this.btnUpdateServiceType.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdateServiceType.IdleLineColor = System.Drawing.Color.Black;
            this.btnUpdateServiceType.Location = new System.Drawing.Point(26, 103);
            this.btnUpdateServiceType.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateServiceType.Name = "btnUpdateServiceType";
            this.btnUpdateServiceType.Size = new System.Drawing.Size(175, 40);
            this.btnUpdateServiceType.TabIndex = 8;
            this.btnUpdateServiceType.TabStop = false;
            this.btnUpdateServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateServiceType.Click += new System.EventHandler(this.BtnUpdateServiceType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewServiceType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(234, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 651);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Dịch Vụ";
            // 
            // dataGridViewServiceType
            // 
            this.dataGridViewServiceType.AllowUserToAddRows = false;
            this.dataGridViewServiceType.AllowUserToDeleteRows = false;
            this.dataGridViewServiceType.AllowUserToResizeRows = false;
            this.dataGridViewServiceType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServiceType.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServiceType.GridColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewServiceType.Name = "dataGridViewServiceType";
            this.dataGridViewServiceType.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewServiceType.RowHeadersVisible = false;
            this.dataGridViewServiceType.RowHeadersWidth = 51;
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceType.Size = new System.Drawing.Size(765, 618);
            this.dataGridViewServiceType.TabIndex = 28;
            this.dataGridViewServiceType.SelectionChanged += new System.EventHandler(this.DataGridViewServiceType_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "Mã loại dịch vụ";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 174;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "Tên loại dịch vụ";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(9, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(350, 46);
            this.labelName.TabIndex = 48;
            this.labelName.Text = "Quản Lí Loại Dịch Vụ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 43);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1000, 14);
            this.bunifuSeparator1.TabIndex = 56;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnCLose1
            // 
            this.btnCLose1.ActiveBorderThickness = 1;
            this.btnCLose1.ActiveCornerRadius = 20;
            this.btnCLose1.ActiveFillColor = System.Drawing.Color.Black;
            this.btnCLose1.ActiveForecolor = System.Drawing.Color.White;
            this.btnCLose1.ActiveLineColor = System.Drawing.Color.Black;
            this.btnCLose1.BackColor = System.Drawing.Color.White;
            this.btnCLose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose1.BackgroundImage")));
            this.btnCLose1.ButtonText = "Đóng";
            this.btnCLose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCLose1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.IdleBorderThickness = 1;
            this.btnCLose1.IdleCornerRadius = 20;
            this.btnCLose1.IdleFillColor = System.Drawing.Color.Black;
            this.btnCLose1.IdleForecolor = System.Drawing.Color.White;
            this.btnCLose1.IdleLineColor = System.Drawing.Color.Black;
            this.btnCLose1.Location = new System.Drawing.Point(26, 153);
            this.btnCLose1.Margin = new System.Windows.Forms.Padding(6);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(175, 40);
            this.btnCLose1.TabIndex = 25;
            this.btnCLose1.TabStop = false;
            this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCLose1.Click += new System.EventHandler(this.BtnCLose1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCLose1);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnUpdateServiceType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(8, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 214);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveBorderThickness = 1;
            this.btnInsert.ActiveCornerRadius = 20;
            this.btnInsert.ActiveFillColor = System.Drawing.Color.Black;
            this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsert.ActiveLineColor = System.Drawing.Color.Black;
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.ButtonText = "Thêm";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleCornerRadius = 20;
            this.btnInsert.IdleFillColor = System.Drawing.Color.Black;
            this.btnInsert.IdleForecolor = System.Drawing.Color.White;
            this.btnInsert.IdleLineColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(26, 53);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(175, 40);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.TabStop = false;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // saveServiceType
            // 
            this.saveServiceType.FileName = "Danh sách loại dịch vụ";
            this.saveServiceType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // fServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupServiceType);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fServiceType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fServiceType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FServiceType_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupServiceType.ResumeLayout(false);
            this.groupServiceType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupServiceType;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateServiceType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
        private System.Windows.Forms.SaveFileDialog saveServiceType;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
    }
}