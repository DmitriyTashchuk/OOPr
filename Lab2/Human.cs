using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Human
    {  
        public Human() { }
        public Human(string name, int salary, int id, int age, string email) { 
            this.Name = name;
            this.Salary = salary;
            this.Id = id;
            this.Age = age;
            this.Email = email;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public virtual string show_info()
        {
            string human_info = "Ім'я: " + Name + " Вік: " + Age + " Ел.Пошта: " + Email + " Зарплата: " + Salary + " ID: " + Id;
            return human_info;
        }
    }
}
