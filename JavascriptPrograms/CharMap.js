let word = "Pretty";

function CharMap(s) {
  let result = {};
  for (let item of s) {
    if (result[item]) {
      result[item] = result[item] + 1;
    } else {
      result[item] = 1;
    }
  }
  return result;
}

let x = CharMap(word);
console.log(x);
