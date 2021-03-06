﻿using System;
using Model.Ordem_de_Servico;
using System.Windows.Forms;
using Controller;

namespace View.OS
{
    public partial class Frm_ListarOS : Form
    {
        public Frm_ListarOS()
        {
            InitializeComponent();
        }

        private void Frm_ListarOS_Load(object sender, EventArgs e)
        {
            AualizarLista();
        }

        private void AualizarLista()
        {
            Data_Os.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Data_Os.DataSource = ControllerOrdemServico.CarregarLista();
        }

        private void Btm_Atualizar_Click(object sender, EventArgs e)
        {
            AualizarLista();
        }
    }
}
