using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitingExercise
{
    class Subscription
    {

        /// <summary>
        /// The name of the subscribed service
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// The month the subscription expires
        /// </summary>
        internal int ExpirationMonth { get; private set; }

        /// <summary>
        /// The year the subscription expires
        /// </summary>
        internal int ExpirationYear { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="expirationMonth">The month the subscription expires</param>
        /// <param name="expirationYear">The year the subscription expires</param>
        public Subscription(int expirationMonth, int expirationYear)
        {
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
        }

    }
}
