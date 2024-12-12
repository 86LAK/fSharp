module ValentinesDay

type Approval = 
  | Yes
  | No 
  | Maybe 

type Cuisine = 
    | Korean
    | Turkish

type Genre = 
    | Crime 
    | Horror
    | Romance
    | Thriller

type Activity = 
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int 

let rateActivity (activity: Activity): Approval = 
    match activity with 
    | BoardGame -> Approval.No
    | Chill -> Approval.No 
    | Restaurant cuisine -> 
        match cuisine with
        | Korean -> Approval.Yes
        | Turkish -> Approval.Maybe
    | Movie genre -> 
        match genre with
        | Romance -> Approval.Yes
        | _ -> Approval.No
    | Walk distance -> 
        if distance < 3 then Approval.Yes
        elif distance >= 5 then Approval.No 
        else Approval.Maybe
