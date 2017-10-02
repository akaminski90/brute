var input = document.querySelector('input[type=file]');
var file = input.files;

if (file.length === 0) {
    document.querySelector('.file-control').textContent = 'Выберите файл';
}

input.addEventListener('change', updateText);

function updateText() {
    var file = input.files;

    if (file.length !== 0) {
        document.querySelector('.file-control').textContent = '' + file[0].name.substring(0, 14) + (file[0].name.length > 14 ? '...' : '') + ' ' + returnFileSize(file[0].size);
    } else {
        document.querySelector('.file-control').textContent = 'Выберите файл';
    }

    function returnFileSize(number) {
        if (number < 1024) {
            return number + 'bytes';
        } else if (number > 1024 && number < 1048576) {
            return (number / 1024).toFixed(1) + 'KB';
        } else if (number > 1048576) {
            return (number / 1048576).toFixed(1) + 'MB';
        }
    }
}