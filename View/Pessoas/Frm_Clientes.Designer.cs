﻿namespace View.Pessoas
{
    partial class Frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
            this.Txt_Tipo = new System.Windows.Forms.ComboBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Fisica = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Txt_DataNacimento = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Sexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage_Juridica = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.Txt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Contato = new System.Windows.Forms.MaskedTextBox();
            this.Txt_InscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Pessoa = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Btm_Carregar = new System.Windows.Forms.Button();
            this.Txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Email = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btm_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.tabPage_Fisica.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_Juridica.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Tipo.FormattingEnabled = true;
            this.Txt_Tipo.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.Txt_Tipo.Location = new System.Drawing.Point(67, 227);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(236, 21);
            this.Txt_Tipo.TabIndex = 9;
            this.Txt_Tipo.DropDownClosed += new System.EventHandler(this.Txt_Tipo_DropDownClosed);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage_Fisica);
            this.TabControl.Controls.Add(this.tabPage_Juridica);
            this.TabControl.Location = new System.Drawing.Point(0, 270);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(862, 133);
            this.TabControl.TabIndex = 18;
            // 
            // tabPage_Fisica
            // 
            this.tabPage_Fisica.Controls.Add(this.panel1);
            this.tabPage_Fisica.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Fisica.Name = "tabPage_Fisica";
            this.tabPage_Fisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fisica.Size = new System.Drawing.Size(854, 107);
            this.tabPage_Fisica.TabIndex = 0;
            this.tabPage_Fisica.Text = "Física";
            this.tabPage_Fisica.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Txt_CPF);
            this.panel1.Controls.Add(this.Txt_Celular);
            this.panel1.Controls.Add(this.Txt_DataNacimento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Txt_Sexo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 109);
            this.panel1.TabIndex = 0;
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(67, 16);
            this.Txt_CPF.Mask = "000.000.000-00";
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(235, 20);
            this.Txt_CPF.TabIndex = 1;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(67, 61);
            this.Txt_Celular.Mask = "(00)90000-0000";
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(235, 20);
            this.Txt_Celular.TabIndex = 3;
            // 
            // Txt_DataNacimento
            // 
            this.Txt_DataNacimento.Location = new System.Drawing.Point(518, 61);
            this.Txt_DataNacimento.Mask = "00/00/0000";
            this.Txt_DataNacimento.Name = "Txt_DataNacimento";
            this.Txt_DataNacimento.Size = new System.Drawing.Size(235, 20);
            this.Txt_DataNacimento.TabIndex = 7;
            this.Txt_DataNacimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_DataNacimento.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Data Nascimento";
            // 
            // Txt_Sexo
            // 
            this.Txt_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Sexo.FormattingEnabled = true;
            this.Txt_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.Txt_Sexo.Location = new System.Drawing.Point(518, 19);
            this.Txt_Sexo.Name = "Txt_Sexo";
            this.Txt_Sexo.Size = new System.Drawing.Size(236, 21);
            this.Txt_Sexo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CPF";
            // 
            // tabPage_Juridica
            // 
            this.tabPage_Juridica.Controls.Add(this.panel3);
            this.tabPage_Juridica.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Juridica.Name = "tabPage_Juridica";
            this.tabPage_Juridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Juridica.Size = new System.Drawing.Size(854, 107);
            this.tabPage_Juridica.TabIndex = 1;
            this.tabPage_Juridica.Text = "Jurídica";
            this.tabPage_Juridica.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Txt_RazaoSocial);
            this.panel3.Controls.Add(this.Txt_CNPJ);
            this.panel3.Controls.Add(this.Txt_Contato);
            this.panel3.Controls.Add(this.Txt_InscricaoEstadual);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(-7, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 108);
            this.panel3.TabIndex = 19;
            // 
            // Txt_RazaoSocial
            // 
            this.Txt_RazaoSocial.Location = new System.Drawing.Point(525, 58);
            this.Txt_RazaoSocial.Name = "Txt_RazaoSocial";
            this.Txt_RazaoSocial.Size = new System.Drawing.Size(236, 20);
            this.Txt_RazaoSocial.TabIndex = 7;
            // 
            // Txt_CNPJ
            // 
            this.Txt_CNPJ.Location = new System.Drawing.Point(67, 16);
            this.Txt_CNPJ.Mask = "00.000.000/0000-00";
            this.Txt_CNPJ.Name = "Txt_CNPJ";
            this.Txt_CNPJ.Size = new System.Drawing.Size(235, 20);
            this.Txt_CNPJ.TabIndex = 1;
            // 
            // Txt_Contato
            // 
            this.Txt_Contato.Location = new System.Drawing.Point(67, 61);
            this.Txt_Contato.Name = "Txt_Contato";
            this.Txt_Contato.Size = new System.Drawing.Size(235, 20);
            this.Txt_Contato.TabIndex = 3;
            // 
            // Txt_InscricaoEstadual
            // 
            this.Txt_InscricaoEstadual.Location = new System.Drawing.Point(525, 13);
            this.Txt_InscricaoEstadual.Name = "Txt_InscricaoEstadual";
            this.Txt_InscricaoEstadual.Size = new System.Drawing.Size(235, 20);
            this.Txt_InscricaoEstadual.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(425, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Inscrição Estadual";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(425, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Razão Social";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Contato";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "CNPJ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.Txt_Pessoa);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.Btm_Carregar);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 40);
            this.panel2.TabIndex = 2;
            // 
            // Txt_Pessoa
            // 
            this.Txt_Pessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Pessoa.Items.AddRange(new object[] {
            "Administrador",
            "Técnico"});
            this.Txt_Pessoa.Location = new System.Drawing.Point(67, 11);
            this.Txt_Pessoa.Name = "Txt_Pessoa";
            this.Txt_Pessoa.Size = new System.Drawing.Size(238, 21);
            this.Txt_Pessoa.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lista";
            // 
            // Btm_Carregar
            // 
            this.Btm_Carregar.Location = new System.Drawing.Point(340, 9);
            this.Btm_Carregar.Name = "Btm_Carregar";
            this.Btm_Carregar.Size = new System.Drawing.Size(75, 23);
            this.Btm_Carregar.TabIndex = 2;
            this.Btm_Carregar.Text = "Carregar";
            this.Btm_Carregar.UseVisualStyleBackColor = true;
            this.Btm_Carregar.Click += new System.EventHandler(this.Btm_Carregar_Click);
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(487, 224);
            this.Txt_Cep.Mask = "99999-999";
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(235, 20);
            this.Txt_Cep.TabIndex = 17;
            this.Txt_Cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(67, 178);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(235, 20);
            this.Txt_Email.TabIndex = 7;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Txt_Estado.FormattingEnabled = true;
            this.Txt_Estado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.Txt_Estado.Location = new System.Drawing.Point(486, 105);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(236, 21);
            this.Txt_Estado.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(485, 182);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(236, 20);
            this.Txt_Bairro.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bairro";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(485, 143);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(236, 20);
            this.Txt_Cidade.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Location = new System.Drawing.Point(69, 139);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(236, 20);
            this.Txt_Endereco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(69, 101);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(236, 20);
            this.Txt_Nome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btm_Salvar,
            this.testeToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btm_Salvar
            // 
            this.Btm_Salvar.Name = "Btm_Salvar";
            this.Btm_Salvar.Size = new System.Drawing.Size(44, 20);
            this.Btm_Salvar.Text = "&Criar";
            this.Btm_Salvar.Click += new System.EventHandler(this.Btm_Salvar_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::View.Properties.Resources.Edit_User_100;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 401);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Txt_Cep);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage_Fisica.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_Juridica.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Txt_Tipo;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage_Fisica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Txt_CPF;
        private System.Windows.Forms.MaskedTextBox Txt_Celular;
        private System.Windows.Forms.MaskedTextBox Txt_DataNacimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Txt_Sexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage_Juridica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_RazaoSocial;
        private System.Windows.Forms.MaskedTextBox Txt_CNPJ;
        private System.Windows.Forms.MaskedTextBox Txt_Contato;
        private System.Windows.Forms.MaskedTextBox Txt_InscricaoEstadual;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Txt_Pessoa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Btm_Carregar;
        private System.Windows.Forms.MaskedTextBox Txt_Cep;
        private System.Windows.Forms.MaskedTextBox Txt_Email;
        private System.Windows.Forms.ComboBox Txt_Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Btm_Salvar;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}