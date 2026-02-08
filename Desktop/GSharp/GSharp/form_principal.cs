using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GSharp.DeixarRoxo;

namespace GSharp
{

    public partial class form_principal : Form
    {

        public form_principal()
        {
            InitializeComponent();
        }

        private void menu_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void form_principal_Load(object sender, EventArgs e)
        {
            menu_principal.Renderer = new PurpleHoverRenderer();
        }

        private void cadastrar_cargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cargo>().Count() == 0)
            {
                form_cargo fCargo = new form_cargo();
                fCargo.MdiParent = this;
                fCargo.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_funcionario>().Count() == 0)
            {
                form_funcionario fFuncionario = new form_funcionario();
                fFuncionario.MdiParent = this;
                fFuncionario.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadastrar_cliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cliente>().Count() == 0)
            {
                form_cliente fCliente = new form_cliente();
                fCliente.MdiParent = this;
                fCliente.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cadastrar_marca_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_marca>().Count() == 0)
            {
                form_marca fMarca = new form_marca();
                fMarca.MdiParent = this;
                fMarca.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cadastrar_categoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_categoria>().Count() == 0)
            {
                form_categoria fCategoria = new form_categoria();
                fCategoria.MdiParent = this;
                fCategoria.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cadastrar_produto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_produto>().Count() == 0)
            {
                form_produto fProduto = new form_produto();
                fProduto.MdiParent = this;
                fProduto.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menu_consulta_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaFuncionario>().Count() == 0)
            {
                formConsultaFuncionario fConsultaFuncionario = new formConsultaFuncionario();
                fConsultaFuncionario.MdiParent = this;
                fConsultaFuncionario.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCargo>().Count() == 0)
            {
                formConsultaCargo fConsultaCargo = new formConsultaCargo();
                fConsultaCargo.MdiParent = this;
                fConsultaCargo.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCategoria>().Count() == 0)
            {
                formConsultaCategoria fConsultaCategoria = new formConsultaCategoria();
                fConsultaCategoria.MdiParent = this;
                fConsultaCategoria.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCliente>().Count() == 0)
            {
                formConsultaCliente fConsultaCliente = new formConsultaCliente();
                fConsultaCliente.MdiParent = this;
                fConsultaCliente.Show();
            }
           else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaMarca>().Count() == 0)
            {
                formConsultaMarca fConsultaMarca = new formConsultaMarca();
                fConsultaMarca.MdiParent = this;
                fConsultaMarca.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaProduto>().Count() == 0)
            {
                formConsultaProduto fConsultaProduto = new formConsultaProduto();
                fConsultaProduto.MdiParent = this;
                fConsultaProduto.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() == 0)
            {
                formRelFuncionario fRelFuncionario = new formRelFuncionario();
                fRelFuncionario.MdiParent = this;
                fRelFuncionario.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menu_vendas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formVenda>().Count() == 0)
            {
                formVenda fVenda = new formVenda();
                fVenda.MdiParent = this;
                fVenda.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_forma_pagamento>().Count() == 0)
            {
                form_forma_pagamento fFormaPagamento = new form_forma_pagamento();
                fFormaPagamento.MdiParent = this;
                fFormaPagamento.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formaDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormConsultaFormaPagamento>().Count() == 0)
            {
                FormConsultaFormaPagamento fConsultaFormaPagamento = new FormConsultaFormaPagamento();
                fConsultaFormaPagamento.MdiParent = this;
                fConsultaFormaPagamento.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelClientes>().Count() == 0)
            {
                formRelClientes fRelClientes = new formRelClientes();
                fRelClientes.MdiParent = this;
                fRelClientes.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelVendaDetalhado>().Count() == 0)
            {
                formRelVendaDetalhado fRelVenda = new formRelVendaDetalhado();
                fRelVenda.MdiParent = this;
                fRelVenda.Show();
            }
            else
            {
                MessageBox.Show("A janela já está aberta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
