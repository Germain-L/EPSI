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


const stt = 'active';


function themeSelector(ev, stt = false) {
    var target = (ev.type !== 'load') ? ev.currentTarget : btn;
    if (stt === 'active') {
        target.classList.add('active')
        target.innerHTML = 'Dark mode'
        document.querySelector('#rootStyle').innerHTML = light;
    }
    if (target.classList.contains('active')) {
        target.classList.remove('active')
        target.innerHTML = 'Light mode'
        document.querySelector('#rootStyle').innerHTML = dark;
    }
}

btn.addEventListener('click', (ev) => {
    themeSelector(ev);
});

window.addEventListener('load', function (ev) {
    themeSelector(ev, stt);
})