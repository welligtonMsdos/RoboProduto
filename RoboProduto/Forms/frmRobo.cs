using Robo.Domain.Repository;
using RoboProduto.Services;
using System;
using System.Windows.Forms;

namespace RoboProduto
{
    public partial class frmRobo : Form
    {
        private bool status = false;    

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
            RoboService roboService = new RoboService(new ProdutoRep(), new Logger(ref gridContainer));

            status = true;

            btnAcao.Text = "Parar";
            
            roboService.Iniciar();
        }

        private void Parar()
        {
            status = false;

            btnAcao.Text = "Iniciar";
        }
    }
}
