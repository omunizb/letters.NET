
var myName = ['O', 'r', 'i', 'o', 'l'];

var repLetters = {};

myName.forEach(function(letter) {
    // Adapted from https://stackoverflow.com/a/14636652
    if (repLetters[letter.toLowerCase()] === parseInt(repLetters[letter.toLowerCase()])) {
        repLetters[letter.toLowerCase()]++;
    }
    else {
        repLetters[letter.toLowerCase()] = 1;
    }
});

for (letter in repLetters) {
    console.log(`${letter}: ${repLetters[letter]}`);
}
