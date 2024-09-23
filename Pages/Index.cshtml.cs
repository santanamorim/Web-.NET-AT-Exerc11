using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_.NET_AT_Exerc11.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web_.NET_AT_Exerc11.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly ClienteContext _context;

        public IndexModel(ClienteContext context)
        {
            _context = context;
        }

        public IList<Cliente> ClienteList { get; set; } = new List<Cliente>();

        public async Task OnGetAsync()
        {
            ClienteList = await _context.Clientes.ToListAsync();
        }
    }
}

