'use strict';

/*
 * Add
 * Input: num1 and num2
 * Adds num2 (an addend) to num1 (an addend) and returns the sum.
 * Returns the addition result of two numbers.
 * 
 * Subtract
 * Input: num1 and num2
 * Subtract num2 (subtrahend) from num1 (minuend) and returns the difference.
 * Returns the subtraction difference.
 * 
 * Multiplication
 * Input: num1 (multiplier) and num2 (multiplicand).
 * Get the reuslt of num1 multiplied by num2.
 *  
 * 
 * Division
 * Input: num1 and num2
 * Get the result of num1 divided by num2.
 * Returns the division quotient.
 */

let calculator = {
    /**
     * Adds two numbers and gets the sum.
     * @param {Integer} num1 The first addend.
     * @param {Integer} num2 The second addend.
     * @returns Returns the sum of two addends.
     */
    add: function (num1, num2) {
        return num1 + num2;
    },

    /**
     * Gets the difference of two numbers.
     * @param {Integer} num1 The minuend.
     * @param {Integer} num2 The subtrahend.
     * @returns Returns the difference of num1 minus num2.
     */
    minus: function (num1, num2) {
        return num1 - num2;
    },

    /**
     * Gets the product of two numbers.
     * @param {Integer} num1 The multiplier.
     * @param {Integer} num2 The multiplicand.
     * @returns Returns the product of multiplier multiplied by multiplicand.
     */
    multiply: function (num1, num2) {
        return num1 * num2;
    },

    /**
     * Gets the quotient of two numbers.
     * @param {Integer} num1 The dividend.
     * @param {Integer} num2 The divisor.
     * @returns Returns the quotient of num1 divided by num2.
     */
    divide: function (num1, num2) {
        if (num2 === 0) {
            throw new Error('Division by zero.');
        }
        return num1 / num2;
    }
}

module.exports = calculator;
