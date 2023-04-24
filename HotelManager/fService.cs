﻿using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fService : Form
    {
        #region Properties
        fServiceType _fServiceType;
        #endregion

        #region Constructor
        public fService()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            LoadFullServiceType();
            LoadFullService(GetFullService());
            comboboxID.DisplayMember = "id";
            txbSearch.KeyPress += TxbSearch_KeyPress;
            KeyPreview = true;
            KeyPress += FService_KeyPress;
            dataGridViewService.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        }


        #endregion

        #region Load
        private void LoadFullService(DataTable table)
        {
            BindingSource source = new BindingSource();
            ChangePrice(table);
            source.DataSource = table;
            dataGridViewService.DataSource = source;

            comboboxID.DataSource = source;
        }
        private void LoadFullServiceType()
        {
            DataTable table = GetFullServiceType();
            comboBoxServiceType.DataSource = table;
            comboBoxServiceType.DisplayMember = "name";
            ;
            if (table.Rows.Count > 0)
                comboBoxServiceType.SelectedIndex = 0;
            _fServiceType = new fServiceType(table);
        }
        #endregion

        #region Click
        private void BtnInsertService_Click(object sender, EventArgs e)
        {
            new fAddService().ShowDialog();
            LoadFullService(GetFullService());
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Bạn có muốn cập nhật lại dịch vụ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
                UpdateService();
            comboboxID.Focus();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnServiceType_Click(object sender, EventArgs e)
        {
            this.Hide();
            _fServiceType.ShowDialog();
            this.LoadFullService(GetFullService());
            comboBoxServiceType.DataSource = _fServiceType.TableSerViceType;
            this.Show();
        }
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txbName.Text = string.Empty;
            txbPrice.Text = string.Empty;
        }
        private void BtnCLose1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Text = txbSearch.Text.Trim();
            if (txbSearch.Text != string.Empty)
            {
                txbName.Text = string.Empty;
                txbPrice.Text = string.Empty;
                btnSearch.Visible = false;
                Search();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadFullService(GetFullService());
            btnSearch.Visible = true;
        }
        #endregion

        #region Method
        private void ChangeText(DataGridViewRow row)
        {

        }
        
        private void UpdateService()
        {
            if (comboboxID.Text == string.Empty)
                MessageBox.Show( "Dịch vụ không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            if (!fCustomer.CheckFillInText(new Control[] { txbName, comboBoxServiceType, txbPrice }))
            {
                MessageBox.Show( "Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Service servicePre = groupService.Tag as Service;
                try
                {
                    Service serviceNow = GetServiceNow();
                    if (serviceNow.Equals(servicePre))
                    {
                        MessageBox.Show( "Bạn chưa thay đổi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool check = ServiceDAO.Instance.UpdateService(serviceNow, servicePre);
                        if (check)
                        {
                            MessageBox.Show( "Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            groupService.Tag = serviceNow;
                                int index = dataGridViewService.SelectedRows[0].Index;
                                LoadFullService(GetFullService());
                                comboboxID.SelectedIndex = index;
                        }
                        else
                            MessageBox.Show( "Dịch vụ không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch
                {
                    MessageBox.Show( "Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Search()
        {
            LoadFullService(GetSearchService());
        }
        #endregion

        #region Get Data
        private DataTable GetFullService()
        {
            return ServiceDAO.Instance.LoadFullService();
        }
        private DataTable GetFullServiceType()
        {
            return ServiceTypeDAO.Instance.LoadFullServiceType();
        }
        private Service GetServiceNow()
        {
            Service service = new Service();
            if (comboboxID.Text == string.Empty)
                service.Id = 0;
            else
                service.Id = int.Parse(comboboxID.Text);
            txbName.Text = txbName.Text.Trim();
            service.Name = txbName.Text;
            service.Price = int.Parse(StringToInt(txbPrice.Text));
            int index = comboBoxServiceType.SelectedIndex;
            service.IdServiceType = (int)((DataTable)comboBoxServiceType.DataSource).Rows[index]["id"];
            return service;
        }
        private DataTable GetSearchService()
        {
            if (int.TryParse(txbSearch.Text, out int id))
                return ServiceDAO.Instance.Search(txbSearch.Text, id);
            else
                return ServiceDAO.Instance.Search(txbSearch.Text, 0);
        }
        #endregion

        #region Change
        private void DataGridViewService_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewService.SelectedRows[0];
                ChangeText(row);
            }
        }
        private void ChangePrice(DataTable table)
        {
            table.Columns.Add("price_New", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
        }
        private string StringToInt(string text)
        {
            if (text.Contains(".") || text.Contains(" "))
            {
                string[] vs = text.Split(new char[] { '.', ' ' });
                StringBuilder textNow = new StringBuilder();
                for (int i = 0; i < vs.Length - 1; i++)
                {
                    textNow.Append(vs[i]);
                }
                return textNow.ToString();
            }
            else return text;
        }
        private string IntToString(string text)
        {
            if (text == string.Empty)
                return 0.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            if (text.Contains(".") || text.Contains(" "))
                return text;
            else
                return (int.Parse(text).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN")));
        }
        #endregion

        #region Key
        private void TxbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void TxbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnSearch_Click(sender, null);
        }
        private void FService_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        #region Enter
        private void TxbPrice_Enter(object sender, EventArgs e)
        {
            txbPrice.Tag = txbPrice.Text;
            txbPrice.Text = StringToInt(txbPrice.Text);
        }
        private void TxbName_Enter(object sender, EventArgs e)
        {
            txbName.Tag = txbName.Text;
        }

        #endregion

        #region Leave
        private void TxbPrice_Leave(object sender, EventArgs e)
        {
            if (txbPrice.Text == string.Empty)
                txbPrice.Text = txbPrice.Tag as string;
            else
                txbPrice.Text = IntToString(txbPrice.Text);
        }
        private void TxbName_Leave(object sender, EventArgs e)
        {
            if (txbName.Text == string.Empty)
                txbName.Text = txbName.Tag as string;
        }
        #endregion

        #region Close
        private void FService_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnCancel_Click(sender, null);
        }
        #endregion
    }
}