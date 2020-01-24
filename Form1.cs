using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace OrgProcessosAPP
{
    public partial class OrgProcessosForm : Form
    {
        string strcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=R:\PUBLICO\OrgProcessos\OrgProcessosAPP\OrgProcessosAPP\bdprocessos.accdb";
        DataTable dt;

        // IMPORTS FOR "OrgProcessosForm_MouseDown" EVENT
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // ------------------------------------------------

        public OrgProcessosForm()
        {
            InitializeComponent();

        }

        private void OrgProcessosForm_Load(object sender, EventArgs e)
        {
            VinculaDados();

        }

        private void VinculaDados()
        {
            OleDbCommand com = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(strcon);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            com.Connection = con;
            com.CommandText = "SELECT * FROM tbprocessos";
            OleDbDataAdapter da = new OleDbDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.AsDataView();

        }

        private void salvar_click(object sender, EventArgs e)
        {
            // SAVE ~ INSERT BUTTON
            string comando = "INSERT INTO tbprocessos (interessado_processo, assunto_processo, des_processo, ano_processo, nm_funcionario) values (@interessado, @assunto, @descricao, @ano, @funcionario)";

            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            com.Parameters.Add("@interessado", OleDbType.VarChar).Value = interessadoTxtbox.Text;
            com.Parameters.Add("@assunto", OleDbType.VarChar).Value = assuntoTxtbox.Text;
            com.Parameters.Add("@descricao", OleDbType.VarChar).Value = descricaoTxtbox.Text;
            com.Parameters.Add("@ano", OleDbType.Integer).Value = anoTxtbox.Text ;
            com.Parameters.Add("@funcionario", OleDbType.VarChar).Value = funcionarioTxtbox.Text;

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Processo cadastrado com sucesso!");

            } catch(Exception E)
            {
                MessageBox.Show("Erro: " + E.Message);
            }
            finally
            {
                VinculaDados();
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display Selected Row from DataGridView to TextBoxes in Window Application
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idTxtBox.Text = row.Cells[0].Value.ToString();
                funcionarioTxtbox.Text = row.Cells[1].Value.ToString();
                interessadoTxtbox.Text = row.Cells[2].Value.ToString();
                assuntoTxtbox.Text = row.Cells[3].Value.ToString();
                descricaoTxtbox.Text = row.Cells[4].Value.ToString();
                anoTxtbox.Text = row.Cells[5].Value.ToString();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // DELETE BUTTON
            string comando = "DELETE * FROM tbProcessos WHERE cod_processo=@idprocesso";
            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            com.Parameters.Add("@idprocesso", OleDbType.VarChar).Value = idTxtBox.Text;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Processo deletado com sucesso!");

            }
            catch (Exception E)
            {
                MessageBox.Show("Erro: " + E.Message);
            }
            finally
            {
                VinculaDados();
                con.Close();
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // CLEAR BUTTON
            idTxtBox.Clear();
            funcionarioTxtbox.Clear();
            interessadoTxtbox.Clear();
            descricaoTxtbox.Clear();
            assuntoTxtbox.Clear();
            anoTxtbox.Clear();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            // UPDATE BUTTON
            string comando = "UPDATE tbProcessos set nm_funcionario=@funcionario, interessado_processo=@interessado, assunto_processo=@assunto, des_processo=@descricao, ano_processo=@ano";

            OleDbConnection con = new OleDbConnection(strcon);
            OleDbCommand com = new OleDbCommand(comando, con);

            com.Parameters.Add("@funcionario", OleDbType.VarChar).Value = funcionarioTxtbox.Text;
            com.Parameters.Add("@interessado", OleDbType.VarChar).Value = interessadoTxtbox.Text;
            com.Parameters.Add("@assunto", OleDbType.VarChar).Value = assuntoTxtbox.Text;
            com.Parameters.Add("@descricao", OleDbType.VarChar).Value = descricaoTxtbox.Text;
            com.Parameters.Add("@ano", OleDbType.Integer).Value = anoTxtbox.Text;

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Processo editado com sucesso!");

            }
            catch (Exception E)
            {
                MessageBox.Show("Erro: " + E.Message);
            }
            finally
            {
                VinculaDados();
                con.Close();
            }

        }

        private void pesquisarTxtbox_TextChanged(object sender, EventArgs e)
        {
            // SEARCH TXTBOX
            if (string.IsNullOrEmpty(pesquisarTxtbox.Text) || pesquisarTxtbox.Text == "")
            {
                this.tbProcessosTableAdapter.Fill(this.bdprocessosDataSet0.tbProcessos);
                tbProcessosBindingSource.DataSource = this.bdprocessosDataSet0.tbProcessos;
            }
            else
            {
                var query = from o in this.bdprocessosDataSet0.tbProcessos
                            where o.nm_funcionario.Contains(pesquisarTxtbox.Text) || o.nm_funcionario == pesquisarTxtbox.Text
                            select o;
                tbProcessosBindingSource.DataSource = query.ToList();
            }
        }

        private void OrgProcessosForm_MouseDown(object sender, MouseEventArgs e)
        {
            // MOVE ~ DRAG AND DROP FORM
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
