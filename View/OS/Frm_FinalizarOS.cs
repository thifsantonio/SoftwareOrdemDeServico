﻿using System;
using System.Windows.Forms;
using Model.Ordem_de_Servico;
using Controller;
using Model.Pessoa_e_Usuario;
using Model;

namespace View
{
    public partial class Frm_Servico : Form
    {
        public Frm_Servico(string nomeDoTecnico)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finalizando Ordem de serviço (Botão).
        /// </summary>
        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String saida = ControllerOrdemServico.FinalizarOS(PreencherTrabalho());

            MessageBox.Show(saida, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Txt_IDPesquisa.Items.Clear();
            Txt_Descricao.Clear();
            Txt_Valor.Clear();

            atualizarListaDeOS();
        }


        /// <summary>
        /// Carregando o nome de todos os serviços e os adicionando no combo Box(Txt_Servicos).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Servico_Load(object sender, EventArgs e)
        {
            atualizarListaDeOS();
        }

        private void atualizarListaDeOS()
        {
            System.Data.DataTable TabelaOS = new System.Data.DataTable();

            TabelaOS = ControllerOrdemServico.CarregarListaDeIdsNaoFinalizados();

            foreach (System.Data.DataRow r in TabelaOS.Rows)
            {
                foreach (System.Data.DataColumn c in TabelaOS.Columns)
                {
                    Txt_IDPesquisa.Items.Add(r[c].ToString());
                }
            }
        }

        /// <summary>
        /// Preenchendo uma classe trabalho com as informações do Form.
        /// </summary>
        /// <returns>The trabalho.</returns>
        private Trabalho PreencherTrabalho()
        {
            Trabalho TrabalhoBase = new Trabalho();

            TrabalhoBase.IdOrdemDeServico = Convert.ToInt16(Txt_IDPesquisa.Text);
            TrabalhoBase.Valor = Convert.ToDecimal(Txt_Valor.Text);
            TrabalhoBase.Descricao = Txt_Descricao.Text;

            return TrabalhoBase;
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))//Verifica se é numero
            {
                if (!(e.KeyChar == ',')) //Verifica se é Vírgula.
                {
                    e.Handled = true;
                }
            }
        }
    }
}
