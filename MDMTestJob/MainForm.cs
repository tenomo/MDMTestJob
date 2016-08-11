using MDMTestJob.Domian.Abstract;
using MDMTestJob.Domian.Concrete;
using System;
using System.Windows.Forms;
using System.Linq;
using MDMTestJob.Domian.Entity;

namespace MDMTestJob
{
    public partial class MainForm : Form
    {
        IOrderRepository orderRepository;
        ICustomerRepository customerRepository;

        public MainForm()
        {
            InitializeComponent();

            orderRepository = OrderRepository.Instance;
            customerRepository =   CustomerRepository.Instance;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomersGridView.DataSource = customerRepository.Customers.ToList();
            OrdersGridView.DataSource = orderRepository.Orders.ToList();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectCustomerId = (int) CustomersGridView.Rows[e.RowIndex].Cells[0].Value; 
            OrdersGridView.DataSource = this.orderRepository.Orders.Where(order => order.CustomerId == selectCustomerId).ToList();
        }


        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            CustomerEditForm customerEditForm = new CustomerEditForm();
            customerEditForm.Show();
        }

        private void DelCustBtn_Click(object sender, EventArgs e)
        {
            // удаления кастомера
        }

        private void CustomersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = this.customerRepository.Customers.Where(
                cust => cust.CustomerId == (int)CustomersGridView.Rows[e.RowIndex].Cells[0].Value).ToList()[0] as Customer;

            CustomerEditForm customerEditForm = new CustomerEditForm(customer);
            customerEditForm.Show();
        }


        private void OrdersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // форма редактирования заказа
            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // форма добвления заказа 
            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // удалить заказ
        }
    }
}
