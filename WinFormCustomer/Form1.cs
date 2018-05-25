using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory;
using CustomerInterface;
using InterfaceDal;
using MiddleLayer;

namespace WinFormCustomer
{
    public partial class Form1 : Form
    {
        public ICustomer customer = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Customer")
            {
                customer = null;
                customer = FactoryCustomer.Create("Customer");
            }
            if (comboBox1.Text == "Lead")
            {
                customer = null;
                customer = FactoryCustomer.Create("Lead");
            }

            //initial values
            customer.CustomerName = textBox_CustomerName.Text;
            customer.PhoneNumber = textBox1_PhoneNumber.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                customer.Validate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_CustomerName_TextChanged(object sender, EventArgs e)
        {
            customer.CustomerName = textBox_CustomerName.Text;
        }

        private void textBox1_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            customer.PhoneNumber = textBox1_PhoneNumber.Text;
        }

        private void textBox1_BillAmount_TextChanged(object sender, EventArgs e)
        {
            customer.BillAmount = Convert.ToDecimal(textBox1_BillAmount.Text);
        }

        private void dateTimePicker1_BillDate_ValueChanged(object sender, EventArgs e)
        {
            customer.BillDate = dateTimePicker1_BillDate.Value;
        }

        private void textBox1_Address_TextChanged(object sender, EventArgs e)
        {
            customer.Address = textBox1_Address.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadGrid();
        }

        private List<CustomerBase> LoadGrid()
        {
            IDAL<CustomerBase> dal = null;
            dal = FactoryCustomer.CreateDAL("CustomerDAL");

            return dal.GetAll();
        }
    }
}
