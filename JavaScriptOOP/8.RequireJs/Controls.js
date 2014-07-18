define(['jquery', 'handleBars'], function($){
    var controls = (function (){
        var ComboBox = (function (){
            function ComboBox(people){
                this.people = people;
            }
            ComboBox.prototype.render = function(template){
                var hbTemplate = Handlebars.compile(template);
                var hbTemplateArray = '';
                for(var i = 0; i < this.people.length; i += 1) {
                    hbTemplateArray += hbTemplate(this.people[i]);
                }

                return hbTemplateArray;
            };

            return ComboBox;
        })();

        return {
            ComboBox: ComboBox
        };
    })();

    return controls;
});