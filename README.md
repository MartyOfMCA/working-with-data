# working-with-data
A simple C# project that demonstrates how to work with variables and arrays

## Variables
These are merely pointers to portions in your computer's RAM where an actual value can be stored. In C#, variables are always defined with a data type instructing the contents that can be stored inside the variable.
In this project, variables are used to accomplish the following:

* Store the number the user provides
* Store the result we obtained after calculating the double for the number the user enters
* Store the result we obtained after calculating the cube for the number the user enters

### Code snippets
Some examples for creating variables

Create a variable to store a whole number
`int number`;
Create a variable to store the name for the user
`string name;`

## Arrays
An array is a block that stores multiple values adjacent each other in the computers RAM. Arrays can be used to enhance a program if used appropriately. 
For instance, if you were to write a program where you had to accept 20 numbers, creating 20 variables not only would prove a waste of time but can actually slow your program's performance. Becasue what happen whenever a variable is created is that some portion in your RAM is randomly allocated to the variable. But for arrays, all 20 values will be stored next to each other, making data retrieval a lot faster.
In this project, arrays are used to accomplish the following:

* Store multiple numbers to be used for the computations
* Store the results obtained as the double for the numbers accepted from the user
* Store the results obtained as the cube for the numbers accepted from the user

### Code snippets
Some examples for creating arrays

Create an array to store 20 numbers
`int[] numbers = new int[20];`
Create an array to store 9 names
`string[] names = new string[9]`

Have fun!
