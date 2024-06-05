using Lab2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Manager;
namespace Lab2
{
    internal delegate void Set_proj_param(Customer cust, int number);
    public class Manager : Human, IListed
    {
        public interface IListed
        {
            List<Worker> this[int index] { get; }
        }
        public Manager() { }
        public Manager(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public List<Worker> this[int index]
        {
            get { return Manager.Workers[index]; }
        }
        public void change_info(int id, ref int salary, string email, int prem, int exp = 0)
        {
            this.Id = id;
            this.Email = email;
            this.Salary = salary;
            this.Premium = prem;
            this.Exp_in_job = exp;
        }
        public override string show_info()
        {
            return "sdd";
        }
        public void set_emp_salary(Worker emp, int sal)
        {
            emp.Salary = sal;
        }
        public void set_emp_dep(Worker emp, string dep)
        {
            emp.Department = dep;
        }
        public void set_proj_price(Customer cust, int price)
        {
            cust.New_Project.Price = price;
        }
        public void set_proj_numemp(Customer cust, int emp)
        {
            cust.New_Project.Number_of_emp = emp;
        }
        public int get_proj_numemp(Customer cust)
        {
            return cust.New_Project.Number_of_emp;
        }
        public void set_proj_time(Customer cust, int time)
        {
            cust.New_Project.Time_to_comp = time;
        }
        public void accept_proj(Customer cust)
        {
            cust.Is_new = false;
        }
        public Worker delete_worker_from_proj(int proj_id, int worker_id)
        {
            Worker temp_worker = this[proj_id - 1].FirstOrDefault(p => p.Id == worker_id);
            if (temp_worker != null)
            {
                temp_worker.Project_Id = 0;
                temp_worker.Task = "Немає";
                temp_worker.Has_a_task = false;
                this[proj_id - 1].Remove(temp_worker);
                return temp_worker;
            }
            else
            {
                MessageBox.Show("Працівника з таким ID не знайдено");
                temp_worker = null;
                return temp_worker;
            }
        }
        public void add_worker_on_proj(int proj_id, Worker emp)
        {
            while (Manager.Workers.Count < proj_id)
            {
                Manager.Workers.Add(new List<Worker>());
            }
            this[proj_id - 1].Add(emp);
            emp.Project_Id = proj_id;
        }
        public Worker set_task(string task, int id)
        {
            ITasked worker_task = Manager.Workers.SelectMany(list => list).FirstOrDefault(worker => worker.Id == id);
            worker_task.set_task(task);
            MessageBox.Show("Завдання призначено");
            Worker worker = worker_task as Worker;
            return worker;
        }
        public Worker delete_task(int id)
        {
            ITasked worker_task = Manager.Workers.SelectMany(list => list).FirstOrDefault(worker => worker.Id == id);
            worker_task.delete_task();
            MessageBox.Show("Завдання видалено");
            Worker worker = worker_task as Worker;
            return worker;
        }
        public void init_workers()
        {
            Manager.Workers = new List<List<Worker>>();
        }
        public int Premium { get; set; }
        public int Exp_in_job {  get; set; }
        public static List<List<Worker>> Workers { get; set; }
        public List<Worker> Workers_on_company { get; set; }
    }
}
