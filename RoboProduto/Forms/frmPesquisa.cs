using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Robo.Domain.Enum;
using Robo.Domain.Interfaces;
using Robo.Domain.Data;

namespace RoboProduto.Forms
{
    public partial class frmPesquisa : Form
    {
        private readonly IPesquisa _pesquisa;
        private DataTable dt = new DataTable();
        public frmPesquisa(string tabela)
        {
            InitializeComponent();

            if (tabela.ToUpper() == ETable.DEPARTAMENTO)
                _pesquisa = new Departamento();
            else if(tabela.ToUpper() == ETable.PRODUTO)
                _pesquisa = new Produto();

            Text = _pesquisa.GetTitle();
            lblPesquisa.Text = "Descrição:";
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            dt = _pesquisa.GetAll();

            gridPesquisa.DataSource = dt;

            gridPesquisa.Columns["id"].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _pesquisa.Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _pesquisa.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _pesquisa.Excluir();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            EnumerableRowCollection<DataRow> query = from objPesquisa in dt.AsEnumerable()
                                                     where objPesquisa.Field<String>("descricao").Contains(txtPesquisa.Text.ToUpper())
                                                     select objPesquisa;

            DataView view = query.AsDataView();

            gridPesquisa.DataSource = view;
        }       
    }
}
