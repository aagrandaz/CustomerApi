using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Dtos;

public class CreateCustomerDtos
{
    [Required(ErrorMessage = "El nombre propio tiene que estar especificado")]
    public string Name { get; set;}
    [Required(ErrorMessage = "El apellido tiene que estar especificado")]
    public string LastName { get; set; }
    [RegularExpression("@^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "El email no es correcto")]
    public string Email { get; set;}
    public string Phone { get; set; }
    public string Address { get; set; }
}