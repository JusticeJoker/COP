using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop.Entidades
{
    public class EquipaTecnica
    {
        // var
        List<Fisioterapeuta> fisioterapeutas = new List<Fisioterapeuta>();
        List<PreparadorFisico> preparadorFisicos = new List<PreparadorFisico>();

        //  Construtor de Equipa Técnica
        public EquipaTecnica(int numeroEquipaTecnica, Qualidades qualidade, Modalidades modalidade)
        {
            this.NumeroEquipaTecnica = numeroEquipaTecnica;           
            this.Qualidade = qualidade;
            this.Modalidade = modalidade;
        }

        #region Propriedades
        
        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o numero de equipa tecnica.
        /// </summary>
        public int NumeroEquipaTecnica { get; set; }


        /// <summary>
        /// Consuma esta propriedade para defenir ou obter a qualidade da equipa técnica.
        /// </summary>
        public Qualidades Qualidade { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter a modalidade da equipa técnica.
        /// </summary>
        public Modalidades Modalidade { get; set; }

        /// <summary>
        /// Consuma esta propriedade para definir o médico da equipa técnica.
        /// </summary>
        public Medico Medico { get; set; }

        /// <summary>
        /// Consuma esta propriedade para definir o treinador da equipa técnica.
        /// </summary>
        public Treinador Treinador { get; set; }




        #endregion

        #region Metodos
        public void AdicionarFisioterapeuta(Fisioterapeuta fisioterapeuta)
        {
            fisioterapeutas.Add(fisioterapeuta);
        }


        public List<Fisioterapeuta> GetFisioterapeutas()
        {
            return fisioterapeutas;
        }


        public void AdicionarPreparadoreFisico(PreparadorFisico preparadorFisico)
        {
            preparadorFisicos.Add(preparadorFisico);
        }


        public List<PreparadorFisico> GetPreparadoreFisico()
        {
            return preparadorFisicos;
        }


        public override string ToString()
        {
            return $"\nNumero de Equipa Tecnica: {this.NumeroEquipaTecnica}\nModalidade: {this.Modalidade}\nQualidade: {this.Qualidade}\n";
        }

        #endregion
    }
}
