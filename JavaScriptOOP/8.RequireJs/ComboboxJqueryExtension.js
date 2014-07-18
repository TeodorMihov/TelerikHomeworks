define(['jquery'], function($){
    $.fn.combobox = function() {
        var $container = $('#container'),
            $randomElement = $container.find('#person-item-1');
            $initializeDiv = $('<div>').addClass('current').html($randomElement.html());

        $container.prepend($initializeDiv);
        $container.find('.person-item').hide();

        $container.on('click', '.current', function(){
            $container.find('.person-item').show();
        });

        $container.on('click', '.person-item', function(){
            $initializeDiv.html($(this).html());
            $container.find('.person-item').hide();
        });

    }
});

