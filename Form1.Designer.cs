namespace AcessHunter
{
    partial class Form1
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
            box_servidor = new TextBox();
            box_bd = new TextBox();
            box_senha = new TextBox();
            box_usuario = new TextBox();
            btn_criaprocs = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_ajuda = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // box_servidor
            // 
            box_servidor.Location = new Point(15, 134);
            box_servidor.Name = "box_servidor";
            box_servidor.Size = new Size(408, 23);
            box_servidor.TabIndex = 0;
            // 
            // box_bd
            // 
            box_bd.Location = new Point(15, 270);
            box_bd.Name = "box_bd";
            box_bd.Size = new Size(408, 23);
            box_bd.TabIndex = 1;
            // 
            // box_senha
            // 
            box_senha.Location = new Point(15, 224);
            box_senha.Name = "box_senha";
            box_senha.Size = new Size(408, 23);
            box_senha.TabIndex = 2;
            // 
            // box_usuario
            // 
            box_usuario.Location = new Point(15, 180);
            box_usuario.Name = "box_usuario";
            box_usuario.Size = new Size(408, 23);
            box_usuario.TabIndex = 3;
            // 
            // btn_criaprocs
            // 
            btn_criaprocs.Location = new Point(52, 367);
            btn_criaprocs.Name = "btn_criaprocs";
            btn_criaprocs.Size = new Size(150, 59);
            btn_criaprocs.TabIndex = 5;
            btn_criaprocs.Text = "Criar Procedures";
            btn_criaprocs.UseVisualStyleBackColor = true;
            btn_criaprocs.Click += btn_criaprocs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AccessHunter.Properties.Resources._1164454;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 49);
            label1.Name = "label1";
            label1.Size = new Size(251, 34);
            label1.TabIndex = 7;
            label1.Text = "ACCESS HUNTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 252);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Banco de dados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 206);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 162);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 116);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Servidor";
            // 
            // btn_ajuda
            // 
            btn_ajuda.Location = new Point(233, 367);
            btn_ajuda.Name = "btn_ajuda";
            btn_ajuda.Size = new Size(150, 59);
            btn_ajuda.TabIndex = 12;
            btn_ajuda.Text = "Ajuda";
            btn_ajuda.UseVisualStyleBackColor = true;
            btn_ajuda.Click += btn_ajuda_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 322);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(408, 23);
            progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 438);
            Controls.Add(progressBar1);
            Controls.Add(btn_ajuda);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_criaprocs);
            Controls.Add(box_usuario);
            Controls.Add(box_senha);
            Controls.Add(box_bd);
            Controls.Add(box_servidor);
            Name = "Form1";
            Text = "AccessHunter - Procedures";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox box_servidor;
        private TextBox box_bd;
        private TextBox box_senha;
        private TextBox box_usuario;
        private Button btn_criaprocs;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_ajuda;
        private ProgressBar progressBar1;
    }
}