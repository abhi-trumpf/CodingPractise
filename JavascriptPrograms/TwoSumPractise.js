function twosum(arr, target) {
  let result = {};
  for (let i = 0; i < arr.length; i++) {
    let number = arr[i];
    let compliment = target - number;
    if (compliment in result) {
      return [result[compliment], i];
    } else {
      result[number] = i;
    }
  }
  return [];
}

let x = twosum([1, 2, 3, 4], 3);
console.log(x);
