namespace lb2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addlaboratory = new System.Windows.Forms.Button();
            this.deletelaboratory = new System.Windows.Forms.Button();
            this.addstudent = new System.Windows.Forms.Button();
            this.deletestudent = new System.Windows.Forms.Button();
            this.addroom = new System.Windows.Forms.Button();
            this.deleteroom = new System.Windows.Forms.Button();
            this.addteacher = new System.Windows.Forms.Button();
            this.deleteteacher = new System.Windows.Forms.Button();
            this.addassistant = new System.Windows.Forms.Button();
            this.deleteassistant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Объединить университеты";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество факультетов";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество лабораторий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество студентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество аудиторий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название университета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество преподавателей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество персонала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "0";
            // 
            // addlaboratory
            // 
            this.addlaboratory.Location = new System.Drawing.Point(337, 95);
            this.addlaboratory.Name = "addlaboratory";
            this.addlaboratory.Size = new System.Drawing.Size(184, 23);
            this.addlaboratory.TabIndex = 16;
            this.addlaboratory.Text = "Добавить лабораторию";
            this.addlaboratory.UseVisualStyleBackColor = true;
            this.addlaboratory.Click += new System.EventHandler(this.addlaboratory_Click);
            // 
            // deletelaboratory
            // 
            this.deletelaboratory.Location = new System.Drawing.Point(558, 95);
            this.deletelaboratory.Name = "deletelaboratory";
            this.deletelaboratory.Size = new System.Drawing.Size(190, 23);
            this.deletelaboratory.TabIndex = 17;
            this.deletelaboratory.Text = "Убрать лабораторию";
            this.deletelaboratory.UseVisualStyleBackColor = true;
            this.deletelaboratory.Click += new System.EventHandler(this.deletelaboratory_Click);
            // 
            // addstudent
            // 
            this.addstudent.Location = new System.Drawing.Point(337, 141);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(184, 23);
            this.addstudent.TabIndex = 18;
            this.addstudent.Text = "Зачислить студента";
            this.addstudent.UseVisualStyleBackColor = true;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // deletestudent
            // 
            this.deletestudent.Location = new System.Drawing.Point(558, 138);
            this.deletestudent.Name = "deletestudent";
            this.deletestudent.Size = new System.Drawing.Size(190, 23);
            this.deletestudent.TabIndex = 19;
            this.deletestudent.Text = "Отчислить студента";
            this.deletestudent.UseVisualStyleBackColor = true;
            this.deletestudent.Click += new System.EventHandler(this.deletestudent_Click);
            // 
            // addroom
            // 
            this.addroom.Location = new System.Drawing.Point(337, 180);
            this.addroom.Name = "addroom";
            this.addroom.Size = new System.Drawing.Size(184, 23);
            this.addroom.TabIndex = 20;
            this.addroom.Text = "Добавить аудиторию";
            this.addroom.UseVisualStyleBackColor = true;
            this.addroom.Click += new System.EventHandler(this.addroom_Click);
            // 
            // deleteroom
            // 
            this.deleteroom.Location = new System.Drawing.Point(558, 177);
            this.deleteroom.Name = "deleteroom";
            this.deleteroom.Size = new System.Drawing.Size(190, 23);
            this.deleteroom.TabIndex = 21;
            this.deleteroom.Text = "Убрать аудиторию";
            this.deleteroom.UseVisualStyleBackColor = true;
            this.deleteroom.Click += new System.EventHandler(this.deleteroom_Click);
            // 
            // addteacher
            // 
            this.addteacher.Location = new System.Drawing.Point(337, 254);
            this.addteacher.Name = "addteacher";
            this.addteacher.Size = new System.Drawing.Size(184, 23);
            this.addteacher.TabIndex = 22;
            this.addteacher.Text = "Нанять преподавателя";
            this.addteacher.UseVisualStyleBackColor = true;
            this.addteacher.Click += new System.EventHandler(this.addteacher_Click);
            // 
            // deleteteacher
            // 
            this.deleteteacher.Location = new System.Drawing.Point(558, 254);
            this.deleteteacher.Name = "deleteteacher";
            this.deleteteacher.Size = new System.Drawing.Size(190, 23);
            this.deleteteacher.TabIndex = 23;
            this.deleteteacher.Text = "Уволить преподавателя";
            this.deleteteacher.UseVisualStyleBackColor = true;
            this.deleteteacher.Click += new System.EventHandler(this.deleteteacher_Click);
            // 
            // addassistant
            // 
            this.addassistant.Location = new System.Drawing.Point(337, 290);
            this.addassistant.Name = "addassistant";
            this.addassistant.Size = new System.Drawing.Size(184, 23);
            this.addassistant.TabIndex = 24;
            this.addassistant.Text = "Нанять ассистента";
            this.addassistant.UseVisualStyleBackColor = true;
            this.addassistant.Click += new System.EventHandler(this.addassistant_Click);
            // 
            // deleteassistant
            // 
            this.deleteassistant.Location = new System.Drawing.Point(558, 293);
            this.deleteassistant.Name = "deleteassistant";
            this.deleteassistant.Size = new System.Drawing.Size(190, 23);
            this.deleteassistant.TabIndex = 25;
            this.deleteassistant.Text = "Уволить аcсистента";
            this.deleteassistant.UseVisualStyleBackColor = true;
            this.deleteassistant.Click += new System.EventHandler(this.deleteassistant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteassistant);
            this.Controls.Add(this.addassistant);
            this.Controls.Add(this.deleteteacher);
            this.Controls.Add(this.addteacher);
            this.Controls.Add(this.deleteroom);
            this.Controls.Add(this.addroom);
            this.Controls.Add(this.deletestudent);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.deletelaboratory);
            this.Controls.Add(this.addlaboratory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addlaboratory;
        private System.Windows.Forms.Button deletelaboratory;
        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.Button deletestudent;
        private System.Windows.Forms.Button addroom;
        private System.Windows.Forms.Button deleteroom;
        private System.Windows.Forms.Button addteacher;
        private System.Windows.Forms.Button deleteteacher;
        private System.Windows.Forms.Button addassistant;
        private System.Windows.Forms.Button deleteassistant;
    }
}

