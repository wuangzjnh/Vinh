namespace HotelManager
{
    partial class fChangeRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangeRoom));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbRoom = new MetroFramework.Controls.MetroComboBox();
            this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRoomName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbRoomTypeName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose_ = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 24;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.BackColor = System.Drawing.Color.White;
            this.guna2Separator6.Location = new System.Drawing.Point(21, 47);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(701, 10);
            this.guna2Separator6.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(25, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 37);
            this.label2.TabIndex = 63;
            this.label2.Text = "Thông Tin Đặt Phòng";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.Controls.Add(this.cbRoom);
            this.guna2Panel3.Controls.Add(this.cbRoomType);
            this.guna2Panel3.Controls.Add(this.guna2Separator3);
            this.guna2Panel3.Controls.Add(this.label7);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.FillColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(21, 73);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(317, 199);
            this.guna2Panel3.TabIndex = 65;
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.Color.White;
            this.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ItemHeight = 23;
            this.cbRoom.Location = new System.Drawing.Point(17, 143);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(283, 29);
            this.cbRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.cbRoom.TabIndex = 55;
            this.cbRoom.UseCustomBackColor = true;
            this.cbRoom.UseCustomForeColor = true;
            this.cbRoom.UseSelectable = true;
            this.cbRoom.UseStyleColors = true;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.White;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 23;
            this.cbRoomType.Location = new System.Drawing.Point(17, 78);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(283, 29);
            this.cbRoomType.Style = MetroFramework.MetroColorStyle.Green;
            this.cbRoomType.TabIndex = 54;
            this.cbRoomType.UseCustomBackColor = true;
            this.cbRoomType.UseCustomForeColor = true;
            this.cbRoomType.UseSelectable = true;
            this.cbRoomType.UseStyleColors = true;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.Black;
            this.guna2Separator3.Location = new System.Drawing.Point(19, 38);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(281, 10);
            this.guna2Separator3.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Danh Sách Phòng trống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Loại phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phòng:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txbRoomName);
            this.guna2Panel1.Controls.Add(this.txbPrice);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.txbLimitPerson);
            this.guna2Panel1.Controls.Add(this.txbRoomTypeName);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(356, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(227, 347);
            this.guna2Panel1.TabIndex = 66;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(19, 38);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(193, 10);
            this.guna2Separator1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // txbRoomName
            // 
            this.txbRoomName.BackColor = System.Drawing.Color.White;
            this.txbRoomName.BorderColorFocused = System.Drawing.Color.Empty;
            this.txbRoomName.BorderColorIdle = System.Drawing.Color.Empty;
            this.txbRoomName.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txbRoomName.BorderThickness = 1;
            this.txbRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRoomName.Enabled = false;
            this.txbRoomName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRoomName.isPassword = false;
            this.txbRoomName.Location = new System.Drawing.Point(19, 89);
            this.txbRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.Size = new System.Drawing.Size(193, 29);
            this.txbRoomName.TabIndex = 21;
            this.txbRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.White;
            this.txbPrice.BorderColorFocused = System.Drawing.Color.Empty;
            this.txbPrice.BorderColorIdle = System.Drawing.Color.Empty;
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(19, 297);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(193, 29);
            this.txbPrice.TabIndex = 35;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã loại phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tên loại phòng:";
            // 
            // txbLimitPerson
            // 
            this.txbLimitPerson.BackColor = System.Drawing.Color.White;
            this.txbLimitPerson.BorderColorFocused = System.Drawing.Color.Empty;
            this.txbLimitPerson.BorderColorIdle = System.Drawing.Color.Empty;
            this.txbLimitPerson.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txbLimitPerson.BorderThickness = 1;
            this.txbLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLimitPerson.Enabled = false;
            this.txbLimitPerson.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbLimitPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLimitPerson.isPassword = false;
            this.txbLimitPerson.Location = new System.Drawing.Point(19, 225);
            this.txbLimitPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txbLimitPerson.Name = "txbLimitPerson";
            this.txbLimitPerson.Size = new System.Drawing.Size(193, 29);
            this.txbLimitPerson.TabIndex = 30;
            this.txbLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbRoomTypeName
            // 
            this.txbRoomTypeName.BackColor = System.Drawing.Color.White;
            this.txbRoomTypeName.BorderColorFocused = System.Drawing.Color.Empty;
            this.txbRoomTypeName.BorderColorIdle = System.Drawing.Color.Empty;
            this.txbRoomTypeName.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txbRoomTypeName.BorderThickness = 1;
            this.txbRoomTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRoomTypeName.Enabled = false;
            this.txbRoomTypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbRoomTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRoomTypeName.isPassword = false;
            this.txbRoomTypeName.Location = new System.Drawing.Point(19, 155);
            this.txbRoomTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txbRoomTypeName.Name = "txbRoomTypeName";
            this.txbRoomTypeName.Size = new System.Drawing.Size(193, 29);
            this.txbRoomTypeName.TabIndex = 23;
            this.txbRoomTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số lượng người tối đa:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoRoundedCorners = true;
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.BorderRadius = 13;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(38, 298);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(287, 29);
            this.btnAddCustomer.TabIndex = 67;
            this.btnAddCustomer.Text = "Lưu Thay Đổi";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnClose_
            // 
            this.btnClose_.AutoRoundedCorners = true;
            this.btnClose_.BackColor = System.Drawing.Color.Transparent;
            this.btnClose_.BorderRadius = 13;
            this.btnClose_.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose_.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose_.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose_.ForeColor = System.Drawing.Color.White;
            this.btnClose_.Location = new System.Drawing.Point(40, 370);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(287, 29);
            this.btnClose_.TabIndex = 68;
            this.btnClose_.Text = "Đóng";
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // fChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 448);
            this.Controls.Add(this.btnClose_);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Separator6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fChangeRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddCustomerInfo";
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private MetroFramework.Controls.MetroComboBox cbRoom;
        private MetroFramework.Controls.MetroComboBox cbRoomType;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbRoomName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbLimitPerson;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbRoomTypeName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnClose_;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
    }
}