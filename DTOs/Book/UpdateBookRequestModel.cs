using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingMaui.DTOs.Book
{
    internal class UpdateBookRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        public DateTime PublishingDate { get; set; }

        [Required]
        public bool IsFavorite { get; set; }

        [Required]
        public bool IsRead { get; set; }

        [Required]
        public bool IsTBR { get; set; }

        public int SerieId { get; set; }

    }
}
