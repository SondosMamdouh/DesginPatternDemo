using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadDemo
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public string PrintLabel()
        {
            return Customer.CompanyName + "\n" + Customer.Address;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    public class Customer
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }

    }
    public class OrderFactory
    {
        public Order CreateFromId(int id)
        {
            return new OrderProxy()
            {
                Id = id
            };
        }
    }
    public class OrderProxy : Order
    {
        public override Customer Customer
        {
            get
            {
                if (base.Customer == null)
                {
                    base.Customer = new Customer();
                }
                return base.Customer;
            }
            set
            {
                base.Customer = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Order;
            if (other == null) return false;
            return other.Id == this.Id;
        }
    }
}
