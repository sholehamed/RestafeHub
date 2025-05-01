(function($) {
    "use strict"
    
    // Colorpicker
    $(".as_colorpicker").asColorPicker();
    $(".complex-colorpicker").asColorPicker({
        mode: 'complex',
        opens:'right'
    });
    $(".gradient-colorpicker").asColorPicker({
        mode: 'gradient',
        opens:'right'
    });
})(jQuery);