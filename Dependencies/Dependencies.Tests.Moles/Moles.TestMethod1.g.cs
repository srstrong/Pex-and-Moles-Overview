// <copyright file="Moles.TestMethod1.g.cs">Copyright �  2011</copyright>
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
using Microsoft.Pex.Framework;
using Dependencies;

namespace Dependencies.Tests.Moles
{
    public partial class Moles
    {
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
public void TestMethod1398()
{
    this.TestMethod1(0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
public void TestMethod139801()
{
    IPexChoiceRecorder choices = PexChoose.Replay.Setup();
    choices.DefaultSession
        .At(1, "points", (object)1000);
    this.TestMethod1(0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
public void TestMethod139802()
{
    IPexChoiceRecorder choices = PexChoose.Replay.Setup();
    choices.DefaultSession
        .At(0, "level", (object)(Level.Silver));
    this.TestMethod1(0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
public void TestMethod139803()
{
    IPexChoiceRecorder choices = PexChoose.Replay.Setup();
    choices.DefaultSession
        .At(1, "points", (object)1001);
    this.TestMethod1(0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
public void TestMethod139804()
{
    IPexChoiceRecorder choices = PexChoose.Replay.Setup();
    choices.DefaultSession
        .At(0, "level", (object)(Level.Bronze));
    this.TestMethod1(0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::Dependencies.Tests.Moles.Moles))]
[PexRaisedException(typeof(InvalidOperationException))]
public void TestMethod1ThrowsInvalidOperationException532()
{
    IPexChoiceRecorder choices = PexChoose.Replay.Setup();
    choices.DefaultSession
        .At(0, "level", (object)((Level)3));
    this.TestMethod1(0);
}
    }
}
