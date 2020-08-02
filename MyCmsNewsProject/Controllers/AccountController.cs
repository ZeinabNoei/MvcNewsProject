using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using System.Web.Security;
namespace MyCmsNewsProject.Controllers
{
    public class AccountController : Controller
    {
        ILoginRepository loginRepository;
        MyCmsContext db = new MyCmsContext();
        public AccountController()
        {
            loginRepository = new LoginReppository(db);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login,string ReturnUrl="/")
        {
            if (ModelState.IsValid)
            {
                if (loginRepository.IsExitUser(login.UserName, login.Password))
                {
                    FormsAuthentication.SetAuthCookie(login.UserName, login.RememberMe);
                    return Redirect(ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("UserName", "کاربری یافت نشد ");
                }
            }

            return View(login);
        }
         //[AllowAnonymous]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}