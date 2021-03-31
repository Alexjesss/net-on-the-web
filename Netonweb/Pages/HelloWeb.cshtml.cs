using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Netonweb.Models;

namespace Netonweb.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public Student Sicco = new(1, "Sicco", 3);

        string[] names = { "Alexandra", "Julio", "Mark", "Nattaya", "Laila", "Paul", "Jens", "Anton", "Oscar", "Marte", "Viktor", "Micha", "Peter", "Thomas", "Jenifer", "Elia","Kai","Serkan"};
            
    }
}




