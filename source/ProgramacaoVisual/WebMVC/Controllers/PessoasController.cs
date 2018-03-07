using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class PessoasController : Controller
    {
         private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa {Id = 1, Nome = "Joao"},
            new Pessoa {Id = 2, Nome = "Juao"},
            new Pessoa {Id = 3, Nome = "John"}
        };

        public IActionResult Index()
        {
            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };

            return View(viewModel);
        }
    }
}