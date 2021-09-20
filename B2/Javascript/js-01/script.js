console.log('\x1B[31m=> Variables');
console.log('Salut');

// Déclaration de variable
var toto = 'Je suis Toto';
console.log(toto);

// Concaténation
var titi = 'Je suis';
var tata = 'fatigué de Hugo';
var tutu = titi + ' ' + tata;
console.log(tutu);

console.log('\x1B[31m=> Types');
// Types
var string = 'String'; // String
var number = 2; // Number
var boolean = true; // Boolean
var array = ['tata', 3, false]; // Array
var json = {
    "papa": "vieux",
    "maman": 69,
    "test": [
        'toto',
        3.4,
        true,
        function(param){return param;}
    ],
    "steps": {
        "titi": "papa",
        "tata": "trop vieille"
    }
};
console.log(json, array);
console.log(json.maman); // 69
console.log(json.steps.tata); // trop vieille
console.log(json.test[3]('string de ouf !'));

console.log('\x1B[31m=> Fonctions');
// Fonctions
function addition(a, b) {
    return a + b;
}

var total = addition(3, 4);
console.log(total);

console.log('\x1B[31m=> Callbacks');
// Callback
function testCallback(a, b, callback = false) {

    if (callback !== false) {
        var total = a + b;
        return callback(total);
        /*return (function() {
            return total + 6
        })()*/
    } else {
        return 'Il manque quelque chose...';
    }
}

function monCallback(value) {
    return value + 6;
}

var call = testCallback(4, 6, monCallback);
console.log(call);

