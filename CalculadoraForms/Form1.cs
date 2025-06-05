namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botão de Somar
        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);

            // Faz a soma
            double resultado = numero1 + numero2;

            lblResultado.Text = "RESULTADO: " + resultado.ToString();

            // Adiciona o Histórico da SOMA na operação
            AdicionarHistorico($"{numero1} + {numero2} = {resultado}");
        }

        // Botão de Subtrair
        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);

            double resultado = numero1 - numero2;

            lblResultado.Text = "RESULTADO: " + resultado.ToString();

            //  o Histórico da SUBTRAÇÃO na operação
            AdicionarHistorico($"{numero1} - {numero2} = {resultado}");
        }

        // Botão de Multiplicar
        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);

            double resultado = numero1 * numero2;

            lblResultado.Text = "RESULTADO: " + resultado.ToString();

            // Adiciona o Histórico da MULTIPLICAÇÃO na operação
            AdicionarHistorico($"{numero1} * {numero2} = {resultado}");
        }

        // Botão de Dividir
        private void btndividir_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            double numero1 = Convert.ToDouble(txtnumero1.Text);
            double numero2 = Convert.ToDouble(txtnumero2.Text);

            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                lblResultado.Text = "Resultado: " + resultado.ToString();
                AdicionarHistorico($"{numero1} / {numero2} = {resultado}");
            }

            else
            {
                MessageBox.Show("Não é possível dividir por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
         //  se o usuário preenchou os campos
        private bool ValidarEntradas()
        {
            if (string.IsNullOrWhiteSpace(txtnumero1.Text) || string.IsNullOrWhiteSpace(txtnumero2.Text))
            {
                MessageBox.Show("Por favor, preencha os dois números.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AdicionarHistorico(string operacao)
        {
            lstHistorico.Items.Add(operacao);
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstHistorico.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
