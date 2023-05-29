using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios
{
    class ArbolBinario
    {
        public Nodo raiz;
        public int topeRecorrido = 0;
        public int[] recorrido = new int[50];

        //
        public NodoHilvanado raizHilvanado;
        public NodoHilvanado[] posicion = new NodoHilvanado[50];
        public int topeHilvanado = 0;

        //public Dictionary<int, int> map = new Dictionary<int, int>();
        public void crearArbolLexicografico(int x)
        {
            Nodo p, q;
            Nodo aux = new Nodo();

            if(raiz == null)
            {
                raiz = new Nodo();
                raiz.Info = x;
                raiz.EnlaceIzquierdo = null;
                raiz.EnlaceDerecho = null;
            }
            else
            {
                p = raiz;
                while(p != null)
                {
                    if(x < p.Info)
                    {
                        aux = p;
                        p = p.EnlaceIzquierdo;
                    }
                    else
                    {
                        if(x > p.Info)
                        {
                            aux = p;
                            p = p.EnlaceDerecho;
                        }
                    }
                }
                if(x < aux.Info)
                {
                    q = new Nodo();
                    q.Info = x;
                    q.EnlaceIzquierdo = null;
                    q.EnlaceDerecho = null;
                    aux.EnlaceIzquierdo = q;
                }
                else
                {
                    if(x > aux.Info)
                    {
                        q = new Nodo();
                        q.Info = x;
                        q.EnlaceIzquierdo = null;
                        q.EnlaceDerecho = null;
                        aux.EnlaceDerecho = q;
                    }
                }
            }
        }

        public void preOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                MessageBox.Show(raiz.Info.ToString());
                //
                recorrido[topeRecorrido] = raiz.Info;
                topeRecorrido++;
                //
                preOrdenRecursivo(raiz.EnlaceIzquierdo);
                preOrdenRecursivo(raiz.EnlaceDerecho);
            }
        }

        public void preOrden(Nodo raiz)
        {
            Nodo p;
            Nodo[] pila = new Nodo[30];
            int tope = 0;

            if(raiz != null)
            {
                p = raiz;
                while(p != null ||tope > 0)
                {
                    while(p != null)
                    {
                        MessageBox.Show(p.Info.ToString());
                        //
                        recorrido[topeRecorrido] = p.Info;
                        topeRecorrido++;
                        //
                        tope++;
                        pila[tope] = p;
                        p = p.EnlaceIzquierdo;
                    }
                    p = pila[tope].EnlaceDerecho;
                    tope--;
                }
            }
        }

        public void entreOrdenRecursivo(Nodo raiz)
        {
            if (raiz != null)
            {
                entreOrdenRecursivo(raiz.EnlaceIzquierdo);
                MessageBox.Show(raiz.Info.ToString());
                //
                recorrido[topeRecorrido] = raiz.Info;
                topeRecorrido++;
                //
                entreOrdenRecursivo(raiz.EnlaceDerecho);
            }
        }

        public void entreOrden(Nodo raiz)
        {
            Nodo p;
            Nodo[] pila = new Nodo[30];
            int tope = 0;

            if (raiz != null)
            {
                p = raiz;
                while(p!=null || tope != 0)
                {
                    while(p != null)
                    {
                        tope++;
                        pila[tope] = p;
                        p = p.EnlaceIzquierdo;
                    }
                    //
                    recorrido[topeRecorrido] = pila[tope].Info;
                    topeRecorrido++;
                    //
                    MessageBox.Show(pila[tope].Info.ToString());
                    p = pila[tope].EnlaceDerecho;
                    tope--;
                } 
            }
        }

        public void postOrdenRecursivo(Nodo raiz)
        {
            if (raiz != null)
            {
                postOrdenRecursivo(raiz.EnlaceIzquierdo);
                postOrdenRecursivo(raiz.EnlaceDerecho);
                MessageBox.Show(raiz.Info.ToString());
                //
                recorrido[topeRecorrido] = raiz.Info;
                topeRecorrido++;
                //
                
            }
        }

        public void postOrden(Nodo raiz)
        {
            Nodo p;
            Nodo[] pila = new Nodo[30];
            int[] posicion = new int[30];
            int tope = 0;

            if(raiz != null)
            {
                p = raiz;
                while(p!=null || tope !=0)
                {
                    while(p!=null)
                    {
                        tope++;
                        pila[tope] = p;
                        posicion[tope] = 0;
                        p = p.EnlaceIzquierdo;
                    }
                    if(posicion[tope] == 0)
                    {
                        posicion[tope] = 1;
                        p = pila[tope].EnlaceDerecho;
                    }
                    else
                    {
                        MessageBox.Show(pila[tope].Info.ToString());
                        //
                        recorrido[topeRecorrido] = pila[tope].Info;
                        topeRecorrido++;
                        //
                        tope--;
                    }

                }

            }
        }

        public void crearArbolLexicograficoHilvanado(int x)
        {
            NodoHilvanado p, q;
            NodoHilvanado aux = new NodoHilvanado();

            if (raizHilvanado == null)
            {
                raizHilvanado = new NodoHilvanado();
                raizHilvanado.Info = x;
                //map.Add(raizHilvanado.Info, 0);
                raizHilvanado.EnlaceIzquierdo = null;
                raizHilvanado.EnlaceDerecho = null;
            }
            else
            {
                p = raizHilvanado;
                while (p != null)
                {
                    if (x < p.Info)
                    {
                        aux = p;
                        p = p.EnlaceIzquierdo;
                    }
                    else
                    {
                        if (x > p.Info)
                        {
                            aux = p;
                            p = p.EnlaceDerecho;
                        }
                    }
                }
                if (x < aux.Info)
                {
                    q = new NodoHilvanado();
                    q.Info = x;
                    q.EnlaceIzquierdo = null;
                    q.EnlaceDerecho = null;
                    aux.EnlaceIzquierdo = q;
                }
                else
                {
                    if (x > aux.Info)
                    {
                        q = new NodoHilvanado();
                        q.Info = x;
                        q.EnlaceIzquierdo = null;
                        q.EnlaceDerecho = null;
                        aux.EnlaceDerecho = q;
                    }
                }
            }
        }

        public void entreOrdenHilvanado(NodoHilvanado raiz)
        {
            if (raiz != null)
            {
                entreOrdenHilvanado(raiz.EnlaceIzquierdo);
                //
                topeHilvanado++;
                posicion[topeHilvanado] = raiz;
                //
                entreOrdenHilvanado(raiz.EnlaceDerecho);
            }
        }

        public void hilvanar(NodoHilvanado raizHilvanado)
        {
            if(raizHilvanado != null)
            {
                entreOrdenHilvanado(raizHilvanado);
                for(int j=1; j<=topeHilvanado; j++)
                {
                    MessageBox.Show(posicion[j].Info.ToString());
                    if (posicion[j].EnlaceIzquierdo == null)
                    {
                        if(j!=1)
                        {
                            posicion[j].EnlaceIzquierdo = posicion[j - 1];
                            posicion[j].IndicadorIzquierdo = false;
                        }
                        else
                            posicion[j].IndicadorIzquierdo = true;
                    }
                    else
                        posicion[j].IndicadorIzquierdo = true;
                    if (posicion[j].EnlaceDerecho == null)
                    {
                        if (j != topeHilvanado)
                        {
                            
                            posicion[j].EnlaceDerecho = posicion[j + 1];
                            posicion[j].IndicadorDerecho = false;
                        }
                        else
                            posicion[j].IndicadorDerecho = true;
                    }
                    else
                        posicion[j].IndicadorDerecho = true;
                }
                MessageBox.Show("El árbol esta hilvanado");
            }
        }
        public void preOrdenHilvanado(NodoHilvanado raiz)
        {
            NodoHilvanado p;

            int[] aux = new int[30];

            var map = new Dictionary<int , int>();
            
            if (raiz != null)
            {
                p = raiz;

                recorrido[topeRecorrido] = p.Info;
                topeRecorrido++;
                map.Add(p.Info, 1);

                while (p.EnlaceDerecho != null)
                {
                    if (p.IndicadorIzquierdo && p.EnlaceIzquierdo != null)
                    {

                        p.IndicadorIzquierdo = false;
                        p = p.EnlaceIzquierdo;
                    }
                    else
                    {

                        p.IndicadorDerecho = false;
                        p = p.EnlaceDerecho;
                    }
                    if (!map.ContainsKey(p.Info))
                    {
                        map.Add(p.Info, 1);
                        recorrido[topeRecorrido] = p.Info;
                        topeRecorrido++;
                    }
                }
                    //while ((p != null && p.IndicadorDerecho || p != null && p.IndicadorIzquierdo) || tope > 0)
                    //{
                    //    while (p != null && p.IndicadorIzquierdo)
                    //    {

                    //        MessageBox.Show(p.Info.ToString());
                    //        //
                    //        recorrido[topeRecorrido] = p.Info;
                    //        topeRecorrido++;
                    //        //
                    //        tope++;
                    //        pila[tope] = p;
                    //        p = p.EnlaceIzquierdo;
                    //    }
                    //    if (pila[tope].IndicadorDerecho && pila[tope].EnlaceDerecho != null)
                    //    {
                    //        p = pila[tope].EnlaceDerecho;
                    //        //p.IndicadorIzquierdo = false;
                    //        /*if(!p.IndicadorDerecho && !p.IndicadorIzquierdo)
                    //        {*/
                    //            MessageBox.Show(p.Info.ToString());
                    //            //
                    //            recorrido[topeRecorrido] = p.Info;
                    //            topeRecorrido++;
                    //        //}
                    //        //tope--;
                    //        //tope++;
                    //        pila[tope] = p;
                    //        //p = p.EnlaceIzquierdo;
                    //    }
                    //    else
                    //    {
                    //        //tope--;
                    //        if(pila[tope].EnlaceDerecho != null)
                    //        {
                    //            p = pila[tope].EnlaceDerecho;
                    //            p.IndicadorIzquierdo = false;
                    //            tope--;
                    //        }
                    //        else
                    //        {
                    //            p = null;
                    //            tope = 0;
                    //        }
                    //    }
                    //}
                }
        }

        public void entreOrdenRecursivoHilvanado(NodoHilvanado raiz)
        {
            for(int j = 1; j <= topeHilvanado; j++)
            {
                recorrido[topeRecorrido] = posicion[j].Info;
                topeRecorrido++;
            }
        }
        public void posOrdenRecursivoHilvanado(NodoHilvanado raiz)
        {
            for (int j = 1; j <= topeHilvanado; j++)
            {
                recorrido[topeRecorrido] = posicion[j].Info;
                topeRecorrido++;
            }
        }
    }
}
