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
            string palavra = "POSTE";
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
                    label1.ForeColor = Color.Red;
                    c--;
                }
                else
                {
                    allText[c-1].ReadOnly = true;
                    label1.Text = "";
                    if (tentativa == palavra)
                    {
                        allText[c-1].ForeColor = Color.Green;
                        label1.Text = "Você acertou a palavra!!";
                        label1.ForeColor = Color.Green;
                        button1.Enabled = false;
                        button1.BackColor = Color.DarkGreen;
                        button1.Text = palavra;
                        c = 10;
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
            if (c == 5)
            {
                label1.Text = "Você não acertou a palavra!! A palavra correta era";
                button1.Enabled = false;
                button1.Text = palavra;
                button1.BackColor = Color.IndianRed;
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
            foreach (Control c in this.Controls)
            {
                if (c.Tag.ToString() == "Jogo")
                {
                    c.Visible = true;
                }
                if (c.Tag.ToString() == "Inicio")
                {
                    c.Visible = false;
                }
            }
        }
    }
}
