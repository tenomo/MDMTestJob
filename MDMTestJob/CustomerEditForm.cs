using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Concrete;
using MDMTestJob.Domian.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDMTestJob
{
    public partial class CustomerEditForm : Form
    {
        Customer otherCustomer;

        public CustomerEditForm( )
        {
            InitializeComponent();

            
        }
        public CustomerEditForm(Customer customer)
        {
            InitializeComponent();
            otherCustomer = customer;

            this.NameTextBox.Text = otherCustomer.Name;
            this.AddressTextBoc.Text = otherCustomer.Address;
            this.PhoneNumTextBox.Text = otherCustomer.PhoneNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (this.NameTextBox.Text !=null &&
                this.AddressTextBoc.Text!=null && 
                this.PhoneNumTextBox.Text!=null)
            {

                if (otherCustomer == null)
                    otherCustomer = new Customer();
                
                otherCustomer.Address = this.AddressTextBoc.Text;
                otherCustomer.Name = this.NameTextBox.Text;
                otherCustomer.PhoneNum = this.PhoneNumTextBox.Text;

                CustomerRepository.Instance.Save(otherCustomer);

                this.Close();
            }

            else
            {
                MessageBox.Show("Fields may not contain empty fields");
            }
        }
    }
}
