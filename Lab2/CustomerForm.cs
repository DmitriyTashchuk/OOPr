using System.Diagnostics.Metrics;
using System.Net.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lab2
{
    public partial class CustomerForm : Form
    {
        private ProgramContext prog_db;
        List<Customer> allCustomers = new List<Customer>();
        public CustomerForm(StartForm frm)
        {
            PrevForm = frm;
            InitializeComponent();
        }
        public StartForm PrevForm { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer()
            {
                Name = textBox1.Text.ToString(),
                Age = int.Parse(textBox2.Text),
                Email = textBox3.Text.ToString(),
                Company = textBox4.Text.ToString(),
                Country = textBox5.Text.ToString(),
                Is_new = true
            };
            cust.create_project(textBox7.Text.ToString());
            using(prog_db = new ProgramContext())
            {
                bool is_find = true;
                int i = 1;
                while(is_find == true)
                {
                    if (prog_db.Customers.Find(i) == null) {
                        cust.Id = i;
                        is_find = false;
                    }
                    i++;
                }
                prog_db.Customers.Add(cust);
                prog_db.SaveChanges();
                MessageBox.Show("Замовлення прийняте на обробку");
            }
            PrevForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrevForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (prog_db = new ProgramContext())
            {
                Customer temp_cust = prog_db.Customers.Include(c => c.New_Project).FirstOrDefault(c => c.Id == int.Parse(textBox6.Text));
                if (temp_cust != null && temp_cust.New_Project.Time_to_comp != 0)
                {
                    label19.Text = temp_cust.New_Project.Project_name;
                    label20.Text = temp_cust.New_Project.Time_to_comp.ToString();
                    label21.Text = temp_cust.New_Project.Price.ToString();
                    label22.Text = temp_cust.New_Project.Number_of_emp.ToString();
                    MessageBox.Show("Дані зчитано.");
                    return;
                }
                MessageBox.Show("Такого замовлення нема, або воно ще не оброблене.");
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PrevForm.Visible == false)
            {
                Application.Exit();
            }
        }
    }
}
