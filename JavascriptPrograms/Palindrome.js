let userinput = 121;
let original = userinput;
let rev = 0;
while (userinput > 0) {
  rev = rev * 10 + (userinput % 10);
  userinput = Math.floor(userinput / 10);
}
if (rev == original) {
  console.log("Palindrome");
} else {
  console.log("not a Palindome");
}
