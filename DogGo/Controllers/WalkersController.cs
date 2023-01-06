using DogGo.Models;
using DogGo.Models.ViewModels;
using DogGo.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DogGo.Controllers
{
    public class WalkersController : Controller
    {
        //abi added--
        private readonly IWalkerRepository _walkerRepo;
        private readonly IWalkRepository _walkRepo;
        private readonly IOwnerRepository _ownerRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalkersController(IWalkerRepository walkerRepository, 
            IWalkRepository walkRepository,
            IOwnerRepository ownerRepo)
        {
            _walkerRepo = walkerRepository;
            _walkRepo = walkRepository;
            _ownerRepo = ownerRepo;
        }
        //-----


        // GET: WalkersController
        // GET: Walkers--UPDATED
        public ActionResult Index()
        {
            try
            {
            Owner owner = _ownerRepo.GetOwnerById(GetCurrentUserId());
            int userNeighborhood = owner.NeighborhoodId;
            
            List<Walker> walkers = _walkerRepo.GetWalkersInNeighborhood(userNeighborhood);
            return View(walkers);
            }
            catch
            {
                List<Walker> walkers = _walkerRepo.GetAllWalkers();
                return View(walkers);
            }
           
           
     

        }

        // GET: Walkers/Details/5
        public ActionResult Details(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);
            List<Walk> walks = _walkRepo.GetAll();

            ProfileViewModel vm = new ProfileViewModel()
            {
                Walker = walker,
                Walks = walks
            };

            return View(vm);
        }

        // GET: WalkersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalkersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
            private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }
    }
}
