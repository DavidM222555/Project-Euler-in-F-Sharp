// Pretty generic solution here that can probably be sped up (even though it currently runs pretty fast on the given data)
// A quick fix would probably be to use an analytic solution that takes advantage of the fact we have formulas for all of these we can use 
// or derive very easily

[<EntryPoint>]
let main args =
    let upperBound = args[0] |> int

    let sumOfSquares = seq {for i in 1..upperBound do i*i}
                        |> Seq.sum

    let sumOfNumsToUpperbound = [for i in 1..upperBound do i]
                                |> List.sum

    let sumSquared = sumOfNumsToUpperbound*sumOfNumsToUpperbound

    let answer = sumSquared - sumOfSquares

    printfn "Sum of squares %d ... sum of numbers squared %d" sumSquared sumOfNumsToUpperbound

    printfn "The difference of the sum of squares up to %d and the square of the sum up to %d is %d" upperBound upperBound answer

    0
