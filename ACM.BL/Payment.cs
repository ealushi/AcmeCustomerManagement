using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }



        public void ProcessPayment(Payment payment)
        {
            PaymentType paymentTypeOption;
            if (!Enum.TryParse(PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", PaymentType, typeof(PaymentType));
            }

            switch ((PaymentType)PaymentType)
            {
                case BL.PaymentType.CreditCard:
                    // Process credit card 
                    break;

                case BL.PaymentType.PayPal:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }

            // Open a connection 
            // Set stored procedure parameters with payment data. 
            // Call the save stored procedure. 
        }
    }
}
