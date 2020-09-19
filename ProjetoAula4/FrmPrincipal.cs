using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula4
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        void ExibirFormulario(Form frm, bool permitirAbrirNovamente = false)
        {
            

            var fc = Application.OpenForms;

            if (!permitirAbrirNovamente)
            {
                foreach (Form item in fc)
                {
                    if (item.Name == frm.Name)
                    {
                        //se chegou ate aqui quer dizer que tem formulario aberto com mesmo nome
                        MessageBox.Show(this, "Este formulario ja esta aberto", "Alerta", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frm = new FrmCadastroAluno();
            ExibirFormulario(frm, false);
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditorTexto frm = new FrmEditorTexto();
            ExibirFormulario(frm, true);
        }
    }
}
