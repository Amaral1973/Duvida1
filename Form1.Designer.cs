namespace Duvida1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.dtpRecebido = new System.Windows.Forms.DateTimePicker();
            this.cbPequeno = new System.Windows.Forms.CheckBox();
            this.dgvCarga = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.dtpEnviado = new System.Windows.Forms.DateTimePicker();
            this.cbMedio = new System.Windows.Forms.CheckBox();
            this.cbGrande = new System.Windows.Forms.CheckBox();
            this.lblEnviado = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // dtpRecebido
            // 
            this.dtpRecebido.CustomFormat = "";
            this.dtpRecebido.Location = new System.Drawing.Point(12, 63);
            this.dtpRecebido.Name = "dtpRecebido";
            this.dtpRecebido.Size = new System.Drawing.Size(216, 20);
            this.dtpRecebido.TabIndex = 1;
            // 
            // cbPequeno
            // 
            this.cbPequeno.AutoSize = true;
            this.cbPequeno.Location = new System.Drawing.Point(15, 155);
            this.cbPequeno.Name = "cbPequeno";
            this.cbPequeno.Size = new System.Drawing.Size(69, 17);
            this.cbPequeno.TabIndex = 2;
            this.cbPequeno.Text = "Pequeno";
            this.cbPequeno.UseVisualStyleBackColor = true;
            // 
            // dgvCarga
            // 
            this.dgvCarga.AllowUserToAddRows = false;
            this.dgvCarga.AllowUserToDeleteRows = false;
            this.dgvCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarga.Location = new System.Drawing.Point(12, 178);
            this.dgvCarga.Name = "dgvCarga";
            this.dgvCarga.ReadOnly = true;
            this.dgvCarga.Size = new System.Drawing.Size(401, 150);
            this.dgvCarga.TabIndex = 3;
            this.dgvCarga.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarga_CellClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(153, 22);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Location = new System.Drawing.Point(12, 47);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(70, 13);
            this.lblRecebido.TabIndex = 5;
            this.lblRecebido.Text = "Recebimento";
            // 
            // dtpEnviado
            // 
            this.dtpEnviado.Location = new System.Drawing.Point(12, 110);
            this.dtpEnviado.Name = "dtpEnviado";
            this.dtpEnviado.Size = new System.Drawing.Size(216, 20);
            this.dtpEnviado.TabIndex = 6;
            // 
            // cbMedio
            // 
            this.cbMedio.AutoSize = true;
            this.cbMedio.Location = new System.Drawing.Point(101, 155);
            this.cbMedio.Name = "cbMedio";
            this.cbMedio.Size = new System.Drawing.Size(55, 17);
            this.cbMedio.TabIndex = 7;
            this.cbMedio.Text = "Médio";
            this.cbMedio.UseVisualStyleBackColor = true;
            // 
            // cbGrande
            // 
            this.cbGrande.AutoSize = true;
            this.cbGrande.Location = new System.Drawing.Point(187, 155);
            this.cbGrande.Name = "cbGrande";
            this.cbGrande.Size = new System.Drawing.Size(61, 17);
            this.cbGrande.TabIndex = 8;
            this.cbGrande.Text = "Grande";
            this.cbGrande.UseVisualStyleBackColor = true;
            // 
            // lblEnviado
            // 
            this.lblEnviado.AutoSize = true;
            this.lblEnviado.Location = new System.Drawing.Point(12, 94);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(46, 13);
            this.lblEnviado.TabIndex = 9;
            this.lblEnviado.Text = "Enviado";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 20);
            this.txtId.TabIndex = 10;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(338, 22);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(338, 51);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(338, 80);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(338, 111);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 343);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEnviado);
            this.Controls.Add(this.cbGrande);
            this.Controls.Add(this.cbMedio);
            this.Controls.Add(this.dtpEnviado);
            this.Controls.Add(this.lblRecebido);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.dgvCarga);
            this.Controls.Add(this.cbPequeno);
            this.Controls.Add(this.dtpRecebido);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dúvida - DatePicker e Checkbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dtpRecebido;
        private System.Windows.Forms.CheckBox cbPequeno;
        private System.Windows.Forms.DataGridView dgvCarga;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.DateTimePicker dtpEnviado;
        private System.Windows.Forms.CheckBox cbMedio;
        private System.Windows.Forms.CheckBox cbGrande;
        private System.Windows.Forms.Label lblEnviado;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
    }
}

