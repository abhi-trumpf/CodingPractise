//3.KING Of The Hill find max without using  .Max()

let s3 = [1,23,344,4,100,555];

// 🟢 1. Declare max OUTSIDE the loop so it keeps its memory
let max = 0;
for (let item of s3){  // love
    if(item>max)
    {
        max = item;
    }
}
console.log(`Highest is ${max}`);