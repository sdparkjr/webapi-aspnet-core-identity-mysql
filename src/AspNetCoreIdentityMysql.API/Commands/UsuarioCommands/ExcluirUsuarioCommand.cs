using System;

namespace AspNetCoreIdentityMysql.API.Commands.UsuarioCommands
{
    public class ExcluirUsuarioCommand : BaseUsuarioCommand
    {
        public ExcluirUsuarioCommand(Guid id)
        {
            Id = id;
        }
    }
}
