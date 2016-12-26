using System.Web.Mvc;
using Apps.Core;

namespace Apps.Controllers
{
    public class VerifyController : Controller
    {
        // GET: Verify
        public ActionResult GetVerifyCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(5);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }
    }
}