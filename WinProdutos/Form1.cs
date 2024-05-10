namespace WinProdutos
{
    public partial class Form1 : Form

    {
        private Models.Produto produto = new Models.Produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = int.Parse(txtQuantidade.Text);



                MessageBox.Show(produto.AdicionarProdutos(quantidade));

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro!! Entre com um valor válido.");
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int quantidade = int.Parse(txtQuantidade.Text);

                MessageBox.Show(produto.RemoverProdutos(quantidade));
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro!! Entre com um valor válido.");
            }
            
        }
    }
}
