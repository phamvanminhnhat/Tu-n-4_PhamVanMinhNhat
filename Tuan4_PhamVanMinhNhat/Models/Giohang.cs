using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuan4_PhamVanMinhNhat.Models
{
    public class Giohang : Controller
    {
        // GET: Giohang
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }


        [Display(Name = "Tên sách")]
        public string tensach { get; set; }


        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }

        [Display(Name = "Gía bán")]
        public Double giaban { get; set; }

        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }

        [Display(Name = "Thành tiền")]

        public Double dThanhtien { get { return iSoluong * giaban; } }

        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            iSoluong = 1;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}