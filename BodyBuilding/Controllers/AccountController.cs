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
                if (_Context.Athletes.Any(p => p.NationalCode == athleteDTO.NationalCode.Trim()) == false)
                {
                    Athlete athlete = new Athlete()
                    {
                        Name = athleteDTO.Name,
                        Family = athleteDTO.Family,
                        BirthDay = athleteDTO.BirthDay,
                        NationalCode = athleteDTO.NationalCode.Trim(),
                        PhoneNumber = athleteDTO.PhoneNumber,
                        Email = athleteDTO.Email,
                        Password = athleteDTO.Password,
                    };
                    _Context.Athletes.Add(athlete);
                    _Context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                
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
