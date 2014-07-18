/**
 * Created by Teodor on 6/27/2014.
 */
var renderers = (function(){
    var CanvasRenderer = function(selector){
        if(selector instanceof HTMLCanvasElement){
            this.context = selector;
        }
        else if(typeof selector === "string" ||
                typeof selector === "String"){
            this.context = document.querySelector(selector);
        }
    };
    CanvasRenderer.prototype = {
        draw: function(obj){
            if(obj instanceof snake.SnakeType){
                drawSnake(this.canvas, obj);
            }
            else if(obj instanceof snake.Food){
                drawFood(this.canvas, obj);
            }
            else if(obj instanceof snake.Wall){
                drawWall(this.canvas, obj);
            }
        }
    }

    return {
        getCanvas: function(){
            return new CanvasRenderer();
        }
    }
}());