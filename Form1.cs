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

namespace WF1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CadastroWF;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt; int ID = 0;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (nome.Text != "" && endereco.Text != "" && celular.Text != "" && telefone.Text != "" && email.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Contatos(nome,endereco,celular,telefone,email) VALUES(@nome,@endereco,@celular,@telefone,@email)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", nome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereco", endereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", celular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@telefone", telefone.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@email", email.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }

                finally
                {
                    con.Close();
                    LimparDados();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }

         }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (nome.Text != "" && endereco.Text != "" && celular.Text != "" && telefone.Text != "" && email.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Contatos SET nome=@nome, endereco=@endereco, celular=@celular,telefone=@telefone,email=@email WHERE id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nome", nome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@endereco", endereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@celular", celular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@telefone", telefone.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@email", email.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LimparDados();
                    ExibirDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Contatos WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        LimparDados();
                        ExibirDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                   ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                   nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                   endereco.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                   celular.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                   telefone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                   email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "Agenda", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                nome.Focus();
        }

        private void buscarId_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDados();
            ExibirDados();
        }

        private string Pesquisando()
        {
            string buscar = "";

            if (pesquisarId.Text != "")
            {
                buscar = $" id = '{ pesquisarId.Text.ToUpper() }'";
            }
            if (nome.Text != "")
            {
                if (buscar == "")
                    buscar = $" nome = '{ nome.Text.ToUpper() }'";
                else
                    buscar = $"{buscar} AND nome = '{ nome.Text.ToUpper() }'";
            }
            if (endereco.Text != "")
            {
                if (buscar == "")
                    buscar = $" endereco = '{ endereco.Text.ToUpper() }'";
                else
                    buscar = $"{buscar} AND endereco = '{ endereco.Text.ToUpper() }'";
            }
            if (celular.Text != "")
            {
                if (buscar == "")
                    buscar = $" celular = '{ celular.Text.ToUpper() }'";
                else
                    buscar = $"{buscar} AND celular = '{ celular.Text.ToUpper() }'";
            }
            if (telefone.Text != "")
            {
                if (buscar == "")
                    buscar = $" telefone = '{ telefone.Text.ToUpper() }'";
                else
                    buscar = $"{buscar} AND telefone = '{ telefone.Text.ToUpper() }'";
            }
            if (email.Text != "")
            {
                if (buscar == "")
                    buscar = $" email = '{ email.Text.ToUpper() }'";
                else
                    buscar = $"{buscar} AND email = '{ email.Text.ToUpper() }'";
            }
            if (buscar == "")
                return "SELECT * FROM Contatos";

            buscar = "SELECT * FROM Contatos WHERE " + buscar;

            return buscar;
        }

        private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(Pesquisando(), con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void LimparDados()
        {
            nome.Text = "";
            endereco.Text = "";
            celular.Text = "";
            telefone.Text = "";
            email.Text = "";
            pesquisarId.Text = "";
        }

    }
}