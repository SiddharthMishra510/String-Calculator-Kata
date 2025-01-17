# String Calculator Kata - C#

This is a C# implementation of the String Calculator Kata. The goal of this Kata is to write a simple string calculator that can process a string of numbers and return the sum, as well as handle various edge cases.

## Requirements

The calculator should support the following operations:

**Addition:**

Add two or more numbers in a single string.
For example, "1,2,3" should return 6.

**Newline as a delimiter:**

The calculator should be able to handle both commas (,) and newlines (\n) as delimiters.
For example, "1\n2,3" should also return 6.

**Custom delimiters:**

The calculator should be able to support custom delimiters specified at the start of the string.
For example, "//;\n1;2;3" should return 6 using ; as the delimiter.

**Negative numbers:**

The calculator should throw an exception if any negative numbers are passed in the string.
The exception message should list all negative numbers.

## Setup

Clone this repository to your local machine:
bash
git clone [https://github.com/SiddharthMishra510/String-Calculator-Kata.git](https://github.com/SiddharthMishra510/String-Calculator-Kata.git)


Open the project in Visual Studio or your preferred C# IDE. (I've used JetBrains Rider)

Build the solution to ensure all dependencies are correctly installed.

## How to Run the Tests

This project includes unit tests to verify the functionality of the StringCalculator class.

1. Open the project in Visual Studio or your preferred C# IDE.
2. Build the solution to ensure all dependencies are installed.
3. Run the tests using the Test Explorer.

## Notes

**Assumptions:**

* The input string will contain valid numeric characters and delimiters.
* Custom delimiters are specified only at the beginning of the string using the format `//delimiter\n`.