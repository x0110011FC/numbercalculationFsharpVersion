namespace Tests

open Utils
open NUnit.Framework

[<UtilsTest>]
type UtilsTest() =

    let valueList = [1.5; 4.0; 6.5; 10.75; 17.25]
    
    [<Test>]
    member _Utils.round() = 
        Assert.AreEqual(0, round 0.0)
        Assert.AreEqual(1, round 1.0)
        Assert.AreEqual(10.75, round 10.63)
        Assert.AreEqual(12, round 12.12)
    
    [<Test>]
    member _Utils.nearestNumericValue() =
        Assert.AreEqual(1.5, nearestNumericValue 0.0 valueList)
        Assert.AreEqual(1.5, nearestNumericValue 2.3 valueList)
        Assert.AreEqual(10.75, nearestNumericValue 10.63 valueList)
        Assert.AreEqual(17.25, nearestNumericValue 100.0 valueList)

    [<Test>]
    member _Utils.isZero() = 
        Assert.AreEqual(true, isZero "0")
        Assert.AreEqual(true, isZero "0.0")
        Assert.AreEqual(true, isZero "0,0")
        Assert.AreEqual(false, isZero "12")

    [<Test>]
    member _Utils.checkLength() = 
        Assert.AreEqual(true, checkLength "0")
        Assert.AreEqual(false, checkLength "3")
        Assert.AreEqual(true, checkLength "-1")