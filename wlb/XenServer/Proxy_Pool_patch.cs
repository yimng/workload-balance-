﻿// Decompiled with JetBrains decompiler
// Type: XenAPI.Proxy_Pool_patch
// Assembly: XenServer, Version=6.1.0.1, Culture=neutral, PublicKeyToken=102be611e60e8ddc
// MVID: 11619AB1-8160-47E5-8915-DFF772C11F71
// Assembly location: C:\Users\ShawnWang\Desktop\wlb\XenServer.dll

using CookComputing.XmlRpc;

namespace XenAPI
{
  [XmlRpcMissingMapping(MappingAction.Ignore)]
  public class Proxy_Pool_patch
  {
    public string uuid;
    public string name_label;
    public string name_description;
    public string version;
    public string size;
    public bool pool_applied;
    public string[] host_patches;
    public string[] after_apply_guidance;
    public object other_config;
  }
}
