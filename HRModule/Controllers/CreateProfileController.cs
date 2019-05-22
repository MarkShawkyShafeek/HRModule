using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRModuleBL;
using HRModule.Models;
using System.Configuration;
namespace HRModule.Controllers
{
    public class CreateProfileController : Controller
    {
        User user = new User();
        Branch brn = new Branch();
        // GET: CreateProfile
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult PersonalInformation()
        {
            var UserList = user.Query;
            ViewBag.UserData = UserList;
            return View();
        }

        [HttpGet]
        public ActionResult JobInformation()
        {
           // ConnectionConfig config = new ConnectionConfig();
            

          //  brn.Query.AddResultColumn(Branch.ColumnNames.ID);
          //  brn.Query.AddResultColumn(Branch.ColumnNames.Name);

            // List<Branch> listItem = new List<Branch>(brn.Name, brn.s_ID);
            // ListItem item = new ListItem(area.Name, area.s_ID);
            BranchModel brnModel = new BranchModel();
            List<BranchModel> Blist = new List<BranchModel>();

            
            if (brn.Query.Load())
            {
                if (brn.DefaultView != null && brn.DefaultView.Count > 0)
                {

                    do
                    {
                        brnModel.ID = int.Parse(Branch.ColumnNames.ID);
                        brnModel.Name = Branch.ColumnNames.Name;
                        Blist.Add(brnModel);
                    } while (brn.MoveNext());

                }
            }




            return View(Blist);
        }

        //[HttpPost]
        //public ActionResult JobInformation()
        //{
            

        //    return View();
        //}

    }
}