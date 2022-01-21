


using System;


namespace EstudoObjeto{

	public class Pessoa
	{
		public string nome {get;set;}
		public int Idade { get; set; }
		public void Apresentar()
        {
			Console.WriteLine($"Olá meu nome é {nome} e tenho {Idade} anos.");
        }
	}
}
