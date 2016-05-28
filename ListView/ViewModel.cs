using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public class ViewModel : INotifyPropertyChanged
    {
        public List<Person> Guys { get; set; }

        private List<Reader.ReaderData> _data;

        public List<Reader.ReaderData> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                RaisePropertyChanged("Data");
            }
        }

        public ViewModel()
        {
            var _reader = new Reader.CsvReader();

            Data = _reader.ReaderListData;

            Guys = new List<Person>();
            Guys.Add(new Person("Julius Caesar", 40));
            Guys.Add(new Person("Pompeius Magnus", 46));
            Guys.Add(new Person("Marcus Crassus", 55));
            RaisePropertyChanged("Guys");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
