// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EquipAetherDividePassiveSkillScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EquipAetherDividePassiveSkillScRsp.proto</summary>
  public static partial class EquipAetherDividePassiveSkillScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EquipAetherDividePassiveSkillScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipAetherDividePassiveSkillScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihFcXVpcEFldGhlckRpdmlkZVBhc3NpdmVTa2lsbFNjUnNwLnByb3RvGhVB",
            "ZXRoZXJTa2lsbEluZm8ucHJvdG8aHEFldGhlckRpdmlkZVNwaXJpdEluZm8u",
            "cHJvdG8iigEKIkVxdWlwQWV0aGVyRGl2aWRlUGFzc2l2ZVNraWxsU2NSc3AS",
            "DwoHcmV0Y29kZRgIIAEoDRIsCgtzcGlyaXRfaW5mbxgNIAEoCzIXLkFldGhl",
            "ckRpdmlkZVNwaXJpdEluZm8SJQoLQkxBQkRNSEdGRkUYAiABKAsyEC5BZXRo",
            "ZXJTa2lsbEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherSkillInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EquipAetherDividePassiveSkillScRsp), global::EggLink.DanhengServer.Proto.EquipAetherDividePassiveSkillScRsp.Parser, new[]{ "Retcode", "SpiritInfo", "BLABDMHGFFE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EquipAetherDividePassiveSkillScRsp : pb::IMessage<EquipAetherDividePassiveSkillScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EquipAetherDividePassiveSkillScRsp> _parser = new pb::MessageParser<EquipAetherDividePassiveSkillScRsp>(() => new EquipAetherDividePassiveSkillScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EquipAetherDividePassiveSkillScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EquipAetherDividePassiveSkillScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EquipAetherDividePassiveSkillScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EquipAetherDividePassiveSkillScRsp(EquipAetherDividePassiveSkillScRsp other) : this() {
      retcode_ = other.retcode_;
      spiritInfo_ = other.spiritInfo_ != null ? other.spiritInfo_.Clone() : null;
      bLABDMHGFFE_ = other.bLABDMHGFFE_ != null ? other.bLABDMHGFFE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EquipAetherDividePassiveSkillScRsp Clone() {
      return new EquipAetherDividePassiveSkillScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "spirit_info" field.</summary>
    public const int SpiritInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo spiritInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo SpiritInfo {
      get { return spiritInfo_; }
      set {
        spiritInfo_ = value;
      }
    }

    /// <summary>Field number for the "BLABDMHGFFE" field.</summary>
    public const int BLABDMHGFFEFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.AetherSkillInfo bLABDMHGFFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AetherSkillInfo BLABDMHGFFE {
      get { return bLABDMHGFFE_; }
      set {
        bLABDMHGFFE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EquipAetherDividePassiveSkillScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EquipAetherDividePassiveSkillScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(SpiritInfo, other.SpiritInfo)) return false;
      if (!object.Equals(BLABDMHGFFE, other.BLABDMHGFFE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (spiritInfo_ != null) hash ^= SpiritInfo.GetHashCode();
      if (bLABDMHGFFE_ != null) hash ^= BLABDMHGFFE.GetHashCode();
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
      if (bLABDMHGFFE_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BLABDMHGFFE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (spiritInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpiritInfo);
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
      if (bLABDMHGFFE_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BLABDMHGFFE);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (spiritInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpiritInfo);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (spiritInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpiritInfo);
      }
      if (bLABDMHGFFE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BLABDMHGFFE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EquipAetherDividePassiveSkillScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.spiritInfo_ != null) {
        if (spiritInfo_ == null) {
          SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
        }
        SpiritInfo.MergeFrom(other.SpiritInfo);
      }
      if (other.bLABDMHGFFE_ != null) {
        if (bLABDMHGFFE_ == null) {
          BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
        }
        BLABDMHGFFE.MergeFrom(other.BLABDMHGFFE);
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
            if (bLABDMHGFFE_ == null) {
              BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
            }
            input.ReadMessage(BLABDMHGFFE);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
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
            if (bLABDMHGFFE_ == null) {
              BLABDMHGFFE = new global::EggLink.DanhengServer.Proto.AetherSkillInfo();
            }
            input.ReadMessage(BLABDMHGFFE);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (spiritInfo_ == null) {
              SpiritInfo = new global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo();
            }
            input.ReadMessage(SpiritInfo);
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
