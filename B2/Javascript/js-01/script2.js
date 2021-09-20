console.log('\x1B[31m=> Objects');
// Objets

var monObjet = {

    begin: null,
    stop: null,
    init: function(a = false, b = false) {
        this.begin = a;
        this.stop = b;
        return this.start();
    },
    start: function () {
        var total = (this.begin !== false)
            ? this.begin + this.stop
            : 'Argument is missing !';
        return total;
    }
}

var go = monObjet.init(3, 4);
console.log(go);
var go2 = monObjet.init();
console.log(go2);


// Class
class City
{
    name;
    buildings;
    hospitals;

    constructor(n, b, h) {
        this.name = n;
        this.buildings = b;
        this.hospitals = h;
    }

    welcome() {
        return 'Welcome to ' + this.name + ' !';
    }

    countBuildings() {
        return this.buildings;
    }

    countHospitals() {
        return this.hospitals;
    }
}

var vegas = new City('Las Vegas', 10, 2),
    welcome = vegas.welcome();
    count1 = vegas.countBuildings(),
    count2 = vegas.countHospitals();

console.log(vegas, count1, count2);