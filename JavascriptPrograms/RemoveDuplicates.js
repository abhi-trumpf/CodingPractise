

function RemoveDuplivates(arr){
    let result = {};
    let correctarray = [];
    for(let i=0;i<arr.length;i++){
        let current = arr[i];
        if(current in result){ // if current is already a part of result object.
            continue;
        }
        else{
            result[current]= true; // if not , result is always going to be empty.
            correctarray.push(current);  // we need to push
        }
    }
    return correctarray;
}


let a = [1,2,3,4,4,4,5,5,1,6,6];
let x = RemoveDuplivates(a);
console.log(x);

//below is by using sets 



//using Sets

function RemoveDuplivates(arr){
    let set =   new Set(arr);
    return [...set];   // convert set into an array.
}

let a = [1,2,3,4,4,4,5,5,1,6,6];
let x = RemoveDuplivates(a);
console.log(x);
