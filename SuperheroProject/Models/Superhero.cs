using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroProject.Models
{
    public class Superhero
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alterego { get; set; }
        public string Ability { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }

    }
}
