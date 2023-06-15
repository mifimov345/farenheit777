using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace farenheit777.Pages
{
    public class TemperatureConverterModel : PageModel
    {
        [BindProperty]
        public double? Celsius { get; set; }

        public double? Result { get; private set; }

        public IActionResult OnPostConvert()
        {
            if (Celsius.HasValue)
            {
                try
                {
                    Result = Celsius.Value * 9 / 5 + 32;
                }
                catch (Exception ex)
                {
                    Result = null;
                }
            }

            return Page();
        }
    }
}
