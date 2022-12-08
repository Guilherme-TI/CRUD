using System;
using System.Data;
using  MySql.Data.MySqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string caminho = "datasource=localhost; username=root; password=; database=mydb";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);

                string sql = "INSERT INTO produto (item, valor, estoque) VALUES ('" + item.Text + "', '" + valor.Text + "', '"+ estoque.Text +"')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Alteração efetuada com sucesso");
                
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally { Conexao.Close(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);

                string sql = "SELECT * FROM produto";
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);
                Conexao.Open();
                da.Fill(ds);

                produtos.DataSource = ds.Tables[0];


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexao.Close(); }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);

                string sql = "DELETE FROM produto WHERE idproduto = " + id.Text + "";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Excluido com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
    }