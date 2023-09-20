using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Dtos;

public class CreateCustomerDtos
{
    [Required(ErrorMessage = "")]
    public string Name { get; set;}
    public string LastName { get; set; }
    public string Email { get; set;}
    public string Phone { get; set; }
    public string Address { get; set; }
}