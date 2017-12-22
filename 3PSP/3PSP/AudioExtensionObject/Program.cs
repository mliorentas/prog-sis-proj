using DecoratorPSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionPSP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalendarEvent reminder = new Reminder() { Title = "Need food", Description = "Eggs, bacon, eggplant." };

            var date = reminder.AddExtension<ItemDate>();
            date.Date = new DateTime(2017, 12, 29);


            Console.WriteLine("Days until event - {0}", date.CalculateDaysUntilEvent());

            var tag = reminder.AddExtension<ItemTag>();
            tag.AddTag("Important");

            var meeting = new Meeting() { Title = "Talk with roomate ", Description = "about his music taste and love for Alla Pugacheva.", People = "Tautvydas" };
            var place = meeting.AddExtension<ItemPlace>();
            place.Place = "My room";

            Console.WriteLine(reminder.GetTypeInfo());
            Console.WriteLine(reminder.GetItem());
            //Console.WriteLine(place.GetPlace());
            Console.WriteLine();
            Console.WriteLine(meeting.GetTypeInfo());
            Console.WriteLine(meeting.GetItem());
        }
    }
}
