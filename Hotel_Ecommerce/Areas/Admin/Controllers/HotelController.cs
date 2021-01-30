using Hotel_Ecommerce.Areas.Admin.Model;
using Hotel_Ecommerce.DAL.Concrete;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using static Hotel_Ecommerce.Areas.Admin.Model.OtelEklemeveGuncelleme;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]

    public class HotelController : AdminBaseController
    {
        [Route("create-hotel")]

        public ActionResult CreateHotel()
        {

            OtelEklemeveGuncelleme OtelEklemeveGuncelleme = new OtelEklemeveGuncelleme
            {
                OdaOzellikleri = _unitOfWork.OdaOzellikListesi.ToList().OrderBy(x => x.OdaOzellikAdi).ToList(),
                OtelOzellikleri = _unitOfWork.OtelOzellikListesi.ToList().OrderBy(x => x.OtelOzellik).ToList(),
                OtelTemalariListesi = _unitOfWork.OtelTemalariListesi.ToList().OrderBy(x => x.TemaAdi).ToList()
            };
            return View(OtelEklemeveGuncelleme);
        }




        [Route("hotel-list")]

        public ActionResult HotelList()
        {
            return View(_unitOfWork.Oteller.ToList());
        }


        [Route("create-hotel-post")]
        [ValidateInput(false)]
        public ActionResult CreateHotelPost(string otelprogrami, string odaprogrami)
        {
            string sliderPath = "";
            string screenImage = "";
            try
            {
                string GallerySessionID = Request.Form["GallerySessionID"];

                sliderPath = Session["gallery_SliderPath_" + GallerySessionID].ToString();
                screenImage = Session["gallery_ScreenImage_" + GallerySessionID].ToString();

                string oteladi = Request.Form["oteladi"];
                string otelbolgesi = Request.Form["otelbolgesi"];
                string otelil = Request.Form["otelil"];
                string otelilce = Request.Form["otelilce"];
                string otelsezonu = Request.Form["otelsezonu"];
                string oteldivbilgi = Request.Form["oteldivbilgi"];
                string oteloncelik = Request.Form["oteloncelik"];
                string otelsehirotelimi = Request.Form["otelsehirotelimi"];

                bool otelonceliklimi;
                bool sehirotelimi;
                if (oteloncelik == "Öncelik Ver")
                {
                    otelonceliklimi = true;
                }
                else
                {
                    otelonceliklimi = false;
                }
                if (otelsehirotelimi == "Evet")
                {
                    sehirotelimi = true;
                }
                else
                {
                    sehirotelimi = false;
                }
                string otelkonumu = Request.Form["otelkonumu"];
                string konaklamatipleri = Request.Form["konaklamatipleri"];
                string oteltemalari = Request.Form["oteltemalari"];

                string otelozellikleri = Request.Form["otelozellikleri"];
                string odaozellikleri = Request.Form["odaozellikleri"];

                string otelkisabilgi = Request.Form["otelkisabilgi"];
                string otellink = LinkOlustur(otelbolgesi) + "/" + LinkOlustur(otelil) + "-" + LinkOlustur(otelilce) + "-otelleri/" + LinkOlustur(oteladi);

                bool otelvarmi = _unitOfWork.Oteller.Any(x => x.OtelLink == otellink);
                Random rnd = new Random();

                if (oteladi.Trim() != string.Empty && otelbolgesi.Trim() != string.Empty && otelil.Trim() != string.Empty && otelilce.Trim() != string.Empty && otelsezonu.Trim() != string.Empty && oteldivbilgi.Trim() != string.Empty && oteloncelik.Trim() != string.Empty && otelkonumu.Trim() != string.Empty && konaklamatipleri.Trim() != string.Empty && otelsehirotelimi.Trim() != string.Empty && otelozellikleri.Trim() != string.Empty && odaozellikleri.Trim() != string.Empty && otelprogrami.Trim() != string.Empty && odaprogrami.Trim() != string.Empty && oteltemalari.Trim() != string.Empty)
                {
                    if (otelvarmi == false)
                    {

                        Oteller data = new Oteller { OtelAdi = oteladi, OtelBolgesi = otelbolgesi, Otelil = otelil, Otelilce = otelilce, OtelSezonu = otelsezonu, OtelDivBilgi = oteldivbilgi, OtelOncelik = otelonceliklimi, OtelXYKoordinat = otelkonumu, KonaklamaTipi = konaklamatipleri, SehirOteli = sehirotelimi, OtelAktifMi = true, OtelAciklama = otelprogrami, OdaAciklama = odaprogrami, OtelAnasayfaResmi = screenImage, OtelGaleriKlasor = sliderPath, OtelDosyaLink = "#", OtelEklenmeTarihi = DateTime.Now, OtelGoruntulenmeSayisi = rnd.Next(100, 110), OtelPuan = rnd.Next(78, 94), OtelKisaBilgi = otelkisabilgi, OtelLink = otellink, IsActive = true, IsDeleted = false, CreatedDate = DateTime.Now };
                        _unitOfWork.Oteller.Insert(data);
                        _unitOfWork.Save();
                        string[] OtelOzellikList = otelozellikleri.Split(',');
                        string id = _unitOfWork.Oteller.FirstOrDefault(x => x.OtelLink == otellink)._id;
                        foreach (var item in OtelOzellikList)
                        {
                            if (item != "")
                            {

                                OtelOzellikleri odata = new OtelOzellikleri { OlanakAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OtelOzellikleri.Insert(odata);
                                _unitOfWork.Save();
                            }
                        }
                        string[] OdaOzellikList = odaozellikleri.Split(',');
                        foreach (var item in OdaOzellikList)
                        {
                            if (item != "")
                            {

                                OdaOzellikleri Odadata = new OdaOzellikleri { OdaOzellikAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OdaOzellikleri.Insert(Odadata);
                                _unitOfWork.Save();
                            }
                        }

                        string[] OtelTemaList = oteltemalari.Split(',');
                        foreach (var item in OtelTemaList)
                        {
                            if (item != "")
                            {

                                OtelTemalari otelTema = new OtelTemalari { OtelTemaAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OtelTemalari.Insert(otelTema);
                                _unitOfWork.Save();
                            }
                        }


                        Session.Remove("secilengaleri");
                        Session.Remove("secilenanasayfaresmi");


                        var deger = new { islem = "onaylandi" };
                        return Json(deger);
                    }
                    else
                    {
                        var deger = new { islem = "ayniotel" };
                        return Json(deger);
                    }
                }
                else
                {
                    var deger = new { islem = "boşkayit" };
                    return Json(deger);
                }



            }
            catch (Exception ex)
            {
                if (sliderPath == string.Empty)
                {
                    var deger = new { islem = "galeriyok" };
                    return Json(deger);
                }
                else
                {
                    var deger = new { islem = "404" };
                    return Json(deger);
                }

            }
        }

        [Route("update-hotel-post")]
        [ValidateInput(false)]
        public ActionResult UpdateHotelPost(string otelprogrami, string odaprogrami, string HotelID)
        {
            string sliderPath = "";
            string screenImage = "";
            try
            {
                var otel = _unitOfWork.Oteller.FirstOrDefault(x => x._id == HotelID);
                string GallerySessionID = Request.Form["GallerySessionID"];


                if (Session["gallery_SliderPath_" + GallerySessionID] != null)
                {
                    sliderPath = Session["gallery_SliderPath_" + GallerySessionID].ToString();
                    screenImage = Session["gallery_ScreenImage_" + GallerySessionID].ToString();
                    otel.OtelGaleriKlasor = sliderPath;
                    otel.OtelAnasayfaResmi = screenImage;
                }


                string oteladi = Request.Form["oteladi"];
                string otelbolgesi = Request.Form["otelbolgesi"];
                string otelil = Request.Form["otelil"];
                string otelilce = Request.Form["otelilce"];
                string otelsezonu = Request.Form["otelsezonu"];
                string oteldivbilgi = Request.Form["oteldivbilgi"];
                string oteloncelik = Request.Form["oteloncelik"];
                string otelsehirotelimi = Request.Form["otelsehirotelimi"];

                bool otelonceliklimi;
                bool sehirotelimi;
                if (oteloncelik == "Öncelik Ver")
                {
                    otelonceliklimi = true;
                }
                else
                {
                    otelonceliklimi = false;
                }
                if (otelsehirotelimi == "Evet")
                {
                    sehirotelimi = true;
                }
                else
                {
                    sehirotelimi = false;
                }
                string otelkonumu = Request.Form["otelkonumu"];
                string konaklamatipleri = Request.Form["konaklamatipleri"];
                string oteltemalari = Request.Form["oteltemalari"];

                string otelozellikleri = Request.Form["otelozellikleri"];
                string odaozellikleri = Request.Form["odaozellikleri"];

                string otelkisabilgi = Request.Form["otelkisabilgi"];
                string otellink = LinkOlustur(otelbolgesi) + "/" + LinkOlustur(otelil) + "-" + LinkOlustur(otelilce) + "-otelleri/" + LinkOlustur(oteladi);

                bool otelvarmi = _unitOfWork.Oteller.Any(x => x.OtelLink == otellink && x._id != HotelID);
                Random rnd = new Random();

                if (oteladi.Trim() != string.Empty && otelbolgesi.Trim() != string.Empty && otelil.Trim() != string.Empty && otelilce.Trim() != string.Empty && otelsezonu.Trim() != string.Empty && oteldivbilgi.Trim() != string.Empty && oteloncelik.Trim() != string.Empty && otelkonumu.Trim() != string.Empty && konaklamatipleri.Trim() != string.Empty && otelsehirotelimi.Trim() != string.Empty && otelozellikleri.Trim() != string.Empty && odaozellikleri.Trim() != string.Empty && otelprogrami.Trim() != string.Empty && odaprogrami.Trim() != string.Empty && oteltemalari.Trim() != string.Empty)
                {
                    if (otelvarmi == false)
                    {

                        

                        otel.OtelAdi = oteladi;
                        otel.OtelBolgesi = otelbolgesi;
                        otel.Otelil = otelil;
                        otel.Otelilce = otelilce;
                        otel.OtelSezonu = otelsezonu;
                        otel.OtelDivBilgi = oteldivbilgi;
                        otel.OtelOncelik = otelonceliklimi;
                        otel.OtelXYKoordinat = otelkonumu;
                        otel.KonaklamaTipi = konaklamatipleri;
                        otel.SehirOteli = sehirotelimi;
                        otel.OtelAktifMi = true;
                        otel.OtelAciklama = otelprogrami;
                        otel.OdaAciklama = odaprogrami;
                        otel.OtelDosyaLink = "#";
                        otel.OtelKisaBilgi = otelkisabilgi;
                        otel.OtelLink = otellink; 
                        _unitOfWork.Oteller.Update(otel);
                        _unitOfWork.Save();


                        _unitOfWork.OtelOzellikleri.RemoveRange(_unitOfWork.OtelOzellikleri.Where(x => x.OtelSubID == HotelID));
                        _unitOfWork.Save();
                        string[] OtelOzellikList = otelozellikleri.Split(',');
                        string id = _unitOfWork.Oteller.FirstOrDefault(x => x.OtelLink == otellink)._id;
                        foreach (var item in OtelOzellikList)
                        {
                            if (item != "")
                            {

                                OtelOzellikleri odata = new OtelOzellikleri { OlanakAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OtelOzellikleri.Insert(odata);
                                _unitOfWork.Save();
                            }
                        }

                        _unitOfWork.OdaOzellikleri.RemoveRange(_unitOfWork.OdaOzellikleri.Where(x => x.OtelSubID == HotelID));
                        _unitOfWork.Save();
                        string[] OdaOzellikList = odaozellikleri.Split(',');
                        foreach (var item in OdaOzellikList)
                        {
                            if (item != "")
                            {

                                OdaOzellikleri Odadata = new OdaOzellikleri { OdaOzellikAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OdaOzellikleri.Insert(Odadata);
                                _unitOfWork.Save();
                            }
                        }
                        _unitOfWork.OtelTemalari.RemoveRange(_unitOfWork.OtelTemalari.Where(x => x.OtelSubID == HotelID));
                        _unitOfWork.Save();
                        string[] OtelTemaList = oteltemalari.Split(',');
                        foreach (var item in OtelTemaList)
                        {
                            if (item != "")
                            {

                                OtelTemalari otelTema = new OtelTemalari { OtelTemaAdi = item.ToString(), OtelSubID = id };
                                _unitOfWork.OtelTemalari.Insert(otelTema);
                                _unitOfWork.Save();
                            }
                        }


                        Session.Remove("secilengaleri");
                        Session.Remove("secilenanasayfaresmi");


                        var deger = new { islem = "onaylandi" };
                        return Json(deger);
                    }
                    else
                    {
                        var deger = new { islem = "ayniotel" };
                        return Json(deger);
                    }
                }
                else
                {
                    var deger = new { islem = "boşkayit" };
                    return Json(deger);
                }



            }
            catch (Exception ex)
            {
                if (sliderPath == string.Empty)
                {
                    var deger = new { islem = "galeriyok" };
                    return Json(deger);
                }
                else
                {
                    var deger = new { islem = "404" };
                    return Json(deger);
                }

            }
        }

        [Route("update-hotel/{HotelID}")]
        public ActionResult UpdateHotel(string HotelID)
        {


            OtelEklemeveGuncelleme OtelEklemeveGuncelleme = new OtelEklemeveGuncelleme
            {
                OdaOzellikleri = _unitOfWork.OdaOzellikListesi.ToList().OrderBy(x => x.OdaOzellikAdi).ToList(),
                OtelOzellikleri = _unitOfWork.OtelOzellikListesi.ToList().OrderBy(x => x.OtelOzellik).ToList(),
                OtelTemalariListesi = _unitOfWork.OtelTemalariListesi.ToList().OrderBy(x => x.TemaAdi).ToList(),
                Data = new HotelEdit
                {
                    Otel = _unitOfWork.Oteller.FirstOrDefault(x => x._id == HotelID),
                    SeciliOdaOzellikleri = _unitOfWork.OdaOzellikleri.Where(x => x.OtelSubID == HotelID).OrderBy(x => x.OdaOzellikAdi).ToList(),
                    SeciliOtelOzellikleri = _unitOfWork.OtelOzellikleri.Where(x => x.OtelSubID == HotelID).OrderBy(x => x.OlanakAdi).ToList(),
                    SeciliOtelTemalariListesi = _unitOfWork.OtelTemalari.Where(x => x.OtelSubID == HotelID).OrderBy(x => x.OtelTemaAdi).ToList()
                }
            };
            return View(OtelEklemeveGuncelleme);
        }

        [Route("ajax-change-hotel-status")]
        public ActionResult ChangeHotelStatus(string HotelID)
        {
            var product = _unitOfWork.Oteller.Find(x => x._id == HotelID);
            product.IsActive = product.IsActive ? false : true;
            _unitOfWork.Oteller.Update(product);
            _unitOfWork.Save();
            return Json(HttpStatusCode.OK);
        }

        [Route("ajax-delete-hotel")]
        public ActionResult DeleteHotel(string HotelID)
        {
            _unitOfWork.OtelOzellikleri.RemoveRange(_unitOfWork.OtelOzellikleri.Where(x => x.OtelSubID == HotelID));
            _unitOfWork.OtelTemalari.RemoveRange(_unitOfWork.OtelTemalari.Where(x => x.OtelSubID == HotelID));
            _unitOfWork.OdaOzellikleri.RemoveRange(_unitOfWork.OdaOzellikleri.Where(x => x.OtelSubID == HotelID));
            var product = _unitOfWork.Oteller.Find(x => x._id == HotelID);
            _unitOfWork.Oteller.Delete(product);
            _unitOfWork.Save();
            return Json(HttpStatusCode.OK);
        }

        #region "Kod Oluştur"
        public static string LinkOlustur(string Text)
        {
            try

            {
                string strReturn = Text.Trim();
                strReturn = strReturn.Replace("ğ", "g");
                strReturn = strReturn.Replace("Ğ", "G");
                strReturn = strReturn.Replace("ü", "u");
                strReturn = strReturn.Replace("Ü", "U");
                strReturn = strReturn.Replace("ş", "s");
                strReturn = strReturn.Replace("Ş", "S");
                strReturn = strReturn.Replace("ı", "i");
                strReturn = strReturn.Replace("İ", "i");
                strReturn = strReturn.Replace("I", "i");
                strReturn = strReturn.Replace("ö", "o");
                strReturn = strReturn.Replace("Ö", "O");
                strReturn = strReturn.Replace("ç", "c");
                strReturn = strReturn.Replace("Ç", "C");
                strReturn = strReturn.Replace("-", "+");
                strReturn = strReturn.Replace(" ", "+");
                strReturn = strReturn.Trim();
                strReturn = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9+]").Replace(strReturn, "");
                strReturn = strReturn.Trim();
                strReturn = strReturn.Replace("+", "-").ToLower();
                return strReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #endregion
    }
}