module FirstNumber

// param related to multiply function
[<Literal>]
let private multiplicationParamX = 0.5
[<Literal>]
let private exponent = 2
// param related to makeSum function
[<Literal>]
let private multiplicationParamY = 30.0
[<Literal>]
let private additionParamX = 10.0
// param related to getFirstNumber function
[<Literal>]
let private denominator =  25.0


let private multiply xParam
    = multiplicationParamX * (pown xParam exponent)

let private makeSum xParam
    = multiplicationParamY * xParam + additionParamX

let getFirstNumber xParam
    = (multiply xParam + makeSum xParam) / denominator