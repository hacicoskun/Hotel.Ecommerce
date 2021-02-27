function openOtelTeklifAl() {
    jQuery('#ModalTeklifAl').modal('show');
}
function AjaxFiyatTalepEt() {

    var txtoteladi = this.setOtelAdi;
    var txtreztarihi = jQuery('#txtteklifgiriscikistarihi').val();
    var txtyolcuadi = jQuery('#txtyolcuadi').val();
    var txtyolcutel = jQuery('#txtyolcutelefon').val();
    var txtyolcuemail = jQuery('#txtyolcuemail').val();
    var txtysayisi = jQuery('#txtteklifysayi').val();
    var txtcsayisi = jQuery('#txtteklifcsayi').val();
    var txtcocuk1yas = jQuery('#selectteklifcocuk1yas').val();
    var txtcocuk2yas = jQuery('#selectteklifcocuk2yas').val();
    if (txtreztarihi.length > 3 && txtyolcuadi.length > 3 && txtyolcutel.length > 3 && txtyolcuemail.length > 3) {

        jQuery.ajax({
            type: "POST",
            url: "/ThemeHandler/OtelTeklifGonder.ashx",

            data: { txtoteladi: txtoteladi, txtreztarihi: txtreztarihi, txtyolcuadi: txtyolcuadi, txtyolcutel: txtyolcutel, txtyolcuemail: txtyolcuemail, txtysayisi: txtysayisi, txtcsayisi: txtcsayisi, txtcocuk1yas: txtcocuk1yas, txtcocuk2yas: txtcocuk2yas },
            dataType: "json",
            beforeSend: function (deger) {
                jQuery('#talepformual').hide();
                jQuery('#talepformok').hide();
                jQuery('#btnoteltalep').hide();
                jQuery('#oteltalepyukleniyor').show();

            },
            success: function (deger) {
                if (deger.islem == "true") {
                    jQuery("#lblotelteklifadsoyad").empty();
                    jQuery("#lblotelteklifadsoyad").append(txtyolcuadi);
                    jQuery('#oteltalepyukleniyor').hide();
                    jQuery('#btnoteltalep').hide();
                    jQuery('#talepformok').show();

                }
                else {
                    jQuery('#talepformok').hide();
                    jQuery('#oteltalepyukleniyor').hide();
                    jQuery('#btnoteltalep').show();
                    jQuery('#talepformual').show();
                    alert("Hata oluştu, lütfen bilgileri kontrol edip tekrar deneyiniz");
                }
            },
            error: function (deger) {
                jQuery('#talepformok').hide();
                jQuery('#oteltalepyukleniyor').hide();
                jQuery('#btnoteltalep').show();
                jQuery('#talepformual').show();
                alert("Hata oluştu, lütfen bilgileri kontrol edip tekrar deneyiniz");

            }
        });
    }
    else {
        alert("Tüm alanların doldurulması zorunludur.");
    }
}