namespace AcademiaListaEx11
{
    partial class Questao1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.button_inserir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_listarNomes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(108, 9);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(478, 23);
            this.textBox_nomeCompleto.TabIndex = 1;
            this.textBox_nomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeCompleto_KeyPress);
            // 
            // button_inserir
            // 
            this.button_inserir.Location = new System.Drawing.Point(592, 9);
            this.button_inserir.Name = "button_inserir";
            this.button_inserir.Size = new System.Drawing.Size(75, 23);
            this.button_inserir.TabIndex = 2;
            this.button_inserir.Text = "inserir";
            this.button_inserir.UseVisualStyleBackColor = true;
            this.button_inserir.Click += new System.EventHandler(this.button_inserir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_listarNomes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_inserir);
            this.panel1.Controls.Add(this.textBox_nomeCompleto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 3;
            // 
            // textBox_listarNomes
            // 
            this.textBox_listarNomes.Location = new System.Drawing.Point(108, 53);
            this.textBox_listarNomes.Multiline = true;
            this.textBox_listarNomes.Name = "textBox_listarNomes";
            this.textBox_listarNomes.ReadOnly = true;
            this.textBox_listarNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listarNomes.Size = new System.Drawing.Size(478, 352);
            this.textBox_listarNomes.TabIndex = 3;
            // 
            // Questao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Questao1";
            this.Text = "Questão 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeCompleto;
        private Button button_inserir;
        private Panel panel1;
        private TextBox textBox_listarNomes;
    }
}