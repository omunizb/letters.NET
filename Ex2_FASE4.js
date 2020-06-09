var myName = ['O', 'R', 'I', 'O', 'L'];
var mySurname = ['M', 'U', 'N', 'I', 'Z'];

var addedSpace = [...myName];
addedSpace.push(' ');

var fullName = addedSpace.concat(mySurname);

console.log(fullName);
