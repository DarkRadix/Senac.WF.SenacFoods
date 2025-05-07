namespace SenacFoods
{
    partial class FrmPrincipal
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
            groupBox1 = new GroupBox();
            btnUsuarios = new Button();
            btnPedido = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            lblMensagem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnPedido);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(48, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(255, 128, 128);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.Font = new Font("Segoe UI", 12F);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(714, 63);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(136, 124);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(128, 128, 255);
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(483, 63);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(136, 124);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.FromArgb(128, 255, 128);
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.Font = new Font("Segoe UI", 12F);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(255, 63);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(136, 124);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += button2_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(255, 255, 128);
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.Font = new Font("Segoe UI", 12F);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(40, 63);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(136, 124);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Arial Black", 20F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(930, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(67, 62);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Arial Black", 20F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(857, 10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(67, 62);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 20F);
            lblMensagem.ForeColor = SystemColors.ButtonFace;
            lblMensagem.Location = new Point(260, 37);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(263, 54);
            lblMensagem.TabIndex = 4;
            lblMensagem.Text = "lblMensagem";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1031, 454);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnUsuarios;
        private Button btnPedido;
        private Button btnComanda;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblMensagem;
    }
}