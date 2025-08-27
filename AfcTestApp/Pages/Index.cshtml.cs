using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVVMWebApp.Models;

namespace AfcTestApp.Pages;

public class IndexModel : PageModel
{
    private readonly Calculator _calculator = new Calculator();
    private readonly ILogger<IndexModel> _logger;
    [BindProperty]
    public double InputNumber { get; set; }

    public double? Result { get; private set; }
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public void OnPost()
    {
        Result = _calculator.MultiplyByTwo(InputNumber);
    }
}
