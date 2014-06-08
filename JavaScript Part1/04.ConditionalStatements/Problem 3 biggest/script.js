/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var num1 = document.getElementById("num1").value;
    var num2 = document.getElementById("num2").value;
    var num3 = document.getElementById("num3").value;

    var first = num1;
    if (first<num2) {
        first = num2;
    }
    if (first<num3){
        first = num3;
    }

    document.getElementById("result").innerText= "biggest: " + first;
}

