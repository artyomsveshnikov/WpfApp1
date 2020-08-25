using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.DAL;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// В этом классе пишешь прописываешь "Свойства зависимостей" для твоей формы (окна). Это по сути класс-привязка контактов к твоей форме (окну)
    /// </summary>
    public class ContactsVM : DependencyObject
    {
        public ContactsVM(IEnumerable<Contact> contactList)
        {
            ContactsList = new ObservableCollection<Contact>(contactList);
        }

        public ContactsVM()
        {
            ContactsList = new ObservableCollection<Contact>(ContactDAL.GetContacts());
        }

        public static readonly DependencyProperty ContactsListProperty = DependencyProperty.Register("ContactsList", typeof(ObservableCollection<Contact>), typeof(ContactsVM), null);
        public ObservableCollection<Contact> ContactsList
        {
            get { return (ObservableCollection<Contact>)GetValue(ContactsListProperty); }
            set { SetValue(ContactsListProperty, value); }
        }

        public static readonly DependencyProperty SelectedContactProperty = DependencyProperty.Register("SelectedContact", typeof(Contact), typeof(ContactsVM), null);
        public Contact SelectedContact
        {
            get { return (Contact)GetValue(SelectedContactProperty); }
            set { SetValue(SelectedContactProperty, value); }
        }
    }
}
