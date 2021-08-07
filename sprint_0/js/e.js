// JavaScript

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

function twoSum(a, b) {
    // Ваше решение
}

function solve() {
    const n = readInt();
    const a = readArray();
    const k = readInt();
    const ans = twoSum(a, k);
    if (ans.length === 0) {
        console.log("None")    
    } else {
        process.stdout.write(`${ans.join(' ')}`);
    }
    process.stdout.write(`${zip(a, b).join(' ')}`);
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