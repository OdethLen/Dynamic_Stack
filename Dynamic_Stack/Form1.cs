using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Dynamic_Stack
{
    public partial class Form1 : Form
    {
        private Stack<int> stack;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack<int>();

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                stack.Push(number);
                UpdateLabel();
                MessageBox.Show("Elemento agregado: " + number);
                txtNumber.Clear();
                ShowElements();
            }
            else
            {
                MessageBox.Show("Enter a valid number. ");
                return;
            }

        }

        private void UpdateLabel()
        {
            lblCount.Text = "Elements in the stack: " + stack.Count;
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                stack.Pop(); 
                UpdateLabel();
                ShowElements();
            }
            else
            {
                MessageBox.Show("Stack is empty.");
                return;
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                int top = stack.Peek();
                MessageBox.Show("Elemento en la cima: " + top);
            }
        
            MessageBox.Show("Stack is empty. ");
            return;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            if (stack.Count > 0)
            {
            
            stack.Clear();
            UpdateLabel();
            MessageBox.Show("Elements in the stack removed.");

            }

            MessageBox.Show("No items to remove. ");
            return;
        }

        private void ShowElements()
        {
            if (stack.Count > 0)
            {
                string elements = string.Join(",", stack);
                MessageBox.Show("Elements: " + elements);
            }
            else
            {
                MessageBox.Show("Stack is empty");
                return;
            }
        }

    }
}