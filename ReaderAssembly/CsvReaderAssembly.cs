using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderAssembly
{
    public class CsvReaderAssembly : INotifyPropertyChanged
    {
        public List<ReaderDataAssembly> ReaderListDataAssembly { get; set; }

        public CsvReaderAssembly()
        {
            ReaderListDataAssembly = new List<ReaderDataAssembly>();
            ReaderListDataAssembly.Add(new ReaderDataAssembly("Julius Caesar 3", 60));
            ReaderListDataAssembly.Add(new ReaderDataAssembly("Pompeius Magnus 3", 66));
            ReaderListDataAssembly.Add(new ReaderDataAssembly("Marcus Crassus 3", 75));
            OnRaisePropertyChanged("ReaderListDataAssembly");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnRaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

