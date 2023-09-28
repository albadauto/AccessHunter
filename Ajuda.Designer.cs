namespace AccessHunter
{
    partial class Ajuda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 29);
            label1.TabIndex = 0;
            label1.Text = "Tutorial de Instalação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(371, 45);
            label2.TabIndex = 1;
            label2.Text = "Para iniciar a criação de procedure \r\né necessário que os arquivos de procedure devão estar \r\nem uma pasta SQL na raiz do diretório que está instalado a aplicação ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 281);
            label3.Name = "label3";
            label3.Size = new Size(333, 29);
            label3.TabIndex = 2;
            label3.Text = "Criado por José Adauto";
            // 
            // button1
            // 
            button1.Location = new Point(142, 322);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ajuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 386);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ajuda";
            Text = "Ajuda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}