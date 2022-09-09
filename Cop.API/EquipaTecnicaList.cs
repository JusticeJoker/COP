using Cop.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop.API
{
    public class EquipaTecnicaList : List<EquipaTecnica>
    {
        List<EquipaTecnica> equipaTecnicas = new List<EquipaTecnica>();

        public new void Add(EquipaTecnica equipaTecnica)
        {
            if (this.Exists(g => g.NumeroEquipaTecnica.Equals(equipaTecnica.NumeroEquipaTecnica)))
                throw new Exception("Este membro da equipa tecnica já existe na coleção!!");

            base.Add(equipaTecnica);
        }

        public new void Remove(EquipaTecnica equipaTecnica)
        {
            if (this.Exists(g => g.NumeroEquipaTecnica.Equals(equipaTecnica.NumeroEquipaTecnica)))
                throw new Exception("Este membro da equipa tecnica não existe na coleção!!");
        }

        public EquipaTecnica Get(int numeroEquipaTecnica)
        {
            return this.FirstOrDefault(g => g.NumeroEquipaTecnica == numeroEquipaTecnica);
        }


        public List<EquipaTecnica> Get(Modalidades modalidade)
        {
            return this.Where(g => g.Modalidade.Equals(modalidade)).ToList();
        }
    }
}
