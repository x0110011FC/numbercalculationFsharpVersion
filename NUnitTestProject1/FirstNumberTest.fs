namespace Tests

open FirstNumber
open NUnit.Framework

[<FirstNumberTest>]
type FirstNumberTest() =
    
    [<Test>]
    member _FirstNumber.getFirstNumber() = 
        Assert.AreEqual(1.62, getFirstNumber 1.0)
        Assert.AreEqual(-0.78, getFirstNumber -1.0)
        Assert.AreEqual(-9.775032000000001, getFirstNumber -10.22)
        Assert.AreEqual(14.946312, getFirstNumber 10.34)
        Assert.AreEqual(0.4, getFirstNumber 0.0)
        