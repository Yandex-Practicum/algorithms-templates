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

function evaluateFunction(x, a, b, c) {
    // Ваше решение
}

function solve() {
    const inputNumbers = readArray();
    const a = inputNumbers[0]
    const x = inputNumbers[1]
    const b = inputNumbers[2]
    const c = inputNumbers[3]
    process.stdout.write(`${evaluateFunction(x, a, b, c)}`);
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
