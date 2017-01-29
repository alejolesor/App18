using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App18
{


    public class Intent
    {
        public Page _startPage { get; set; }
        public Page _endPage { get; set; }
        public Dictionary<string, object> DataObject { get; set; }
        public Dictionary<string, string> DataString { get; set; }


        public Intent(Page startPage, Page endPage)
        {
            _startPage = startPage;
            _endPage = endPage;
            DataObject = new Dictionary<string, object>();
            DataString = new Dictionary<string, string>();
        }

        public void PutObject(string Key , object obj)
        {
            if (DataObject.ContainsKey(Key))
            {
                throw new ArgumentException("La llave ya Existe");
            }
            DataObject.Add(Key , obj);

        }

        public void PutString(string Key, string value)
        {
            if (DataString.ContainsKey(Key))
            {
                throw new ArgumentException("La llave ya Existe");
            }

            DataString.Add(Key, value);

        }

        public string GetString(string Key)
        {
            if (DataString.ContainsKey(Key))
            {
                return DataString[Key];
            }
            throw new ArgumentException("La llave no Existe");


        }

        public T GetObject<T>(string Key)
        {
            if(DataObject.ContainsKey(Key))
            {
                return (T)DataObject[Key];
            }
            throw new ArgumentException("La llave no Existe");

             
        }

        public void StartIntent()
        {
            Navigation.Intent = this;
            _startPage.Navigation.PushModalAsync(_endPage,true);
        }

        public class Navigation
        {
            public static Intent Intent { get; set; }
        }
    }
}







