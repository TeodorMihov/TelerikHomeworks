var $input = $('<input type="color">').appendTo('body');

$input.on('change', function(){
    var color = $input.val();
    $('body').css('background',color);
})