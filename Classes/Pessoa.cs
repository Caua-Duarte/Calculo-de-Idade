using System;

namespace CalculoIdade
{
    public class Pessoa
    {
        //Propriedade
        public Pessoa(String nomePessoa, int anoNascimentoPessoa)
        {
            this.Nome = nomePessoa;
            this.AnoNascmento = anoNascimentoPessoa;
            this.CalcularIdade();
        }

        private int anoNascimento; // propfull
        public int AnoNascmento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }
        
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade
        {
            get { return this.idade; }
        }
        
        //Metodos

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now; // Pega a data do sistema atual/Agora
            int ano = data.Year;
            this.idade = ano - this.AnoNascmento;  
        }
        
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de Nascimento: " + this.AnoNascmento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }
    }
}