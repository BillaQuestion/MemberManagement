using System;

namespace MM.Model
{
    public class OneTimeExperience : Product
    {
        /// <summary>
        /// 销售产品
        /// </summary>
        /// <param name="product">所销售产品</param>
        /// <returns>购买记录</returns>
        public SellRecord Sell(Tutor tutor)
        {
            SellRecord purchase = new SellRecord()
            {
                Product = this,
                ProductId = this.Id,
                Price = this.Price,
                Tutor = tutor,
                TutorId = tutor.Id,
                SellDate = DateTime.Now
            };
            return purchase;
        }
    }
}