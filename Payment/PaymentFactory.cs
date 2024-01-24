using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORYPATTERN.Payment
{
    public class PaymentFactory
    {
        public static IPayment create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.GooglePay:
                    return new GooglPayPayment();
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                case PaymentMethod.ApplePay:
                    return new ApplePay();

                default:
                    throw new NotSupportedException
                    (
                        $"{paymentMethod} is not currently supported as a payment method."
                    );

            }
        }
    }
}

