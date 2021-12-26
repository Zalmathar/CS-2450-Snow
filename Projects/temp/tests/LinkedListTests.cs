using NUnit.Framework;
using classes.LinkedList;

namespace tests;

public class LinkedListTests
{
    private LinkedList<string> ll;
    private string[] nl = 
    {
        "John",
        "Paul",
        "Joe",
        "Jack",
        "Nathan",
        "Nathan"
    };

    [SetUp]
    public void Setup()
    {
        ll = new LinkedList<string>();
        foreach (string name in nl)
        {
            ll.Add(name);
        }
    }
    [Test]
    public void testPeek()
    {
        Assert.IsTrue(ll.Peek() == nl[0]);
        Assert.IsTrue(ll.count == 6);
    }

    [Test]
    public void testPeekIndex()
    {
        for (int i = 0; i < ll.count; i++)
        {
            Assert.IsTrue(ll.Peek(i) == nl[i]);
        }
        Assert.IsTrue(ll.count == 6);
    }

    [Test]
    public void testRemove()
    {
        for (int i = 0; i < ll.count; i++)
        {
            Assert.IsTrue(ll.Remove() == nl[i]);
            Assert.IsTrue(ll.count == 5 - i);
        }
        Assert.IsTrue(ll.count == 0);
    }

    [Test]
    public void testRevmoveIndex()
    {
        for (int i = ll.count; i > 0; i--)
        {
            Assert.IsTrue(ll.Remove(i) == nl[i]);
        }
        Assert.IsTrue(ll.count == 0);
    }

    // [Test]
    // public void testIEnumerable()
    // {
    //     int index = 0;
    //     foreach (string name in ll)
    //     {
    //         Assert.IsTrue(name.Equals(nl[index]));
    //         index++;
    //     }
    // }
}