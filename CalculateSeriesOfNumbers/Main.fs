module main
open System
open System.Collections.Generic

[<Literal>]
let numericValueNotification = "Only numeric values are accepted!\n"

[<Literal>]
let zeroValueNoticifaction = "Zero is not allowed!\n"

[<Literal>]
let lengthNoticifaction = "Length have to be more or equal to 3\n"

[<EntryPoint>]
let main argv =
 
    // user inputs
    Console.Write("Insert X parameter: ")
    let mutable inputX = Console.ReadLine();

    while true <> (System.Double.TryParse inputX |> fst)
        do
        Console.Write(numericValueNotification)
        inputX <- Console.ReadLine()

    let xParam = double inputX

    Console.Write("Insert Y parameter: ")
    let mutable inputY = Console.ReadLine();

    while true <> ((System.Double.TryParse inputY |> fst))
        do
        Console.Write(numericValueNotification)
        inputY <- Console.ReadLine()

    let yParam = double inputY

    Console.Write("Insert series length: ")
    let mutable length = Console.ReadLine();

    while (true <> ((System.Int32.TryParse length |> fst)) || Utils.checkLength length )
        do
        if Utils.checkLength length then 
            Console.Write(lengthNoticifaction)
        else
            Console.Write(numericValueNotification)
        length <- Console.ReadLine()

    let lengthParam = int length

    let firstNumber = FirstNumber.getFirstNumber xParam
    let growthRate = GrowthRate.getGrowthRate yParam firstNumber
    printfn "\nFirst number =  %g" firstNumber
    printfn "Growth rate = %g\n" growthRate

    // show unmodified list of values 
    let resultDefaultList = new List<double>()
    Console.WriteLine("Default numbers\n")
    resultDefaultList.Add(firstNumber)
    for i = 1 to lengthParam - 1 do
        resultDefaultList.Add(Result.overall growthRate firstNumber i)    

    resultDefaultList.Sort()
    let sortedWithoutDuplicatesDefaultList = List.ofSeq (set resultDefaultList)
    sortedWithoutDuplicatesDefaultList |> Seq.iteri (fun index item -> printfn "%f" sortedWithoutDuplicatesDefaultList.[index])

    // show rounded list of values
    let resultRoundedList = new List<double>()
    Console.WriteLine("\nRounded numbers\n")
    resultRoundedList.Add(Utils.round firstNumber);
    for i = 1 to lengthParam - 1 do
        resultRoundedList.Add(Utils.round(Result.overall growthRate firstNumber i))

    resultRoundedList.Sort()
    let sortedWithoutDuplicatesRoundedList = List.ofSeq (set resultRoundedList)
    sortedWithoutDuplicatesRoundedList |> Seq.iteri (fun index item -> printfn "%g" sortedWithoutDuplicatesRoundedList.[index])
  
    // show special number
    let specialNumber = sortedWithoutDuplicatesRoundedList.[(sortedWithoutDuplicatesRoundedList.Length - 3)] 
    printf "\nSpecial number = %g\n" specialNumber
    
    // approximate number
    Console.Write("Insert parameter Z: ")
    let mutable inputZ = Console.ReadLine()

    while (true <> ((System.Double.TryParse inputZ |> fst)) || Utils.isZero inputZ)
        do
        if Utils.isZero inputZ then 
            Console.Write(zeroValueNoticifaction)
        else
            Console.Write(numericValueNotification)
        inputZ <- Console.ReadLine()

    let zParam = double inputZ

    let approximateNumber = ApproximateNumber.approximateNumber zParam

    printf "\nApproximate number = %g which makes %g special.\n" approximateNumber (Utils.nearestNumericValue approximateNumber sortedWithoutDuplicatesRoundedList) 

    0