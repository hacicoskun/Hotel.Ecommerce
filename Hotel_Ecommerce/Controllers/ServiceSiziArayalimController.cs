using Hotel_Ecommerce.Areas.Admin.Controllers;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.Helper;
using Hotel_Ecommerce.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class ServiceSiziArayalimController : AdminBaseController
    {
        // GET: ServiceSiziArayallim
        
        [Route("ajax-service-sizi-arayalim")]
        public string ProcessRequest (string adisoyadi,string telefon,string email,string konu,string tarih,string saat,string kampanya)
        {

            string VisitorsIPAddr = string.Empty;
            DateTime kayittarihi = DateTime.Now;
            string ipadress = VisitorsIPAddr;
            
            SiziArayalim s = new SiziArayalim { Adsoyad = adisoyadi, Telefon = telefon, Email = email, Konu = konu, Aramatarihi = tarih, Aramazamani = saat, Islemtarihi = kayittarihi, Ipadresi = ipadress };
            if (kampanya == "true")
            {
                BiziTakipEdin b = new BiziTakipEdin { Adsoyad = adisoyadi, Email = email, Ipadresi = VisitorsIPAddr, IslemTarihi = DateTime.Now };
                _unitOfWork.BiziTakipEdin.Insert(b);
            }
            _unitOfWork.SiziArayalim.Insert(s);
            _unitOfWork.Save();

            string mailbody = "<table style='background-color:#fff;padding:10px;width:620px;text-align:left;border-top:10px solid #E3000F;border-bottom:10px solid #E3000F;border-left:10px solid #E3000F;border-right:10px solid #E3000F' width='630' cellspacing='0' cellpadding='0'><tbody><tr><td><table style='background-color:#ffffff;' width='100%' cellspacing='0' cellpadding = '0'>  <tbody><tr><td style = 'padding: 10px;'><a href = 'http://www.becoming.com.tr' target = '_blank'  > <img src = '~/Content/assest/images/logo.png' alt = '' width = '200' height = '68' border = '0' /></a></td><td style = 'color: #1a2640; font-family: Arial; font-size: 13px;margin-left:50px;' align = 'right' > (312) 435 96 16 <span style = 'color: #a5b9c5; font-size: 24px;' >|</span> <a style = 'text-decoration: none; color: #1a2640;' href = 'http://www.becoming.com.tr/iletisim' target = '_blank' data - saferedirecturl = 'http://www.becoming.com.tr/iletisim'> www.becomingtur.com.tr </a> &nbsp; &nbsp; &nbsp;</td></tr><tr><td colspan = '2' ><hr style='border: 1px dashed black;'/> </td></tr><tr><td style = 'padding: 10px; font-size: 12px; font-family: Arial;' colspan = '2' ><p style = 'margin: 0 0 10px 0;' >Sayın <strong>" + adisoyadi + "</strong>,</p><p style = 'margin: 0 0 10px 0;' > " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " tarihinde, " + konu + " hakkında görüşme talebinde bulundunuz.Arama talebiniz doğrultusunda " + tarih + " saat " + saat + " 'da ilgili tur departmanımız tarafından iletişime geçilecektir.</p><h5><strong>Arama Bilgileri </strong></h5><strong> Müşteri Adı:</strong> " + adisoyadi + " <br/><strong> Aranacak Tarih:</strong> " + tarih + " <br /> <strong> Aranacak Saat:</strong>  " + saat + " <br /> <strong>Departman:</strong>  " + konu + "<br /><h5><strong> İletişim Bilgileri </strong ></h5><strong> Kişi Adı:</strong>" + adisoyadi + " <br /> <strong> Telefon No:</strong> " + telefon + " <br /> <strong> E-mail Adresi </strong> " + email + " <br /> <br /><p style = 'margin: 0 0 0 0;' >Her türlü sorunuzda bize <a style = 'color: #000000;' href = 'mailto:info@becoming.com' target = '_blank' > info@becomingtur.com </a> adresinden ulaşabilir veya<a href = 'tel:+90(312)4359616' target = '_blank' > +90 (312) 425 13 33 </a> nolu telefondan müşteri hizmetleri ile görüşebilirsiniz.</p><p style = 'margin: 20px 0 0 0;' > Saygılarımızla,</p><p style = 'margin: 5px 0 0 0;' > Becoming Tur  Müşteri Hizmetleri</p></td></tr><tr><td colspan = '2' ><img src = 'http://www.becoming.com.tr/images/ustborder.png' alt = '' /></td></tr><tr><td style = 'padding: 10px; color: #808080; font-size: 12px;' colspan = '2'><p style = 'margin: 0 0 0 0; font-family: Arial;' > Copyright &copy; 2021 Becomingtur.com.tr Tüm hakları saklıdır.</p></td></tr></tbody></table></td></tr></tbody></table> ";


                 Smtp.MailGonder(mailbody);


            var wrapper = new { gelenadsoyad = adisoyadi, gelentelefon = telefon, gelentarih = tarih, gelensaat = saat, gelenkonu = konu };
            return JsonConvert.SerializeObject(wrapper);

            



        }


    }
}
