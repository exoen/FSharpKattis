open System
open System.IO

let readLines () = seq {
    use sr = new StreamReader (Console.OpenStandardInput())
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

[<EntryPoint>]
    let main argv =
        let lines = readLines();
        for _ in lines do
            Console.WriteLine(0);
        0