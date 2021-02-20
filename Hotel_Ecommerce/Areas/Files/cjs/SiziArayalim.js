//jQuery(document).ready(function () {
//    document.getElementById("btnsarayalimgonder").disabled = true;
//});
function saraylimclick() {
    jQuery('#txtsaat')[0].options.length = 0;
    var dt = new Date();
    var acilis = 9;
    var kapanis = 19;
    var suansaat = dt.getHours();

    var secilengun = jQuery("#txttarih").val();

    var d = new Date();
    var gunno = d.getDay();
    if (suansaat >= 9 && suansaat <= 19 && secilengun == "Bugün" && gunno != 0 && gunno != 6) {

        for (var i = suansaat; i <= 18; i++) {
            if (i == 9) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                }));
            }
            else if (i == 17) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: (i) + ':00-' + (i + 1) + ':00 Arası',
                }));
            }
            else if (i == 18) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i) + ':00 Arası',
                    text: (i) + ':00-' + (i) + ':30 Arası',
                }));
            }
            else {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: (i) + ':00-' + (i + 1) + ':00 Arası'
                }));
            }

        }
    }
    else if (suansaat >= 9 && suansaat < 16 && secilengun == "Bugün" && gunno == 6) {
        jQuery("#hhaftasonu").text("Cumartesi günü çalışma saatimiz 16:00'dır.");
        for (var i = suansaat; i < 16; i++) {
            if (i == 9) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                }));
            }

            else {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: (i) + ':00-' + (i + 1) + ':00 Arası'
                }));
            }

        }
    }
    else if (suansaat >= 16 && secilengun == "Bugün" && gunno == 6 || secilengun == "Yarın" && gunno == 6 || secilengun == "Pazartesi" && gunno == 6) {
        jQuery("#hhaftasonu").text("Mesai saatimizin bitmesi nedeni ile talebiniz Pazartesi günü işleme alınacaktır. .");
        var tarihdrop = jQuery("#txttarih");
        tarihdrop.empty();
        if (secilengun == "Yarın" && gunno == 6 || secilengun == "Pazartesi" && gunno == 6) {
            tarihdrop.append(jQuery('<option>', {
                value: 'Bugün',
                text: 'Bugün',
            }));
        }



        tarihdrop.append(jQuery('<option>', {
            value: 'Pazartesi',
            text: 'Pazartesi',
        }));
        tarihdrop.val("Pazartesi");

        for (var i = acilis; i < 18; i++) {
            if (i == 9) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                }));
            }
            else if (i == 17) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':30 Arası',
                    text: (i) + ':00-' + (i + 1) + ':30 Arası',
                }));
            }
            else {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: (i) + ':00-' + (i + 1) + ':00 Arası'
                }));
            }

        }
    }
    else {

        for (var i = acilis; i < 18; i++) {
            if (i == 9) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: '0' + (i) + ':00-' + (i + 1) + ':00 Arası',
                }));
            }
            else if (i == 17) {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':30 Arası',
                    text: (i) + ':00-' + (i + 1) + ':30 Arası',
                }));
            }
            else {
                jQuery('#txtsaat').append(jQuery('<option>', {
                    value: (i) + ':00-' + (i + 1) + ':00 Arası',
                    text: (i) + ':00-' + (i + 1) + ':00 Arası'
                }));
            }

        }

    }

    jQuery('#modalSiziArayalim').modal('show');
};

function enableBtn() {
    document.getElementById("btnsarayalimgonder").disabled = false;
}


function ajaxgonder() {
    var txtadisoyadi = jQuery('#txtsadsoyadi').val();
    var txttelefon = jQuery('#txtulkekodu').val() + jQuery('#txtteli').val();
    var txtemail = jQuery('#txtemail').val();
    var txtkonu = jQuery('#dropkonu').val();
    var txttarih = jQuery('#txttarih').val();
    var txtsaat = jQuery('#txtsaat').val();
    var kampanyami = "";
    if (jQuery('#cbbizitakipedin:checkbox:checked').length > 0) {
        kampanyami = 'true';
    } else {
        kampanyami = 'false';
    }

    if (txtadisoyadi != '' && txttelefon != '' && txtemail != '') {
        jQuery.ajax({
            type: "POST",
            url: "/ajax-service-sizi-arayalim",

            data: { adisoyadi: txtadisoyadi, telefon: txttelefon, email: txtemail, konu: txtkonu, tarih: txttarih, saat: txtsaat, kampanya: kampanyami },
            dataType: "json",
            beforeSend: function (deger) {
                var sarayalimkayit = document.getElementById("sarayalimkayit");
                var currentClass = sarayalimkayit.className;
                sarayalimkayit.className = "hidden";
                var sarayalimkayitbasarili = document.getElementById("sarayalimkayitbasarili");
                var currentClass = sarayalimkayitbasarili.className;
                sarayalimkayitbasarili.className = "hidden";
                jQuery('#talepyukleniyor').show();
            },
            
            success: function (deger) {
                debugger
                jQuery("#lbladsoyadsiziarayalim").empty();
                jQuery("#lbladsoyadsiziarayalim").append(deger.gelenadsoyad);

                jQuery("#lbltelefonsiziarayalim").empty();
                jQuery("#lbltelefonsiziarayalim").append(deger.gelentelefon);


                jQuery("#lbltarihsiziarayalim").empty();
                jQuery("#lbltarihsiziarayalim").append(deger.gelentarih);

                jQuery("#lblsaatsiziarayalim").empty();
                jQuery("#lblsaatsiziarayalim").append(deger.gelensaat);

                jQuery("#lblkonusiziarayalim").empty();
                jQuery("#lblkonusiziarayalim").append(deger.gelenkonu);


                jQuery('#talepyukleniyor').hide();

                var sarayalimkayit = document.getElementById("sarayalimkayit");
                var currentClass = sarayalimkayit.className;
                sarayalimkayit.className = "hidden";
                var sarayalimkayitbasarili = document.getElementById("sarayalimkayitbasarili");
                var currentClass = sarayalimkayitbasarili.className;
                sarayalimkayitbasarili.className = "visible";
            }
        });
    }
    else if (txtadisoyadi == '' || txtadisoyadi.length == 2) {
        alert('Lütfen ad soyad alanını kontrol ediniz.');
    }
    else if (txttelefon.length < 7) {
        alert('Lütfen Telefon alanını kontrol ediniz.');
    }
    else if (txtemail.length < 1) {
        alert('Lütfen E Mail alanını kontrol ediniz.');
    }
    else {
        alert('Lütfen boş alan bırakmayınız.');
    }



};