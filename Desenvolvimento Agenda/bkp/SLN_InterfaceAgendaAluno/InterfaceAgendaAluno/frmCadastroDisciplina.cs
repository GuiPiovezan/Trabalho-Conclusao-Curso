using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAgendaAluno
{
    public partial class frmCadastroDisciplina : Form
    {
        int idDisciplina = 0;
        public frmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "CADASTRAR" && idDisciplina ==0)
            {
                try
                {
                    Disciplina objDisciplina = new Disciplina();
                    CtrlDisciplia objCtrlDisciplina = new CtrlDisciplia();
                    objDisciplina.disciplina = txtDescricao.Text;
                    if (objCtrlDisciplina.Inserir(objDisciplina))
                    {
                        MessageBox.Show("Disciplina cadastrada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a disciplina");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro na conexão database: \n" + ex);
                }
            }
            else if(btnCadastrar.Text == "SALVAR" && idDisciplina!=0)
            {
                try
                {
                    Disciplina objDisciplina = new Disciplina();
                    CtrlDisciplia objCtrlDisciplina = new CtrlDisciplia();
                    objDisciplina.idDisciplina = idDisciplina;
                    objDisciplina.disciplina = txtDescricao.Text;
                    if(objCtrlDisciplina.Alterar(objDisciplina, idDisciplina))
                    {
                        MessageBox.Show("Disciplina alterado com sucesso!");
                        txtDescricao.Text = "";
                        idDisciplina = 0;
                        btnCadastrar.Text = "CADASTRAR";
                    }
                    else
                    {
                        MessageBox.Show("Falha ao realizar a alteração da disciplina!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro: \n" + ex);
                }
            }
            
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CtrlDisciplia objCtrlDisciplina = new CtrlDisciplia();
            dataConsultaDisciplina.ColumnCount = 2;
            dataConsultaDisciplina.Rows.Clear();
            dataConsultaDisciplina.ReadOnly = true;
            dataConsultaDisciplina.Columns[0].Name = "Código da disciplina";
            dataConsultaDisciplina.Columns[1].Name = "Disciplina";
            foreach (Disciplina objDisiciplina in objCtrlDisciplina.selecionarDisciplina())
            {
                dataConsultaDisciplina.Rows.Add(
                    objDisiciplina.idDisciplina.ToString(),
                    objDisiciplina.disciplina.ToString()                    
                    );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataConsultaDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Text = "SALVAR";
            idDisciplina = Convert.ToInt32(dataConsultaDisciplina.CurrentRow.Cells[0].Value);
            txtDescricao.Text = dataConsultaDisciplina.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Disciplina objDisciplina = new Disciplina();
                CtrlDisciplia objCtrlDisciplina = new CtrlDisciplia();
                objDisciplina.idDisciplina = idDisciplina;
                if(objCtrlDisciplina.Excluir(objDisciplina, idDisciplina))
                {
                    MessageBox.Show("Disciplina excluída com sucesso!");
                    txtDescricao.Clear();
                    idDisciplina = 0;
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a disciplina!");
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro: \n"+ex);
            }
        }
    }
}
