using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        List<Imprumuturi> lista2;

        string connString;
        public Form5(List<Imprumuturi> lista)
        {
            InitializeComponent();
            lista2 = lista;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cititori.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //  MessageBox.Show("S-a deschis!");
                OleDbCommand comanda = new OleDbCommand();           
                comanda.CommandText = "SELECT * FROM cititori";
                comanda.Connection = conexiune;

                OleDbDataReader reader = comanda.ExecuteReader(); 
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["codCarte"].ToString());
                    itm.SubItems.Add(reader["numeCarte"].ToString());
                    itm.SubItems.Add(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Varsta"].ToString());
                    itm.SubItems.Add(reader["Sex"].ToString());
                    listView1.Items.Add(itm);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int codCarte = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM cititori WHERE codCarte=" + codCarte;
                        comanda.ExecuteNonQuery();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            button1_Click(sender, e);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        
    }
}
