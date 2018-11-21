// Decompiled with JetBrains decompiler
// Type: Evaluation
// Assembly: controller, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2ED39F30-612C-4FE2-B672-F5F6629F389A
// Assembly location: /home/ross/bot_deob/controller-cleaned.exe

using System;

internal class Evaluation : Attribute
{
  internal readonly string Warning;

  internal Evaluation(string string_0)
  {
    this.Warning = string_0;
  }
}
