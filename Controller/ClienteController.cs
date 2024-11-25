using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Cliente
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ServClienteAbstract _servCliente;

        public ClienteController()
        {
            _servCliente = new ServCliente();
        }

        [Route("/api/cliente/{id}")]
        [HttpGet]
        public IActionResult GetClienteById(int id)
        {
            try
            {
                var cliente = _servCliente.GetClienteById(id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/api/cliente")]
        [HttpPost]
        public IActionResult PostCliente(ClienteDTO dto)
        {
            try
            {
                var cliente = _servCliente.CreateCliente(dto);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
