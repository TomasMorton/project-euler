module Tests

open FsUnit.Xunit
open Xunit
open Project.Euler.FSharp.Problem1

[<Fact>]
let ``Should find the sum of all the multiples of 3 or 5 below 1000`` () =
    sumOfMultiples 1000 [3; 5]
    |> should equal 233168