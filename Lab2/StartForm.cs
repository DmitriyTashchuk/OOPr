using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    public class ProgramContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public ProgramContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=programData.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Ignore(m => m.Salary);
            modelBuilder.Entity<Worker>()
                .HasOne(w => w.Pr_manager)
                .WithMany(m => m.Workers_on_company)
                .HasForeignKey(w => w.Manager_id);
        }
    }
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CustomerLoad_Click(object sender, EventArgs e)
        {
            StartForm start = this;
            CustomerForm custForm = new CustomerForm(start);
            custForm.Show();
            this.Hide();
        }

        private void ManagerLoad_Click(object sender, EventArgs e)
        {
            StartForm start = this;
            ManagerForm mangForm = new ManagerForm(start);
            mangForm.Show();
            this.Hide();
        }

        private void WorkerLoad_Click(object sender, EventArgs e)
        {
            StartForm start = this;
            WorkerForm workForm = new WorkerForm(start);
            workForm.Show();
            this.Hide();
        }
    }
}
