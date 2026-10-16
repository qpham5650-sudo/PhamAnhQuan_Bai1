namespace  PhamAnhQuan_Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.ComboBox cboCategory;

        private System.Windows.Forms.NumericUpDown numQuantity;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvDevices;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDeviceId = new TextBox();
            txtDeviceName = new TextBox();
            txtPrice = new TextBox();

            cboCategory = new ComboBox();

            numQuantity = new NumericUpDown();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvDevices = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dgvDevices)).BeginInit();

            SuspendLayout();

            // txtDeviceId
            txtDeviceId.Location = new Point(20, 20);
            txtDeviceId.Size = new Size(150, 23);
            txtDeviceId.ReadOnly = true;

            // txtDeviceName
            txtDeviceName.Location = new Point(20, 60);
            txtDeviceName.Size = new Size(250, 23);

            // cboCategory
            cboCategory.Location = new Point(20, 100);
            cboCategory.Size = new Size(200, 23);
            cboCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // txtPrice
            txtPrice.Location = new Point(20, 140);
            txtPrice.Size = new Size(150, 23);

            // numQuantity
            numQuantity.Location = new Point(20, 180);
            numQuantity.Size = new Size(120, 23);

            // btnAdd
            btnAdd.Location = new Point(350, 20);
            btnAdd.Size = new Size(100, 35);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;

            // btnUpdate
            btnUpdate.Location = new Point(460, 20);
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Location = new Point(350, 70);
            btnDelete.Size = new Size(100, 35);
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;

            // btnClear
            btnClear.Location = new Point(460, 70);
            btnClear.Size = new Size(100, 35);
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;

            // dgvDevices
            dgvDevices.Location = new Point(20, 230);
            dgvDevices.Size = new Size(760, 250);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(800, 520);

            Controls.Add(txtDeviceId);
            Controls.Add(txtDeviceName);
            Controls.Add(cboCategory);
            Controls.Add(txtPrice);
            Controls.Add(numQuantity);

            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(dgvDevices);

            Text = "Quản lý thiết bị điện tử";

            ((System.ComponentModel.ISupportInitialize)(numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dgvDevices)).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
