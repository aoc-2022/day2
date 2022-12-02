open System.IO
let lines = File.ReadAllLines "/tmp/aoc/input" |> Array.toList

type Round(hand1: string, hand2:string) =
    member this.Hand1 = hand1 
    member this.Hand2 = hand2
    
    member this.Score1 =
        match (this.Hand1, this.Hand2) with
        | ("A","X") -> 4
        | ("A","Y") -> 1
        | ("A","Z") -> 7
        | ("B","X") -> 8
        | ("B","Y") -> 5
        | ("B","Z") -> 2
        | ("C","X") -> 3
        | ("C","Y") -> 9
        | ("C","Z") -> 6
        | _ -> -900000
        
    member this.Score2 =
        match (this.Hand1, this.Hand2) with
        | ("A","X") -> 4
        | ("A","Y") -> 8
        | ("A","Z") -> 3
        | ("B","X") -> 1
        | ("B","Y") -> 5
        | ("B","Z") -> 9
        | ("C","X") -> 7
        | ("C","Y") -> 2
        | ("C","Z") -> 6
        | _ -> -900000

    member this.Score2Task2 =
        match (this.Hand1, this.Hand2) with
        | ("A","X") -> 3    //X loose Y dra Z win
        | ("A","Y") -> 4
        | ("A","Z") -> 8
        | ("B","X") -> 1
        | ("B","Y") -> 5
        | ("B","Z") -> 9
        | ("C","X") -> 2
        | ("C","Y") -> 6
        | ("C","Z") -> 7
        | _ -> -900000
 
    override this.ToString () =
        $"({hand1} {hand2})"

    
let parse (s:string) =
    let s = s.Split(' ')
    Round(s[0],s[1])

let rounds = lines |> List.map parse

let scores1 = rounds |> List.map (fun r -> r.Score1)
let scores2 = rounds |> List.map (fun r -> r.Score2)
let scores2task2 = rounds |> List.map (fun r -> r.Score2Task2)

printfn $"{scores2}"
printfn $"{scores2 |> List.sum}"

printfn $"{scores2task2}"
printfn $"{scores2task2 |> List.sum}"