namespace Tests

open GrowthRate
open NUnit.Framework

[<GrowthRateTest>]
type GrowthRateTest() =
    
    [<Test>]
    member _GrowthRate.getGrowthRate() = 
        Assert.AreEqual(2.5, Utils.round (getGrowthRate 5062.5 1.62))
        Assert.AreEqual(0.0, Utils.round (getGrowthRate 0.0 1.62))
        Assert.AreEqual(0.0, Utils.round (getGrowthRate 1.0 1.62))
        Assert.AreEqual(0.0, Utils.round (getGrowthRate -1.0 1.62))
        Assert.AreEqual(-2.5, Utils.round (getGrowthRate -5062.5 1.62))
        