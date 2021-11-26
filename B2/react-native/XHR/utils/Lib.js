export function initials(firstname, lastname, callback) {
  let first = firstname[0].toUpperCase(),
    last = lastname[0].toUpperCase();

  callback(first + last);
}
