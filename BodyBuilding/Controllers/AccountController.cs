using BodyBuilding.Application.DTOs;
using BodyBuilding.Domain.Entities.Athlete;
using BodyBuilding.Infrastructuer.DbContext;
using Microsoft.AspNetCore.Mvc;

namespace BodyBuilding.Controllers
{
    public class AccountController : Controller
    {
        #region Ctro

        private readonly BodyBuildingDbContext _Context;

        public AccountController(BodyBuildingDbContext context)
        {
            _Context = context;
        }

        #endregion

        #region register

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Register(AthleteRegisterDTO athleteDTO)
        {
            if (ModelState.IsValid)
            {
                Athlete athlete = new Athlete()
                {
                    Name = athleteDTO.Name,
                    Family = athleteDTO.Family,
                    BirthDay = athleteDTO.BirthDay,
                    Gender = athleteDTO.Gender,
                    NationalCode = athleteDTO.NationalCode,
                    PhoneNumber = athleteDTO.PhoneNumber,
                    Password = athleteDTO.Password,
                };
                _Context.Athletes.Add(athlete);
                _Context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        #endregion

        #region login



        #endregion

        #region logout



        #endregion

    }
}
