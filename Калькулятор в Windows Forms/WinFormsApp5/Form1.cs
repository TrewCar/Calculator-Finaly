using ConsoleApp6;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Enter_TextChanged(object sender, EventArgs e)
        {

        }
        private void A_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "1";
        }
        private void B_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "2";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "3";
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "4";
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "5";
        }
        private void Buttom6_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "6";
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "7";
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "8";
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "9";
        }
        private void Buttom0_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "0";
        }
        private void Plus_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " + ";
        }
        private void Minus_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " - ";
        }
        private void Del_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " / ";
        }
        private void Umn_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " * ";
        }
        private void Left_Skobka_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "( ";
        }
        private void Right_Skobka_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " )";
        }
        private void Cos_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "cos ";
        }
        private void Sin_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "sin ";
        }
        private void Tg_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "tg ";
        }
        private void Ctg_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "ctg ";
        }
        private void ClearRight_Click(object sender, EventArgs e)
        {
            try
            {
                string formula = Enter.Text;
                string result = formula.Substring(0, formula.LastIndexOf(' '));
                this.Enter.Clear();

                this.Enter.Text += result;
            }
            catch 
            {
                this.Enter.Clear();
            }                              
        }
        private void Clear_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Clear();
        }
        private void Pow_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += " ^ ";
        }
        private void Sqrt_Buttom_Click(object sender, EventArgs e)
        {
            string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("Введите степень корня " +
                "(не забудте добавить число под корнем потом) ", "Sqrt");

            this.Enter.Text += "sqrt "+ UserAnswer + " ";
        }
        private void Sqrt0_Buttom_Click(object sender, EventArgs e)
        {
            this.Enter.Text += "sqrt ";
        }
        private void Start_Click(object sender, EventArgs e)
        {
            X rool = new X();
            Random rand = new Random();

            string formula = Enter.Text;
            string[] _formula = formula.Split(' ');

            string[] err = new string[_formula.Length + 4];
            for (int i = 0; i < err.Length; i++)
            {
                if (i < 2 || i > _formula.Length + 1)
                    err[i] = "0";
                else
                    err[i] = _formula[i - 2];
            }

            err[0] = "0";
            err[1] = "+";
            err[err.Length - 1] = "0";
            err[err.Length - 2] = "+";
            try
            {
                double yy = rool.sect(err);

                this.Enter.Clear();
                this.Enter.Text += yy;
            }
            catch
            {
                MessageBox.Show("В формуле обнаружена ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void умножитьИДелитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если в уровнении есть на подобии такого : 4 * 3 ^ 2, нужно записать: 4 * ( 3 ^ 2 )");
        }

        private void кореньВ2СтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись происходит как обычный корень");
        }

        private void кореньВДругойСтепениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись происходит таким образом: sqrt 3 27, тоесть корень 3-ей степени из 27");
        }
    }
}