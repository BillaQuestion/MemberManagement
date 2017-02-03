using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model
{
    public class Member : Visitor
    {
        /// <summary>
        /// string meida, int count.
        /// </summary>
        private IDictionary<string, int> _balance;

        #region Properties
        public String Name { get; set; }

        public string ContactNumber { get; set; }

        public Gender Gender { get; set; }

        public String Address { get; set; }

        public IDictionary<string, int> Balance { get; }
        #endregion
        
        #region Public Methods
        public void BuyBusinessCard(BusinessCard businessCard)
        {
            this._balance.Add(businessCard.Media, businessCard.CountOfMedia);
        }

        /// <summary>
        /// Use business card from the BusinessCard collection.
        /// Throw excpetion when there's no card.
        /// Throw exception when cards has no enough Media.
        /// Remove card with no Media left.
        /// </summary>
        public void UseBusinessCard()
        {

        }

        /// <summary>
        /// Use business card from the BusinessCard collection.
        /// </summary>
        /// <param name="number">number of Media to be used</param>
        public void UseBusinessCard(int number)
        {

        }
        #endregion

        #region Prrivate Methods
        #endregion
    }
}
