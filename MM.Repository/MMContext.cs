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
        # region IDbSet Members

        /// <summary>
        /// 工作流定义集
        /// </summary>
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

        /// <summary>
        /// 工作流定义集
        /// </summary>
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

        #region DbContext override

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new OneTimeExperienceConfiguration());
        }

        #endregion
    }
}
