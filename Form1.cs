using System;
using System.Windows.Forms;

namespace BingoMaster
{
    public partial class Form1 : Form
    {
        // Criamos o gerador aqui fora para ele ser inicializado uma única vez
        Random gerador = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento do Botão Sortear
        private void btnSortear_Click(object sender, EventArgs e)
        {
            // 1. Pegar os valores dos inputs
            int min = (int)numMin.Value;
            int max = (int)numMax.Value;

            // 2. Validação de segurança
            if (min >= max)
            {
                MessageBox.Show("O valor mínimo deve ser menor que o máximo!", "Atenção");
                return;
            }

            // 3. Gerar o número (max + 1 para o valor máximo ser inclusivo)
            int resultado = gerador.Next(min, max + 1);

            // 4. Mostrar o resultado na Label principal
            lblResultado.Text = resultado.ToString();

            // 5. Adicionar ao histórico (no topo da lista)
            lstHistorico.Items.Insert(0, $"Número: {resultado}");
        }

        // Evento do Botão Limpar (Dê um duplo clique no botão Limpar no Design)
        

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            // Limpa todos os itens que foram adicionados à lista
            lstHistorico.Items.Clear();

            // Opcional: Volta o texto do resultado para o estado inicial
            lblResultado.Text = "--";

            // Opcional: Foca o cursor de volta no campo de número mínimo
            numMin.Focus();
        }
    }
}
