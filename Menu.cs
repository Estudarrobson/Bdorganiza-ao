/*******************************************************************************
 * MÓDULO: Gerenciador de Tarefas Domésticas
 * 
 * CAMADA: Apresentação (FormMenu.cs)
 * 
 * DESCRIÇÃO: Tela principal após o login do usuário.
 *            Exibe o nome do usuario logado e sua foto, data e hora atuais,
 *            e fornece acesso às demais funcionalidades 
 *            do sistema por meio de botões de navegação e menu.
 *            
 *******************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Organização.Cadastro;

namespace Organização
{
    public partial class FormMenu : Form
    {
        Conexao Cnx = new Conexao();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

      
        //FORM LOAD
        private void FormMenu_Load(object sender, EventArgs e)
        {
            //CHAMADA DA VERIFICAÇÃO DATA
            VerificarData();

            // VERIFICAÇÃO DO TIMER FOI REINICIADO
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer1.Start();
                MessageBox.Show("Timer foi reiniciado!"); // Apenas para debug, remova depois
            }

            // Textos do usuário
            LbNomeUsuario.Text = Program.NomeUsuario;
            LbQuem.Text = Program.QuemUsuario;

            // 🟢 CARREGAMENTO DA FOTO (código novo)
            try
            {
                if (Program.FotoUsuario != null && Program.FotoUsuario.Length > 0)
                {
                    using (var ms = new MemoryStream(Program.FotoUsuario))
                    {
                        PictFotoUsuario.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    PictFotoUsuario.Image = Properties.Resources.usuario82;
                }
            }
            catch
            {
                PictFotoUsuario.Image = Properties.Resources.usuario82;
            }

            // Configuração do timer
            timer1.Interval = 1000; // 1000ms = 1 segundo
            timer1.Enabled = true;  // Habilita o timer
            timer1.Start();         // Inicia o timer

            // Atualiza imediatamente ao carregar
            LbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LbHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        // DATA
        private void VerificarData()
        {
            try
            {
                DateTime dataServidor = ObterDataDoServidor();

                // Só mostra alerta se a diferença for maior que 1 dia
                if (dataServidor != DateTime.MinValue &&
                    Math.Abs((dataServidor - DateTime.Now).TotalDays) > 1)
                {
                    MessageBox.Show($"Atenção: Seu computador está com a data incorreta!\n\n" +
                                  $"Data do sistema: {DateTime.Now:dd/MM/yyyy}\n" +
                                  $"Data do servidor: {dataServidor:dd/MM/yyyy}",
                                  "Alerta de Data",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar data: {ex.Message}");
                // Não mostra erro para o usuário para não ser intrusivo
            }
        }

        // RELÓGIO
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            LbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // DATA
        private DateTime ObterDataDoServidor()
        {
            try
            {
                Cnx.AbrirCon();
                MySqlCommand cmd = new MySqlCommand("SELECT NOW()", Cnx.con);
                return Convert.ToDateTime(cmd.ExecuteScalar());
            }
            catch
            {
                return DateTime.MinValue;
            }
            finally
            {
                Cnx.FecharCon();
            }
        }

        //EVENTO TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime agora = DateTime.Now;
                LbHora.Text = agora.ToString("HH:mm:ss");
                LbData.Text = agora.ToString("dd/MM/yyyy");

                // Força a atualização imediata
                LbHora.Invalidate();
                LbData.Invalidate();
                Application.DoEvents(); // Opcional - use com cuidado
            }
            catch (Exception ex)
            {
                // Logar erro se necessário
                Console.WriteLine($"Erro no timer: {ex.Message}");
            }
        }

        // MENU SAIR
        private void logauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close(); // fecha a principal quando a login for fechada
            this.Hide();
            login.Show();

        }

        // BOTÃO SAIR
        private void BtnSair_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.FormClosed += (s, args) => this.Close(); // fecha a principal quando a login for fechada
            this.Hide();
            login.Show();

        }


        // FORM  BOTÃO MENU ------------- USUÁRIO ---------------------
        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            Cadastro.FormUsuario Form = new Cadastro.FormUsuario();
            Form.Show();
        }

        //FORM ----------- USUARIO --------------
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Cadastro.FormUsuario Form = new Cadastro.FormUsuario();
            Form.Show();
        }

        //FORM ----------- ADMINISTRADOR------------
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FormAdministrador form = new Cadastro.FormAdministrador(
                Program.NomeUsuario,
                Program.QuemUsuario,
                Program.IdUsuario.ToString(),
                Program.FotoUsuario
            );
            form.Show();
        }

        // FORM  BOTÃO MENU ------------- ADMINISTRADOR ---------------
        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            Cadastro.FormAdministrador form = new Cadastro.FormAdministrador(
                Program.NomeUsuario,
                Program.QuemUsuario,
                Program.IdUsuario.ToString(),
                Program.FotoUsuario
            );
            form.Show();
        }

        //FORM ---------- TAREFAS ----------------
        private void MenuTarefas_Click(object sender, EventArgs e)
        {
            Cadastro.FormTarefas Form = new Cadastro.FormTarefas();
            Form.Show();
        }

        //  FORM  BOTÃO MENU -----------TAREFAS------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro.FormTarefas Form = new Cadastro.FormTarefas();
            Form.Show();
        }

        //FORM ---------- NOMETAREFA-----------
        private void nomeDaTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.FormNomeTarefa Form = new Cadastro.FormNomeTarefa();
            Form.Show();
        }

        // FORM  BOTÃO ---------- NOME TAREFAS ---------
        private void BtnNomeTarefas_Click(object sender, EventArgs e)
        {
            Cadastro.FormNomeTarefa Form = new Cadastro.FormNomeTarefa();
            Form.Show();
        }

        //FORM ---------- QUEM ---------
        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro.FormQuem Form = new Cadastro.FormQuem();
            Form.Show();
        }

        // FORM  BOTÃO ---------- QUEM ---------
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastro.FormQuem Form = new Cadastro.FormQuem();
            Form.Show();
        }

        
    }
}