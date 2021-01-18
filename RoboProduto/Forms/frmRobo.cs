using Robo.Domain.Repository;
using RoboProduto.Forms;
using RoboProduto.Services;
using System;
using System.Windows.Forms;

namespace RoboProduto
{
    public partial class frmRobo : Form
    {
        private bool status = false;
        RoboService roboService;

        public frmRobo()
        {
            InitializeComponent();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (!status)
                Iniciar();
            else
                Parar();
        }

        private void Iniciar()
        {
            status = true;

            btnAcao.Text = "Parar";
            
            roboService.Iniciar();
        }

        private void Parar()
        {
            status = false;

            btnAcao.Text = "Iniciar";

            roboService.Parar();
        }

        private void frmRobo_Load(object sender, EventArgs e)
        {
            roboService = new RoboService(new ProdutoRep(), new Logger(ref gridContainer));
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa("Departamento");
            frm.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa("Produto");
            frm.ShowDialog();
        }
    }
}
