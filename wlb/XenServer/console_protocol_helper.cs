﻿// Decompiled with JetBrains decompiler
// Type: XenAPI.console_protocol_helper
// Assembly: XenServer, Version=6.1.0.1, Culture=neutral, PublicKeyToken=102be611e60e8ddc
// MVID: 11619AB1-8160-47E5-8915-DFF772C11F71
// Assembly location: C:\Users\ShawnWang\Desktop\wlb\XenServer.dll

namespace XenAPI
{
  public static class console_protocol_helper
  {
    public static string ToString(console_protocol x)
    {
      switch (x)
      {
        case console_protocol.vt100:
          return "vt100";
        case console_protocol.rfb:
          return "rfb";
        case console_protocol.rdp:
          return "rdp";
        default:
          return "unknown";
      }
    }
  }
}
