function Solve(input) {
            var rowsColsJumps = input[0].split(' ').map(Number);
            var rows = rowsColsJumps[0];
            var cols = rowsColsJumps[1];
            var numberOfJumps = rowsColsJumps[2];

            var startPos = input[1].split(' ').map(Number);
            var startRow = startPos[0];
            var startCol = startPos[1];

            var field = [];
            var fillCounter = 1;

            for (var i = 0; i < rows; i++) {
                field[i] = [];

                for (var j = 0; j < cols; j++) {
                    field[i][j] = fillCounter++;
                }
            }

            var jumpSequence = [];
            for (var i = 2; i < input.length; i++) {
                var jumpLineCommand = input[i].split(' ').map(Number);

                var currentJumpPosition = {
                    row: jumpLineCommand[0],
                    col: jumpLineCommand[1]
                };

                jumpSequence.push(currentJumpPosition);
            }

            var currentRow = startRow;
            var currentCol = startCol;
            var sumOfNumbers = 0;
            var jumpsCount = 0;
            var jumpCounter = 0;
            var escaped = false;


            while (true) {
                if (currentRow < 0 ||
                        currentRow >= rows ||
                        currentCol < 0 ||
                        currentCol >= cols) {
                    return 'escaped ' + sumOfNumbers;
                }

                if (isNaN(field[currentRow][currentCol])) {
                    return 'caught ' + numberOfJumps;
                }

                sumOfNumbers += field[currentRow][currentCol];
                jumpsCount++;
                field[currentRow][currentCol] = '@';

                if (jumpCounter >= numberOfJumps) {
                    jumpCounter = 0;

                }

                currentRow += jumpSequence[jumpCounter].row;
                currentCol += jumpSequence[jumpCounter].col;

                ++jumpCounter;
            }
        }

        input = [
            '6 7 3',
            '0 0',
            '2 2',
            '-2 2',
            '3 -1'
        ];

        Solve(input);