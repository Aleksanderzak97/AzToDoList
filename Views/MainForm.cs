using AzToDoList.Models;
using AzToDoList.Views;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Runtime.InteropServices.Marshalling;

namespace AzToDoList
{
    public partial class MainForm : Form, ITaskView
    {
        public event EventHandler AddTaskClicked;
        public event EventHandler RemoveTaskClicked;

        public string TaskName => textBoxTaskName.Text;

        public TaskModel SelectedTask
        {
            get
            {
                if (listViewTasks.SelectedItems.Count > 0)
                {
                    return listViewTasks.SelectedItems[0].Tag as TaskModel;
                }
                return null;
            }
        }

        public string SelectedStatus => comboBoxStatus.SelectedItem?.ToString() ?? "";

        private BindingList<TaskModel> _tasks = new BindingList<TaskModel>();

        public MainForm()
        {
            InitializeComponent();

            
            listViewTasks.View = View.Details;
            listViewTasks.FullRowSelect = true;
            listViewTasks.Columns.Add("Zadanie", 200);
            listViewTasks.Columns.Add("Status", 120);
            comboBoxStatus.Items.AddRange(new string[] { "Do zrobienia", "W trakcie", "Zrobione" });
            comboBoxStatus.SelectedIndexChanged += ComboBoxStatus_SelectedIndexChanged;
            listViewTasks.SelectedIndexChanged += ListViewTasks_SelectedIndexChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasksToFile();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTaskClicked?.Invoke(this, EventArgs.Empty);
            textBoxTaskName.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveTaskClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetTaskList(BindingList<TaskModel> tasks)
        {
            _tasks = tasks;
            RefreshListView();
        }

        private void RefreshListView()
        {
            listViewTasks.Items.Clear();
            foreach (var task in _tasks)
            {
                ListViewItem item = new ListViewItem(task.Name);
                item.SubItems.Add(task.Status);
                item.Tag = task;
                listViewTasks.Items.Add(item);
            }
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTask != null)
            {
                SelectedTask.Status = comboBoxStatus.SelectedItem.ToString();
                RefreshListView();
            }
        }

        private void ListViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTask != null)
            {
                comboBoxStatus.SelectedItem = SelectedTask.Status;
            }
            else
            {
                comboBoxStatus.SelectedIndex = -1;
            }
        }

        private void SaveTasksToFile()
        {
            try
            {
                File.WriteAllText("tasks.json", JsonConvert.SerializeObject(_tasks));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Wyst¹pi³ b³¹d podczas zapisywania zadañ: {ex.Message}",
                    "B³¹d zapisu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void LoadTasksFromFile()
        {
            if (File.Exists("tasks.json"))
            {
                try
                {
                    var loadedTasks = JsonConvert.DeserializeObject<BindingList<TaskModel>>(File.ReadAllText("tasks.json"));
                    if (loadedTasks != null)
                    {
                        foreach (var task in loadedTasks)
                        {
                            _tasks.Add(task);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"B³¹d podczas ³adowania zadañ: {ex.Message}",
                        "B³¹d ³adowania",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                RefreshListView();
            }
        }

    }
}
