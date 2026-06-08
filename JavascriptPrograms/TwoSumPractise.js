

function twosum(arr,target){
let result = {};  // You are instantiating a new Object (using the Object constructor/literal)
for (let i=0;i<arr.length;i++){  //everything is done wrt i
    let number = arr[i];
    let compliment = target - number;
    if(compliment in result){   //ok it only works because we are only trying to compliment for 
    // the elements that are already a part of the result map {}.
        return[result[compliment],i];    //with respect to result and use square brackets.
    }
    else{
// FIX 2: Store the number as the key, index as the value Key: The Number (e.g., 2) Value: The Index (eg 0)
        result[number] = i;  // already ulta-bulta
        // object[val] - index format .
    }
}
return [];
}



let x = twosum([1,2,3,4],3);
console.log(x);