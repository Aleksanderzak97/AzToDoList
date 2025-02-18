using AzToDoList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzToDoList.Views
{
    public interface ITaskView
    {
        string TaskName { get; }
        TaskModel SelectedTask { get; }
        string SelectedStatus { get; }

        void SetTaskList(BindingList<TaskModel> tasks);

        event EventHandler AddTaskClicked;
        event EventHandler RemoveTaskClicked;
    }
}
