using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newtest.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        /// <summary>
        /// 联系方式
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /// <summary>
        /// Welcome
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {

            return View();
        }
        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List(int page=7)
        {
            String[] data = new string[] { "在Linux开发.NET——拜拜了Win10",
                "微软开源LightGBM：轻量级梯度Boosting框架",
                "Go 1.7.2 版本发布了。",
                "Git 项目推荐 | lyadmin 轻量级通用后台" };
            //ViewBag.data = data;
            //Viewdata["data"]=data
            ViewData.Model = data;
            ViewBag.Page = page;
            return View();

        }

        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();

        }

        /// <summary>
        /// 保存新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title,string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();

        }
    }
}