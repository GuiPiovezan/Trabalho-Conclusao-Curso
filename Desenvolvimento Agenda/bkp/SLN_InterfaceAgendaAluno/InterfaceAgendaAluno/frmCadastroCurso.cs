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
    public partial class frmCadastroCurso : Form
    {
        int idCurso = 0;
        int idUnidade = 0;
        public frmCadastroCurso()
        {
            InitializeComponent();
            carregarCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            if(btnCadastrarCurso.Text == "CADASTRAR" && idCurso == 0)
            {
                try
                {
                    Curso objCurso = new Curso();
                    CtrlCurso objCtrlCurso = new CtrlCurso();
                    objCurso.descricao = txtDescricaoCurso.Text;
                    if (cmbSelecioneUnidade.SelectedItem != null)
                    {
                        int codUnidade = Convert.ToInt32(cmbSelecioneUnidade.SelectedValue);
                        objCurso.codUnidade = codUnidade;
                    }
                    else
                    {
                        MessageBox.Show("Selecione a unidade estudantil!");
                    }
                    if (cmbAno.SelectedIndex == 0)
                    {
                        objCurso.anoCurso = "2019";
                    }
                    else if (cmbAno.SelectedIndex == 1)
                    {
                        objCurso.anoCurso = "2020";
                    }
                    else
                    {
                        objCurso.anoCurso = "2021";
                    }
                    objCurso.coordenador = txtNomeCoordenador.Text;
                    if (cmbTipoCurso.SelectedIndex == 0)
                    {
                        objCurso.tipoCurso = "ETIM";
                    }
                    else if (cmbTipoCurso.SelectedIndex == 1)
                    {
                        objCurso.tipoCurso = "MEDTEC";
                    }
                    else if (cmbTipoCurso.SelectedIndex == 2)
                    {
                        objCurso.tipoCurso = "TECNICO";
                    }
                    else
                    {
                        MessageBox.Show("Selecione um tipo de curso!");
                    }

                    if (objCtrlCurso.Inserir(objCurso))
                    {
                        MessageBox.Show("Curso cadastrado com sucesso!");
                        txtDescricaoCurso.Text = "";
                        txtNomeCoordenador.Text = "";
                        cmbAno.SelectedValue = -1;
                        cmbSelecioneUnidade.SelectedValue = -1;
                        cmbTipoCurso.SelectedValue = -1;
                        atualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o curso!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão database: \n" + ex);
                }
            }
            else if(btnCadastrarCurso.Text == "SALVAR" && idCurso!=0)
            {
                try
                {
                    Curso objCurso = new Curso();
                    CtrlCurso objCtrlCurso = new CtrlCurso();
                    objCurso.idCurso = idCurso;
                    objCurso.descricao = txtDescricaoCurso.Text;
                    objCurso.anoCurso = cmbAno.SelectedText;
                    objCurso.tipoCurso = cmbTipoCurso.SelectedText;
                    objCurso.coordenador = txtNomeCoordenador.Text;
                    objCurso.codUnidade = idUnidade;
                    if (objCtrlCurso.Alterar(objCurso, idCurso))
                    {
                        MessageBox.Show("Curso alterado com sucesso!");
                        txtDescricaoCurso.Text = "";
                        txtNomeCoordenador.Text = "";
                        cmbAno.SelectedValue = -1;
                        cmbSelecioneUnidade.SelectedValue = -1;
                        cmbTipoCurso.SelectedValue = -1;
                        idCurso = 0;
                        idUnidade = 0;
                        btnCadastrarCurso.Text = "CADASTRAR";
                        atualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao alterar o curso!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: \n" + ex);
                }

            }
           
            
        }

        public void carregarCombo()
        {
            CtrlUnidade objCtrlUnidade = new CtrlUnidade();
            cmbSelecioneUnidade.DataSource = objCtrlUnidade.preencherComboBox();
            cmbSelecioneUnidade.DisplayMember = "nomeUnidade";
            cmbSelecioneUnidade.ValueMember = "idEscola";
            cmbSelecioneUnidade.SelectedValue = -1;
            cmbSelecioneUnidade.Refresh();
        }
        private void frmCadastroCurso_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataConsultaCurso.ColumnCount = 6;
            dataConsultaCurso.Rows.Clear();
            dataConsultaCurso.Refresh();
            dataConsultaCurso.ReadOnly = true;
            dataConsultaCurso.Columns[0].Name = "Código do curso";
            dataConsultaCurso.Columns[1].Name = "Descrição";
            dataConsultaCurso.Columns[2].Name = "Ano do Curso";
            dataConsultaCurso.Columns[3].Name = "Tipo de Curso";
            dataConsultaCurso.Columns[4].Name = "Coordenador";
            dataConsultaCurso.Columns[5].Name = "Código da Unidade";
            CtrlCurso objCtrlCurso = new CtrlCurso();
            foreach (Curso objCurso in objCtrlCurso.selecionarCurso())
            {
                dataConsultaCurso.Rows.Add(
                    objCurso.idCurso.ToString(),
                    objCurso.descricao.ToString(),
                    objCurso.anoCurso.ToString(),
                    objCurso.tipoCurso.ToString(),
                    objCurso.coordenador.ToString(),
                    objCurso.codUnidade.ToString()
                    );
            }
        }

        public void atualizarLista()
        {
            dataConsultaCurso.ColumnCount = 6;
            dataConsultaCurso.Rows.Clear();
            dataConsultaCurso.ReadOnly = true;
            dataConsultaCurso.Columns[0].Name = "Código do curso";
            dataConsultaCurso.Columns[1].Name = "Descrição";
            dataConsultaCurso.Columns[2].Name = "Ano do Curso";
            dataConsultaCurso.Columns[3].Name = "Tipo de Curso";
            dataConsultaCurso.Columns[4].Name = "Coordenador";
            dataConsultaCurso.Columns[5].Name = "Código da Unidade";
            CtrlCurso objCtrlCurso = new CtrlCurso();
            foreach (Curso objCurso in objCtrlCurso.selecionarCurso())
            {
                dataConsultaCurso.Rows.Add(
                    objCurso.idCurso.ToString(),
                    objCurso.descricao.ToString(),
                    objCurso.anoCurso.ToString(),
                    objCurso.tipoCurso.ToString(),
                    objCurso.coordenador.ToString(),
                    objCurso.codUnidade.ToString()
                    );
            }
        }

        private void dataConsultaCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrarCurso.Text = "SALVAR";
            idCurso = Convert.ToInt16(dataConsultaCurso.CurrentRow.Cells[0].Value);
            txtDescricaoCurso.Text = dataConsultaCurso.CurrentRow.Cells[1].Value.ToString();
            cmbAno.SelectedText = dataConsultaCurso.CurrentRow.Cells[2].Value.ToString();
            cmbTipoCurso.SelectedText = dataConsultaCurso.CurrentRow.Cells[3].Value.ToString();
            txtNomeCoordenador.Text = dataConsultaCurso.CurrentRow.Cells[4].Value.ToString();
            idUnidade = Convert.ToInt16(dataConsultaCurso.CurrentRow.Cells[5].Value);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Curso objCurso = new Curso();
                CtrlCurso objCtrlCurso = new CtrlCurso();
                objCurso.idCurso = idCurso;
                if(objCtrlCurso.Excluir(objCurso, idCurso))
                {
                    idCurso = 0;
                    MessageBox.Show("Curso excluído com sucesso!");
                    txtDescricaoCurso.Clear();
                    txtNomeCoordenador.Clear();
                    cmbAno.SelectedValue = -1;
                    cmbSelecioneUnidade.SelectedValue = -1;
                    cmbTipoCurso.SelectedValue = -1;
                    atualizarLista();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o curso!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro :\n" + ex);
            }
        }
    }
}
