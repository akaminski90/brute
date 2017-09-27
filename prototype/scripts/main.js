// $('.bars').click(function () {
//     $('.mobile-menu').addClass('active');
//     $('.wrapper').addClass('mobile-menu-active');
// });
//
// $('.close').click(function () {
//     $('.mobile-menu').removeClass('active');
//     $('.wrapper').removeClass('mobile-menu-active');
// });


/*********************SIDEBAR****************************************************/
var sidebar = document.querySelector('.sidebar');
var article = document.querySelector('body article');
var siteName = document.querySelector('.navbar ul');
var sidebarStyle = sidebar.currentStyle || window.getComputedStyle(sidebar);
document.querySelector('.bars').addEventListener('click', function () {
    if (sidebarStyle.left === '0px' || sidebarStyle.left === '') {
        sidebar.style.left = '-300px';
        article.style.marginLeft = '0px';
        siteName.style.marginLeft = '50px';
    } else {
        sidebar.style.left = '0px';
        article.style.marginLeft = '300px';
        siteName.style.marginLeft = '250px';
    }
});

/**********************ARROWS******************************************************/

/*$('.br-down').click(function () {
    var $li = $(this).parent().parent();
    $li.toggleClass('active');
    $(this).toggleClass('br-down').toggleClass('br-up');
});*/

document.body.addEventListener('click', function (event) {
    if (event.target.classList.contains('br-down') || event.target.classList.contains('br-up')) {
        event.target.classList.toggle('br-down');
        event.target.classList.toggle('br-up');
        event.target.parentNode.parentNode.classList.toggle('active');
    }
});