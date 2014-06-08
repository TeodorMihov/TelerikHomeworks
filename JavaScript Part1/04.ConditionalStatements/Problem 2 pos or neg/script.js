/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var num1 = document.getElementById("num1").value,
        num2 = document.getElementById("num2").value,
        num3 = document.getElementById("num3").value,
        signCounter = 0;

    if (num1 < 0) {
        signCounter++;
    }
    if (num2 < 0) {
        signCounter++;
    }
    if (num3 < 0) {
        signCounter++;
    }
    if (signCounter % 2 === 0) {
        document.getElementById("result").innerText= "The product is a positive number";
    }
    else {
        document.getElementById("result").innerText = "The product is a negative number";
    }
}

