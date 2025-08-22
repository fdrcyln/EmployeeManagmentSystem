namespace EmployeeFormTest
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            quitLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            SignOut = new Button();
            SalaryButton = new Button();
            AddButton = new Button();
            DashBoardButton = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            salary1 = new Salary();
            addEmployee1 = new AddEmployee();
            dashBoard1 = new DashBoard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(quitLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(6, 7);
            label2.Name = "label2";
            label2.Size = new Size(253, 23);
            label2.TabIndex = 1;
            label2.Text = "Employee Manangement System";
            label2.Click += label2_Click;
            // 
            // quitLabel
            // 
            quitLabel.AutoSize = true;
            quitLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quitLabel.ForeColor = SystemColors.ControlLightLight;
            quitLabel.Location = new Point(1068, 9);
            quitLabel.Name = "quitLabel";
            quitLabel.Size = new Size(20, 21);
            quitLabel.TabIndex = 0;
            quitLabel.Text = "X";
            quitLabel.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(SignOut);
            panel2.Controls.Add(SalaryButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(DashBoardButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 565);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 525);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 2;
            label1.Text = "Sign Out";
            // 
            // SignOut
            // 
            SignOut.Cursor = Cursors.No;
            SignOut.FlatStyle = FlatStyle.Flat;
            SignOut.ForeColor = Color.White;
            SignOut.Image = Properties.Resources.power_off;
            SignOut.Location = new Point(12, 518);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(35, 35);
            SignOut.TabIndex = 2;
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += button4_Click;
            // 
            // SalaryButton
            // 
            SalaryButton.BackColor = Color.FromArgb(33, 11, 97);
            SalaryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            SalaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            SalaryButton.FlatStyle = FlatStyle.Flat;
            SalaryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SalaryButton.ForeColor = Color.White;
            SalaryButton.Image = Properties.Resources.icons8_salary_32;
            SalaryButton.ImageAlign = ContentAlignment.MiddleLeft;
            SalaryButton.Location = new Point(12, 298);
            SalaryButton.Name = "SalaryButton";
            SalaryButton.Size = new Size(200, 40);
            SalaryButton.TabIndex = 4;
            SalaryButton.Text = "SALARY";
            SalaryButton.UseVisualStyleBackColor = false;
            SalaryButton.Click += SalaryButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(33, 11, 97);
            AddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            AddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AddButton.ForeColor = Color.White;
            AddButton.Image = Properties.Resources.icons8_add_male_user_group_32;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(12, 241);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 40);
            AddButton.TabIndex = 3;
            AddButton.Text = "ADD EMPLOYEE";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DashBoardButton
            // 
            DashBoardButton.BackColor = Color.FromArgb(33, 11, 97);
            DashBoardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            DashBoardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            DashBoardButton.FlatStyle = FlatStyle.Flat;
            DashBoardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DashBoardButton.ForeColor = Color.White;
            DashBoardButton.Image = Properties.Resources.icons8_dashboard_layout_24;
            DashBoardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashBoardButton.Location = new Point(12, 186);
            DashBoardButton.Name = "DashBoardButton";
            DashBoardButton.Size = new Size(200, 40);
            DashBoardButton.TabIndex = 2;
            DashBoardButton.Text = "DASHBOARD";
            DashBoardButton.UseVisualStyleBackColor = false;
            DashBoardButton.Click += DashBoardButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 133);
            label3.Name = "label3";
            label3.Size = new Size(144, 24);
            label3.TabIndex = 2;
            label3.Text = "Welcome, User";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_management_64;
            pictureBox1.Location = new Point(69, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // salary1
            // 
            salary1.Location = new Point(229, 35);
            salary1.Name = "salary1";
            salary1.Size = new Size(869, 565);
            salary1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(225, 35);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(875, 565);
            addEmployee1.TabIndex = 2;
            // 
            // dashBoard1
            // 
            dashBoard1.BackColor = SystemColors.Control;
            dashBoard1.Location = new Point(225, 35);
            dashBoard1.Name = "dashBoard1";
            dashBoard1.Size = new Size(875, 565);
            dashBoard1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dashBoard1);
            Controls.Add(addEmployee1);
            Controls.Add(salary1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label quitLabel;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button DashBoardButton;
        private Button AddButton;
        private Button SignOut;
        private Button SalaryButton;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private DashBoard dashBoard1;
        private Label label1;
    }
}