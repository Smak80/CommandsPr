using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandsPr
{
    class MyCoomands
    {
        public static RoutedCommand Sit { get; set; }
        public static RoutedCommand Lay { get; set; }
        public static RoutedCommand Voice { get; set; }
        static MyCoomands() 
        {
            Sit = new RoutedCommand(nameof(Sit), typeof(MainWindow));
            Lay = new RoutedCommand(nameof(Lay), typeof(MainWindow));
            Voice = new RoutedCommand(nameof(Voice), typeof(MainWindow));
        }
    }
}
