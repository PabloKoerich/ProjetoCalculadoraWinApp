namespace ProjetoCalculadoraWinApp
{
    public partial class CalculadoraSimples : Form
    {
        public string historico;
        public string resultado;

        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void BotaoCalcular(object sender, EventArgs e)
        {
            // ler valores do primeiro e segundo numeros.
            double primeiroNumero = Convert.ToDouble(txtPrimeiroNumero.Text);
            double segundoNumero = Convert.ToDouble(txtSegundoNumero.Text);

            double resultado = 0;  // Imprimir na tela o resultado.

            // checagem da operação escolhida, calcular.
            if (rdbAdicao.Checked)
            {
                resultado = primeiroNumero + segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "+" + segundoNumero + "=" + resultado); //imprime a operação na lista de histórico.
            }
            if (rdbSubtracao.Checked)
            {
                resultado = primeiroNumero - segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "-" + segundoNumero + "=" + resultado); //imprime a operação na lista de histórico.
            }
            if (rdbMultiplicacao.Checked)
            {
                resultado = primeiroNumero * segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "*" + segundoNumero + "=" + resultado); //imprime a operação na lista de histórico.
            }
            if (rdbDivisao.Checked)
            {
                resultado = primeiroNumero / segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "/" + segundoNumero + "=" + resultado); //imprime a operação na lista de histórico.
            }
             
            txtResultado.Text = resultado.ToString(); //imprime resultado operação na tela 
        }

        // opção limpar tela.
        private void BotaoLimpar(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();
            txtResultado.Clear();
            rdbAdicao.Checked = true;
        }

        //limpar histórico
        private void LimparHistórico_Click(object sender, EventArgs e)
        {
            ListaDeHistorico.Items.Clear();
        }

                      //mensagem de inicio da calculadora.
        private void CalculadoraSimples_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja iniciar a calculadora?");
        }
    }
}