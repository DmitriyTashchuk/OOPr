using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public delegate void Show_message(string message);
    public partial class ManagerForm : Form
    {
        private ProgramContext prog_db;
        Manager mang;
        Show_message show = (message) => MessageBox.Show(message);
        public ManagerForm(StartForm frm)
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                if (prog_db.Workers.Find(int.Parse(textBox3.Text)) == null)
                {
                    Worker worker = new Worker(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                    mang.set_emp_dep(worker, textBox5.Text.ToString());
                    mang.set_emp_salary(worker, int.Parse(textBox6.Text));
                    worker.Pr_manager = prog_db.Manager.Find(1);
                    prog_db.Workers.Add(worker);
                    prog_db.SaveChanges();
                    show("Працівника додано");
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
                }
                else
                {
                    show("Таке ID вже використовується");
                }
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                mang = prog_db.Manager.Find(1);
                mang.init_workers();
                foreach (Customer cust in prog_db.Customers.Include(c => c.New_Project).ToList())
                {
                    if (mang.get_proj_numemp(cust) != 0)
                    {
                        while (Manager.Workers.Count < cust.Id)
                        {
                            Manager.Workers.Add(new List<Worker>());
                        }
                        Manager.Workers[cust.Id - 1] = prog_db.Workers.Where(w => w.Project_Id == cust.Id).ToList();
                    }
                }
            }
        }
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PrevForm.Visible == false)
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Worker worker = prog_db.Workers.Find(int.Parse(textBox7.Text));
                if (worker != null)
                {
                    if (worker.Project_Id != 0)
                    {
                        Worker temp_worker = mang[worker.Project_Id - 1].Find(w => w.Id == int.Parse(textBox7.Text));
                        mang.set_emp_dep(temp_worker, textBox8.Text.ToString());
                        mang.set_emp_dep(worker, textBox8.Text.ToString());
                        prog_db.SaveChanges();
                        textBox8.Clear();
                        MessageBox.Show("Відділ успішно змінено");
                    }
                    else
                    {
                        mang.set_emp_dep(worker, textBox8.Text.ToString());
                        MessageBox.Show("Відділ успішно змінено");
                        prog_db.SaveChanges();
                        textBox8.Clear();
                    }
                }
                else
                {
                    show("Працівника з таким ID не знайдено");
                }
            }
        }

        private void changeSal_Click(object sender, EventArgs e)
        {
            Set_param set_param = new Set_param(mang.set_emp_salary);
            using (prog_db = new ProgramContext())
            {
                Worker worker = prog_db.Workers.Find(int.Parse(textBox7.Text));
                if (worker != null)
                {
                    if (worker.Project_Id != 0)
                    {
                        Worker temp_worker = mang[worker.Project_Id - 1].Find(w => w.Id == int.Parse(textBox7.Text));
                        set_param(temp_worker, int.Parse(textBox9.Text));
                        set_param(worker, int.Parse(textBox9.Text));
                        MessageBox.Show("Зарплату успішно змінено");
                        prog_db.SaveChanges();
                        textBox9.Clear();
                    }
                    else
                    {
                        set_param(worker, int.Parse(textBox9.Text));
                        MessageBox.Show("Зарплату успішно змінено");
                        prog_db.SaveChanges();
                        textBox9.Clear();
                    }
                }
                else
                {
                    show("Працівника з таким ID не знайдено");
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Worker temp_worker = prog_db.Workers.Find(int.Parse(textBox10.Text));
                if (temp_worker != null)
                {
                    if (temp_worker.Project_Id != 0)
                    {
                        Manager.Workers[temp_worker.Project_Id - 1].Remove(mang[temp_worker.Project_Id - 1].Find(w => w.Id == int.Parse(textBox10.Text)));
                        Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == temp_worker.Project_Id); ;
                        mang.set_proj_numemp(temp_cust, mang.get_proj_numemp(temp_cust) - 1);
                        foreach (Worker worker in mang[temp_worker.Project_Id - 1])
                        {
                            MessageBox.Show(worker.show_base_info() + " Відділ: " + worker.Department + " ID проекту: " + worker.Project_Id);
                        }
                    }
                    prog_db.Workers.Remove(temp_worker);
                    listBox3.Items.Clear();
                    MessageBox.Show("Працівника видалено");
                    prog_db.SaveChanges();
                    foreach (Worker worker in prog_db.Workers)
                    {
                        listBox3.Items.Add(worker.show_base_info() + " Відділ: " + worker.Department + " ID проекту: " + worker.Project_Id);
                    }
                }
                else
                {
                    MessageBox.Show("Працівника з таким ID не знайдено");
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox11.Text));
                if (temp_cust != null)
                {
                    mang.set_proj_price(temp_cust, int.Parse(textBox13.Text));
                    mang.set_proj_time(temp_cust, int.Parse(textBox14.Text));
                    mang.set_proj_numemp(temp_cust, 0);
                    mang.accept_proj(temp_cust);
                    prog_db.SaveChanges();
                    textBox11.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    MessageBox.Show("Замовлення прийняте");
                    listBox4.Items.Clear();
                    foreach (Customer cust in prog_db.Customers.Include(c => c.New_Project))
                    {
                        if (cust.Is_new == true)
                        {
                            listBox4.Items.Add(cust.show_proj_info());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вказано невірнe ID");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox18.Text));
                if (temp_cust != null)
                {
                    Set_proj_param set_param = new Set_proj_param(mang.set_proj_time);
                    set_param(temp_cust, int.Parse(textBox15.Text));
                    textBox15.Clear();
                    prog_db.SaveChanges();
                    MessageBox.Show("Успішно змінено");
                }
                else
                {
                    MessageBox.Show("Вказано невірнe ID");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox18.Text));
                if (temp_cust != null)
                {
                    Set_proj_param set_param = new Set_proj_param(mang.set_proj_price);
                    set_param(temp_cust, int.Parse(textBox16.Text));
                    textBox16.Clear();
                    prog_db.SaveChanges();
                    MessageBox.Show("Успішно змінено");
                }
                else
                {
                    MessageBox.Show("Вказано невірнe ID");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox17.Text));
                if (temp_cust != null)
                {
                    Worker temp_worker = prog_db.Workers.Find(int.Parse(textBox19.Text));
                    if (temp_worker != null && temp_worker.Project_Id == 0)
                    {
                        mang.add_worker_on_proj(int.Parse(textBox17.Text), temp_worker);
                        textBox19.Clear();
                        MessageBox.Show("Працівника додано на проект");
                        mang.set_proj_numemp(temp_cust, mang.get_proj_numemp(temp_cust) + 1);
                        prog_db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Працівника з таким ID не знайдено або він числиться на іншому проекті");
                    }
                }
                else
                {
                    MessageBox.Show("Проекту з таким ID не знайдено");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox17.Text));
                if (temp_cust != null)
                {
                    Worker temp_worker = mang.delete_worker_from_proj(int.Parse(textBox17.Text), int.Parse(textBox19.Text));
                    if (temp_worker != null)
                    {
                        textBox19.Clear();
                        MessageBox.Show("Працівника видалено з проекту");
                        mang.set_proj_numemp(temp_cust, mang.get_proj_numemp(temp_cust) - 1);
                        prog_db.Workers.Remove(prog_db.Workers.Find(temp_worker.Id));
                        prog_db.Workers.Add(temp_worker);
                        prog_db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Проекту з таким ID не знайдено");
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            using (prog_db = new ProgramContext())
            {
                if (prog_db.Customers.Find(int.Parse(textBox20.Text)) != null)
                {
                    List<Worker> workers_on_proj = mang[int.Parse(textBox20.Text) - 1];
                    foreach (Worker worker in workers_on_proj)
                    {
                        listBox6.Items.Add("Ім'я: " + worker.Name + " ID: " + worker.Id + " Відділ: " + worker.Department + " Чи є завдання: " + worker.Has_a_task);
                    }
                }
                else
                {
                    MessageBox.Show("Проекту з таким ID не знайдено");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int proj_id = int.Parse(textBox20.Text);
            listBox6.Items.Clear();
            if (proj_id <= Manager.Workers.Count)
            {
                foreach (Worker worker in mang[proj_id - 1])
                {
                    if (worker != null && worker.Has_a_task == true)
                    {
                        listBox6.Items.Add("ID працівника: " + worker.Id + " Завдання: " + worker.Task);
                    }
                }
            }
            else
            {
                MessageBox.Show("Проекту з таким ID не знайдено");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int worker_id = int.Parse(textBox21.Text);
            string task = richTextBox1.Text.ToString();
            using (prog_db = new ProgramContext())
            {
                if (prog_db.Workers.Find(worker_id) != null && prog_db.Workers.Find(worker_id).Project_Id != 0)
                {
                    Worker temp_worker = mang.set_task(task, worker_id);
                    prog_db.Workers.Remove(prog_db.Workers.Find(temp_worker.Id));
                    prog_db.Workers.Add(temp_worker);
                    prog_db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Працівника з таким ID не знайдено або він не призначений на проект");
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int worker_id = int.Parse(textBox21.Text);
            using (prog_db = new ProgramContext())
            {
                if (prog_db.Workers.Find(worker_id) != null && prog_db.Workers.Find(worker_id).Project_Id != 0)
                {
                    Worker temp_worker = mang.delete_task(worker_id);
                    prog_db.Workers.Remove(prog_db.Workers.Find(temp_worker.Id));
                    prog_db.Workers.Add(temp_worker);
                    prog_db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Працівника з таким ID не знайдено або він не призначений на проект");
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            using (prog_db = new ProgramContext())
            {
                foreach (Customer customer in prog_db.Customers.Include(c => c.New_Project))
                {
                    if (customer.Is_new == true)
                    {
                        listBox1.Items.Add(customer.show_info());
                        listBox1.Items.Add(customer.show_proj_info());
                    }
                    else
                    {
                        listBox2.Items.Add(customer.show_info());
                        listBox2.Items.Add(customer.show_proj_info());
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            using (prog_db = new ProgramContext())
            {
                Manager temp_mang = prog_db.Manager.Include(w => w.Workers_on_company).FirstOrDefault(m => m.Id == 1);
                foreach (Worker worker in temp_mang.Workers_on_company)
                {
                    listBox3.Items.Add(worker.show_base_info() + " Відділ: " + worker.Department + " ID проекту: " + worker.Project_Id);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                listBox4.Items.Clear();
                foreach (Customer cust in prog_db.Customers.Include(c => c.New_Project))
                {
                    if (cust.Is_new == true)
                    {
                        listBox4.Items.Add(cust.show_proj_info());
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                listBox5.Items.Clear();
                foreach (Customer cust in prog_db.Customers.Include(c => c.New_Project))
                {
                    if (cust.Is_new != true)
                    {
                        listBox5.Items.Add(cust.show_proj_info());
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                var projWithLowTime = prog_db.Customers
                    .Include(c => c.New_Project)
                    .Where(c => c.New_Project.Time_to_comp < 15 && c.Is_new == false)
                    .GroupBy(c => c.New_Project.Time_to_comp)
                    .Select(g => new { Time_to_comp = g.Key, Projects = g.ToList() });
                foreach (var group in projWithLowTime)
                {
                    foreach (var customer in group.Projects)
                    {
                        MessageBox.Show("Назва проекту: " + customer.New_Project.Project_name + " Час: " + customer.New_Project.Time_to_comp);
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                var result = from worker in prog_db.Workers
                             where worker.Project_Id != 0
                             join manager in prog_db.Manager on worker.Manager_id equals manager.Id
                             join customer in prog_db.Customers.Include(c => c.New_Project) on worker.Project_Id equals customer.Id
                             select new { Worker = worker, Manager = manager, Customer = customer };
                listBox3.Items.Clear();

                foreach (var item in result)
                {
                    listBox3.Items.Add($" ID: {item.Worker.Id} Працівник: {item.Worker.Name}, Менеджер: {item.Manager.Name}, ID проекту: {item.Customer.Id} Замовлення: {item.Customer.New_Project.Project_name}");
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                listBox3.Items.Clear();
                var sortedSalary = prog_db.Workers.OrderBy(w => w.Salary).ToList();
                foreach (Worker worker in sortedSalary)
                {
                    listBox3.Items.Add(worker.show_base_info() + " Відділ: " + worker.Department + " ID проекту: " + worker.Project_Id);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                List<int> workersId = prog_db.Workers.Select(w => w.Id).ToList();
                List<int> allId = Enumerable.Range(1, 15).ToList();
                List<int> actualId = allId.Except(workersId).ToList();
                var output = new StringBuilder();
                foreach (int id in actualId)
                {
                    output.AppendLine(id.ToString());
                }
                MessageBox.Show("Можливі ID: " + output);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                List<int> projectPrices = prog_db.Customers.Include(c=>c.New_Project).Select(p => p.New_Project.Price).ToList();
                int sumPrices = projectPrices.Sum();
                MessageBox.Show("Загальна вартість наявних проектів: " + sumPrices);
            }
        }
    }
}
