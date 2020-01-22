﻿using System;
using System.Collections.Generic;

namespace CRM.BusinessLogic.Model
{
    public class Generator
    {
        Random random = new Random();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();

            for(int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerID = Customers.Count,
                    Name = GetRandomText()
                };
                Customers.Add(customer);
                result.Add(customer);
            }

            return result;
        }

        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerID = Sellers.Count,
                    Name = GetRandomText()
                };
                Sellers.Add(seller);
                result.Add(seller);
            }

            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductID = Customers.Count,
                    Name = GetRandomText(),
                    Count = random.Next(10, 1000),
                    Price = Convert.ToDecimal(random.Next(5, 100000) + random.NextDouble())
                };
                Products.Add(product);
                result.Add(product);
            }

            return result;
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();
            var count = random.Next(min, max);

            for(int i = 0; i < count; i++)
            {
                result.Add(Products[random.Next(Products.Count - 1)]);
            }

            return result;
        }

        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}
