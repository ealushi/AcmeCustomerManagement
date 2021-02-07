using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeCustomerManagement
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.Text = "Processing ...";
            }

            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate the customer instance 

            var order = new Order();
            // Populate the order instance
            
            var payment = new Payment();
            // Populate the payment info from the UI

            var orderController = new OrderController();
            try
            {
                orderController.PlaceOrder(customer, order, payment, allowSplitOrders: false, emailReceipt: true);
            }
            catch (ArgumentNullException ex)
            {
                // log the issue 
                // display a message to the user that the order was not successful
            }
            
        }
    }
}
