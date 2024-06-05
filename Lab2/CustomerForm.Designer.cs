namespace Lab2
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            CustOrder = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            Cust_order = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            CustInfo = new TabPage();
            Proj_load_to_cust = new Button();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            Back_to_menu = new Button();
            label3 = new Label();
            tabControl1.SuspendLayout();
            CustOrder.SuspendLayout();
            CustInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CustOrder);
            tabControl1.Controls.Add(CustInfo);
            tabControl1.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(12, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 393);
            tabControl1.TabIndex = 0;
            // 
            // CustOrder
            // 
            CustOrder.Controls.Add(label10);
            CustOrder.Controls.Add(label9);
            CustOrder.Controls.Add(label8);
            CustOrder.Controls.Add(label7);
            CustOrder.Controls.Add(label6);
            CustOrder.Controls.Add(label5);
            CustOrder.Controls.Add(label4);
            CustOrder.Controls.Add(textBox7);
            CustOrder.Controls.Add(Cust_order);
            CustOrder.Controls.Add(textBox5);
            CustOrder.Controls.Add(textBox4);
            CustOrder.Controls.Add(textBox3);
            CustOrder.Controls.Add(label1);
            CustOrder.Controls.Add(textBox2);
            CustOrder.Controls.Add(textBox1);
            CustOrder.Location = new Point(4, 35);
            CustOrder.Name = "CustOrder";
            CustOrder.Padding = new Padding(3);
            CustOrder.Size = new Size(768, 354);
            CustOrder.TabIndex = 0;
            CustOrder.Text = "Замовлення";
            CustOrder.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 12F);
            label10.Location = new Point(407, 57);
            label10.Name = "label10";
            label10.Size = new Size(128, 29);
            label10.TabIndex = 18;
            label10.Text = "Тема проекту:";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(377, 0);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(10, 358);
            label9.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 12F);
            label8.Location = new Point(19, 235);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(73, 29);
            label8.TabIndex = 16;
            label8.Text = "Країна:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F);
            label7.Location = new Point(19, 190);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(96, 29);
            label7.TabIndex = 15;
            label7.Text = "Компанія:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F);
            label6.Location = new Point(19, 145);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(73, 29);
            label6.TabIndex = 14;
            label6.Text = "Пошта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F);
            label5.Location = new Point(19, 101);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(44, 29);
            label5.TabIndex = 13;
            label5.Text = "Вік:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F);
            label4.Location = new Point(19, 57);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(51, 29);
            label4.TabIndex = 12;
            label4.Text = "Ім'я:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(407, 144);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(349, 30);
            textBox7.TabIndex = 9;
            // 
            // Cust_order
            // 
            Cust_order.FlatAppearance.BorderSize = 3;
            Cust_order.FlatStyle = FlatStyle.Flat;
            Cust_order.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Cust_order.Location = new Point(472, 235);
            Cust_order.Name = "Cust_order";
            Cust_order.Size = new Size(198, 46);
            Cust_order.TabIndex = 8;
            Cust_order.Text = "Замовити проект";
            Cust_order.UseVisualStyleBackColor = true;
            Cust_order.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(132, 235);
            textBox5.Margin = new Padding(0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 30);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 190);
            textBox4.Margin = new Padding(0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 30);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 145);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 30);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 2;
            label1.Text = "Дані замовника:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 101);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 57);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 30);
            textBox1.TabIndex = 0;
            // 
            // CustInfo
            // 
            CustInfo.Controls.Add(Proj_load_to_cust);
            CustInfo.Controls.Add(label22);
            CustInfo.Controls.Add(label21);
            CustInfo.Controls.Add(label20);
            CustInfo.Controls.Add(label19);
            CustInfo.Controls.Add(label18);
            CustInfo.Controls.Add(label16);
            CustInfo.Controls.Add(label15);
            CustInfo.Controls.Add(label14);
            CustInfo.Controls.Add(label13);
            CustInfo.Controls.Add(textBox6);
            CustInfo.Controls.Add(label12);
            CustInfo.Location = new Point(4, 35);
            CustInfo.Name = "CustInfo";
            CustInfo.Padding = new Padding(3);
            CustInfo.Size = new Size(768, 354);
            CustInfo.TabIndex = 1;
            CustInfo.Text = "Перегляд даних";
            CustInfo.UseVisualStyleBackColor = true;
            // 
            // Proj_load_to_cust
            // 
            Proj_load_to_cust.FlatAppearance.BorderSize = 2;
            Proj_load_to_cust.FlatStyle = FlatStyle.Flat;
            Proj_load_to_cust.Location = new Point(445, 17);
            Proj_load_to_cust.Margin = new Padding(0);
            Proj_load_to_cust.Name = "Proj_load_to_cust";
            Proj_load_to_cust.Size = new Size(138, 39);
            Proj_load_to_cust.TabIndex = 12;
            Proj_load_to_cust.Text = "Показати дані";
            Proj_load_to_cust.UseVisualStyleBackColor = true;
            Proj_load_to_cust.Click += button3_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Sitka Banner", 12F);
            label22.Location = new Point(274, 242);
            label22.Name = "label22";
            label22.Size = new Size(0, 29);
            label22.TabIndex = 11;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Sitka Banner", 12F);
            label21.Location = new Point(274, 193);
            label21.Name = "label21";
            label21.Size = new Size(0, 29);
            label21.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Sitka Banner", 12F);
            label20.Location = new Point(274, 146);
            label20.Name = "label20";
            label20.Size = new Size(0, 29);
            label20.TabIndex = 9;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Sitka Banner", 12F);
            label19.Location = new Point(274, 100);
            label19.Name = "label19";
            label19.Size = new Size(0, 29);
            label19.TabIndex = 8;
            // 
            // label18
            // 
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Location = new Point(0, 73);
            label18.Name = "label18";
            label18.Size = new Size(768, 10);
            label18.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Banner", 12F);
            label16.Location = new Point(24, 242);
            label16.Name = "label16";
            label16.Size = new Size(212, 29);
            label16.TabIndex = 5;
            label16.Text = "Працівників на проекті:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Banner", 12F);
            label15.Location = new Point(24, 193);
            label15.Name = "label15";
            label15.Size = new Size(88, 29);
            label15.TabIndex = 4;
            label15.Text = "Вартість:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Banner", 12F);
            label14.Location = new Point(23, 146);
            label14.Name = "label14";
            label14.Size = new Size(168, 29);
            label14.TabIndex = 3;
            label14.Text = "Час на виконання:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Banner", 12F);
            label13.Location = new Point(23, 100);
            label13.Name = "label13";
            label13.Size = new Size(129, 29);
            label13.TabIndex = 2;
            label13.Text = "Опис проекту:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(254, 17);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 30);
            textBox6.TabIndex = 1;
            // 
            // label12
            // 
            label12.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(23, 7);
            label12.Name = "label12";
            label12.Size = new Size(225, 66);
            label12.TabIndex = 0;
            label12.Text = "Введіть ID проекту: (Надається менеджером)";
            // 
            // Back_to_menu
            // 
            Back_to_menu.FlatAppearance.BorderSize = 2;
            Back_to_menu.FlatStyle = FlatStyle.Flat;
            Back_to_menu.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Back_to_menu.Location = new Point(639, 12);
            Back_to_menu.Name = "Back_to_menu";
            Back_to_menu.Size = new Size(142, 40);
            Back_to_menu.TabIndex = 1;
            Back_to_menu.Text = "На головну";
            Back_to_menu.UseVisualStyleBackColor = true;
            Back_to_menu.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(215, 33);
            label3.TabIndex = 2;
            label3.Text = "Сторінка замовника";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Back_to_menu);
            Controls.Add(tabControl1);
            Name = "CustomerForm";
            Text = "Form1";
            FormClosing += CustomerForm_FormClosing;
            tabControl1.ResumeLayout(false);
            CustOrder.ResumeLayout(false);
            CustOrder.PerformLayout();
            CustInfo.ResumeLayout(false);
            CustInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage CustOrder;
        private TabPage CustInfo;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox7;
        private Button Cust_order;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button Back_to_menu;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Label label12;
        private Label label19;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label22;
        private Label label21;
        private Label label20;
        private Button Proj_load_to_cust;
    }
}
