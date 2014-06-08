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

    if (num1>num2) {
        var buff=num2;
        num2=num1;
        num1=buff;
    }

    document.getElementById("result").innerText= "num1 =" + num1 + ", num2=" + num2;
}

