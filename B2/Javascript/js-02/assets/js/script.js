const p1 = document.querySelector("#bloc1 > p");
p1.innerHTML = `Fred c'est un &nbsp<span style="text-transform: uppercase; color: gold;">bon</span>&nbspprof`;

const span = document.querySelector("#bloc1 > p > span");
console.log(span.textContent);

const sections = document.querySelectorAll(".sections");
console.log(sections);

for (var i = 0; i < sections.length; i++) {
    var section = sections[i];

    const d = new Date(),
        year = d.getFullYear(),
        month =
            d.getMonth().toString.length < 2
                ? '0' + (d.getMonth() + 1)
                : d.getMonth() + 1,

        day = d.getDate();

    const currentDate = `${year}/${month}/${day}`;

    console.log(currentDate);

    console.log(section.id);
    section.classList.add(`maClass-${i}`);
    section.dataset.toto = currentDate
}

function formalizeDate(data) {
    var d = new Date(date),
        year = d.getFullYear(),
        month = ('0' + (d.getMonth() + 1)).slice(-2),
        day = ('0' + (d.getDay() + 1)).slice(-2);
    return `${year}-${month}-${day}`;
}

for (var i = 0; i < sections.length; i++) {

    if (i % 2 == 0) {
        sections[i].style.backgroundImage = "linear-gradient(to top, #fbc2eb 0%, #a6c1ee 100%);";
        
    }
}