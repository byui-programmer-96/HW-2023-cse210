using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two products
            Product product1 = new Product("Product 1", "P001", 10.99, 2);
            Product product2 = new Product("Product 2", "P002", 5.99, 3);

            // Create a customer
            Address address = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer = new Customer("John Doe", address);

            // Create an order
            Order order = new Order(customer);
            order.AddProduct(product1);
            order.AddProduct(product2);

            // Display the packing label
            Console.WriteLine(order.GetPackingLabel());

            // Display the shipping label
            Console.WriteLine(order.GetShippingLabel());

            // Display the total price
            Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
        }
    }

    class Product
    {
        private string name;
        private string id;
        private double price;
        private int quantity;

        public Product(string name, string id, double price, int quantity)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetId()
        {
            return id;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetTotalPrice()
        {
            return price * quantity;
        }
    }

    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }
    }

    class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public string GetStreet()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetState()
        {
            return state;
        }

        public string GetCountry()
        {
            return country;
        }

        public bool IsInUSA()
        {
            return country == "USA";
        }

        public string GetFullAddress()
        {
            return $"{street}\n{city}, {state} {country}";
        }
    }

    class Order
    {
        private Customer customer;
        private Product[] products;
        private int productCount;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new Product[10];
            productCount = 0;
        }

        public void AddProduct(Product product)
        {
            products[productCount] = product;
            productCount++;
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                if (product != null)
                {
                    totalPrice += product.GetTotalPrice();
                }
            }
            if (customer.IsInUSA())
            {
                totalPrice += 5;
            }
            else
            {
                totalPrice += 35;
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in products)
            {
                if (product != null)
                {
                    packingLabel += $"{product.GetName()} ({product.GetId()})\n";
                }
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }
}