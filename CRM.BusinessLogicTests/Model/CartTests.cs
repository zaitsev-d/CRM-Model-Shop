﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM.BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BusinessLogic.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            // arrange
            var customer = new Customer()
            {
                CustomerID = 1,
                Name = "TestUser"
            };
            var product1 = new Product()
            {
                ProductID = 1,
                Name = "product1",
                Price = 100,
                Count = 1000
            };
            var product2 = new Product()
            {
                ProductID = 1,
                Name = "product2",
                Price = 200,
                Count = 20
            };
            var cart = new Cart(customer);

            var expectedResult = new List<Product>()
            {
                product1, product1, product2, product2, product2
            };

            // act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);
            cart.Add(product2);
            cart.Add(product2);

            var cartResult = cart.GetAll();

            // assert
            Assert.AreEqual(expectedResult.Count, cart.GetAll().Count);
            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
        }
    }
}