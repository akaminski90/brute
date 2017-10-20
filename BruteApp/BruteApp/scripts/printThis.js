$(document).ready(function() { $('.print').on('click', openPrintDialogue); });


function openPrintDialogue() {
    var $iframe = $('<iframe>',
        {
            name: 'myiframe',
            class: 'printFrame'
        }).appendTo('body');
    $iframe
        .contents()
        .find('head')
        .append(
    "<style>"
            + "h1 {"
                + "text-align: center;"
                + "display: block;"
                + "font-size: 25px;"
            +"}"

            + ".for-print {"
            + "text-align: center;"
            + "display: block;"
            + "font-size: 22px;"
            + "font-weight: 600;"
            + "margin: 25px 0;"
        + "}"

        + ".text {"
            + "font-size: 16px;"
        + "}"

        + ".text .string {"
            + "border-bottom: 1px solid #eee;"
            + "padding: 5px 0;"
            + "display: -webkit-box;"
            + "display: -webkit-flex;"
            + "display: -ms-flexbox;"
            + "display: flex;"
            + "min-height: 30px;"
        + "}"

        + ".text .string.title {"
            + "text-align: center;"
            + "font-weight: 600;"
            + "font-size: 20px;"
        + "}"

        + ".text .string .original {"
            + "width: 50%;"
            + "padding: 0 10px;"
            + "border-right: 1px solid #eee;"
        + "}"

        + ".text .string .translate {"
            + "width: 50%;"
            + "padding: 0 10px;"
        + "}"

        + ".text .string .translate {"
            + "font-weight: 600;"
        + "}"
    + "</style>");
    $iframe
        .contents()
        .find('body')
        .append($('span.for-print:first').clone())
        .append($('.text').clone())
        .append($('span.for-print:last').clone());

    window.frames['myiframe'].focus();
    window.frames['myiframe'].print();

    setTimeout(function() { return $(".printFrame").remove(); }, 1000);
};