namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnFechar = new Button();
            btnEntrar = new Button();
            txtsenha = new TextBox();
            txtusuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtsenha);
            panel2.Controls.Add(txtusuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(303, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 450);
            panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Arial Black", 20F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(418, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(67, 62);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial Black", 20F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(54, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(354, 88);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtsenha
            // 
            txtsenha.BackColor = Color.Black;
            txtsenha.BorderStyle = BorderStyle.None;
            txtsenha.Font = new Font("Arial Black", 18F);
            txtsenha.ForeColor = Color.White;
            txtsenha.Location = new Point(64, 189);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(314, 51);
            txtsenha.TabIndex = 0;
            txtsenha.Text = "Senha";
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.Black;
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.Font = new Font("Arial Black", 18F);
            txtusuario.ForeColor = Color.White;
            txtusuario.Location = new Point(54, 76);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(324, 51);
            txtusuario.TabIndex = 0;
            txtusuario.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 218);
            label2.Name = "label2";
            label2.Size = new Size(324, 32);
            label2.TabIndex = 1;
            label2.Text = "_______________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 108);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 1;
            label1.Text = "_______________________________";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtsenha;
        private Label label2;
        private Label label1;
        private Button btnEntrar;
        private TextBox txtusuario;
        private Button btnFechar;
    }
}
