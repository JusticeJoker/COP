using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cop.Entidades;

namespace Cop.API
{
    class AtletaApuradoList : List<Atleta>
    {
        List<Atleta> atletasapurados = new List<Atleta>();

        public new void Add(Atleta atleta)
        {
            if (this.Exists(g => g.PrimeiroNome + g.UltimoNome == atleta.PrimeiroNome + atleta.UltimoNome))
                throw new Exception("Este atleta já existe na coleção!!");

            base.Add(atleta);
        }
    }
}
