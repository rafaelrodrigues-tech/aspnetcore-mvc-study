using System.Collections.Generic;
using System.Linq;
using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
namespace SalesWebMvc2.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc2Context _context;

        public SellerService(SalesWebMvc2Context context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
