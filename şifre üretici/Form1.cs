﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace şifre_üretici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       char[] ozelkarakterler = { '{', '<', '>', '|', '.', ':', '`', '@', ';', ',', '"', 'é', '!', '\\', '\'', '£', '$', ',', '€', '%', '½', '&', '/', '¨', '~', '{', '[', '(', ']', ')', '}', '=', '?', '*', '-', '_', '}' };
        
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                 
                 MessageBox.Show("Lütfen Parametrelerden en az birini işaretleyiniz");

           
            int sifreuzunlugu = Convert.ToInt32(nmrcsifreuzunlugu.Value);
            int sifresayısı = Convert.ToInt32(nmrcsifresayısı.Value);
          
            int x;
            richTextBox1.Clear();
           


            for (int i = 0; i < sifresayısı; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreuzunlugu; j++)
                {
                    x = r.Next(0, 4);

                    if (x==0)
                    {
                        if (checkBox1.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(97, 123));
                        }

                        else if (checkBox2.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(65, 91));
                        }

                        else if (checkBox3.Checked == true)
                        {
                            sifre += r.Next(0, 10);
                        }

                        else if (checkBox4.Checked == true)
                        {
                            sifre += Convert.ToString(ozelkarakterler[r.Next(ozelkarakterler.Length)]);
                        }
                
                       
                        
                    }

                    else if (x==1)
                    {

                         if (checkBox2.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(65, 91));
                        }

                        else if (checkBox1.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(97, 123));
                        }

                        else if (checkBox3.Checked == true)
                        {
                            sifre += r.Next(0, 10);
                        }

                        else if (checkBox4.Checked == true)
                        {
                            sifre += Convert.ToString(ozelkarakterler[r.Next(ozelkarakterler.Length)]);
                        }
                
                    }


                    else if (x == 2)
                    {

                        if (checkBox3.Checked == true)
                        {
                            sifre += r.Next(0, 10);
                        }

                        else if (checkBox1.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(97, 123));
                        }

                        else if (checkBox2.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(65, 91));
                        }

                        else if (checkBox4.Checked == true)
                        {
                            sifre += Convert.ToString(ozelkarakterler[r.Next(ozelkarakterler.Length)]);
                        }

                    }

                    else if (x==3)
                    {
                        if (checkBox4.Checked == true)
                        {
                            sifre += Convert.ToString(ozelkarakterler[r.Next(ozelkarakterler.Length)]);
                        }

                        else if (checkBox3.Checked == true)
                        {
                            sifre += r.Next(0, 10);
                        }

                        else if (checkBox1.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(97, 123));
                        }

                        else if (checkBox2.Checked == true)
                        {
                            sifre += Convert.ToChar(r.Next(65, 91));
                        }
                       
                    }
                 }
               richTextBox1.Text += sifre+"\n";
               
            }
          
       }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
