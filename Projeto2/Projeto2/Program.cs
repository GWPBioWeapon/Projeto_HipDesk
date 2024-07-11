using MySql.Data.MySqlClient;

namespace Projeto2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;Database=formulario-hipdata;Uid=root;Pwd=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conex�o com a HipData estabelecida com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //inst�ncia do formul�rio login
            frmLogin frm = new frmLogin();
            //Se o resultado do dialogo for ok
            //ou seja se o usuario e login constarem no bd
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //abro o formul�rio principal
                Application.Run(new Form1());
            }
            else
            {
                //Sen�o mostro a mensagem e fecho a apica��o
                MessageBox.Show("Usu�rio ou Login inv�lidos!");
            }
        
            ApplicationConfiguration.Initialize();
            
        }
    }
}