namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEtapa));
            grbDadosdaetapa = new GroupBox();
            grbListadeEtapas = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnExcluir = new Button();
            btnCnacelar = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnnovo = new Button();
            btnPesquisar = new Button();
            label3 = new Label();
            txtPesquisar = new TextBox();
            lblCodigo = new Label();
            lblNome = new Label();
            lblOrdem = new Label();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvListadeetapa = new DataGridView();
            panel1 = new Panel();
            lblSituação = new Label();
            rbInativo = new RadioButton();
            btAtivo = new RadioButton();
            grbDadosdaetapa.SuspendLayout();
            grbListadeEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadeetapa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grbDadosdaetapa
            // 
            grbDadosdaetapa.Controls.Add(lblSituação);
            grbDadosdaetapa.Controls.Add(panel1);
            grbDadosdaetapa.Controls.Add(lblOrdem);
            grbDadosdaetapa.Controls.Add(lblNome);
            grbDadosdaetapa.Controls.Add(lblCodigo);
            grbDadosdaetapa.Controls.Add(textBox3);
            grbDadosdaetapa.Controls.Add(textBox2);
            grbDadosdaetapa.Controls.Add(textBox1);
            grbDadosdaetapa.Location = new Point(32, 32);
            grbDadosdaetapa.Name = "grbDadosdaetapa";
            grbDadosdaetapa.Size = new Size(736, 136);
            grbDadosdaetapa.TabIndex = 0;
            grbDadosdaetapa.TabStop = false;
            grbDadosdaetapa.Text = "Dados Da Etapa";
            grbDadosdaetapa.Enter += lblDadosdaetapa_Enter;
            // 
            // grbListadeEtapas
            // 
            grbListadeEtapas.Controls.Add(dgvListadeetapa);
            grbListadeEtapas.Location = new Point(32, 232);
            grbListadeEtapas.Name = "grbListadeEtapas";
            grbListadeEtapas.Size = new Size(736, 212);
            grbListadeEtapas.TabIndex = 1;
            grbListadeEtapas.TabStop = false;
            grbListadeEtapas.Text = "Lista de Etapas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(592, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 23);
            textBox3.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(288, 184);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 32);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCnacelar
            // 
            btnCnacelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnacelar.ImageIndex = 0;
            btnCnacelar.ImageList = imageList1;
            btnCnacelar.Location = new Point(368, 184);
            btnCnacelar.Name = "btnCnacelar";
            btnCnacelar.Size = new Size(80, 32);
            btnCnacelar.TabIndex = 10;
            btnCnacelar.Text = "Cancelar";
            btnCnacelar.TextAlign = ContentAlignment.MiddleRight;
            btnCnacelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(208, 184);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(120, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnnovo
            // 
            btnnovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnnovo.ImageIndex = 3;
            btnnovo.ImageList = imageList1;
            btnnovo.Location = new Point(32, 184);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 32);
            btnnovo.TabIndex = 9;
            btnnovo.Text = "Novo";
            btnnovo.TextAlign = ContentAlignment.MiddleRight;
            btnnovo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(672, 192);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 23);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 18;
            label3.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(504, 192);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(184, 23);
            txtPesquisar.TabIndex = 16;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 22;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome";
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(16, 80);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 24;
            lblOrdem.Text = "Ordem";
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
            // dgvListadeetapa
            // 
            dgvListadeetapa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeetapa.Location = new Point(0, 16);
            dgvListadeetapa.Name = "dgvListadeetapa";
            dgvListadeetapa.Size = new Size(736, 192);
            dgvListadeetapa.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbInativo);
            panel1.Controls.Add(btAtivo);
            panel1.Location = new Point(296, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 24);
            panel1.TabIndex = 25;
            // 
            // lblSituação
            // 
            lblSituação.AutoSize = true;
            lblSituação.Location = new Point(296, 80);
            lblSituação.Name = "lblSituação";
            lblSituação.Size = new Size(52, 15);
            lblSituação.TabIndex = 23;
            lblSituação.Text = "Situação";
            lblSituação.Click += lblSituação_Click;
            // 
            // rbInativo
            // 
            rbInativo.AutoSize = true;
            rbInativo.Location = new Point(59, 3);
            rbInativo.Name = "rbInativo";
            rbInativo.Size = new Size(61, 19);
            rbInativo.TabIndex = 22;
            rbInativo.TabStop = true;
            rbInativo.Text = "Inativo";
            rbInativo.UseVisualStyleBackColor = true;
            rbInativo.CheckedChanged += rbInativo_CheckedChanged;
            // 
            // btAtivo
            // 
            btAtivo.AutoSize = true;
            btAtivo.Location = new Point(3, 2);
            btAtivo.Name = "btAtivo";
            btAtivo.Size = new Size(53, 19);
            btAtivo.TabIndex = 21;
            btAtivo.TabStop = true;
            btAtivo.Text = "Ativo";
            btAtivo.UseVisualStyleBackColor = true;
            btAtivo.CheckedChanged += btAtivo_CheckedChanged;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesquisar);
            Controls.Add(label3);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCnacelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnnovo);
            Controls.Add(grbListadeEtapas);
            Controls.Add(grbDadosdaetapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            grbDadosdaetapa.ResumeLayout(false);
            grbDadosdaetapa.PerformLayout();
            grbListadeEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadeetapa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosdaetapa;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox grbListadeEtapas;
        private Button btnExcluir;
        private Button btnCnacelar;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnnovo;
        private Button btnPesquisar;
        private Label label3;
        private TextBox txtPesquisar;
        private Label lblCodigo;
        private Label lblOrdem;
        private Label lblNome;
        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvListadeetapa;
        private Panel panel1;
        private Label lblSituação;
        private RadioButton rbInativo;
        private RadioButton btAtivo;
    }
}