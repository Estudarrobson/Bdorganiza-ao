/**********************************************************
 * MÓDULO: Gerenciador de Tarefas Domésticas
 * 
 * CAMADA: Apresentação (FormLogin.cs)
 * 
 * DESCRIÇÃO: Tela responsável por autenticar o acesso ao sistema.
 *            Apenas usuários previamente cadastrados no 
 *            formulário de administrador têm permissão para login.
 *            Inicialmente, o sistema está configurado para 
 *            autenticar somente perfis de administradores.
 *            
 **********************************************************/


using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Organização
{
    public partial class FormLogin : Form
    {
        Conexao Cnx = new Conexao();

        public FormLogin()
        {
            InitializeComponent();
            PnlLogin.Visible = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            PnlLogin.Location = new Point(this.Width / 2 - 165, this.Height / 2 - 231);
            PnlLogin.Visible = true;
        }

        // Validação de Botões Login: Usuário e Senha (MANTIDO ORIGINAL)
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        // Private void Não tem retorno (MANTIDO ORIGINAL)
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        // Método Chamar Login - COM TODAS SUAS VALIDAÇÕES + MELHORIAS
        private void ChamarLogin()
        {
            // VALIDAÇÕES  
            if (TextUsuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Usuário !", "Campo Vazio",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextUsuario.Text = "";
                TextUsuario.Focus();
                return;
            }
            if (TextSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a Senha !", "Campo Vazio",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextSenha.Text = "";
                TextSenha.Focus();
                return;
            }

            // CONSULTA SQL (COM JOIN PARA A FOTO)
            string query = @"
        SELECT 
            a.nome,
            a.quem,
            a.id_usuario,
            u.foto
        FROM administrador a
        LEFT JOIN usuario u ON a.id_usuario = u.id
        WHERE a.usuario = @usuario 
        AND a.senha = @senha";

            try
            {
                Cnx.AbrirCon();
                using (MySqlCommand cmd = new MySqlCommand(query, Cnx.con))
                {
                    cmd.Parameters.AddWithValue("@usuario", TextUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", TextSenha.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            // 3️⃣ MENSAGEM DE BOAS-VINDAS ORIGINAL (RESTAURADA)
                            MessageBox.Show("Bem Vindo(a) ! " + reader["nome"].ToString(),
                                          "Login Efetuado com Sucesso !",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Exclamation);

                            // 4️⃣ ARMAZENA OS DADOS (INCLUINDO FOTO)
                            Program.NomeUsuario = reader["nome"].ToString();
                            Program.QuemUsuario = reader["quem"].ToString();
                            Program.IdUsuario = reader.GetInt32("id_usuario");
                            Program.FotoUsuario = !reader.IsDBNull(reader.GetOrdinal("foto"))
                                ? (byte[])reader["foto"]
                                : null;

                            // 5️⃣ ABRE O MENU
                            FormMenu form = new FormMenu();
                            LimparLogin(); // Método original que limpa os campos
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            // MENSAGEM ORIGINAL DE ERRO
                            MessageBox.Show("Usuário ou Senha Incorretos!",
                                          "Dados Incorretos !",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                            TextUsuario.Text = "";
                            TextUsuario.Focus();
                            TextSenha.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cnx.FecharCon();
            }
        }
        private void LimparLogin()
        {
            TextUsuario.Text = "";
            TextSenha.Text = "";
            TextUsuario.Focus();
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            PnlLogin.Location = new Point(this.Width / 2 - 165, this.Height / 2 - 231);
        }
    }
}