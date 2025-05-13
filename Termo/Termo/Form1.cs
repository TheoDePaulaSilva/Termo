namespace Termo
{
    public partial class Form1 : Form
    {
        private int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = "ADOLF";
            string tentativa;
            RichTextBox textAtual;
            c++;
            if (c < 5)
            {
                textAtual = (this.Controls.Find($"richTextBox{c}", true).FirstOrDefault() as RichTextBox);
                tentativa = (this.Controls.Find($"richTextBox{c}", true).FirstOrDefault() as RichTextBox).Text;
                tentativa = tentativa.ToUpper();
                if (tentativa.Length != 5)
                {
                    label1.Text = "ERRO!! A palavra tem que ter 5 caracteres.";
                    c--;
                }
                else
                {
                    textAtual.ReadOnly = true;
                    label1.Text = "";
                    if (tentativa == palavra)
                    {
                        textAtual.ForeColor = Color.Green;
                        label1.Text = "Você acertou a palavra!!";
                        c = 5;
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (tentativa[i] == palavra[i])
                            {
                                textAtual.Select(i, 1);
                                textAtual.SelectionColor = Color.Green;
                            }
                            else
                            {
                                for (int x = 0; x < 5; x++)
                                {
                                    if (tentativa[i] == palavra[x])
                                    {
                                        textAtual.Select(i, 1);
                                        textAtual.SelectionColor = Color.Orange;
                                        break;
                                    }
                                    else
                                    {
                                        textAtual.Select(i, 1);
                                        textAtual.SelectionColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
