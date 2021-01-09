using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboProduto.Services;
using Robo.Domain.Repository;

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
