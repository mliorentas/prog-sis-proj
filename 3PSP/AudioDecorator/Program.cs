using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Event reminder = new Reminder() { Title = "Need food", Description = "Eggs, bacon, eggplant." };
            reminder = new ItemDate(reminder) {Date = new DateTime(2017, 12, 29)};
            reminder = new ItemPlace(reminder) { Place = "My room"};
            reminder = new ItemTag(reminder);

            var date = EventDecorator.GetRole<ItemDate>(reminder);
            Console.WriteLine("Days until event - {0}", date.CalculateDaysUntilEvent());

            var tag = EventDecorator.GetRole<ItemTag>(reminder);
            tag.AddTag("Important");
            tag.RemoveTag("Important");

            var meeting = new Meeting() { Title = "Talk with roomate ", Description = "about his music taste and love for Alla Pugacheva.", People = "Tautvydas" };
            Console.WriteLine(reminder.GetTypeInfo());
            Console.WriteLine(reminder.GetItem());
            Console.WriteLine();
            Console.WriteLine(meeting.GetTypeInfo());
            Console.WriteLine(meeting.GetItem());
        }
    }
}
