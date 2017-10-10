$(document).ready(function () {
    var search = $('.search-bar');
    search.select2({
        placeholder: 'Введите название песни или имя исполнителя',
        minimumInputLength: 1,
        maximumInputLength: 20,
        templateResult: formatRepo,
        templateSelection: formatSelectionRepo,
        escapeMarkup: function (markup) { return markup; },
        ajax: {
            url: '/umbraco/surface/searchSurface/search',
            dataType: 'json',
            delay: 1000,
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

        if (!repo.id) {
            return repo.id;
        }

        var markup = "<p>" + repo.text + "</p>";

        return markup;
    }
});

