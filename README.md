# Calculator code kata

A calculator executes operations on decimal numbers. Numbers are provided by entering digits (0-9) or a decimal dot (.) one after the other in an input register. 

The input register can accept any digit multiple times (leading zeroes are ignored). A decimal dot could be entered only once, consecutive entries must be ignored.

After a number is entered an operation (*, /, +, -. =) is selected, the value into the input register is pushed onto a calculation stack and the input register is cleared, ready to accept the next number.

Selecting an operation executes any operations inside the calculation stack reducing the stack only to the calculated value. 

Model a calculator using a language of your choice.
