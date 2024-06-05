using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Worker;
namespace Lab2
{
    internal delegate void Set_param(Worker obj, int number);
    public interface IBase
    {
        string show_base_info();
    }
    public interface ITasked : IBase
    {
        void set_task(string task);
        void delete_task();
        bool Has_a_task { get; set; }
        string Task { get; set; }
    }
    public sealed class Worker : Human, ITasked
    {
        public Worker() { }
        public Worker(string name, int age, int id, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Email = email;
            this.Project_Id = 0;
            this.Has_a_task = false;
            this.Task = "Немає";
        }
        public string show_base_info()
        {
           return base.show_info();
        }
        public void set_task(string task)
        {
            this.Task = task;
            this.Has_a_task = true;
        }
        public void delete_task()
        {
            this.Task = "Немає";
            this.Has_a_task = false;
        }
        public int Manager_id { get; set; }
        public Manager Pr_manager { get; set; }
        public int Project_Id { get; set; }
        public string Department {  get; set; }
        public string Task {  get; set; }
        public bool Has_a_task {  get; set; }
    }
}
