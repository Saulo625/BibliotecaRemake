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
            this.btnErro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpErro = new System.Windows.Forms.TabPage();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnLivros = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tpLivros = new System.Windows.Forms.TabPage();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.tpTelaPrincipal);
            this.tcControle.Controls.Add(this.tpErro);
            this.tcControle.Controls.Add(this.tpLivros);
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
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // tpErro
            // 
            this.tpErro.Location = new System.Drawing.Point(4, 22);
            this.tpErro.Name = "tpErro";
            this.tpErro.Padding = new System.Windows.Forms.Padding(3);
            this.tpErro.Size = new System.Drawing.Size(792, 424);
            this.tpErro.TabIndex = 1;
            this.tpErro.Text = "Erro";
            this.tpErro.UseVisualStyleBackColor = true;
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
            this.siticoneCircleButton1.Text = "🏠Home🏠";
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
        private System.Windows.Forms.TabPage tpErro;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnErro;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivros;
        private System.Windows.Forms.TabPage tpLivros;
    }
}