namespace Projeto_Banco
{
    partial class Frm_Banco
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
            this.Lbl_Agência = new System.Windows.Forms.Label();
            this.Lbl_NdaConta = new System.Windows.Forms.Label();
            this.Lbl_TitularDaConta = new System.Windows.Forms.Label();
            this.Txt_Agencia = new System.Windows.Forms.TextBox();
            this.Txt_NdaConta = new System.Windows.Forms.TextBox();
            this.Txt_TitularDaConta = new System.Windows.Forms.TextBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Btn_Saque = new System.Windows.Forms.Button();
            this.Btn_Deposito = new System.Windows.Forms.Button();
            this.Lbl_SaldoDisponivel = new System.Windows.Forms.Label();
            this.Txt_SaldoDisponivel = new System.Windows.Forms.TextBox();
            this.Btn_X = new System.Windows.Forms.Button();
            this.Lbl_Saque = new System.Windows.Forms.Label();
            this.Lbl_Deposito = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Bank = new System.Windows.Forms.Label();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_Mes = new System.Windows.Forms.TextBox();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Agência
            // 
            this.Lbl_Agência.AutoSize = true;
            this.Lbl_Agência.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Agência.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Agência.ForeColor = System.Drawing.Color.White;
            this.Lbl_Agência.Location = new System.Drawing.Point(50, 80);
            this.Lbl_Agência.Name = "Lbl_Agência";
            this.Lbl_Agência.Size = new System.Drawing.Size(74, 18);
            this.Lbl_Agência.TabIndex = 0;
            this.Lbl_Agência.Text = "Agência";
            // 
            // Lbl_NdaConta
            // 
            this.Lbl_NdaConta.AutoSize = true;
            this.Lbl_NdaConta.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NdaConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NdaConta.ForeColor = System.Drawing.Color.White;
            this.Lbl_NdaConta.Location = new System.Drawing.Point(50, 151);
            this.Lbl_NdaConta.Name = "Lbl_NdaConta";
            this.Lbl_NdaConta.Size = new System.Drawing.Size(102, 18);
            this.Lbl_NdaConta.TabIndex = 1;
            this.Lbl_NdaConta.Text = "Nº da Conta";
            // 
            // Lbl_TitularDaConta
            // 
            this.Lbl_TitularDaConta.AutoSize = true;
            this.Lbl_TitularDaConta.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TitularDaConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitularDaConta.ForeColor = System.Drawing.Color.White;
            this.Lbl_TitularDaConta.Location = new System.Drawing.Point(588, 80);
            this.Lbl_TitularDaConta.Name = "Lbl_TitularDaConta";
            this.Lbl_TitularDaConta.Size = new System.Drawing.Size(135, 18);
            this.Lbl_TitularDaConta.TabIndex = 2;
            this.Lbl_TitularDaConta.Text = "Titular da Conta";
            // 
            // Txt_Agencia
            // 
            this.Txt_Agencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Agencia.ForeColor = System.Drawing.Color.Black;
            this.Txt_Agencia.Location = new System.Drawing.Point(53, 101);
            this.Txt_Agencia.MaxLength = 4;
            this.Txt_Agencia.Name = "Txt_Agencia";
            this.Txt_Agencia.Size = new System.Drawing.Size(47, 23);
            this.Txt_Agencia.TabIndex = 3;
            this.Txt_Agencia.TabStop = false;
            this.Txt_Agencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Agencia_KeyPress);
            // 
            // Txt_NdaConta
            // 
            this.Txt_NdaConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NdaConta.ForeColor = System.Drawing.Color.Black;
            this.Txt_NdaConta.Location = new System.Drawing.Point(53, 172);
            this.Txt_NdaConta.MaxLength = 5;
            this.Txt_NdaConta.Name = "Txt_NdaConta";
            this.Txt_NdaConta.Size = new System.Drawing.Size(65, 23);
            this.Txt_NdaConta.TabIndex = 4;
            this.Txt_NdaConta.TabStop = false;
            this.Txt_NdaConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NdaConta_KeyPress);
            // 
            // Txt_TitularDaConta
            // 
            this.Txt_TitularDaConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TitularDaConta.ForeColor = System.Drawing.Color.Black;
            this.Txt_TitularDaConta.Location = new System.Drawing.Point(546, 101);
            this.Txt_TitularDaConta.MaxLength = 30;
            this.Txt_TitularDaConta.Name = "Txt_TitularDaConta";
            this.Txt_TitularDaConta.Size = new System.Drawing.Size(232, 23);
            this.Txt_TitularDaConta.TabIndex = 5;
            this.Txt_TitularDaConta.TabStop = false;
            this.Txt_TitularDaConta.TextChanged += new System.EventHandler(this.hcj);
            this.Txt_TitularDaConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TitularDaConta_KeyPress);
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor.ForeColor = System.Drawing.Color.Black;
            this.Txt_Valor.Location = new System.Drawing.Point(53, 315);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(112, 23);
            this.Txt_Valor.TabIndex = 6;
            this.Txt_Valor.TabStop = false;
            this.Txt_Valor.TextChanged += new System.EventHandler(this.Txt_Valor_TextChanged);
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valor_KeyPress);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Valor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.ForeColor = System.Drawing.Color.White;
            this.Lbl_Valor.Location = new System.Drawing.Point(50, 294);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(50, 18);
            this.Lbl_Valor.TabIndex = 7;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Btn_Saque
            // 
            this.Btn_Saque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Saque.FlatAppearance.BorderSize = 2;
            this.Btn_Saque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Saque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Saque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Saque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Saque.ForeColor = System.Drawing.Color.White;
            this.Btn_Saque.Location = new System.Drawing.Point(479, 366);
            this.Btn_Saque.Name = "Btn_Saque";
            this.Btn_Saque.Size = new System.Drawing.Size(86, 33);
            this.Btn_Saque.TabIndex = 8;
            this.Btn_Saque.Text = "Saque";
            this.Btn_Saque.UseVisualStyleBackColor = true;
            this.Btn_Saque.Click += new System.EventHandler(this.Btn_Saque_Click);
            // 
            // Btn_Deposito
            // 
            this.Btn_Deposito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Deposito.FlatAppearance.BorderSize = 2;
            this.Btn_Deposito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Deposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deposito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deposito.ForeColor = System.Drawing.Color.White;
            this.Btn_Deposito.Location = new System.Drawing.Point(650, 366);
            this.Btn_Deposito.Name = "Btn_Deposito";
            this.Btn_Deposito.Size = new System.Drawing.Size(111, 33);
            this.Btn_Deposito.TabIndex = 9;
            this.Btn_Deposito.Text = "Depósito";
            this.Btn_Deposito.UseVisualStyleBackColor = true;
            this.Btn_Deposito.Click += new System.EventHandler(this.Btn_Deposito_Click);
            // 
            // Lbl_SaldoDisponivel
            // 
            this.Lbl_SaldoDisponivel.AutoSize = true;
            this.Lbl_SaldoDisponivel.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_SaldoDisponivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoDisponivel.ForeColor = System.Drawing.Color.White;
            this.Lbl_SaldoDisponivel.Location = new System.Drawing.Point(50, 225);
            this.Lbl_SaldoDisponivel.Name = "Lbl_SaldoDisponivel";
            this.Lbl_SaldoDisponivel.Size = new System.Drawing.Size(139, 18);
            this.Lbl_SaldoDisponivel.TabIndex = 10;
            this.Lbl_SaldoDisponivel.Text = "Saldo Disponível";
            // 
            // Txt_SaldoDisponivel
            // 
            this.Txt_SaldoDisponivel.Enabled = false;
            this.Txt_SaldoDisponivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoDisponivel.ForeColor = System.Drawing.Color.Black;
            this.Txt_SaldoDisponivel.Location = new System.Drawing.Point(53, 246);
            this.Txt_SaldoDisponivel.Name = "Txt_SaldoDisponivel";
            this.Txt_SaldoDisponivel.Size = new System.Drawing.Size(112, 23);
            this.Txt_SaldoDisponivel.TabIndex = 11;
            this.Txt_SaldoDisponivel.TabStop = false;
            // 
            // Btn_X
            // 
            this.Btn_X.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_X.FlatAppearance.BorderSize = 0;
            this.Btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_X.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_X.ForeColor = System.Drawing.Color.White;
            this.Btn_X.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_X.Location = new System.Drawing.Point(780, -4);
            this.Btn_X.Name = "Btn_X";
            this.Btn_X.Size = new System.Drawing.Size(23, 27);
            this.Btn_X.TabIndex = 12;
            this.Btn_X.Text = "X";
            this.Btn_X.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_X.UseVisualStyleBackColor = true;
            this.Btn_X.Click += new System.EventHandler(this.Btn_X_Click);
            // 
            // Lbl_Saque
            // 
            this.Lbl_Saque.AutoSize = true;
            this.Lbl_Saque.ForeColor = System.Drawing.Color.White;
            this.Lbl_Saque.Location = new System.Drawing.Point(514, 406);
            this.Lbl_Saque.Name = "Lbl_Saque";
            this.Lbl_Saque.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Saque.TabIndex = 13;
            this.Lbl_Saque.Text = "0";
            // 
            // Lbl_Deposito
            // 
            this.Lbl_Deposito.AutoSize = true;
            this.Lbl_Deposito.ForeColor = System.Drawing.Color.White;
            this.Lbl_Deposito.Location = new System.Drawing.Point(700, 406);
            this.Lbl_Deposito.Name = "Lbl_Deposito";
            this.Lbl_Deposito.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Deposito.TabIndex = 14;
            this.Lbl_Deposito.Text = "0";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Black;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(240, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(202, 24);
            this.Lbl_Titulo.TabIndex = 15;
            this.Lbl_Titulo.Text = "TODO PODEROSO";
            // 
            // Lbl_Bank
            // 
            this.Lbl_Bank.AutoSize = true;
            this.Lbl_Bank.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bank.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bank.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bank.Location = new System.Drawing.Point(436, 15);
            this.Lbl_Bank.Name = "Lbl_Bank";
            this.Lbl_Bank.Size = new System.Drawing.Size(49, 18);
            this.Lbl_Bank.TabIndex = 16;
            this.Lbl_Bank.Text = "Bank";
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Idade.Location = new System.Drawing.Point(591, 183);
            this.Txt_Idade.MaxLength = 3;
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(40, 23);
            this.Txt_Idade.TabIndex = 17;
            this.Txt_Idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Idade_KeyPress);
            // 
            // Txt_Mes
            // 
            this.Txt_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mes.Location = new System.Drawing.Point(703, 183);
            this.Txt_Mes.MaxLength = 2;
            this.Txt_Mes.Name = "Txt_Mes";
            this.Txt_Mes.Size = new System.Drawing.Size(33, 23);
            this.Txt_Mes.TabIndex = 18;
            this.Txt_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Mes_KeyPress);
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Idade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Idade.Location = new System.Drawing.Point(588, 162);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(53, 18);
            this.Lbl_Idade.TabIndex = 19;
            this.Lbl_Idade.Text = "Idade";
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.ForeColor = System.Drawing.Color.White;
            this.Lbl_Mes.Location = new System.Drawing.Point(674, 143);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(104, 37);
            this.Lbl_Mes.TabIndex = 20;
            this.Lbl_Mes.Text = "Mês  Nascimento";
            this.Lbl_Mes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Mes.Click += new System.EventHandler(this.Lbl_Mes_Click);
            // 
            // Frm_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Projeto_Banco.Properties.Resources.Timao__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.Txt_Mes);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Lbl_Bank);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lbl_Deposito);
            this.Controls.Add(this.Lbl_Saque);
            this.Controls.Add(this.Btn_X);
            this.Controls.Add(this.Txt_SaldoDisponivel);
            this.Controls.Add(this.Lbl_SaldoDisponivel);
            this.Controls.Add(this.Btn_Deposito);
            this.Controls.Add(this.Btn_Saque);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Txt_TitularDaConta);
            this.Controls.Add(this.Txt_NdaConta);
            this.Controls.Add(this.Txt_Agencia);
            this.Controls.Add(this.Lbl_TitularDaConta);
            this.Controls.Add(this.Lbl_NdaConta);
            this.Controls.Add(this.Lbl_Agência);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancaria";
            this.Load += new System.EventHandler(this.Frm_Banco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Agência;
        private System.Windows.Forms.Label Lbl_NdaConta;
        private System.Windows.Forms.Label Lbl_TitularDaConta;
        private System.Windows.Forms.TextBox Txt_Agencia;
        private System.Windows.Forms.TextBox Txt_NdaConta;
        private System.Windows.Forms.TextBox Txt_TitularDaConta;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Button Btn_Saque;
        private System.Windows.Forms.Button Btn_Deposito;
        private System.Windows.Forms.Label Lbl_SaldoDisponivel;
        private System.Windows.Forms.TextBox Txt_SaldoDisponivel;
        private System.Windows.Forms.Button Btn_X;
        private System.Windows.Forms.Label Lbl_Saque;
        private System.Windows.Forms.Label Lbl_Deposito;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Bank;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_Mes;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Label Lbl_Mes;
    }
}

