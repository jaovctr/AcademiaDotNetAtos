namespace FormsDbExGlicemia
{
    partial class Gerente
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
            this.listView_exibirValores = new System.Windows.Forms.ListView();
            this.columnHeader_idMedida = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_valGlicemico = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_dataMedicao = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_paciente = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_idPaciente = new System.Windows.Forms.ColumnHeader();
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.textBox_valorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_salvarGlicemia = new System.Windows.Forms.Button();
            this.panel_cadastrar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_idGlicemia = new System.Windows.Forms.TextBox();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.button_gerPaciente = new System.Windows.Forms.Button();
            this.panel_cadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_exibirValores
            // 
            this.listView_exibirValores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_idMedida,
            this.columnHeader_valGlicemico,
            this.columnHeader_dataMedicao,
            this.columnHeader_paciente,
            this.columnHeader_idPaciente});
            this.listView_exibirValores.Location = new System.Drawing.Point(12, 12);
            this.listView_exibirValores.Name = "listView_exibirValores";
            this.listView_exibirValores.Size = new System.Drawing.Size(598, 171);
            this.listView_exibirValores.TabIndex = 0;
            this.listView_exibirValores.UseCompatibleStateImageBehavior = false;
            this.listView_exibirValores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_idMedida
            // 
            this.columnHeader_idMedida.Text = "IdMedida";
            this.columnHeader_idMedida.Width = 70;
            // 
            // columnHeader_valGlicemico
            // 
            this.columnHeader_valGlicemico.Text = "Valor Glicêmico";
            this.columnHeader_valGlicemico.Width = 95;
            // 
            // columnHeader_dataMedicao
            // 
            this.columnHeader_dataMedicao.Text = "Data medição";
            this.columnHeader_dataMedicao.Width = 110;
            // 
            // columnHeader_paciente
            // 
            this.columnHeader_paciente.Text = "Paciente";
            this.columnHeader_paciente.Width = 150;
            // 
            // columnHeader_idPaciente
            // 
            this.columnHeader_idPaciente.Text = "idPaciente";
            this.columnHeader_idPaciente.Width = 80;
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(12, 189);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(75, 23);
            this.button_conectar.TabIndex = 1;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Enabled = false;
            this.button_cadastrar.Location = new System.Drawing.Point(93, 189);
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
            this.button_deletar.Location = new System.Drawing.Point(174, 189);
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
            this.button_editar.Location = new System.Drawing.Point(255, 189);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 4;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // textBox_valorGlicemia
            // 
            this.textBox_valorGlicemia.Location = new System.Drawing.Point(120, 36);
            this.textBox_valorGlicemia.Name = "textBox_valorGlicemia";
            this.textBox_valorGlicemia.Size = new System.Drawing.Size(242, 23);
            this.textBox_valorGlicemia.TabIndex = 5;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(120, 94);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(242, 23);
            this.textBox_idPaciente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor Glicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Medição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "idPaciente";
            // 
            // button_salvarGlicemia
            // 
            this.button_salvarGlicemia.Location = new System.Drawing.Point(120, 123);
            this.button_salvarGlicemia.Name = "button_salvarGlicemia";
            this.button_salvarGlicemia.Size = new System.Drawing.Size(242, 23);
            this.button_salvarGlicemia.TabIndex = 13;
            this.button_salvarGlicemia.Text = "Salvar";
            this.button_salvarGlicemia.UseVisualStyleBackColor = true;
            this.button_salvarGlicemia.Click += new System.EventHandler(this.button_salvarGlicemia_Click);
            // 
            // panel_cadastrar
            // 
            this.panel_cadastrar.Controls.Add(this.label4);
            this.panel_cadastrar.Controls.Add(this.textBox_idGlicemia);
            this.panel_cadastrar.Controls.Add(this.dateTimePicker_data);
            this.panel_cadastrar.Controls.Add(this.button_salvarGlicemia);
            this.panel_cadastrar.Controls.Add(this.label3);
            this.panel_cadastrar.Controls.Add(this.label2);
            this.panel_cadastrar.Controls.Add(this.label1);
            this.panel_cadastrar.Controls.Add(this.textBox_idPaciente);
            this.panel_cadastrar.Controls.Add(this.textBox_valorGlicemia);
            this.panel_cadastrar.Enabled = false;
            this.panel_cadastrar.Location = new System.Drawing.Point(7, 242);
            this.panel_cadastrar.Name = "panel_cadastrar";
            this.panel_cadastrar.Size = new System.Drawing.Size(515, 197);
            this.panel_cadastrar.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "IdMedida";
            // 
            // textBox_idGlicemia
            // 
            this.textBox_idGlicemia.Enabled = false;
            this.textBox_idGlicemia.Location = new System.Drawing.Point(120, 7);
            this.textBox_idGlicemia.Name = "textBox_idGlicemia";
            this.textBox_idGlicemia.Size = new System.Drawing.Size(242, 23);
            this.textBox_idGlicemia.TabIndex = 15;
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Location = new System.Drawing.Point(120, 65);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(242, 23);
            this.dateTimePicker_data.TabIndex = 14;
            // 
            // button_gerPaciente
            // 
            this.button_gerPaciente.Location = new System.Drawing.Point(336, 189);
            this.button_gerPaciente.Name = "button_gerPaciente";
            this.button_gerPaciente.Size = new System.Drawing.Size(125, 23);
            this.button_gerPaciente.TabIndex = 15;
            this.button_gerPaciente.Text = "Gerenciar Pacientes";
            this.button_gerPaciente.UseVisualStyleBackColor = true;
            this.button_gerPaciente.Click += new System.EventHandler(this.button_gerPaciente_Click);
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.button_gerPaciente);
            this.Controls.Add(this.panel_cadastrar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.listView_exibirValores);
            this.Name = "Gerente";
            this.Text = "Gestão de Medidas Glicêmicas";
            this.panel_cadastrar.ResumeLayout(false);
            this.panel_cadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_exibirValores;
        private ColumnHeader columnHeader_idMedida;
        private ColumnHeader columnHeader_valGlicemico;
        private ColumnHeader columnHeader_dataMedicao;
        private ColumnHeader columnHeader_paciente;
        private ColumnHeader columnHeader_idPaciente;
        private Button button_conectar;
        private Button button_cadastrar;
        private Button button_deletar;
        private Button button_editar;
        private TextBox textBox_valorGlicemia;
        private TextBox textBox_idPaciente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_salvarGlicemia;
        private Panel panel_cadastrar;
        private DateTimePicker dateTimePicker_data;
        private Label label4;
        private TextBox textBox_idGlicemia;
        private Button button_gerPaciente;
    }
}