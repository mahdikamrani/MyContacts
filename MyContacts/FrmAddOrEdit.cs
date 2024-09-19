using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class FrmAddOrEdit : Form
    {
        IContactsRepository repository;
        public int ContactID = 0;
        public FrmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (ContactID == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش شخض";
                DataTable dt = repository.selectRow(ContactID);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                txtAge.Text = dt.Rows[0][4].ToString();
                txtMobile.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "ویرایش";
            }
        }

        bool ValidateInpute()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد نمائید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی خود را وارد نمائید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا شماره موبایل خود را وارد نمائید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Value == 0)
            {
                MessageBox.Show("لطفا سن خود را وارد نمائید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمبل خود را وارد نمائید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInpute())
            {

                bool isSuccess;

                if (ContactID == 0)
                {
                    isSuccess = repository.insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }
                else
                {
                  isSuccess = repository.update(ContactID,txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }

                if (isSuccess = true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;

                    

                }
                else
                {
                    MessageBox.Show(" عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
