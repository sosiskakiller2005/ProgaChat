using ProgaChat.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProgaChat
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ProgaChatDbEntities _context;
        public static ProgaChatDbEntities GetContext()
        {
            if (_context == null)
            {
                _context = new ProgaChatDbEntities();
            }
            return _context;
        }
    }
}
