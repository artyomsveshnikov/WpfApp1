using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.DAL
{
    /// <summary>
    /// В этом классе пишешь абсолютно любы методы по обработке данных контактов. В моём примере контакты будут браться из текствого файла. У тебя это может быть БД. Или вообще запросы к Web API, которые тебе возвращают нужные значения
    /// </summary>
    public static class ContactDAL
    {
        public static List<Contact> GetContacts()
        {
            string filepath = @"Contacts.json";
            using (StreamReader file = File.OpenText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<Contact> contacts = (List<Contact>)serializer.Deserialize(file, typeof(List<Contact>));
                return contacts;
            }
        }
    }
}