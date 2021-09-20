console.log('\x1B[31m=> DOM');
// DOM

var paragraph = document.querySelector('#paragraph');
console.log(paragraph);
console.log(paragraph.id);
console.log(paragraph.title);
console.log(paragraph.textContent);
console.log(paragraph.innerHTML);

paragraph.id = 'papa';
console.log(paragraph.id);
