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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cititori.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "INSERT INTO cititori VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("codCarte", OleDbType.Integer).Value = Convert.ToInt32(tbCod_carte.Text);
                comanda.Parameters.Add("numeCarte", OleDbType.Char, 20).Value = tbNume_carte.Text;
                comanda.Parameters.Add("Nume", OleDbType.Char, 20).Value = tbNume.Text;
                comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = Convert.ToInt32(tbVarsta.Text);
                comanda.Parameters.Add("Sex", OleDbType.Char, 2).Value = cbSex.Text;
                comanda.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbVarsta.Clear();
                cbSex.Text = "";
                tbNume_carte.Clear();
                tbCod_carte.Clear();
            }
        }

        private void tbCod_carte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
