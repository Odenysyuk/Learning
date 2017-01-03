using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _9_FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 48},
                new Person {FirstName = "Gat", LastName = "Simpson", Age = 25}
            };

            people.CollectionChanged += people_CollectionChanged;

            people.Add(new Person() {LastName = "Blach", FirstName = "White", Age = 15});
            people.RemoveAt(1);

        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

            Console.WriteLine("Action for this event is {0}", e.Action);
            
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are old items:");

                foreach (Person item in e.OldItems)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }


            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are new items:");

                foreach (Person item in e.NewItems)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

            }       
        }
    }
}
