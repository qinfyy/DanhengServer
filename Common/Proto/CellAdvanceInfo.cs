// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CellAdvanceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CellAdvanceInfo.proto</summary>
  public static partial class CellAdvanceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CellAdvanceInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CellAdvanceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDZWxsQWR2YW5jZUluZm8ucHJvdG8aG0NlbGxNb25zdGVyU2VsZWN0SW5m",
            "by5wcm90bxoVQ2VsbE1vbnN0ZXJJbmZvLnByb3RvGhFIS0pJRENHTUtPRy5w",
            "cm90byKLAQoPQ2VsbEFkdmFuY2VJbmZvEiMKCWJvc3NfaW5mbxgJIAEoCzIQ",
            "LkNlbGxNb25zdGVySW5mbxIwChBzZWxlY3RfYm9zc19pbmZvGAIgASgLMhYu",
            "Q2VsbE1vbnN0ZXJTZWxlY3RJbmZvEiEKC0VGSkhJSUxFQ0dBGAsgASgLMgwu",
            "SEtKSURDR01LT0dCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellMonsterSelectInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.CellMonsterInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.HKJIDCGMKOGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CellAdvanceInfo), global::EggLink.DanhengServer.Proto.CellAdvanceInfo.Parser, new[]{ "BossInfo", "SelectBossInfo", "EFJHIILECGA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CellAdvanceInfo : pb::IMessage<CellAdvanceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CellAdvanceInfo> _parser = new pb::MessageParser<CellAdvanceInfo>(() => new CellAdvanceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CellAdvanceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CellAdvanceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellAdvanceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellAdvanceInfo(CellAdvanceInfo other) : this() {
      bossInfo_ = other.bossInfo_ != null ? other.bossInfo_.Clone() : null;
      selectBossInfo_ = other.selectBossInfo_ != null ? other.selectBossInfo_.Clone() : null;
      eFJHIILECGA_ = other.eFJHIILECGA_ != null ? other.eFJHIILECGA_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellAdvanceInfo Clone() {
      return new CellAdvanceInfo(this);
    }

    /// <summary>Field number for the "boss_info" field.</summary>
    public const int BossInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.CellMonsterInfo bossInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellMonsterInfo BossInfo {
      get { return bossInfo_; }
      set {
        bossInfo_ = value;
      }
    }

    /// <summary>Field number for the "select_boss_info" field.</summary>
    public const int SelectBossInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo selectBossInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo SelectBossInfo {
      get { return selectBossInfo_; }
      set {
        selectBossInfo_ = value;
      }
    }

    /// <summary>Field number for the "EFJHIILECGA" field.</summary>
    public const int EFJHIILECGAFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.HKJIDCGMKOG eFJHIILECGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKJIDCGMKOG EFJHIILECGA {
      get { return eFJHIILECGA_; }
      set {
        eFJHIILECGA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CellAdvanceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CellAdvanceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BossInfo, other.BossInfo)) return false;
      if (!object.Equals(SelectBossInfo, other.SelectBossInfo)) return false;
      if (!object.Equals(EFJHIILECGA, other.EFJHIILECGA)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (bossInfo_ != null) hash ^= BossInfo.GetHashCode();
      if (selectBossInfo_ != null) hash ^= SelectBossInfo.GetHashCode();
      if (eFJHIILECGA_ != null) hash ^= EFJHIILECGA.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (selectBossInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SelectBossInfo);
      }
      if (bossInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BossInfo);
      }
      if (eFJHIILECGA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EFJHIILECGA);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (selectBossInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SelectBossInfo);
      }
      if (bossInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BossInfo);
      }
      if (eFJHIILECGA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EFJHIILECGA);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (bossInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BossInfo);
      }
      if (selectBossInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SelectBossInfo);
      }
      if (eFJHIILECGA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFJHIILECGA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CellAdvanceInfo other) {
      if (other == null) {
        return;
      }
      if (other.bossInfo_ != null) {
        if (bossInfo_ == null) {
          BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
        }
        BossInfo.MergeFrom(other.BossInfo);
      }
      if (other.selectBossInfo_ != null) {
        if (selectBossInfo_ == null) {
          SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
        }
        SelectBossInfo.MergeFrom(other.SelectBossInfo);
      }
      if (other.eFJHIILECGA_ != null) {
        if (eFJHIILECGA_ == null) {
          EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
        }
        EFJHIILECGA.MergeFrom(other.EFJHIILECGA);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (selectBossInfo_ == null) {
              SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
            }
            input.ReadMessage(SelectBossInfo);
            break;
          }
          case 74: {
            if (bossInfo_ == null) {
              BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
            }
            input.ReadMessage(BossInfo);
            break;
          }
          case 90: {
            if (eFJHIILECGA_ == null) {
              EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
            }
            input.ReadMessage(EFJHIILECGA);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (selectBossInfo_ == null) {
              SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
            }
            input.ReadMessage(SelectBossInfo);
            break;
          }
          case 74: {
            if (bossInfo_ == null) {
              BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
            }
            input.ReadMessage(BossInfo);
            break;
          }
          case 90: {
            if (eFJHIILECGA_ == null) {
              EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
            }
            input.ReadMessage(EFJHIILECGA);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
