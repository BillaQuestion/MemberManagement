using MM.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.Model.Enums;

namespace MM.Model
{
    public class Member
    {
        /// <summary>
        /// string medium, int count.
        /// </summary>
        private IDictionary<string, int> _remainingMedium;

        #region Properties
        public String Name { get; set; }

        public string ContactNumber { get; set; }

        public Gender Gender { get; set; }

        public String Address { get; set; }

        public IDictionary<string, int> RemainingMedium { get { return _remainingMedium; } }
        #endregion

        public Member()
        {
            _remainingMedium = new Dictionary<string, int>();
        }

        #region Public Methods
        public void BuyBusinessCard(BusinessCard businessCard)
        {
            var result = _remainingMedium.FirstOrDefault(x => x.Key == businessCard.Medium);
            if (result.Equals(new KeyValuePair<string, int>(null, 0)))
            {
                _remainingMedium.Add(businessCard.Medium, businessCard.CountOfMedium);
            }
            else
            {
                _remainingMedium[result.Key] = result.Value + businessCard.CountOfMedium;
            }
        }

        /// <summary>
        /// Decrease the Balance with a specific medium.
        /// Throw exception when there's no enough specific medium.
        /// </summary>
        /// <param name="medium">medium to be used</param>
        public void UseBusinessCard(string medium)
        {
            var result = _remainingMedium.FirstOrDefault(x => x.Key == medium);
            //not found
            if (result.Equals(new KeyValuePair<string, int>(null, 0)))
            {
                throw new CountNotEnoughException();
            }
            //balance not enough
            if (result.Value == 0)
            {
                throw new CountNotEnoughException();
            }
            _remainingMedium[result.Key] = result.Value - 1;

        }

        /// <summary>
        /// Use business card from the BusinessCard collection.
        /// </summary>
        /// <param name="number">number of medium to be used</param>
        /// <param name="medium">medium to be used</param>
        public void UseBusinessCard(string medium, int number)
        {
            var result = _remainingMedium.FirstOrDefault(x => x.Key == medium);
            //not found
            if (result.Equals(new KeyValuePair<string, int>(null, 0)))
            {
                throw new CountNotEnoughException();
            }
            //balance not enough
            if (result.Value < number)
            {
                throw new CountNotEnoughException(result.Value.ToString());
            }
            _remainingMedium[result.Key] = result.Value - number;
        }
        #endregion
    }
}
