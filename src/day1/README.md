# Day 1

## Problem 1
https://adventofcode.com/2021/day/1

The problem here can be solved by counting the number of times the next value in a sequence is larger than the previous value.

My orignal ide was along these lines:

    let deeper = seq { lines -> lines[n-1] > lines[n] }

I couldn't find a way to compare two following items in a sequence in F#, so I ended up reading the file twice into two different sequences, and combining the sequences into a sequence of touples using Seq.zip 

(The first item from sequence2 was removed before combining them):
    (item0 item1)
    (item1 item2)
    (item2 item3)
    ...

It is now trivial to check if item0 is larger than item1, and count the result

The answer is 1766

## Problem 2
https://adventofcode.com/2021/day/1#part2

The problem here is similar to Problem 1 above in that we have to count the number of times the next value in a sequence
is larger than the previous value, but this time I have to compare the sum of the three first number with the sum of the next three numbers: 

    n + (n+1) + (n+2) < (n+1) + (n+2) + (n+3)

It took me a while, but I finally think I figured out that working with sequences the way I was, didn't work very well: Sequences are evaluated on demand, which created issues for me. I changed to using arrays, and that move simplified things. (Sequences are just an abstraction for lists and arrays)


The answer is 1797