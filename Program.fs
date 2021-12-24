open JonThomas.AdventOfCode2021
 
(*
    run program by using the following command: dotnet run
    
    The problem here is to count the number of times the next value in a sequence is larger than the previous number.
    My orignal ide was along these lines:
        let deeper = seq { lines -> lines[n-1] > lines[n] }
    I couldn't find a way to compare two following items in a sequence in F#, so I ended up reading the file twice into
    two different sequences, and combining the sequences into a sequence of touples using Seq.zip 
    (The first item from sequence2 was removed before combining them):
        (item0 item1)
        (item1 item2)
        (item2 item3)
        ...
    It is now trivial to check if item0 is larger than item1, and count the result
*)

[<EntryPoint>]
let main args =
    //for arg in args do
    //   printfn "Arg: %s" arg

    Day1.day11

    0