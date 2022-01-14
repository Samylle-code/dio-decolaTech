using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    
    interface IAnimal
    {
        void nome (string nome);
        void dono (string nomeDono);
        void Especie(string especie);

    }

    class Animal : IAnimal
    {
        public string nome { get; set; }
        public string nomeDono { get; set; }
        public string Especie { get; set; }

    void IAnimal.nome(string nome)
    {
        this.nome = nome;
    }
    void IAnimal.dono(string nomeDono)
    {
        this.nomeDono = nomeDono;
    }
    void IAnimal.Especie(string especie)
    {
        this.Especie = especie;
    }
    }

    
}