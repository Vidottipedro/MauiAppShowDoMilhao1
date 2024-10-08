﻿using MauiAppShowDoMilhao1.Models;

namespace MauiAppShowDoMilhao1
{
    public partial class App : Application
    {


        static List<Pergunta> perguntas_faceis = new()
        static List<Pergunta> perguntas_medias = new()
        static List<Pergunta> perguntas_sorteadas = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo? ",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa { Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa { Correta = false, Descricao = "GASOSO"},
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"},
                }

            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa { Correta = true, Descricao = "MINNIE"},
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa { Correta = false, Descricao = "OLÍVIA PALITO"},
                }

            },
            new Pergunta
            {
                Id =3,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "CUCA"},
                    new Alternativa { Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa { Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa { Correta = true, Descricao = "SACI-PERERE"},
                }
            },
            new Pergunta
            {
                Id= 4,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAMAICA"},
                    new Alternativa { Correta = true, Descricao = "CUBA"},
                    new Alternativa { Correta = false, Descricao = "EL SALVADOR"},
                    new Alternativa { Correta = false, Descricao = "MÉXICO"},
                }
            },
            new Pergunta
            {
                Id=5,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL RODON"},
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=6,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "BARÃO DE MAUA"},
                    new Alternativa { Correta = true, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa { Correta = false, Descricao = "MARQUES POMBAL"},
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id=7,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativa = new()
                {
                    new Alternativa { Correta = true, Descricao = "ROMEU"},
                    new Alternativa { Correta = false, Descricao = "ORFEU"},
                    new Alternativa { Correta = false, Descricao = "HAMLET"},
                    new Alternativa { Correta = false, Descricao = "IAGO"},
                }
            },
            new Pergunta
            {
                Id=8,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativa = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARANA"},
                    new Alternativa { Correta = false, Descricao = "MSANTA CATARINA"},
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO"},
                    new Alternativa { Correta = true, Descricao = "BAHIA"},
                }
            },
            new Pergunta
            {
                Id=9,
                Enunciado = "Como se chama o lugar onde são armazenadas as balas de um revólver",
                Alternativa = new()
                {
                    new Alternativa { Correta = true, Descricao = "TAMBOR"},
                    new Alternativa { Correta = false, Descricao = "CANO"},
                    new Alternativa { Correta = false, Descricao = "AGULHA"},
                    new Alternativa { Correta = false, Descricao = "GATILHO"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Quem é o autor de 'Dom Casmurro'?",
                Alternativa = new()
                {
                 new Alternativa { Correta = false, Descricao = "JOSÉ DE ALENCAR" },
                 new Alternativa { Correta = false, Descricao = "MANUEL BANDEIRA" },
                 new Alternativa { Correta = false, Descricao = "MACHADO DE ASSIS" },
                 new Alternativa { Correta = true, Descricao = "MACHADO DE ASSIS" },
                }
            },

            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é o planeta mais próximo do Sol?",
                Alternativa = new()
                {
                 new Alternativa { Correta = false, Descricao = "VÊNUS" },
                 new Alternativa { Correta = false, Descricao = "TERRA" },
                 new Alternativa { Correta = false, Descricao = "MARTE" },
                 new Alternativa { Correta = true, Descricao = "MERCÚRIO" },
                }
            },

            new Pergunta
            {
               Id = 14,
               Enunciado = "Qual é o maior oceano do mundo?",
               Alternativa = new()
               {
                   new Alternativa { Correta = false, Descricao = "OCEANO ATLÂNTICO" },
                   new Alternativa { Correta = false, Descricao = "OCEANO ÁRTICO" },
                   new Alternativa { Correta = false, Descricao = "OCEANO ANTÁRTICO" },
                   new Alternativa { Correta = true, Descricao = "OCEANO PACÍFICO" },
               }
},

new Pergunta
{
    Id = 15,
    Enunciado = "Qual é o símbolo químico do ouro?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Au" },
        new Alternativa { Correta = false, Descricao = "Ag" },
        new Alternativa { Correta = false, Descricao = "Fe" },
        new Alternativa { Correta = true, Descricao = "Au" },
    }
},

new Pergunta
{
    Id = 16,
    Enunciado = "Qual é a língua oficial do Japão?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "CHINÊS" },
        new Alternativa { Correta = false, Descricao = "COREANO" },
        new Alternativa { Correta = true, Descricao = "JAPONÊS" },
    }
},

new Pergunta
{
    Id = 17,
    Enunciado = "Qual é o maior mamífero terrestre?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "ELEFANTE AFRICANO" },
        new Alternativa { Correta = false, Descricao = "BISONTE" },
        new Alternativa { Correta = false, Descricao = "RINOCERONTE" },
        new Alternativa { Correta = true, Descricao = "ELEFANTE AFRICANO" },
    }
},

new Pergunta
{
    Id = 18,
    Enunciado = "Quem pintou a Mona Lisa?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "VINCENT VAN GOGH" },
        new Alternativa { Correta = false, Descricao = "CLAUDE MONET" },
        new Alternativa { Correta = false, Descricao = "PABLO PICASSO" },
        new Alternativa { Correta = true, Descricao = "LEONARDO DA VINCI" },
    }
},

new Pergunta
{
    Id = 19,
    Enunciado = "Qual é a fórmula da água?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "H2O2" },
        new Alternativa { Correta = false, Descricao = "CO2" },
        new Alternativa { Correta = false, Descricao = "CH4" },
        new Alternativa { Correta = true, Descricao = "H2O" },
    }
},

new Pergunta
{
    Id = 20,
    Enunciado = "Em que continente está localizado o Egito?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "ÁSIA" },
        new Alternativa { Correta = false, Descricao = "AMÉRICA" },
        new Alternativa { Correta = false, Descricao = "EUROPA" },
        new Alternativa { Correta = true, Descricao = "ÁFRICA" },
    }
},

new Pergunta
{
    Id = 21,
    Enunciado = "Qual é o maior rio do mundo em volume de água?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "RIO NILO" },
        new Alternativa { Correta = false, Descricao = "RIO MISSISSIPI" },
        new Alternativa { Correta = false, Descricao = "RIO YANGTSÉ" },
        new Alternativa { Correta = true, Descricao = "RIO AMAZÔNIA" },
    }
},
        };
        /* Perguntas faceis 1 a 20 */

        public static Pergunta getRendomPerguntaFacil()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                pergunta_sorteada= perguntas_faceis[sorteado];

                if ( perguntas_sorteadas.Contains(pergunta_sorteada) )
                    {
                   perguntas_sorteadas.Add(pergunta_sorteada);                
                }
            }



        }

        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
{
    Id = 21,
    Enunciado = "Qual é o maior deserto do mundo?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "DESERTO DE SAARA" },
        new Alternativa { Correta = false, Descricao = "DESERTO DE GOBI" },
        new Alternativa { Correta = false, Descricao = "DESERTO DA ANTÁRTIDA" },
        new Alternativa { Correta = true, Descricao = "DESERTO DA ANTÁRTIDA" },
    }
},

new Pergunta
{
    Id = 22,
    Enunciado = "Qual é a capital da Austrália?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "SYDNEY" },
        new Alternativa { Correta = false, Descricao = "MELBOURNE" },
        new Alternativa { Correta = false, Descricao = "BRISBANE" },
        new Alternativa { Correta = true, Descricao = "CANBERRA" },
    }
},

new Pergunta
{
    Id = 23,
    Enunciado = "Quem escreveu 'O Pequeno Príncipe'?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "ANTOINE DE SAINT-EXUPÉRY" },
        new Alternativa { Correta = false, Descricao = "JULES VERNE" },
        new Alternativa { Correta = false, Descricao = "CHARLES DICKENS" },
        new Alternativa { Correta = true, Descricao = "ANTOINE DE SAINT-EXUPÉRY" },
    }
},

new Pergunta
{
    Id = 24,
    Enunciado = "Qual é a principal fonte de energia do Sol?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "FUSÃO NUCLEAR" },
        new Alternativa { Correta = false, Descricao = "FISSÃO NUCLEAR" },
        new Alternativa { Correta = false, Descricao = "REAÇÕES QUÍMICAS" },
        new Alternativa { Correta = true, Descricao = "FUSÃO NUCLEAR" },
    }
},

new Pergunta
{
    Id = 25,
    Enunciado = "Qual é o número atômico do hidrogênio?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "2" },
        new Alternativa { Correta = false, Descricao = "6" },
        new Alternativa { Correta = false, Descricao = "8" },
        new Alternativa { Correta = true, Descricao = "1" },
    }
},

new Pergunta
{
    Id = 26,
    Enunciado = "Qual é o processo pelo qual as plantas produzem seu próprio alimento?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "RESPIRAÇÃO" },
        new Alternativa { Correta = false, Descricao = "FERMENTAÇÃO" },
        new Alternativa { Correta = false, Descricao = "DIGESTÃO" },
        new Alternativa { Correta = true, Descricao = "FOTOSSÍNTESE" },
    }
},

new Pergunta
{
    Id = 27,
    Enunciado = "Quem pintou 'A Última Ceia'?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "MICHELANGELO" },
        new Alternativa { Correta = false, Descricao = "RAPHAEL" },
        new Alternativa { Correta = false, Descricao = "CARAVAGGIO" },
        new Alternativa { Correta = true, Descricao = "LEONARDO DA VINCI" },
    }
},

new Pergunta
{
    Id = 28,
    Enunciado = "Qual é a principal função dos glóbulos vermelhos no sangue?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "DEFESA DO ORGANISMO" },
        new Alternativa { Correta = false, Descricao = "COAGULAÇÃO" },
        new Alternativa { Correta = false, Descricao = "TRANSPORTE DE HORMÔNIOS" },
        new Alternativa { Correta = true, Descricao = "TRANSPORTE DE OXIGÊNIO" },
    }
},

new Pergunta
{
    Id = 29,
    Enunciado = "Qual é o elemento químico representado pelo símbolo 'Na'?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "NÍQUEL" },
        new Alternativa { Correta = false, Descricao = "NITROGÊNIO" },
        new Alternativa { Correta = false, Descricao = "NÃO" },
        new Alternativa { Correta = true, Descricao = "SÓDIO" },
    }
},

new Pergunta
{
    Id = 30,
    Enunciado = "Qual é o maior planeta do Sistema Solar?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "SATURNO" },
        new Alternativa { Correta = false, Descricao = "URANO" },
        new Alternativa { Correta = false, Descricao = "NETUNO" },
        new Alternativa { Correta = true, Descricao = "JÚPITER" },
    }
},

new Pergunta
{
    Id = 31,
    Enunciado = "Quem foi o primeiro homem a pisar na Lua?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "BUZZ ALDRIN" },
        new Alternativa { Correta = false, Descricao = "MICHAEL COLLINS" },
        new Alternativa { Correta = false, Descricao = "YURI GAGARIN" },
        new Alternativa { Correta = true, Descricao = "NEIL ARMSTRONG" },
    }
},

new Pergunta
{
    Id = 32,
    Enunciado = "Qual é o maior animal marinho?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "ORCA" },
        new Alternativa { Correta = false, Descricao = "TUBARÃO-BALEIA" },
        new Alternativa { Correta = false, Descricao = "PINGUIM IMPERIAL" },
        new Alternativa { Correta = true, Descricao = "BALEIA AZUL" },
    }
},

new Pergunta
{
    Id = 33,
    Enunciado = "Qual é o elemento químico com símbolo 'Fe'?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "FÓSFORO" },
        new Alternativa { Correta = false, Descricao = "FLORETO" },
        new Alternativa { Correta = false, Descricao = "FERRO" },
        new Alternativa { Correta = true, Descricao = "FERRO" },
    }
},

new Pergunta
{
    Id = 34,
    Enunciado = "Qual é o nome do satélite natural da Terra?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Fobos" },
        new Alternativa { Correta = false, Descricao = "Ío" },
        new Alternativa { Correta = false, Descricao = "Titan" },
        new Alternativa { Correta = true, Descricao = "Lua" },
    }
},

new Pergunta
{
    Id = 35,
    Enunciado = "Qual é a capital do Canadá?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Vancouver" },
        new Alternativa { Correta = false, Descricao = "Toronto" },
        new Alternativa { Correta = false, Descricao = "Montreal" },
        new Alternativa { Correta = true, Descricao = "Ottawa" },
    }
},

new Pergunta
{
    Id = 36,
    Enunciado = "Qual é o nome da maior cadeia de montanhas do mundo?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Montanhas Rochosas" },
        new Alternativa { Correta = false, Descricao = "Alpes" },
        new Alternativa { Correta = false, Descricao = "Montanhas do Atlas" },
        new Alternativa { Correta = true, Descricao = "Himalaias" },
    }
},

new Pergunta
{
    Id = 37,
    Enunciado = "Quem foi o presidente dos Estados Unidos durante a Segunda Guerra Mundial?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "THEODORE ROOSEVELT" },
        new Alternativa { Correta = false, Descricao = "HARRY TRUMAN" },
        new Alternativa { Correta = false, Descricao = "WOODROW WILSON" },
        new Alternativa { Correta = true, Descricao = "FRANKLIN D. ROOSEVELT" },
    }
},

new Pergunta
{
    Id = 38,
    Enunciado = "Qual é o principal gás encontrado na atmosfera da Terra?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "DIOXÍDIO DE CARBONO" },
        new Alternativa { Correta = false, Descricao = "HÉLIO" },
        new Alternativa { Correta = false, Descricao = "ARGÔNIO" },
        new Alternativa { Correta = true, Descricao = "NITROGÊNIO" },
    }
},

new Pergunta
{
    Id = 39,
    Enunciado = "Qual é o nome da famosa torre inclinada na Itália?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Torre de Pisa" },
        new Alternativa { Correta = false, Descricao = "Torre de Veneza" },
        new Alternativa { Correta = false, Descricao = "Torre de Roma" },
        new Alternativa { Correta = true, Descricao = "Torre de Pisa" },
    }
},

new Pergunta
{
    Id = 40,
    Enunciado = "Qual é o nome da teoria que descreve a origem do universo?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Teoria da Relatividade" },
        new Alternativa { Correta = false, Descricao = "Teoria do Big Bang" },
        new Alternativa { Correta = false, Descricao = "Teoria da Evolução" },
        new Alternativa { Correta = true, Descricao = "Teoria do Big Bang" },
    }
},



        };

        public static Pergunta getRendomPerguntaMedias()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(21, 40);

                pergunta_sorteada = perguntas_medias[sorteado];

                if (perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                }
            }

        static List<Pergunta> perguntas_dificeis = new()
        {
           new Pergunta
{
    Id = 41,
    Enunciado = "Qual é o nome do fenômeno pelo qual a luz é desviada ao passar por um campo gravitacional intenso?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Efeito Doppler" },
        new Alternativa { Correta = false, Descricao = "Efeito Compton" },
        new Alternativa { Correta = false, Descricao = "Desvio para o Vermelho" },
        new Alternativa { Correta = true, Descricao = "Lente Gravitacional" },
    }
},

new Pergunta
{
    Id = 42,
    Enunciado = "Qual é a principal obra filosófica de Immanuel Kant?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "A República" },
        new Alternativa { Correta = false, Descricao = "O Capital" },
        new Alternativa { Correta = false, Descricao = "Assim Falou Zaratustra" },
        new Alternativa { Correta = true, Descricao = "Crítica da Razão Pura" },
    }
},

new Pergunta
{
    Id = 43,
    Enunciado = "Qual é a teoria que propõe que a vida na Terra pode ter sido originada a partir de moléculas orgânicas trazidas por meteoritos ou cometas?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Teoria da Panspermia" },
        new Alternativa { Correta = false, Descricao = "Teoria da Abiogênese" },
        new Alternativa { Correta = false, Descricao = "Teoria da Evolução" },
        new Alternativa { Correta = true, Descricao = "Teoria da Panspermia" },
    }
},

new Pergunta
{
    Id = 44,
    Enunciado = "Qual foi o principal autor da teoria da relatividade geral?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Isaac Newton" },
        new Alternativa { Correta = false, Descricao = "Niels Bohr" },
        new Alternativa { Correta = false, Descricao = "Galileu Galilei" },
        new Alternativa { Correta = true, Descricao = "Albert Einstein" },
    }
},

new Pergunta
{
    Id = 45,
    Enunciado = "Qual é o nome do estudo da origem e evolução do universo?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Astronomia" },
        new Alternativa { Correta = false, Descricao = "Cosmologia" },
        new Alternativa { Correta = false, Descricao = "Astrofísica" },
        new Alternativa { Correta = true, Descricao = "Cosmologia" },
    }
},

new Pergunta
{
    Id = 46,
    Enunciado = "Quem formulou a teoria do caos e a ideia de sistemas dinâmicos não-lineares?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Stephen Hawking" },
        new Alternativa { Correta = false, Descricao = "Niels Bohr" },
        new Alternativa { Correta = false, Descricao = "Isaac Newton" },
        new Alternativa { Correta = true, Descricao = "Edward Lorenz" },
    }
},

new Pergunta
{
    Id = 47,
    Enunciado = "Qual é o nome do método que utiliza amostras de DNA para identificar indivíduos?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "PCR" },
        new Alternativa { Correta = false, Descricao = "Eletroforese" },
        new Alternativa { Correta = false, Descricao = "Sequenciamento Genético" },
        new Alternativa { Correta = true, Descricao = "Perfil Genético" },
    }
},

new Pergunta
{
    Id = 48,
    Enunciado = "Qual foi o nome da primeira sonda espacial a pousar em outro planeta?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Viking 1" },
        new Alternativa { Correta = false, Descricao = "Voyager 1" },
        new Alternativa { Correta = false, Descricao = "Cassini" },
        new Alternativa { Correta = true, Descricao = "Viking 1" },
    }
},

new Pergunta
{
    Id = 49,
    Enunciado = "Qual é a mais antiga universidade em funcionamento contínuo no mundo?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Universidade de Oxford" },
        new Alternativa { Correta = false, Descricao = "Universidade de Bolonha" },
        new Alternativa { Correta = false, Descricao = "Universidade de Paris" },
        new Alternativa { Correta = true, Descricao = "Universidade de Al Quaraouiyine" },
    }
},

new Pergunta
{
    Id = 50,
    Enunciado = "Qual foi o primeiro livro impresso com a imprensa de tipos móveis de Gutenberg?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "A Divina Comédia" },
        new Alternativa { Correta = false, Descricao = "Os Lusíadas" },
        new Alternativa { Correta = false, Descricao = "O Príncipe" },
        new Alternativa { Correta = true, Descricao = "A Bíblia de Gutenberg" },
    }
},

new Pergunta
{
    Id = 51,
    Enunciado = "Quem é conhecido por desenvolver a teoria das cordas na física?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Richard Feynman" },
        new Alternativa { Correta = false, Descricao = "Stephen Hawking" },
        new Alternativa { Correta = false, Descricao = "Paul Dirac" },
        new Alternativa { Correta = true, Descricao = "Edward Witten" },
    }
},

new Pergunta
{
    Id = 52,
    Enunciado = "Qual é o nome do fenômeno pelo qual a matéria é convertida em energia, conforme descrito pela equação E=mc²?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Fissão Nuclear" },
        new Alternativa { Correta = false, Descricao = "Fusão Nuclear" },
        new Alternativa { Correta = false, Descricao = "Desintegração Radioativa" },
        new Alternativa { Correta = true, Descricao = "Aniquilação" },
    }
},

new Pergunta
{
    Id = 53,
    Enunciado = "Qual é a linguagem de programação desenvolvida por Bjarne Stroustrup?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Java" },
        new Alternativa { Correta = false, Descricao = "Python" },
        new Alternativa { Correta = false, Descricao = "C#" },
        new Alternativa { Correta = true, Descricao = "C++" },
    }
},

new Pergunta
{
    Id = 54,
    Enunciado = "Qual foi o evento que ocorreu em 1989 e marcou a queda do muro em uma importante cidade europeia?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Revolução Húngara" },
        new Alternativa { Correta = false, Descricao = "Revolução Velha" },
        new Alternativa { Correta = false, Descricao = "Revolução de 1968" },
        new Alternativa { Correta = true, Descricao = "Queda do Muro de Berlim" },
    }
},

new Pergunta
{
    Id = 55,
    Enunciado = "Qual é o nome do estudo da estrutura dos átomos e suas interações?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Física Nuclear" },
        new Alternativa { Correta = false, Descricao = "Química Orgânica" },
        new Alternativa { Correta = false, Descricao = "Química Analítica" },
        new Alternativa { Correta = true, Descricao = "Física Atômica" },
    }
},

new Pergunta
{
    Id = 56,
    Enunciado = "Qual é o nome da teoria que sugere que os genes podem influenciar o comportamento e a cultura?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Teoria da Evolução Cultural" },
        new Alternativa { Correta = false, Descricao = "Teoria da Seleção Natural" },
        new Alternativa { Correta = false, Descricao = "Teoria dos Jogos" },
        new Alternativa { Correta = true, Descricao = "Genética Comportamental" },
    }
},

new Pergunta
{
    Id = 57,
    Enunciado = "Qual é o conceito descrito por Jean-Paul Sartre como a ideia de que a existência precede a essência?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Existencialismo" },
        new Alternativa { Correta = false, Descricao = "Absurdo" },
        new Alternativa { Correta = false, Descricao = "Materialismo" },
        new Alternativa { Correta = true, Descricao = "Existencialismo" },
    }
},

new Pergunta
{
    Id = 58,
    Enunciado = "Qual é o nome do princípio pelo qual as leis da física são as mesmas para todos os sistemas inerciais?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Princípio da Incerteza" },
        new Alternativa { Correta = false, Descricao = "Princípio de Heisenberg" },
        new Alternativa { Correta = false, Descricao = "Princípio da Relatividade" },
        new Alternativa { Correta = true, Descricao = "Princípio da Relatividade" },
    }
},

new Pergunta
{
    Id = 59,
    Enunciado = "Qual é o nome da teoria que descreve o comportamento da luz como uma onda e partícula?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Teoria da Relatividade" },
        new Alternativa { Correta = false, Descricao = "Teoria das Cordas" },
        new Alternativa { Correta = false, Descricao = "Teoria do Caos" },
        new Alternativa { Correta = true, Descricao = "Dualidade Onda-Partícula" },
    }
},

new Pergunta
{
    Id = 60,
    Enunciado = "Quem foi o matemático que formulou o teorema dos números primos na análise complexa?",
    Alternativa = new()
    {
        new Alternativa { Correta = false, Descricao = "Leonhard Euler" },
        new Alternativa { Correta = false, Descricao = "Carl Friedrich Gauss" },
        new Alternativa { Correta = false, Descricao = "Bernhard Riemann" },
        new Alternativa { Correta = true, Descricao = "Bernhard Riemann" },
    }
},

        };

        public static Pergunta getRandom

        public static Pergunta getRendomPerguntaDificeis()
        {
            Random r = new Random();

            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(41, 60);

                pergunta_sorteada = perguntas_dificeis[sorteado];

                if (perguntas_sorteadas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                }
            }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}