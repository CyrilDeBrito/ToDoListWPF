using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DeBritoCyrilToDoListEvaluationWPF
{
    public class ToDoTask : INotifyPropertyChanged
    {
        public ToDoTask()
        {
            this.Date = DateTime.Now;
        }

        public DateTime Date { get; set; }

        public String Task { get; set; }

       public event PropertyChangedEventHandler PropertyChanged;
    }
}
