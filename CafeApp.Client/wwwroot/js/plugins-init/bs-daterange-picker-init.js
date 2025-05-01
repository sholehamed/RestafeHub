(function($) {
    "use strict"
    
    // Daterange picker
    $('.input-daterange-datepicker').daterangepicker({
        "locale": {
            "format": "MM/DD/YYYY",
            "separator": " - ",
            "applyLabel": "اعمال",
            "cancelLabel": "لغو",
            "fromLabel": "از",
            "toLabel": "تا",
            "daysOfWeek": [
                "ش",
                "ج",
                "پ",
                "چ",
                "س",
                "د",
                "ی"
            ],
            "monthNames": [
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            ],
            "firstDay": 1
        },
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse',
        opens: 'left',
        
    });
    $('.input-daterange-timepicker').daterangepicker({
        "locale": {
            "format": "MM/DD/YYYY",
            "separator": " - ",
            "applyLabel": "اعمال",
            "cancelLabel": "لغو",
            "fromLabel": "از",
            "toLabel": "تا",
            "daysOfWeek": [
                "ش",
                "ج",
                "پ",
                "چ",
                "س",
                "د",
                "ی"
            ],
            "monthNames": [
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            ],
            "firstDay": 1},
        opens: 'left',
        timePicker: true,
        format: 'MM/DD/YYYY h:mm A',
        timePickerIncrement: 30,
        timePicker12Hour: true,
        timePickerSeconds: false,
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse'
    });
    $('.input-limit-datepicker').daterangepicker({
        "locale": {
            "format": "MM/DD/YYYY",
            "separator": " - ",
            "applyLabel": "اعمال",
            "cancelLabel": "لغو",
            "fromLabel": "از",
            "toLabel": "تا",
            "daysOfWeek": [
                "ش",
                "ج",
                "پ",
                "چ",
                "س",
                "د",
                "ی"
            ],
            "monthNames": [
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            ],
            "firstDay": 1},
        opens: 'left',
        format: 'MM/DD/YYYY',
        minDate: '06/01/1400',
        maxDate: '06/30/1400',
        buttonClasses: ['btn', 'btn-sm'],
        applyClass: 'btn-danger',
        cancelClass: 'btn-inverse',
        dateLimit: {
            days: 6
        }
    });
})(jQuery);