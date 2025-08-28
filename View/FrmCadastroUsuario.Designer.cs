namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            txtCodigo = new TextBox();
            txtPerfil = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtPesquisar = new TextBox();
            btnCancelar = new Button();
            btnExcluircadastro = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnPesquisar = new Button();
            lblSituaçãodoAtendimento = new Label();
            dgvClientes = new DataGridView();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(360, 112);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(176, 23);
            txtPerfil.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 112);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(328, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(528, 23);
            txtNome.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(488, 192);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(168, 23);
            txtPesquisar.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(352, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluircadastro
            // 
            btnExcluircadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluircadastro.ImageIndex = 2;
            btnExcluircadastro.ImageList = imageList1;
            btnExcluircadastro.Location = new Point(272, 192);
            btnExcluircadastro.Name = "btnExcluircadastro";
            btnExcluircadastro.Size = new Size(75, 32);
            btnExcluircadastro.TabIndex = 20;
            btnExcluircadastro.Text = "Excluir";
            btnExcluircadastro.TextAlign = ContentAlignment.MiddleRight;
            btnExcluircadastro.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(104, 192);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 192);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 32);
            btnNovo.TabIndex = 22;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(192, 192);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 24;
            label1.Text = "Dados da Situação Atendimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 25;
            label2.Text = "Código";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 40);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 26;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 96);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 27;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 96);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 28;
            label5.Text = "Perfil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 175);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 29;
            label6.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 2;
            btnPesquisar.Location = new Point(664, 192);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 24);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblSituaçãodoAtendimento
            // 
            lblSituaçãodoAtendimento.AutoSize = true;
            lblSituaçãodoAtendimento.Location = new Point(24, 232);
            lblSituaçãodoAtendimento.Name = "lblSituaçãodoAtendimento";
            lblSituaçãodoAtendimento.Size = new Size(167, 15);
            lblSituaçãodoAtendimento.TabIndex = 31;
            lblSituaçãodoAtendimento.Text = "Lista Situação do atendimento";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(16, 248);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(724, 192);
            dgvClientes.TabIndex = 32;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-editar.png");
            imageList1.Images.SetKeyName(2, "icone-excluir.png");
            imageList1.Images.SetKeyName(3, "icone-novo.png");
            imageList1.Images.SetKeyName(4, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(5, "icone-salva.png");
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(lblSituaçãodoAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluircadastro);
            Controls.Add(btnCancelar);
            Controls.Add(txtPesquisar);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(txtPerfil);
            Controls.Add(txtCodigo);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtPerfil;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtPesquisar;
        private Button btnCancelar;
        private Button btnExcluircadastro;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPesquisar;
        private Label lblSituaçãodoAtendimento;
        private ImageList imageList1;
        private DataGridView dgvClientes;
    }
}