using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Aplicacao.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProdutoServico(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Produto Gravar(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Descricao))
                throw new ArgumentNullException(nameof(produto.Descricao));

            if (produto.Valor <= 0.0m)
                throw new ApplicationException($"Valor {produto.Valor} inválido! Verifique");

            _unitOfWork.ProdutoRepositorio.Adicionar(produto);
            _unitOfWork.SaveChanges();

            return produto;
        }

        public Produto ObterProdutoPorCodigoBarra(string codigoBarra)
        {
            return _unitOfWork.ProdutoRepositorio.ObterTodos()
                 .FirstOrDefault(x => x.CodigoBarra == codigoBarra);
        }

        public List<Produto> ObterTodos()
        {
            return _unitOfWork.ProdutoRepositorio.ObterTodos();
        }

        public void RemoverPorCodigoBarra(string codigoBarra)
        {
            var produto = ObterProdutoPorCodigoBarra(codigoBarra);

            if (produto == null)
                throw new ArgumentNullException($"Produto para código {codigoBarra} não encontrado! Verifique.");

            _unitOfWork.ProdutoRepositorio.Remover(produto);
        }
    }
}