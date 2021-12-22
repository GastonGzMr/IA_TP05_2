using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_2
{
    public abstract class Estado
    {
        public bool[] Clausulas { get; set; }

        public Estado(bool[] clausulas)
        {
            Clausulas = clausulas;
        }

        public Estado(Estado padre1, Estado padre2)
        {
            Clausulas = new bool[padre1.Clausulas.Length];
            int medio = (int)Math.Round((double)padre1.Clausulas.Length / 2);
            for (int i = 0; i <= medio; i++)
            {
                Clausulas[i] = padre1.Clausulas[i];
            }
            for (int i = medio + 1; i < padre2.Clausulas.Length; i++)
            {
                Clausulas[i] = padre2.Clausulas[i];
            }
            Mutar();
        }

        public void Mutar()
        {
            Random random = new Random();
            Clausulas[random.Next(0, Clausulas.Length)] = (random.Next(-100,100) > 0);
        }

        public int ObtenerValor()
        {
            if (EjecutarClausula())
            {
                return Clausulas.Count(x => x);
            }
            else return 0;
        }

        public abstract bool EjecutarClausula();
    }
}
