﻿using MDMTestJob.Domian.Concrete;
using MDMTestJob.Domian.Entity;
using System;
using System.Windows.Forms;

namespace MDMTestJob
{

    public delegate void AddedSuccessfullyEventHandler (object e);
    public partial class CustomerEditForm : Form
    {

        public event AddedSuccessfullyEventHandler AddedSuccessfully;
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
                
                otherCustomer.Address = this.AddressTextBoc.Text;
                otherCustomer.Name = this.NameTextBox.Text;
                otherCustomer.PhoneNum = this.PhoneNumTextBox.Text;
                CustomerRepository.Instance.Save(otherCustomer);

                if (AddedSuccessfully != null)
                {
                    AddedSuccessfully(otherCustomer);
                }
                this.Close();
            }

            else
            {
                MessageBox.Show("Fields may not contain empty fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
