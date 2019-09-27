using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitingExercise
{
    class User
    {
        
        /// <summary>
        /// The name of the user
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// The user's chosen payment type
        /// </summary>
        internal PaymentType PaymentType { get; set; }

        /// <summary>
        /// The user's subscriptions
        /// </summary>
        internal IEnumerable<Subscription> Subscriptions { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="User" /> class. 
        /// </summary>
        /// <param name="subscriptions">The subscriptions the user has.</param>
        public User(IEnumerable<Subscription> subscriptions)
        {
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// The number of expired subscriptions the user has
        /// </summary>
        internal int ExpiredSubscriptions 
        {
            get
            {                
                var expired = 0;
                var n = DateTime.Now.AddMonths(0);
                foreach (var subsc in Subscriptions) {
                    if (subsc.ExpirationMonth <= n.Month ){ expired++; }
                }
                return expired;
            }
        }

    }
}
