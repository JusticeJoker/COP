using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cop.Entidades
{
    public class Atleta : Pessoa
    {     
        // Construtor de Atleta
        public Atleta (string primeiroNome, string ultimoNome, DateTime dataNascimento, Generos genero, int numeroAtleta, DateTime anoInicioCarreira, int numeroMedalhasOuro, int numeroMedalhasPrata, int numeroMedalhasBronze, int numeroMedalhasOuroUltimosQuatroAnos, int numeroMedalhasPrataUltimosQuatroAnos, int numeroMedalhasBronzeUltimosQuatroAnos, bool lesionado, int altura, Modalidades modalidade) : base(primeiroNome, ultimoNome, dataNascimento, genero)
        {
            this.NumeroAtleta = numeroAtleta;
            this.AnoInicioCarreira = anoInicioCarreira;
            this.NumeroMedalhasOuro = numeroMedalhasOuro;
            this.NumeroMedalhasPrata = numeroMedalhasPrata;
            this.NumeroMedalhasBronze = numeroMedalhasBronze;
            this.NumeroMedalhasOuroUltimosQuatroAnos = numeroMedalhasOuroUltimosQuatroAnos;
            this.NumeroMedalhasPrataUltimosQuatroAnos = numeroMedalhasPrataUltimosQuatroAnos;
            this.NumeroMedalhasBronzeUltimosQuatroAnos = numeroMedalhasBronzeUltimosQuatroAnos;
            this.Lesionado = lesionado;
            this.Altura = altura;
            this.Modalidade = modalidade;
        }

        #region Propriedades

        public delegate bool ApuradoDelagate(Atleta atleta);

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o numero de atleta do Atleta.
        /// </summary>
        public int NumeroAtleta { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o ano de inicio de carreira do Atleta.
        /// </summary>
        public DateTime AnoInicioCarreira { get; set; }

        /// <summary>
        /// Esta propriedade calcula os Anos no ativo do Atleta em função da data de inicio de carreira.
        /// </summary>
        public int AnosAtivo
        {
            get
            {
                return DateTime.Now.Year - this.AnoInicioCarreira.Year;
            }
        }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de ouro do Atleta.
        /// </summary>
        public int NumeroMedalhasOuro { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de prata do Atleta.
        /// </summary>
        public int NumeroMedalhasPrata { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de bronze do Atleta.
        /// </summary>
        public int NumeroMedalhasBronze { get; set; }


        /// <summary>
        /// Esta propriedade calcula o número total de medalhas do Atleta.
        /// </summary>
        public int NumeroTotalMedalhas 
        {
            get
            {
                return NumeroMedalhasOuro + NumeroMedalhasPrata + NumeroMedalhasBronze;
            }
        }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de ouro obtidas nos ultimos 4 anos do Atleta.
        /// </summary>
        public int NumeroMedalhasOuroUltimosQuatroAnos { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de prata obtidas nos ultimos 4 anos do Atleta.
        /// </summary>
        public int NumeroMedalhasPrataUltimosQuatroAnos { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter o número de medalhas de bronze obtidas nos ultimos 4 anos do Atleta.
        /// </summary>
        public int NumeroMedalhasBronzeUltimosQuatroAnos { get; set; }

        /// <summary>
        /// Esta propriedade calcula o número de medalhas nos ultimos 4 anos do Atleta.
        /// </summary>
        public int NumeroMedalhasUltimosQuatroAnos
        {
            get
            {
                return NumeroMedalhasOuroUltimosQuatroAnos + NumeroMedalhasPrataUltimosQuatroAnos + NumeroMedalhasBronzeUltimosQuatroAnos;
            }
        }

        /// <summary>
        /// Consuma esta propriedade para defenir ou verificar se o atleta está lesionado.
        /// </summary>
        public bool Lesionado { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter a altura do atleta.
        /// </summary>
        public int Altura { get; set; }

        /// <summary>
        /// Consuma esta propriedade para defenir ou obter a modalidade do atleta.
        /// </summary>
        public Modalidades Modalidade { get; set; }

        public bool Apurado { get; set; }

        #endregion

        #region Métodos

        /// <summary>
        /// Este metodo verifica se o Atleta está apurado para os jogos olimpicos.
        /// </summary>
        /// <param name="apurado">Verificar se fica Apurado</param>
        /// <returns>Retorna o resultado do Apuramento</returns>
        public bool EApurado(ApuradoDelagate apurado)
        {
            if (apurado(this) == true)
                this.Apurado = true;
            else
                this.Apurado = false;
            return apurado(this);
        }

        /// <summary>
        /// Este método serve para alterar a mensagem apresentada no output do programa.
        /// </summary>
        /// <returns>String com os Dados do Atleta</returns>
        public override string ToString()
        {
            return $"\nNome: {this.PrimeiroNome} {this.UltimoNome}\nIdade: {this.Idade}\nAltura: {this.Altura}\nGenero: {this.Genero}\nLesionado: {this.Lesionado}\nNumero de Atleta: {this.NumeroAtleta}\nAnos no Ativo: {this.AnosAtivo}\nModalidade: {this.Modalidade}\nNumero total de medalhas: {this.NumeroTotalMedalhas}\nNumero total de medalhas de ouro: {this.NumeroMedalhasOuro}\nNumero total de medalhas de prata: {this.NumeroMedalhasPrata}\nNumero total de medalhas de bronze: {this.NumeroMedalhasBronze}\nNumero total de medalhas nos ultimos 4 anos: {this.NumeroMedalhasUltimosQuatroAnos}\nNumero de medalhas de ouro nos ultimos 4 anos: {this.NumeroMedalhasOuroUltimosQuatroAnos}\nNumero de medalhas de prata nos ultimos 4 anos: {this.NumeroMedalhasPrataUltimosQuatroAnos}\nNumero de medalhas de bronze nos ultimos 4 anos: {this.NumeroMedalhasBronzeUltimosQuatroAnos}\n";
        }

        #endregion
    }

}
