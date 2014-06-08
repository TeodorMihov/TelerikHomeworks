/**
 * Created with JetBrains RubyMine.
 * User: Joker
 * Date: 3/10/13
 * Time: 11:05 AM
 * To change this template use File | Settings | File Templates.
 */
function check(){
    var number = parseFloat(document.getElementById("num1").value);
    var result = get_number_name(number);
    document.getElementById("result").innerText= "Result: " + result;
}

function get_number_name(number){
    var ones = 0;
    var tenths = 0;
    var hundreds = 0;
    var name = "";

    ones = parseInt(number % 10);
    tenths = parseInt((number % 100) / 10);
    hundreds = parseInt((number % 1000) / 100);
    switch (parseInt(hundreds)){
        case 0:
            break;
        case 1:
            name="One hundred "; break;
        case 2:
            name="Two hundred "; break;
        case 3:
            name="Three hundred "; break;
        case 4:
            name="Four hundred "; break;
        case 5:
            name="Five hundred "; break;
        case 6:
            name="Six hundred "; break;
        case 7:
            name="Seven hundred "; break;
        case 8:
            name="Eight hundred "; break;
        case 9:
            name="Nine hundred "; break;
    }
    if ((tenths==1 || ones==0) && hundreds!=0){
        name = name.concat("and ");
    }
    switch (tenths){
        case 0:
            break;
        case 1:
            switch (ones)
            {
                case 0:
                    name= name.concat("ten "); break;
                case 1:
                    name=name.concat("eleven "); break;
                case 2:
                    name=name.concat("twelve "); break;
                case 3:
                    name=name.concat("thirteen "); break;
                case 4:
                    name=name.concat("fourteen "); break;
                case 5:
                    name=name.concat("fifteen "); break;
                case 6:
                    name=name.concat("sixteen "); break;
                case 7:
                    name=name.concat("seventeen "); break;
                case 8:
                    name=name.concat("eighteen "); break;
                case 9:
                    name=name.concat("nineteen "); break;
            }
            break;
        case 2:
            name=name.concat("twenty "); break;
        case 3:
            name=name.concat("thirty "); break;
        case 4:
            name=name.concat("fourty "); break;
        case 5:
            name=name.concat("fivty "); break;
        case 6:
            name=name.concat("sixty "); break;
        case 7:
            name=name.concat("sevanty "); break;
        case 8:
            name=name.concat("eighty "); break;
        case 9:
            name=name.concat("ninety "); break;
    }
    if (tenths == 0 && hundreds != 0)
    {
        name = name.concat("and ");
    }
    if (tenths!=1){
        switch(ones){
            case 0:
                if (hundreds==0 && tenths==0){
                    name = name + "zero";
                }
                break;
            case 1:
                name=name.concat("one "); break;
            case 2:
                name=name.concat("two "); break;
            case 3:
                name=name.concat("three "); break;
            case 4:
                name=name.concat("four ") ; break;
            case 5:
                name=name.concat("five "); break;
            case 6:
                name=name.concat("six "); break;
            case 7:
                name=name.concat("seven "); break;
            case 8:
                name=name.concat("eight "); break;
            case 9:
                name=name.concat("nine "); break;
        }
    }
    return name;
}
