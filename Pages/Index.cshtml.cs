using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AvalaraCodeChallenge.Pages
{
    public class IndexModel : PageModel
    {
        public void OnPost()
        {
        //when the date form is submitted store the input data into a variable
        var date = Request.Form["date"];
        
        }
    }
}
