using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_2
{
    public class Estado1 : Estado 
    {
        public Estado1(bool[] clausulas) : base(clausulas) { }
        
        public Estado1(Estado1 padre1, Estado1 padre2) : base(padre1, padre2) { }
        
        public override bool EjecutarClausula()
        {
            return (Clausulas[0] || Clausulas[1]) && (Clausulas[0] || !Clausulas[1]) &&
                (!Clausulas[0] || Clausulas[1]) && (!Clausulas[0] || !Clausulas[1]);
        }
    }
}
