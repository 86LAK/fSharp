module Gigasecond
open System

let add (beginDate: DateTime) = 
    beginDate.AddSeconds(double 1000000000)

  
