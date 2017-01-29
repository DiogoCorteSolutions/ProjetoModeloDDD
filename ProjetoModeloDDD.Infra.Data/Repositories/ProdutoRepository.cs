using ProjetModeloDDD.Dommain.Entities;
using ProjetModeloDDD.Dommain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return DB.Produtos.Where(p => p.Nome == nome);
        }
    }
}
