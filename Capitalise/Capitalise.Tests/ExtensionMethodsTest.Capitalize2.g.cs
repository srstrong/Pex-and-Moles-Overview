// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Capitalise
{
    public partial class ExtensionMethodsTest
    {
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void Capitalize2ThrowsNullReferenceException988()
{
    this.Capitalize2((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2552()
{
    this.Capitalize2("");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2671()
{
    this.Capitalize2("\0");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
[PexRaisedException(typeof(AssertFailedException))]
public void Capitalize2ThrowsAssertFailedException808()
{
    this.Capitalize2(".");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2315()
{
    this.Capitalize2("a");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2201()
{
    this.Capitalize2("aa");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
[PexRaisedException(typeof(AssertFailedException))]
public void Capitalize2ThrowsAssertFailedException956()
{
    this.Capitalize2(".\0");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2644()
{
    this.Capitalize2("..");
}
[TestMethod]
[PexGeneratedBy(typeof(ExtensionMethodsTest))]
public void Capitalize2207()
{
    this.Capitalize2("\0\0");
}
    }
}