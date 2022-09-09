using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cop.Entidades;
using Cop.API;

namespace COP
{
    class Program
    {
        static void Main(string[] args)
        {

            //var
            string lerLetras;
            bool final = true;

            // Criar as Listas
            AtletaList atletas = new AtletaList();
            EquipaTecnicaList equipaTecnicas = new EquipaTecnicaList();

            // Atletas
            atletas.Add(new Atleta("André", "Silva", new DateTime(2000, 10, 16), Generos.Masculino, 1001, new DateTime(2009, 4, 12), 37, 49, 67, 6, 8, 11, false, 174, Modalidades.Natação));
            atletas.Add(new Atleta("José", "Ferreira", new DateTime(1999, 7, 3), Generos.Masculino, 1002, new DateTime(2007, 7, 5), 39, 27, 47, 7, 3, 2, false, 178, Modalidades.Canoagem));
            atletas.Add(new Atleta("Catarina", "Teixeira", new DateTime(2001, 1, 5), Generos.Feminino, 1003, new DateTime(2012, 11, 21), 8, 23, 39, 2, 4, 13, false, 168, Modalidades.GinásticaArtística));
            atletas.Add(new Atleta("Luis", "Neiva", new DateTime(1997, 5, 12), Generos.Masculino, 1004, new DateTime(2011, 9, 17), 17, 26, 50, 9, 4, 13, false, 188, Modalidades.Atletismo));
            atletas.Add(new Atleta("Gustavo", "Barros", new DateTime(1994, 7, 24), Generos.Masculino, 1005, new DateTime(2008, 6, 14), 70, 50, 12, 12, 14, 3, true, 197, Modalidades.Judo));
            atletas.Add(new Atleta("Maria", "Barbosa", new DateTime(1998, 12, 11), Generos.Feminino, 1006, new DateTime(2012, 11, 3), 36, 41, 50, 6, 11, 16, false, 162, Modalidades.Ténis));
            atletas.Add(new Atleta("Diogo", "Silva", new DateTime(2000, 10, 16), Generos.Masculino, 1007, new DateTime(2009, 4, 12), 37, 49, 67, 2, 8, 11, false, 174, Modalidades.Natação));
            atletas.Add(new Atleta("Fernando", "Ferreira", new DateTime(1999, 7, 3), Generos.Masculino, 1008, new DateTime(2007, 7, 5), 39, 27, 47, 7, 8, 2, false, 178, Modalidades.Canoagem));
            atletas.Add(new Atleta("Joana", "Teixeira", new DateTime(2001, 1, 5), Generos.Feminino, 1009, new DateTime(2012, 11, 21), 8, 23, 39, 9, 4, 13, false, 168, Modalidades.GinásticaArtística));
            atletas.Add(new Atleta("Flávio", "Neiva", new DateTime(1997, 5, 12), Generos.Masculino, 1010, new DateTime(2011, 9, 17), 17, 26, 50, 4, 4, 13, false, 188, Modalidades.Atletismo));
            atletas.Add(new Atleta("Fabio", "Barros", new DateTime(1994, 7, 24), Generos.Masculino, 1011, new DateTime(2008, 6, 14), 70, 50, 12, 7, 8, 3, false, 197, Modalidades.Judo));
            atletas.Add(new Atleta("Liliana", "Barbosa", new DateTime(1998, 12, 11), Generos.Feminino, 1012, new DateTime(2012, 11, 3), 36, 41, 50, 2, 6, 6, false, 162, Modalidades.Ténis));

            // Equipas Tecnicas
            equipaTecnicas.Add(new EquipaTecnica(3005, Qualidades.Alta, Modalidades.Atletismo));
            equipaTecnicas.Add(new EquipaTecnica(3002, Qualidades.Media, Modalidades.Judo));
            equipaTecnicas.Add(new EquipaTecnica(3001, Qualidades.Baixa, Modalidades.Ténis));
            equipaTecnicas.Add(new EquipaTecnica(3003, Qualidades.Alta, Modalidades.Canoagem));
            equipaTecnicas.Add(new EquipaTecnica(3004, Qualidades.Media, Modalidades.Natação));
            equipaTecnicas.Add(new EquipaTecnica(3006, Qualidades.Media, Modalidades.GinásticaArtística));

            // Membros das Equipas Tecnicas
            equipaTecnicas.Get(3006).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3006).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3006).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3006).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016, 5, 24), 2004));
            equipaTecnicas.Get(3006).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3006).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);

            equipaTecnicas.Get(3005).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3005).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3005).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3005).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016,5,24), 2004));
            equipaTecnicas.Get(3005).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3005).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);

            equipaTecnicas.Get(3004).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3004).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3004).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3004).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016, 5, 24), 2004));
            equipaTecnicas.Get(3004).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3004).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);

            equipaTecnicas.Get(3003).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3003).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3003).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3003).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016, 5, 24), 2004));
            equipaTecnicas.Get(3003).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3003).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);

            equipaTecnicas.Get(3002).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3002).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3002).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3002).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016, 5, 24), 2004));
            equipaTecnicas.Get(3002).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3002).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);

            equipaTecnicas.Get(3001).AdicionarFisioterapeuta(new Fisioterapeuta("Nuno", "Antunes", new DateTime(1979, 7, 12), Generos.Masculino, new DateTime(2004, 3, 1), 2001));
            equipaTecnicas.Get(3001).AdicionarFisioterapeuta(new Fisioterapeuta("Gonçalo", "Pereira", new DateTime(1987, 3, 23), Generos.Masculino, new DateTime(2009, 6, 29), 2002));
            equipaTecnicas.Get(3001).AdicionarPreparadoreFisico(new PreparadorFisico("Renato", "Dantas", new DateTime(1970, 12, 2), Generos.Masculino, new DateTime(1993, 9, 17), 2003));
            equipaTecnicas.Get(3001).AdicionarPreparadoreFisico(new PreparadorFisico("Vânia", "Araújo", new DateTime(1994, 1, 18), Generos.Feminino, new DateTime(2016, 5, 24), 2004));
            equipaTecnicas.Get(3001).Medico = new Medico("David", "Sivilar", new DateTime(1964, 3, 15), Generos.Masculino, new DateTime(1987, 8, 17), 2005);
            equipaTecnicas.Get(3001).Treinador = new Treinador("Fernando", "Rocha", new DateTime(1987, 5, 11), Generos.Masculino, new DateTime(2011, 8, 17), 2006);
                       
            // Interface da consola
            while (final)
            {
                Console.WriteLine("Insira:\n1)Atletas\n2)Equipas Tecnicas\n3)Atletas Apurados\nsair) Encerrar Programa\n");
                lerLetras = Console.ReadLine();
                switch (lerLetras)
                {
                    case "1":
                        // Escrever na consola os Atletas
                        Console.WriteLine("=============== Atletas ===============");
                        Mostra(atletas);
                        break;
                    case "2":
                        // Escrever na consola as Equipas Tecnicas e os seus respetivos membros
                        Console.WriteLine("============== Equipas Tecnicas ==============");
                        Mostra(equipaTecnicas);
                        break;
                    case "3":
                        // Escrever na consola os Atletas Apurados
                        Console.WriteLine("=============== Atletas Apurados ===============");
                        EscreveApurado(atletas);
                        break;
                    case "sair":
                        // Sair do programa
                        Console.WriteLine("\n============================\nSaindo do programa!\nPrima ENTER\n============================\n");
                        final = false;
                        break;
                    default:
                        // Lançar erro caso o utilizador insira uma opção invalida
                        Console.WriteLine("\n===============================\nNão escreveu uma opçao valida!\n===============================\n");
                        break;
                }
                
            }

            Console.ReadKey();
        }

        // Vereficar se o Atleta está apurado
        static bool VerificaApurado1(Atleta atleta)
        {
            // var
            bool aprovado = false;

            if (atleta.Lesionado)
                return false;
            if (((atleta.NumeroMedalhasOuroUltimosQuatroAnos * 5) + (atleta.NumeroMedalhasPrataUltimosQuatroAnos * 3) + (atleta.NumeroMedalhasBronzeUltimosQuatroAnos)) >= 50)
                return true;

            return aprovado;

        }

        static bool VerificaApurado2(Atleta atleta)
        {
            // var
            bool aprovado = false;

            if (atleta.Lesionado)
                return false;
            if (((atleta.NumeroMedalhasOuroUltimosQuatroAnos * 5) + (atleta.NumeroMedalhasPrataUltimosQuatroAnos * 3) + (atleta.NumeroMedalhasBronzeUltimosQuatroAnos)) >= 40)
                return true;

            return aprovado;

        }

        static bool VerificaApurado3(Atleta atleta)
        {
            // var
            bool aprovado = false;

            if (atleta.Lesionado)
                return false;
            if (((atleta.NumeroMedalhasOuroUltimosQuatroAnos * 5) + (atleta.NumeroMedalhasPrataUltimosQuatroAnos * 3) + (atleta.NumeroMedalhasBronzeUltimosQuatroAnos)) >= 60)
                return true;

            return aprovado;

        }

        // Apresentar os Atletas apurados
        static void EscreveApurado(AtletaList atletas)
        {
            foreach (Atleta atleta in atletas)
            {
                atleta.EApurado(new Atleta.ApuradoDelagate(VerificaApurado1));
                //Console.WriteLine(atleta.EApurado(new Atleta.ApuradoDelagate(VerificaApurado1)));
                if (atleta.Apurado == true)
                {
                    Console.WriteLine("================================================");
                    Console.WriteLine(atleta);                    
                }               
            }
        }

        // Função que mostra os Atletas
        static void Mostra(AtletaList atletas)
        {
            foreach (Atleta atleta in atletas)
            {                
                Console.WriteLine("=======================================");
                Console.WriteLine(atleta);                
            }
        }

        // Função que mostra as Equipas Tecnicas e os seus respetivos membros 
        static void Mostra(EquipaTecnicaList equipaTecnicas)
        {
            foreach (EquipaTecnica equipaTecnica in equipaTecnicas)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine(equipaTecnica);
                foreach (Fisioterapeuta fisioterapeuta in equipaTecnica.GetFisioterapeutas()) 
                {
                    Console.WriteLine($" -Fisioterapeuta: { fisioterapeuta }");
                }
                foreach (PreparadorFisico preparadorFisico in equipaTecnica.GetPreparadoreFisico())
                {
                    Console.WriteLine($" -Preparador Fisico: { preparadorFisico }");
                }
                Console.WriteLine($" -Medico: { equipaTecnica.Medico }");
                Console.WriteLine($" -Treinador: { equipaTecnica.Treinador }");
            }
        }
    }
}
