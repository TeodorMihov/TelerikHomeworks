var $appendButton = $('<button>').text('Append').appendTo('body'),
    $prependButton = $('<button>').text('Prepend').appendTo('body'),
    $mainDiv = $('<div>').text('main div').appendTo('body');

$prependButton.on('click',prependDiv);
$appendButton.on('click',appendDiv);

function prependDiv() {
    $('<div>Prepend div</div>').prependTo($mainDiv);
}

function appendDiv() {
    $('<div>Append div</div>').appendTo($mainDiv);
}