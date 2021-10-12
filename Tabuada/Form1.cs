﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularTabuada()
        {
            listBox1.Items.Clear();

            int valor = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(valor + " x " + i + " = " + (valor * i));
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                 if (e.KeyChar == '\r') 
                {
                    CalcularTabuada(); 
                }
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                e.KeyChar = '\0';
            }
                
        }
    }
}
