using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            if (!Enum.IsDefined(typeof(SwallowType), swallowType))
                throw new ArgumentOutOfRangeException(nameof(swallowType), "Invalid swallow type entered.");

            Type = swallowType;
            Load = SwallowLoad.None;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            if (!Enum.IsDefined(typeof(SwallowLoad), load))
                throw new ArgumentOutOfRangeException(nameof(load), "Invalid load type entered.");

            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            return (Type, Load) switch
            {
                (SwallowType.African, SwallowLoad.None) => 22.0,
                (SwallowType.African, SwallowLoad.Coconut) => 18.0,
                (SwallowType.European, SwallowLoad.None) => 20.0,
                (SwallowType.European, SwallowLoad.Coconut) => 16.0,
                _ => throw new InvalidOperationException("Invalid type or load for swallow."),
            };
        }
    }
}
