using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingMaui.DTOs.Book
{
    internal class BookByIdRequestModel
    {
        [Required(ErrorMessage = "This field cannot be empty")]
        public int Id { get; set; }
    }
}
