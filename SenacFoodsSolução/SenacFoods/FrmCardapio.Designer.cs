namespace SenacFoods
{
    partial class FrmCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardapio));
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnFechar = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(-2, 91);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1206, 589);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(975, 516);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(168, 52);
            button2.TabIndex = 2;
            button2.Text = "# Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(805, 516);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(168, 52);
            button1.TabIndex = 1;
            button1.Text = "X Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 133);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1086, 374);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 25);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(828, 45);
            textBox1.TabIndex = 4;
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
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(52, 59);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(168, 63);
            button3.TabIndex = 3;
            button3.Text = "+ Item";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 89);
            panel1.TabIndex = 6;
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
            button4.Click += button4_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 684);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            Load += FrmCardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnFechar;
        private Button button3;
        private Panel panel1;
        private Button button4;
    }
}