using System;

namespace AspNetCoreIdentityMysql.API.Model
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        protected Usuario()
        {

        }

    }
}
