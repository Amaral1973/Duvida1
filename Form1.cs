using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Duvida1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Duvida1\\carga.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        public void CarregaDgv()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            String query = "select * from carga";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable carga = new DataTable();
            da.Fill(carga);
            dgvCarga.DataSource = carga;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDgv();
            //Carrego meu datepicker com as propriedades que desejo
            dtpRecebido.MinDate = new DateTime(2020, 1, 1);
            dtpRecebido.MaxDate = new DateTime(2022, 1, 1);
            dtpRecebido.Format = DateTimePickerFormat.Short;
            //Carrego meu datepicker com as propriedades que desejo
            dtpEnviado.MinDate = new DateTime(2020, 1, 1);
            dtpEnviado.MaxDate = new DateTime(2022, 1, 1);
            dtpEnviado.CustomFormat = "dd/MM/yyyy - hh:mm";
            dtpEnviado.Format = DateTimePickerFormat.Custom;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirCarga";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recebimento", dtpRecebido.Value);
                cmd.Parameters.AddWithValue("@envio", dtpEnviado.Value);
                cmd.Parameters.Add(new SqlParameter("@pequeno", SqlDbType.Bit)).Value = Convert.ToInt32(cbPequeno.Checked);
                String medio;
                if(cbMedio.Checked == true)
                {
                    medio = "Médio";
                }
                else
                {
                    medio = "";
                }
                cmd.Parameters.AddWithValue("@medio", medio);
                cmd.Parameters.Add(new SqlParameter("@grande", SqlDbType.Bit)).Value = Convert.ToInt32(cbGrande.Checked);
                con.Open();
                cmd.ExecuteNonQuery();
                CarregaDgv();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                dtpRecebido.Value = DateTime.Now;
                dtpEnviado.Value = DateTime.Now;
                cbPequeno.Checked = false;
                cbMedio.Checked = false;
                cbGrande.Checked = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarCarga";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@recebimento", dtpRecebido.Value);
                cmd.Parameters.AddWithValue("@envio", dtpEnviado.Value);
                cmd.Parameters.Add(new SqlParameter("@pequeno", SqlDbType.Bit)).Value = Convert.ToInt32(cbPequeno.Checked);
                String medio;
                if (cbMedio.Checked == true)
                {
                    medio = "Médio";
                }
                else
                {
                    medio = "";
                }
                cmd.Parameters.AddWithValue("@medio", medio);
                cmd.Parameters.Add(new SqlParameter("@grande", SqlDbType.Bit)).Value = Convert.ToInt32(cbGrande.Checked);
                con.Open();
                cmd.ExecuteNonQuery();
                CarregaDgv();
                MessageBox.Show("Registro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                dtpRecebido.Value = DateTime.Now;
                dtpEnviado.Value = DateTime.Now;
                cbPequeno.Checked = false;
                cbMedio.Checked = false;
                cbGrande.Checked = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirCarga";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                CarregaDgv();
                MessageBox.Show("Registro apagado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                dtpRecebido.Value = DateTime.Now;
                dtpEnviado.Value = DateTime.Now;
                cbPequeno.Checked = false;
                cbMedio.Checked = false;
                cbGrande.Checked = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarCarga";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    dtpRecebido.Text = rd["recebimento"].ToString();
                    dtpEnviado.Text = rd["envio"].ToString();
                    //Verificando se existe valor na coluna, se tiver então marca 'true' se não é 'false'
                    cbPequeno.Checked = rd["pequeno"] == DBNull.Value ? true : false;
                    cbMedio.Checked = rd["medio"] == DBNull.Value ? true : false;
                    cbGrande.Checked = rd["grande"] == DBNull.Value ? true : false;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            finally
            {
            }
        }

        private void dgvCarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCarga.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                dtpRecebido.Text = row.Cells[1].Value.ToString();
                dtpEnviado.Text = row.Cells[2].Value.ToString();
                string pequeno = row.Cells[3].Value.ToString();
                if(pequeno == "True")
                {
                    cbPequeno.Checked = true;
                } else
                {
                    cbPequeno.Checked = false;
                }
                string medio = row.Cells[4].Value.ToString().Trim();
                if (medio == "Médio")
                {
                    cbMedio.Checked = true;
                }
                else
                {
                    cbMedio.Checked = false;
                }
                string grande = row.Cells[5].Value.ToString();
                if (grande == "True")
                {
                    cbGrande.Checked = true;
                }
                else
                {
                    cbGrande.Checked = false;
                }
            }
        }
    }
}
