using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_2
{
    public class Estado2 : Estado
    {
        public Estado2(bool[] clausulas) : base(clausulas) { }

        public Estado2(Estado2 padre1, Estado2 padre2) : base(padre1, padre2) { }

        public override bool EjecutarClausula()
        {
            return ((Clausulas[3] || Clausulas[1] || Clausulas[2]) && (Clausulas[4] || Clausulas[0] || Clausulas[1]) &&
                    (Clausulas[4] || Clausulas[0] || !Clausulas[2]) && (Clausulas[2] || Clausulas[0] || Clausulas[1]) &&
                    (Clausulas[3] || Clausulas[0] || !Clausulas[2]) && (!Clausulas[4] || Clausulas[0] || Clausulas[3]));
        }
    }
}
