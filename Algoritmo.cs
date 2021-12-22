using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace IA_TP05_2
{
    class Algoritmo
    {
        public static Estado Resolver(ICollection<Estado> estadosIniciales)
        {
            List<Estado> estados = estadosIniciales.ToList();
            Estado hijo1;
            Estado hijo2;
            bool[] resultado;
            Random random = new Random();

            estados = estados.OrderBy(x => x.ObtenerValor()).ToList();
            Estado padre1 = estados[0];
            Estado padre2 = estados[1];
            resultado = new bool[padre1.Clausulas.Length];
            while ((estados.Count() < Math.Pow(2,padre1.Clausulas.Length)) && !padre1.EjecutarClausula())
            {
                hijo1 = (Estado)Activator.CreateInstance(padre1.GetType(), new Estado[] { padre1, padre2 });
                if ((estados.Where(x => SonDistintos(hijo1.Clausulas,x.Clausulas)).Count() == estados.Count()))
                {
                    estados.Add(hijo1);
                }

                hijo2 = (Estado)Activator.CreateInstance(padre2.GetType(), new Estado[] { padre2, padre1 });
                if ((estados.Where(x => SonDistintos(hijo2.Clausulas, x.Clausulas)).Count() == estados.Count()))
                {
                    estados.Add(hijo2);
                }

                estados = estados.OrderBy(x => x.ObtenerValor()).ToList();
                padre1 = estados[random.Next(0, estadosIniciales.Count())];
                padre2 = estados[random.Next(0, estadosIniciales.Count())];
            }

            if (padre1.EjecutarClausula())
            {
                return padre1;
            }

            else
            {
                return null;
            }
        }

        static bool SonDistintos(bool[] coleccion1, bool[] coleccion2)
        {
            for (int i = 0; i < coleccion1.Length; i++)
            {
                if (coleccion1[i] != coleccion2[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
