using System;
using System.Collections;
using System.Text;
using System.ComponentModel;

namespace PizzaPlace.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Order Order { get; set; }
    }
}
