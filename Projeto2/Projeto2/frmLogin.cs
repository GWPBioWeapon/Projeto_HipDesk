using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection(@"server=localhost;database=formulario-hipdata;Uid=root;Pwd=root;");
        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        //Click do boão logar
        private void btnLogar_Click(object sender, EventArgs e)
        {
            //chamo o método já testando seu retorno
            //preenchendo os parâmetros necessários
            //se retorna true
            if (ValidaUsuario(txtUsuario.Text, txtSenha.Text))
            {
                //retorno o diálogo ok
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //Senão retorno o dialogo cancel por exemplo
                this.DialogResult = DialogResult.Cancel;
            }

        }
        //Método para validar usuário que recebe duas string
        //como parâmetros que será o usuario e senha
        private bool ValidaUsuario(string usuario, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;
            ////instância da cocexão

            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM usuarios WHERE Usuario=@Usuario AND Senha=@Senha";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            //preenchimento dos parâmetros
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            //abro conexão
            conn.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            conn.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO usuarios (Usuario, Senha) " +
                                         "VALUES('" + txtUsuario.Text + "','" + txtSenha.Text + "')", conn);

                command.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Não é possivel inserir valores em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
