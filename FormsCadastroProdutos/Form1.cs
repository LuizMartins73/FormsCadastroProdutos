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
        private double total;
        private double newtotal;
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
            if (double.TryParse(TextQtde.Text, out double quantidade) && double.TryParse(TextVl.Text, out double valorUnitario))
            {
                //adicionar ao banco
                string Produto = TextProduto.Text;
                double Qtde = double.Parse(TextQtde.Text);
                double vlu = double.Parse(TextVl.Text);
                double vlt = vlu * Qtde;

                total = vlt;
                newtotal = newtotal + total;
                label6.Text = newtotal.ToString("C");


                //limpar as caixas de texto
                TextQtde.Clear();
                TextProduto.Clear();
                TextVl.Clear();


                dvg.Rows.Add(Produto, Qtde, vlu, vlt);
            }
            else
            {
                MessageBox.Show("Erro! Certifique-se de inserir apenas valores numéricos. :)");
            }


        }

        private void Box_produto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxVl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnremover_Click(object sender, EventArgs e)
        {     
               
            double vlt = double.Parse(dvg.CurrentRow.Cells["Valor_Total"].Value.ToString());
  
            newtotal = newtotal -vlt;
            label6.Text = newtotal.ToString("C");


            dvg.Rows.RemoveAt(dvg.CurrentRow.Index);

            


        }

        private void buttonqtde_Click(object sender, EventArgs e)
        {
            if (TextAlterar.Text !="")
            {
                try
                {
                    double newQtde = double.Parse(TextAlterar.Text);
                    double vlu = double.Parse(dvg.CurrentRow.Cells["Valor_unit"].Value.ToString());
                    double Qtde = double.Parse(dvg.CurrentRow.Cells["Qtde"].Value.ToString());
                    double newvlt = vlu * newQtde;
                    double vlt = vlu * Qtde;

                    dvg.CurrentRow.Cells["Valor_Total"].Value = newvlt;
                    dvg.CurrentRow.Cells["Qtde"].Value = newQtde;

                    total = -vlt + newvlt;
                    newtotal = newtotal + total;
                    label6.Text = newtotal.ToString("C");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }           
        }
            else
            {
                MessageBox.Show("O campo de valor a alterar não pode estar vazio.");
            }
        }

                    

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextProdutoAlterar.Text != "")
            {

                dvg.CurrentRow.Cells["Produto"].Value = TextProdutoAlterar.Text;


            }
            else
            {
                MessageBox.Show("O campo de valor a alterar não pode estar vazio.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextVlAlterar.Text != "")
            {
                try
                {
                    
                    double newvlu = double.Parse(TextVlAlterar.Text);
                    double vlu = double.Parse(dvg.CurrentRow.Cells["Valor_unit"].Value.ToString());
                    double Qtde = double.Parse(dvg.CurrentRow.Cells["Qtde"].Value.ToString());
                    double newvlt = newvlu * Qtde;
                    double vlt = vlu * Qtde;
                   
                    dvg.CurrentRow.Cells["Valor_unit"].Value = newvlu.ToString();
                    dvg.CurrentRow.Cells["Valor_Total"].Value = newvlt.ToString();

                    total = -vlt + newvlt;
                    newtotal = newtotal + total;
                    label6.Text = newtotal.ToString("C");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("O campo de valor a alterar não pode estar vazio.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
