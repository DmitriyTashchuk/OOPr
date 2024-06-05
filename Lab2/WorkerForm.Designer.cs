namespace Lab2
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Back_to_menu = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            FindWorker = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Back_to_menu
            // 
            Back_to_menu.FlatAppearance.BorderSize = 2;
            Back_to_menu.FlatStyle = FlatStyle.Flat;
            Back_to_menu.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Back_to_menu.Location = new Point(558, 9);
            Back_to_menu.Name = "Back_to_menu";
            Back_to_menu.Size = new Size(124, 42);
            Back_to_menu.TabIndex = 5;
            Back_to_menu.Text = "На головну";
            Back_to_menu.UseVisualStyleBackColor = true;
            Back_to_menu.Click += Back_to_menu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(10, 99);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 345);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(671, 306);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Перегляд даних працівника";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Banner", 12F);
            label14.Location = new Point(318, 240);
            label14.Name = "label14";
            label14.Size = new Size(0, 29);
            label14.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Banner", 12F);
            label13.Location = new Point(318, 196);
            label13.Name = "label13";
            label13.Size = new Size(0, 29);
            label13.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Banner", 12F);
            label12.Location = new Point(318, 156);
            label12.Name = "label12";
            label12.Size = new Size(0, 29);
            label12.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner", 12F);
            label11.Location = new Point(318, 115);
            label11.Name = "label11";
            label11.Size = new Size(0, 29);
            label11.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 12F);
            label10.Location = new Point(318, 73);
            label10.Name = "label10";
            label10.Size = new Size(0, 29);
            label10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 12F);
            label9.Location = new Point(318, 32);
            label9.Name = "label9";
            label9.Size = new Size(0, 29);
            label9.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 12F);
            label8.Location = new Point(41, 240);
            label8.Name = "label8";
            label8.Size = new Size(106, 29);
            label8.TabIndex = 5;
            label8.Text = "ID проекту:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F);
            label7.Location = new Point(41, 196);
            label7.Name = "label7";
            label7.Size = new Size(95, 29);
            label7.TabIndex = 4;
            label7.Text = "Зарплата:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F);
            label6.Location = new Point(40, 156);
            label6.Name = "label6";
            label6.Size = new Size(69, 29);
            label6.TabIndex = 3;
            label6.Text = "Відділ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F);
            label5.Location = new Point(41, 115);
            label5.Name = "label5";
            label5.Size = new Size(98, 29);
            label5.TabIndex = 2;
            label5.Text = "Ел.Пошта:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F);
            label4.Location = new Point(41, 73);
            label4.Name = "label4";
            label4.Size = new Size(44, 29);
            label4.TabIndex = 1;
            label4.Text = "Вік:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F);
            label3.Location = new Point(41, 32);
            label3.Name = "label3";
            label3.Size = new Size(51, 29);
            label3.TabIndex = 0;
            label3.Text = "Ім'я:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(671, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Перегляд даних по проекту";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label20.Location = new Point(63, 176);
            label20.Name = "label20";
            label20.Size = new Size(536, 113);
            label20.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Sitka Banner", 12F);
            label19.Location = new Point(307, 88);
            label19.Name = "label19";
            label19.Size = new Size(0, 29);
            label19.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Sitka Banner", 12F);
            label18.Location = new Point(307, 34);
            label18.Name = "label18";
            label18.Size = new Size(0, 29);
            label18.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sitka Banner", 12F);
            label17.Location = new Point(63, 138);
            label17.Name = "label17";
            label17.Size = new Size(98, 29);
            label17.TabIndex = 2;
            label17.Text = "Завдання:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Banner", 12F);
            label16.Location = new Point(63, 85);
            label16.Name = "label16";
            label16.Size = new Size(168, 29);
            label16.TabIndex = 1;
            label16.Text = "Час на виконання:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Banner", 12F);
            label15.Location = new Point(63, 31);
            label15.Name = "label15";
            label15.Size = new Size(128, 29);
            label15.TabIndex = 0;
            label15.Text = "Тема проекту:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(10, 9);
            label2.Name = "label2";
            label2.Size = new Size(223, 33);
            label2.TabIndex = 8;
            label2.Text = "Сторінка працівника";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 26);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 10;
            label1.Text = "Введіть ваше ID:";
            // 
            // FindWorker
            // 
            FindWorker.FlatAppearance.BorderSize = 2;
            FindWorker.FlatStyle = FlatStyle.Flat;
            FindWorker.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindWorker.Location = new Point(349, 51);
            FindWorker.Name = "FindWorker";
            FindWorker.Size = new Size(124, 42);
            FindWorker.TabIndex = 11;
            FindWorker.Text = "Знайти";
            FindWorker.UseVisualStyleBackColor = true;
            FindWorker.Click += FindWorker_Click;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 472);
            Controls.Add(FindWorker);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(Back_to_menu);
            Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "WorkerForm";
            Text = "WorkerForm";
            FormClosing += WorkerForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back_to_menu;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button FindWorker;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label16;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
    }
}