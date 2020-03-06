//Modelos das Entidades
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio
{
    public class Usuario
    {

        [DisplayName("Identificador")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o nome do usuário !")]
        public string Nome { get; set; }

        [DisplayName("Data de Nasciemnto")]
        [Required(ErrorMessage = "Preencha a data de nascimento !")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [PasswordPropertyText]
        public string Senha { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Preencha o  Sexo !")]
        public ESexo Sexo { get; set; }

    }


}

