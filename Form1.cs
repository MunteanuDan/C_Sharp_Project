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
    public partial class Form1 : Form
    {
        int Imprumut_Maxim = 12;

        List<Imprumuturi> ListaImprum = new List<Imprumuturi>();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string sex = cbSex.Text;
                string numeCarte = tbNume_Carte.Text;
                int codCarte = Convert.ToInt32(tbCod_Carte.Text);
                int perioadaImprumut = Convert.ToInt32(tbPerioada_Imprumut.Text);
                int perioadaRamasa = Convert.ToInt32(tbPerioada_Ramasa.Text);
                Imprumuturi i = new Imprumuturi(nume, varsta, sex, numeCarte, codCarte, perioadaImprumut, perioadaRamasa);
                ListaImprum.Add(i);
                MessageBox.Show(i.ToString());

                string fileName = "varstaAdaugate.txt";
                int textToAdd = Convert.ToInt32(tbVarsta.Text);
               // string fileName1 = "numeAdaugate";
               // string textToAdd1 = tbNume.Text;

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
                 //Adaugam in fisierul "varstaAdaugate.txt" varsta fiecarui cititor odata apasat butonul "Adauga"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNume.Clear();
                tbVarsta.Clear();
                cbSex.Text = "";
                tbNume_Carte.Clear();
                tbCod_Carte.Clear();
                tbPerioada_Imprumut.Clear();
                tbPerioada_Ramasa.Clear();
                
            }

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(ListaImprum);
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4(ListaImprum);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(ListaImprum);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void tbVarsta_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        int varsta = Convert.ToInt32(tbVarsta.Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void tbVarsta_Validated(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Am validat deja!");
        //}

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbPerioada_Imprumut.Text = vScrollBar1.Value.ToString();
        }

        private void tbPerioada_Imprumut_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vScrollBar1.Value = Convert.ToInt32(tbPerioada_Imprumut.Text);
            }
            catch
            {
                vScrollBar1.Value = 1;
            }
        }

        private void imprumut_MaximToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Imprumut_Maxim = 24;
                vScrollBar1.Maximum = 24;
            }
            else
            {
                Imprumut_Maxim = 12;
                vScrollBar1.Maximum = 12;
            }
            MessageBox.Show("Imprumutul maxim: " + Imprumut_Maxim);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar2.Maximum =  Convert.ToInt32(tbPerioada_Imprumut.Text);
            tbPerioada_Ramasa.Text = vScrollBar2.Value.ToString();
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbVarsta.Clear();
            cbSex.Text = "";
            tbNume_Carte.Clear();
            tbCod_Carte.Clear();
            tbPerioada_Imprumut.Clear();
            tbPerioada_Ramasa.Clear();
            checkBox1.Checked = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele ");
            else
                 if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta ");
            else
                 if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Introduceti sexul ");
            else
                 if (tbNume_Carte.Text == "")
                errorProvider1.SetError(tbNume_Carte, "Introduceti numele cartii ");
            else
                 if (tbCod_Carte.Text == "")
                errorProvider1.SetError(tbCod_Carte, "Introduceti codul cartii ");
            else
                 if (tbPerioada_Imprumut.Text == "")
                errorProvider1.SetError(tbPerioada_Imprumut, "Introduceti perioada de imprumut ");
            else
                 if (tbPerioada_Ramasa.Text == "")
                errorProvider1.SetError(tbPerioada_Ramasa, "Introduceti perioada ramasa ");
           
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(ListaImprum);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7(ListaImprum);
            frm.Show();
        }

        private void tbVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPerioada_Imprumut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPerioada_Ramasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbCod_Carte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       



        //private void button3_Click(object sender, EventArgs e)
        //{


        //    string fileName = "varstaAdaugate.txt";
        //    int textToAdd = Convert.ToInt32(tbVarsta.Text);

        //    try
        //    {

        //        using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
        //        {
        //            writer.Write(Environment.NewLine + textToAdd);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //}


    }
}
