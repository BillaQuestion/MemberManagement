using MM.Model;
using System;
using System.Data.Entity;

namespace MM.Repository.Tests
{
    public class DropCreateMMDbWithSeedDataForRepositoryTest : DropCreateDatabaseAlways<MMContext>
    {
        protected override void Seed(MMContext context)
        {
            base.Seed(context);

            var medium画布 = new Medium() { Name = "画布" };
            medium画布.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0000-0001-000000000001"));
            context.Mediums.Add(medium画布);

            var medium画纸 = new Medium() { Name = "画纸" };
            medium画纸.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0000-0001-000000000002"));
            context.Mediums.Add(medium画纸);

            var lecture = new Lecture()
            {
                Name = "水粉画基础",
                Price = 998,
                Count = 14,
                Description = "从零开始学习水粉画的基本画法"
            };
            lecture.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0001-000000000001"));
            context.Lectures.Add(lecture);

            lecture = new Lecture()
            {
                Name = "水粉画基础test",
                Price = 998,
                Count = 14,
                Description = "从零开始学习水粉画的基本画法"
            };
            lecture.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0001-000000000002"));
            context.Lectures.Add(lecture);

            var timesCard = new TimesCard()
            {
                Name = "500元画纸",
                Price = 500,
                Count = 12,
                Medium = medium画纸
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000001"));
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "500元画布",
                Price = 500,
                Count = 8,
                Medium = medium画布
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000002"));
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画纸",
                Price = 1000,
                Count = 26,
                Medium = medium画纸
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000003"));
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画布",
                Price = 1000,
                Count = 18,
                Medium = medium画布
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000004"));
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画布test",
                Price = 1000,
                Count = 18,
                Medium = medium画布
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000005"));
            context.TimesCards.Add(timesCard);

            timesCard = new TimesCard()
            {
                Name = "1000元画布test",
                Price = 1000,
                Count = 18,
                Medium = medium画布
            };
            timesCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0002-000000000006"));
            context.TimesCards.Add(timesCard);

            var oneTimeExperience = new OneTimeExperience()
                { Name = "一次性画纸", Price = 20 };
            oneTimeExperience.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0003-000000000001"));
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布", Price = 30 };
            oneTimeExperience.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0003-000000000002"));
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布test", Price = 30 };
            oneTimeExperience.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0003-000000000003"));
            context.OneTimeExperiences.Add(oneTimeExperience);

            Tutor tutor = new Tutor()
            {
                Name = "admin",
                IsManager = true
            };
            tutor.SetPassword("password");
            tutor.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0002-0001-000000000001"));
            context.Tutors.Add(tutor);
        }
    }
}
