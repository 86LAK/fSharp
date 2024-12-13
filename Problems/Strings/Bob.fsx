module Bob

open System

let response (statement: string): string =
    let trimmedStatement = statement.Trim()
    
    let isQuestion = trimmedStatement.EndsWith("?")
    let isYelling = trimmedStatement <> trimmedStatement.ToLower() && trimmedStatement = trimmedStatement.ToUpper()
    let isSilence = String.IsNullOrWhiteSpace(trimmedStatement)
    
    match (isQuestion, isYelling, isSilence) with
    | (true, true, _) -> "Calm down, I know what I'm doing!"
    | (true, false, _) -> "Sure."
    | (false, true, _) -> "Whoa, chill out!"
    | (_, _, true) -> "Fine. Be that way!"
    | _ -> "Whatever."
