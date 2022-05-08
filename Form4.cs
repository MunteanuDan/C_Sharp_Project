using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        List<Imprumuturi> lista2;
        public Form4(List<Imprumuturi> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Imprumuturi i in lista2)
                textBox1.Text += i.ToString() + Environment.NewLine;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox2.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox2.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            textBox2.DragDrop += new DragEventHandler(textBox1_DragDrop);

            pictureBox1.AllowDrop = true;


        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;

            if (MessageBox.Show("Sterge cititor", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox1.Focus();
                textBox2.Clear();
                textBox2.Focus();

            }
            else
            {
                MessageBox.Show("Cititor nesters", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
