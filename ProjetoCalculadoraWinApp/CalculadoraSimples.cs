namespace ProjetoCalculadoraWinApp
{
    public partial class CalculadoraSimples : Form
    {
        private const bool Falso = false;
        public string historico;

        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void BotaoCalcular(object sender, EventArgs e)
        {
            // ler valores do primeiro e segundo numeros.
            double primeiroNumero = Convert.ToDouble(txtPrimeiroNumero.Text);
            double segundoNumero = Convert.ToDouble(txtSegundoNumero.Text);

            // checagem da operação escolhida e calcular e imprimir na tela o resultado.
            double resultado = 0;

            if (rdbAdicao.Checked)
            {
                resultado = primeiroNumero + segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "+" + segundoNumero + "=" + resultado); //histórico de Operações.
            }
            if (rdbSubtracao.Checked)
            {
                resultado = primeiroNumero - segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "-" + segundoNumero + "=" + resultado); //histórico de Operações.
            }
            if (rdbMultiplicacao.Checked)
            {
                resultado = primeiroNumero * segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "*" + segundoNumero + "=" + resultado); //histórico de Operações.
            }
            if (rdbDivisao.Checked)
            {
                resultado = primeiroNumero / segundoNumero;
                ListaDeHistorico.Items.Add(primeiroNumero + "/" + segundoNumero + "=" + resultado); //histórico de Operações.
            }

            ////memsagem de erro, caso não digite um numero (em criação!)
            //if (PrimeiroNumero == 0)
            //{
            //    MessageBox.Show("Digite um número válido!");
            //}

        }
        // opção limpar tela.
        private void BotaoLimpar(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();
            txtResultado.Clear();
            rdbAdicao.Checked = true;
        }

        private void CalculadoraSimples_Load(object sender, EventArgs e) //mensagem de inicio da calculadora.
        {
            MessageBox.Show("Iniciar a Calculadora?");
        }

        private void LimparHistórico_Click(object sender, EventArgs e) //limpar histórico
        {
            ListaDeHistorico.Items.Clear();
        }
    }
}





