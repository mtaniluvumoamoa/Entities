using BusinessLayer;
using Entities;

namespace Lesson7
{
    public partial class Form1 : Form
    {
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
            txtName.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.NAME = txtName.Text;
            contact.Email = txtEmail.Text;
            contact.Tel = txtTel.Text;
            contact.Address = txtAddress.Text;

            contact = ContactService.Create(contact);
            LoadData();
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}