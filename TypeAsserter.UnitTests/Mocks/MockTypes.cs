namespace TypeAsserter.UnitTests.Mocks
{
    public interface IPublicInterface { }

    internal interface IInternalInterface { }

    public interface INotImplementedInterface { }

    public class PublicClass : IPublicInterface { }

    public abstract class PublicAbstractClass { }

    public sealed class PublicSealedClass : IPublicInterface { }

    public class PublicClassWithBaseClass : PublicClass { }

    public class PublicClassWithAbstrctBaseClass : PublicAbstractClass { }

    internal class InternalClass : IInternalInterface { }

    public static class PublicStaticClass { }

    internal static class InternalStaticClass { }
}