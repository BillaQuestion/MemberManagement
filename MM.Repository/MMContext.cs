using Dayi.Infrastructure.Data.Seedwork;
using MM.Model;
using MM.Repository.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Repository
{
    public class MMContext : QueryableUnitOfWork
    {
        #region IDbSet Members

        #region 产品集
        public IDbSet<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = base.Set<Product>();

                return _products;
            }
        }
        IDbSet<Product> _products;
        #endregion

        #region 一次性体验产品集
        public IDbSet<OneTimeExperience> OneTimeExperiences
        {
            get
            {
                if (_oneTimeExperiences == null)
                    _oneTimeExperiences = base.Set<OneTimeExperience>();

                return _oneTimeExperiences;
            }
        }
        IDbSet<OneTimeExperience> _oneTimeExperiences;
        #endregion

        #region 会员产品集
        public IDbSet<MemberProduct> MemberProducts
        {
            get
            {
                if (_memberProducts == null)
                    _memberProducts = base.Set<MemberProduct>();

                return _memberProducts;
            }
        }
        IDbSet<MemberProduct> _memberProducts;
        #endregion

        #region 课程产品集
        public IDbSet<Lecture> Lectures
        {
            get
            {
                if (_lectures == null)
                    _lectures = base.Set<Lecture>();

                return _lectures;
            }
        }
        IDbSet<Lecture> _lectures;
        #endregion

        #region 按次消费产品集
        public IDbSet<TimesCard> TimesCards
        {
            get
            {
                if (_timeCards == null)
                    _timeCards = base.Set<TimesCard>();

                return _timeCards;
            }
        }
        IDbSet<TimesCard> _timeCards;
        #endregion

        #region 画布介质集
        public IDbSet<Medium> Mediums
        {
            get
            {
                if (_mediums == null)
                    _mediums = base.Set<Medium>();

                return _mediums;
            }
        }
        IDbSet<Medium> _mediums;
        #endregion

        #region 购买集
        public IDbSet<Purchase> Purchases
        {
            get
            {
                if (_purchases == null)
                    _purchases = base.Set<Purchase>();

                return _purchases;
            }
        }
        IDbSet<Purchase> _purchases;
        #endregion

        #region 余额集
        public IDbSet<Balance> Balances
        {
            get
            {
                if (_balances == null)
                    _balances = base.Set<Balance>();

                return _balances;
            }
        }
        IDbSet<Balance> _balances;
        #endregion

        #region 教师集
        public IDbSet<Tutor> Tutors
        {
            get
            {
                if (_tutors == null)
                    _tutors = base.Set<Tutor>();

                return _tutors;
            }
        }
        IDbSet<Tutor> _tutors;
        #endregion

        #region 消费集
        public IDbSet<Consumption> Consumptions
        {
            get
            {
                if (_consumptions == null)
                    _consumptions = base.Set<Consumption>();

                return _consumptions;
            }
        }
        IDbSet<Consumption> _consumptions;
        #endregion

        #region 学时消费集
        public IDbSet<Session> Sessions
        {
            get
            {
                if (_sessions == null)
                    _sessions = base.Set<Session>();

                return _sessions;
            }
        }
        IDbSet<Session> _sessions;
        #endregion

        #region 会员集
        public IDbSet<Member> Members
        {
            get
            {
                if (_members == null)
                    _members = base.Set<Member>();

                return _members;
            }
        }
        IDbSet<Member> _members;
        #endregion

        #endregion

        #region DbContext override

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new OneTimeExperienceConfiguration());
            modelBuilder.Configurations.Add(new MemberProductConfiguration());
            modelBuilder.Configurations.Add(new LectureConfiguration());
            modelBuilder.Configurations.Add(new TimesCardConfiguration());
            modelBuilder.Configurations.Add(new PurchaseConfiguration());
            modelBuilder.Configurations.Add(new BalanceConfiguration());
            modelBuilder.Configurations.Add(new TutorConfiguration());
            modelBuilder.Configurations.Add(new ConsumptionConfiguration());
            modelBuilder.Configurations.Add(new SessionConfiguration());
            modelBuilder.Configurations.Add(new MediumConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
        }

        #endregion
    }
}
