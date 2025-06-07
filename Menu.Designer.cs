namespace Organização
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            MenuPrincipal = new MenuStrip();
            MenuCadastro = new ToolStripMenuItem();
            MenuAdministrador = new ToolStripMenuItem();
            MenuUsuario = new ToolStripMenuItem();
            MenuTarefas = new ToolStripMenuItem();
            categoriasToolStripMenuItem1 = new ToolStripMenuItem();
            nomeDaTarefasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            logauteToolStripMenuItem = new ToolStripMenuItem();
            PnlTopo = new Panel();
            BtnNomeTarefas = new Button();
            button1 = new Button();
            BtnTarefas = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnSair = new Button();
            panel1 = new Panel();
            label15 = new Label();
            BtnAdministrador = new Button();
            BtnUsuario = new Button();
            panel3 = new Panel();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            LbQuem = new Label();
            label9 = new Label();
            label8 = new Label();
            LbNomeUsuario = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            PictFotoUsuario = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            LbHora = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            LbData = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            MenuPrincipal.SuspendLayout();
            PnlTopo.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictFotoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.BackColor = Color.FromArgb(252, 208, 18);
            MenuPrincipal.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { MenuCadastro, sairToolStripMenuItem });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(1181, 24);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            MenuCadastro.DropDownItems.AddRange(new ToolStripItem[] { MenuAdministrador, MenuUsuario, MenuTarefas, categoriasToolStripMenuItem1, nomeDaTarefasToolStripMenuItem });
            MenuCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MenuCadastro.Image = (Image)resources.GetObject("MenuCadastro.Image");
            MenuCadastro.Name = "MenuCadastro";
            MenuCadastro.Size = new Size(83, 20);
            MenuCadastro.Text = "Cadastro";
            // 
            // MenuAdministrador
            // 
            MenuAdministrador.Image = (Image)resources.GetObject("MenuAdministrador.Image");
            MenuAdministrador.Name = "MenuAdministrador";
            MenuAdministrador.Size = new Size(153, 22);
            MenuAdministrador.Text = "Administrador";
            MenuAdministrador.Click += loginToolStripMenuItem_Click;
            // 
            // MenuUsuario
            // 
            MenuUsuario.BackColor = Color.Transparent;
            MenuUsuario.Image = (Image)resources.GetObject("MenuUsuario.Image");
            MenuUsuario.Name = "MenuUsuario";
            MenuUsuario.Size = new Size(153, 22);
            MenuUsuario.Text = "Usuário";
            MenuUsuario.Click += MenuUsuario_Click;
            // 
            // MenuTarefas
            // 
            MenuTarefas.BackColor = Color.Transparent;
            MenuTarefas.Image = (Image)resources.GetObject("MenuTarefas.Image");
            MenuTarefas.Name = "MenuTarefas";
            MenuTarefas.Size = new Size(153, 22);
            MenuTarefas.Text = "Tarefas";
            MenuTarefas.Click += MenuTarefas_Click;
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.BackColor = Color.Transparent;
            categoriasToolStripMenuItem1.Image = (Image)resources.GetObject("categoriasToolStripMenuItem1.Image");
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.Size = new Size(153, 22);
            categoriasToolStripMenuItem1.Text = "Quem";
            categoriasToolStripMenuItem1.Click += categoriasToolStripMenuItem1_Click;
            // 
            // nomeDaTarefasToolStripMenuItem
            // 
            nomeDaTarefasToolStripMenuItem.Image = (Image)resources.GetObject("nomeDaTarefasToolStripMenuItem.Image");
            nomeDaTarefasToolStripMenuItem.Name = "nomeDaTarefasToolStripMenuItem";
            nomeDaTarefasToolStripMenuItem.Size = new Size(153, 22);
            nomeDaTarefasToolStripMenuItem.Text = "NomeTarefas";
            nomeDaTarefasToolStripMenuItem.Click += nomeDaTarefasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logauteToolStripMenuItem });
            sairToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sairToolStripMenuItem.Image = (Image)resources.GetObject("sairToolStripMenuItem.Image");
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(56, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // logauteToolStripMenuItem
            // 
            logauteToolStripMenuItem.Name = "logauteToolStripMenuItem";
            logauteToolStripMenuItem.Size = new Size(113, 22);
            logauteToolStripMenuItem.Text = "Logout";
            logauteToolStripMenuItem.Click += logauteToolStripMenuItem_Click;
            // 
            // PnlTopo
            // 
            PnlTopo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PnlTopo.BackColor = Color.FromArgb(122, 121, 125);
            PnlTopo.Controls.Add(BtnNomeTarefas);
            PnlTopo.Controls.Add(button1);
            PnlTopo.Controls.Add(BtnTarefas);
            PnlTopo.Controls.Add(panel2);
            PnlTopo.Controls.Add(BtnSair);
            PnlTopo.Controls.Add(panel1);
            PnlTopo.Controls.Add(label15);
            PnlTopo.Controls.Add(BtnAdministrador);
            PnlTopo.Controls.Add(BtnUsuario);
            PnlTopo.Location = new Point(0, 27);
            PnlTopo.Name = "PnlTopo";
            PnlTopo.Size = new Size(815, 136);
            PnlTopo.TabIndex = 1;
            // 
            // BtnNomeTarefas
            // 
            BtnNomeTarefas.BackColor = Color.FromArgb(177, 177, 177);
            BtnNomeTarefas.FlatAppearance.BorderSize = 0;
            BtnNomeTarefas.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnNomeTarefas.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnNomeTarefas.FlatStyle = FlatStyle.Flat;
            BtnNomeTarefas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNomeTarefas.Image = (Image)resources.GetObject("BtnNomeTarefas.Image");
            BtnNomeTarefas.ImageAlign = ContentAlignment.TopCenter;
            BtnNomeTarefas.Location = new Point(535, 17);
            BtnNomeTarefas.Name = "BtnNomeTarefas";
            BtnNomeTarefas.Size = new Size(79, 85);
            BtnNomeTarefas.TabIndex = 4;
            BtnNomeTarefas.TextAlign = ContentAlignment.BottomCenter;
            BtnNomeTarefas.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNomeTarefas.UseVisualStyleBackColor = false;
            BtnNomeTarefas.Click += BtnNomeTarefas_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(177, 177, 177);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(411, 17);
            button1.Name = "button1";
            button1.Size = new Size(83, 85);
            button1.TabIndex = 5;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BtnTarefas
            // 
            BtnTarefas.BackColor = Color.FromArgb(177, 177, 177);
            BtnTarefas.FlatAppearance.BorderSize = 0;
            BtnTarefas.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnTarefas.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnTarefas.FlatStyle = FlatStyle.Flat;
            BtnTarefas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTarefas.Image = (Image)resources.GetObject("BtnTarefas.Image");
            BtnTarefas.ImageAlign = ContentAlignment.TopCenter;
            BtnTarefas.Location = new Point(287, 18);
            BtnTarefas.Name = "BtnTarefas";
            BtnTarefas.Size = new Size(79, 85);
            BtnTarefas.TabIndex = 4;
            BtnTarefas.TextAlign = ContentAlignment.BottomCenter;
            BtnTarefas.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnTarefas.UseVisualStyleBackColor = false;
            BtnTarefas.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(832, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 474);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(122, 121, 125);
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(340, 471);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.FromArgb(177, 177, 177);
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnSair.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.ImageAlign = ContentAlignment.TopCenter;
            BtnSair.Location = new Point(662, 18);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(79, 85);
            BtnSair.TabIndex = 3;
            BtnSair.TextAlign = ContentAlignment.BottomCenter;
            BtnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(832, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 719);
            panel1.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(243, 105);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 3;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.BackColor = Color.FromArgb(177, 177, 177);
            BtnAdministrador.FlatAppearance.BorderSize = 0;
            BtnAdministrador.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnAdministrador.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdministrador.Image = (Image)resources.GetObject("BtnAdministrador.Image");
            BtnAdministrador.ImageAlign = ContentAlignment.TopCenter;
            BtnAdministrador.Location = new Point(41, 18);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(84, 85);
            BtnAdministrador.TabIndex = 5;
            BtnAdministrador.TextAlign = ContentAlignment.BottomCenter;
            BtnAdministrador.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnAdministrador.UseVisualStyleBackColor = false;
            BtnAdministrador.Click += BtnAdministrador_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.BackColor = Color.FromArgb(177, 177, 177);
            BtnUsuario.FlatAppearance.BorderSize = 0;
            BtnUsuario.FlatAppearance.MouseDownBackColor = Color.Gray;
            BtnUsuario.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnUsuario.FlatStyle = FlatStyle.Flat;
            BtnUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsuario.Image = (Image)resources.GetObject("BtnUsuario.Image");
            BtnUsuario.ImageAlign = ContentAlignment.TopCenter;
            BtnUsuario.Location = new Point(163, 18);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(80, 85);
            BtnUsuario.TabIndex = 0;
            BtnUsuario.TextAlign = ContentAlignment.BottomCenter;
            BtnUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnUsuario.UseVisualStyleBackColor = false;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(122, 121, 125);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label24);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(LbQuem);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(LbNomeUsuario);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(PictFotoUsuario);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(LbHora);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(LbData);
            panel3.Controls.Add(label1);
            panel3.Font = new Font("Segoe UI", 9F);
            panel3.Location = new Point(798, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 722);
            panel3.TabIndex = 2;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(167, 632);
            label24.Name = "label24";
            label24.Size = new Size(106, 20);
            label24.TabIndex = 31;
            label24.Text = "Data do Início";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(152, 668);
            label23.Name = "label23";
            label23.Size = new Size(94, 20);
            label23.TabIndex = 30;
            label23.Text = "Data do Fim";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(274, 602);
            label22.Name = "label22";
            label22.Size = new Size(67, 20);
            label22.TabIndex = 29;
            label22.Text = "Número";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(252, 208, 18);
            label21.Location = new Point(102, 631);
            label21.Name = "label21";
            label21.Size = new Size(59, 21);
            label21.TabIndex = 28;
            label21.Text = "Início:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(252, 208, 18);
            label20.Location = new Point(102, 662);
            label20.Name = "label20";
            label20.Size = new Size(44, 21);
            label20.TabIndex = 27;
            label20.Text = "Fim:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(252, 208, 18);
            label19.Location = new Point(102, 601);
            label19.Name = "label19";
            label19.Size = new Size(166, 21);
            label19.TabIndex = 26;
            label19.Text = "Nº de Participantes:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(136, 549);
            label18.Name = "label18";
            label18.Size = new Size(151, 41);
            label18.TabIndex = 25;
            label18.Text = "DESAFIO ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(179, 492);
            label17.Name = "label17";
            label17.Size = new Size(137, 21);
            label17.TabIndex = 24;
            label17.Text = "Usuário 3º lugar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(179, 462);
            label16.Name = "label16";
            label16.Size = new Size(142, 21);
            label16.TabIndex = 23;
            label16.Text = "Usuário 2º Lugar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(175, 430);
            label14.Name = "label14";
            label14.Size = new Size(141, 21);
            label14.TabIndex = 22;
            label14.Text = "Usuário 1º Lugar";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(13, 340);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 75);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(252, 208, 18);
            label13.Location = new Point(70, 489);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 20;
            label13.Text = "3º Lugar:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(252, 208, 18);
            label12.Location = new Point(70, 459);
            label12.Name = "label12";
            label12.Size = new Size(95, 25);
            label12.TabIndex = 19;
            label12.Text = "2º Lugar:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(252, 208, 18);
            label11.Location = new Point(70, 427);
            label11.Name = "label11";
            label11.Size = new Size(95, 25);
            label11.TabIndex = 18;
            label11.Text = "1º Lugar:";
            // 
            // LbQuem
            // 
            LbQuem.AutoSize = true;
            LbQuem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LbQuem.ForeColor = Color.Black;
            LbQuem.Location = new Point(126, 285);
            LbQuem.Name = "LbQuem";
            LbQuem.Size = new Size(240, 25);
            LbQuem.TabIndex = 17;
            LbQuem.Text = "Quem é o Usuário na casa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(136, 346);
            label9.Name = "label9";
            label9.Size = new Size(97, 41);
            label9.TabIndex = 16;
            label9.Text = "Rank ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(252, 208, 18);
            label8.Location = new Point(126, 255);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 15;
            label8.Text = "Quem:";
            // 
            // LbNomeUsuario
            // 
            LbNomeUsuario.AutoSize = true;
            LbNomeUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LbNomeUsuario.ForeColor = Color.Black;
            LbNomeUsuario.Location = new Point(121, 219);
            LbNomeUsuario.Name = "LbNomeUsuario";
            LbNomeUsuario.Size = new Size(166, 25);
            LbNomeUsuario.TabIndex = 14;
            LbNomeUsuario.Text = "Nome do Usuario";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(13, 602);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 86);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(276, 346);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // PictFotoUsuario
            // 
            PictFotoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictFotoUsuario.BackColor = Color.Transparent;
            PictFotoUsuario.BorderStyle = BorderStyle.FixedSingle;
            PictFotoUsuario.Location = new Point(13, 208);
            PictFotoUsuario.Name = "PictFotoUsuario";
            PictFotoUsuario.Size = new Size(93, 102);
            PictFotoUsuario.SizeMode = PictureBoxSizeMode.AutoSize;
            PictFotoUsuario.TabIndex = 11;
            PictFotoUsuario.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(177, 177, 177);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(177, 177, 177);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            LbHora.ForeColor = SystemColors.ControlLightLight;
            LbHora.ImageAlign = ContentAlignment.TopCenter;
            LbHora.Location = new Point(224, 131);
            LbHora.Name = "LbHora";
            LbHora.Size = new Size(136, 41);
            LbHora.TabIndex = 8;
            LbHora.Text = "15:00:00";
            LbHora.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(252, 208, 18);
            label5.Location = new Point(121, 199);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 7;
            label5.Text = "Usuário Logado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-137, 525);
            label4.Name = "label4";
            label4.Size = new Size(707, 15);
            label4.TabIndex = 6;
            label4.Text = "____________________________________________________________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-137, 322);
            label3.Name = "label3";
            label3.Size = new Size(707, 15);
            label3.TabIndex = 5;
            label3.Text = "____________________________________________________________________________________________________________________________________________";
            // 
            // LbData
            // 
            LbData.AutoSize = true;
            LbData.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            LbData.ForeColor = SystemColors.ControlLightLight;
            LbData.Location = new Point(22, 131);
            LbData.Name = "LbData";
            LbData.Size = new Size(159, 36);
            LbData.TabIndex = 4;
            LbData.Text = "22/04/2025";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-28, 169);
            label1.Name = "label1";
            label1.Size = new Size(707, 15);
            label1.TabIndex = 3;
            label1.Text = "____________________________________________________________________________________________________________________________________________";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1181, 749);
            Controls.Add(panel3);
            Controls.Add(PnlTopo);
            Controls.Add(MenuPrincipal);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuPrincipal;
            MaximizeBox = false;
            Name = "FormMenu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            PnlTopo.ResumeLayout(false);
            PnlTopo.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictFotoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem MenuCadastro;
        private ToolStripMenuItem MenuUsuario;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
        private ToolStripMenuItem logauteToolStripMenuItem;
        private Panel PnlTopo;
        private Button BtnUsuario;
        private Button BtnAdministrador;
        private Button BtnSair;
        private Label label15;
        private ToolStripMenuItem MenuAdministrador;
        private ToolStripMenuItem MenuTarefas;
        private ToolStripMenuItem nomeDaTarefasToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label LbHora;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label LbData;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox PictFotoUsuario;
        private Label LbNomeUsuario;
        private Label label11;
        private Label LbQuem;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label12;
        private PictureBox pictureBox6;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label24;
        private Label label23;
        private System.Windows.Forms.Timer timer1;
        private Button BtnTarefas;
        private Button button1;
        private Button BtnNomeTarefas;
    }
}