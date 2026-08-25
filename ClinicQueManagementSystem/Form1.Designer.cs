namespace ClinicQueManagementSystem
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtReason = new TextBox();
            btnAddToQueue = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            cmbPatientType = new ComboBox();
            lblQueueNumber = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 108);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 141);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 175);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Reason for Visit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 209);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Patient Type:";
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 23);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(154, 141);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(185, 23);
            txtAge.TabIndex = 5;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(154, 175);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(185, 23);
            txtReason.TabIndex = 6;
            // 
            // btnAddToQueue
            // 
            btnAddToQueue.Location = new Point(154, 266);
            btnAddToQueue.Name = "btnAddToQueue";
            btnAddToQueue.Size = new Size(104, 23);
            btnAddToQueue.TabIndex = 8;
            btnAddToQueue.Text = "ADD TO QUEUE";
            btnAddToQueue.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 266);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 105);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 11;
            label5.Text = "Queue Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 28);
            label6.Name = "label6";
            label6.Size = new Size(360, 25);
            label6.TabIndex = 12;
            label6.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // cmbPatientType
            // 
            cmbPatientType.FormattingEnabled = true;
            cmbPatientType.Location = new Point(154, 209);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(185, 23);
            cmbPatientType.TabIndex = 13;
            // 
            // lblQueueNumber
            // 
            lblQueueNumber.AutoSize = true;
            lblQueueNumber.Location = new Point(520, 105);
            lblQueueNumber.Name = "lblQueueNumber";
            lblQueueNumber.Size = new Size(13, 15);
            lblQueueNumber.TabIndex = 14;
            lblQueueNumber.Text = "0";
            lblQueueNumber.Click += lblQueueNumber_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 144);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 15;
            label7.Text = "Patient Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 175);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 16;
            label8.Text = "Priority";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 553);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblQueueNumber);
            Controls.Add(cmbPatientType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnAddToQueue);
            Controls.Add(txtReason);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtReason;
        private TextBox textBox4;
        private Button btnAddToQueue;
        private Button button2;
        private Label label5;
        private Label label6;
        private ComboBox cmbPatientType;
        private Label lblQueueNumber;
        private Label label7;
        private Label label8;
    }
}
