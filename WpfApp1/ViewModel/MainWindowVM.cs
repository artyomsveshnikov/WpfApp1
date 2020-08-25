using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.ViewModel
{
    public class MainWindowVM : DependencyObject
    {
        public MainWindowVM()
        {
            OpenContactsListCommand = new DelegateCommand(OpenContactsList);
        }

        

        private static void OpenContactsList(object obj)
        {
            ContactsVM context = new ContactsVM();

        }

        public static readonly DependencyProperty OpenContactsListCommandProperty = DependencyProperty.Register("OpenContactsListCommand", typeof(DelegateCommand), typeof(MainWindowVM), null);
        public DelegateCommand OpenContactsListCommand
        {
            get { return (DelegateCommand)GetValue(OpenContactsListCommandProperty); }
            set { SetValue(OpenContactsListCommandProperty, value); }
        }
    }
}
