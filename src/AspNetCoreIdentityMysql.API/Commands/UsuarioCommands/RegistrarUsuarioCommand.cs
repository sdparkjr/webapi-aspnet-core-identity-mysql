using System;

namespace AspNetCoreIdentityMysql.API.Commands.UsuarioCommands
{
    public class RegistrarUsuarioCommand : BaseUsuarioCommand
    {

        public RegistrarUsuarioCommand(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
