using DespositivosEletronicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DespositivosEletronicos.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoFabri = 2021, Laptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11"},
                new Computador { Marca = "Sansung", Modelo = "Inspirion", AnoFabri = 2021, Laptop = false, MemoriaRam = 16, SistemaOperacional = "Windows 11"}
            };
            return View(dispositivos);
        }
    }
}
