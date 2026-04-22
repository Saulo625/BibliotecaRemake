namespace BibliotecaRemake
{
    partial class Funcionarios
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbofuncionarios = new System.Windows.Forms.ListBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(11, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 34);
            this.btnVoltar.TabIndex = 110;
            this.btnVoltar.Text = "🏠Home";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Gray;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(30, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 109;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.Gray;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Location = new System.Drawing.Point(30, 160);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(315, 20);
            this.txtCargo.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(30, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 20);
            this.txtEmail.TabIndex = 107;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(381, 429);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(357, 36);
            this.btnLimpar.TabIndex = 106;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAcoes
            // 
            this.btnAcoes.BackColor = System.Drawing.Color.Gray;
            this.btnAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcoes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoes.Location = new System.Drawing.Point(185, 429);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(137, 36);
            this.btnAcoes.TabIndex = 105;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = false;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.BackColor = System.Drawing.Color.Gray;
            this.btnAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuste.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuste.Location = new System.Drawing.Point(30, 429);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(137, 36);
            this.btnAjuste.TabIndex = 104;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = false;
            this.btnAjuste.Click += new System.EventHandler(this.btnAJuste_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(26, 205);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 102;
            this.materialLabel3.Text = "Email:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 101;
            this.materialLabel2.Text = "Cargo:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 100;
            this.materialLabel1.Text = "Nome Completo:";
            // 
            // lbofuncionarios
            // 
            this.lbofuncionarios.BackColor = System.Drawing.Color.Gray;
            this.lbofuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbofuncionarios.FormattingEnabled = true;
            this.lbofuncionarios.Location = new System.Drawing.Point(381, 94);
            this.lbofuncionarios.Name = "lbofuncionarios";
            this.lbofuncionarios.Size = new System.Drawing.Size(357, 301);
            this.lbofuncionarios.TabIndex = 99;
            this.lbofuncionarios.SelectedIndexChanged += new System.EventHandler(this.lbofuncionarios_SelectedIndexChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Gray;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(30, 284);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(315, 20);
            this.txtSenha.TabIndex = 114;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(28, 262);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(54, 19);
            this.materialLabel5.TabIndex = 111;
            this.materialLabel5.Text = "Senha:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(377, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(160, 19);
            this.materialLabel4.TabIndex = 116;
            this.materialLabel4.Text = "Pesquisar funcionario:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.Gray;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(381, 50);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(357, 20);
            this.txtPesquisar.TabIndex = 115;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbofuncionarios);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(768, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjuste;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox lbofuncionarios;
        private System.Windows.Forms.TextBox txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}
