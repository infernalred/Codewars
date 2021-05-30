using System;
using Human_Readable_Time;
using NUnit.Framework;

[TestFixture]
public class HumanReadableTimeTest
{
    [Test]
    public void HumanReadableTest()
    {
        Assert.AreEqual("01:02:01", TimeFormat.GetReadableTime(3721));
        Assert.AreEqual("00:02:01", TimeFormat.GetReadableTime(121));
        Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
        Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
        Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
        Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
        Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
    }
}