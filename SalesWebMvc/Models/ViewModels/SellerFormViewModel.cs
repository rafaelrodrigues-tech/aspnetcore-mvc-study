using System.Collections.Generic;

namespace SalesWebMvc2.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller  { get; set; }
        public ICollection<Department> Departments{ get; set; }
    }
}
//O SellerFormViewModel não existe para representar apenas um vendedor.
//Ele existe para representar os dados necessários para a tela de cadastro:
//o vendedor que está sendo criado e a lista de departamentos(dropdown) disponíveis para seleção.