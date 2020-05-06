using System;

namespace _02._05._2020task
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("678904", "Alex", "Foxtrot") { Article = ("USB-hab").ToLower(), Quantity = "6" };
            inv.CostCalculation(true);
        }
    }

    class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { get; set; }
        public string Quantity { get; set; }

        double cost;
        private void GetCost()
        {
            switch (Article)
            {
                case "usb-hab":
                    cost = 12;
                    break;
                case "sd-card":
                    cost = 30;
                    break;
                case "notbook":
                    cost = 1400;
                    break;
                default:
                    break;
            }
        }

        public void CostCalculation(bool needEdv)
        {
            GetCost();
            double total = 0;

            if (needEdv)
            {
                double edv = cost * 0.18;
                total = cost * Int32.Parse(Quantity) + edv;
            }
            else if (!needEdv)
            {
                total = cost * Int32.Parse(Quantity);
            }
            Console.WriteLine($"Total cost is {total}");
        }
    }
}
