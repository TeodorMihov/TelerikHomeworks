function Solve(input) {
    var firstLine = input[0].split(' ').map(Number),
        rows = firstLine[0],
        cols = firstLine[1],
        jumps = firstLine[2],
        startPosition = input[1].split(' ').map(Number),
        startRow = startPosition[0],
        startCol = startPosition[1];

    var matrix = [],
        cntr = 1;
    for (var i = 0; i < rows; i++) {
        matrix[i] = [];
        for (var j = 0; j < cols; j++) {
            matrix[i][j] = cntr++;
        }
    }

    var jumpMatrix = [];
    for (var i = 2; i < input.length; i++) {
        var line = input[i].split(' ').map(Number);
        currentPosition = {
            Row: line[0],
            Col: line[1]
        }
        jumpMatrix.push(currentPosition);
    }

    var currentRow = startRow,
        currentCol = startCol,
        sumOfJumps = 0,
        numberOfJumps = 0,
        counter = 0;
    while (true) {
        if (currentRow < 0 ||
                currentRow >= rows ||
                currentCol < 0 ||
                currentCol >= cols) {
            return 'escaped ' + sumOfJumps;
            //console.log('escaped ' + sumOfJumps);
            //break;
        };

        if (matrix[currentRow][currentCol] === 'a') {
            return 'caught ' + numberOfJumps;
            //console.log('caught ' + numberOfJumps);
            //break;
        };

        sumOfJumps += matrix[currentRow][currentCol];
        numberOfJumps++;
        matrix[currentRow][currentCol] = 'a';

        if (counter >= jumps) {
            counter = 0;
        }

        currentRow += jumpMatrix[counter].Row;
        currentCol += jumpMatrix[counter].Col;

        counter++;
    }

    //console.log('reached end');
}

var input = [
    '6, 7, 3',
    '0, 0',
    '2, 2',
    '-2, 2',
    '3, -1'
];
var result = Solve(input);
console.log(result);
