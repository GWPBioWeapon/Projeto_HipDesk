using System.Data;
using System.Drawing;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private void conectar()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(" Persist Security Info=False;" +
                                    "server = localhost;" +
                                    "database = formulario-hipdata;" +
                                    "uid = root; pwd = root");

            try
            {
                mConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void mostrarResultados()
        {

            if (mConn.State == ConnectionState.Open)
            {
                mAdapter = new MySqlDataAdapter("SELECT ID,NOME,EMAIL,CATEGORIA,PRIORIDADE,ASSUNTO,INFORMACOES FROM CHAMADOS", mConn);
                mAdapter.Fill(mDataSet, "Chamados");
                dgvDados.DataSource = mDataSet;
                dgvDados.DataMember = "Chamados";
                mConn.Close();
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEmail.Text = "";
            txtAssunto.Text = "";
            txtInformacoes.Text = "";
            cbCategoria.Text = "";
            cbPrioridade.Text = "";
        }
        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtEmail.Text != "")
            {
                conectar();
                MySqlCommand command = new MySqlCommand("INSERT INTO chamados (nome, email, categoria, prioridade, assunto, informacoes) " +
                                         "VALUES('" + txtNome.Text + "','" + txtEmail.Text + "','" + cbCategoria.Text + "','" + cbPrioridade.Text + "','" + txtAssunto.Text + "','" + txtInformacoes.Text + "')", mConn);

                command.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarResultados();
                Limpar();
            }
            else
            {
                MessageBox.Show("Não é possivel inserir valores em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();
            if (id != null)
            {
                this.txtNome.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["nome"].Value);
                this.txtEmail.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["email"].Value);
                this.cbCategoria.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["categoria"].Value);
                this.cbPrioridade.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["prioridade"].Value);
                this.txtAssunto.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["assunto"].Value);
                this.txtInformacoes.Text = Convert.ToString(this.dgvDados.CurrentRow.Cells["informacoes"].Value);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string valor_id = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();
            if (valor_id != string.Empty)
            {
                conectar();
                MySqlCommand command = new MySqlCommand("delete from chamados where id ='"
                                                        + valor_id + "';", mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Chamado excluído com sucesso.");
                mostrarResultados();
                Limpar();
            }
            else
            {
                MessageBox.Show("Selecione um dos chamados para excluí-lo.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAtualizar_Click(Object sender, EventArgs e)
        {
            string valor_ID = this.dgvDados.CurrentRow.Cells["id"].Value.ToString();
            string sql = "UPDATE chamados SET nome = '" + txtNome.Text + "', email = '" + txtEmail.Text + "', categoria = '" + cbCategoria.Text + "', prioridade = '" + cbPrioridade.Text + "', assunto = '" + txtAssunto.Text + "', informacoes = '" + txtInformacoes.Text + "' WHERE id = " + valor_ID + ";";


            if (valor_ID != string.Empty)
            {
                conectar();
                MySqlCommand command = new MySqlCommand(sql, mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Alterado com sucesso!");
                mostrarResultados();
                Limpar();
            }
            else
            {
                MessageBox.Show("Para atualizar, selecione um registro.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();
            mostrarResultados();
            Limpar();
        }
    }
}