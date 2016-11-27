using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Containers
{
    public class Person: DependencyObject
    {
        public readonly static DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(Person));

        public string Name
        {
            get { return (string)GetValue(NameProperty); }

            set
            {
                if (Name == value)
                {
                    return;
                }

                SetValue(NameProperty, value);
            }
        }

    }
}
