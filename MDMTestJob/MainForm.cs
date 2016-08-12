using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Concrete;
using System;
using System.Windows.Forms;
using System.Linq;
using MDMTestJob.Domian.Entity;
using System.Collections.Generic;

namespace MDMTestJob
{
    public partial class MainForm : Form
    {
        IOrderRepository orderRepository;
        ICustomerRepository customerRepository;

        private Customer SelectCustomer;
        private Order SelectOrder;

        public MainForm()
        {
            InitializeComponent();

            orderRepository = OrderRepository.Instance;
            customerRepository = CustomerRepository.Instance;

        }

        
      
            


        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDatagrid(null);
        }

        /// <summary>
        /// Select customer by clic on row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.SelectCustomer = this.customerRepository.Customers.Where(
                   cust => cust.CustomerId == (int)CustomersGridView.Rows[e.RowIndex].
                   Cells[0].Value).FirstOrDefault<Customer>();

                OrdersGridView.DataSource = this.orderRepository.Orders.Where(
                    order => order.CustomerId == SelectCustomer.CustomerId).ToList();
            }
            catch
            {
                MessageBox.Show("The table is empty");
            }
        }

        /// <summary>
        /// Add new customer in edit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            CustomerEditForm customerEditForm = new CustomerEditForm();
            customerEditForm.Show();
            customerEditForm.AddedSuccessfully += UpdateDatagrid;
        }       
       
        
        /// <summary>
        /// Edit customer in edit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Customer customer = this.customerRepository.Customers.Where(
                    cust => cust.CustomerId == (int)CustomersGridView.Rows[e.RowIndex].
                    Cells[0].Value).ToList().FirstOrDefault<Customer>();
                CustomerEditForm customerEditForm = new CustomerEditForm(customer);
                customerEditForm.Show();


                customerEditForm.AddedSuccessfully += UpdateDatagrid;
            }

            catch 
            {
                MessageBox.Show("The table is empty");
            }
        }

        /// <summary>
        /// Deleted selected customer and him orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelCustBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<Order> customerOrders = null;
            try
            {

                customerOrders = orderRepository.Orders.Where(order => order.CustomerId == SelectCustomer.CustomerId).ToList();
            }
            catch
            {
                MessageBox.Show("Do not select the customer, or the table is empty");
            }


            if (customerOrders != null && customerOrders.Count()>0)
            {
                var result = new System.Windows.Forms.DialogResult();

                result = MessageBox.Show("Are you sure you want to remove him ?",
                    "this customer has " + customerOrders.Count() + " orders",
                                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    orderRepository.DeleteByCustomer(SelectCustomer.CustomerId);
                    this.customerRepository.Delete(SelectCustomer.CustomerId);
                }
            }
            else
            {
                this.customerRepository.Delete(SelectCustomer.CustomerId);

            }

            this.UpdateDatagrid(null);
        }



        /// <summary>
        /// Edit order in edit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                OrderEditForm orderEditForm = new OrderEditForm(SelectOrder);

                orderEditForm.AddedSuccessfully += UpdateDatagrid;
                orderEditForm.Show();
            }
            catch
            {
                MessageBox.Show("Do not select the order, or the table is empty");
            }
        }

        /// <summary>
        /// Edit order in edit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // форма добвления заказа 

            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.AddedSuccessfully += UpdateDatagrid;
            orderEditForm.Show();
        }

        /// <summary>
        /// Deleted selected order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderRepository.Delete(SelectOrder.OrderId);
            }
            catch
            {
                MessageBox.Show("Do not select the order, or the table is empty");
            }
            this.UpdateDatagrid(null);
        }

        private void OrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.SelectOrder = this.orderRepository.Orders.Where(
                  order => order.OrderId == (int)OrdersGridView.Rows[e.RowIndex].
                  Cells[0].Value).First<Order>();
            }
            catch
            {
                MessageBox.Show("The table is empty");
            }
        }
       

        private void UpdateDatagrid(object o)
        {
            CustomersGridView.DataSource = customerRepository.Customers.ToList();
            OrdersGridView.DataSource = orderRepository.Orders.ToList();

            CustomersGridView.Columns[0].HeaderText = "Id";
            CustomersGridView.Columns[3].HeaderText = "Phone number";

            OrdersGridView.Columns[1].HeaderText = "Id";
            OrdersGridView.Columns[1].HeaderText = "Customer id";
            OrdersGridView.Columns[4].HeaderText = "Due time";
            OrdersGridView.Columns[4].HeaderText = "Processed time";

        }
    }
}
