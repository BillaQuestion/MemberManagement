using MM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Repository.Mappings
{
    public class TimesCardConfiguration:EntityTypeConfiguration<TimesCard>
    {
        public TimesCardConfiguration()
        {
            ToTable("TimesCards");
        }
    }
}
