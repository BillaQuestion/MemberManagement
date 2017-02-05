using MM.Model;
using System.Data.Entity;

namespace MM.Repository.Tests
{
    public class DropCreateMMDbWithSeedData : DropCreateDatabaseAlways<MMContext>
    {
        protected override void Seed(MMContext context)
        {
            base.Seed(context);

            var medium画布 = new Medium() { Name = "画布" };
            medium画布.GenerateNewIdentity();
            context.Mediums.Add(medium画布);

            var medium画纸 = new Medium() { Name = "画纸" };
            medium画纸.GenerateNewIdentity();
            context.Mediums.Add(medium画纸);

            var lecture = new Lecture()
            {
                Name = "水粉画基础",
                Price = 998,
                Count = 14,
                Description = "从零开始学习水粉画的基本画法"
            };
            lecture.GenerateNewIdentity();
            context.Lectures.Add(lecture);

            var timesCard = new TimesCard()
            {
                Name = "500元画纸",
                Price = 500,
                Count = 12,
                Medium = medium画纸
            };
            timesCard.GenerateNewIdentity();
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "500元画布",
                Price = 500,
                Count = 8,
                Medium = medium画布
            };
            timesCard.GenerateNewIdentity();
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画纸",
                Price = 1000,
                Count = 26,
                Medium = medium画纸
            };
            timesCard.GenerateNewIdentity();
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画布",
                Price = 1000,
                Count = 18,
                Medium = medium画布
            };
            timesCard.GenerateNewIdentity();
            context.TimesCards.Add(timesCard);

            var oneTimeExperience = new OneTimeExperience()
                { Name = "一次性画纸", Price = 20 };
            oneTimeExperience.GenerateNewIdentity();
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布", Price = 30 };
            oneTimeExperience.GenerateNewIdentity();
            context.OneTimeExperiences.Add(oneTimeExperience);
        }
    }
}
