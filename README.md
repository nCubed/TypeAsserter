TypeAsserter
============

A micro-framework for unit testing class and type declarations.

###Why?

TDD traditionally tests code functionality. But what about expected types? For example, often times an API is exposed through public interfaces while hiding the implementation with an internal class. `TypeAsserter` allows you to easily create tests for the expected types of your classes to help protect against modifying the type in unexpected ways.

###Usage

Simply add `TypeAsserter` to your Unit Test project through the Visual Studio Nuget Package Manager and import the `TypeAsserter` namespace. Alternatively, clone the GitHub repository. Once the `TypeAsserter` assembly is added to your Unit Test project, you can then use the available static methods from the `AssertClass<T>` class.

###Examples

Let's say you have an internal class named `MyFoo` that is sealed and implements the `IFoo` interface:

```csharp
// example class with interface
internal sealed class MyFoo : IFoo { }

// Unit Tests verifying the MyFoo type
[TestClass]
public class MyTests
{
    [TestMethod]
    public void MyFoo_TypeDeclarations()
    {
        AssertClass<MyFoo>.IsInternal();
        AssertClass<MyFoo>.IsSealed();
        AssertClass<MyFoo>.ImplementsInterface<IFoo>();
    }
    
    [TestMethod]
    [ExpectedException( typeof( AssertFailedException ) )]
    public void MyFoo_IsStatic_Fails()
    {
        // Here we are ensuring MyFoo is not static
        AssertClass.IsStatic( typeof( MyFoo ), ClassVisibility.Internal );
    }
}

```

###Methods

The method names should be self-explanatory. The following is a partial list of available methods that are most commonly used:

```csharp
AssertClass<T>.IsInternal();
AssertClass<T>.IsPublic();
AssertClass<T>.IsAbstract();
AssertClass<T>.IsNotAbstract();
AssertClass<T>.IsSealed();
AssertClass<T>.IsNotSealed();
AssertClass<T>.InheritsBaseClass<TBaseClass>();
AssertClass<T>.InheritsAbstractBaseClass<TAbstractClass>();
AssertClass<T>.ImplementsInterface<TInterface>();

// static classes cannot be used as generic constraints so you must pass in the
// type to the IsStatic method, i.e., typeof( MyFoo )
AssertClass.IsStatic( Type type, ClassVisibility visibility );
```
