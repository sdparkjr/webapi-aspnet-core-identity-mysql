using FluentValidator;
using FluentValidator.Validation;
using System;

namespace AspNetCoreIdentityMysql.API.Model
{
    public class Usuario : Notifiable
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;


            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Nome, 3, "Nome", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(Nome, 40, "Nome", "O nome deve conter no maximo 40 caracteres")
                .IsEmail(Email, "Email", "Email inválido")
            );
        }

        protected Usuario()
        {

        }

        public override string ToString()
        {
            return $"{this.Nome}, {this.Email}";
        }

    }
}
