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
    public partial class frmCadastroAula : Form
    {
        int idAula = 0, codTurma = 0, codDisciplina = 0;
        public frmCadastroAula()
        {
            InitializeComponent();
            carregarComboDisciplina();
            carregarComboTurma();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void atualizarLista()
        {
            dataConsultaAula.ColumnCount = 7;
            dataConsultaAula.Rows.Clear();
            dataConsultaAula.ReadOnly = true;
            dataConsultaAula.Columns[0].Name = "Código da Aula";
            dataConsultaAula.Columns[1].Name = "Local";
            dataConsultaAula.Columns[2].Name = "Ínicio";
            dataConsultaAula.Columns[3].Name = "Término";
            dataConsultaAula.Columns[4].Name = "Data da Aula";
            dataConsultaAula.Columns[5].Name = "Código da Turma";
            dataConsultaAula.Columns[6].Name = "Código da Disciplina";

            CtrlAula objCtrlAula = new CtrlAula();

            foreach (Aula objAula in objCtrlAula.selecionarAula())
            {
                dataConsultaAula.Rows.Add
                    (
                       objAula.idAula.ToString(),
                       objAula.locall.ToString(),
                       objAula.horaInicio.ToString(),
                       objAula.horaTermino.ToString(),
                       objAula.dataAula.ToString(),
                       objAula.codTurma.ToString(),
                       objAula.codDisciplina.ToString()
                    );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "CADASTRAR" && idAula==0)
            {
                try
                {
                    Aula objAula = new Aula();
                    CtrlAula objCtrlAula = new CtrlAula();
                    if (cmbSelectTurma.SelectedItem != null)
                    {
                        objAula.codTurma = Convert.ToInt32(cmbSelectTurma.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma turma!");
                    }
                    if (cmbSelectDisciplina.SelectedItem != null)
                    {
                        objAula.codDisciplina = Convert.ToInt32(cmbSelectDisciplina.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma disciplina!");
                    }
                    objAula.dataAula = txtData.Text;
                    objAula.horaInicio = txtInicio.Text;
                    objAula.horaTermino = txtTermino.Text;
                    objAula.locall = txtLocal.Text;
                    if (objCtrlAula.Inserir(objAula))
                    {
                        MessageBox.Show("Aula cadastrada com sucesso!");
                        txtData.Text = "";
                        txtInicio.Text = "";
                        txtLocal.Text = "";
                        txtTermino.Text = "";
                        cmbSelectDisciplina.SelectedValue = -1;
                        cmbSelectTurma.SelectedValue = -1;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a aula!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar database: \n" + ex);
                }
                atualizarLista();
            }
            else if (btnCadastrar.Text == "SALVAR" && idAula!=0)
            {
                try
                {
                    Aula objAula = new Aula();
                    CtrlAula objCtrlAula = new CtrlAula();
                    objAula.idAula = idAula;
                    objAula.codTurma = codTurma;
                    objAula.codDisciplina = codDisciplina;
                    objAula.dataAula = txtData.Text;
                    objAula.horaInicio = txtInicio.Text;
                    objAula.horaTermino = txtTermino.Text;
                    objAula.locall = txtLocal.Text;
                    if (objCtrlAula.Alterar(objAula, idAula))
                    {
                        MessageBox.Show("Aula alterada com sucesso!");
                        idAula = 0; codDisciplina = 0; codTurma = 0;
                        txtData.Text = "";
                        txtInicio.Text = "";
                        txtLocal.Text = "";
                        txtTermino.Text = "";
                        cmbSelectDisciplina.SelectedValue = -1;
                        cmbSelectTurma.SelectedValue = -1;
                        btnCadastrar.Text = "CADASTRAR";
                    }
                    else
                    {
                        MessageBox.Show("Erro alterar a aula!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: \n" + ex);
                }
            }
            
        }

        private void frmCadastroAula_Load(object sender, EventArgs e)
        {
            try
            {
                dataConsultaAula.ColumnCount = 7;
                dataConsultaAula.Rows.Clear();
                dataConsultaAula.ReadOnly = true;
                dataConsultaAula.Columns[0].Name = "Código da Aula";
                dataConsultaAula.Columns[1].Name = "Local";
                dataConsultaAula.Columns[2].Name = "Ínicio";
                dataConsultaAula.Columns[3].Name = "Término";
                dataConsultaAula.Columns[4].Name = "Data da Aula";
                dataConsultaAula.Columns[5].Name = "Código da Turma";
                dataConsultaAula.Columns[6].Name = "Código da Disciplina";

                CtrlAula objCtrlAula = new CtrlAula();

                foreach (Aula objAula in objCtrlAula.selecionarAula())
                {
                    dataConsultaAula.Rows.Add(
                    objAula.idAula.ToString(),
                    objAula.locall.ToString(),
                    objAula.horaInicio.ToString(),
                    objAula.horaTermino.ToString(),
                    objAula.dataAula.ToString(),
                    objAula.codTurma.ToString(),
                    objAula.codDisciplina.ToString()
                        );
                }
            }
            catch
            {
                MessageBox.Show("Não contém aula!");
            }
            
        }

        public void carregarComboTurma()
        {
            CtrlTurma Turma = new CtrlTurma();
            CtrlDisciplia Disciplina = new CtrlDisciplia();
            try
            {
                cmbSelectTurma.DataSource = Turma.preencherCombo();
                cmbSelectTurma.DisplayMember = "descricao";
                cmbSelectTurma.ValueMember = "idTurma";
                cmbSelectTurma.SelectedValue = -1;
                cmbSelectTurma.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dataConsultaAula.ColumnCount = 7;
                dataConsultaAula.Rows.Clear();
                dataConsultaAula.ReadOnly = true;
                dataConsultaAula.Columns[0].Name = "Código da Aula";
                dataConsultaAula.Columns[1].Name = "Local";
                dataConsultaAula.Columns[2].Name = "Ínicio";
                dataConsultaAula.Columns[3].Name = "Término";
                dataConsultaAula.Columns[4].Name = "Data da Aula";
                dataConsultaAula.Columns[5].Name = "Código da Turma";
                dataConsultaAula.Columns[6].Name = "Código da Disciplina";

                CtrlAula objCtrlAula = new CtrlAula();

                foreach (Aula objAula in objCtrlAula.selecionarAula())
                {
                    dataConsultaAula.Rows.Add(
                    objAula.idAula.ToString(),
                    objAula.locall.ToString(),
                    objAula.horaInicio.ToString(),
                    objAula.horaTermino.ToString(),
                    objAula.dataAula.ToString(),
                    objAula.codTurma.ToString(),
                    objAula.codDisciplina.ToString()
                        );
                }
            }
            catch
            {
                MessageBox.Show("Não contém aula!");
            }
        }

        private void btnExcuir_Click(object sender, EventArgs e)
        {
            try
            {
                Aula objAula = new Aula();
                CtrlAula objCtrlAula = new CtrlAula();
                objAula.idAula = idAula;
                if(objCtrlAula.Excluir(objAula, idAula))
                {
                    MessageBox.Show("Aula excluída com sucesso!");
                    idAula = 0;
                    txtData.Clear();
                    txtInicio.Clear();
                    txtLocal.Clear();
                    txtTermino.Clear();
                    cmbSelectDisciplina.SelectedValue = -1;
                    cmbSelectTurma.SelectedValue = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a aula!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
        }

        public void carregarComboDisciplina()
        {
            try
            {
                CtrlDisciplia Disciplina = new CtrlDisciplia();
                cmbSelectDisciplina.Refresh();
                cmbSelectDisciplina.DataSource = Disciplina.preencherComboBox();
                cmbSelectDisciplina.DisplayMember = "disciplina";
                cmbSelectDisciplina.ValueMember = "idDisciplina";
                cmbSelectDisciplina.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
        }


        private void dataConsultaAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Text = "SALVAR";
            idAula = Convert.ToInt32(dataConsultaAula.CurrentRow.Cells[0].Value.ToString());
            txtLocal.Text = dataConsultaAula.CurrentRow.Cells[1].Value.ToString();
            txtInicio.Text = dataConsultaAula.CurrentRow.Cells[2].Value.ToString();
            txtTermino.Text = dataConsultaAula.CurrentRow.Cells[3].Value.ToString();
            txtData.Text = dataConsultaAula.CurrentRow.Cells[4].Value.ToString();
            cmbSelectTurma.SelectedValue = Convert.ToInt32(dataConsultaAula.CurrentRow.Cells[5].Value.ToString());
            codTurma = Convert.ToInt32(dataConsultaAula.CurrentRow.Cells[5].Value.ToString());
            cmbSelectDisciplina.SelectedValue = Convert.ToInt32(dataConsultaAula.CurrentRow.Cells[6].Value.ToString());
            codDisciplina = Convert.ToInt32(dataConsultaAula.CurrentRow.Cells[6].Value.ToString());
        }
    }
    
}
