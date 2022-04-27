namespace Formulario
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> diccionario;
        public Form1()
        {
            InitializeComponent();
            this.diccionario = new Dictionary<string, int>();
       }
​
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.ContarPalabras();
            this.Mostrar();
​
        }
        public void ContarPalabras()
        {
            char [] separadores = { ' ', ',', '.', '\n' };
            string [] palabras = rtbTexto.Text.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
​
            foreach (string palabra in palabras)
            {
                if (!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario [palabra] += 1;
                }
            }
        }
        public  void Mostrar()
        {
            int i = 0;
            string palabraEncontrada = "";
            StringBuilder sb = new StringBuilder();
            while (i < 3)
            {
                foreach (KeyValuePair<string, int> item in this.diccionario)
                {
                    if (diccionario.Values.Max() == item.Value)
                    {
                        palabraEncontrada = item.Key;
                        sb.AppendLine($"{item.Key} {item.Value}");
                        break;
​
                    }
                }
                if (diccionario.Remove(palabraEncontrada))
                {
                    i++;
                }
            }
​
            MessageBox.Show(sb.ToString());
        }
    }
}