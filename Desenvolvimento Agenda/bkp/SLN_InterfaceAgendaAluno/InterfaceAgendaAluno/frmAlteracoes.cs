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
    public partial class frmAlteracoes : Form
    {
        public frmAlteracoes()
        {
            InitializeComponent();
        }

        private void rdbCurso_CheckedChanged(object sender, EventArgs e)
        {
            limparLabels();
            lbl1.Text = "CONSULTAS DE CURSOS";
            lbl2.Text = "Descrição: ";
            txtDescricao.Visible = true;
            lbl3.Text = "Periodo: ";
            cmbPeriodoCurso.Visible = true; txtDataAula.Visible = false;
            lbl4.Text = "Coordenador: ";
            txtCoordenador.Visible = true; txtLocalAula.Visible = false;
            lbl5.Text = "Ano do curso: ";
            cmbAnoCurso.Visible = true; txtHoraInicio.Visible = false;
            lbl6.Text = "Tipo de curso: ";
            cmbTipoCurso.Visible = true; txtHoraTermino.Visible = false;

        }

        private void rdbTurma_CheckedChanged(object sender, EventArgs e)
        {
            limparLabels();
            lbl1.Text = "CONSULTAS DE TURMAS";
            lbl2.Text = "Descrição: ";
            txtDescricao.Visible = true;
            lbl3.Visible = false; lbl4.Visible = false; lbl5.Visible = false; lbl6.Visible = false;
            cmbAnoCurso.Visible = false; txtCoordenador.Visible = false; txtDataAula.Visible = false;
            txtHoraInicio.Visible = false; txtHoraTermino.Visible = false; txtLocalAula.Visible = false;
            cmbPeriodoCurso.Visible = false; cmbTipoCurso.Visible = false;
        }

        private void rdbAula_CheckedChanged(object sender, EventArgs e)
        {
            limparLabels();
            lbl1.Text = "CONSULTAS DE AULAS";
            lbl2.Text = "Descrição: ";
            txtDescricao.Visible = true;
            lbl3.Text = "Data da aula: ";
            lbl3.Refresh();
            txtDataAula.Visible = true; cmbPeriodoCurso.Visible = false;
            lbl4.Text = "Local: ";
            lbl4.Refresh();
            txtLocalAula.Visible = true; txtCoordenador.Visible = false;
            lbl5.Text = "Hora de início: ";
            lbl5.Refresh();
            txtHoraInicio.Visible = true; cmbAnoCurso.Visible = false;
            lbl6.Text = "Hora término: ";
            lbl6.Refresh();
            txtHoraTermino.Visible = true; cmbTipoCurso.Visible = false;
        }

        public void limparLabels()
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
        }
    }
}
