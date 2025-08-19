namespace Sistema_de_Atendimento
{
    partial class frmtelaprincipal
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
            mnuTelaprincipal = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            statusAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            atendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            mnuTelaprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaprincipal
            // 
            mnuTelaprincipal.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, atendimentoToolStripMenuItem, sistemasToolStripMenuItem });
            mnuTelaprincipal.Location = new Point(0, 0);
            mnuTelaprincipal.Name = "mnuTelaprincipal";
            mnuTelaprincipal.Size = new Size(774, 24);
            mnuTelaprincipal.TabIndex = 0;
            mnuTelaprincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, statusAtendimentoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(179, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(179, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(179, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            // 
            // statusAtendimentoToolStripMenuItem
            // 
            statusAtendimentoToolStripMenuItem.Name = "statusAtendimentoToolStripMenuItem";
            statusAtendimentoToolStripMenuItem.Size = new Size(179, 22);
            statusAtendimentoToolStripMenuItem.Text = "Status Atendimento";
            // 
            // atendimentoToolStripMenuItem
            // 
            atendimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, consultasToolStripMenuItem });
            atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            atendimentoToolStripMenuItem.Size = new Size(97, 20);
            atendimentoToolStripMenuItem.Text = " Atendimentos";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(176, 22);
            consultaToolStripMenuItem.Text = "Novo Atendimento";
            consultaToolStripMenuItem.Click += consultaToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(176, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // sistemasToolStripMenuItem
            // 
            sistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            sistemasToolStripMenuItem.Size = new Size(65, 20);
            sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // frmtelaprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Controls.Add(mnuTelaprincipal);
            MainMenuStrip = mnuTelaprincipal;
            Name = "frmtelaprincipal";
            Text = "Sistema de Atendimento";
            mnuTelaprincipal.ResumeLayout(false);
            mnuTelaprincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaprincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem statusAtendimentoToolStripMenuItem;
        private ToolStripMenuItem atendimentoToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
