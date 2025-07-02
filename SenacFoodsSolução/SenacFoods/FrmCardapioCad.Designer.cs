
namespace SenacFoods
{
    partial class FrmCardapioCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardapioCad));
            label1 = new Label();
            txtvalor = new TextBox();
            label2 = new Label();
            txtdescricao = new TextBox();
            label3 = new Label();
            txtTitulo = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            btnFechar = new Button();
            label4 = new Label();
            label5 = new Label();
            chkPossuiPreparo = new CheckBox();
            btnsalvar = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button5 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 423);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 10;
            label1.Text = "VALOR";
            label1.Click += label1_Click;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(68, 451);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(192, 31);
            txtvalor.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 257);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 12;
            label2.Text = "DESCRIÇÃO";
            label2.Click += label2_Click;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(68, 285);
            txtdescricao.Multiline = true;
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(402, 129);
            txtdescricao.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(68, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 14;
            label3.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(68, 223);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(402, 31);
            txtTitulo.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 89);
            panel1.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Black", 20F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1013, 12);
            button4.Name = "button4";
            button4.Size = new Size(92, 71);
            button4.TabIndex = 6;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Arial Black", 20F);
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(1123, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(67, 62);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(358, 45);
            label4.TabIndex = 3;
            label4.Text = "Cadastro de Cardápio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(34, 117);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 16;
            label5.Text = "Cardapio";
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(68, 500);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(168, 29);
            chkPossuiPreparo.TabIndex = 17;
            chkPossuiPreparo.Text = "Possui Preparo ?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.LimeGreen;
            btnsalvar.Location = new Point(983, 500);
            btnsalvar.Margin = new Padding(4, 5, 4, 5);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(168, 52);
            btnsalvar.TabIndex = 19;
            btnsalvar.Text = "# Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(807, 500);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(168, 52);
            button1.TabIndex = 18;
            button1.Text = "X Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1206, 89);
            panel2.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Black", 20F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(1013, 12);
            button3.Name = "button3";
            button3.Size = new Size(92, 71);
            button3.TabIndex = 6;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.White;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Black", 20F);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(1123, 12);
            button5.Name = "button5";
            button5.Size = new Size(67, 62);
            button5.TabIndex = 5;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(358, 45);
            label6.TabIndex = 3;
            label6.Text = "Cadastro de Cardápio";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 562);
            Controls.Add(btnsalvar);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(chkPossuiPreparo);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtdescricao);
            Controls.Add(label1);
            Controls.Add(txtvalor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private TextBox txtvalor;
        private Label label2;
        private TextBox txtdescricao;
        private Label label3;
        private TextBox txtTitulo;
        private Panel panel1;
        private Button button4;
        private Button btnFechar;
        private Label label4;
        private Label label5;
        private CheckBox chkPossuiPreparo;
        private Button btnsalvar;
        private Button button1;
        private Panel panel2;
        private Button button3;
        private Button button5;
        private Label label6;
    }
}