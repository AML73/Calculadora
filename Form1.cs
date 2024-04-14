using Microsoft.VisualBasic;
using System.Diagnostics;

namespace WF2
{
    public partial class Form1 : Form
    {
        private string Operador = "";
        private int ResultadoParcial = 0;
        //----------------------------------------------------------------------
        private void Calcular(string Operacion)
        {
            try
            {
                // Si el anterior operador fue el resultado, resetear el Operador:
                Operador = Operador == "=" ? "" : Operador;

                ResultadoParcial = Eval(ResultadoParcial + Operador + Display.Text);

                Operador = Operacion;

                Display.Text = "";
                dump.Text = ResultadoParcial + Operador;
                // Right padding basado en: https://stackoverflow.com/a/28075417
                dump.Text = dump.Text.PadRight(dump.Text.Length + 1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //----------------------------------------------------------------------
        static int Eval(String expression)
        {
            // Basado en: https://stackoverflow.com/a/25313985
            System.Data.DataTable table = new System.Data.DataTable();

            return Convert.ToInt32(table.Compute(expression, String.Empty));
        }
        //----------------------------------------------------------------------
        private void NumberInput(object sender, EventArgs e)
        {
            string Nme = ((Button)sender).Name;

            // Para que el siguiente número borre el resultado:
            if (Operador == "=")
            {
                Display.Text = "";
                Operador = "";
            }

            Display.Text += Nme[^1..]; // ^ es el "from end operator" y .. es el "range operator"
        }

        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calcular("+");
        }
        //----------------------------------------------------------------------
        private void Result_Click(object sender, EventArgs e)
        {
            Calcular("=");

            Display.Text = ResultadoParcial.ToString();
            ResultadoParcial = 0;
        }
        //----------------------------------------------------------------------
        private void btnSubs_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }
        //----------------------------------------------------------------------
        private void btnMult_Click(object sender, EventArgs e)
        {
            Calcular("*"); // El único problema es que se muestra "*" en vez del que está en el botón.
        }
        //----------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            dump.Text = "";
            ResultadoParcial = 0;
            Operador = "";
        }
        //----------------------------------------------------------------------
        private void btnDiv_Click(object sender, EventArgs e)
        {
            Calcular("/"); // El único problema es que se muestra "/" en vez del que está en el botón.
        }
        //----------------------------------------------------------------------
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Como los caracteres que se muestran no corresponden con los del
            // teclado, se toman los presionados y se los envía a los eventos
            // correctos.
            switch (e.KeyChar)
            {
                case '*':
                    btnMult_Click(sender, e);
                    break;

                case '/':
                    btnDiv_Click(sender, e);
                    break;

            }
        }
        //----------------------------------------------------------------------
        private void btnClearE_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }
    }
}
