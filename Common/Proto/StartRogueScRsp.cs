// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartRogueScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartRogueScRsp.proto</summary>
  public static partial class StartRogueScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartRogueScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRogueScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTdGFydFJvZ3VlU2NSc3AucHJvdG8aD1JvZ3VlSW5mby5wcm90bxoPU2Nl",
            "bmVJbmZvLnByb3RvGhFBTEpPQU1NS09NTy5wcm90bxoQTGluZXVwSW5mby5w",
            "cm90byKdAQoPU3RhcnRSb2d1ZVNjUnNwEiEKC0xDQUFOTUpLQk1KGA8gASgL",
            "MgwuQUxKT0FNTUtPTU8SGwoGbGluZXVwGAcgASgLMgsuTGluZXVwSW5mbxIP",
            "CgdyZXRjb2RlGAogASgNEh4KCnJvZ3VlX2luZm8YCyABKAsyCi5Sb2d1ZUlu",
            "Zm8SGQoFc2NlbmUYBiABKAsyCi5TY2VuZUluZm9CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ALJOAMMKOMOReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartRogueScRsp), global::EggLink.DanhengServer.Proto.StartRogueScRsp.Parser, new[]{ "LCAANMJKBMJ", "Lineup", "Retcode", "RogueInfo", "Scene" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartRogueScRsp : pb::IMessage<StartRogueScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartRogueScRsp> _parser = new pb::MessageParser<StartRogueScRsp>(() => new StartRogueScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartRogueScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartRogueScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueScRsp(StartRogueScRsp other) : this() {
      lCAANMJKBMJ_ = other.lCAANMJKBMJ_ != null ? other.lCAANMJKBMJ_.Clone() : null;
      lineup_ = other.lineup_ != null ? other.lineup_.Clone() : null;
      retcode_ = other.retcode_;
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueScRsp Clone() {
      return new StartRogueScRsp(this);
    }

    /// <summary>Field number for the "LCAANMJKBMJ" field.</summary>
    public const int LCAANMJKBMJFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ALJOAMMKOMO lCAANMJKBMJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ALJOAMMKOMO LCAANMJKBMJ {
      get { return lCAANMJKBMJ_; }
      set {
        lCAANMJKBMJ_ = value;
      }
    }

    /// <summary>Field number for the "lineup" field.</summary>
    public const int LineupFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.LineupInfo lineup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo Lineup {
      get { return lineup_; }
      set {
        lineup_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.SceneInfo scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneInfo Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartRogueScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartRogueScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LCAANMJKBMJ, other.LCAANMJKBMJ)) return false;
      if (!object.Equals(Lineup, other.Lineup)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(Scene, other.Scene)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lCAANMJKBMJ_ != null) hash ^= LCAANMJKBMJ.GetHashCode();
      if (lineup_ != null) hash ^= Lineup.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (scene_ != null) hash ^= Scene.GetHashCode();
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
      if (scene_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Scene);
      }
      if (lineup_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Lineup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueInfo);
      }
      if (lCAANMJKBMJ_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(LCAANMJKBMJ);
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
      if (scene_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Scene);
      }
      if (lineup_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Lineup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueInfo);
      }
      if (lCAANMJKBMJ_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(LCAANMJKBMJ);
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
      if (lCAANMJKBMJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LCAANMJKBMJ);
      }
      if (lineup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lineup);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartRogueScRsp other) {
      if (other == null) {
        return;
      }
      if (other.lCAANMJKBMJ_ != null) {
        if (lCAANMJKBMJ_ == null) {
          LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
        }
        LCAANMJKBMJ.MergeFrom(other.LCAANMJKBMJ);
      }
      if (other.lineup_ != null) {
        if (lineup_ == null) {
          Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        Lineup.MergeFrom(other.Lineup);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
        }
        Scene.MergeFrom(other.Scene);
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
          case 50: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 58: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 122: {
            if (lCAANMJKBMJ_ == null) {
              LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
            }
            input.ReadMessage(LCAANMJKBMJ);
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
          case 50: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 58: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 122: {
            if (lCAANMJKBMJ_ == null) {
              LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
            }
            input.ReadMessage(LCAANMJKBMJ);
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
