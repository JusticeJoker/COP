using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cop.Entidades;

namespace Cop.API
{
    public class AtletaList : List<Atleta>
    {
        List<Atleta> atletas = new List<Atleta>();

        public new void Add (Atleta atleta)
        {
            if (this.Exists(g => g.PrimeiroNome + g.UltimoNome == atleta.PrimeiroNome + atleta.UltimoNome))
                throw new Exception("Este atleta já existe na coleção!!");

            base.Add(atleta);
        }

        public new void Remove(Atleta atleta)
        {
            if (!Exists(g => g.PrimeiroNome + g.UltimoNome == atleta.PrimeiroNome + atleta.UltimoNome))
                throw new Exception("Este atleta não existe na coleção!!");
        }

        public Atleta Get(int numeroAtleta)
        {
            return this.FirstOrDefault(g => g.NumeroAtleta == numeroAtleta);
        }

        public List<Atleta> Get(string primeiroNome, string ultimoNome)
        {
            return this.Where(g => (g.PrimeiroNome.Contains(primeiroNome) && g.UltimoNome.Contains(ultimoNome))).ToList();
        }

        public List<Atleta> Get(Modalidades modalidade)
        {
            return this.Where(g => g.Modalidade.Equals(modalidade)).ToList();
        }


    }
}
