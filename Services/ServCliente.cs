namespace Ecommerce.Cliente
{
    public interface ServClienteAbstract
    {
        Cliente GetClienteById(int id);
        Cliente CreateCliente(ClienteDTO dto);
    }

    public class ServCliente : ServClienteAbstract
    {
        private DataContext _dataContext;

        public ServCliente()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public Cliente GetClienteById(int id)
        {
            var cliente = _dataContext.Cliente.FirstOrDefault(cliente => cliente.Id == id);

            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado!");
            }

            return cliente;
        }

        public Cliente CreateCliente(ClienteDTO dto)
        {
            var cliente = new Cliente();

            cliente.Id = dto.id;
            cliente.Nome = dto.nome;
            cliente.Email = dto.email;
            cliente.CPF = dto.cpf;
            
            _dataContext.Add(cliente);
            _dataContext.SaveChanges();

            return cliente;
        }
    }
}