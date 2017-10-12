$(document).ready(function () {
    var search = $('.search-bar');
    search.select2({
        placeholder: 'Введите название песни или имя исполнителя',
        minimumInputLength: 1,
        maximumInputLength: 50,
        templateResult: formatRepo,
        templateSelection: formatSelectionRepo,
        escapeMarkup: function (markup) { return markup; },
        language: {
            inputTooShort: function (args) {
                var remainingChars = args.minimum - args.input.length;
                var message = 'Пожалуйста, введите ' + remainingChars + ' или более символов';
                return message;
            },
            inputTooLong: function (args) {
                var overChars = args.input.length - args.maximum;
                var message = 'Пожалуйста, удалите ' + overChars;
                if (overChars === 1) {
                    message += ' символ';
                } else if (overChars > 1 && overChars < 5){
                    message += ' симовла';
                } else {
                    message += ' символов';
                }

                return message;
            },
            errorLoading: function () {
                return "Ошибка загрузки результатов";
            },
            loadingMore: function () {
                return "Загружаем больше результатов";
            },
            noResults: function () {
                return "Ничего не найдено";
            },
            searching: function () {
                return "Поиск...";
            },
            maximumSelected: function (args) {
                var message = 'Вы можете выбрать только ' + args.maximum;

                if (args.maximum === 1) {
                    message += ' элемент';
                } if (args.maximum > 1 && args.maximum < 5) {
                    message += ' элемента';
                } else {
                    message += ' элементов';
                }

                return message;
            }
        },
        ajax: {
            url: '/umbraco/surface/searchSurface/search',
            dataType: 'json',
            delay: 250,
            data: function (params) {
                return {
                    q: params.term // search term
                };
            },
            processResults: function (data, params) {
                params.page = params.page || 1;
                return {
                    results: data
                };
            }
        }
    });

    search.on('select2:select', function (e) {
        window.location = e.params.data.link;
    });    

    //$('b[role="presentation"]').hide();
    $('.select2-selection__arrow').append('<i class="br-search" style="position: absolute; transform: translate(-50%, -50%); top: 50%; left: 50%;"></i>');

    function formatRepo(repo) {

        if (repo.loading) {
            return "Поиск...";
        }

        if (!repo.id) {
            return repo.id;
        }

        var markup = "<a style='width: 100%; height: 100%;' class='detail-link' href='" + repo.link + "'>" + repo.text + "</a>";

        return markup;
    }

    function formatSelectionRepo(repo) {

        if (repo.loading) {
            return "Поиск...";
        }

        var markup = "<p>" + repo.text + "</p>";

        return markup;
    }
});

