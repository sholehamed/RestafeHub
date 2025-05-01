jQuery(".form-valide").validate({
    rules: {
        "val-username": {
            required: !0,
            minlength: 3
        },
        "val-email": {
            required: !0,
            email: !0
        },
        "val-password": {
            required: !0,
            minlength: 5
        },
        "val-confirm-password": {
            required: !0,
            equalTo: "#val-password"
        },
        "val-select2": {
            required: !0
        },
        "val-select2-multiple": {
            required: !0,
            minlength: 2
        },
        "val-suggestions": {
            required: !0,
            minlength: 5
        },
        "val-skill": {
            required: !0
        },
        "val-currency": {
            required: !0,
            currency: ["$", !0]
        },
        "val-website": {
            required: !0,
            url: !0
        },
        "val-phoneus": {
            required: !0,
            phoneUS: !0
        },
        "val-digits": {
            required: !0,
            digits: !0
        },
        "val-number": {
            required: !0,
            number: !0
        },
        "val-range": {
            required: !0,
            range: [1, 5]
        },
        "val-terms": {
            required: !0
        }
    },
    messages: {
        "val-username": {
            required: "لطفا اسمت رو وارد کن",
            minlength: "اسمت باید حداقل 3 تا حرف داشته باشه"
        },
        "val-email": "لطفا پست الکترونیکی خودتو وارد کن",
        "val-password": {
            required: "رمز عبور اجباریه !",
            minlength: "رمز عبور باید حداقل 5 حرف داشته باشه"
        },
        "val-confirm-password": {
            required: "رمز عبور اجباریه !",
            minlength: "رمز عبور باید حداقل 5 حرف داشته باشه",
            equalTo: "لطفا همان رمز عبور بالا رو وارد کن"
        },
        "val-select2": "یکی از گزینه ها رو باید انتخاب کنی !",
        "val-select2-multiple": "حداقل دوتا گزینه رو انتخاب کن !",
        "val-suggestions": "چی کار کنیم که بهتر بشیم ؟",
        "val-skill": "یک مهارت رو انتخاب کن !",
        "val-currency": "لطفا یک واحد پولی رو وارد کن",
        "val-website": "لطفا آدرس وب سایت خودت رو وارد کن",
        "val-phoneus": "شماره تلفنت رو وارد کن",
        "val-digits": "لطفا یه عدد وارد کن",
        "val-number": "لطفا یه عدد  اعشاری وارد کن",
        "val-range": "باید یک عدد بین 1 تا 5 وارد کنی !",
        "val-terms": "باید با شرایط خدمات موافقت کنی !"
    },

    ignore: [],
    errorClass: "invalid-feedback animated fadeInUp",
    errorElement: "div",
    errorPlacement: function(e, a) {
        jQuery(a).parents(".form-group > div").append(e)
    },
    highlight: function(e) {
        jQuery(e).closest(".form-group").removeClass("is-invalid").addClass("is-invalid")
    },
    success: function(e) {
        jQuery(e).closest(".form-group").removeClass("is-invalid"), jQuery(e).remove()
    },
});


jQuery(".form-valide-with-icon").validate({
    rules: {
        "val-username": {
            required: !0,
            minlength: 3
        },
        "val-password": {
            required: !0,
            minlength: 5
        }
    },
    messages: {
        "val-username": {
            required: "لطفا اسمت رو وارد کن",
            minlength: "اسمت باید حداقل 3 تا حرف داشته باشه"
        },
        "val-password": {
            required: "رمز عبور اجباریه !",
            minlength: "رمز عبور باید حداقل 5 حرف داشته باشه"
        }
    },

    ignore: [],
    errorClass: "invalid-feedback animated fadeInUp",
    errorElement: "div",
    errorPlacement: function(e, a) {
        jQuery(a).parents(".form-group > div").append(e)
    },
    highlight: function(e) {
        jQuery(e).closest(".form-group").removeClass("is-invalid").addClass("is-invalid")
    },
    success: function(e) {
        jQuery(e).closest(".form-group").removeClass("is-invalid").addClass("is-valid")
    }




});