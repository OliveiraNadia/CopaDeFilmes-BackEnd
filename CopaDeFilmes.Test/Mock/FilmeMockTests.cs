﻿using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CopaDeFilmes.Test.Mock
{
    public static class FilmeMockTests
    {
        public async static ValueTask<List<Filme>> ListaFilmes()
        {
            return new List<Filme>()
            {
                new Filme()
                {
                    Id="tt3606756",
                    Titulo = "Os Incríveis 2",
                    Nota=8.5,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt4881806",
                    Titulo = "Jurassic World: Reino Ameaçado",
                    Nota=6.7,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt5164214",
                    Titulo = "Oito Mulheres e um Segredo",
                    Nota=6.3,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt7784604",
                    Titulo = "Hereditário",
                    Nota=7.8,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt4154756",
                    Titulo = "Vingadores: Guerra Infinita",
                    Nota=8.8,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt5463162",
                    Titulo = "Deadpool 2",
                    Nota=8.1,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt3778644",
                    Titulo = "Han Solo: Uma História Star Wars",
                    Nota=7.2,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt3501632",
                    Titulo = "Thor: Ragnarok",
                    Nota=7.9,
                    Ano=2017
                },
                new Filme()
                {
                    Id="tt2854926",
                    Titulo = "Te Peguei!",
                    Nota=7.1,
                    Ano=2018
                } ,
                new Filme()
                {
                    Id="tt0317705",
                    Titulo = "Os Incríveis",
                    Nota=8,
                    Ano=2004
                },
                new Filme()
                {
                    Id="tt3799232",
                    Titulo = "A Barraca do Beijo",
                    Nota=6.4,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt1365519",
                    Titulo = "Tomb Raider: A Origem",
                    Nota=6.5,
                    Ano=2018
                },
                new Filme()
                {
                    Id="tt1825683",
                    Titulo = "Pantera Negra",
                    Nota=7.5,
                    Ano=2018
                }
                ,
                new Filme()
                {
                    Id="tt5834262",
                    Titulo = "Hotel Artemis",
                    Nota=6.3,
                    Ano=2018
                }
                ,
                new Filme()
                {
                    Id="tt7690670",
                    Titulo = "Superfly",
                    Nota=5.1,
                    Ano=2018
                }
                ,
                new Filme()
                {
                    Id="tt6499752",
                    Titulo = "Upgrade",
                    Nota=7.8,
                    Ano=2018
                }
            };
        }
    }
}
