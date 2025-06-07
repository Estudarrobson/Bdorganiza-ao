namespace Organização
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            PnlLogin = new Panel();
            TextSenha = new TextBox();
            TextUsuario = new TextBox();
            BtnLogin = new Button();
            PnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLogin
            // 
            PnlLogin.BackColor = Color.Transparent;
            PnlLogin.BackgroundImage = (Image)resources.GetObject("PnlLogin.BackgroundImage");
            PnlLogin.Controls.Add(TextSenha);
            PnlLogin.Controls.Add(TextUsuario);
            PnlLogin.Controls.Add(BtnLogin);
            PnlLogin.Location = new Point(303, 29);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(330, 462);
            PnlLogin.TabIndex = 0;
            // 
            // TextSenha
            // 
            TextSenha.BackColor = Color.FromArgb(252, 208, 18);
            TextSenha.BorderStyle = BorderStyle.None;
            TextSenha.Cursor = Cursors.Hand;
            TextSenha.Font = new Font("Segoe UI", 10F);
            TextSenha.Location = new Point(89, 295);
            TextSenha.Name = "TextSenha";
            TextSenha.PasswordChar = '*';
            TextSenha.Size = new Size(196, 18);
            TextSenha.TabIndex = 2;
            // 
            // TextUsuario
            // 
            TextUsuario.BackColor = Color.FromArgb(252, 208, 18);
            TextUsuario.BorderStyle = BorderStyle.None;
            TextUsuario.Cursor = Cursors.Hand;
            TextUsuario.Font = new Font("Segoe UI", 10F);
            TextUsuario.Location = new Point(99, 244);
            TextUsuario.Name = "TextUsuario";
            TextUsuario.Size = new Size(186, 18);
            TextUsuario.TabIndex = 1;
   
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(252, 208, 18);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 184, 0);
            BtnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 194, 50);
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnLogin.Image = (Image)resources.GetObject("BtnLogin.Image");
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(89, 362);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(149, 46);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 523);
            Controls.Add(PnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "LOGIN";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            KeyDown += FormLogin_KeyDown;
            Resize += FormLogin_Resize;
            PnlLogin.ResumeLayout(false);
            PnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLogin;
        private Button BtnLogin;
        private TextBox TextUsuario;
        private TextBox TextSenha;
    }
}
