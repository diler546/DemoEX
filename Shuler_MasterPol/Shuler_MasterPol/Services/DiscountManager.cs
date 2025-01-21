using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuler_MasterPol.Services
{
    /// <summary>
    /// Расчет скидок.
    /// </summary>
    internal class DiscountManager
    {
        /// <summary>
        /// PKGH
        /// Расчет скидки для партнера. 
        /// </summary>
        /// <param name="amount">Продажи продукции за весь период работы.</param>
        /// <returns>Величина скидки.</returns>
        public static int CalculateDiscount(double amount)
        {
            int discount = 0;

            if (amount >= 10_000 && amount < 50_000)
            {
                discount = 5;
            }
            else if (amount >= 50_000 && amount < 300_000)
            {
                discount = 10;
            }
            else if (amount >= 300_000)
            {
                discount = 15;
            }

            return discount;
        }
    }

}
