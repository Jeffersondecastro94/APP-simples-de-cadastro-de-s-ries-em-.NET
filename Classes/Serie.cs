using System;
using Dio.Series.Classes;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}
        public int Id { get; private set; }

        // Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    	{
    		this.Id = id;
    		this.Genero = genero;
    		this.Titulo = titulo;
    		this.Descricao = descricao;
    		this.Ano = ano;
            this.Excluido = false;
    	}
    
        public override string ToString()
    	{
    		// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;//environment.newLine pula a linha independente de onde esteja sendo usado isso. inves de usar /n etc
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
    		return retorno;
    	}
    
        public string retornaTitulo()
    	{
    		return this.Titulo;
    	}
    
    	public int retornaId()
    	{
    		return this.Id;
    	}
        public bool retornaExcluido()
    	{
    		return this.Excluido;
    	}
        public void Excluir() {
            this.Excluido = true;
        }
    }

}
