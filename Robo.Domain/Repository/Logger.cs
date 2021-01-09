using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Robo.Domain.Interfaces;

namespace Robo.Domain.Repository
{
    public class Logger : ILogger
    {
        private DataGridView _gridView;
        delegate void AddDataGridViewRow(DataGridViewRow row);

        public Logger(ref DataGridView gridView)
        {
            _gridView = gridView;
        }
        public void LogMsg(DataTable dt)
        {
            foreach(DataRow linha in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell descricao = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell departamento = new DataGridViewTextBoxCell();

                id.Value = linha[0].ToString();
                descricao.Value = linha[1].ToString();
                departamento.Value = linha[2].ToString();

                row.Cells.AddRange(id, descricao, departamento);

                AddDataGridViewRow add = new AddDataGridViewRow(InsertRow);
                _gridView.Invoke(add, new object[] { row });
            }
        }

       private void InsertRow(DataGridViewRow row)
        {
            _gridView.Rows.Insert(0, row);
        }
    }
}
