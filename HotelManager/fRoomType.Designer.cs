namespace HotelManager
{
    partial class fRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoomType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRoomType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupRoomType = new System.Windows.Forms.GroupBox();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.txbLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelName = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.saveRoomType = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomType)).BeginInit();
            this.groupRoomType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(5, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.Black;
            this.txbSearch.BorderColorIdle = System.Drawing.Color.Black;
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(23, 61);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5);
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
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã/ Tên loại phòng:";
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
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.Black;
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(23, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(23, 100);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRoomType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(231, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 612);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Phòng";
            // 
            // dataGridViewRoomType
            // 
            this.dataGridViewRoomType.AllowUserToAddRows = false;
            this.dataGridViewRoomType.AllowUserToDeleteRows = false;
            this.dataGridViewRoomType.AllowUserToResizeRows = false;
            this.dataGridViewRoomType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoomType.ColumnHeadersHeight = 29;
            this.dataGridViewRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colLimitPerson,
            this.colPrice,
            this.col});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoomType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoomType.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoomType.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewRoomType.Name = "dataGridViewRoomType";
            this.dataGridViewRoomType.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoomType.RowHeadersVisible = false;
            this.dataGridViewRoomType.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewRoomType.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoomType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRoomType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomType.Size = new System.Drawing.Size(626, 579);
            this.dataGridViewRoomType.TabIndex = 28;
            this.dataGridViewRoomType.SelectionChanged += new System.EventHandler(this.DataGridViewRoomType_SelectionChanged);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "Mã";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 71;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "Tên Loại Phòng";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 185;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLimitPerson.DataPropertyName = "limitPerson";
            this.colLimitPerson.HeaderText = "Số người tối đa";
            this.colLimitPerson.MinimumWidth = 6;
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            this.colLimitPerson.Width = 188;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "price_New";
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // col
            // 
            this.col.DataPropertyName = "price";
            this.col.HeaderText = "price";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.Visible = false;
            this.col.Width = 125;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(23, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã phòng:";
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
            this.txbName.Location = new System.Drawing.Point(23, 135);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 29);
            this.txbName.TabIndex = 0;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbName.Enter += new System.EventHandler(this.TxbName_Enter);
            this.txbName.Leave += new System.EventHandler(this.TxbName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên loại phòng:";
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
            this.txbPrice.Location = new System.Drawing.Point(23, 261);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(175, 29);
            this.txbPrice.TabIndex = 2;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPrice.Enter += new System.EventHandler(this.TxbPrice_Enter);
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrice_KeyPress);
            this.txbPrice.Leave += new System.EventHandler(this.TxbPrice_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số người tối đa:";
            // 
            // groupRoomType
            // 
            this.groupRoomType.Controls.Add(this.comboboxID);
            this.groupRoomType.Controls.Add(this.txbLimitPerson);
            this.groupRoomType.Controls.Add(this.label2);
            this.groupRoomType.Controls.Add(this.label3);
            this.groupRoomType.Controls.Add(this.txbPrice);
            this.groupRoomType.Controls.Add(this.label1);
            this.groupRoomType.Controls.Add(this.txbName);
            this.groupRoomType.Controls.Add(this.label16);
            this.groupRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupRoomType.ForeColor = System.Drawing.Color.Black;
            this.groupRoomType.Location = new System.Drawing.Point(5, 222);
            this.groupRoomType.Name = "groupRoomType";
            this.groupRoomType.Size = new System.Drawing.Size(220, 301);
            this.groupRoomType.TabIndex = 1;
            this.groupRoomType.TabStop = false;
            this.groupRoomType.Text = "Thông tin loại phòng";
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(23, 64);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(175, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Green;
            this.comboboxID.TabIndex = 30;
            this.comboboxID.UseSelectable = true;
            // 
            // txbLimitPerson
            // 
            this.txbLimitPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbLimitPerson.BorderColorFocused = System.Drawing.Color.Black;
            this.txbLimitPerson.BorderColorIdle = System.Drawing.Color.Black;
            this.txbLimitPerson.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txbLimitPerson.BorderThickness = 1;
            this.txbLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLimitPerson.Enabled = false;
            this.txbLimitPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLimitPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLimitPerson.isPassword = false;
            this.txbLimitPerson.Location = new System.Drawing.Point(23, 201);
            this.txbLimitPerson.Margin = new System.Windows.Forms.Padding(0);
            this.txbLimitPerson.Name = "txbLimitPerson";
            this.txbLimitPerson.Size = new System.Drawing.Size(175, 29);
            this.txbLimitPerson.TabIndex = 29;
            this.txbLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.Black;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.Black;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Đóng";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.Black;
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(23, 85);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 40);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.Black;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Cập Nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.Black;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(23, 35);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(9, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(339, 46);
            this.labelName.TabIndex = 49;
            this.labelName.Text = "Quản Lí Loại Phòng";
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(771, 16);
            this.bunifuSeparator1.TabIndex = 58;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // saveRoomType
            // 
            this.saveRoomType.FileName = "Danh sách loại phòng";
            this.saveRoomType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // fRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 680);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupRoomType);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRoomType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRoomType_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRoomType_KeyPress);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomType)).EndInit();
            this.groupRoomType.ResumeLayout(false);
            this.groupRoomType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRoomType;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.SaveFileDialog saveRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbLimitPerson;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
    }
}