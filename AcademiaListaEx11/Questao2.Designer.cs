namespace AcademiaListaEx11
{
    partial class Questao2
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
            this.button_adicionarEmail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.listView_email = new System.Windows.Forms.ListView();
            this.columnHeader_email = new System.Windows.Forms.ColumnHeader();
            this.listView_dominio = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_adicionarEmail
            // 
            this.button_adicionarEmail.Location = new System.Drawing.Point(515, 12);
            this.button_adicionarEmail.Name = "button_adicionarEmail";
            this.button_adicionarEmail.Size = new System.Drawing.Size(197, 23);
            this.button_adicionarEmail.TabIndex = 0;
            this.button_adicionarEmail.Text = "Adicionar E-mail";
            this.button_adicionarEmail.UseVisualStyleBackColor = true;
            this.button_adicionarEmail.Click += new System.EventHandler(this.button_adicionarEmail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.button_adicionarEmail);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail: ";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(56, 12);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(453, 23);
            this.textBox_email.TabIndex = 3;
            this.textBox_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_email_KeyPress);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(527, 448);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(197, 23);
            this.button_limpar.TabIndex = 2;
            this.button_limpar.Text = "Limpar listas";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // listView_email
            // 
            this.listView_email.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_email});
            this.listView_email.Location = new System.Drawing.Point(3, 28);
            this.listView_email.Name = "listView_email";
            this.listView_email.Size = new System.Drawing.Size(706, 174);
            this.listView_email.TabIndex = 4;
            this.listView_email.UseCompatibleStateImageBehavior = false;
            this.listView_email.View = System.Windows.Forms.View.List;
            // 
            // listView_dominio
            // 
            this.listView_dominio.Location = new System.Drawing.Point(3, 27);
            this.listView_dominio.Name = "listView_dominio";
            this.listView_dominio.Size = new System.Drawing.Size(493, 163);
            this.listView_dominio.TabIndex = 5;
            this.listView_dominio.UseCompatibleStateImageBehavior = false;
            this.listView_dominio.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista de E-mails cadastrados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de domínios cadastrados:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listView_email);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 205);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listView_dominio);
            this.panel3.Location = new System.Drawing.Point(12, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 193);
            this.panel3.TabIndex = 10;
            // 
            // Questao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 495);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_limpar);
            this.Name = "Questao2";
            this.Text = "Questão 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_adicionarEmail;
        private Panel panel1;
        private Button button_limpar;
        private TextBox textBox_email;
        private Label label1;
        private ListView listView_email;
        private ListView listView_dominio;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private ColumnHeader columnHeader_email;
    }
}