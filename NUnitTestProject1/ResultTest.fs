namespace Tests

open Result
open NUnit.Framework

[<ResultTest>]
type ResultTest() =
    
    [<Test>]
    member _Result.overall() = 
        Assert.AreEqual(4.0500000000000007, overall 2.5 1.62 1)
        Assert.AreEqual(6.561000000000002, overall 2.5 1.62 2)
        Assert.AreEqual(0.0, overall 0.0 0.0 1)
        Assert.AreEqual(0.0, overall 0.0 0.0 2)
        Assert.AreEqual(0.0, overall 0.0 -1.0 1)
        Assert.AreEqual(0.0, overall 0.0 -1.0 2)
        