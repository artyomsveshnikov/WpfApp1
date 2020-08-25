using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.View;

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
            ContactsVM context = new ContactsVM(); //Экземпляр класса-привязки
            ContactsWindow form = new ContactsWindow(); //Экземпялр класса формы (окна)
            form.DataContext = context; //Здесь идёт присваивание контекста данных для привязки этих самых данных
            form.ShowDialog(); //Показ окна модальным (диалоговым)
        }

        public static readonly DependencyProperty OpenContactsListCommandProperty = DependencyProperty.Register("OpenContactsListCommand", typeof(DelegateCommand), typeof(MainWindowVM), null);
        public DelegateCommand OpenContactsListCommand
        {
            get { return (DelegateCommand)GetValue(OpenContactsListCommandProperty); }
            set { SetValue(OpenContactsListCommandProperty, value); }
        }
    }
}
