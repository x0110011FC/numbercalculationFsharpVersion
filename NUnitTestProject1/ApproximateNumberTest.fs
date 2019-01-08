namespace Tests

open NUnit.Framework
open ApproximateNumber

[<ApproximateNumberTest>]
type ApproximateNumberTest () =

    [<Test>]
    member _ApproximateNumber.approximateNumber()
        = Assert.AreEqual(500, approximateNumber 2.0)
          Assert.AreEqual(1000, approximateNumber 1.0)
          Assert.AreEqual(-1000, approximateNumber -1.0)
          Assert.AreEqual(1, approximateNumber 1000.0)

  
