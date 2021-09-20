// var btn = document.querySelector('#btnContainer button');

// var light = ':root {\n' +
//     '      --bg: white,\n' +
//     '      --color: black;\n' +
//     '    }';

// var dark = ':root {\n' +
//     '      --bg: #191919,\n' +
//     '      --color: white;\n' +
//     '    }';

// // Object method
// btn.onclick = function (ev) {
//     var target = ev.currentTarget;
//     if (target.classList.contains('active')) {
//         target.classList.remove('active');
//         target.innerHTML = 'Light mode'
//         document.querySelector('#rootStyle').innerHTML = dark;
//     } else {
//         target.classList.add('active');
//         document.querySelector('#rootStyle').innerHTML = light;
//         target.innerHTML = 'Dark mode'
//     }
// }

var btn = document.querySelector('#btnContainer button');
var dark = ':root {\n' +
    '            --bg: black;\n' +
    '            --color: white;\n' +
    '        }'
var light = ':root {\n' +
    '            --bg: white;\n' +
    '            --color: black;\n' +
    '        }'

btn.onclick = function (ev) {
    var target = ev.currentTarget;
    if (target.classList.contains('active')) {
        target.classList.remove('active')
        target.innerHTML = 'Choisir le light mode'
        document.querySelector('#rootStyle').innerHTML = dark;
    } else {
        target.classList.add('active')
        target.innerHTML = 'Choisir le dark mode'
        document.querySelector('#rootStyle').innerHTML = light;
    }
}