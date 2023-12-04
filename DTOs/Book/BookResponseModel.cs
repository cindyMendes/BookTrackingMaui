using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingMaui.DTOs.Book
{
    internal class BookResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishingDate { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsRead { get; set; }

        public bool IsTBR { get; set; }

        public int SerieId { get; set; }
    }
}
