namespace BibliotecaRemake
{
    partial class Form1
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
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.btnFuncionarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEmprestimos = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnUsuarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpEmprestimos = new System.Windows.Forms.TabPage();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.tpTelaPrincipal);
            this.tcControle.Controls.Add(this.tpLivros);
            this.tcControle.Controls.Add(this.tpUsuarios);
            this.tcControle.Controls.Add(this.tpEmprestimos);
            this.tcControle.Controls.Add(this.tpFuncionarios);
            this.tcControle.Depth = 0;
            this.tcControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControle.Location = new System.Drawing.Point(0, 0);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(800, 450);
            this.tcControle.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.tpTelaPrincipal.Controls.Add(this.btnFuncionarios);
            this.tpTelaPrincipal.Controls.Add(this.btnEmprestimos);
            this.tpTelaPrincipal.Controls.Add(this.btnUsuarios);
            this.tpTelaPrincipal.Controls.Add(this.btnLivros);
            this.tpTelaPrincipal.Controls.Add(this.siticoneCircleButton1);
            this.tpTelaPrincipal.Controls.Add(this.btnErro);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(792, 424);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.DimGray;
            this.btnFuncionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionarios.FillColor = System.Drawing.Color.Gray;
            this.btnFuncionarios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 255);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(180, 45);
            this.btnFuncionarios.TabIndex = 5;
            this.btnFuncionarios.Text = "Funcionarios";
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.DimGray;
            this.btnEmprestimos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmprestimos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmprestimos.FillColor = System.Drawing.Color.Gray;
            this.btnEmprestimos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(0, 193);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(180, 45);
            this.btnEmprestimos.TabIndex = 4;
            this.btnEmprestimos.Text = "Emprestimos";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DimGray;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 128);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 45);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.DimGray;
            this.btnLivros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLivros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLivros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLivros.FillColor = System.Drawing.Color.Gray;
            this.btnLivros.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(0, 62);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(180, 45);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.Text = "Livros";
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.BackColor = System.Drawing.Color.DimGray;
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.Gray;
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(644, 0);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(148, 148);
            this.siticoneCircleButton1.TabIndex = 1;
            this.siticoneCircleButton1.Text = "🏠Home";
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.Color.DimGray;
            this.btnErro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnErro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnErro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnErro.FillColor = System.Drawing.Color.Gray;
            this.btnErro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.ForeColor = System.Drawing.Color.White;
            this.btnErro.Location = new System.Drawing.Point(0, 0);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(180, 45);
            this.btnErro.TabIndex = 0;
            this.btnErro.Text = "Erro";
     
            // 
            // tpLivros
            // 
            this.tpLivros.Location = new System.Drawing.Point(4, 22);
            this.tpLivros.Name = "tpLivros";
            this.tpLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivros.Size = new System.Drawing.Size(792, 424);
            this.tpLivros.TabIndex = 2;
            this.tpLivros.Text = "Livros";
            this.tpLivros.UseVisualStyleBackColor = true;
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(792, 424);
            this.tpUsuarios.TabIndex = 3;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // tpEmprestimos
            // 
            this.tpEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestimos.Name = "tpEmprestimos";
            this.tpEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimos.Size = new System.Drawing.Size(792, 424);
            this.tpEmprestimos.TabIndex = 4;
            this.tpEmprestimos.Text = "Emprestimos";
            this.tpEmprestimos.UseVisualStyleBackColor = true;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionarios.Size = new System.Drawing.Size(792, 424);
            this.tpFuncionarios.TabIndex = 5;
            this.tpFuncionarios.Text = "Funcionarios";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcControle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcControle.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private System.Windows.Forms.TabPage tpLivros;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEmprestimos;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuarios;
        private System.Windows.Forms.TabPage tpUsuarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionarios;
        private System.Windows.Forms.TabPage tpEmprestimos;
        private System.Windows.Forms.TabPage tpFuncionarios;
    }
}