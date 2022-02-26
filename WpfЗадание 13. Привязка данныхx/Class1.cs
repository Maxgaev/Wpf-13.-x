using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfЗадание_13.Привязка_данныхx
{
    internal class Class1
    {
        public static RoutedUICommand Exit { get; set; }
        static Class1()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.F4, ModifierKeys.Alt, "Alt+F4"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(Class1), inputs);
        }

    }
}
