namespace FormsDbExGlicemia
{
    partial class Paciente
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
            this.listView_exibirPaciente = new System.Windows.Forms.ListView();
            this.columnHeader_idPaciente = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_nome = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_email = new System.Windows.Forms.ColumnHeader();
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.panel_dados = new System.Windows.Forms.Panel();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.panel_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_exibirPaciente
            // 
            this.listView_exibirPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_idPaciente,
            this.columnHeader_nome,
            this.columnHeader_email});
            this.listView_exibirPaciente.Location = new System.Drawing.Point(12, 22);
            this.listView_exibirPaciente.Name = "listView_exibirPaciente";
            this.listView_exibirPaciente.Size = new System.Drawing.Size(391, 132);
            this.listView_exibirPaciente.TabIndex = 0;
            this.listView_exibirPaciente.UseCompatibleStateImageBehavior = false;
            this.listView_exibirPaciente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_idPaciente
            // 
            this.columnHeader_idPaciente.Text = "idPaciente";
            this.columnHeader_idPaciente.Width = 80;
            // 
            // columnHeader_nome
            // 
            this.columnHeader_nome.Text = "Nome";
            this.columnHeader_nome.Width = 150;
            // 
            // columnHeader_email
            // 
            this.columnHeader_email.Text = "E-mail";
            this.columnHeader_email.Width = 130;
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(12, 160);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(71, 23);
            this.button_conectar.TabIndex = 1;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Enabled = false;
            this.button_cadastrar.Location = new System.Drawing.Point(166, 160);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 2;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Enabled = false;
            this.button_deletar.Location = new System.Drawing.Point(247, 160);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 3;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Enabled = false;
            this.button_editar.Location = new System.Drawing.Point(328, 160);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 4;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // panel_dados
            // 
            this.panel_dados.Controls.Add(this.button_salvar);
            this.panel_dados.Controls.Add(this.textBox_email);
            this.panel_dados.Controls.Add(this.textBox_nome);
            this.panel_dados.Controls.Add(this.textBox_idPaciente);
            this.panel_dados.Controls.Add(this.label3);
            this.panel_dados.Controls.Add(this.label2);
            this.panel_dados.Controls.Add(this.label1);
            this.panel_dados.Enabled = false;
            this.panel_dados.Location = new System.Drawing.Point(12, 226);
            this.panel_dados.Name = "panel_dados";
            this.panel_dados.Size = new System.Drawing.Size(391, 139);
            this.panel_dados.TabIndex = 5;
            // 
            // button_salvar
            // 
            this.button_salvar.Enabled = false;
            this.button_salvar.Location = new System.Drawing.Point(235, 94);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 6;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Location = new System.Drawing.Point(83, 65);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(227, 23);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Location = new System.Drawing.Point(83, 36);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(227, 23);
            this.textBox_nome.TabIndex = 4;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Enabled = false;
            this.textBox_idPaciente.Location = new System.Drawing.Point(83, 7);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(227, 23);
            this.textBox_idPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "idPaciente";
            // 
            // button_voltar
            // 
            this.button_voltar.Location = new System.Drawing.Point(331, 384);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(72, 23);
            this.button_voltar.TabIndex = 7;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 419);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.panel_dados);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.listView_exibirPaciente);
            this.Name = "Paciente";
            this.Text = "Pacientes";
            this.panel_dados.ResumeLayout(false);
            this.panel_dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_exibirPaciente;
        private ColumnHeader columnHeader_idPaciente;
        private ColumnHeader columnHeader_nome;
        private ColumnHeader columnHeader_email;
        private Button button_conectar;
        private Button button_cadastrar;
        private Button button_deletar;
        private Button button_editar;
        private Panel panel_dados;
        private Button button_voltar;
        private Button button_salvar;
        private TextBox textBox_email;
        private TextBox textBox_nome;
        private TextBox textBox_idPaciente;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}