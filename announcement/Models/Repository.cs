using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework1.Models
{
    public static class Repository
    {
        // Duyuruları tutan statik liste
        private static List<Anno> announcements = new List<Anno>();

        // Benzersiz ID atamak için bir sayaç
        private static int nextId = 1;

        // Duyurulara dışarıdan erişmek için public bir property
        public static IEnumerable<Anno> Annos => announcements;

        // Constructor içinde başlangıç duyuruları ekleniyor
        static Repository()
        {
            announcements.Add(new Anno
            {
                Id = nextId++,
                Title = "Artificial Intelligence Academic Thesis Program Begins",
                Text = "The program aims to increase competencies in the field of artificial intelligence in the defense industry, contribute to the need for qualified human resources in the sector and establish cooperation between academia and industry in the field of artificial intelligence. Students accepted to the program will be announced on October 31. Successful students will benefit from opportunities such as internship, candidate engineering program and project support in line with their competencies.",
                ResponsiblePerson = "Alican",
                AddAnn = DateTime.Now
            });
            announcements.Add(new Anno
            {
                Id = nextId++,
                Title = "2209-A - University Students Research Projects Support Program Call",
                Text = "2209-A University Students Research Projects Support Program 2024 1st semester call is open for application. Applications can be made via TUBITAK Management Information System (tybs.tubitak.gov.tr) until 17.30 on November 01, 2024.",
                ResponsiblePerson = "Nurcan",
                AddAnn = DateTime.Now
            });
            announcements.Add(new Anno
            {
                Id = nextId++,
                Title = "4001 National and International Competition/Event Participation Support 2nd Call",
                Text = "The 2nd call for 4001 National and International Competition/Event Participation Support, whose first call period was held between August 2 and September 30, was published on October 1, 2024 and opened for application.",
                ResponsiblePerson = "Gülcan",
                AddAnn = DateTime.Now
            });
            announcements.Add(new Anno
            {
                Id = nextId++,
                Title = "Adaptation to University Life Program",
                Text = "An orientation program has been organized for our new students to get to know university life and Sakarya University more closely; the topics, programs, people and places to be informed are attached.",
                ResponsiblePerson = "Mehmetcan",
                AddAnn = DateTime.Now
            });
        }

        // Duyurulara erişmek için property
        public static List<Anno> Announcements => announcements;

        // ID ile duyuru bulma metodu
        public static Anno GetAnnouncementById(int id)
        {
            return announcements.FirstOrDefault(a => a.Id == id);
        }

        // Yeni duyuru ekleyen metod
        public static void AddAnnouncement(Anno announcement)
        {
            announcement.Id = nextId++; // Benzersiz ID atama
            announcement.AddAnn = DateTime.Now; // Duyuru tarihini ekleme
            announcements.Add(announcement);
        }
    }
}
