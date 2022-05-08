using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        List<Imprumuturi> lista2;
        public Form2(List<Imprumuturi> lista)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = "openFileDialog1.txt";
                string textToAdd = textBox1.Text;
                // StreamWriter sw = new StreamWriter(dlg.FileName);
                StreamWriter sw = new StreamWriter(dlg.FileName,true, Encoding.UTF8);

                sw.WriteLine(Environment.NewLine + textBox1.Text);

                try
                {

                    using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
                    {
                        writer.Write(Environment.NewLine + textToAdd);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sw.Close();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "(*.txt)|*.txt";
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
           // bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs, lista2);
            textBox1.Clear();
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
           // string s = (string)bf.Deserialize(fs);
            //textBox1.Text = s;
           List<Imprumuturi> lista3 = (List<Imprumuturi>)bf.Deserialize(fs);
           textBox1.Clear();
           foreach (Imprumuturi i in lista3)
               textBox1.Text += i.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}


//toate varstele clientilor pana la momentul respectiv si sa fac un average la varsta medie pana la momentul respectiv


    