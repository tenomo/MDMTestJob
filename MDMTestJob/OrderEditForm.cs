using System;
using System.Linq;
using System.Windows.Forms;
using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Concrete;
using MDMTestJob.Domian.Entity;

namespace MDMTestJob
{
    public partial class OrderEditForm : Form
    {
        public OrderEditForm()
        {
            InitializeComponent();
            otherOreder = new Order();
        }
        public OrderEditForm(Order order)
        {
            InitializeComponent();
            otherOreder = order;

            this.AmountTextBox.Text = order.Amount.ToString();
            this.DescriptionTextBox.Text = order.Description;
            this.DueTimeTextBox.Text = order.DueTime.ToString();
            this.NumberTextBox.Text = order.Number.ToString();
        }


        Order otherOreder;

        ICustomerRepository customerRepository;
        IOrderRepository orderRepository;
        public event AddedSuccessfullyEventHandler AddedSuccessfully;


        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            customerRepository = CustomerRepository.Instance;
            orderRepository = OrderRepository.Instance;
            this.customersComboBox.Items.AddRange(customerRepository.Customers.ToArray());
            this.customersComboBox.DisplayMember = "Name";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (this.AmountTextBox.Text != null &&
                this.DescriptionTextBox.Text != null &&
                this.NumberTextBox.Text != null &&
                this.DescriptionTextBox.Text != null &&
                this.DueTimeTextBox.Text != null
                )
            {
                try
                {
                    otherOreder.Amount = Convert.ToInt32(AmountTextBox.Text);
                    MessageBox.Show((customersComboBox.SelectedItem as Customer).CustomerId.ToString());
                    otherOreder.CustomerId = (customersComboBox.SelectedItem as Customer).CustomerId;
                    otherOreder.Description = DescriptionTextBox.Text;
                    otherOreder.DueTime = DueTimeTextBox.Text;
                    otherOreder.Number = NumberTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("Incorrectly filled entry fields");
                }

               orderRepository.Save(otherOreder);
                if (AddedSuccessfully != null)
                {
                    AddedSuccessfully(otherOreder);
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
    }
}    
