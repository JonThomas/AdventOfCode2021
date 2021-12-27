namespace JonThomas.AdventOfCode2021

open JonThomas.AdventOfCode2021

module Day1 =

    let filePath = ".\src\day1\Day1-Input1.txt"

    let day11 = 

        let lines = FileUtils.readFile filePath
                    |> Seq.toArray 
        let lines2 = lines 
                    |> Array.tail

        let decreasing = Array.zip lines[0 .. lines.Length - 2] lines2
                        |> Array.where (fun x -> 
                            let first, second = x
                            first < second)
                    // |> Seq.iter (fun x -> printfn "%d %d" (fst x) (snd x))

        $"The depth is decreasing {(decreasing |> Array.length)} times"

    let day12 =

        let lines = FileUtils.readFile filePath
                    |> Seq.toArray
        let lines2 = lines[1 .. lines.Length - 2]
        let lines3 = lines[2 ..]

        let slidingWindow = Array.zip3 lines[0 .. lines.Length - 3] lines2 lines3 
                                |> Array.map(fun x -> 
                                let first, second, third = x
                                first + second + third)
        //printfn "Length of slidingWindow: %d" (slidingWindow |> Seq.length)

        let slidingWindow2 = slidingWindow[1 .. slidingWindow.Length]
        //printfn "Length of slidingWindow2: %d" (slidingWindow2 |> Seq.length)

        let decreasing = Array.zip slidingWindow[0 .. slidingWindow.Length - 2] slidingWindow2
                        |> Array.where (fun x -> 
                            let first, second = x
                            first < second)
                        |> Array.length

        $"The depth is decreasing {decreasing} number of times"