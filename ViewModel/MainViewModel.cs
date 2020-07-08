using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DeBritoCyrilToDoListEvaluationWPF.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ToDoTask toDoTask;

        private ToDoTask selectedToDoTask;

        public MainViewModel()
        {
            MinToDoDate = DateTime.Now;
            ToDoListTasks = new ObservableCollection<ToDoTask>();
            toDoTask = new ToDoTask();
        }

        public ObservableCollection<ToDoTask> ToDoListTasks { get; set; }

        public ToDoTask NewToDoTask
        {
            get { return toDoTask; }
            set
            {
                toDoTask = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("NewReservation"));
            }
        }

        public ToDoTask SelectedToDoTask
        {
            get { return selectedToDoTask; }
            set { selectedToDoTask = value; }
        }

        public DateTime MinToDoDate { get; set; }

        public void AddToDoTask()
        {
            this.ToDoListTasks.Add(toDoTask);
            NewToDoTask = new ToDoTask();
        }

        public void RemoveToDoTask()
        {
            this.ToDoListTasks.Remove(selectedToDoTask);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}