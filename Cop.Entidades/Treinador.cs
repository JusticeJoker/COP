using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop.Entidades
{
    public class Treinador : Pessoa
    {
        public Treinador(string primeiroNome, string ultimoNome, DateTime dataNascimento, Generos genero, DateTime anoInicioCarreira, int numeroStaff) : base(primeiroNome, ultimoNome, dataNascimento, genero)
        {
            this.AnoInicioCarreira = anoInicioCarreira;
            this.NumeroStaff = numeroStaff;
        }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o Ano de inicio de carreira.
        /// </summary>
        public DateTime AnoInicioCarreira { get; set; }

        /// <summary>
        /// Esta propriedade calcula os anos no ativo em função da data de inicio de carreira.
        /// </summary>
        public int AnosAtivo { get => DateTime.Now.Year - this.AnoInicioCarreira.Year; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o numero de staff.
        /// </summary>
        public int NumeroStaff { get; set; }

        public override string ToString()
        {
            return $"\nNome: {this.PrimeiroNome} {this.UltimoNome}\nIdade: {this.Idade}\nGenero: {this.Genero}\nNumero do membro da equipa tecnica: {this.NumeroStaff}\nAnos no Ativo: {this.AnosAtivo}\n";
        }

    }
}
