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
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            // arrange
            var customer1 = new Customer()
            {
                Name = "testuser1",
                CustomerID = 1
            };

            var customer2 = new Customer()
            {
                Name = "customer2",
                CustomerID = 2
            };

            var seller = new Seller()
            {
                Name = "sellername",
                SellerID = 1
            };

            var product1 = new Product()
            {
                ProductID = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };

            var product2 = new Product()
            {
                ProductID = 2,
                Name = "prod2",
                Price = 200,
                Count = 20
            };

            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            var cart2 = new Cart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);

            var cashDesk = new CashDesk(1, seller);
            cashDesk.MaxQueueLength = 10;
            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);

            var cart1ExpectedResult = 400;
            var cart2ExpectedResult = 500;

            // act
            var cart1ActualResult = cashDesk.Dequeue();
            var cart2ActualResult = cashDesk.Dequeue();

            // assert
            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(17, product2.Count);
        }
    }
}