using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssestCategory.DAL;
using AssestCategory.DTO;
using AssestCategory.Utilities;

namespace AssestCategory.Controllers
{
    public class AssestCategoryController : Controller
    {
        GetClassDAL getClassDAL = new GetClassDAL();
        CategorySubDAL categorySubDAL = new CategorySubDAL();
        AssestDataDTO assestDataDTO = new AssestDataDTO();
        BasicUtilities _basicUtilities = new BasicUtilities();
        // GET: AssestCategory
        public ActionResult AssestCategory()
        {
            DataTable dt = new DataTable();
            dt = categorySubDAL.GetData();
            List<Dictionary<string, object>> _list = new List<Dictionary<string, object>>();
            _list = _basicUtilities.GetTableRows(dt);
            ViewBag.Data = _list;
            return View();
        }
        [HttpPost]
        public JsonResult getClass()
        {
            DataTable dt = getClassDAL.GetClassData();
            List<Dictionary<string, object>> _ChannelList = _basicUtilities.GetTableRows(dt);
            return Json(_ChannelList);

        }
        [HttpPost]
        public JsonResult SubCat(string categoryId, string categoryName, string categoryCode, string classList, bool activeStatus)
        {
            string createdBy = "7500018";
            DataTable res = categorySubDAL.Submit(categoryId, categoryName, categoryCode, classList, createdBy, activeStatus);
            if (res.Rows.Count > 0)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [HttpPost]
        public ActionResult Updates(AssestDataDTO assestDataDTO)
        {
            string createdBy = "7500018";
            DataTable res = categorySubDAL.Update(assestDataDTO.categoryId, assestDataDTO.categoryName, assestDataDTO.categoryCode, assestDataDTO.classList, createdBy, assestDataDTO.activeStatus);
            if (res.Rows.Count > 0)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

    }
}