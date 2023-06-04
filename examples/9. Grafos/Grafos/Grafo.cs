using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {
        public Vertice grafo;
        Vertice vertice;

        public void insertarVertice(int x)
        {
            Vertice p;
            if (grafo == null)
            {
                grafo = new Vertice();
                grafo.Info = x;
                grafo.EnlaceIzquierdo = null;
                grafo.EnlaceDerecho = null;
                grafo.EnlaceArco = null;
                vertice = grafo;
            }
            else
            {
                p = new Vertice();
                p.Info = x;
                p.EnlaceIzquierdo = vertice;
                p.EnlaceDerecho = null;
                p.EnlaceArco = null;
                vertice.EnlaceDerecho = p;
                vertice = p;
            }
        }
        public Vertice buscarVertice(int x)
        {
            Vertice p;
            p = grafo;
            while (p.Info != x)
                p = p.EnlaceDerecho;
            return p;
        }
        public void insertarArco(int x, int y)
        {
            Vertice p, q;
            Arco r,s;
            
            p = buscarVertice(x);
            q = buscarVertice(y);

            if(p.EnlaceArco == null)
            {
                r = new Arco();
                r.EnlaceVertice = q;
                r.EnlaceArco = null;
                p.EnlaceArco = r;
            }
            else
            {
                s = p.EnlaceArco;
                while (s.EnlaceArco != null)
                    s = s.EnlaceArco;
                r = new Arco();
                r.EnlaceVertice = q;
                r.EnlaceArco = null;
                s.EnlaceArco = r;
            }
        }

        public void eliminarArcosSaliendo(Vertice p)
        {
            Arco s, q;
            q = p.EnlaceArco;
            while(q != null)
            {
                s = q;
                q = q.EnlaceArco;
                p.EnlaceArco = q;
                s.EnlaceArco = null;
                s = null;
            }
        }

        public void eliminarArcosEntrando(Vertice p)
        {
            Vertice q;
            Arco r, s = new Arco();
            q = grafo;
            while(q != null)
            {
                r = q.EnlaceArco;
                while(r != null && r.EnlaceVertice != p)
                {
                    s = r;
                    r = r.EnlaceArco;
                }
                if(r != null)
                {
                    if(r == q.EnlaceArco)
                    {
                        q.EnlaceArco = r.EnlaceArco;
                        r.EnlaceArco = null;
                        r.EnlaceVertice = null;
                        r = null;
                    }
                    else
                    {
                        s.EnlaceArco = r.EnlaceArco;
                        r.EnlaceArco = null;
                        r.EnlaceVertice = null;
                        r = null;
                    }
                }
                q = q.EnlaceDerecho;
            }
        }

        public void eliminarVertice(Vertice p)
        {
            Vertice q;
            if (p == grafo)
            {
                grafo = grafo.EnlaceDerecho;
                p.EnlaceDerecho = null;
                p = null;
            }
            else
            {
                q = grafo;
                while(q.EnlaceDerecho != p)
                {
                    q = q.EnlaceDerecho;
                }
                q.EnlaceDerecho = p.EnlaceDerecho;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = null;
                p = null;
            }
        }
    }
}
