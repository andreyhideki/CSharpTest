﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using ConsoleAppExamples.Model;
using ConsoleAppExamples.Model.Comparativos;
using ConsoleAppExamples.Model.Enums;
using ConsoleAppExamples.Model.Override;

//EnumCompare ec = new EnumCompare();
//ec.CompararTempos();

StringCompare sc = new StringCompare();
sc.CompararStrings();

//TesteAbstract();

//Console.WriteLine("Hello, World!");

//IEnumerable<Product> products;
//List<Product> productsList = new List<Product>();

//for (int i = 1; i < 10; i++)
//{
//    var prod = new Product(Guid.NewGuid(), $"Prod {i}", $"Prod {i}");
//    productsList.Add(prod);
//}

//products = productsList.ToList();

//foreach (var item in productsList)
//{
//    Console.WriteLine(item.ToString());

//}

static void TesteAbstract()
{
    Dog dog = new Dog();
    Cat cat = new Cat();
    dog.Speak();
    cat.Speak();

    //Quando abstrato precisa implementar a funcao
    DogAbstract dogAbstract = new DogAbstract();
    CatAbstract catAbstract = new CatAbstract();
    dogAbstract.Speak();
    catAbstract.Speak();
}

