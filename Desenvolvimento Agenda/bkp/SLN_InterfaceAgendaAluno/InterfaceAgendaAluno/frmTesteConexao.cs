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
    public partial class frmTesteConexao : Form
    {
        public frmTesteConexao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            Conexao conecta = new Conexao();
            MessageBox.Show(conecta.testarConexao());
        }
    }
}
