using NUnit.Framework;
using classes.CeaserCypher;

namespace tests;

public class CeaserCypherTests
{
    [SetUp]
    public void Setup()
    { 
    }

    [Test]
    public void TestEncrypt()
    {
        Assert.IsTrue(CeaserCypher.encrypt("abc", 'a').Equals("bcd"));
        Assert.IsTrue(CeaserCypher.encrypt("xyz", 'c').Equals("abc"));
        Assert.IsTrue(CeaserCypher.encrypt("ABC", 'A').Equals("BCD"));
        Assert.IsTrue(CeaserCypher.encrypt("XYZ", 'C').Equals("ABC"));
        Assert.IsTrue(CeaserCypher.encrypt("XYZ!!!", 'C').Equals("ABC!!!"));
        Assert.IsTrue(CeaserCypher.encrypt("XyZ@", 'c').Equals("AbC@"));
    }

    [Test]
    public void TestDecrypt()
    {
        Assert.IsTrue(CeaserCypher.decrypt("bcd", 'a').Equals("abc"));
        Assert.IsTrue(CeaserCypher.decrypt("abc", 'c').Equals("xyz"));
        Assert.IsTrue(CeaserCypher.decrypt("ABC!!!", 'C').Equals("XYZ!!!"));
    }
}