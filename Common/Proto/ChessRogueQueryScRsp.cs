// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQueryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQueryScRsp.proto</summary>
  public static partial class ChessRogueQueryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQueryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQueryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlUXVlcnlTY1JzcC5wcm90bxoaQ2hlc3NSb2d1ZUZpbmlz",
            "aEluZm8ucHJvdG8aGUNoZXNzUm9ndWVRdWVyeUluZm8ucHJvdG8aG0NoZXNz",
            "Um9ndWVDdXJyZW50SW5mby5wcm90bxoXQ2hlc3NSb2d1ZUdldEluZm8ucHJv",
            "dG8aHUNoZXNzUm9ndWVRdWVyeUdhbWVJbmZvLnByb3RvIoICChRDaGVzc1Jv",
            "Z3VlUXVlcnlTY1JzcBIqCgtmaW5pc2hfaW5mbxgBIAEoCzIVLkNoZXNzUm9n",
            "dWVGaW5pc2hJbmZvEiQKBGluZm8YDSABKAsyFi5DaGVzc1JvZ3VlQ3VycmVu",
            "dEluZm8SDwoHcmV0Y29kZRgMIAEoDRIoCgpxdWVyeV9pbmZvGAkgASgLMhQu",
            "Q2hlc3NSb2d1ZVF1ZXJ5SW5mbxIqCg5yb2d1ZV9nZXRfaW5mbxgPIAEoCzIS",
            "LkNoZXNzUm9ndWVHZXRJbmZvEjEKD3JvZ3VlX2dhbWVfaW5mbxgDIAEoCzIY",
            "LkNoZXNzUm9ndWVRdWVyeUdhbWVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueFinishInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGetInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp), global::EggLink.DanhengServer.Proto.ChessRogueQueryScRsp.Parser, new[]{ "FinishInfo", "Info", "Retcode", "QueryInfo", "RogueGetInfo", "RogueGameInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQueryScRsp : pb::IMessage<ChessRogueQueryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQueryScRsp> _parser = new pb::MessageParser<ChessRogueQueryScRsp>(() => new ChessRogueQueryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQueryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQueryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp(ChessRogueQueryScRsp other) : this() {
      finishInfo_ = other.finishInfo_ != null ? other.finishInfo_.Clone() : null;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      retcode_ = other.retcode_;
      queryInfo_ = other.queryInfo_ != null ? other.queryInfo_.Clone() : null;
      rogueGetInfo_ = other.rogueGetInfo_ != null ? other.rogueGetInfo_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQueryScRsp Clone() {
      return new ChessRogueQueryScRsp(this);
    }

    /// <summary>Field number for the "finish_info" field.</summary>
    public const int FinishInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo finishInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo FinishInfo {
      get { return finishInfo_; }
      set {
        finishInfo_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "query_info" field.</summary>
    public const int QueryInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo queryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo QueryInfo {
      get { return queryInfo_; }
      set {
        queryInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ChessRogueGetInfo rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGetInfo RogueGetInfo {
      get { return rogueGetInfo_; }
      set {
        rogueGetInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfo rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfo RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQueryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQueryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FinishInfo, other.FinishInfo)) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(QueryInfo, other.QueryInfo)) return false;
      if (!object.Equals(RogueGetInfo, other.RogueGetInfo)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (finishInfo_ != null) hash ^= FinishInfo.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (queryInfo_ != null) hash ^= QueryInfo.GetHashCode();
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
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
      if (finishInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FinishInfo);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueGameInfo);
      }
      if (queryInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(QueryInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Info);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueGetInfo);
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
      if (finishInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FinishInfo);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RogueGameInfo);
      }
      if (queryInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(QueryInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (info_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Info);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueGetInfo);
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
      if (finishInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinishInfo);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (queryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryInfo);
      }
      if (rogueGetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGetInfo);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQueryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.finishInfo_ != null) {
        if (finishInfo_ == null) {
          FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
        }
        FinishInfo.MergeFrom(other.FinishInfo);
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.queryInfo_ != null) {
        if (queryInfo_ == null) {
          QueryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo();
        }
        QueryInfo.MergeFrom(other.QueryInfo);
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfo();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
          case 10: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 26: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 74: {
            if (queryInfo_ == null) {
              QueryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo();
            }
            input.ReadMessage(QueryInfo);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 122: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
            }
            input.ReadMessage(RogueGetInfo);
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
          case 10: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.ChessRogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 26: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 74: {
            if (queryInfo_ == null) {
              QueryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo();
            }
            input.ReadMessage(QueryInfo);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.ChessRogueCurrentInfo();
            }
            input.ReadMessage(Info);
            break;
          }
          case 122: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
            }
            input.ReadMessage(RogueGetInfo);
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
