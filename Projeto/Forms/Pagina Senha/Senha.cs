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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Senha_Load(object sender, EventArgs e) { }

        private void button_alterar_Click(object sender, EventArgs e)
        {
            string atual = TxtAtual.Text;
            string nova = Conta.HasharSenha(TxtNova.Text);

            Conta.AlterarSenha(atual, nova);
        }
    }
}
