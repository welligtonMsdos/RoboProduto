using Robo.Domain.Interfaces;
using Robo.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;

namespace Robo.Domain.Forms
{
    public partial class frmDepartamento : Form
    {
        private readonly IDepartamentoRep _departamentoRep;

        public Departamento departamento = new Departamento();
        public int Id { get; set; }

        public frmDepartamento(IDepartamentoRep departamentoRep)
        {
            InitializeComponent();

            _departamentoRep = departamentoRep;
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            try
            {
                departamento.descricao = txtDescricao.Text.Trim();

                if (_departamentoRep.Validacao(departamento))
                {
                    if (Id == 0)
                        _departamentoRep.Insert(departamento);
                    else
                        _departamentoRep.Update(departamento);

                    MessageBox.Show("Salvo com sucesso!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        
        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                departamento = _departamentoRep.ObterDados(Id);

                SetDados();
            }
        }        

        public void SetDados()
        {
            txtDescricao.Text = departamento.descricao;

            txtDescricao.Select(txtDescricao.Text.Length, 0);
        }            
    }
}
