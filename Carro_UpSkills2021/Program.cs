using Carro_UpSkills2021;
using System.Collections.Generic;
using System.Linq;

// Variáveis
Carros carros = new Carros();
List<Carro> list;

// Carregar carros
list = carros.GetCarros();


// Apresentar todos os carros acedendo a cada um pelo indice
Console.WriteLine("Lista de carros (Via indice da lista com um ciclo for)\n");

for (int i = 0; i < list.Count; i++)
    Console.WriteLine(list[i].Marca + " - " + list[i].Modelo + " - " + list[i].Ano + " - " + list[i].Matricula);


// Apresentar todos os carros acedendo a cada um através do próprio objeto e ordenando por Matricula
Console.WriteLine("\n\nLista de carros ordenado por matrícula (Via objeto com um ciclo foreach)\n");

foreach (Carro carro in list.OrderBy(carro => carro.Matricula).ToList())
    Console.WriteLine(carro.Marca + " - " + carro.Modelo + " - " + carro.Ano + " - " + carro.Matricula);


// Apresentar todos os carros acedendo apenas aos carros dos anos 2018 e 2020.
Console.WriteLine("\n\nLista de todos os carros dos anos 2018 e 2020 (via objeto com um ciclo foreach");

foreach (Carro carro in list.OrderBy(c => c.Ano).ToList())
{
    if (carro.Ano == 2018)
        Console.WriteLine(carro.Marca + " - " + carro.Modelo + " - " + carro.Ano + " - " + carro.Matricula);
    if (carro.Ano == 2020)
        Console.WriteLine(carro.Marca + " - " + carro.Modelo + " - " + carro.Ano + " - " + carro.Matricula);
}


// Apresentar as marcas de carros existentes na lista, sem repetir marcas 
Console.WriteLine("\n\nLista de marcas de carros sem repetir a Marca (via objeto com um ciclo foreach");

//IEnumerable<Carro> lista = list.AsQueryable().Distinct();


foreach (Carro carro in list.OrderBy(m => m.Marca == "Ford").ToList()) {

    Console.WriteLine(carro.Marca + " - " + carro.Modelo + " - " + carro.Ano + " - " + carro.Matricula);
}


Console.ReadKey();