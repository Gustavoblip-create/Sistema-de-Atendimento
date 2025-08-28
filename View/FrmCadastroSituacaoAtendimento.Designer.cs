namespace SistemaAtendimento.View
{
    partial class FrmCadastroSituacaoAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroSituacaoAtendimento));
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtNome = new TextBox();
            txtCor = new TextBox();
            btnnovo = new Button();
            btnCnacelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblCor = new Label();
            label3 = new Label();
            lblNome = new Label();
            lblSituação = new Label();
            lblDadosdasituacaoatendimento = new Label();
            grbListadeSituacaodoAtendimento = new GroupBox();
            dgvListadeSituacao = new DataGridView();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            btAtivo = new RadioButton();
            rbInativo = new RadioButton();
            grbListadeSituacaodoAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadeSituacao).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(32, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(112, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(32, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(552, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(32, 104);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(336, 23);
            txtCor.TabIndex = 3;
            txtCor.TextChanged += txtCor_TextChanged;
            // 
            // btnnovo
            // 
            btnnovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnnovo.ImageIndex = 3;
            btnnovo.ImageList = imageList1;
            btnnovo.Location = new Point(32, 168);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 32);
            btnnovo.TabIndex = 4;
            btnnovo.Text = "Novo";
            btnnovo.TextAlign = ContentAlignment.MiddleRight;
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // btnCnacelar
            // 
            btnCnacelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnacelar.ImageIndex = 0;
            btnCnacelar.ImageList = imageList1;
            btnCnacelar.Location = new Point(368, 168);
            btnCnacelar.Name = "btnCnacelar";
            btnCnacelar.Size = new Size(80, 32);
            btnCnacelar.TabIndex = 5;
            btnCnacelar.Text = "Cancelar";
            btnCnacelar.TextAlign = ContentAlignment.MiddleRight;
            btnCnacelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(288, 168);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(208, 168);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(120, 168);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(480, 168);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(160, 23);
            txtPesquisar.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(648, 168);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(32, 88);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 14;
            lblCor.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 152);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Pesquisar";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(160, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome";
            // 
            // lblSituação
            // 
            lblSituação.AutoSize = true;
            lblSituação.Location = new Point(376, 88);
            lblSituação.Name = "lblSituação";
            lblSituação.Size = new Size(52, 15);
            lblSituação.TabIndex = 17;
            lblSituação.Text = "Situação";
            // 
            // lblDadosdasituacaoatendimento
            // 
            lblDadosdasituacaoatendimento.AutoSize = true;
            lblDadosdasituacaoatendimento.Location = new Point(32, 16);
            lblDadosdasituacaoatendimento.Name = "lblDadosdasituacaoatendimento";
            lblDadosdasituacaoatendimento.Size = new Size(194, 15);
            lblDadosdasituacaoatendimento.TabIndex = 18;
            lblDadosdasituacaoatendimento.Text = "Dados da Situação do Atendimento";
            // 
            // grbListadeSituacaodoAtendimento
            // 
            grbListadeSituacaodoAtendimento.Controls.Add(dgvListadeSituacao);
            grbListadeSituacaodoAtendimento.Location = new Point(32, 208);
            grbListadeSituacaodoAtendimento.Name = "grbListadeSituacaodoAtendimento";
            grbListadeSituacaodoAtendimento.Size = new Size(688, 224);
            grbListadeSituacaodoAtendimento.TabIndex = 19;
            grbListadeSituacaodoAtendimento.TabStop = false;
            grbListadeSituacaodoAtendimento.Text = "Lista de Situação do Atendimento";
            // 
            // dgvListadeSituacao
            // 
            dgvListadeSituacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeSituacao.Location = new Point(0, 24);
            dgvListadeSituacao.Name = "dgvListadeSituacao";
            dgvListadeSituacao.Size = new Size(688, 200);
            dgvListadeSituacao.TabIndex = 0;
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
            // panel1
            // 
            panel1.Controls.Add(rbInativo);
            panel1.Controls.Add(btAtivo);
            panel1.Location = new Point(376, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 24);
            panel1.TabIndex = 20;
            // 
            // btAtivo
            // 
            btAtivo.AutoSize = true;
            btAtivo.Location = new Point(0, 2);
            btAtivo.Name = "btAtivo";
            btAtivo.Size = new Size(53, 19);
            btAtivo.TabIndex = 12;
            btAtivo.TabStop = true;
            btAtivo.Text = "Ativo";
            btAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            rbInativo.AutoSize = true;
            rbInativo.Location = new Point(63, 2);
            rbInativo.Name = "rbInativo";
            rbInativo.Size = new Size(61, 19);
            rbInativo.TabIndex = 14;
            rbInativo.TabStop = true;
            rbInativo.Text = "Inativo";
            rbInativo.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(panel1);
            Controls.Add(grbListadeSituacaodoAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(label3);
            Controls.Add(btnExcluir);
            Controls.Add(txtPesquisar);
            Controls.Add(btnCnacelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnnovo);
            Controls.Add(lblDadosdasituacaoatendimento);
            Controls.Add(lblSituação);
            Controls.Add(lblNome);
            Controls.Add(lblCor);
            Controls.Add(txtCor);
            Controls.Add(txtNome);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastro de Status de Atendimentos";
            grbListadeSituacaodoAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadeSituacao).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNome;
        private TextBox txtCor;
        private Button btnnovo;
        private Button btnCnacelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblCor;
        private Label label3;
        private Label lblNome;
        private Label lblSituação;
        private Label lblDadosdasituacaoatendimento;
        private GroupBox grbListadeSituacaodoAtendimento;
        private DataGridView dgvListadeSituacao;
        private ImageList imageList1;
        private Panel panel1;
        private RadioButton btAtivo;
        private RadioButton rbInativo;
    }
}