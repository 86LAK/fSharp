module LogLevels

let message (logLine: string): string = 
    match logLine.IndexOf(':') with
    | -1 -> ""
    | index -> logLine.Substring(index + 1).Trim()

let logLevel(logLine: string): string = 
    let stringLength = logLine.IndexOf("]") - logLine.IndexOf("[")
    let message = logLine.Substring(logLine.IndexOf("[") + 1, stringLength - 1)
    message.ToLower()

let reformat(logLine: string): string = 
    let message = message logLine
    let level = logLevel logLine
    let resultingString = message + " (" + level + ")"
    resultingString
