module GrowthRate

[<Literal>]
let private percentage = 0.02
[<Literal>]
let private divider = 25.0

let private getPercent yParam
    = percentage * yParam

let private devide yParam
    = getPercent yParam / divider

let getGrowthRate yParam firstNumber
    = (devide yParam) / firstNumber



