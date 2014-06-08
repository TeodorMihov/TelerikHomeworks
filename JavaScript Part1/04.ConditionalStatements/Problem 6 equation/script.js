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

    var roots = solver(num1,num2,num3);

    if(roots.length==0){
        document.getElementById("result").innerText= "Result: There are no roots" ;
    }
    if(roots.length==1){
        document.getElementById("result").innerText= "Result: " + roots[0];
    }
    if(roots.length==2){
        document.getElementById("result").innerText= "Result: " + roots[0] + ", " + roots[1];
    }
}

function solver(num1,num2,num3){
    var discriminant = 0;
    var roots = new Array();
    discriminant = Math.pow(num2,2) - 4 * num1 * num3;

    if (discriminant>0){
        roots[0] = ((-num2) + Math.sqrt(Math.pow(num2, 2) - 4 * num1 * num3)) / (2 * num1);
        roots[1] = ((-num2) - Math.sqrt(Math.pow(num2, 2) - 4 * num1 * num3)) / (2 * num1);
    }

    if (discriminant==0){
        roots[0] = (-numbers[1]) / (numbers[0] * 2);
    }

    return roots;
}
