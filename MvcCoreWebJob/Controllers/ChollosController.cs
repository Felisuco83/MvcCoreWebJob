using Microsoft.AspNetCore.Mvc;
using MvcCoreWebJob.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJob.Controllers
{
    public class ChollosController : Controller
    {
        RepositoryChollos repo;
        public ChollosController (RepositoryChollos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetChollos());
        }
    }
}
