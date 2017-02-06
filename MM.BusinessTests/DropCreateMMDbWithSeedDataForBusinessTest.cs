using MM.Model;
using MM.Business;
using MM.Repository;
using System.Data.Entity;

namespace MM.Business.Tests
{
    public class DropCreateMMDbWithSeedDataForBusinessTest : DropCreateDatabaseAlways<MMContext>
    {
        protected override void Seed(MMContext context)
        {
            base.Seed(context);
        }
    }
}
