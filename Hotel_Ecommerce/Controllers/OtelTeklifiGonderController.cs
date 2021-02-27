using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class OtelTeklifiGonderController : Controller
    {
        // GET: OtelTeklifiGonder
        [Route("ajax-fiyat-gonder")]
        public string OtelTeklifiGonder(string txtoteladi,string txtreztarihi,string txtyolcuadi,string txtyolcutel,string txtyolcuemail,string txtysayisi,string txtcsayisi,string txtcocuk1yas,string txtcocuk2yas)
        {
            var cocukdiv = "";
            var mailbody = "";
            if (txtcsayisi == "2")
            {
                cocukdiv = "<strong>Çocuk 1 Yaş: </strong>" + txtcocuk1yas + "<br/><strong>Çocuk 2 Yaş: </strong>" + txtcocuk2yas;
            }
            else if (txtcsayisi == "1")
            {
                cocukdiv = "<strong>Çocuk 1 Yaş: </strong>" + txtcocuk1yas;

            }

            mailbody = "<table style='background-color:#fff;padding:10px;width:620px;text-align:left;border-top:10px solid #E3000F;border-bottom:10px solid #E3000F;border-left:10px solid #E3000F;border-right:10px solid #E3000F' width='630' cellspacing='0' cellpadding='0'><tbody><tr><td><table style='background-color:#ffffff;' width='100%' cellspacing='0' cellpadding = '0'>  <tbody><tr><td style = 'padding: 10px;'><a href = 'http://www.becomingtur.com.tr' target = '_blank'  > <img src = 'http://www.becomingtur.com.tr/images/Logo.png' alt = '' width = '200' height = '68' border = '0' /></a></td><td style = 'color: #1a2640; font-family: Arial; font-size: 13px;margin-left:50px;' align = 'right' > 0(312) 435 96 16 <span style = 'color: #a5b9c5; font-size: 24px;' >|</span> <a style = 'text-decoration: none; color: #1a2640;' href = 'http://www.becomingtur.com.tr/iletisim' target = '_blank' data - saferedirecturl = 'http://www.becomingtur.com.tr/iletisim'> www.becomingtur.com.tr </a> &nbsp; &nbsp; &nbsp;</td></tr><tr><td colspan = '2' ><hr style='border: 1px dashed black;'/> </td></tr><tr><td style = 'padding: 10px; font-size: 12px; font-family: Arial;' colspan = '2' ><p style = 'margin: 0 0 10px 0;' > Sayın <strong>" + txtyolcuadi + "</strong>,</p><p style = 'margin: 0 0 10px 0;' > " + DateTime.Now.ToString() + " tarihinde," + txtoteladi + "</strong> adlı otel için ön rezervasyon talebinde bulundunuz.Yetkililerimiz en kısa sürede sizinle iletişime geçecektir.</p><h5><strong> İletişim Bilgileri </strong ></h5><strong> Kişi Adı: </strong>" + txtyolcuadi + " <br /> <strong> Telefon No: </strong> " + txtyolcutel + " <br /> <strong> E-mail Adresi </strong> " + txtyolcuemail + " <h5><strong> Ön Rezervasyon Bilgileri </strong ></h5> <strong> Otel Adı: </strong> " + txtoteladi + " <br />  <strong> Ön Rezervasyon Tarihi: </strong> " + txtreztarihi + " <br /> <strong> Yetişkin Sayısı: </strong> " + txtysayisi + " <br /><strong> Çocuk Sayısı: </strong>" + txtcsayisi + " <br />" + cocukdiv + "<br /><p style = 'margin: 0 0 0 0;' >Her türlü sorunuzda bize <a style = 'color: #000000;' href = 'mailto:info@becomingtur.com.tr' target = '_blank' > info@becomingtur.com.tr </a> adresinden ulaşabilir veya<a href = 'tel:+90(312)4359616' target = '_blank' > +90(312) 435 96 16 </a> nolu telefondan müşteri hizmetleri ile görüşebilirsiniz.</p><p style = 'margin: 20px 0 0 0;' > Saygılarımızla,</p><p style = 'margin: 5px 0 0 0;' > Becoming Tur Müşteri Hizmetleri</p></td></tr><tr><td colspan = '2' ><hr style='border: 1px dashed black;'/></td></tr><tr><td style = 'padding: 10px; color: #808080; font-size: 12px;' colspan = '2'><p style = 'margin: 0 0 0 0; font-family: Arial;' > Copyright &copy; 2017 becomingtur.com.tr Tüm hakları saklıdır.</p></td></tr></tbody></table></td></tr></tbody></table> ";

            OtelTeklifleri teklif = new OtelTeklifleri { OtelAdi = txtoteladi, Adsoyad = txtyolcuadi, Telefon = txtyolcutel, Email = txtyolcuemail, YetiskinSayisi = txtysayisi, CocukSayisi = txtcsayisi, Cocuk1Yas = txtcocuk1yas, Cocuk2Yas = txtcocuk2yas, Ipadresi="1234" ,RezTarihi = txtreztarihi, IslemTarihi = DateTime.Now };
            DateTime kayittarihi = DateTime.Now;
            Smtp.MailGonder(mailbody);
            var deger = new { islem = "true" };
            return JsonConvert.SerializeObject(deger);

        }
    }
}