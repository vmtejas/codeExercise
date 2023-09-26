using System;
using Xunit;

namespace DeveloperSample.ClassRefactoring
{
    public class ClassRefactorTest
    {
        [Fact]
        public void AfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);
            Assert.Equal(22, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenAfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            Assert.Equal(18, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void EuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);
            Assert.Equal(20, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenEuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            Assert.Equal(16, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void ThrowExceptionForInvalidSwallowType()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Swallow((SwallowType)999));
        }

        [Fact]
        public void ThrowExceptionForInvalidLoadType()
        {
            var swallow = new Swallow(SwallowType.African);
            Assert.Throws<ArgumentOutOfRangeException>(() => swallow.ApplyLoad((SwallowLoad)999));
        }

        [Fact]
        public void ResettingSwallowLoadToNone()
        {
            var swallow = new Swallow(SwallowType.European);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            swallow.ApplyLoad(SwallowLoad.None);
            Assert.Equal(20, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void ApplyingLoadToAlreadyLoadedSwallow()
        {
            var swallow = new Swallow(SwallowType.African);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            Assert.Equal(18, swallow.GetAirspeedVelocity());
        }
    }
}