# Question 2: Answers

Consider the following function definition:

```javascript
function compareIt(num1, num2) {
    return num1 == num2;
}

compareIt(5, "5");
```

## Question 1: Why will the function call return true?

The `compareIt` function uses the equality operator (`==`) to compare its two parameters. In JavaScript, the `==` operator performs type coercion when the operands are of different types. This means it will convert the operands to a common type before comparing them.

When you call `compareIt(5, "5")`:

1. The number `5` is compared with the string `"5"`.
2. JavaScript converts the string `"5"` to the number `5`.
3. After this conversion, the comparison is essentially `5 == 5`, which is true.

Thus, the function returns `true` when invoked with `compareIt(5, "5")`.

## Question 2: How could one change this function so that data types are checked as well as values?

To modify the function to check both value and data type, you should use the strict equality operator (`===`) instead of the equality operator (`==`):

```javascript
function compareIt(num1, num2) {
    return num1 === num2;
}
```

**Explanation:**  
The strict equality operator (`===`) compares both the value and the data type without performing type coercion. When using the modified function:

- `compareIt(5, 5)` would return `true` because both the value and type match.
- `compareIt(5, "5")` would return `false` because although the values are equivalent, the types are different (number vs string).

This stricter comparison ensures that your function only considers two values equal if they have identical data types and values.