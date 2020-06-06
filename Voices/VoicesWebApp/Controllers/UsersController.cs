using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VoicesWebUI.ViewModels;

namespace DataAccess.Controllers
{
    public class UsersController : Controller
    {

        public IUsersRepository _repo { get; }

        public UsersController(IUsersRepository _Repo) =>
            _repo = _Repo ?? throw new ArgumentException(nameof(_Repo));
        
        // GET: Users
        public ActionResult Index()
        {
            return View(_repo.GetAll().ToString());
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("FisrtName", "LastName", "Username", "Email", "Password")]UsersViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var users = new Domain.Models.Users
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Username = user.Username,
                        Email = user.Email,
                        Password = user.Password
                    };
                    _repo.AddUser(users);
                    _repo.Save();

                    RedirectToAction(nameof(Index));
                }
                return View(user);
            }
            catch
            {
                return View(user);
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}