using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TesteAcademiadoProgramador
{
    public partial class ControledeChamados : Form
    {
        public ControledeChamados()
        {
            InitializeComponent();
            txt_codigochamado.Enabled = false;
            txt_descricaochamado.Enabled = false;
            txt_nomeequipamento.Enabled = false;
            txt_diaschamadoaberto.Enabled = false;
            txt_dataaberturachamado.Enabled = false;
            txt_pesquisaporcodigo.Enabled = false;
        }

        SqlConnection sqlcon = null;
        private string strcon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademiadoProgramador;Data Source=DESKTOP-1K2RKHV\SQLEXPRESS";
        private string strsql = string.Empty;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_createchamado_Click(object sender, EventArgs e)
        {
            txt_codigochamado.Enabled = true;
            txt_descricaochamado.Enabled = true;
            txt_nomeequipamento.Enabled = true;
            txt_diaschamadoaberto.Enabled = true;
            txt_dataaberturachamado.Enabled = true;

            strcon = "insert into Equipamentos (codigochamado,descricaochamado,nomeequipamento,diaschamadoaberto,dataaberturachamado) values (@codigochamado,@descricaochamado,@nomeequipamento,@dataaberturachamado,@diaschamadoaberto)";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@codigochamado", SqlDbType.Int).Value = txt_codigochamado.Text;
            comando.Parameters.Add("@descricaochamado", SqlDbType.VarChar).Value = txt_descricaochamado.Text;
            comando.Parameters.Add("@nomeequipamento", SqlDbType.VarChar).Value = txt_nomeequipamento.Text;
            comando.Parameters.Add("@dataaberturachamado", SqlDbType.Date).Value = txt_dataaberturachamado.Text;
            comando.Parameters.Add("@diaschamadoaberto", SqlDbType.Int).Value = txt_diaschamadoaberto.Text;

            

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            txt_pesquisaporcodigo.Enabled = true;

            txt_nomeequipamento.Clear();
            txt_diaschamadoaberto.Clear();
            txt_descricaochamado.Clear();
            txt_dataaberturachamado.Clear();
            txt_codigochamado.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_readchamado_Click(object sender, EventArgs e)
        {

            strcon = "select * from Chamado where codigochamado = @pesquisaporcodigo";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@pesquisaporcodigo", SqlDbType.VarChar).Value = txt_pesquisaporcodigo.Text;

            try
            {

                if (txt_pesquisaporcodigo.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU NENHUM TERMO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            txt_pesquisaporcodigo.Clear();

                sqlcon.Open();


                SqlDataReader dr = comando.ExecuteReader(); 

            if(dr.HasRows == false)
            {
                throw new Exception("ESTE CHAMADO NÃO ESTÁ CADASTRADO");

                dr.Read();

                txt_codigochamado.Text = Convert.ToString(dr["codigochamado"]);
                txt_dataaberturachamado.Text = Convert.ToString(dr["dataaberturachamado"]);
                txt_descricaochamado.Text = Convert.ToString(dr["descricaochamado"]);
                txt_diaschamadoaberto.Text = Convert.ToString(dr["diaschamadoaberto"]);
                txt_nomeequipamento.Text = Convert.ToString(dr["nomeequipamento"]);
            }


            
        }

        private void btn_updatechamado_Click(object sender, EventArgs e)
        {
            strcon = "update Chamados set codigochamado=@codigochamado,dataaberturachamado@dataaberturachamado,descricaochamamado=@descricaochamado,diaschamadoaberto=@diaschamadoaberto,nomeequipamento=@nomeequipamento ";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@codigochamado", SqlDbType.Int).Value = txt_codigochamado.Text;
            comando.Parameters.Add("@descricaochamado", SqlDbType.VarChar).Value = txt_descricaochamado.Text;
            comando.Parameters.Add("@nomeequipamento", SqlDbType.VarChar).Value = txt_nomeequipamento.Text;
            comando.Parameters.Add("@dataaberturachamado", SqlDbType.Date).Value = txt_dataaberturachamado.Text;
            comando.Parameters.Add("@diaschamadoaberto", SqlDbType.Int).Value = txt_diaschamadoaberto.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CHAMADO ALTERADO COM SUCESSO");
            }catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            txt_nomeequipamento.Clear();
            txt_diaschamadoaberto.Clear();
            txt_descricaochamado.Clear();
            txt_dataaberturachamado.Clear();
            txt_codigochamado.Clear();
        }

        private void btn_deletechamado_Click(object sender, EventArgs e)
        {
            strcon = " delete * from Chamados codigochamado = @codigochamado ";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@codigochamado", SqlDbType.Int).Value = txt_codigochamado.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CHAMADO DELETAD0 COM SUCESSO");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            txt_nomeequipamento.Clear();
            txt_diaschamadoaberto.Clear();
            txt_descricaochamado.Clear();
            txt_dataaberturachamado.Clear();
            txt_codigochamado.Clear();
        }

    }
    }
    



