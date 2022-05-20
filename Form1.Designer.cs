namespace Lab_07
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
            this.groupBox_Streat = new System.Windows.Forms.GroupBox();
            this.label_street = new System.Windows.Forms.Label();
            this.groupBox_Door = new System.Windows.Forms.GroupBox();
            this.label_door = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label_door1 = new System.Windows.Forms.Label();
            this.label_door2 = new System.Windows.Forms.Label();
            this.label_train = new System.Windows.Forms.Label();
            this.groupBox_Streat.SuspendLayout();
            this.groupBox_Door.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Streat
            // 
            this.groupBox_Streat.Controls.Add(this.label_street);
            this.groupBox_Streat.Location = new System.Drawing.Point(32, 13);
            this.groupBox_Streat.Name = "groupBox_Streat";
            this.groupBox_Streat.Size = new System.Drawing.Size(230, 100);
            this.groupBox_Streat.TabIndex = 0;
            this.groupBox_Streat.TabStop = false;
            this.groupBox_Streat.Text = "Вулиця";
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Location = new System.Drawing.Point(19, 45);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(61, 13);
            this.label_street.TabIndex = 0;
            this.label_street.Text = "label_street";
            // 
            // groupBox_Door
            // 
            this.groupBox_Door.Controls.Add(this.label_door);
            this.groupBox_Door.Location = new System.Drawing.Point(78, 119);
            this.groupBox_Door.Name = "groupBox_Door";
            this.groupBox_Door.Size = new System.Drawing.Size(131, 47);
            this.groupBox_Door.TabIndex = 1;
            this.groupBox_Door.TabStop = false;
            this.groupBox_Door.Text = "Двері";
            // 
            // label_door
            // 
            this.label_door.AutoSize = true;
            this.label_door.Location = new System.Drawing.Point(7, 20);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(56, 13);
            this.label_door.TabIndex = 0;
            this.label_door.Text = "label_door";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(32, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 213);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Приміщення вокзалу";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 95);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 75);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Каси";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            this.label6.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            this.label5.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            this.label4.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_door2);
            this.groupBox5.Controls.Add(this.label_door1);
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Location = new System.Drawing.Point(32, 391);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 113);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Платформа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_train);
            this.groupBox1.Location = new System.Drawing.Point(32, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Потяг";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(22, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 56);
            this.listBox2.TabIndex = 0;
            // 
            // label_door1
            // 
            this.label_door1.AutoSize = true;
            this.label_door1.Location = new System.Drawing.Point(22, 94);
            this.label_door1.Name = "label_door1";
            this.label_door1.Size = new System.Drawing.Size(62, 13);
            this.label_door1.TabIndex = 1;
            this.label_door1.Text = "label_door1";
            this.label_door1.TextChanged += new System.EventHandler(this.label3_TextChanged);
            // 
            // label_door2
            // 
            this.label_door2.AutoSize = true;
            this.label_door2.Location = new System.Drawing.Point(135, 93);
            this.label_door2.Name = "label_door2";
            this.label_door2.Size = new System.Drawing.Size(62, 13);
            this.label_door2.TabIndex = 2;
            this.label_door2.Text = "label_door2";
            this.label_door2.TextChanged += new System.EventHandler(this.label3_TextChanged);
            // 
            // label_train
            // 
            this.label_train.AutoSize = true;
            this.label_train.Location = new System.Drawing.Point(22, 20);
            this.label_train.Name = "label_train";
            this.label_train.Size = new System.Drawing.Size(55, 13);
            this.label_train.TabIndex = 0;
            this.label_train.Text = "label_train";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Door);
            this.Controls.Add(this.groupBox_Streat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Streat.ResumeLayout(false);
            this.groupBox_Streat.PerformLayout();
            this.groupBox_Door.ResumeLayout(false);
            this.groupBox_Door.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Streat;
        private System.Windows.Forms.GroupBox groupBox_Door;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_door2;
        private System.Windows.Forms.Label label_door1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label_train;
    }
}

