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
            "ChpDaGVzc1JvZ3VlTGVhdmVTY1JzcC5wcm90bxoRQ05IR0pETEFFSEwucHJv",
            "dG8aEUpQREhPTlBJQ0lELnByb3RvGhFBUENLT0JLREdGRy5wcm90bxoRSUdE",
            "S09MTkFGS1AucHJvdG8iugEKFENoZXNzUm9ndWVMZWF2ZVNjUnNwEiUKD3Jv",
            "Z3VlX2Flb25faW5mbxgHIAEoCzIMLkFQQ0tPQktER0ZHEiQKDnJvZ3VlX2dl",
            "dF9pbmZvGAkgASgLMgwuSUdES09MTkFGS1ASDwoHcmV0Y29kZRgFIAEoDRIh",
            "CgtBTk5OQkhKRE1QTRgDIAEoCzIMLkpQREhPTlBJQ0lEEiEKC1BCSE9KTkxL",
            "S09MGA0gASgLMgwuQ05IR0pETEFFSExCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CNHGJDLAEHLReflection.Descriptor, global::EggLink.DanhengServer.Proto.JPDHONPICIDReflection.Descriptor, global::EggLink.DanhengServer.Proto.APCKOBKDGFGReflection.Descriptor, global::EggLink.DanhengServer.Proto.IGDKOLNAFKPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueLeaveScRsp), global::EggLink.DanhengServer.Proto.ChessRogueLeaveScRsp.Parser, new[]{ "RogueAeonInfo", "RogueGetInfo", "Retcode", "ANNNBHJDMPM", "PBHOJNLKKOL" }, null, null, null, null)
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
      aNNNBHJDMPM_ = other.aNNNBHJDMPM_ != null ? other.aNNNBHJDMPM_.Clone() : null;
      pBHOJNLKKOL_ = other.pBHOJNLKKOL_ != null ? other.pBHOJNLKKOL_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueLeaveScRsp Clone() {
      return new ChessRogueLeaveScRsp(this);
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.APCKOBKDGFG rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.APCKOBKDGFG RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.IGDKOLNAFKP rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IGDKOLNAFKP RogueGetInfo {
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

    /// <summary>Field number for the "ANNNBHJDMPM" field.</summary>
    public const int ANNNBHJDMPMFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.JPDHONPICID aNNNBHJDMPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPDHONPICID ANNNBHJDMPM {
      get { return aNNNBHJDMPM_; }
      set {
        aNNNBHJDMPM_ = value;
      }
    }

    /// <summary>Field number for the "PBHOJNLKKOL" field.</summary>
    public const int PBHOJNLKKOLFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.CNHGJDLAEHL pBHOJNLKKOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CNHGJDLAEHL PBHOJNLKKOL {
      get { return pBHOJNLKKOL_; }
      set {
        pBHOJNLKKOL_ = value;
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
      if (!object.Equals(ANNNBHJDMPM, other.ANNNBHJDMPM)) return false;
      if (!object.Equals(PBHOJNLKKOL, other.PBHOJNLKKOL)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (aNNNBHJDMPM_ != null) hash ^= ANNNBHJDMPM.GetHashCode();
      if (pBHOJNLKKOL_ != null) hash ^= PBHOJNLKKOL.GetHashCode();
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
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ANNNBHJDMPM);
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
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PBHOJNLKKOL);
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
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ANNNBHJDMPM);
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
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PBHOJNLKKOL);
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
      if (aNNNBHJDMPM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ANNNBHJDMPM);
      }
      if (pBHOJNLKKOL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBHOJNLKKOL);
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
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.aNNNBHJDMPM_ != null) {
        if (aNNNBHJDMPM_ == null) {
          ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
        }
        ANNNBHJDMPM.MergeFrom(other.ANNNBHJDMPM);
      }
      if (other.pBHOJNLKKOL_ != null) {
        if (pBHOJNLKKOL_ == null) {
          PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
        }
        PBHOJNLKKOL.MergeFrom(other.PBHOJNLKKOL);
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
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 106: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
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
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 74: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
            break;
          }
          case 106: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
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
