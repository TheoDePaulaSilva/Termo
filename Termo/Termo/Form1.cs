using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            c++;
            // A palavra que vai ser adivinhada
            string palavra = "TERMO";
            string tentativa;
            RichTextBox[] allText = new RichTextBox[5];
            for (int i = 0; i < 5; i++)
            {
                allText[i] = (this.Controls.Find($"richTextBox{i+1}", true).FirstOrDefault() as RichTextBox);
            }
            if (c <= 5)
            {
                tentativa = allText[c-1].Text.ToUpper();
                if (tentativa.Length != 5)
                {
                    label1.Text = "ERRO!! A palavra tem que ter 5 caracteres.";
                    c--;
                }
                else
                {
                    allText[c-1].ReadOnly = true;
                    label1.Text = "";
                    if (tentativa == palavra)
                    {
                        allText[c].ForeColor = Color.Green;
                        label1.Text = "Você acertou a palavra!!";
                        c = 6;
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (tentativa[i] == palavra[i])
                            {
                                allText[c - 1].Select(i, 1);
                                allText[c - 1].SelectionColor = Color.Green;
                            }
                            else
                            {
                                for (int x = 0; x < 5; x++)
                                {
                                    if (tentativa[i] == palavra[x])
                                    {
                                        allText[c - 1].Select(i, 1);
                                        allText[c - 1].SelectionColor = Color.Orange;
                                        break;
                                    }
                                    else
                                    {
                                        allText[c - 1].Select(i, 1);
                                        allText[c - 1].SelectionColor = Color.Red;
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

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            foreach (Control c in this.Controls)
            {
                if (c.Tag.ToString() == "Jogo")
                {
                    c.Visible = true;
                }
            }
        }
    }
}
