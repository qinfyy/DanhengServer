// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueLeaveScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueLeaveScRsp.proto</summary>
  public static partial class ChessRogueLeaveScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueLeaveScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueLeaveScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDaGVzc1JvZ3VlTGVhdmVTY1JzcC5wcm90bxoaQ2hlc3NSb2d1ZVBsYXll",
            "ckluZm8ucHJvdG8aGUNoZXNzUm9ndWVRdWVyeUluZm8ucHJvdG8aF0NoZXNz",
            "Um9ndWVHZXRJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8i",
            "1wEKFENoZXNzUm9ndWVMZWF2ZVNjUnNwEiwKD3JvZ3VlX2Flb25faW5mbxgH",
            "IAEoCzITLkNoZXNzUm9ndWVBZW9uSW5mbxIqCg5yb2d1ZV9nZXRfaW5mbxgJ",
            "IAEoCzISLkNoZXNzUm9ndWVHZXRJbmZvEg8KB3JldGNvZGUYBSABKA0SKAoK",
            "cXVlcnlfaW5mbxgDIAEoCzIULkNoZXNzUm9ndWVRdWVyeUluZm8SKgoLcGxh",
            "eWVyX2luZm8YDSABKAsyFS5DaGVzc1JvZ3VlUGxheWVySW5mb0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueQueryInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGetInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueAeonInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueLeaveScRsp), global::EggLink.DanhengServer.Proto.ChessRogueLeaveScRsp.Parser, new[]{ "RogueAeonInfo", "RogueGetInfo", "Retcode", "QueryInfo", "PlayerInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueLeaveScRsp : pb::IMessage<ChessRogueLeaveScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueLeaveScRsp> _parser = new pb::MessageParser<ChessRogueLeaveScRsp>(() => new ChessRogueLeaveScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueLeaveScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueLeaveScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLeaveScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLeaveScRsp(ChessRogueLeaveScRsp other) : this() {
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      rogueGetInfo_ = other.rogueGetInfo_ != null ? other.rogueGetInfo_.Clone() : null;
      retcode_ = other.retcode_;
      queryInfo_ = other.queryInfo_ != null ? other.queryInfo_.Clone() : null;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLeaveScRsp Clone() {
      return new ChessRogueLeaveScRsp(this);
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ChessRogueGetInfo rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGetInfo RogueGetInfo {
      get { return rogueGetInfo_; }
      set {
        rogueGetInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
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
    public const int QueryInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo queryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo QueryInfo {
      get { return queryInfo_; }
      set {
        queryInfo_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueLeaveScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueLeaveScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueGetInfo, other.RogueGetInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(QueryInfo, other.QueryInfo)) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (queryInfo_ != null) hash ^= QueryInfo.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
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
      if (queryInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(QueryInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueGetInfo);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerInfo);
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
      if (queryInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(QueryInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RogueAeonInfo);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueGetInfo);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerInfo);
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
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (rogueGetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGetInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (queryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryInfo);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueLeaveScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
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
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
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
          case 26: {
            if (queryInfo_ == null) {
              QueryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo();
            }
            input.ReadMessage(QueryInfo);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 106: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
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
          case 26: {
            if (queryInfo_ == null) {
              QueryInfo = new global::EggLink.DanhengServer.Proto.ChessRogueQueryInfo();
            }
            input.ReadMessage(QueryInfo);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessRogueAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGetInfo();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 106: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.ChessRoguePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
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
