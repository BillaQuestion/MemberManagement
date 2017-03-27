using MM.Model;
using MM.Repository;
using System;

namespace MM.Business.Tests
{
    public class PrepareDatas
    {
        public void CreateDatas()
        {
            MMContext context = new MMContext();

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
                Medium = medium画纸,
                Description = "从零开始学习水粉画的基本画法"
            };
            lecture.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0001-000000000001"));
            context.Lectures.Add(lecture);

            lecture = new Lecture()
            {
                Name = "水粉画基础test",
                Price = 998,
                Count = 14,
                Medium = medium画纸,
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
            { Name = "一次性画纸", Price = 20, Medium = medium画纸 };
            oneTimeExperience.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0003-000000000001"));
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布", Price = 30, Medium = medium画纸 };
            oneTimeExperience.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0001-0003-000000000002"));
            context.OneTimeExperiences.Add(oneTimeExperience);

            oneTimeExperience = new Model.OneTimeExperience()
            { Name = "一次性画布test", Price = 30, Medium = medium画纸 };
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

            SellRecord sellRecord = new SellRecord()
            {
                ProductId = Guid.Parse("00000000-0000-0001-0002-000000000001"),
                Tutor = tutor,
                Price = 500,
                SellDate = DateTime.Parse("2017-3-1")
            };

            sellRecord.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0005-0001-000000000001"));
            context.SellRecords.Add(sellRecord);

            Member member = new Member()
            { Name = "李四", PhoneNumber = "1234567890" };
            member.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0003-0001-000000000001"));
            LectureMemberCard lectureMemberCard = new LectureMemberCard()
            {
                Name = "500元画纸",
                TotalCount = 12,
                Remainder = 12,
                MediumName = medium画纸.Name,
                ProductId = Guid.Parse("00000000-0000-0001-0002-000000000001"),
                Member = member,
                PurchaseDate = DateTime.Parse("2017-3-1"),
                SellRecord = sellRecord
            };
            lectureMemberCard.ChangeCurrentIdentity(Guid.Parse("00000000-0000-0004-0001-000000000001"));
            member.MemberCards.Add(lectureMemberCard);
            context.Members.Add(member);

            context.SaveChanges();
        }

        public void CleanDatas()
        {
            MMContext context = new MMContext();

            foreach (var c in context.Consumptions)
                context.Consumptions.Remove(c);

            foreach (var t in context.Tutors)
                context.Tutors.Remove(t);

            foreach (var m in context.Members)
                context.Members.Remove(m);

            foreach (var m in context.Mediums)
                context.Mediums.Remove(m);

            foreach (var s in context.SellRecords)
                context.SellRecords.Remove(s);

            foreach (var p in context.Products)
                context.Products.Remove(p);

            context.SaveChanges();
        }
    }
}
