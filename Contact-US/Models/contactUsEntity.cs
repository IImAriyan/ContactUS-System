using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace Contact_US.Models;


[Table(name:"ContactUS")]
public class contactUsEntity
{
    
    [Key] 
    [Required]
    [SwaggerIgnore]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please Enter Name")]
    [Display(Name = "Name")]
    [MaxLength(350)]
    public string Name { get; set; }
    
    
    [Required(ErrorMessage = "Please Enter Email")]
    [Display(Name = "Email")]
    [MaxLength(350)]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Please Enter Number")]
    [Display(Name = "Number")]
    [MaxLength(350)]
    public string Number { get; set; }
    
    [Required(ErrorMessage = "Please Enter Your Text")]
    [Display(Name = "Text")]
    [MaxLength(350)]
    public string Text { get; set; }
}