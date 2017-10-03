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
var content = document.querySelector('.content');
var sidebarStyle = sidebar.currentStyle || window.getComputedStyle(sidebar);
document.querySelector('.bars').addEventListener('click', function () {
    if (sidebarStyle.left === '0px') {
        sidebar.style.left = '-300px';
        //if (window.innerWidth >= 900) {
        article.style.marginLeft = '0px';
        content.style.left = '0px';
        /*} else {
            content.style.left = '0px';
            article.style.marginLeft = '0px';
        }*/
    } else {
        sidebar.style.left = '0px';
        if (window.innerWidth >= 900) {
            article.style.marginLeft = '300px';
            content.style.left = '0px';
        } else {
            content.style.left = '300px';
            article.style.marginLeft = '0px';
        }
    }
});

/**********************ARROWS******************************************************/

/*$('.br-down').click(function () {
    var $li = $(this).parent().parent();
    $li.toggleClass('active');
    $(this).toggleClass('br-down').toggleClass('br-up');
});*/

/*document.body.addEventListener('click', function (event) {
    arrows = document.querySelectorAll('.sidebar > ul > li > a');
    if (event.target.classList.contains('br-down') || event.target.classList.contains('br-up')) {
        event.target.classList.toggle('br-down');
        event.target.classList.toggle('br-up');
        event.target.parentNode.parentNode.classList.toggle('active');
    }
});*/

/*var arrows = document.querySelectorAll('.sidebar > ul > li > a');
arrows.forEach(cur => cur.addEventListener('click', function () {
    this.parentNode.classList.toggle('active');
    for (var i = 0; i < this.childNodes.length; i++) {
        //console.log(this.childNodes[i]);
        if (this.childNodes[i].className === 'br-down') {
            this.childNodes[i].classList.toggle('br-up');
            this.childNodes[i].classList.toggle('br-down');
        } else if (this.childNodes[i].className === 'br-up') {
            this.childNodes[i].classList.toggle('br-down');
            this.childNodes[i].classList.toggle('br-up');
        }
    }
}));*/

var arrows = document.querySelectorAll('.sidebar > ul > li > a');
for (var i = 0; i < arrows.length; i++) {
    arrows[i].addEventListener('click',
        function() {
            this.parentNode.classList.toggle('active');
            for (var i = 0; i < this.childNodes.length; i++) {
                //console.log(this.childNodes[i]);
                if (this.childNodes[i].className === 'br-down') {
                    this.childNodes[i].classList.toggle('br-up');
                    this.childNodes[i].classList.toggle('br-down');
                } else if (this.childNodes[i].className === 'br-up') {
                    this.childNodes[i].classList.toggle('br-down');
                    this.childNodes[i].classList.toggle('br-up');
                }
            }
        });
}

/*$('.sidebar > ul > li > a').click(function () {
    var $li = $(this).parent();
    $li.toggleClass('active');
    $(this).find('i').toggleClass('br-down').toggleClass('br-up');
});*/

