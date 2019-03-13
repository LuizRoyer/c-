namespace SelecaoDeJogador
{
    partial class TabelaJogador
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvJogador = new System.Windows.Forms.DataGridView();
            this.btnNovoJogador = new System.Windows.Forms.Button();
            this.blnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.novoJogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaJogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoJogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaJogadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvJogador);
            this.splitContainer1.Size = new System.Drawing.Size(484, 237);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvJogador
            // 
            this.dgvJogador.AllowUserToAddRows = false;
            this.dgvJogador.AllowUserToDeleteRows = false;
            this.dgvJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJogador.Location = new System.Drawing.Point(0, 0);
            this.dgvJogador.Name = "dgvJogador";
            this.dgvJogador.ReadOnly = true;
            this.dgvJogador.Size = new System.Drawing.Size(484, 237);
            this.dgvJogador.TabIndex = 0;
            this.dgvJogador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogador_CellContentClick);
            // 
            // btnNovoJogador
            // 
            this.btnNovoJogador.Location = new System.Drawing.Point(12, 256);
            this.btnNovoJogador.Name = "btnNovoJogador";
            this.btnNovoJogador.Size = new System.Drawing.Size(75, 23);
            this.btnNovoJogador.TabIndex = 1;
            this.btnNovoJogador.Text = "Novo";
            this.btnNovoJogador.UseVisualStyleBackColor = true;
            this.btnNovoJogador.Click += new System.EventHandler(this.btnNovoJogador_Click);
            // 
            // blnEditar
            // 
            this.blnEditar.Location = new System.Drawing.Point(133, 256);
            this.blnEditar.Name = "blnEditar";
            this.blnEditar.Size = new System.Drawing.Size(75, 23);
            this.blnEditar.TabIndex = 2;
            this.blnEditar.Text = "Alterar";
            this.blnEditar.UseVisualStyleBackColor = true;
            this.blnEditar.Click += new System.EventHandler(this.blnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(257, 256);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // novoJogadorBindingSource
            // 
            this.novoJogadorBindingSource.DataSource = typeof(SelecaoDeJogador.NovoJogador);
            // 
            // tabelaJogadorBindingSource
            // 
            this.tabelaJogadorBindingSource.DataSource = typeof(SelecaoDeJogador.TabelaJogador);
            // 
            // TabelaJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 306);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.blnEditar);
            this.Controls.Add(this.btnNovoJogador);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TabelaJogador";
            this.Text = "Tabela de Jogadores";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoJogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaJogadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvJogador;
        private System.Windows.Forms.Button btnNovoJogador;
        private System.Windows.Forms.Button blnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.BindingSource novoJogadorBindingSource;
        private System.Windows.Forms.BindingSource tabelaJogadorBindingSource;
    }
}