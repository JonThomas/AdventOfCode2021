# Day 2

## Problem 1
https://adventofcode.com/2021/day/2

The problem here is to keep track of two variables: Depth and Horizontal position. Depth can increase or decrease, whereas Horizontal position can only increase. Initial idea: Use pattern matching to evaluate and extract the values from each line in the file.

*Recursion*
I ended up writing a recursive function that continually processes the head of the list, and then passes the rest of the list in as an argument for the next recursion. 

One takeaway for me was I learned that recursive functions have their last argument both as input- and return- parameter.

The answer is obtained by multiplying the final horizontal position with the depth.

The answer is: 2215080

## Problem 2
https://adventofcode.com/2021/day/2#part2

The problem here is very similar to Day 2, problem 1, but a third variable "aim" has been introduced.

This fits nicely into the recursive method I already wrote, so I just had to understand the new rules for aim and update the the pattern matching and input variables.

The answer is 1864715580