const _readline = require('readline');

const _reader = _readline.createInterface({
    input: process.stdin
});

const _inputLines = [];
let _curLine = 0;

_reader.on('line', line => {
    _inputLines.push(line);
});

process.stdin.on('end', solve);

// Если ответ существует, верните список из двух элементов
// Если нет - то верните пустой список 
function twoSum(array, targetSum) {
    // Ваше решение
}

function solve() {
    const n = readInt();
    const array = readArray();
    const targetSum = readInt();
    const ans = twoSum(array, targetSum);
    if (ans.length === 0) {
        console.log("None")    
    } else {
        process.stdout.write(`${ans.join(' ')}`);
    }
}

function readInt() {
    const n = Number(_inputLines[_curLine]);
    _curLine++;
    return n;
}

function readArray() {
    var arr = _inputLines[_curLine].trim(" ").split(" ").map(num => Number(num));
    _curLine++;
    return arr;
}