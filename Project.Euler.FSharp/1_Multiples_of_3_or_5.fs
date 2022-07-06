module Project.Euler.FSharp.Problem1

//"Natural numbers": Natural numbers are all positive numbers like 1, 2, 3, 4, and so on.
//Boundaries: "below 10" so up to 9
//Each result number is unique, even if matching multiple values
//return the sum of the unique matches

//1: generate the list of all numbers up to exclusiveMax (the "candidates")
//2a: iterate on each candidate and test if it is divisible by one of the multiples
//2b: keep the successful candidates
//3: sum the successful candidates

let private isDivisibleBy multiples x =
    let isDivisible divisor = x % divisor = 0
    List.tryFind isDivisible multiples
    |> Option.isSome

let sumOfMultiples inclusiveMax multiples =
    seq { 0..(inclusiveMax-1) }
    |> Seq.filter (isDivisibleBy multiples)
    |> Seq.sum

