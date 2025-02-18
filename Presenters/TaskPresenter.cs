using AzToDoList.Models;
using AzToDoList.Views;
using System;
using System.ComponentModel;

namespace AzToDoList.Presenters
{
    public class TaskPresenter
    {
        private readonly ITaskView _view;
        private BindingList<TaskModel> _tasks = new BindingList<TaskModel>();

        public TaskPresenter(ITaskView view)
        {
            _view = view;
            _view.SetTaskList(_tasks);
            _view.AddTaskClicked += OnAddTask;
            _view.RemoveTaskClicked += OnRemoveTask;
        }

        private void OnAddTask(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_view.TaskName))
            {
                _tasks.Add(new TaskModel
                {
                    Name = _view.TaskName,
                    Status = "Do zrobienia"
                });
                _view.SetTaskList(_tasks);
            }
        }

        private void OnRemoveTask(object sender, EventArgs e)
        {
            if (_view.SelectedTask != null)
            {
                _tasks.Remove(_view.SelectedTask);
                _view.SetTaskList(_tasks);
            }
        }
    }
}
