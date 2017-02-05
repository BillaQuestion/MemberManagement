using MM.Model;
using System.Data.Entity;

namespace MM.Repository.Tests
{
    public class DropCreateMMDbWithSeedData : DropCreateDatabaseAlways<MMContext>
    {
        protected override void Seed(MMContext context)
        {
            base.Seed(context);

            var oneTimeExperience = new OneTimeExperience()
                { Name = "一次性画纸", Price = 20 };
            oneTimeExperience.GenerateNewIdentity();
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布", Price = 30 };
            oneTimeExperience.GenerateNewIdentity();
            context.OneTimeExperiences.Add(oneTimeExperience);

            var lecture = new Lecture()
            {
                Name = "水粉画基础",
                Price = 998,
                Count = 14,
                Description = "从零开始学习水粉画的基本画法"
            };
            lecture.GenerateNewIdentity();
            context.Lectures.Add(lecture);
        }
    }
}
