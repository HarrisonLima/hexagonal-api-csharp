
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Aplicacao.Servicos
{
    public class ClienteServico : IClienteServico
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteServico(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Cliente Gravar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new ArgumentNullException(nameof(cliente.Nome));

            if (string.IsNullOrWhiteSpace(cliente.Documento))
                throw new ArgumentNullException(nameof(cliente.Documento));

            _unitOfWork.ClienteRepositorio.Adicionar(cliente);
            _unitOfWork.SaveChanges();

            return cliente;
        }

        public Cliente ObterClientePorDocumento(string documento)
        {
            return _unitOfWork.ClienteRepositorio.ObterTodos()
                 .FirstOrDefault(x => x.Documento == documento);
        }

        public List<Cliente> ObterTodos()
        {
            return _unitOfWork.ClienteRepositorio.ObterTodos();
        }

        public void RemoverPorDocumento(string documento)
        {
            var cliente = ObterClientePorDocumento(documento);

            if (cliente == null)
                throw new ArgumentNullException($"Cliente para documento {documento} não encontrado! Verifique.");

            _unitOfWork.ClienteRepositorio.Remover(cliente);
        }
    }
}
