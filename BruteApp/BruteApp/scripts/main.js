$(document).ready(function () {
    /*SWIPE*/
    $(document).swipe({
        swipeLeft: function (e) {
            hideSidebar();
        },
        swipeRight: function (e) {
            showSidebar();
        },
        excludedElements: $.fn.swipe.defaults.excludedElements + ", form *"
    });

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

var hideSidebar = function () {
    $('.sidebar').css('left', '-300px');
    $('body article').css('margin-left', '0px');
    $('.content').css('left', '0px');
};

var showSidebar = function() {
    $('.sidebar').css('left', '0px');
    if ($(window).innerWidth() >= 900) {
        $('body article').css('margin-left', '300px');
        $('.content').css('left', '0px');
    } else {
        $('.content').css('left', '300px');
        $('body article').css('margin-left', '0px');
    }
}

/*SCROLL*/
$(function(){
    $('.menu-content .items').slimScroll({
        height: '100%',
        size: '4px'
    });
});