using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Lab_07
{
    public partial class Form1 : Form
    {
        Mutex mut = new Mutex();
        Semaphore sem = new Semaphore(4,10);
        Semaphore sem1 = new Semaphore(2, 3);
        List<Label> labels = new List<Label>();
        List<Label> labels1 = new List<Label>();
        int maxPersons = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            labels.AddRange(new[] { label3, label4, label5, label6});
            labels1.AddRange(new[] { label_door1, label_door2 });
           
            foreach (Label item in labels)
            {
                item.Text = "X";
                
            }
            foreach (Label item1 in labels1)
            {
                item1.Text = "X";

            }

            label_train.Text = "";
            label_street.Text = "";
            for (int i = 0; i < maxPersons; i++)
            {
                label_street.Text += i.ToString()+", ";
            }

            for (int i = 0; i < maxPersons; i++)
            {
                Thread myThread = new Thread(changeLabelDoor);
                string name = i.ToString();
                myThread.Name = name + " людина біля дверей";
                myThread.Start(name);
            }

            void changeLabelDoor(object obj)
            {
                bool flag = false;
                while (true)
                {
                    if (obj is string str)
                    {
                        mut.WaitOne();

                        label_street.Text = label_street.Text.Replace(str, "X");
                        label_door.Text = str;
                        Thread.Sleep(1000);
                        Thread myThread = new Thread(changeLabelsHall);
                        Console.WriteLine($"{Thread.CurrentThread.Name} зайшли в зали");
                        myThread.Name = str + " людина у залі";
                        label_door.Text = "X";
                        listBox1.Items.Add(str);
                        Thread.Sleep(1000);
                        myThread.Start(str);

                        flag = true;
                        mut.ReleaseMutex();
                        if (flag == true) return;
                    }
                }
            }
            void changeLabelsHall(object obj)
            {
                bool flag = false;
                while (true)
                {
                    sem.WaitOne();
                    if (obj is string str)
                    {
                        foreach (Label item in labels)
                        {
                            if (item.Text == "X")
                            {
                                Console.WriteLine($"{Thread.CurrentThread.Name} знайшла вільну касу");
                                listBox1.Items.Remove(str);
                                item.Text = str;
                                Thread.Sleep(10000);
                                item.Text = "X";
                                Thread myThread1 = new Thread(changeLabelsPlatform);
                                listBox2.Items.Add(str);
                                myThread1.Start(str);
                                Thread.Sleep(1000);
                                flag = true;
                                break;

                            }
                        }
                    }
                    sem.Release();
                    if (flag == true) return;
                
                }
                
            }
            void changeLabelsPlatform(object obj)
            {
                bool flag = false;
                while (true)
                {
                    sem1.WaitOne();
                    if (obj is string str)
                    {
                        foreach (Label item1 in labels1)
                        {
                            if (item1.Text == "X")
                            {
                                Console.WriteLine($"{Thread.CurrentThread.Name} знайшов(-ла) вільні двері");
                                
                                item1.Text = str;
                                listBox2.Items.Remove(str);

                                Thread.Sleep(7500);
                                item1.Text = "X";
                                label_train.Text += str + ", ";
                                Thread.Sleep(750);
                                flag = true;
                                break;

                            }
                        }
                    }
                    sem1.Release();
                    if (flag == true) return;

                }

            }

        }
        private void label2_TextChanged(object sender, EventArgs e)
        {
            foreach (Label item in labels)
            {
                item.BackColor = SystemColors.Control;
                if (item == (Label)sender)
                {
                    item.BackColor = Color.LightGreen;
                }
            }
        }
        private void label3_TextChanged(object sender, EventArgs e)
        {
            foreach (Label item1 in labels1)
            {
                item1.BackColor = SystemColors.Control;
                if (item1 == (Label)sender)
                {
                    item1.BackColor = Color.LightGreen;
                }
            }
        }

    }
    
}
