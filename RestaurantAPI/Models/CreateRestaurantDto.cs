using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class CreateRestaurantDto
    {
      
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool HasDelivery { get; set; }
        public string? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string? City { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
    }

    //[CreditCard]                  //Potwierdza, ze wlasciwosc ma format karty kredytowej

    //[Compare("otherProperty")]    //Sprawdza, czy dwie wlasciwosci w modelu sa zgodne

    //[EmailAddress]                //Sprawdza, czy wlasciwosc ma format wiadomosci e-mail

    //[Phone]                       //Sprawdza, czy wlasciwosc ma format numeru telefonu

    //[Range(minValue, maxValue)]   //Sprawdza, czy wartosc wlasciwosci miesci sie w okreslonym zakresie.

    //[RegularExpression(pattern)]  //Sprawdza, czy wartosc wlasciwosci pasuje do okreslonego wyrazenia regularnego
}
