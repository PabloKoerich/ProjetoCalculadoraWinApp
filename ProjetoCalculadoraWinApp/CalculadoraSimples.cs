namespace ProjetoCalculadoraWinApp
{
    public partial class CalculadoraSimples : Form
    {
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

            // checagem da operação escolhida.
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

            //if (rdbAdicao = Convert.ToString) false;
                    
            //    false && rdbSubtracao = false && rdbMultiplicacao = false && rdbDivisao = false);
            //{
            //    MessageBox.Show("Selecione uma operação!");
            //}

            // calcular e imprimir na tela o resultado.
            txtResultado.Text = resultado.ToString();
        }
        // opção limpar tela.
        private void BotaoLimpar(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();
            txtResultado.Clear();
            rdbAdicao.Checked = true;
        }

        private void CalculadoraSimples_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciar a Calculadora?");
        }

        //private void LimparHistorico(object sender, EventArgs e)
        //{
        //    ListaDeHistorico.Click += new EventHandler(BotaoLimpar);
        //}
    }
}





