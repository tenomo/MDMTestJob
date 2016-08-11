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
            CustomersGridView.DataSource = customerRepository.Customers.ToList();
            OrdersGridView.DataSource = orderRepository.Orders.ToList();
        }

        /// <summary>
        /// Select customer by clic on row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectCustomer = this.customerRepository.Customers.Where(
               cust => cust.CustomerId == (int)CustomersGridView.Rows[e.RowIndex].
               Cells[0].Value).FirstOrDefault<Customer>();

            OrdersGridView.DataSource = this.orderRepository.Orders.Where(
                order => order.CustomerId == SelectCustomer.CustomerId).ToList();

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

         
        private void UpdateDatagrid(object o)
        {
            CustomersGridView.DataSource = customerRepository.Customers.ToList();
            OrdersGridView.DataSource = orderRepository.Orders.ToList();
        }


        /// <summary>
        /// Edit customer in edit form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = this.customerRepository.Customers.Where(
                cust => cust.CustomerId == (int)CustomersGridView.Rows[e.RowIndex].
                Cells[0].Value).ToList().FirstOrDefault<Customer>();

            CustomerEditForm customerEditForm = new CustomerEditForm(customer);
            customerEditForm.Show();


            customerEditForm.AddedSuccessfully += UpdateDatagrid;
        }

        /// <summary>
        /// Deleted selected customer and him orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelCustBtn_Click(object sender, EventArgs e)
        {
           IEnumerable<Order> customerOrders = 
                orderRepository.Orders.Where(order => order.CustomerId == SelectCustomer.CustomerId).ToList();


            if (customerOrders.Count() > 0)
            {
                var result = new System.Windows.Forms.DialogResult();

                result = MessageBox.Show("Are you sure you want to remove him ?",
                    "this customer has "+customerOrders.Count()+" orders",
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
            // форма редактирования заказа
            OrderEditForm orderEditForm = new OrderEditForm(SelectOrder);

            orderEditForm.AddedSuccessfully += UpdateDatagrid;
            orderEditForm.Show();
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
            // удалить заказ
        }

        private void OrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectOrder = this.orderRepository.Orders.Where(
              order => order.OrderId == (int)OrdersGridView.Rows[e.RowIndex].
              Cells[0].Value).First<Order>();
        }
    }
}
