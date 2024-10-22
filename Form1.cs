namespace ArbolBinarioBusqueda
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol = new ArbolBinario();
        public Form1()
        {
            InitializeComponent();
        }

        private void DibujarArbol(Graphics g, Nodo nodo, int x, int y, int espacio)
        {
            if (nodo != null)
            {
                g.DrawEllipse(Pens.Black, x, y, 30, 30);
                g.DrawString(nodo.Valor.ToString(), this.Font, Brushes.Black, x + 10, y + 10);

                if (nodo.Izquierdo != null)
                {
                    g.DrawLine(Pens.Black, x + 15, y + 30, x - espacio + 15, y + 60);
                    DibujarArbol(g, nodo.Izquierdo, x - espacio, y + 60, espacio / 2);
                }

                if (nodo.Derecho != null)
                {
                    g.DrawLine(Pens.Black, x + 15, y + 30, x + espacio + 15, y + 60);
                    DibujarArbol(g, nodo.Derecho, x + espacio, y + 60, espacio / 2);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (arbol.Raiz != null)
            {
                DibujarArbol(e.Graphics, arbol.Raiz, picArbol.Width / 2, 10, picArbol.Width / 4);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValor.Text, out valor))
            {
                arbol.Insertar(valor);
                picArbol.Refresh();
            }
        }

        private void picArbol_Paint(object sender, PaintEventArgs e)
        {
            if (arbol.Raiz != null)
            {
                DibujarArbol(e.Graphics, arbol.Raiz, picArbol.Width / 2, 10, picArbol.Width / 4);
            }
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            List<int> recorrido = new List<int>();
            arbol.Preorden(arbol.Raiz, recorrido);
            lblResultado.Text = "Preorden: " + string.Join(", ",recorrido);
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            List<int> recorrido = new List<int>();
            arbol.Inorden(arbol.Raiz, recorrido);
            lblResultado.Text = "Inorden: " + string.Join(", ", recorrido);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            List<int> recorrido = new List<int>();
            arbol.Postorden(arbol.Raiz, recorrido);
            lblResultado.Text = "Postorden: " + string.Join(", ",recorrido);
        }
    }
}
