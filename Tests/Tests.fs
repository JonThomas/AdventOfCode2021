namespace JonThomas.AdventOfCode2021.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open JonThomas.AdventOfCode2021

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.TestDay11() =
        Assert.AreEqual(1766, fst(Day1.day11))

    [<TestMethod>]
    member this.TestDay12() =
        Assert.AreEqual(1797, fst(Day1.day12))

    [<TestMethod>]
    member this.TestDay21() =
        Assert.AreEqual(2215080, fst(Day2.day21))