namespace Lab2
{
    partial class StartForm
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
            label1 = new Label();
            label2 = new Label();
            CustomerLoad = new Button();
            ManagerLoad = new Button();
            WorkerLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 54);
            label1.Name = "label1";
            label1.Size = new Size(225, 39);
            label1.TabIndex = 0;
            label1.Text = "Ласкаво просимо!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(176, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 1;
            label2.Text = "Хто ви?";
            // 
            // CustomerLoad
            // 
            CustomerLoad.FlatAppearance.BorderSize = 3;
            CustomerLoad.FlatStyle = FlatStyle.Flat;
            CustomerLoad.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomerLoad.Location = new Point(119, 154);
            CustomerLoad.Name = "CustomerLoad";
            CustomerLoad.Size = new Size(199, 58);
            CustomerLoad.TabIndex = 2;
            CustomerLoad.Text = "Замовник";
            CustomerLoad.UseVisualStyleBackColor = true;
            CustomerLoad.Click += CustomerLoad_Click;
            // 
            // ManagerLoad
            // 
            ManagerLoad.FlatAppearance.BorderSize = 3;
            ManagerLoad.FlatStyle = FlatStyle.Flat;
            ManagerLoad.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ManagerLoad.Location = new Point(119, 233);
            ManagerLoad.Name = "ManagerLoad";
            ManagerLoad.Size = new Size(199, 58);
            ManagerLoad.TabIndex = 3;
            ManagerLoad.Text = "Менеджер";
            ManagerLoad.UseVisualStyleBackColor = true;
            ManagerLoad.Click += ManagerLoad_Click;
            // 
            // WorkerLoad
            // 
            WorkerLoad.FlatAppearance.BorderSize = 3;
            WorkerLoad.FlatStyle = FlatStyle.Flat;
            WorkerLoad.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkerLoad.Location = new Point(119, 312);
            WorkerLoad.Name = "WorkerLoad";
            WorkerLoad.Size = new Size(199, 58);
            WorkerLoad.TabIndex = 4;
            WorkerLoad.Text = "Працівник";
            WorkerLoad.UseVisualStyleBackColor = true;
            WorkerLoad.Click += WorkerLoad_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(443, 442);
            Controls.Add(WorkerLoad);
            Controls.Add(ManagerLoad);
            Controls.Add(CustomerLoad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CustomerLoad;
        private Button ManagerLoad;
        private Button WorkerLoad;
    }
}