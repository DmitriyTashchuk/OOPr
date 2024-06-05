using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class WorkerForm : Form
    {
        private ProgramContext prog_db;
        public WorkerForm(StartForm frm)
        {
            PrevForm = frm;
            InitializeComponent();
        }
        public StartForm PrevForm { get; set; }

        private void Back_to_menu_Click(object sender, EventArgs e)
        {
            PrevForm.Show();
            this.Close();
        }

        private void WorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PrevForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void FindWorker_Click(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            using (prog_db = new ProgramContext())
            {
                Worker temp_worker = prog_db.Workers.Find(int.Parse(textBox1.Text));
                if (temp_worker != null)
                {
                    label9.Text = temp_worker.Name;
                    label10.Text = temp_worker.Age.ToString();
                    label11.Text = temp_worker.Email;
                    label12.Text = temp_worker.Department;
                    label13.Text = temp_worker.Salary.ToString();
                    label14.Text = temp_worker.Project_Id.ToString();
                    if (temp_worker.Project_Id != 0)
                    {
                        Customer temp_cust = prog_db.Customers
                            .Include(c => c.New_Project) 
                            .FirstOrDefault(c => c.Id == temp_worker.Project_Id); ;
                        label18.Text = temp_cust.New_Project.Project_name;
                        label19.Text = temp_cust.New_Project.Time_to_comp.ToString();
                        label20.Text = temp_worker.Task;
                    }
                    MessageBox.Show("Дані зчитано.");
                    return;
                }
                MessageBox.Show("Такого працівника не знайдено");
            }
        }
    }
}
