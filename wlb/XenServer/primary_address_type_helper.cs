﻿// Decompiled with JetBrains decompiler
// Type: XenAPI.primary_address_type_helper
// Assembly: XenServer, Version=6.1.0.1, Culture=neutral, PublicKeyToken=102be611e60e8ddc
// MVID: 11619AB1-8160-47E5-8915-DFF772C11F71
// Assembly location: C:\Users\ShawnWang\Desktop\wlb\XenServer.dll

namespace XenAPI
{
  public static class primary_address_type_helper
  {
    public static string ToString(primary_address_type x)
    {
      switch (x)
      {
        case primary_address_type.IPv4:
          return "IPv4";
        case primary_address_type.IPv6:
          return "IPv6";
        default:
          return "unknown";
      }
    }
  }
}