function Solve(input) {
    var state = 'function name',
        functions = {};
    
    for (var i = 0; i < input.length; i++) {
        switch (state) {
            case 'function name':
                for (var j = 0; j < input[i].length; j++) {
                    var currentSymbol = input[i][j];
                    if (currentSymbol === '(') {
                        state = 'operations';
                    }
                    else if (currentSymbol === ' ') {
                        continue;
                    }
                    else {
                        functions.name += currentSymbol;
                    }
                }
                break;
            case 'operations':
                break;
        }
    }
}

var input = [
    '(def     func     10  )',
    '(def newFunc (+  func 2))',
    '(def sumFunc (+ func func newFunc 0 0 0))',
    '(* sumFunc 2)'
];

function getNumbers(line) {
    var len = line.length,
        digit = '',
        numbers = [];

    for (var i = 0; i < len; i++) {
        var symbol = line[i];

        if (symbol === ' ' || symbol === ')') {

            if (!isFinite(digit)) {
                numbers.push(parseInt(digit));
                digit = '';
            }
            digit = '';
        }
        digit += symbol;
    }

    return numbers;
}