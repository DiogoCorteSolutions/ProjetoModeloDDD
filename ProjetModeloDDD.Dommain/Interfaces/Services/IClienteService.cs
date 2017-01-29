using ProjetModeloDDD.Dommain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetModeloDDD.Dommain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes);
    }
}
