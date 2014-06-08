/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var num1 = parseFloat(document.getElementById("num1").value);
    var result;
    switch(num1){
        case 0: result="zero";break;
        case 1: result="one";break;
        case 2: result="two";break;
        case 3: result="three";break;
        case 4: result="four";break;
        case 5: result="five";break;
        case 6: result="six";break;
        case 7: result="seven";break;
        case 8: result="eight";break;
        case 9: result="nine";break;
    }
    document.getElementById("result").innerText= "Result: " + result;
}

