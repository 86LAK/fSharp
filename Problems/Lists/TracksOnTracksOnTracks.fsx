module TracksOnTracksOnTracks

let newList: string list = []

let existingList: string list = ["F#"; "Clojure"; "Haskell"]

let addLanguage (language: string) (languages: string list): string list = 
    let result = language :: languages
    result
    

let countLanguages (languages: string list): int = 
  languages.Length

let reverseList(languages: string list): string list = 
  List.fold(fun acc x -> x :: acc) [] languages

let excitingList (languages: string list): bool = 
  match languages with
  | [] -> false
  | "F#" :: _ -> true
  | [_; "F#"] -> true
  | [_; "F#"; _] -> true
  | _ -> false
