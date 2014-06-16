/**
 * Created by Teodor on 6/15/2014.
 */
var $generateTable = $('<button>').text('Generate Table').appendTo('body');

$generateTable.on('click', createTable);

function createTable() {
    var $table = $('<table>').appendTo('body'),
        $thead = $('<thead>').appendTo($table),
        $tr = $('<tr>').appendTo($thead),
        $tbody = $('<tbody>').appendTo($table);

    $tr.append($('<th>').text('First name'));
    $tr.append($('<th>').text('Last name'));
    $tr.append($('<th>').text('Grade'));


    for(var i in students) {
        var $infoStudent = $('<tr>').appendTo($tbody);
        $infoStudent.append($('<td>').text(students[i].firstName));
        $infoStudent.append($('<td>').text(students[i].lastName));
        $infoStudent.append($('<td>').text(students[i].grade));
    }

}

var students = [{
    firstName: 'Peter',
    lastName: 'Ivanov',
    grade: 3
}, {
    firstName: 'Milena',
    lastName: 'Grigorova',
    grade: 6
}, {
    firstName: 'Gergana',
    lastName: 'Borisova',
    grade: 12
}, {
    firstName: 'Boyko',
    lastName: 'Petrov',
    grade: 7
}];