namespace AzToDoList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTaskName = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            listViewTasks = new ListView();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(151, 31);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(125, 27);
            textBoxTaskName.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(314, 30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(51, 240);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Usuń";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(11, 26);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(170, 28);
            comboBoxStatus.TabIndex = 5;
            comboBoxStatus.Text = "Zmień status zadania";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Nazwa Zadania";
            // 
            // listViewTasks
            // 
            listViewTasks.FullRowSelect = true;
            listViewTasks.Location = new Point(45, 79);
            listViewTasks.Name = "listViewTasks";
            listViewTasks.Size = new Size(384, 121);
            listViewTasks.TabIndex = 8;
            listViewTasks.UseCompatibleStateImageBehavior = false;
            listViewTasks.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Location = new Point(179, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 68);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zmiana statusu zadania";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listViewTasks);
            Controls.Add(label1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTaskName);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTaskName;
        private Button buttonAdd;
        private Button buttonRemove;
        private ComboBox comboBoxStatus;
        private Label label1;
        private ListView listViewTasks;
        private GroupBox groupBox1;
    }
}
