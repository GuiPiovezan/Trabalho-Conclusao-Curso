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
    public partial class frmCadastroUnidade : Form
    {
        int idUnidade = 0;
        public frmCadastroUnidade()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "CADASTRAR" && idUnidade==0)
            {
                try
                {
                    Unidade objUnidade = new Unidade();
                    CtrlUnidade objCtrlUnidade = new CtrlUnidade();
                    objUnidade.nomeUnidade = txtNomeUnidade.Text;
                    objUnidade.enderecoUnidade = txtEnderecoUnidade.Text;
                    objUnidade.emailUnidade = txtEmailUnidade.Text;
                    objUnidade.telefoneUnidade = txtTelefoneUnidade.Text;
                    if (objCtrlUnidade.Inserir(objUnidade))
                    {
                        MessageBox.Show("Unidade Escolar cadastrada com sucesso!");
                        txtNomeUnidade.Text = "";
                        txtEmailUnidade.Text = "";
                        txtEnderecoUnidade.Text = "";
                        txtTelefoneUnidade.Text = "";
                        atualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a unidade");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conexão database: \n" + ex);
                }
            }
            else if (btnCadastrar.Text == "SALVAR" && idUnidade!=0)
            {
                try
                {
                    Unidade objUnidade = new Unidade();
                    CtrlUnidade objCtrlUnidade = new CtrlUnidade();
                    objUnidade.idEscola = idUnidade;
                    objUnidade.nomeUnidade = txtNomeUnidade.Text;
                    objUnidade.emailUnidade = txtEmailUnidade.Text;
                    objUnidade.enderecoUnidade = txtEnderecoUnidade.Text;
                    objUnidade.telefoneUnidade = txtTelefoneUnidade.Text;
                    if(objCtrlUnidade.Alterar(objUnidade, idUnidade))
                    {
                        MessageBox.Show("Unidade alterada com sucesso!");
                        txtNomeUnidade.Text = "";
                        txtEmailUnidade.Text = "";
                        txtEnderecoUnidade.Text = "";
                        txtTelefoneUnidade.Text = "";
                        idUnidade = 0;
                        btnCadastrar.Text = "CADASTRAR";
                        atualizarLista();
                    }
                    else
                    {
                        MessageBox.Show("Problemas ao alterar a unidade!");
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
            CtrlUnidade objCtrlUnidade = new CtrlUnidade();
            dataConsultaUnidade.ColumnCount = 5;
            dataConsultaUnidade.Rows.Clear();
            dataConsultaUnidade.ReadOnly = true;
            dataConsultaUnidade.Columns[0].Name = "Código da Unidade";
            dataConsultaUnidade.Columns[1].Name = "Nome da Unidade";
            dataConsultaUnidade.Columns[2].Name = "E-mail";
            dataConsultaUnidade.Columns[3].Name = "Telefone";
            dataConsultaUnidade.Columns[4].Name = "Endereço";
            foreach (Unidade objUnidade in objCtrlUnidade.selecionarUnidades())
            {
                dataConsultaUnidade.Rows.Add
                    (
                    objUnidade.idEscola.ToString(),
                    objUnidade.nomeUnidade.ToString(),
                    objUnidade.emailUnidade.ToString(),
                    objUnidade.telefoneUnidade.ToString(),
                    objUnidade.enderecoUnidade.ToString()
                    );
            }
        }

        private void dataConsultaUnidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Text = "SALVAR";
            idUnidade = Convert.ToInt32(dataConsultaUnidade.CurrentRow.Cells[0].Value);
            txtNomeUnidade.Text = dataConsultaUnidade.CurrentRow.Cells[1].Value.ToString();
            txtEmailUnidade.Text = dataConsultaUnidade.CurrentRow.Cells[2].Value.ToString();
            txtTelefoneUnidade.Text = dataConsultaUnidade.CurrentRow.Cells[3].Value.ToString();
            txtEnderecoUnidade.Text = dataConsultaUnidade.CurrentRow.Cells[4].Value.ToString();
        }

        public void atualizarLista()
        {
            CtrlUnidade objCtrlUnidade = new CtrlUnidade();
            dataConsultaUnidade.ColumnCount = 5;
            dataConsultaUnidade.Rows.Clear();
            dataConsultaUnidade.ReadOnly = true;
            dataConsultaUnidade.Columns[0].Name = "Código da Unidade";
            dataConsultaUnidade.Columns[1].Name = "Nome da Unidade";
            dataConsultaUnidade.Columns[2].Name = "E-mail";
            dataConsultaUnidade.Columns[3].Name = "Telefone";
            dataConsultaUnidade.Columns[4].Name = "Endereço";
            foreach (Unidade objUnidade in objCtrlUnidade.selecionarUnidades())
            {
                dataConsultaUnidade.Rows.Add
                    (
                    objUnidade.idEscola.ToString(),
                    objUnidade.nomeUnidade.ToString(),
                    objUnidade.emailUnidade.ToString(),
                    objUnidade.telefoneUnidade.ToString(),
                    objUnidade.enderecoUnidade.ToString()
                    );
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Unidade objUnidade = new Unidade();
                CtrlUnidade objCtrlUnidade = new CtrlUnidade();
                objUnidade.idEscola = idUnidade;
                if (objCtrlUnidade.Excluir(objUnidade, idUnidade))
                {
                    MessageBox.Show("Unidade escolar excluída com sucesso!");
                    idUnidade = 0;
                    txtEmailUnidade.Clear();
                    txtEnderecoUnidade.Clear();
                    txtNomeUnidade.Clear();
                    txtTelefoneUnidade.Clear();
                    atualizarLista();
                }
                else
                {
                    MessageBox.Show("Falha ao tentar excluir a unidade escola!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: \n" + ex);
            }
            
        }
    }
}
