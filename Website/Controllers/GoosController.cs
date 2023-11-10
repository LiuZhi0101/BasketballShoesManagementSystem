using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using PagedList.Mvc;
using PagedList;
using System.Data.Entity;
using System.Configuration;
using System.Net;
using System.Text;
using System.IO;

namespace Website.Controllers
{
    public class GoosController : Controller
    {
        GoodsDBEntities1 db = new GoodsDBEntities1();
        // GET: Goos
        public ActionResult Index()
        {
            IEnumerable<Goods> goods = db.Goods.ToList();
            return View(goods);
        }
        public ActionResult RuGoodsPuls(int? page)
        {

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods.Where(i => i.Goods_Place ==9).ToList().ToPagedList(pageNumber, pageSize);
            //IPagedList<Goods> pagedGoodsList = goodsList.ToPagedList(pageNumber, pageSize);
            return View(userList);

        }
        [HttpPost]
        public ActionResult RuGoodsPuls(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods.Where(i => i.Ru_Uid.Contains(chat) || i.Goods_Name.Contains(chat) || i.Goods_Spec.Contains(chat) || i.Goods_Type.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult ChuGoodsPuls(int? page)
        {

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods.Where(i => i.Goods_Place ==8).ToList().ToPagedList(pageNumber, pageSize);
            //IPagedList<Goods> pagedGoodsList = goodsList.ToPagedList(pageNumber, pageSize);
            return View(userList);

        }
        [HttpPost]
        public ActionResult ChuGoodsPuls(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods.Where(i => i.Ru_Uid.Contains(chat) || i.Goods_Name.Contains(chat) || i.Goods_Spec.Contains(chat) || i.Goods_Type.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult GoodsPuls(int? page)
        {

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods.Where(i => i.Goods_Place < 8).ToList().ToPagedList(pageNumber, pageSize);
            //IPagedList<Goods> pagedGoodsList = goodsList.ToPagedList(pageNumber, pageSize);
            return View(userList);

        }
        [HttpPost]
        public ActionResult GoodsPuls(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods.Where(i => i.Ru_Uid.Contains(chat) || i.Goods_Name.Contains(chat) || i.Goods_Spec.Contains(chat) || i.Goods_Type.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult DamageAdmin(string id)
        {
            int ID = int.Parse(id);
            var uss = db.Goods.Where(i => i.Goods_ID == ID).FirstOrDefault();
            var us = db.Goods_Damage.Where(m => m.Damage_Uid == uss.Goods_ID).FirstOrDefault();
            uss.Goods_Number = uss.Goods_Number - us.Damage_Number;
            Goods goods = new Goods();
            goods.Ru_Uid = us.Damage_Uid.ToString();
            goods.Goods_Name = us.Damage_Name;
            goods.Goods_Spec = us.Damage_Spec;
            goods.Goods_Brand = us.Damage_Brand;
            goods.Goods_Number = us.Damage_Number;
            goods.Goods_Place = 9;
            goods.Goods_Type = us.Damage_Type;
            us.Damage_state = 2;
            db.Goods.Add(goods);
            db.SaveChanges();
            return Content("<script>alert('报损成功！');location.href='ChuAdmin'</script>");
        }
        public ActionResult DamageAdmins(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods_Damage.Where(i=>i.Damage_state==1).ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult DamageAdmins(string chat,int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Damage.Where(i => i.Damage_Name.Contains(chat) || i.Damage_Type.Contains(chat) || i.Damage_Spec.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult ChuAdmins(string id)
        {
            int ID = int.Parse(id);
            var uss = db.Goods.Where(i => i.Goods_ID == ID).FirstOrDefault();
            var us = db.Goods_Chu.Where(m => m.Chu_Uid == uss.Goods_ID).FirstOrDefault(); 
            uss.Goods_Number = uss.Goods_Number - us.Chu_Number;
            Goods goods = new Goods();
            goods.Ru_Uid = us.Chu_Uid.ToString();
            goods.Goods_Name = us.Chu_Name;
            goods.Goods_Spec = us.Chu_Spec;
            goods.Goods_Brand = us.Chu_Brand;
            goods.Goods_Number = us.Chu_Number;
            goods.Goods_Place = us.Chu_Place;
            goods.Goods_Type = us.Chu_Type;
            us.Chu_state = 2;
            db.Goods.Add(goods);
            db.SaveChanges();
            return Content("<script>alert('出库成功！');location.href='ChuAdmin'</script>");
        }
        public ActionResult ChuAdmin(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods_Chu.Where(i=>i.Chu_state==1).ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult ChuAdmin(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Chu.Where(i => i.Chu_Name.Contains(chat) || i.Chu_Type.Contains(chat) || i.Chu_Spec.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult RuAdmin(string id)
        {
            
            int ID = int.Parse(id);

            var us = db.Goods_Ru.Where(i => i.Ru_ID == ID ).FirstOrDefault();
            var uid = db.Goods.Where(m => m.Ru_Uid==us.Ru_Uid && m.Goods_Place==us.Ru_Place).FirstOrDefault();
            if (uid!=null)
            {
                uid.Goods_Number +=us.Ru_Number;
                us.Ru_state = 2;
                db.SaveChanges();
                return Content("<script>alert('入库成功！');location.href='AdminIndex'</script>");
            }
            else
            {
                Goods goods = new Goods();
                goods.Ru_Uid = us.Ru_Uid;
                goods.Goods_Name = us.Ru_Name;
                goods.Goods_Spec = us.Ru_Spec;
                goods.Goods_Brand = us.Ru_Brand;
                goods.Goods_Number = us.Ru_Number;
                goods.Goods_Place = us.Ru_Place;
                goods.Goods_Type = us.Ru_Type;
                us.Ru_state = 2;
                db.Goods.Add(goods);
                db.SaveChanges();
                return Content("<script>alert('入库成功！');location.href='AdminIndex'</script>");
            }
            
        }
        public ActionResult AdminIndex(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            //var userList = db.Goods_Ru.ToList().ToPagedList(pageNumber, pageSize);
            var userList = db.Goods_Ru.Where(gg => gg.Ru_state == 1).ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult AdminIndex(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Ru.Where(i => i.Ru_Uid.Contains(chat) || i.Ru_Name.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        //发送验证码
        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];
        public JsonResult Phone(string phones)
        {

            int id = db.Admin_Info.Where(u => u.Admin_Phone == phones).Select(m => m.Admin_ID).FirstOrDefault();

            if (id > 0)
            {
                string account = "C42633319";//用户名是登录用户中心->验证码、通知短信->帐户及签名设置->APIID
                string password = "06078bd9c35f6be9b187bad238543d8d"; //密码是请登录用户中心->验证码、通知短信->帐户及签名设置->APIKEY
                string mobile = phones;
                Random rad = new Random();
                int mobile_code = rad.Next(1000, 10000);
                string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";
                string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

                 UTF8Encoding encoding = new UTF8Encoding();
                 byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

                 HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
                 myRequest.Method = "POST";
                 myRequest.ContentType = "application/x-www-form-urlencoded";
                 myRequest.ContentLength = postData.Length;

                 Stream newStream = myRequest.GetRequestStream();
                 //Send the data.
                 newStream.Write(postData, 0, postData.Length);
                 newStream.Flush();
                 newStream.Close();

                 HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                 if (myResponse.StatusCode == HttpStatusCode.OK)
                 {
                     StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                    //Response.Write(reader.ReadToEnd());

                    string res = reader.ReadToEnd();
                    int len1 = res.IndexOf("</code>");
                    int len2 = res.IndexOf("<code>");
                    string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                    //Response.Write(code);

                    int len3 = res.IndexOf("</msg>");
                    int len4 = res.IndexOf("<msg>");
                    string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                    var result = new
                    {
                        yzm = mobile_code,
                        stu_id = id
                    };
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
                 else
                 {
                     //访问失败
                     return Json(0);
                 }
                //var result = new
                //{
                //    yzm = mobile_code,
                //    stu_id = id
                //};
                //return Json(result, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(0);
                //var re = new
                //{
                //    re = 0
                //};
                //return Json(re, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Admin()
        {
            int id = int.Parse(Request["id"].ToString());
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public bool Admin(string Pwd, int ID)
        {
            try
            {
                var user = db.Admin_Info.FirstOrDefault(u => u.Admin_ID == ID);
                user.Admin_Pwd = Pwd;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public ActionResult Goods_DamageT(int ?page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods_Damage.ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult Goods_DamageT(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Damage.Where(i => i.Damage_Name.Contains(chat) || i.Damage_Type.Contains(chat) || i.Damage_Spec.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult Goods_Damage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Goods_Damage(Goods_Damage goods_Damage)
        {
            var us = db.Goods.Where(i => i.Goods_ID == goods_Damage.Damage_Uid && i.Goods_Number > goods_Damage.Damage_Number).FirstOrDefault();
            if (us != null)
            {
                var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Goods_Damage da = new Goods_Damage();
                da.Damage_Uid = us.Goods_ID;
                da.Damage_Name = us.Goods_Name;
                da.Damage_Brand = us.Goods_Brand;
                da.Damage_Spec = us.Goods_Spec;
                da.Damage_Number = goods_Damage.Damage_Number;
                da.Damage_Type = us.Goods_Type;
                da.Damage_Place = "报损仓库";
                da.Damage_Time = DateTime.Parse(time);
                da.Damage_state = 1;
                db.Goods_Damage.Add(da);
                db.SaveChanges();
                return Content("<script>alert('报损申请成功！');location.href='Goods_Damage'</script>");
            }
            else
            {
                return Content("<script>alert('报损申请失败！');location.href='Goods_Damage'</script>");
            }
        }
        public ActionResult ChuGoodsT(int ?page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods_Chu.ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult ChuGoodsT(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Chu.Where(i => i.Chu_Name.Contains(chat) || i.Chu_Type.Contains(chat) || i.Chu_Spec.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult ChuGoods()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChuGoods(Goods_Chu goods_Chu)
        {
            var us = db.Goods.Where(i => i.Goods_ID == goods_Chu.Chu_Uid && i.Goods_Number > goods_Chu.Chu_Number ).FirstOrDefault();
            if (us != null)
            {
                var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Goods_Chu chu = new Goods_Chu();
                chu.Chu_Uid = us.Goods_ID;
                chu.Chu_Name = us.Goods_Name;
                chu.Chu_Brand = us.Goods_Brand;
                chu.Chu_Spec = us.Goods_Spec;
                chu.Chu_Number = goods_Chu.Chu_Number;
                chu.Chu_Type = us.Goods_Type;
                chu.Chu_Time = DateTime.Parse(time);
                chu.Chu_Place = goods_Chu.Chu_Place;
                chu.Chu_state = 1;
                db.Goods_Chu.Add(chu);
                db.SaveChanges();
                return Content("<script>alert('申请出库成功！');location.href='ChuGoods'</script>");
            }
            else
            {
                return Content("<script>alert('仓库没有此货源或数量不足！');location.href='ChuGoods'</script>");
            }
        }
        public ActionResult RuGoodsT(int ?page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods_Ru.ToList().ToPagedList(pageNumber, pageSize);
            return View(userList);
        }
        [HttpPost]
        public ActionResult RuGoodsT(string chat, int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods_Ru.Where(i => i.Ru_Uid.Contains(chat) || i.Ru_Name.Contains(chat) || i.Ru_Spec.Contains(chat) || i.Ru_Type.Contains(chat) ).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
     
        public ActionResult Goods(int ?page)
        {
            
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var userList = db.Goods.Where(i=>i.Goods_Place<8).ToList().ToPagedList(pageNumber, pageSize);
            //IPagedList<Goods> pagedGoodsList = goodsList.ToPagedList(pageNumber, pageSize);
            return View(userList);
            
        }
        [HttpPost]
        public ActionResult Goods(string chat,int ?page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var results = db.Goods.Where(i => i.Ru_Uid.Contains(chat) || i.Goods_Name.Contains(chat) || i.Goods_Spec.Contains(chat) || i.Goods_Type.Contains(chat)).ToList().ToPagedList(pageNumber, pageSize);
            return View(results);
        }
        public ActionResult RuGoods()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RuGoods(Goods goods)
        {
            var us = db.Goods.Where(i => i.Ru_Uid == goods.Ru_Uid &&i.Goods_Place==goods.Goods_Place &&i.Goods_Spec==goods.Goods_Spec).FirstOrDefault();
            if (us!=null)
            {
                var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Goods_Ru ru = new Goods_Ru();
                ru.Ru_Uid = us.Ru_Uid;
                ru.Ru_Name = us.Goods_Name;
                ru.Ru_Brand = us.Goods_Brand;
                ru.Ru_Spec = us.Goods_Spec;
                ru.Ru_Number = us.Goods_Number;
                ru.Ru_Type = us.Goods_Type;
                ru.Ru_Time = DateTime.Parse(time); 
                ru.Ru_Place = us.Goods_Place;
                ru.Ru_state = 1;
                db.Goods_Ru.Add(ru);
                db.SaveChanges();
                return Content("<script>alert('申请入库成功！');location.href='RuGoods'</script>");
            }
            else
            {
                var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Goods_Ru ruu = new Goods_Ru();
                ruu.Ru_Uid = goods.Ru_Uid;
                ruu.Ru_Name = goods.Goods_Name;
                ruu.Ru_Brand = goods.Goods_Brand;
                ruu.Ru_Spec = goods.Goods_Spec;
                ruu.Ru_Number = goods.Goods_Number;
                ruu.Ru_Type = goods.Goods_Type;
                ruu.Ru_Time = DateTime.Parse(time);
                ruu.Ru_Place = goods.Goods_Place;
                ruu.Ru_state = 1;
                db.Goods_Ru.Add(ruu);
                db.SaveChanges();
                return Content("<script>alert('申请入库成功！');location.href='RuGoods'</script>");
            }
            
        }
        public ActionResult ZhuCe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ZhuCe(Admin_Info admin_Info)
        {
            var uss = db.Admin_Info.Where(i => i.Admin_Uid == admin_Info.Admin_Uid &&i.Admin_Phone==admin_Info.Admin_Phone).FirstOrDefault();
            if (uss!=null)
            {
                return Content("<script>alert('注册失败，账号已存在！');location.href='ZhuCe'</script>");
            }
            else
            {
                Admin_Info us = new Admin_Info();
                us.Admin_Uid =  admin_Info.Admin_Uid;
                us.Admin_Pwd = admin_Info.Admin_Pwd;
                us.Admin_Phone=admin_Info.Admin_Phone;
                db.Admin_Info.Add(us);
                db.SaveChanges();
                return Content("<script>alert('注册成功！');location.href='Login'</script>");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uid,string pwd)
        {
            var uer = db.Admin_Info.Where(i=>i.Admin_Uid==uid && i.Admin_Pwd==pwd).FirstOrDefault();
            if (uer!=null)
            {
                if (uer.Admin_Uid=="admin")
                {
                    return Content("<script>alert('登录成功');location.href='AdminIndex'</script>");
                }
                else
                {
                    HttpCookie usernameCookie = new HttpCookie("username", uid);
                    usernameCookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(usernameCookie);
                    return Content("<script>alert('登录成功');location.href='Index'</script>");
                }
                
            }
            else
            {
                return Content("<script>alert('登录失败，账号或密码错误！');location.href='Login'</script>");
            }
        }
        public ActionResult GoosAdmin()
        {

            return View();
        }

    }
}