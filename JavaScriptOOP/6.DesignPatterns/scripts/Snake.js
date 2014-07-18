var snake = (function(){
    var snakePartSize = 10;

    var GameObject = function(x, y, size){
        this.x = x;
        this.y = y;
        this.size = size;
    };
    GameObject.prototype = {
        getPosition: function(){
            return {
                x: this.x,
                y: this.y
            };
        },
        getSize: function(){
            return this.size;
        }
    };
    var Snake = function(x, y, size){
        var part,
            partX,
            partY;
        this.parts = [];
        for (var i = 0; i < size; i += 1){
            partX = x - i * snakePartSize;
            partY = y;
            part = new SnakePart(partX, partY, snakePartSize);
            this.parts.push(part);
        }
    };
    Snake.prototype = new GameObject();

    var SnakePart = function(x, y, size){
        GameObject.call(this, x, y, size);
    };
    SnakePart.prototype = new GameObject();
    SnakePart.prototype.changePosition = function(x, y){
        this.x = x;
        this.y = y;
    };

    var Wall = function(x, y, size){
        GameObject.call(this, x, y, size);
    };
    Wall.prototype = new GameObject();

    var Food = function(x, y, size){
        GameObject.call(this, x, y, size);
    };
    Food.prototype = new GameObject();

    return {
        get: function(x,y,size){
            return new Snake(x,y,size);
        },
        SnakeType: Snake,
        Food: Food,
        Wall: Wall
    }
}());