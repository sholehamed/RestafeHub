swal.setDefaults({ 
    confirmButtonText: "باشه",
    cancelButtonText: "لغو" 
});
document.querySelector(".sweet-wrong").onclick = function () {
     sweetAlert("اوووپس...", "مشکلی پیش اومد !!", "error") }, 
     document.querySelector(".sweet-message").onclick = function () { swal("سلام ، این یه پیامه  !!") },
     document.querySelector(".sweet-text").onclick = function () { swal("سلام ، این یه پیامه  !!", "جالبه ، نه ؟") },
    document.querySelector(".sweet-success").onclick = function () { swal("آفرین ، کارت خوب بود !!", "دکمه رو کلیک کردی !!", "success") },
    document.querySelector(".sweet-confirm").onclick = function () { swal({ title: "مطمئنی میخوای حذف کنی ؟", text: "دیگه نمیتونی این پرونده رو بازیابی کنی  !!", type: "warning", showCancelButton: !0, confirmButtonColor: "#DD6B55", confirmButtonText: "بله حذفش کن !!", closeOnConfirm: !1 },
     function () { swal("حذف شده !!", "سلام ، پرونده مورد نظر شما حذف شده  !!", "success") }) }, 
    document.querySelector(".sweet-success-cancel").onclick = function () { swal({ title: "مطمئنی میخوای حذفش کنی ؟", text: "دیگه نمیتونی این پرونده رو بازیابی کنی  !!", type: "warning", showCancelButton: !0, confirmButtonColor: "#DD6B55", confirmButtonText: "بله حذفش کن !!", cancelButtonText: "نه ، لغوش کن !!", closeOnConfirm: !1, closeOnCancel: !1 },
   function (e) { e ? swal("حذف شد !!", "سلام ، پرونده مورد نظر شما حذف شد  !!", "success") : swal("لغو شد !!", " پرونده مورد نظر شما حذف نشد   !!", "error") }) }, document.querySelector(".sweet-image-message").onclick = function () { swal({ title: "یه چیز جالب !!", text: " این یه تصویر سفارشی هست !!", imageUrl: "../xhtml/images/profile/small/pic1.jpg" }) },
     document.querySelector(".sweet-html").onclick = function () { swal({ title: "یه چیز جالب !!", text: "<span style='color:#ff0000'>  داری از HTML استفاده میکنی  !!<span>", html: !0 }) },
      document.querySelector(".sweet-auto").onclick = function () { swal({ title: "هشدار بستن خودکارsweet !!", text: "  این پیغام 2 ثانیه دیگه بسته میشه !!", timer: 2e3, showConfirmButton: !1 }) },
    document.querySelector(".sweet-prompt").onclick = function () { swal({ title: "یه چیزی وارد کن !!", text: "یه چیز جالب بنویس !!", type: "input", showCancelButton: !0, closeOnConfirm: !1, animation: "slide-from-top", inputPlaceholder: "یه چیزی بنویس" },
     function (e) { return !1 !== e && ("" === e ? (swal.showInputError(" باید یه چیزی  اینجا بنویسی!"), !1) : void swal("آفرین !!", "تو نوشتی : " + e, "success")) }) },
     document.querySelector(".sweet-ajax").onclick = function () { swal({ title: "درخواست Sweet ajax !!", text: "برای اجرای درخواست ajax ارسال کن !!", type: "info", showCancelButton: !0, closeOnConfirm: !1, showLoaderOnConfirm: !0 },
    function () { setTimeout(function () { swal(" درخواست ajax شما تموم شد !!") }, 2e3) }) };