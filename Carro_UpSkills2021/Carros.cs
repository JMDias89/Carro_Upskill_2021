using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_UpSkills2021
{
    public class Carros
    {
        /// <summary>
        /// Este método serve para devolver a lista de carros
        /// </summary>
        /// <returns>Lista de carros</returns>
        public List<Carro> GetCarros()
        {
            List<Carro> carros = new List<Carro>()
            {
                new Carro{Ano = 2017, Marca = "Ford", Modelo ="Fiesta", Matricula = "54-AS-64"},
                new Carro{Ano = 2018, Marca = "Ford", Modelo = "Focus", Matricula = "98-AD-54"},
                new Carro{Ano = 2017, Marca = "Peugeot", Modelo ="208", Matricula = "67-HF-13"},
                new Carro{Ano = 2019, Marca = "Renault", Modelo = "Clio",Matricula = "44-HH-55"},
                new Carro{Ano = 2020, Marca = "Mercedes", Modelo = "Class A 180d", Matricula = "32-TR-19"},
                new Carro{Ano = 2019, Marca = "BMW", Modelo = "320 d",Matricula = "62-RT-26"},
                new Carro{Ano = 2017, Marca = "Seat", Modelo = "Ibiza",Matricula = "75-JJ-11"},
                new Carro{Ano = 2020, Marca = "Ford", Modelo = "Mondeo", Matricula = "AS-12-35"},
                new Carro{Ano = 2020, Marca = "BMW", Modelo = "320 d", Matricula = "AD-33-FG"},
                new Carro{Ano = 2019, Marca = "Seat", Modelo = "Leon", Matricula = "RE-24-AS"},
                new Carro{Ano = 2019, Marca = "Volkswagen", Modelo = "Golf", Matricula = "JG-44-IH"},
            };
            // inserir outro carro com o ADD
            carros.Add(new Carro { Ano = 2018, Marca = "Volkswagen", Modelo = "Passat", Matricula = "WD-53-MN" });

            return carros;
        }
    }
}
