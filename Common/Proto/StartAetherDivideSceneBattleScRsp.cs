// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartAetherDivideSceneBattleScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartAetherDivideSceneBattleScRsp.proto</summary>
  public static partial class StartAetherDivideSceneBattleScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartAetherDivideSceneBattleScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartAetherDivideSceneBattleScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlU2NSc3AucHJvdG8aHEFl",
            "dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iegohU3RhcnRBZXRoZXJEaXZp",
            "ZGVTY2VuZUJhdHRsZVNjUnNwEiwKC2JhdHRsZV9pbmZvGAggASgLMhcuQWV0",
            "aGVyRGl2aWRlQmF0dGxlSW5mbxIWCg5jYXN0X2VudGl0eV9pZBgDIAEoDRIP",
            "CgdyZXRjb2RlGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherDivideBattleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleScRsp), global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleScRsp.Parser, new[]{ "BattleInfo", "CastEntityId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartAetherDivideSceneBattleScRsp : pb::IMessage<StartAetherDivideSceneBattleScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartAetherDivideSceneBattleScRsp> _parser = new pb::MessageParser<StartAetherDivideSceneBattleScRsp>(() => new StartAetherDivideSceneBattleScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartAetherDivideSceneBattleScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleScRsp(StartAetherDivideSceneBattleScRsp other) : this() {
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      castEntityId_ = other.castEntityId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleScRsp Clone() {
      return new StartAetherDivideSceneBattleScRsp(this);
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    /// <summary>Field number for the "cast_entity_id" field.</summary>
    public const int CastEntityIdFieldNumber = 3;
    private uint castEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CastEntityId {
      get { return castEntityId_; }
      set {
        castEntityId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartAetherDivideSceneBattleScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartAetherDivideSceneBattleScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if (CastEntityId != other.CastEntityId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      if (CastEntityId != 0) hash ^= CastEntityId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (CastEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CastEntityId);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (CastEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CastEntityId);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BattleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
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
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (CastEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CastEntityId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartAetherDivideSceneBattleScRsp other) {
      if (other == null) {
        return;
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
      }
      if (other.CastEntityId != 0) {
        CastEntityId = other.CastEntityId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 24: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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
          case 24: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (battleInfo_ == null) {
              BattleInfo = new global::EggLink.DanhengServer.Proto.AetherDivideBattleInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
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