var myName = ['O', 'r', 'i', 'o', 'l'];

// Adapted from https://stackoverflow.com/a/5488098
function isVowel(c) {
    if (['a', 'e', 'i', 'o', 'u'].indexOf(c.toLowerCase()) != -1) {
        return true;
    }
    else {
        return false;
    }
}

var isVowel;

myName.forEach(function(letter) {
    // Adapted from https://stackoverflow.com/a/8935688
    if(letter >= '0' && letter <= '9')
    {
        console.log("Person names don't have numbers!")
    }
    else if (isVowel(letter))
    {
        console.log(letter + " VOWEL")
    }
    // Adapted from https://stackoverflow.com/a/9862788
    else if (letter.match(/[a-z]/i))
    {
        console.log(letter + " CONSONANT")
    }
})