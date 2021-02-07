using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;

namespace ACM.BLTests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //-- Arrange 
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "deborahk@insteptech.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act 
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }
    }
}