using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace MyContacts
{
    public partial class ContactsForm : Form
    {
        IContactsRepository repository;


        public ContactsForm()
        {
            InitializeComponent();

            repository = new ContactsRepository();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;

            dgContacts.DataSource = repository.selectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frm = new FrmAddOrEdit();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                BindGrid();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (dgContacts.SelectedRows != null)
            {
                string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
                string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string FullName = name + family;
                if (MessageBox.Show($"آیا از حذف {FullName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes) ;

                {
                    int ContactID = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                    repository.delete(ContactID);

                    BindGrid();

                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.SelectedRows != null)
            {
                int ContactID = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());

                FrmAddOrEdit frm = new FrmAddOrEdit();

                frm.ContactID = ContactID;

                if(frm.ShowDialog() ==  DialogResult.OK)
                {

                    BindGrid();
                }


            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید");
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
          dgContacts.DataSource =  repository.search(txtSearchBox.Text);
        }
    }
}
