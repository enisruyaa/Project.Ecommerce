using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.COMMON.Tools;
using Project.CoreMVC.Models;
using Project.CoreMVC.Models.AppUsers;
using Project.ENTITIES.Models;
using System.Diagnostics;

namespace Project.CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        //Todo : Validation Sistemi Yapýlacak

        // Todo : SignIn yapan kullanýcý Register ve SignIn linklerini görmektense SignOut linkini görsün.

        private readonly ILogger<HomeController> _logger;
        readonly UserManager<AppUser> _userManager;
        readonly RoleManager<IdentityRole<int>> _roleManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, RoleManager<IdentityRole<int>> roleManager)
        {

            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Register(UserRegisterModel model)
        {
            Guid specId = Guid.NewGuid();
            AppUser appUser = new()
            {
                UserName = model.UserName,
                Email = model.Email,
                ActivationCode = specId
            };

            IdentityResult result = await _userManager.CreateAsync(appUser,model.Password);

            if (result.Succeeded)
            {
                #region RolKontrolIslemleri
                IdentityRole<int> appRole = await _roleManager.FindByNameAsync("Member");
                if (appRole != null) await _roleManager.CreateAsync(new() { Name = "Member" });
                await _userManager.AddToRoleAsync(appUser, "Member");
                #endregion

                string body = $" Hesabýnýz Oluþturulmuþtur. Üyeliðinizi Onaylamak Ýçin Lütfen http://localhost:5279/Home/ConfirmEmail?specId={specId}&id={appUser.Id} Linkine Týklayýnýz... ";

                MailService.Send(model.Email, body: body);
                TempData["Message"] = "Mailinizi Kontrol Ediniz";
                return RedirectToAction("RedirectPanel");
            }

            return View();
        }

        public async Task<IActionResult> ConfirmEmail(Guid specId,int id)
        {
            AppUser user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanýcý Bulunamadý";
                return RedirectToAction("RedirectPanel");
            }
            else if (user.ActivationCode == specId)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                TempData["Message"] = " Email Adresiniz Baþarýlý Bir Þekilde Onaylandý ";
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("Register");
        }

        public IActionResult RedirectPanel()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

    }
}
