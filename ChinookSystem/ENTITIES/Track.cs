using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChinookSystem.ENTITIES
{
    [Table("Tracks")]

    internal class Track
    {

        private string _Composer;


        [Key]
        public int TrackId { get; set; }

        [Required(ErrorMessage = "Track Name is required")]
        [StringLength(200, ErrorMessage ="Track name is limited to 200 characters")]
        public string Name { get; set; }

        
        public int? AlbumId { get; set; }

        [Required(ErrorMessage = "Track MediaTypeId is required")]       
        public int MediaTypeId { get; set; }

        
        public int? GenreId { get; set; }

        [StringLength(220, ErrorMessage = "Track Composer is limited to 220 characters")]
        public string Composer 
        {
            get { return _Composer; }
            set { _Composer = string.IsNullOrEmpty(value) ? null : value; } 
        }

        [Required(ErrorMessage = "Track Milliseconds is required")]
        public int Milliseconds { get; set; }

        public int? Bytes { get; set; }

        [Required(ErrorMessage = "Track Unit Price is required")]        
        public decimal UnitPrice { get; set; }

        
        public virtual Album Album { get; set; }

    }
}
