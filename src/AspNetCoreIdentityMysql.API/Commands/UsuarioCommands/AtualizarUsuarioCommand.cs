using System;

namespace AspNetCoreIdentityMysql.API.Commands.UsuarioCommands
{
    public class AtualizarUsuarioCommand : BaseUsuarioCommand 
    {
        public AtualizarUsuarioCommand(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
