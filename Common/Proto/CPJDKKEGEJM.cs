// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CPJDKKEGEJM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CPJDKKEGEJM.proto</summary>
  public static partial class CPJDKKEGEJMReflection {

    #region Descriptor
    /// <summary>File descriptor for CPJDKKEGEJM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CPJDKKEGEJMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDUEpES0tFR0VKTS5wcm90bxoRUm9ndWVTdGF0dXMucHJvdG8aFENoZXNz",
            "Um9ndWVCdWZmLnByb3RvGhdDaGVzc1JvZ3VlTWlyYWNsZS5wcm90byKBAgoL",
            "Q1BKREtLRUdFSk0SKAoMbWlyYWNsZV9pbmZvGAkgASgLMhIuQ2hlc3NSb2d1",
            "ZU1pcmFjbGUSHAoGc3RhdHVzGA4gASgOMgwuUm9ndWVTdGF0dXMSEwoLRUhD",
            "TUxHTExORkgYASABKA0SDgoGbWFwX2lkGAwgASgNEhMKC09MR0hDTUFHR0tM",
            "GAsgAygNEhoKEmN1cl9yZWFjaF9yb29tX251bRgKIAEoDRITCgtQTk5CRkJJ",
            "Tk1QSBgEIAEoDRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GAMgAygNEiIKCWJ1",
            "ZmZfaW5mbxgIIAEoCzIPLkNoZXNzUm9ndWVCdWZmQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBuffReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CPJDKKEGEJM), global::EggLink.DanhengServer.Proto.CPJDKKEGEJM.Parser, new[]{ "MiracleInfo", "Status", "EHCMLGLLNFH", "MapId", "OLGHCMAGGKL", "CurReachRoomNum", "PNNBFBINMPH", "BaseAvatarIdList", "BuffInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CPJDKKEGEJM : pb::IMessage<CPJDKKEGEJM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CPJDKKEGEJM> _parser = new pb::MessageParser<CPJDKKEGEJM>(() => new CPJDKKEGEJM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CPJDKKEGEJM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CPJDKKEGEJMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CPJDKKEGEJM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CPJDKKEGEJM(CPJDKKEGEJM other) : this() {
      miracleInfo_ = other.miracleInfo_ != null ? other.miracleInfo_.Clone() : null;
      status_ = other.status_;
      eHCMLGLLNFH_ = other.eHCMLGLLNFH_;
      mapId_ = other.mapId_;
      oLGHCMAGGKL_ = other.oLGHCMAGGKL_.Clone();
      curReachRoomNum_ = other.curReachRoomNum_;
      pNNBFBINMPH_ = other.pNNBFBINMPH_;
      baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
      buffInfo_ = other.buffInfo_ != null ? other.buffInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CPJDKKEGEJM Clone() {
      return new CPJDKKEGEJM(this);
    }

    /// <summary>Field number for the "miracle_info" field.</summary>
    public const int MiracleInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ChessRogueMiracle miracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracle MiracleInfo {
      get { return miracleInfo_; }
      set {
        miracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueStatus status_ = global::EggLink.DanhengServer.Proto.RogueStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "EHCMLGLLNFH" field.</summary>
    public const int EHCMLGLLNFHFieldNumber = 1;
    private uint eHCMLGLLNFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EHCMLGLLNFH {
      get { return eHCMLGLLNFH_; }
      set {
        eHCMLGLLNFH_ = value;
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 12;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "OLGHCMAGGKL" field.</summary>
    public const int OLGHCMAGGKLFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_oLGHCMAGGKL_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> oLGHCMAGGKL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OLGHCMAGGKL {
      get { return oLGHCMAGGKL_; }
    }

    /// <summary>Field number for the "cur_reach_room_num" field.</summary>
    public const int CurReachRoomNumFieldNumber = 10;
    private uint curReachRoomNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurReachRoomNum {
      get { return curReachRoomNum_; }
      set {
        curReachRoomNum_ = value;
      }
    }

    /// <summary>Field number for the "PNNBFBINMPH" field.</summary>
    public const int PNNBFBINMPHFieldNumber = 4;
    private uint pNNBFBINMPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PNNBFBINMPH {
      get { return pNNBFBINMPH_; }
      set {
        pNNBFBINMPH_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id_list" field.</summary>
    public const int BaseAvatarIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_baseAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> baseAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BaseAvatarIdList {
      get { return baseAvatarIdList_; }
    }

    /// <summary>Field number for the "buff_info" field.</summary>
    public const int BuffInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ChessRogueBuff buffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBuff BuffInfo {
      get { return buffInfo_; }
      set {
        buffInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CPJDKKEGEJM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CPJDKKEGEJM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MiracleInfo, other.MiracleInfo)) return false;
      if (Status != other.Status) return false;
      if (EHCMLGLLNFH != other.EHCMLGLLNFH) return false;
      if (MapId != other.MapId) return false;
      if(!oLGHCMAGGKL_.Equals(other.oLGHCMAGGKL_)) return false;
      if (CurReachRoomNum != other.CurReachRoomNum) return false;
      if (PNNBFBINMPH != other.PNNBFBINMPH) return false;
      if(!baseAvatarIdList_.Equals(other.baseAvatarIdList_)) return false;
      if (!object.Equals(BuffInfo, other.BuffInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (miracleInfo_ != null) hash ^= MiracleInfo.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) hash ^= Status.GetHashCode();
      if (EHCMLGLLNFH != 0) hash ^= EHCMLGLLNFH.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      hash ^= oLGHCMAGGKL_.GetHashCode();
      if (CurReachRoomNum != 0) hash ^= CurReachRoomNum.GetHashCode();
      if (PNNBFBINMPH != 0) hash ^= PNNBFBINMPH.GetHashCode();
      hash ^= baseAvatarIdList_.GetHashCode();
      if (buffInfo_ != null) hash ^= BuffInfo.GetHashCode();
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
      if (EHCMLGLLNFH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EHCMLGLLNFH);
      }
      baseAvatarIdList_.WriteTo(output, _repeated_baseAvatarIdList_codec);
      if (PNNBFBINMPH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PNNBFBINMPH);
      }
      if (buffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BuffInfo);
      }
      if (miracleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MiracleInfo);
      }
      if (CurReachRoomNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurReachRoomNum);
      }
      oLGHCMAGGKL_.WriteTo(output, _repeated_oLGHCMAGGKL_codec);
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (EHCMLGLLNFH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EHCMLGLLNFH);
      }
      baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
      if (PNNBFBINMPH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PNNBFBINMPH);
      }
      if (buffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BuffInfo);
      }
      if (miracleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MiracleInfo);
      }
      if (CurReachRoomNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurReachRoomNum);
      }
      oLGHCMAGGKL_.WriteTo(ref output, _repeated_oLGHCMAGGKL_codec);
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Status);
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
      if (miracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MiracleInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (EHCMLGLLNFH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EHCMLGLLNFH);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      size += oLGHCMAGGKL_.CalculateSize(_repeated_oLGHCMAGGKL_codec);
      if (CurReachRoomNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurReachRoomNum);
      }
      if (PNNBFBINMPH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PNNBFBINMPH);
      }
      size += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
      if (buffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BuffInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CPJDKKEGEJM other) {
      if (other == null) {
        return;
      }
      if (other.miracleInfo_ != null) {
        if (miracleInfo_ == null) {
          MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracle();
        }
        MiracleInfo.MergeFrom(other.MiracleInfo);
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        Status = other.Status;
      }
      if (other.EHCMLGLLNFH != 0) {
        EHCMLGLLNFH = other.EHCMLGLLNFH;
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      oLGHCMAGGKL_.Add(other.oLGHCMAGGKL_);
      if (other.CurReachRoomNum != 0) {
        CurReachRoomNum = other.CurReachRoomNum;
      }
      if (other.PNNBFBINMPH != 0) {
        PNNBFBINMPH = other.PNNBFBINMPH;
      }
      baseAvatarIdList_.Add(other.baseAvatarIdList_);
      if (other.buffInfo_ != null) {
        if (buffInfo_ == null) {
          BuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuff();
        }
        BuffInfo.MergeFrom(other.BuffInfo);
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
          case 8: {
            EHCMLGLLNFH = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            baseAvatarIdList_.AddEntriesFrom(input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 32: {
            PNNBFBINMPH = input.ReadUInt32();
            break;
          }
          case 66: {
            if (buffInfo_ == null) {
              BuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuff();
            }
            input.ReadMessage(BuffInfo);
            break;
          }
          case 74: {
            if (miracleInfo_ == null) {
              MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracle();
            }
            input.ReadMessage(MiracleInfo);
            break;
          }
          case 80: {
            CurReachRoomNum = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            oLGHCMAGGKL_.AddEntriesFrom(input, _repeated_oLGHCMAGGKL_codec);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
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
          case 8: {
            EHCMLGLLNFH = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 32: {
            PNNBFBINMPH = input.ReadUInt32();
            break;
          }
          case 66: {
            if (buffInfo_ == null) {
              BuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuff();
            }
            input.ReadMessage(BuffInfo);
            break;
          }
          case 74: {
            if (miracleInfo_ == null) {
              MiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracle();
            }
            input.ReadMessage(MiracleInfo);
            break;
          }
          case 80: {
            CurReachRoomNum = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            oLGHCMAGGKL_.AddEntriesFrom(ref input, _repeated_oLGHCMAGGKL_codec);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 112: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
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
