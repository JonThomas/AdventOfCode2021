open System.IO

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

module FileUtils =
    let readFile (filePath: string) : seq<int> =
        System.IO.File.ReadLines(filePath)
        |> Seq.map(fun x -> (int)x)

[<EntryPoint>]
let main args =
    //for arg in args do
    //    printfn "Arg: %s" arg

    let filePath = "C:\dev\AdventOfCode2021\Day1-Input1.txt"
    let lines = FileUtils.readFile filePath 
    let lines2 = FileUtils.readFile filePath 
                 |> Seq.tail

    let decreasing = Seq.zip lines lines2
                    |> Seq.where (fun x -> (fst x) < (snd x))
                   // |> Seq.iter (fun x -> printfn "%d %d" (fst x) (snd x))

    printfn "The depth is decreasing %d number of times" (decreasing |> Seq.length)

    0

