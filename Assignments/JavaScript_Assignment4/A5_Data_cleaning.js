let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let uniqueNumbers = [...new Set(numbers)];
console.log(uniqueNumbers);

let secondLargest = [...new Set(numbers)]
  .sort((a, b) => b - a)[1];
console.log(secondLargest);

let frequency = numbers.reduce((acc, num) => {
  acc[num] = (acc[num] || 0) + 1;
  return acc;
}, {});
console.log(frequency);

let firstNonRepeating = numbers.find(num => frequency[num] === 1);
console.log(firstNonRepeating);

let rotatedBy2 = [
  ...numbers.slice(-2),
  ...numbers.slice(0, numbers.length - 2)
];
console.log(rotatedBy2);

let nested = [1, 2, [3, 4, [5]]];
let flattened = nested.flat(Infinity);
console.log(flattened);

let arr = [1, 2, 3, 5, 6];
let missingNumber = arr
  .reduce((sum, num) => sum + num, 0);

let n = arr.length + 1;
let expectedSum = (n * (n + 1)) / 2;
console.log(expectedSum - missingNumber);