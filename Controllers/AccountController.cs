using Microsoft.AspNetCore.Mvc;

namespace GranTiete_Devs.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string Email, string Password)
    {
        if (Email == "Admin" && Password == "123456")
            ViewData["Resultado"] = "Logado";
        else
            ViewData["Resultado"] = "Usuário e/ou Senha Inválidos";
        return View();
    }

}
