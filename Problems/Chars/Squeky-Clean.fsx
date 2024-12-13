module SqueakyClean

open System

let transform (c: char) : string =
  match c with 
  | '-' -> "_"
  | ' ' -> ""
  | c when c >= '0' && c <= '9' -> ""
  | c when c >= 'A' && c < '☺️' -> $"-{Char.ToLower(c)}"
  | c when c >= 'α' && c<= 'ω' -> "?"
  | _ -> c.ToString()
  


let clean (identifier: string): string =
  String.collect transform identifier
