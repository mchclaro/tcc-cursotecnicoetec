using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc2
{
    public partial class frmCategoria : Form
    {
        Informacoes info = new Informacoes();
        string idSel = "";

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            String StringDeConexao = @"Data Source=LAPTOP-IR5DO1BN\SQLEXPRESS;Initial Catalog= tcc;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = info.StringDeConexao;

                String sql = @"select codigo, Modelo from Categoria";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["Modelo"] = "";
                dt.Rows.InsertAt(row, 0);

                cmbModelo.DataSource = dt;
                cmbModelo.DisplayMember = "Modelo";
                cmbModelo.ValueMember = "codigo";
                cmbModelo.SelectedIndex = 0;

                con.Close();       
        }


        private void btnGravarCategoria_Click(object sender, EventArgs e)
        {


            string sql = @"UPDATE CATEGORIA "
               + "SET ValorCaixao = '"
               + txtValorCaixao.Text + "', "
               + "Flores = '"
               + txtFlores.Text + "', "
               + "CoroaDeFlores = '"
               + txtCoroaDeFlores.Text + "', "
               + "Paramentacao = '"
               + txtParamentacao.Text + "', "
               + "Higienizacao = '"
               + txtHigienizacao.Text + "', "
               + "Veu = '"
               + txtVeu.Text + "', "
               + "Carro = '"
               + txtCarro.Text + "', "
               + "Valor = '"
               + txtValor.Text + "' "
               + "where codigo = "
               + idSel;



            //String StringDeConexao = @"Data Source=PC6\SQLEXPRESS; Initial Catalog=tcc;
            //Integrated Security = True";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = info.StringDeConexao;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alteração feita com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            EditarCategoria();
        }

        private void EditarCategoria()
        {
            txtValorCaixao.Enabled = true;
            txtFlores.Enabled = true;
            txtCoroaDeFlores.Enabled = true;
            txtParamentacao.Enabled = true;
            txtHigienizacao.Enabled = true;
            txtVeu.Enabled = true;
            txtCarro.Enabled = true;
            txtValor.Enabled = true;

            lblCancelarCategoria.Enabled = true;
            btnCancelarCategoria.Enabled = true;
            lblGravarCategoria.Enabled = true;
            btnGravarCategoria.Enabled = true;
            btnEditarCategoria.Enabled = false;
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            CancelarCategoria();
        }

        private void CancelarCategoria()
        {
            txtValorCaixao.Enabled = false;
            txtFlores.Enabled = false;
            txtCoroaDeFlores.Enabled = false;
            txtParamentacao.Enabled = false;
            txtHigienizacao.Enabled = false;
            txtVeu.Enabled = false;
            txtCarro.Enabled = false;
            txtValor.Enabled = false;

            lblCancelarCategoria.Enabled = false;
            btnCancelarCategoria.Enabled = false;
            lblGravarCategoria.Enabled = false;
            btnGravarCategoria.Enabled = false;
            btnEditarCategoria.Enabled = true;
        }

        private void cmbModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if(cmb.SelectedValue.ToString() != "")
            {
                idSel = cmb.SelectedValue.ToString();
                String sql = "select * from Categoria where codigo = " + idSel;
                SqlConnection con = new SqlConnection(info.StringDeConexao);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                con.Open();

                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtValorCaixao.Text = reader[2].ToString();
                        txtFlores.Text = reader[3].ToString();
                        txtCoroaDeFlores.Text = reader[4].ToString();
                        txtParamentacao.Text = reader[5].ToString();
                        txtHigienizacao.Text = reader[6].ToString();
                        txtVeu.Text = reader[7].ToString();
                        txtCarro.Text = reader[8].ToString();
                        txtValor.Text = reader[9].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao carregar dados.");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    
