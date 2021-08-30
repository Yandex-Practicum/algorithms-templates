const _readline = require('readline');

const _reader = _readline.createInterface({
    input: process.stdin
});

const _inputLines = [];
let _curLine = 0;

// Установим callback на считывание строки - так мы получим
// все строки из ввода в массиве _inputLines.
_reader.on('line', line => {
    _inputLines.push(line);
});

process.stdin.on('end', solve);


// Функция парсит число из очередной строки массива _inputLines
// и сдвигает указатель на единицу вперёд.
function readNumber() {
    return Number(_inputLines[_curLine++]);
}

function evaluateFunction(a, b, c, x) {
    // Ваше решение
    return a * x * x + b * x + c;
}

function solve() {
    const a = readNumber();
    const b = readNumber();

    console.log(getSum(a, b));
}