using Robo.Domain.Data;
using Robo.Domain.Enum;
using Robo.Domain.Interfaces;
using Robo.Domain.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RoboProduto.Forms
{
    public partial class frmPesquisa : Form
    {
        private readonly IPesquisa _pesquisa;
        private readonly IDepartamentoRep _departamentoRep;
        private readonly IProdutoRep _produtoRep;

        private DataTable dt = new DataTable();
        private int id, index;
        public frmPesquisa(string tabela)
        {
            InitializeComponent();

            if (tabela.ToUpper() == ETable.DEPARTAMENTO)
            {
                _departamentoRep = new DepartamentoRep();
                _pesquisa = new DepartamentoPesquisa(_departamentoRep);
            }
            else if (tabela.ToUpper() == ETable.PRODUTO)
            {
                _produtoRep = new ProdutoRep();
                _pesquisa = new ProdutoPesquisa(_produtoRep);
            }

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
            _pesquisa.Editar(id);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_pesquisa.Excluir(id))
                gridPesquisa.Rows.RemoveAt(index);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            EnumerableRowCollection<DataRow> query = from objPesquisa in dt.AsEnumerable()
                                                     where objPesquisa.Field<String>("descricao").Contains(txtPesquisa.Text.ToUpper())
                                                     select objPesquisa;

            DataView view = query.AsDataView();

            gridPesquisa.DataSource = view;
        }

        private void gridPesquisa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            id = int.Parse(gridPesquisa.Rows[index].Cells["id"].Value.ToString());
        }

        private void frmPesquisa_Shown(object sender, EventArgs e)
        {
            gridPesquisa.Focus();
        }
    }
}
