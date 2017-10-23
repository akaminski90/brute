$(document).ready(function () {
    /*SWIPE*/
    if (isMobile() == true) {
        $(document).swipe({
            swipeLeft: function(e) {
                hideSidebar();
            },
            swipeRight: function(e) {
                showSidebar();
            },
            excludedElements: $.fn.swipe.defaults.excludedElements + ", form *",
            treshold: 75
        });
    };

    /*ARROWS*/
    $('.sidebar .items > li > a').click(function (e) {
        e.preventDefault();
        var $li = $(this).parent();
        $li.toggleClass('active');
        $(this).find('i').toggleClass('br-down').toggleClass('br-up');
    });

    /*SIDEBAR*/
    $('.bars').click(function () {
        if ($('.sidebar').css('left') === '0px') {
            hideSidebar();
        } else {
            showSidebar();
        }
    });
});

function hideSidebar() {
    $('.sidebar').css('left', '-300px');
    $('body article').css('margin-left', '0px');
    $('.content').css('left', '0px');
};

function showSidebar() {
    $('.sidebar').css('left', '0px');
    if ($(window).innerWidth() >= 900) {
        $('body article').css('margin-left', '300px');
        $('.content').css('left', '0px');
    } else {
        $('.content').css('left', '300px');
        $('body article').css('margin-left', '0px');
    }
}

function isMobile() {
    try {
        document.createEvent("TouchEvent");
        return true;
    } catch (e) {
        return false;
    }
}

/*SCROLL*/
$(function () {
    $('.menu-content .items').slimScroll({
        height: '100%',
        size: '4px'
    });
});


/*Print*/

function printTranslation() {
    $('.text, .song > h1, .for-print').printThis({
        importCSS: true,
        loadCSS: "/css/print.css"
    });
}

/* Tooltips */

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
});

/* Open filter */

$('.open-filter').click(function () {
    $('.filter').toggleClass('active');
    $(this).find('i').toggleClass('br-down').toggleClass('br-up');
});
