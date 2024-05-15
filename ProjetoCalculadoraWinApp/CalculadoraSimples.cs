namespace ProjetoCalculadoraWinApp
{
    public partial class CalculadoraSimples : Form
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void BotaoCalcular(object sender, EventArgs e)
        {
            // ler valores do primeiro e segundo numeros.
            double primeiroNumero = Convert.ToDouble(txtPrimeiroNumero.Text);
            double segundoNumero = Convert.ToDouble(txtSegundoNumero.Text);

            // checagem da opera��o escolhida.
            double resultado = 0;

            if (rdbAdicao.Checked)
                resultado = primeiroNumero + segundoNumero;

            if (rdbSubtracao.Checked)
                resultado = primeiroNumero - segundoNumero;

            if (rdbMultiplicacao.Checked)
                resultado = primeiroNumero * segundoNumero;

            if (rdbDivisao.Checked)
                resultado = primeiroNumero / segundoNumero;

            // calcular e imprimir na tela o resultado.
            txtResultado.Text = resultado.ToString();
        }

        private void BotaoLimpar(object sender, EventArgs e) // op��o limpar tela.
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();   
            txtResultado.Clear();   
            rdbAdicao.Checked = true;
        }
    }
}
