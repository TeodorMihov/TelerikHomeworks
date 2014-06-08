/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var num1 = parseFloat(document.getElementById("num1").value);
    var num2 = parseFloat(document.getElementById("num2").value);
    var num3 = parseFloat(document.getElementById("num3").value);

    var first = 0;
    var second = 0;
    var third = 0;

    if (num1>num2) {
        if (num1>num3){
            first=num1;
            if (num2>num3){
                second=num2;
                third=num3;
            }
            else{
                second=num3;
                third=num2;
            }
        }
        else{
            first=num3;
            second=num1;
            third=num2;
        }
    }
    else{
        // num2 > num1
        if (num1>num3){
            first = num2;
            second = num1;
            third = num3;
        }
        else{
            // num3 > num1
            third=num1;
            if (num2>num3){
                first=num2;
                second=num3;
            }
            else{
                first=num3;
                second=num2;
            }
        }
    }

    document.getElementById("result").innerText= "Result: " + first + ", " + second + ", " + third;
}

