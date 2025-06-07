

using MySql.Data.MySqlClient;

namespace Organização
{
    public class Conexao
    {
        public MySqlConnection con;

        // 🟢 STRING DE CONEXÃO ATUALIZADA
        public Conexao()
        {
            con = new MySqlConnection(
                "Server=localhost;" +
                "Database=bdorganizacao;" +  // Nome SEM acentos
                "User=root;" +               // Usuário do MySQL
                "Password=;" +               // Senha (vazia se não tiver)
                "Convert Zero Datetime=True");
        }

        public void AbrirCon()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        public void FecharCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}