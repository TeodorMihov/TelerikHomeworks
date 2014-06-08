function Solve(input) {
    var result = 1;
    input = input.map(Number);
    for (var i = 2; i < input.length; i++) {
        if (input[i - 1] > input[i]) {
            result++;
        }
    }
    return result;
}

var input = [
    7,
    11,
    2,
    -3,
    42,
    4,
    110,
    1
];
var answer = Solve(input);
console.log(answer);