using MM.Model;
using System.Data.Entity.ModelConfiguration;

namespace MM.Repository.Mappings
{
    public class OneTimeExperienceConfiguration : EntityTypeConfiguration<OneTimeExperience>
    {
        public OneTimeExperienceConfiguration()
        {
            ToTable("OneTimeExperiences");
            //HasKey(o => o.Id);
        }
    }
}
