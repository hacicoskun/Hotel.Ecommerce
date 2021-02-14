

var yurticioteller = [];
var yurtdisiotelleri = [];


var yurtdisiotellinkleri = [];
var yurticiotellinkleri = [];
var $mam = jQuery.noConflict();
var isOtel = false;
var otelLink = "";
$mam.ajax({
    url: '/aramasonuclari',
    type: 'GET',
    dataType: 'json',
    success: function (response) {
        for (var i = 0; i < response.length; i++) {
            var item = response[i];
            if (item.Location === "Türkiye Otelleri" || item.Location === "Türkiye") {
                if (item.OtelMi === "1") {
                    yurticioteller.push(item.Name + " | " + item.Adress);
                    yurticiotellinkleri.push(item.Link);
                }
                else {
                    yurticioteller.push(item.Adress);
                    yurticiotellinkleri.push(item.Link);
                }
            }
            else {

                if (item.OtelMi === "1") {
                    yurtdisiotelleri.push(item.Name + " | " + item.Adress);
                    yurtdisiotellinkleri.push(item.Link);
                }
                else {
                    yurtdisiotelleri.push(item.Adress);
                    yurtdisiotellinkleri.push(item.Link);
                }
            }
        }




        var sltryurtici = $mam.map(yurticioteller, function (team) { return { value: team, data: { category: 'Türkiye Otelleri' } }; });
        var salturydisi = $mam.map(yurtdisiotelleri, function (team) { return { value: team, data: { category: 'Yurtdışı Otelleri' } }; });
        var teams = sltryurtici.concat(salturydisi);

        // Initialize autocomplete with local lookup:
        $mam('#autocomplete').devbridgeAutocomplete({
            lookup: teams,
            minChars: 2,
            onSelect: function (suggestion) {
                isOtel = false;
                if (suggestion.value.split('|').length > 1) {


                    if ($mam.inArray(suggestion.value, yurticioteller) !== -1) {
                        var index = yurticioteller.indexOf(suggestion.value);
                        for (var i = 0; i < yurticiotellinkleri.length; i++) {
                            if (i === index) {


                                isOtel = true;
                                otelLink = yurticiotellinkleri[i];
                            }
                        }


                    }
                }
                else if (suggestion.data.category.indexOf("Yurtdışı Otelleri") >= 0) {


                    if ($mam.inArray(suggestion.value, yurtdisiotelleri) !== -1) {
                        var index = yurtdisiotelleri.indexOf(suggestion.value);
                        for (var i = 0; i < yurtdisiotellinkleri.length; i++) {
                            if (i === index) {
                                var deger = yurtdisiotellinkleri[i];
                                var h = document.getElementById('hgidilenyer');
                                h.value = deger;

                            }
                        }


                    }
                }

            },


            showNoSuggestionNotice: true,
            noSuggestionNotice: 'Üzgünüz,Sonuç Bulunamadı.',
            groupBy: 'category',
            minChars: 2
        });
    }
});


function OtelAra() {
    var OtelveyaBolge = tjq("#autocomplete").val();
    var GirisTarihi = tjq("#depart").val();
    var CikisTarihi = tjq("#return").val();
    var YetiskinSayisi = tjq("#dropYetiskinSayisi_MP_cBdLN29i2").val();
    var CocukSayisi = tjq("#dropCocukSayisi_MP_cBdLN29i2").val();
    var CocukYas1 = "0";
    var CocukYas2 = "0";
    if (CocukSayisi == "1") {
        CocukYas1 = tjq("#dropCocukYas1 option:selected").val();
    }
    else if (CocukSayisi == "2") {
        CocukYas1 = tjq("#dropCocukYas1 option:selected").val();
        CocukYas2 = tjq("#dropCocukYas2 option:selected").val();
    }
    if (OtelveyaBolge.trim() != "" && GirisTarihi.trim() != "" && CikisTarihi.trim() != "" && CikisTarihi.trim() != "" && YetiskinSayisi.trim() != "") {
        var type = OtelveyaBolge.split(',').length;

        if (!isOtel) {
            if (type == 2)/*Otel Bölge ve il arama*/ {
                window.location.href = "/arama-sonuclari?OtelBolgesi=" + OtelveyaBolge.split(',')[1] + " Otelleri&Otelil=" + OtelveyaBolge.split(',')[0].replace(" Otelleri", "").trim();
            }
            else if (type == 3)/*Otel Bölge ve il arama*/ {
                window.location.href = "/arama-sonuclari?OtelBolgesi=" + OtelveyaBolge.split(',')[2] + " Otelleri&Otelil=" + OtelveyaBolge.split(',')[0] + "&Otelilce=" + OtelveyaBolge.split(',')[1].replace(" Otelleri", "").trim();
            }
        }
        else {
            window.location.href = otelLink;
        }
    }
    else {
        alert("Lütfen otel,bölge ve giriş-çıkış tarihlerini kontrol ediniz.");
    }
}






