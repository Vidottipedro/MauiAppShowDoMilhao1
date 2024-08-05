namespace MauiAppShowDoMilhao1
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativa = new()
                {
                    new Alternativa {Correta = false, Descricao = "Líquido" },
                    new Alternativa {Correta = true, Descricao = "Sólido" },
                    new Alternativa {Correta = false, Descricao = "Gasoso" },
                    new Alternativa {Correta = false, Descricao = "Vaporoso" }
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual e o personagem do folclore brasileiro tem uma perna só",
                Alternativa = new() 
                {
                    new Alternativa {Correta = false, Descricao = "Cuca" },                 
                    new Alternativa { Correta = false, Descricao ="Boitatá" },
                    new Alternativa { Correta = true, Descricao = "Saci - Pererê" },
                    new Alternativa { Correta = false, Descricao = "Negrinho do Pastoreiro" },
            }

    }
}
        