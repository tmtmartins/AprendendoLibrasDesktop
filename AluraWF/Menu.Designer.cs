namespace AluraWF {
    partial class frmMenu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_descricao = new System.Windows.Forms.Button();
            this.btn_Alfabeto = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.btnMontarPalavra = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.btnJogoMemoria = new System.Windows.Forms.Button();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1138, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(140, 140);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_descricao
            // 
            this.btn_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btn_descricao.FlatAppearance.BorderSize = 0;
            this.btn_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descricao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btn_descricao.Location = new System.Drawing.Point(253, 254);
            this.btn_descricao.Name = "btn_descricao";
            this.btn_descricao.Size = new System.Drawing.Size(264, 92);
            this.btn_descricao.TabIndex = 2;
            this.btn_descricao.Text = "O que é";
            this.btn_descricao.UseVisualStyleBackColor = false;
            this.btn_descricao.Click += new System.EventHandler(this.btn_descricao_Click);
            // 
            // btn_Alfabeto
            // 
            this.btn_Alfabeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btn_Alfabeto.FlatAppearance.BorderSize = 0;
            this.btn_Alfabeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alfabeto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alfabeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btn_Alfabeto.Location = new System.Drawing.Point(253, 405);
            this.btn_Alfabeto.Name = "btn_Alfabeto";
            this.btn_Alfabeto.Size = new System.Drawing.Size(264, 92);
            this.btn_Alfabeto.TabIndex = 3;
            this.btn_Alfabeto.Text = "Alfabeto";
            this.btn_Alfabeto.UseVisualStyleBackColor = false;
            this.btn_Alfabeto.Click += new System.EventHandler(this.btn_Alfabeto_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btnGerador.FlatAppearance.BorderSize = 0;
            this.btnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnGerador.Location = new System.Drawing.Point(540, 405);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(264, 92);
            this.btnGerador.TabIndex = 4;
            this.btnGerador.Text = "Gerador de Palavras";
            this.btnGerador.UseVisualStyleBackColor = false;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // btnMontarPalavra
            // 
            this.btnMontarPalavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btnMontarPalavra.FlatAppearance.BorderSize = 0;
            this.btnMontarPalavra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontarPalavra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontarPalavra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnMontarPalavra.Location = new System.Drawing.Point(830, 405);
            this.btnMontarPalavra.Name = "btnMontarPalavra";
            this.btnMontarPalavra.Size = new System.Drawing.Size(264, 92);
            this.btnMontarPalavra.TabIndex = 5;
            this.btnMontarPalavra.Text = "Jogo da Forca";
            this.btnMontarPalavra.UseVisualStyleBackColor = false;
            this.btnMontarPalavra.Click += new System.EventHandler(this.btnMontarPalavra_Click);
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btnHistoria.FlatAppearance.BorderSize = 0;
            this.btnHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnHistoria.Location = new System.Drawing.Point(540, 254);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(264, 92);
            this.btnHistoria.TabIndex = 6;
            this.btnHistoria.Text = "História";
            this.btnHistoria.UseVisualStyleBackColor = false;
            this.btnHistoria.Click += new System.EventHandler(this.btnHistoria_Click);
            // 
            // btnJogoMemoria
            // 
            this.btnJogoMemoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.btnJogoMemoria.FlatAppearance.BorderSize = 0;
            this.btnJogoMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogoMemoria.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogoMemoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.btnJogoMemoria.Location = new System.Drawing.Point(830, 254);
            this.btnJogoMemoria.Name = "btnJogoMemoria";
            this.btnJogoMemoria.Size = new System.Drawing.Size(264, 92);
            this.btnJogoMemoria.TabIndex = 7;
            this.btnJogoMemoria.Text = "Jogo da Memória";
            this.btnJogoMemoria.UseVisualStyleBackColor = false;
            this.btnJogoMemoria.Click += new System.EventHandler(this.btnJogoMemoria_Click);
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCreditos.Location = new System.Drawing.Point(483, 547);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(391, 22);
            this.lblCreditos.TabIndex = 8;
            this.lblCreditos.Text = "POR TAMIRES MARTINS E JOAO MARQUES";
            this.lblCreditos.Click += new System.EventHandler(this.lblCreditos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(96)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 696);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.btnJogoMemoria);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.btnMontarPalavra);
            this.Controls.Add(this.btnGerador);
            this.Controls.Add(this.btn_Alfabeto);
            this.Controls.Add(this.btn_descricao);
            this.Controls.Add(this.btnSair);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APRENDENDO LIBRAS";
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_descricao;
        private System.Windows.Forms.Button btn_Alfabeto;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.Button btnMontarPalavra;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.Button btnJogoMemoria;
        private System.Windows.Forms.Label lblCreditos;
    }
}

