using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Windows.Forms;

namespace Robo.Domain.Forms
{
    public partial class frmDepartamento : Form
    {
        private readonly IDepartamentoRep _departamentoRep;
        private Departamento departamento;

        public frmDepartamento(IDepartamentoRep _departamentoRep, Departamento departamento)
        {
            InitializeComponent();
            this._departamentoRep = _departamentoRep;
            this.departamento = departamento;

            txtDescricao.Text = this.departamento.descricao;

            txtDescricao.Select(txtDescricao.Text.Length, 0);
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (departamento.id == null)
            {
                departamento = new Departamento(0, txtDescricao.Text.Trim());
                _departamentoRep.Insert(departamento);
            }
            else
            {
                departamento.descricao = txtDescricao.Text.Trim();
                _departamentoRep.Update(departamento);
            }
        }
    }
}
