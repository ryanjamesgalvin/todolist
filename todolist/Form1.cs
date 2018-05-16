using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task;
namespace WindowsFormsApp1
{
    public partial class todoList : Form
    {
        public todoList()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (taskBox.Text != "")
            {
                //creates a new Task and adds it to the todo list
                task.Task newTask = new task.Task(taskBox.Text);
                taskHolder.Rows.Add(newTask.getText());
                taskBox.Text = null;
            }
        }

        private void taskBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void taskHolder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //adds the selected task to the completed list, and removes from current list
                if (taskHolder.CurrentCell.Value != null)
                {
                    taskCompletedHolder.Rows.Add(taskHolder.CurrentCell.Value);
                    taskHolder.Rows.Remove(taskHolder.CurrentCell.OwningRow);
                }
                
            }
            catch
            {
                
            }
        }

        private void taskCompletedHolder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                //remove rows in the completed list
                while (taskCompletedHolder.Rows.Count != 0)
                {
                    taskCompletedHolder.Rows.Remove(taskCompletedHolder.Rows[0]);
                }
                {
                    
                }
            }
            catch
            {

            }
            }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //prompt user to open file
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                // read the current tasks in from file
                try {
                    sr = new StreamReader(open.OpenFile());
                    string[] curTasks = sr.ReadLine().Split('|');
                    foreach (string task in curTasks)
                    {
                        //load tasks into current tasks list
                        task.Task t = new task.Task(task);
                        if (t.getText() != "")
                        {
                            taskHolder.Rows.Add(t.getText());
                        }
                    }
                    //create string array to hold tasks
                    string[] completedTasks = sr.ReadLine().Split(',');
                    if (completedTasks[0] != null)
                    {
                        //load tasks into completed tasks list
                        foreach (string task in completedTasks)
                        {
                            task.Task t = new task.Task(task);
                            taskCompletedHolder.Rows.Add(t.getText());
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    //close the stream reader
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create save object and set save parameters
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All Files(*.*)|*.*";
            save.RestoreDirectory = true;

            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.OpenFile());
                int i = 0;
                foreach (DataGridViewRow row in taskHolder.Rows)
                {
                    //loop through current tasks and write to file
                    if (row.Cells[0].Value != null)
                    {
                        if (i != 0)
                        {
                            sw.Write('|');
                        }
                        else
                        {
                            i = 1;
                        }
                        sw.Write(row.Cells[0].Value);
                      
                    }
                }

                sw.Write("\r\n");
                i = 0;
                
                foreach (DataGridViewRow row in taskCompletedHolder.Rows)
                {
                    //loop through completed tasks and write to file on new line
                    if (row.Cells[0].Value != null)
                    {
                        if (i != 0)
                        {
                            sw.Write(',');
                        }
                        else
                        {
                            i = 1;
                        }
                        sw.Write(row.Cells[0].Value);
                        
                    }
                }
                sw.Close();
            }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit program
            Application.Exit();
        }
    }
    }

