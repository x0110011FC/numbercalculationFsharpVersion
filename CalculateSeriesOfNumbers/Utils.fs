module Utils

open System

let round value
    = Math.Round(value * 4.0) / 4.0 

let nearestNumericValue (approximateNumber:double)
    = Seq.minBy (fun n -> abs(n - approximateNumber))

let isZero possibleZeroValue
    = if possibleZeroValue.Equals("0") then
        true
      elif possibleZeroValue.Equals("0.0") then
        true
      elif possibleZeroValue.Equals("0,0") then
        true
      else
        false

let checkLength length
    = if Int32.Parse length < 3 then
            true
        else
            false