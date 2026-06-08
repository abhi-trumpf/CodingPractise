function RemoveDuplivates(arr) {
  let result = {};
  let correctarray = [];
  for (let i = 0; i < arr.length; i++) {
    let current = arr[i];
    if (current in result) {
      continue;
    } else {
      result[current] = true;
      correctarray.push(current);
    }
  }
  return correctarray;
}

let a = [1, 2, 3, 4, 4, 4, 5, 5, 1, 6, 6];
let x = RemoveDuplivates(a);
console.log(x);

function RemoveDuplivates(arr) {
  let set = new Set(arr);
  return [...set];
}

let a = [1, 2, 3, 4, 4, 4, 5, 5, 1, 6, 6];
let x = RemoveDuplivates(a);
console.log(x);
