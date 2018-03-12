using System;

namespace AspNetCoreIdentityMysql.API.Commands.UsuarioCommands
{
    public abstract class BaseUsuarioCommand
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
    }
}
