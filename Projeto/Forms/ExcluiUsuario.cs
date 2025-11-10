using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class ExcluiUsuario : Form
    {
        public ExcluiUsuario()
        {
            InitializeComponent();
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            string senha = TxtSenha.Text;

            DialogResult apagar = MessageBox.Show(
                "Essa ação não pode ser desfeita! Está certo disso?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (apagar == DialogResult.Yes && Conta.ExcluirConta(senha) == 1)
            {
                MessageBox.Show(
                        "Conta excluida com sucesso.",
                        "Excluida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                Sessao.UsuarioAtual!.Sair();
                Close();
            }
            else
                MessageBox.Show(
                        "Erro ao tentar excluir a conta, verifique a senha inserida.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
        }
    }
}
