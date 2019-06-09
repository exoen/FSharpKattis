open System
open System.IO

let readLines () = seq {
    use sr = new StreamReader (Console.OpenStandardInput())
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let AbsoluteDifference x y = abs (x - y)

[<EntryPoint>]
    let main argv =
        let lines = readLines();
        for line in lines do
            let splittedLine = line.Split(' ');
            printfn "%d" (AbsoluteDifference (splittedLine.[0] |> int64) (splittedLine.[1] |> int64))
        0