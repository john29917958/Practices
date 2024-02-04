const calculator = require('./calculator.js');

test('adds 1 + 2 to equal 3', () => {
    expect(calculator.add(1, 2)).toBe(3);
});

test('minuses 2 - 1 to equal to 1', () => {
    expect(calculator.minus(2, 1)).toBe(1);
});

test('multiplies 2 * 3 to equal to 6', () => {
    expect(calculator.multiply(2, 3)).toBe(6);
});

test('divides 3 / 2 to equal to 1.5', () => {
    expect(calculator.divide(3, 2)).toBe(1.5);
});

test('should throw an error if divided by zero', () => {
    expect(() => {
        calculator.divide(3, 0);
    }).toThrow('Division by zero.');
});
