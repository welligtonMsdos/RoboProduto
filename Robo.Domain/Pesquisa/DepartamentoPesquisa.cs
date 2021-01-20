using Robo.Domain.Enum;
using Robo.Domain.Forms;
using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System.Data;
using System.Windows.Forms;

namespace Robo.Domain.Pesquisa
{
    public class DepartamentoPesquisa : IPesquisa
    {
        private readonly IDepartamentoRep _departamentoRep;

        public DepartamentoPesquisa(IDepartamentoRep _departamentoRep)
        {
            this._departamentoRep = _departamentoRep;
        }

        public void Editar(int id)
        {
            frmDepartamento frm = new frmDepartamento(_departamentoRep);
            frm.Id = id;
            frm.ShowDialog();
        }

        public bool Excluir(int id)
        {
            bool resultado = false;

            if(MessageBox.Show("Deseja realmente excluir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                resultado = _departamentoRep.Delete(id);

            return resultado;
        }

        public DataTable GetAll()
        {
            return _departamentoRep.GetAll();
        }       

        public string GetTitle()
        {
            return "DEPARTAMENTO";
        }

        public void Novo()
        {
            frmDepartamento frm = new frmDepartamento(_departamentoRep);
            frm.ShowDialog();
        }       
    }
}
