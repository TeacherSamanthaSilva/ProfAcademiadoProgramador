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
    public partial class ControledeEquipamentos : Form
    {
        public ControledeEquipamentos()
        {
            InitializeComponent();
            txt_nomedoequipamento.Enabled = false;
            txt_datafabricacao.Enabled = false;
            txt_numerodeserie.Enabled = false;
            txt_precoequipamento.Enabled = false;
            txt_fabricante.Enabled = false;
            txt_pesquisaequipamento.Enabled = false;
        }

        SqlConnection sqlcon = null;
        private string strcon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademiadoProgramador;Data Source=DESKTOP-1K2RKHV\SQLEXPRESS";
        private string strsql = string.Empty;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomedoequipamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createequipamento_Click(object sender, EventArgs e)
        {
            txt_nomedoequipamento.Enabled = true;
            txt_datafabricacao.Enabled = true;
            txt_fabricante.Enabled = true;
            txt_numerodeserie.Enabled = true;
            txt_precoequipamento.Enabled = true;

            strcon = "insert into Equipamentos (nomeequipamento,preco,numerodeserie,datafabricacao,fabricante) values (@nomeequipamento,@preco,@numerodeserie,@datafabricacao,@fabricante)";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@nomeequipamento", SqlDbType.VarChar).Value = txt_nomedoequipamento.Text;
            comando.Parameters.Add("@preco", SqlDbType.Real).Value = txt_precoequipamento.Text;
            comando.Parameters.Add("@numerodeserie", SqlDbType.VarChar).Value = txt_numerodeserie.Text;
            comando.Parameters.Add("@datafabricacao", SqlDbType.Date).Value = txt_datafabricacao.Text;
            comando.Parameters.Add("@fabricante", SqlDbType.VarChar).Value = txt_fabricante.Text;

            if(txt_nomedoequipamento.TextLength < 6)
            {
                MessageBox.Show("NOME DE EQUIPAMENTO INVÁLIDO DIGITE UM NOME DE EQUIPAMENTO SUPERIOR A SEIS");
            }

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

            txt_pesquisaequipamento.Enabled = true;

            txt_datafabricacao.Clear();
            txt_fabricante.Clear();
            txt_nomedoequipamento.Clear();
            txt_numerodeserie.Clear();
            txt_precoequipamento.Clear();

        }

        private void txt_fabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_pesquisaequipamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ControledeEquipamentos_Load(object sender, EventArgs e)
        {

        }

        private void btn_readequipamento_Click(object sender, EventArgs e)
        {
            strcon = "select * from Chamado where codigochamado = @pesquisaequipamento";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@pesquisaporcodigo", SqlDbType.VarChar).Value = txt_pesquisaequipamento.Text;

            try
            {

                if (txt_pesquisaequipamento.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU NENHUM TERMO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            txt_pesquisaequipamento.Clear();
        }

        private void btn_updateequipeamento_Click(object sender, EventArgs e)
        {
            strcon = "update Chamados set nomeequipamento=@nomeequipamento,datafabricacao@datafabricacao,numerodeserie=@numerodeserie,preco=@preco,fabricante=@fabricante ";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@nomeequipamento", SqlDbType.Int).Value = txt_nomedoequipamento.Text;
            comando.Parameters.Add("@preco", SqlDbType.VarChar).Value = txt_precoequipamento.Text;
            comando.Parameters.Add("@numerodeserie", SqlDbType.VarChar).Value = txt_numerodeserie.Text;
            comando.Parameters.Add("@datafabricacao", SqlDbType.Date).Value = txt_datafabricacao.Text;
            comando.Parameters.Add("@fabricante", SqlDbType.Int).Value = txt_fabricante.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CHAMADO ALTERADO COM SUCESSO");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            finally
            {
                sqlcon.Close();
            }
            txt_datafabricacao.Clear();
            txt_fabricante.Clear();
            txt_nomedoequipamento.Clear();
            txt_numerodeserie.Clear();
            txt_precoequipamento.Clear();


        }

        private void btn_deleteequipamento_Click(object sender, EventArgs e)
        {
            strcon = " delete * from Equipamentos nomeequipamento = @nomeequipamento ";

            sqlcon = new SqlConnection(strcon);

            var comando = new SqlCommand(strcon, sqlcon);

            comando.Parameters.Add("@nomeequipamento", SqlDbType.Int).Value = txt_nomedoequipamento.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("EQUIPAMENTO DELETAD0 COM SUCESSO");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            finally
            {
                sqlcon.Close();
            }
            txt_datafabricacao.Clear();
            txt_fabricante.Clear();
            txt_nomedoequipamento.Clear();
            txt_numerodeserie.Clear();
            txt_precoequipamento.Clear();

        }
    }
    }

