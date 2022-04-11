using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Comment
    {
        //SCalar Properties
        [Key]
        public int Id { get; set; }
        public string Comentario { get; set; }
        public DateTime Date { get; set; }

        //Reference navigation properties
        public Usuario Usuario { get; set; }
        //Relacion de uno amuchos
    }



    /*
    ● Comments: deberá tener,

            Id.
                Date
                Comment
            User que creo el Comment
    
    */

}
