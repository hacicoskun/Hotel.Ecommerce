using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.Models;
using Hotel_Ecommerce.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace Hotel_Ecommerce.Controllers
{
    public class FilterController : BaseController
    {


        [Route("arama-sonuclari")]
        public ActionResult Filter()
        {

            string OtelveyaBolge = Request.QueryString["OtelveyaBolge"];
            string GirisTarihi = Request.QueryString["GirisTarihi"];
            string CikisTarihi = Request.QueryString["CikisTarihi"];
            string YetiskinSayisi = Request.QueryString["YetiskinSayisi"];
            string CocukSayisi = Request.QueryString["CocukSayisi"];
            string CocukYas1 = Request.QueryString["CocukYas1"];
            string CocukYas2 = Request.QueryString["CocukYas2"];

            Session.Add("otelsecimisession", OtelveyaBolge);
            Session.Add("giristarihiession", GirisTarihi);
            Session.Add("cikistarihiession", CikisTarihi);
            Session.Add("yetiskinsayisisession", YetiskinSayisi);
            Session.Add("cocuksayisisession", CocukSayisi);
            Session.Add("cocukyas1session", CocukYas1);
            Session.Add("cocukyas2session", CocukYas2);

            #region Otel Filtre
            FiltreOtel filtreOtel = new FiltreOtel();


            string otelbolgesi = Request.QueryString["OtelBolgesi"] == null ? "" : Request.QueryString["OtelBolgesi"];
            string otelil = Request.QueryString["Otelil"] == null ? "" : Request.QueryString["Otelil"];
            string otelilce = Request.QueryString["otelilce"] == null ? "" : Request.QueryString["otelilce"];
            filtreOtel.Bolge = otelbolgesi;
            filtreOtel.Il = otelil;
            filtreOtel.Ilce = otelilce;

            var liste = _unitOfWork.Oteller.Where(x => x.OtelLink.Contains(otelbolgesi) && x.OtelAktifMi == true).OrderByDescending(x => x.OtelOncelik);

            if (otelbolgesi != "")
            {
                if (otelil == "" && otelilce == "")
                {

                    liste = _unitOfWork.Oteller.Where(x => x.OtelBolgesi == otelbolgesi && x.OtelAktifMi == true).OrderByDescending(x => x.OtelOncelik);
                }
                else if (otelil != "" && otelilce == "")
                {
                    liste = _unitOfWork.Oteller.Where(x => x.Otelil.Contains(otelil) && x.OtelAktifMi == true && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik);
                }
                else if (otelil != "" && otelilce != "")
                {
                    liste = _unitOfWork.Oteller.Where(x => x.Otelilce.Contains(otelilce) && x.OtelAktifMi == true && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik);
                }
                else
                {
                    liste = _unitOfWork.Oteller.Where(x => x.Otelil.Contains(otelil) && x.OtelAktifMi == true && x.Otelilce.Contains(otelilce) && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik);
                }
            }

            filtreOtel.Otels = liste.ToList();
            #endregion

            List<FiltreKonaklamaTipleri> konaklamalist = new List<FiltreKonaklamaTipleri>();

            foreach (var item in liste)
            {
                string[] konaklamatipi = item.KonaklamaTipi.Split(',');

                foreach (var kitem in konaklamatipi)
                {
                    bool sonuc = konaklamalist.Any(x => x.KonaklamaAdi == kitem);


                    FiltreKonaklamaTipleri f = new FiltreKonaklamaTipleri();
                    string konaklamacount = liste.Where(x => x.KonaklamaTipi.Contains(kitem) && x.KonaklamaTipi.EndsWith(kitem)).ToList().Count.ToString();
                    f.KonaklamaAdi = kitem.ToString() + " (" + konaklamacount + ")";
                    for (int i = 0; i < konaklamatipi.Length; i++)
                    {
                        f.KonaklamaAdi = kitem.ToString();
                        f.KonaklamaAdiValue = kitem.ToString();
                    }

                    if (f.KonaklamaAdi.Trim() != "" && !konaklamalist.Any(x => x.KonaklamaAdi == f.KonaklamaAdi))
                    {
                        konaklamalist.Add(f);
                    }
                }

            }




            var otelolanaklarList = (from otel in liste
                                     join otelolanak in _unitOfWork.OtelOzellikleri.ToList() on otel._id equals otelolanak.OtelSubID
                                     where otel._id == otelolanak.OtelSubID
                                     select new FiltreOtelOzellikleri { OlanakAdi = otelolanak.OlanakAdi, KacOteldeVar = _unitOfWork.OtelOzellikleri.Count(x => x.OlanakAdi == otelolanak.OlanakAdi), OlanakveSayisi = otelolanak.OlanakAdi + "(" + _unitOfWork.OtelOzellikleri.Count(x => x.OlanakAdi == otelolanak.OlanakAdi) + ")" }).OrderByDescending(x => x.KacOteldeVar).ToList();
          



            FiltreCheckbox filtreChechbox = new FiltreCheckbox
            {
                KonaklamaTipleri = konaklamalist,
                OtelOzellikleri = otelolanaklarList
            };
            filtreOtel.Checkboxs = filtreChechbox;

            return View(filtreOtel);
        }


        List<OtelFiltrelenmisListe> filtrelist = new List<OtelFiltrelenmisListe>();
        List<OtelFiltrelenmisListe> FiltreliVeri = new List<OtelFiltrelenmisListe>();

        [Route("otel-ara-filtre")]
        public ActionResult FiltreYap(string[] secilenKonaklamalar, string[] secilenOlanaklar, string otelbolgesi,string otelil,string otelilce)
        {
            try
            {
                int konaklamaL = secilenKonaklamalar == null ? 0 : secilenKonaklamalar.Length;
                int olanaklarL = secilenOlanaklar == null ? 0 : secilenOlanaklar.Length;

            
             
                List<Oteller> liste = _unitOfWork.Oteller.Where(x => x.OtelLink.Contains(otelbolgesi) && x.OtelAktifMi == true).OrderByDescending(x => x.OtelOncelik).ToList();
                
                if (otelbolgesi != "")
                {
                    if (otelil == "" && otelilce == "")
                    {

                        liste = _unitOfWork.Oteller.Where(x => x.OtelBolgesi == otelbolgesi && x.OtelAktifMi == true).OrderByDescending(x => x.OtelOncelik).ToList();
                    }
                    else if (otelil != "" && otelilce == "")
                    {
                        liste = _unitOfWork.Oteller.Where(x => x.Otelil.Contains(otelil) && x.OtelAktifMi == true && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik).ToList();
                    }
                    else if (otelil != "" && otelilce != "")
                    {
                        liste = _unitOfWork.Oteller.Where(x => x.Otelilce.Contains(otelilce) && x.OtelAktifMi == true && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik).ToList();
                    }
                    else
                    {
                        liste = _unitOfWork.Oteller.Where(x => x.Otelil.Contains(otelil) && x.OtelAktifMi == true && x.Otelilce.Contains(otelilce) && x.OtelBolgesi == otelbolgesi).OrderByDescending(x => x.OtelOncelik).ToList();
                    }
                }


                List<OtelFiltrelenmisListe> filtrelist = new List<OtelFiltrelenmisListe>();
                if (konaklamaL > 0 && olanaklarL == 0)
                {
                    OtelleriSplitYap(liste, filtrelist);
                    string sorgu;
                    string[] sorgufiltre;
                    KonaklamaFiltrele(secilenKonaklamalar, out sorgu, out sorgufiltre);
                    filtrelist = filtrelist.Where(sorgu, sorgufiltre).GroupBy(p => p.OtelID).Select(g => g.First()).ToList();
                }
                else if (konaklamaL == 0 && olanaklarL > 0)
                {
                    OtelleriSplitYap(liste, filtrelist);
                    string sorguolanak;
                    string[] olanakfiltre;
                    OlanakFiltrele(secilenOlanaklar, out sorguolanak, out olanakfiltre);
                    filtrelist = filtrelist.Where(sorguolanak, olanakfiltre).GroupBy(p => p.OtelID).Select(g => g.First()).ToList();
                }
                else if (konaklamaL > 0 && olanaklarL > 0)
                {
                    OtelleriSplitYap(liste, filtrelist);
                    string sorgu;
                    string[] sorgufiltre;
                    string sorguolanak;
                    string[] olanakfiltre;
                    KonaklamaFiltrele(secilenKonaklamalar, out sorgu, out sorgufiltre);
                    filtrelist = filtrelist.Where(sorgu, sorgufiltre).GroupBy(p => p.OtelID).Select(g => g.First()).ToList();
                    OlanakFiltrele(secilenOlanaklar, out sorguolanak, out olanakfiltre);
                    filtrelist = filtrelist.Where(sorguolanak, olanakfiltre).GroupBy(p => p.OtelID).Select(g => g.First()).ToList();
                }
                List<FiltreKonaklamaTipleri> konaklamalist = new List<FiltreKonaklamaTipleri>();
                KonaklamaTipleriniAyarla(liste, konaklamalist);

                if (konaklamaL > 0 || olanaklarL > 0)
                {
                    var otelolanaklarList = (from otel in filtrelist
                                             join otelolanak in _unitOfWork.OtelOzellikleri.ToList() on otel.OtelID equals otelolanak.OtelSubID
                                             where otel.OtelID == otelolanak.OtelSubID
                                             select new { OlanakAdi = otelolanak.OlanakAdi }).Distinct().Take(10).ToList();

                    var deger = new { otellistesi = filtrelist, konaklamalistesi = konaklamalist, olanaklistesi = otelolanaklarList };
                    return Content(JsonConvert.SerializeObject(deger));
                }
                else
                {
                    var otelolanaklarList = (from otel in liste
                                             join otelolanak in _unitOfWork.OtelOzellikleri.ToList() on otel._id equals otelolanak.OtelSubID
                                             where otel._id == otelolanak.OtelSubID
                                             select new { OlanakAdi = otelolanak.OlanakAdi }).Distinct().Take(10).ToList();

                    var deger = new { otellistesi = liste, konaklamalistesi = konaklamalist, olanaklistesi = otelolanaklarList };
                    return Content(JsonConvert.SerializeObject(deger));

                }

            }
            catch (Exception ex)
            {
                return Json(FiltreliVeri);
            }
        }

        public class OtelFiltrelenmisListe
        {
            public string OtelID { get; set; }
            public string OtelAdi { get; set; }
            public string OtelAnasayfaResmi { get; set; }
            public string KonaklamaTipi { get; set; }
            public string KonaklamaSplit { get; set; }
            public string otelil { get; set; }
            public string otelilce { get; set; }
            public string OtelBolgesi { get; set; }
            public int OtelPuan { get; set; }
            public string OtelDivBilgi { get; set; }
            public string OlanakAdi { get; set; }
            public int OtelGosterimSayisi { get; set; }
            public bool OtelOncelik { get; set; }
        }
        private void OtelleriSplitYap(List<Oteller> liste, List<OtelFiltrelenmisListe> filtrelist)
        {
            foreach (var item in liste)
            {
                string[] ktipi = item.KonaklamaTipi.Split(',');

                foreach (var k in ktipi)
                {
                    OtelFiltrelenmisListe o = new OtelFiltrelenmisListe();
                    o.KonaklamaSplit = k;
                    o.OtelID = item._id;
                    o.OtelAdi = item.OtelAdi;
                    o.OtelAnasayfaResmi = item.OtelAnasayfaResmi;
                    o.KonaklamaTipi = item.KonaklamaTipi.Replace(",", "");
                    o.otelil = item.Otelil;
                    o.otelilce = item.Otelilce;
                    o.OtelBolgesi = item.OtelBolgesi;
                    o.OtelPuan = item.OtelPuan;
                    o.OtelDivBilgi = item.OtelDivBilgi;
                    o.OtelGosterimSayisi = item.OtelGoruntulenmeSayisi;
                    var olanaklar = _unitOfWork.OtelOzellikleri.Where(x => x.OtelSubID == item._id).ToList();
                    foreach (var itemolanak in olanaklar)
                    {
                        o.OlanakAdi += itemolanak.OlanakAdi + ",";
                    }
                    filtrelist.Add(o);
                }

            }
        }
        private static void KonaklamaFiltrele(string[] secilenKonaklamalar, out string sorgu, out string[] sorgufiltre)
        {
            sorgu = string.Empty;
            sorgufiltre = new String[secilenKonaklamalar.Length];
            for (int i = 0; i < secilenKonaklamalar.Length; i++)
            {
                sorgufiltre[i] = secilenKonaklamalar[i].ToString();
                if (i == 0)
                {
                    sorgu = "KonaklamaSplit = @" + i.ToString();
                }
                else
                {
                    sorgu += " OR KonaklamaSplit = @" + i.ToString();
                }

            }
        }
        private static void OlanakFiltrele(string[] secilenolanaklar, out string sorguolanak, out string[] olanakfiltre)
        {
            sorguolanak = string.Empty;
            olanakfiltre = new String[secilenolanaklar.Length];
            for (int i = 0; i < secilenolanaklar.Length; i++)
            {
                olanakfiltre[i] = secilenolanaklar[i].ToString();
                if (i == 0)
                {
                    sorguolanak = "OlanakAdi.Contains(@" + i.ToString() + ")";
                }
                else
                {
                    sorguolanak += " AND OlanakAdi.Contains(@" + i.ToString() + ")";
                }

            }
        }
        private static void KonaklamaTipleriniAyarla(List<Oteller> liste, List<FiltreKonaklamaTipleri> konaklamalist)
        {
            foreach (var item in liste)
            {
                string[] konaklamatipi = item.KonaklamaTipi.Split(',');

                foreach (var kitem in konaklamatipi)
                {
                    bool sonuc = konaklamalist.Any(x => x.KonaklamaAdi == kitem);


                    if (sonuc == false)
                    {

                        FiltreKonaklamaTipleri f = new FiltreKonaklamaTipleri();
                        string konaklamacount = liste.Where(x => x.KonaklamaTipi.Contains(kitem) && x.KonaklamaTipi.EndsWith(kitem)).ToList().Count.ToString();
                        f.KonaklamaAdi = kitem.ToString() + " (" + konaklamacount + ")";
                        for (int i = 0; i < konaklamatipi.Length; i++)
                        {
                            f.KonaklamaAdi = kitem.ToString();
                            f.KonaklamaAdiValue = kitem.ToString();
                        }

                        if (f.KonaklamaAdi.Trim() != "" && !konaklamalist.Any(x => x.KonaklamaAdi == f.KonaklamaAdi))
                        {
                            konaklamalist.Add(f);
                        }
                    }
                }

            }
        }


    }
}