using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppInDDD.ApplicationCore.Entity
{
    public class Candidato
    {
        public Candidato(string nome, string apelido, string telefonePrimario, string telefoneSecundario, string cpf)
        {
            Id = NumeroDoProximoId;
            NumeroDoProximoId++;
            Nome = nome;
            Apelido = apelido;
            TelefonePrimario = telefonePrimario;
            TelefoneSecundario = telefoneSecundario;
            Cpf = cpf;
        }
        public Candidato(string nome, string apelido, string cpf)
        {
            Id = NumeroDoProximoId;
            NumeroDoProximoId++;
            Nome = nome;
            Apelido = apelido;
            TelefonePrimario = "759885854220";
            TelefoneSecundario = "";
            Cpf = cpf;
        }
        public Candidato()
        {
            Id = NumeroDoProximoId;
            NumeroDoProximoId++;
            Nome = "Thiago";
            Apelido = "Titi";
            TelefonePrimario = "759885854220";
            TelefoneSecundario = "";
            Cpf = "046.228.625-81";
        }

       
        public static int NumeroDoProximoId = 1;
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Apelido { get; set; }
        [Required]
        public string TelefonePrimario { get; set; }
        public string TelefoneSecundario{ get; set; }
        [Required]
        public string Cpf { get; set; }
    }
}
