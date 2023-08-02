using BusinessLayer;
using Entities;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lesson0007
{
    public partial class Form1 : Form
    {
        int selectedIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (ContactService.GetAll().Count >= 0)
            {
                dataGridView.DataSource = ContactService.GetAll();
            }
        }
        private void ClearData()
        {
            txtName.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.ID = selectedIndex;
            contact.NAME = txtName.Text;
            contact.Email = txtEmail.Text;
            contact.Tel = txtTel.Text;
            contact.Address = txtAddress.Text;

            ContactService.Create(contact);
            LoadData();
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.ID = selectedIndex;
            contact.NAME = txtName.Text;
            contact.Email = txtEmail.Text;
            contact.Tel = txtTel.Text;
            contact.Address = txtAddress.Text;

            ContactService.Update(contact);
            LoadData();
            ClearData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.ID = selectedIndex;
            contact.NAME = txtName.Text;
            contact.Email = txtEmail.Text;
            contact.Tel = txtTel.Text;
            contact.Address = txtAddress.Text;

            ContactService.Delete(contact);
            LoadData();
            ClearData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                selectedIndex = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (dataGridView.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    txtName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    txtName.Text = string.Empty;
                }
                if (dataGridView.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    txtEmail.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    txtEmail.Text = string.Empty;
                }
                if (dataGridView.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    txtTel.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    txtTel.Text = string.Empty;
                }
                if (dataGridView.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    txtAddress.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    txtAddress.Text = string.Empty;
                }
            }
            else
            {
                selectedIndex = -1;
            }

        }

        
    }

}