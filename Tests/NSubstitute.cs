using System;
using NUnit.Framework;
using NSubstitute;

namespace Tests
{
    [TestFixture]
    public class NSubstitute
    {
        [Test]
        public void CanMock ()
        {
            var mock = Substitute.For<ICanDoThat> ();
            mock.DoThat ();

            mock.Received ().DoThat ();
        }

        [Test]
        public void CanStub()
        {
            var mock = Substitute.For<ICanProvideAValue> ();
            mock.GetValue ().Returns (42);

            Assert.That (mock.GetValue (), Is.EqualTo (42));
        }
    }

    public interface ICanDoThat
    {
        void DoThat ();
    }
    public interface ICanProvideAValue
    {
        object GetValue ();
    }
}

