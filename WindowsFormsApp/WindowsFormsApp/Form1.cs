using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Print_Buttons(2);
        }

        private void Print_Buttons(int system_base)
        {
            List<Button> buttons = new List<Button>();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = Math.Min((int)numericUpDown1.Value, 10);
            tableLayoutPanel1.RowCount = (int)numericUpDown1.Value / 10 + 1;
            for(int i = 0; i < system_base; i++)
            {
                buttons.Add(new Button());
                if (i < 10)
                    buttons[i].Text = i.ToString();
                else
                    buttons[i].Text = ((char)(i + 'A' - 10)).ToString();
                buttons[i].Height = 75;
                buttons[i].Width = 75;
                buttons[i].Click += button_click;
                tableLayoutPanel1.Controls.Add(buttons[i]);
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
            textBox2.Text = ConsoleApp.Number_Systems_Converter.Convert(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Print_Buttons((int)numericUpDown1.Value);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox2.Text = ConsoleApp.Number_Systems_Converter.Convert(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            }
            else
            {
                textBox2.Clear();
            }
        }
    }
}
