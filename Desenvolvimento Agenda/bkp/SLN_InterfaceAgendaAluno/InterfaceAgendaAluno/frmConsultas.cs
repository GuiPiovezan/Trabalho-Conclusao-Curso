using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAgendaAluno
{
    public partial class frmConsultas : Form
    {
       string idUsuario = "";
        public frmConsultas()
        {
            InitializeComponent();
        }

        public frmConsultas(string idRecebido)
        {
            InitializeComponent();
            idUsuario = idRecebido;
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbAulas_CheckedChanged(object sender, EventArgs e)
        {
            dataConsultas.Rows.Clear();
            dataConsultas.ColumnCount = 6;
            dataConsultas.ReadOnly = true;
            dataConsultas.Columns[0].Name = "Código";
            dataConsultas.Columns[1].Name = "Descrição";
            dataConsultas.Columns[2].Name = "Data da aula";
            dataConsultas.Columns[3].Name = "Local";
            dataConsultas.Columns[4].Name = "Inicio";
            dataConsultas.Columns[5].Name = "Término";
            CtrlAula objCtrlAula = new CtrlAula();
            foreach (Aula objAula in objCtrlAula.selecionarAula(idUsuario))
            {
                dataConsultas.Rows.Add(
                    objAula.idAula.ToString(),
                    objAula.descricao.ToString(),
                    objAula.dataAula.ToString(),
                    objAula.locall.ToString(),
                    objAula.horaInicio.ToString(),
                    objAula.horaTermino.ToString()
                    );
            }
        }

        private void rdbCurso_CheckedChanged(object sender, EventArgs e)
        {
            dataConsultas.Rows.Clear();
            dataConsultas.ColumnCount = 6;
            dataConsultas.ReadOnly = true;
            dataConsultas.Columns[0].Name = "Código";
            dataConsultas.Columns[1].Name = "Descrição";
            dataConsultas.Columns[2].Name = "Coordenador";
            dataConsultas.Columns[3].Name = "Tipo de Curso";
            dataConsultas.Columns[4].Name = "Ano do Curso";
            dataConsultas.Columns[5].Name = "Período";
        }

        private void rdbTurma_CheckedChanged(object sender, EventArgs e)
        {
            dataConsultas.Rows.Clear();
            dataConsultas.ColumnCount = 2;
            dataConsultas.ReadOnly = true;
            dataConsultas.Columns[0].Name = "Código";
            dataConsultas.Columns[1].Name = "Descrição";
        }
    }
}
