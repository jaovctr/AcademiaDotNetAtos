namespace AcademiaListaEx11
{
    partial class Questao3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_addCripto = new System.Windows.Forms.Button();
            this.textBox_adcsigla = new System.Windows.Forms.TextBox();
            this.textBox_adcvalor = new System.Windows.Forms.TextBox();
            this.textBox_adcnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_exibir = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_removerCripto = new System.Windows.Forms.Button();
            this.textBox_remover = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserir Criptomoeda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Criptomoedas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remover Criptomoeda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_addCripto);
            this.panel1.Controls.Add(this.textBox_adcsigla);
            this.panel1.Controls.Add(this.textBox_adcvalor);
            this.panel1.Controls.Add(this.textBox_adcnome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 135);
            this.panel1.TabIndex = 3;
            // 
            // button_addCripto
            // 
            this.button_addCripto.Location = new System.Drawing.Point(5, 89);
            this.button_addCripto.Name = "button_addCripto";
            this.button_addCripto.Size = new System.Drawing.Size(191, 23);
            this.button_addCripto.TabIndex = 4;
            this.button_addCripto.Text = "Adicionar criptomoeda";
            this.button_addCripto.UseVisualStyleBackColor = true;
            this.button_addCripto.Click += new System.EventHandler(this.button_addCripto_Click);
            // 
            // textBox_adcsigla
            // 
            this.textBox_adcsigla.Location = new System.Drawing.Point(71, 6);
            this.textBox_adcsigla.Name = "textBox_adcsigla";
            this.textBox_adcsigla.Size = new System.Drawing.Size(125, 23);
            this.textBox_adcsigla.TabIndex = 1;
            // 
            // textBox_adcvalor
            // 
            this.textBox_adcvalor.Location = new System.Drawing.Point(71, 60);
            this.textBox_adcvalor.Name = "textBox_adcvalor";
            this.textBox_adcvalor.Size = new System.Drawing.Size(125, 23);
            this.textBox_adcvalor.TabIndex = 3;
            // 
            // textBox_adcnome
            // 
            this.textBox_adcnome.Location = new System.Drawing.Point(71, 34);
            this.textBox_adcnome.Name = "textBox_adcnome";
            this.textBox_adcnome.Size = new System.Drawing.Size(125, 23);
            this.textBox_adcnome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor unit.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView_exibir);
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 243);
            this.panel2.TabIndex = 4;
            // 
            // listView_exibir
            // 
            this.listView_exibir.Location = new System.Drawing.Point(3, 3);
            this.listView_exibir.Name = "listView_exibir";
            this.listView_exibir.Size = new System.Drawing.Size(766, 237);
            this.listView_exibir.TabIndex = 0;
            this.listView_exibir.UseCompatibleStateImageBehavior = false;
            this.listView_exibir.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_removerCripto);
            this.panel3.Controls.Add(this.textBox_remover);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(413, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 135);
            this.panel3.TabIndex = 5;
            // 
            // button_removerCripto
            // 
            this.button_removerCripto.Location = new System.Drawing.Point(3, 34);
            this.button_removerCripto.Name = "button_removerCripto";
            this.button_removerCripto.Size = new System.Drawing.Size(138, 23);
            this.button_removerCripto.TabIndex = 6;
            this.button_removerCripto.Text = "Remover criptomoeda";
            this.button_removerCripto.UseVisualStyleBackColor = true;
            this.button_removerCripto.Click += new System.EventHandler(this.button_removerCripto_Click);
            // 
            // textBox_remover
            // 
            this.textBox_remover.Location = new System.Drawing.Point(41, 3);
            this.textBox_remover.Name = "textBox_remover";
            this.textBox_remover.Size = new System.Drawing.Size(100, 23);
            this.textBox_remover.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Sigla";
            // 
            // Questao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Questao3";
            this.Text = "Questao3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox_adcsigla;
        private TextBox textBox_adcvalor;
        private TextBox textBox_adcnome;
        private Label label6;
        private Label label5;
        private Label label4;       
        private Button button_addCripto;
        private Button button_removerCripto;
        private TextBox textBox_remover;
        private Label label14;
        private ListView listView_exibir;
    }
}