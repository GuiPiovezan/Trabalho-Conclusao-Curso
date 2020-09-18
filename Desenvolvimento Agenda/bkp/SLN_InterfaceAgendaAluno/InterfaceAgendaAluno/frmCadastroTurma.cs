using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceAgendaAluno
{
    public partial class frmCadastroTurma : Form
    {
        int idTurma = 0;
        public frmCadastroTurma()
        {
            InitializeComponent();
            carregarComboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            Turma objTurma = new Turma();
            CtrlTurma objCtrlTurma = new CtrlTurma();
            if (btnCadastrar.Text == "CADASTRAR" && idTurma==0)
            {
                try
                {
                    if (cmbSelecCurso.SelectedItem != null)
                    {
                        objTurma.codCurso = Convert.ToInt32(cmbSelecCurso.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um curso!");
                    }
                    objTurma.descricao = txtDescricaoTurma.Text;
                    idTurma = objTurma.idTurma;
                    if (cmbPeriodo.SelectedIndex == 0)
                    {
                        objTurma.codPeriodo = 1;
                    }
                    else if (cmbPeriodo.SelectedIndex == 1)
                    {
                        objTurma.codPeriodo = 2;
                    }
                    else
                    {
                        objTurma.codPeriodo = 3;
                    }
                    if (objCtrlTurma.Inserir(objTurma))
                    {
                        MessageBox.Show("Turma cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a turma");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar database: \n" + ex);
                }
                atualizarLista();
            }
            else if(btnCadastrar.Text=="SALVAR" && idTurma!=0)
            {
                
                try
                {
                    if (cmbSelecCurso.SelectedItem != null)
                    {
                        objTurma.codCurso = Convert.ToInt32(cmbSelecCurso.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um curso!");
                    }
                    objTurma.descricao = txtDescricaoTurma.Text;
                    idTurma = objTurma.idTurma;
                    if (cmbPeriodo.SelectedIndex == 0)
                    {
                        objTurma.codPeriodo = 1;
                    }
                    else if (cmbPeriodo.SelectedIndex == 1)
                    {
                        objTurma.codPeriodo = 2;
                    }
                    else
                    {
                        objTurma.codPeriodo = 3;
                    }
                    if (objCtrlTurma.Inserir(objTurma))
                    {
                        MessageBox.Show("Turma alterada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar a turma");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar database: \n" + ex);
                }
                atualizarLista();
            }
            
        }
        public void carregarComboBox()
        {
            try
            {
                CtrlCurso objCtrlCurso = new CtrlCurso();
                cmbSelecCurso.DataSource = objCtrlCurso.preencherComboBox();
                cmbSelecCurso.DisplayMember = "descricao";
                cmbSelecCurso.ValueMember = "idCurso";
                cmbSelecCurso.SelectedValue = -1;
                cmbSelecCurso.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
          
        }
        private void frmCadastroTurma_Load(object sender, EventArgs e)
        {
            try
            {
                dataConsultaTurma.ColumnCount = 4;
                dataConsultaTurma.Rows.Clear();
                dataConsultaTurma.ReadOnly = true;
                dataConsultaTurma.Columns[0].Name = "Código da Turma";
                dataConsultaTurma.Columns[1].Name = "Descrição";
                dataConsultaTurma.Columns[2].Name = "Código do Curso";
                dataConsultaTurma.Columns[3].Name = "Código do Periodo";
                CtrlTurma objCtrlTurma = new CtrlTurma();
                foreach (Turma objTurma in objCtrlTurma.selecionarTurma())
                {
                    dataConsultaTurma.Rows.Add(
                        objTurma.idTurma.ToString(),
                        objTurma.descricao.ToString(),
                        objTurma.codCurso.ToString(),
                        objTurma.codPeriodo.ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
            
        }
        public void atualizarLista()
        {
            try
            {                
                dataConsultaTurma.ColumnCount = 4;
                dataConsultaTurma.Rows.Clear();
                dataConsultaTurma.Refresh();
                dataConsultaTurma.ReadOnly = true;
                dataConsultaTurma.Columns[0].Name = "Código da Turma";
                dataConsultaTurma.Columns[1].Name = "Descrição";
                dataConsultaTurma.Columns[2].Name = "Código do Curso";
                dataConsultaTurma.Columns[3].Name = "Código do Periodo";
                CtrlTurma objCtrlTurma = new CtrlTurma();
                foreach (Turma objTurma in objCtrlTurma.selecionarTurma())
                {
                    dataConsultaTurma.Rows.Add(
                        objTurma.idTurma.ToString(),
                        objTurma.descricao.ToString(),
                        objTurma.codCurso.ToString(),
                        objTurma.codPeriodo.ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
        }

        private void dataConsultaTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Text = "SALVAR";
            idTurma = Convert.ToInt32(dataConsultaTurma.CurrentRow.Cells[0].Value.ToString());
            txtDescricaoTurma.Text = dataConsultaTurma.CurrentRow.Cells[1].Value.ToString();
            cmbSelecCurso.SelectedValue = Convert.ToInt32(dataConsultaTurma.CurrentRow.Cells[2].Value.ToString());
            cmbPeriodo.SelectedValue = Convert.ToInt32(dataConsultaTurma.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma objTurma = new Turma();
                CtrlTurma objCtrlTurma = new CtrlTurma();
                objTurma.idTurma = idTurma;
                if (objCtrlTurma.Excluir(objTurma, idTurma))
                {
                    MessageBox.Show("Turma excluída com sucesso!");
                    txtDescricaoTurma.Clear();
                    idTurma = 0;
                    btnCadastrar.Text = "CADASTRAR";
                    cmbPeriodo.SelectedValue = -1;
                    cmbSelecCurso.SelectedValue = -1;
                    atualizarLista();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a turma!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string pesquisaId = "";
            try
            {
                Turma objTurma = new Turma();
                CtrlTurma objCtrlTurma = new CtrlTurma();
                
                try
                {
                    pesquisaId = txtPesquisa.Text;
                }
                catch
                {
                    MessageBox.Show("Digite o código da turma!");
                }
                objTurma = objCtrlTurma.pesquisarTurma(pesquisaId);
                cmbPeriodo.SelectedValue = objTurma.codPeriodo;
                txtDescricaoTurma.Text = objTurma.descricao;
                cmbSelecCurso.SelectedValue = objTurma.codCurso;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro :\n" + ex);
            }
             
            
        }
    }
}
