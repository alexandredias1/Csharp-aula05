using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_aula5
{
    public partial class Form1 : Form
    {
        public double acumulador;
        public double acumuladorqtd;
        public Form1()
        {
            InitializeComponent();
            acumulador = 0;
            acumuladorqtd = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtém o nome do item do TextBox
            string itemNome = textBox1.Text;

            // Verifica se a quantidade inserida é um número válido
            if (int.TryParse(textBox2.Text, out int qtd) && qtd > 0 && double.TryParse(textBox3.Text, out double valor))
            {
                // Adiciona o item e a quantidade à ListBox
                listBox1.Items.Add($"{itemNome} - Quantidade: {qtd} - RS{valor:F2}");


                acumulador += valor * qtd;
                acumuladorqtd += qtd;

                // Limpa os TextBox após adicionar
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (acumulador <= 30)
            {
                label6.Text = $"Total: R${acumulador:F2}";
            }
            else
            {
                MessageBox.Show("Limite de 30 livros por pedido excedido.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}