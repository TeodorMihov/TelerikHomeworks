window.onload = (function() {
    'use strict';
 
    var a = document.createElement('style');
    a.innerHTML = 'li{list-style-type:none}';
    document.head.appendChild(a);
 
    var treeView = document.createElement('ul');
    treeView.innerHTML = 'Unordered list';
    document.body.appendChild(treeView);
 
    addLi(0, treeView, 'List Item ');
 
    function addLi(depth, parent, text) {
        for (var i = 0; i < 2; i++) {
            var li = document.createElement('li');
            var liTxt = text + (i + 1);
            li.innerHTML = liTxt;
            var ul = document.createElement('ul');
            if (depth < 3) {
                addLi(depth + 1, ul, liTxt + '.');
            }
            li.appendChild(ul);
            parent.appendChild(li);
        }
    }
 
})();