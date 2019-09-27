using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RecruitingExercise
{
    [TestClass]
    public class RecruitingTest
    {

        [TestMethod]
        public void SubscriptionsExpiredLastMonth()
        {
            var date = DateTime.Now.AddMonths(-1);

            var subscriptions = new List<Subscription>();

            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Netflix" });
            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Amazon Prime" });

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };
            
            Assert.IsTrue(user.ExpiredSubscriptions == 2, "Expected expired subscriptions: 2 - Your code returns: {0}", user.ExpiredSubscriptions);

        }


        [TestMethod]
        public void SubscriptionsExpiringNextMonth()
        {
            var date = DateTime.Now.AddMonths(1);

            var subscriptions = new List<Subscription>();

            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Netflix" });
            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Amazon Prime" });

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.IsTrue(user.ExpiredSubscriptions == 0, "Expected expired subscriptions: 0 - Your code returns: {0}", user.ExpiredSubscriptions);
        }

        [TestMethod]
        public void SubscriptionsExpiredLastYear()
        {
            var date = DateTime.Now.AddYears(-1);

            var subscriptions = new List<Subscription>();

            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Netflix" });
            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Amazon Prime" });

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.IsTrue(user.ExpiredSubscriptions == 2, "Expected expired subscriptions: 2 - Your code returns: {0}", user.ExpiredSubscriptions);
        }

        [TestMethod]
        public void SubscriptionsExpiredLastYearPreviousMonth()
        {
            var date = DateTime.Now.AddYears(-1).AddMonths(-1);
            var subscriptions = new List<Subscription>();

            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Netflix" });
            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Amazon Prime" });

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.IsTrue(user.ExpiredSubscriptions == 2, "Expected expired subscriptions: 2 - Your code returns: {0}", user.ExpiredSubscriptions);
        }

        [TestMethod]
        public void SubscriptionsExpiringNextYearNextMonth()
        {
           
            var date = DateTime.Now.AddYears(1).AddMonths(1);

            var subscriptions = new List<Subscription>();

            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Netflix" });
            subscriptions.Add(new Subscription(date.Month, date.Year) { Name = "Amazon Prime" });

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            Assert.IsTrue(user.ExpiredSubscriptions == 0, "Expected expired subscriptions: 0 - Your code returns: {0}", user.ExpiredSubscriptions);
            
        }
    }
}
