using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsCadastroProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            //adicionar ao banco
            string Produto = TextProduto.Text;
            double Qtde = double.Parse(TextQtde.Text);
            double vlu = double.Parse(TextVl.Text);
           

            //limpar as caixas de texto
            TextQtde.Clear();
            TextProduto.Clear();
            TextVl.Clear();


            dvg.Rows.Add(Produto, Qtde, vlu);
        }

        private void Box_produto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxVl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
           dvg.Rows.RemoveAt(dvg.CurrentRow.Index);

        }

        private void buttonqtde_Click(object sender, EventArgs e)
        {
            if (TextAlterar.Text !="")
            {
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextProdutoAlterar.Text != "")
            {

                dvg.CurrentRow.Cells["Produto"].Value = TextProdutoAlterar.Text;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextVlAlterar.Text != "")
            {
                

            }
        }
    }
}
