using System.ComponentModel.DataAnnotations;
using Valtech_Form_BusinessLogic.Extensions;

namespace Valtech_Form_BusinessLogic.Models
{
    public class FormModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Vul alstublieft een achternaam in")]
        public string Surname { get; set; }

        [Display(Name = "E-mailadres")]
        [EmailAddress(ErrorMessage = "Dat is geen geldig e-mailadres. Vul alstublieft een correct e-mailadres in.")]
        [Required(ErrorMessage = "Vul alstublieft een e-mailadres in")]
        public string Email { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Postcode")]
        public string ZipCode { get; set; }

        [Display(Name = "Telefoonnummer")]
        [Phone(ErrorMessage = "Dat is geen geldig telefoonnummer. Vul alstublieft een geldig telefoonnummer in.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Ik ga akkoord met de algemene voorwaarden")]
        [RequireTrue(ErrorMessage = "U moet akkoord gaan met de voorwaarden.")]
        public bool AgreedToTermsAndConditions { get; set; }
    }
}
