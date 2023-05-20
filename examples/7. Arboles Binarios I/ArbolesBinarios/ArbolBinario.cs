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
        public void crearArbolLexicografico(int x, Nodo padre)
        {
            Nodo p, q;
            Nodo aux = new Nodo();

            if(raiz == null)
            {
                raiz = new Nodo();
                raiz.Info = x;
                raiz.EnlaceIzquierdo = null;
                raiz.EnlaceDerecho = null;
                raiz.Padre = padre;
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
                //MessageBox.Show(aux.Info.ToString());
                if(x < aux.Info)
                {
                    q = new Nodo();
                    q.Info = x;
                    q.EnlaceIzquierdo = null;
                    q.EnlaceDerecho = null;
                    q.Padre = aux;
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
                        q.Padre = aux;
                        aux.EnlaceDerecho = q;
                    }
                }
            }
        }

        public void preOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                //MessageBox.Show(raiz.Info.ToString());
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
                        //MessageBox.Show(p.Info.ToString());
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
                //MessageBox.Show(raiz.Info.ToString());
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
                    //MessageBox.Show(pila[tope].Info.ToString());
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
                //MessageBox.Show(raiz.Info.ToString());
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
                        //MessageBox.Show(pila[tope].Info.ToString());
                        //
                        recorrido[topeRecorrido] = pila[tope].Info;
                        topeRecorrido++;
                        tope--;
                        //
                    }

                }
            }
        }
        public int altura(Nodo raiz)
        {

            int alturaDerecha = 0; int alturaIzquierda = 0;

            if(raiz == null) {
                return -1;
            }

            if(raiz.EnlaceDerecho != null) {
                alturaDerecha = altura(raiz.EnlaceDerecho);
            }

            if (raiz.EnlaceIzquierdo != null)
            {
                alturaIzquierda = altura(raiz.EnlaceIzquierdo);
            }

            int alturaHijos = Math.Max(alturaDerecha, alturaIzquierda);
            return alturaHijos + 1;
        }

        public Nodo buscarPadre(Nodo raiz, int x)
        {
            Nodo aux = null;
            if (raiz == null)
                return null;

            if (raiz.EnlaceIzquierdo != null)
                if (raiz.EnlaceIzquierdo.Info == x)
                    return raiz;
            if (raiz.EnlaceDerecho != null)
                if (raiz.EnlaceDerecho.Info == x)
                    return raiz;

            if (raiz.EnlaceIzquierdo != null && x < raiz.Info)
                aux = buscarPadre(raiz.EnlaceIzquierdo, x);
            if (raiz.EnlaceDerecho != null && x > raiz.Info)
                aux = buscarPadre(raiz.EnlaceDerecho, x);
            return aux;
        }

        public void eliminar(Nodo raiz, int x)
        {
            if (raiz == null)
                return;
            else if (x < raiz.Info)
                eliminar(raiz.EnlaceIzquierdo, x);
            else if (x > raiz.Info)
                eliminar(raiz.EnlaceDerecho, x);
            else
                eliminarNodo(raiz);
        }

        private Nodo minimoIzq(Nodo raiz)
        {
            if (raiz == null)
                return null;
            if (raiz.EnlaceIzquierdo != null)
                return minimoIzq(raiz.EnlaceIzquierdo);
            else
                return raiz;
        }
        
        private void reemplazar(Nodo raiz, Nodo newNodo)
        {
            //Nodo aux = buscarPadre(raiz, x);
            if(raiz.Padre != null)
            {
                if(raiz.Info == raiz.Padre.EnlaceIzquierdo.Info)
                    raiz.Padre.EnlaceIzquierdo = newNodo;
                else if (raiz.Info == raiz.Padre.EnlaceDerecho.Info)
                        raiz.Padre.EnlaceDerecho = newNodo;
            }
            if (newNodo != null)
                newNodo.Padre = raiz.Padre;
        }

        private void eliminarNodo(Nodo nodoEliminar)
        {
            if(nodoEliminar.EnlaceIzquierdo != null && nodoEliminar.EnlaceDerecho != null)
            {
                Nodo min = minimoIzq(nodoEliminar.EnlaceDerecho);
                nodoEliminar.Info = min.Info;
                eliminarNodo(min);
            }
            else if(nodoEliminar.EnlaceIzquierdo != null)
            {
                reemplazar(nodoEliminar, nodoEliminar.EnlaceIzquierdo);
                nodoEliminar.EnlaceIzquierdo = null;
                nodoEliminar.EnlaceDerecho = null;
                nodoEliminar = null;
            }
            else if (nodoEliminar.EnlaceDerecho != null)
            {
                reemplazar(nodoEliminar, nodoEliminar.EnlaceDerecho);
                nodoEliminar.EnlaceIzquierdo = null;
                nodoEliminar.EnlaceDerecho = null;
                nodoEliminar = null;
            }
            else
            {
                reemplazar(nodoEliminar, null);
                nodoEliminar.EnlaceIzquierdo = null;
                nodoEliminar.EnlaceDerecho = null;
                nodoEliminar = null;
            }
        }

        /*int NumeroNodosArbol(tArbol T)
        {
            int res;
            Pila P;
            Nodo m;

            res = 0;
            P = CrearPila(sizeof(nodo));

            m = Raiz(T);
            do
            {
                if (m != NODO_NULO)
                {
                    res++;
                    Push(&m, P);
                    m = HijoIzqda(m, T);
                }
                else if (!VaciaPila(P))
                {
                    Tope(&m, P);
                    Pop(P);
                    m = HermanoDrcha(m, T);
                }
            } while (!VaciaPila(P));

            DestruirPila(P);

            return res;

        }*/
        Nodo trabajo;
        public Nodo econtrarMinimo(Nodo raiz)
        {
            if (raiz == null)
                return null;
            trabajo = raiz;
            //int minimo = trabajo.Info;

            while (trabajo.EnlaceIzquierdo != null)
            {
                trabajo = trabajo.EnlaceIzquierdo;
                //minimo = trabajo.Info;
            }
            return trabajo;
        }
        Nodo padre;
        Nodo minimo;
        public Nodo borrar(Nodo nodo, int x)
        {
            if (nodo == null)
                return nodo;
            else if (x < nodo.Info)
                nodo.EnlaceIzquierdo = borrar(nodo.EnlaceIzquierdo, x);
            else if (x > nodo.Info)
                nodo.EnlaceDerecho = borrar(nodo.EnlaceDerecho, x);
            else
            {
                if(nodo.EnlaceIzquierdo == null && nodo.EnlaceDerecho == null)
                {
                    nodo = null;
                    return nodo;
                }
                else if(nodo.EnlaceIzquierdo == null)
                {
                    padre = buscarPadre(nodo, x);
                    padre.EnlaceDerecho = nodo.EnlaceDerecho;
                    return nodo;
                }
                else
                {
                    minimo = econtrarMinimo(nodo.EnlaceDerecho);
                    nodo.Info = minimo.Info;
                    nodo.EnlaceDerecho = borrar(nodo.EnlaceDerecho, minimo.Info);
                }
            }
            return nodo;
        }
        public int contarRamas(Nodo n)
        {
            if (n != null)
            {
                int izq = contarRamas(n.EnlaceIzquierdo);
                int der = contarRamas(n.EnlaceDerecho);
                return izq + der + 1;
            }
            else
            {
                return 0;
            }
            //return contador;
        }
        public int cant = 0;
        public void cantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.EnlaceDerecho == null && reco.EnlaceIzquierdo == null)
                {
                    cant++;
                }
                cantidadNodosHoja(reco.EnlaceIzquierdo);
                cantidadNodosHoja(reco.EnlaceDerecho);
            }
        }
        /*public void menorValor()
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                while (reco.getIzq() != null)
                {
                    reco = reco.getIzq();
                }
                System.out.println("Menor valor del árbol:" + reco.getDato());
            }
        }

        public void mayorValor()
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                while (reco.getDer() != null)
                {
                    reco = reco.getDer();
                }
                System.out.println("Mayor valor del árbol:" + reco.getDato());
            }
        }*/
        public int nivel = 0;
        public bool busqueda(Nodo raiz, int n)
        {
            if (raiz == null)
                return false;
            else if (raiz.Info == n)
            {
                nivel++;
                return true;
            }
            else if (n < raiz.Info)
            {
                nivel++;
                return busqueda(raiz.EnlaceIzquierdo, n);
            }

            else
            {
                nivel++;
                return busqueda(raiz.EnlaceDerecho, n);
            }
                
        }
        /*public bool Existe(int info)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (info == reco.info)
                    return true;
                else
                    if (info > reco.info)
                    reco = reco.der;
                else
                    reco = reco.izq;
            }
            return false;
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void Cantidad(Nodo reco)
        {
            if (reco != null)
            {
                cant++;
                Cantidad(reco.izq);
                Cantidad(reco.der);
            }
        }

        public int Cantidad()
        {
            cant = 0;
            Cantidad(raiz);
            return cant;
        }

        private void CantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.izq == null && reco.der == null)
                    cant++;
                CantidadNodosHoja(reco.izq);
                CantidadNodosHoja(reco.der);
            }
        }

        public int CantidadNodosHoja()
        {
            cant = 0;
            CantidadNodosHoja(raiz);
            return cant;
        }

        private void ImprimirEntreConNivel(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                ImprimirEntreConNivel(reco.izq, nivel + 1);
                Console.Write(reco.info + " (" + nivel + ") - ");
                ImprimirEntreConNivel(reco.der, nivel + 1);
            }
        }

        public void ImprimirEntreConNivel()
        {
            ImprimirEntreConNivel(raiz, 1);
            Console.WriteLine();
        }

        private void RetornarAltura(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                RetornarAltura(reco.izq, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                RetornarAltura(reco.der, nivel + 1);
            }
        }

        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(raiz, 1);
            return altura;
        }

        public void MayorValorl()
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                while (reco.der != null)
                    reco = reco.der;
                Console.WriteLine("Mayor valor del árbol:" + reco.info);
            }
        }

        public void BorrarMenor()
        {
            if (raiz != null)
            {
                if (raiz.izq == null)
                    raiz = raiz.der;
                else
                {
                    Nodo atras = raiz;
                    Nodo reco = raiz.izq;
                    while (reco.izq != null)
                    {
                        atras = reco;
                        reco = reco.izq;
                    }
                    atras.izq = reco.der;
                }
            }
        }*/
    }
}
