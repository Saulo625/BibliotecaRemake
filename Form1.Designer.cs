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
            this.tcEmprestimos = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.btnFuncionarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEmprestimos = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnUsuarios = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpEmprestimos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tpEmprestando = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.tpEmprestar = new System.Windows.Forms.TabPage();
            this.tpDevolver = new System.Windows.Forms.TabPage();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcEmprestimos.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.tpEmprestimos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpEmprestando.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEmprestimos
            // 
            this.tcEmprestimos.Controls.Add(this.tpTelaPrincipal);
            this.tcEmprestimos.Controls.Add(this.tpLivros);
            this.tcEmprestimos.Controls.Add(this.tpUsuarios);
            this.tcEmprestimos.Controls.Add(this.tpEmprestimos);
            this.tcEmprestimos.Controls.Add(this.tpFuncionarios);
            this.tcEmprestimos.Controls.Add(this.tabPage1);
            this.tcEmprestimos.Depth = 0;
            this.tcEmprestimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmprestimos.Location = new System.Drawing.Point(0, 0);
            this.tcEmprestimos.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcEmprestimos.Name = "tcEmprestimos";
            this.tcEmprestimos.SelectedIndex = 0;
            this.tcEmprestimos.Size = new System.Drawing.Size(800, 450);
            this.tcEmprestimos.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.tpTelaPrincipal.Controls.Add(this.btnFuncionarios);
            this.tpTelaPrincipal.Controls.Add(this.btnEmprestimos);
            this.tpTelaPrincipal.Controls.Add(this.btnUsuarios);
            this.tpTelaPrincipal.Controls.Add(this.btnLivros);
            this.tpTelaPrincipal.Controls.Add(this.siticoneCircleButton1);
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
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 193);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(180, 45);
            this.btnFuncionarios.TabIndex = 5;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
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
            this.btnEmprestimos.Location = new System.Drawing.Point(0, 131);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(180, 45);
            this.btnEmprestimos.TabIndex = 4;
            this.btnEmprestimos.Text = "Emprestimos";
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
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
            this.btnUsuarios.Location = new System.Drawing.Point(0, 66);
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
            this.btnLivros.Location = new System.Drawing.Point(0, 0);
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
            this.tpEmprestimos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tpEmprestimos.Controls.Add(this.tableLayoutPanel1);
            this.tpEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestimos.Name = "tpEmprestimos";
            this.tpEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimos.Size = new System.Drawing.Size(792, 424);
            this.tpEmprestimos.TabIndex = 4;
            this.tpEmprestimos.Text = "Emprestimos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tpEmprestando, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.28708F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.71292F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tpEmprestando
            // 
            this.tpEmprestando.Controls.Add(this.tpPrincipal);
            this.tpEmprestando.Controls.Add(this.tpEmprestar);
            this.tpEmprestando.Controls.Add(this.tpDevolver);
            this.tpEmprestando.Controls.Add(this.tpConsulta);
            this.tpEmprestando.Depth = 0;
            this.tpEmprestando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpEmprestando.Location = new System.Drawing.Point(3, 45);
            this.tpEmprestando.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpEmprestando.Name = "tpEmprestando";
            this.tpEmprestando.SelectedIndex = 0;
            this.tpEmprestando.Size = new System.Drawing.Size(780, 370);
            this.tpEmprestando.TabIndex = 2;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(772, 344);
            this.tpPrincipal.TabIndex = 1;
            this.tpPrincipal.Text = "Principal";
            // 
            // tpEmprestar
            // 
            this.tpEmprestar.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestar.Name = "tpEmprestar";
            this.tpEmprestar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestar.Size = new System.Drawing.Size(772, 344);
            this.tpEmprestar.TabIndex = 2;
            this.tpEmprestar.Text = "Emprestar";
            this.tpEmprestar.UseVisualStyleBackColor = true;
           
            // 
            // tpDevolver
            // 
            this.tpDevolver.Location = new System.Drawing.Point(4, 22);
            this.tpDevolver.Name = "tpDevolver";
            this.tpDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolver.Size = new System.Drawing.Size(772, 344);
            this.tpDevolver.TabIndex = 3;
            this.tpDevolver.Text = "Devolver";
            this.tpDevolver.UseVisualStyleBackColor = true;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(772, 344);
            this.tpConsulta.TabIndex = 4;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnDevolver, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmprestar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConsultar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelecionar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 36);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Gray;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Location = new System.Drawing.Point(588, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(189, 30);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.Gray;
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestar.Location = new System.Drawing.Point(393, 3);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(189, 30);
            this.btnEmprestar.TabIndex = 2;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(198, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(189, 30);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Gray;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Location = new System.Drawing.Point(3, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(189, 30);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcEmprestimos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcEmprestimos.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.tpEmprestimos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tpEmprestando.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcEmprestimos;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private System.Windows.Forms.TabPage tpLivros;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEmprestimos;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuarios;
        private System.Windows.Forms.TabPage tpUsuarios;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionarios;
        private System.Windows.Forms.TabPage tpEmprestimos;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private MaterialSkin.Controls.MaterialTabControl tpEmprestando;
        private System.Windows.Forms.TabPage tpPrincipal;
        private System.Windows.Forms.TabPage tpEmprestar;
        private System.Windows.Forms.TabPage tpDevolver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TabPage tpConsulta;
    }
}