
[<EntryPoint>]
    let main argv =
        let divideByZero = 1 / 0;
        printfn "%d" divideByZero
        0