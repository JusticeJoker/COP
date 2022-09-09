using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop.Entidades
{
    public abstract class Pessoa
    {
        public Pessoa (string primeiroNome, string ultimoNome, DateTime dataNascimento, Generos genero)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.DataNascimento = dataNascimento;
            this.Genero = genero;
        }

        #region Propriedades
        /// <summary>
        /// Primeiro nome da pessoa.
        /// </summary>
        public string PrimeiroNome { get; set; }

        /// <summary>
        /// Ultimo nome da pessoa.
        /// </summary>
        public string UltimoNome { get; set; }

        /// <summary>
        /// Esta data representa a data de nascimento da pessoa.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Esta propriedade calcula a idade da pessoa em função da sua data de nascimento.
        /// </summary>
        public int Idade 
        {
            get 
            { 
                if ((DateTime.Now.Day >= this.DataNascimento.Day) && (DateTime.Now.Month >= this.DataNascimento.Month))
                    return DateTime.Now.Year - this.DataNascimento.Year;
                else
                    return DateTime.Now.Year - this.DataNascimento.Year - 1;
            }
        }

        /// <summary>
        /// Genero da pessoa.
        /// </summary>
        public Generos Genero { get; set; }

        #endregion
    }
}
