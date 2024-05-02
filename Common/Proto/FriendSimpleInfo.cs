// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendSimpleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FriendSimpleInfo.proto</summary>
  public static partial class FriendSimpleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendSimpleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendSimpleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGcmllbmRTaW1wbGVJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnBy",
            "b3RvImQKEEZyaWVuZFNpbXBsZUluZm8SJgoLcGxheWVyX2luZm8YAiABKAsy",
            "ES5QbGF5ZXJTaW1wbGVJbmZvEhMKC2lzX3JlbWFya2VkGAwgASgIEhMKC3Jl",
            "bWFya19uYW1lGAggASgJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerSimpleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FriendSimpleInfo), global::EggLink.DanhengServer.Proto.FriendSimpleInfo.Parser, new[]{ "PlayerInfo", "IsRemarked", "RemarkName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FriendSimpleInfo : pb::IMessage<FriendSimpleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FriendSimpleInfo> _parser = new pb::MessageParser<FriendSimpleInfo>(() => new FriendSimpleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FriendSimpleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FriendSimpleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo(FriendSimpleInfo other) : this() {
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      isRemarked_ = other.isRemarked_;
      remarkName_ = other.remarkName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendSimpleInfo Clone() {
      return new FriendSimpleInfo(this);
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.PlayerSimpleInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerSimpleInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_remarked" field.</summary>
    public const int IsRemarkedFieldNumber = 12;
    private bool isRemarked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRemarked {
      get { return isRemarked_; }
      set {
        isRemarked_ = value;
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 8;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FriendSimpleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FriendSimpleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (IsRemarked != other.IsRemarked) return false;
      if (RemarkName != other.RemarkName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (IsRemarked != false) hash ^= IsRemarked.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
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
      if (playerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerInfo);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (IsRemarked != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsRemarked);
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
      if (playerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerInfo);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (IsRemarked != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsRemarked);
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
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (IsRemarked != false) {
        size += 1 + 1;
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FriendSimpleInfo other) {
      if (other == null) {
        return;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.IsRemarked != false) {
        IsRemarked = other.IsRemarked;
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
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
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 96: {
            IsRemarked = input.ReadBool();
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
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.PlayerSimpleInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 96: {
            IsRemarked = input.ReadBool();
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
