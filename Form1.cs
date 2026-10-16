using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhamAnhQuan_Bai1
{
    public partial class Form1 : Form
    {
        private BindingList<Device> devices;
        private BindingSource source;
        private ErrorProvider errorProvider;

        private int idCounter = 1;

        public Form1()
        {
            InitializeComponent();

            InitializeData();
            InitializeGrid();
            BindControls();
        }

        private void InitializeData()
        {
            devices = new BindingList<Device>();

            source = new BindingSource();
            source.DataSource = devices;

            errorProvider = new ErrorProvider();

            dgvDevices.DataSource = source;

            cboCategory.Items.AddRange(new string[]
            {
                "Laptop",
                "Điện thoại",
                "Máy tính bảng",
                "Phụ kiện"
            });

            cboCategory.SelectedIndex = -1;
        }

        private void InitializeGrid()
        {
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.ReadOnly = true;
            dgvDevices.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Mã thiết bị",
                DataPropertyName = "DeviceId"
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tên thiết bị",
                DataPropertyName = "DeviceName"
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Loại",
                DataPropertyName = "Category"
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Đơn giá",
                DataPropertyName = "Price",
                DefaultCellStyle =
                {
                    Format = "N0"
                }
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity"
            });
        }

        private void BindControls()
        {
            txtDeviceId.DataBindings.Add(
                "Text", source, "DeviceId");

            txtDeviceName.DataBindings.Add(
                "Text", source, "DeviceName");

            cboCategory.DataBindings.Add(
                "Text", source, "Category");

            txtPrice.DataBindings.Add(
                "Text", source, "Price");

            numQuantity.DataBindings.Add(
                "Value", source, "Quantity");
        }

        private bool ValidateInput()
        {
            bool valid = true;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(
                txtDeviceName.Text))
            {
                errorProvider.SetError(
                    txtDeviceName,
                    "Tên thiết bị không được để trống");

                valid = false;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(
                    cboCategory,
                    "Chọn loại thiết bị");

                valid = false;
            }

            decimal price;

            if (!decimal.TryParse(txtPrice.Text,
                out price) || price < 0)
            {
                errorProvider.SetError(
                    txtPrice,
                    "Đơn giá không hợp lệ");

                valid = false;
            }

            return valid;
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            devices.Add(new Device()
            {
                DeviceId = "TB" +
                    idCounter++.ToString("000"),

                DeviceName = txtDeviceName.Text,

                Category = cboCategory.Text,

                Price = decimal.Parse(
                    txtPrice.Text),

                Quantity =
                    (int)numQuantity.Value
            });

            ClearInput();
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (source.Current is Device device)
            {
                device.DeviceName =
                    txtDeviceName.Text;

                device.Category =
                    cboCategory.Text;

                device.Price =
                    decimal.Parse(txtPrice.Text);

                device.Quantity =
                    (int)numQuantity.Value;

                source.ResetBindings(false);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (source.Current == null)
                return;

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                source.RemoveCurrent();
            }
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            txtDeviceId.Clear();
            txtDeviceName.Clear();
            txtPrice.Clear();

            cboCategory.SelectedIndex = -1;

            numQuantity.Value = 0;

            errorProvider.Clear();
        }
    }
}