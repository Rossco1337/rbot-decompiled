// Decompiled with JetBrains decompiler
// Type: Evaluation
// Assembly: bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2C92CEF-E226-4220-B754-98A291323477

using System;

internal class Evaluation : Attribute
{
  internal readonly string Warning;

  internal Evaluation(string string_0)
  {
    this.Warning = string_0;
  }
}
