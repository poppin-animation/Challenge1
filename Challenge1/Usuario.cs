using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    /*
    Como practica inicial de EF Core, lo primero que vamos a hacer va a ser crear en un proyecto de Consola (.NET Core) vacio las clases de Modelo como la de Contexto para el siguiente modelo de BD:
                ● Usuario: deberá tener,
                 Id.
                Name
                Password
                Email.
                Posts
                Comments
    */

    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }


    



}
