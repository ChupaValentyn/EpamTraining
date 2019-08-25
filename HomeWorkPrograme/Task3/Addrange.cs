using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Task3
{
    class Addrange
    {
        public void Addrang()
        {
            List<Person> people = new List<Person>(6);

            people.Add(new Person() { Name = "Tom", age = 25, PhoneNumber = new List<string>() { "0633084525", "0553945122", "0634419213" } });
            people.Add(new Person() { Name = "Jeal", age = 29, PhoneNumber = new List<string>() { "0983042312", "0702013502", "0801431214", "0932455662" } });
            people.Add(new Person() { Name = "Bruse", age = 31, PhoneNumber = new List<string>() { "0501324356", "0903415203" } });
            people.Add(new Person() { Name = "Jason", age = 27, PhoneNumber = new List<string>() { "0634532134", "0501233123" } });
            people.Add(new Person() { Name = "Danny", age = 40, PhoneNumber = new List<string>() { "0963212341", "0631234561", "0983435213" } });
            people.Add(new Person() { Name = "Oliver", age = 24, PhoneNumber = new List<string>() { "0965540932", "0603323142", "0984432152" } });

            List<Person> addrangeperson = new List<Person>(3);
            addrangeperson.Add(new Person() { Name = "Jean", age = 31, PhoneNumber = new List<string> { "0504312304", "0635230123", "0934435123" } });
            addrangeperson.Add(new Person() { Name = "Freddy", age = 28, PhoneNumber = new List<string> { "0804355304", "0505340123", "0934444333" } });
            addrangeperson.Add(new Person() { Name = "Andree", age = 41, PhoneNumber = new List<string> { "0809077304", "0635341233", "0935125231" } });
            people.AddRange(addrangeperson);

            foreach (var item in people)
            {
                Console.Write($"Name={item.Name}, Age={item.age}, Phone numbers: ");
                foreach (var numbers in item.PhoneNumber)
                {
                    Console.Write($"{numbers} ");
                }
                Console.WriteLine();
            }
        }
    }
}
