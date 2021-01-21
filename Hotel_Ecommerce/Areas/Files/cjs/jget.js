$(function get() {
    $("#<%=txtbaslangictarihi.ClientID %>").datepicker({
        changeMonth: true,
        changeYear: true,
        numberOfMonths: 3,
        showButtonPanel: true
    });
});