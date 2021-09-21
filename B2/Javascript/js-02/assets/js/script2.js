var btn = document.querySelector('#btnContainer button');
var dark = ':root {\n' +
    '            --bg: black;\n' +
    '            --color: white;\n' +
    '        }'
var light = ':root {\n' +
    '            --bg: white;\n' +
    '            --color: black;\n' +
    '        }'

// btn.onclick = function (ev) {
//     var target = ev.currentTarget;
//     if (target.classList.contains('active')) {
//         target.classList.remove('active')
//         target.innerHTML = 'Light mode'
//         document.querySelector('#rootStyle').innerHTML = dark;
//     } else {
//         target.classList.add('active')
//         target.innerHTML = 'Dark mode'
//         document.querySelector('#rootStyle').innerHTML = light;
//     }
// }

btn.addEventListener('click', (ev) => {
    var target = ev.currentTarget;
    if (target.classList.contains('active')) {
        target.classList.remove('active')
        target.innerHTML = 'Light mode'
        document.querySelector('#rootStyle').innerHTML = dark;
    } else {
        target.classList.add('active')
        target.innerHTML = 'Dark mode'
        document.querySelector('#rootStyle').innerHTML = light;
    }
});