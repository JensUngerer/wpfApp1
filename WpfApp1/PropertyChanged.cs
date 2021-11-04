using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class PropertyChanged : INotifyPropertyChanged
    {
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }



        public int TheDependencyProperty
        {
            get { return (int)GetValue(TheDependencyPropertyProperty); }
            set { NewMethod(value); }
        }

        private static void NewMethod(int value)
        {
            SetValue(TheDependencyPropertyProperty, value);
        }

        private static void SetValue(DependencyProperty theDependencyPropertyProperty, int value)
        {
            throw new NotImplementedException();
        }

        private int GetValue(DependencyProperty theDependencyPropertyProperty)
        {
            throw new NotImplementedException();
        }

        // Using a DependencyProperty as the backing store for TheDependencyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TheDependencyPropertyProperty =
            DependencyProperty.Register("TheDependencyProperty", typeof(int), typeof(PropertyChanged), new PropertyMetadata(TheDependencyPropertyProperty));




        public static int GetAttachedProperty(DependencyObject obj)
        {
            return (int)obj.GetValue(AttachedPropertyProperty);
        }

        public static void SetAttachedProperty(DependencyObject obj, int value)
        {
            obj.SetValue(AttachedPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for AttachedProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AttachedPropertyProperty =
            DependencyProperty.RegisterAttached("AttachedProperty", typeof(int), typeof(PropertyChanged), new PropertyMetadata(0));

    }
}
