

var yurticioteller = [];
var kibrisotelleri = [];


var yurtdisiotellinkleri = [];
var yurticiotellinkleri = [];
var $mam = jQuery.noConflict();

$mam.ajax({
    url: '/aramasonuclari',
    type: 'GET',
    dataType: 'json',
    success: function (response) {
        for (var i = 0; i < response.length; i++) {
            var item = response[i];
            if (item.Location === "Yurt İçi Otelleri" || item.Location === "Türkiye") {
                yurticioteller.push(item.Name + "   |   " + item.Adress);
                yurticiotellinkleri.push('http://www.becomingtur.com/' + item.Link);
            }
            else {
               
                kibrisotelleri.push(item.Name + "-" + item.Adress);
                yurtdisiotellinkleri.push('http://www.becomingtur.com/' + item.Link);
            }
        }
        
       


        var sltryurtici = $mam.map(yurticioteller, function (team) { return { value: team, data: { category: 'Yurt içi Otelleri' } }; });
        var salturydisi = $mam.map(kibrisotelleri, function (team) { return { value: team, data: { category: 'Kıbrıs Otelleri' } }; });
        var teams = sltryurtici.concat(salturydisi);

        // Initialize autocomplete with local lookup:
        $mam('#autocomplete').devbridgeAutocomplete({
            lookup: teams,
            minChars: 2,
            onSelect: function (suggestion) {

                if (suggestion.data.category.indexOf("Yurt içi Otelleri") >= 0) {


                    if ($mam.inArray(suggestion.value, yurticioteller) !== -1) {
                        var index = yurticioteller.indexOf(suggestion.value);
                        for (var i = 0; i < yurticiotellinkleri.length; i++) {
                            if (i == index) {

                                var deger = yurticiotellinkleri[i];
                                var h = document.getElementById('hgidilenyer');
                                h.value = deger;

                            }
                        }


                    }
                }
                else if (suggestion.data.category.indexOf("Yurtdışı Otelleri") >= 0) {


                    if ($mam.inArray(suggestion.value, kibrisotelleri) !== -1) {
                        var index = kibrisotelleri.indexOf(suggestion.value);
                        for (var i = 0; i < yurtdisiotellinkleri.length; i++) {
                            if (i == index) {
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










