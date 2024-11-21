using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            monthCalendar.SelectionStart = DateTime.Today;
            monthCalendar.SelectionEnd = DateTime.Today;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Добавление нового напоминания
            string task = txtTask.Text;
            DateTime date = monthCalendar.SelectionStart;

            listBoxTasks.Items.Add($"{date.ToShortDateString()}: {task}");
            txtTask.Clear();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            // Удаление выбранного напоминания
            int selectedIndex = listBoxTasks.SelectedIndex;
            if (selectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
