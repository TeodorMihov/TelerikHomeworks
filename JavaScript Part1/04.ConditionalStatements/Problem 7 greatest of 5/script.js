/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var nums = new Array();
    nums[0] = parseFloat(document.getElementById("num1").value);
    nums[1] = parseFloat(document.getElementById("num2").value);
    nums[2] = parseFloat(document.getElementById("num3").value);
    nums[3] = parseFloat(document.getElementById("num4").value);
    nums[4] = parseFloat(document.getElementById("num5").value);

    var biggest=0;
    for (var i=0; i<nums.length; i++){
        if (nums[i]>biggest){
            biggest=nums[i];
        }
    }

    document.getElementById("result").innerText= "Result: " + biggest ;
}
