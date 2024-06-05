using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    public class Customer : Human
    {
        public Customer() { }
        public Customer(string name, int age, string email, string company, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Company = company;
            this.Country = country;
        }
        public void create_project(string name)
        {
            this.New_Project = new Project(name);
        }
        public void write_data_to_file()
        {                           //метод запису даних проекту в файл
            try
            {
                using (StreamWriter writer = File.AppendText("NewCustomerData.TXT"))
                {
                    writer.WriteLine($"{this.Name},{this.Age},{this.Email},{this.Company},{this.Country},{this.New_Project.Project_name}");
                }
                MessageBox.Show("Замовлення прийняте, чекайте на обробку.");  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing file: {ex.Message}");
            }
        }
        public override string show_info()
        {
            string cust_info = "Ім'я: " + Name + " Вік: " + Age + " Ел.Пошта: " + Email + " Компанія: " + Company + " Країна: " + Country;
            return cust_info;
        }
        public string show_proj_info()
        {
            string proj_info = "ID: " + Id + "Тема: " + New_Project.Project_name;
            if (New_Project.Time_to_comp != 0)
            {
                proj_info += " Час на виконання: " + New_Project.Time_to_comp + " Вартість: " + New_Project.Price + " Кількість працівників на проекті: " + New_Project.Number_of_emp;
            }
            return proj_info;
        }
        public string Company {  get; set; }
        public string Country {  get; set; }
        public Project New_Project { get; set; }
        public bool Is_new {  get; set; }
    }
}
