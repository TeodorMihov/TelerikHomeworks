(function () {
    require.config({
        paths: {
            'handleBars': 'libs/handlebars.min',
            'jquery': 'libs/jquery.min',
            'Controls': 'Controls',
            'people': 'content',
            'ComboboxJqueryExtension': 'ComboboxJqueryExtension'
        }
    });

    require(['Controls', 'people', 'jquery', 'ComboboxJqueryExtension'], function(controls, people, $){

        var comboBox = new controls.ComboBox(people);
        var template = $("#person-template").html();
        var comboBoxHtml = comboBox.render(template);
        var container = document.getElementById('container');
        container.innerHTML = comboBoxHtml;

        $('#container').combobox()
    });
})();