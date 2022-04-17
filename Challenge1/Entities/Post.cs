using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    /*● Posts: deberá tener,
            Title
            Date
            Content
            User que creo el Post
    */
    public class Post
    {
        //SCalar Properties
        [Key]
        public int IdPost { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
      
        public ICollection<Comment> Comments { get; set; }


        //Reference navigation properties
        public Usuario Usuario { get; set; } //Relacion de uno amuchos

    }

}
