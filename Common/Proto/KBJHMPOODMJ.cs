// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KBJHMPOODMJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KBJHMPOODMJ.proto</summary>
  public static partial class KBJHMPOODMJReflection {

    #region Descriptor
    /// <summary>File descriptor for KBJHMPOODMJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KBJHMPOODMJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLQkpITVBPT0RNSi5wcm90bxoXTW9uc3RlckJhdHRsZVR5cGUucHJvdG8i",
            "SwoLS0JKSE1QT09ETUoSJwoLRERNSEdGQkhEQk4YCCABKA4yEi5Nb25zdGVy",
            "QmF0dGxlVHlwZRITCgtNSU5DS0ZNQ0NNSBgLIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MonsterBattleTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KBJHMPOODMJ), global::EggLink.DanhengServer.Proto.KBJHMPOODMJ.Parser, new[]{ "DDMHGFBHDBN", "MINCKFMCCMH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KBJHMPOODMJ : pb::IMessage<KBJHMPOODMJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KBJHMPOODMJ> _parser = new pb::MessageParser<KBJHMPOODMJ>(() => new KBJHMPOODMJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KBJHMPOODMJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KBJHMPOODMJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KBJHMPOODMJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KBJHMPOODMJ(KBJHMPOODMJ other) : this() {
      dDMHGFBHDBN_ = other.dDMHGFBHDBN_;
      mINCKFMCCMH_ = other.mINCKFMCCMH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KBJHMPOODMJ Clone() {
      return new KBJHMPOODMJ(this);
    }

    /// <summary>Field number for the "DDMHGFBHDBN" field.</summary>
    public const int DDMHGFBHDBNFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.MonsterBattleType dDMHGFBHDBN_ = global::EggLink.DanhengServer.Proto.MonsterBattleType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonsterBattleType DDMHGFBHDBN {
      get { return dDMHGFBHDBN_; }
      set {
        dDMHGFBHDBN_ = value;
      }
    }

    /// <summary>Field number for the "MINCKFMCCMH" field.</summary>
    public const int MINCKFMCCMHFieldNumber = 11;
    private uint mINCKFMCCMH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MINCKFMCCMH {
      get { return mINCKFMCCMH_; }
      set {
        mINCKFMCCMH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KBJHMPOODMJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KBJHMPOODMJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DDMHGFBHDBN != other.DDMHGFBHDBN) return false;
      if (MINCKFMCCMH != other.MINCKFMCCMH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DDMHGFBHDBN != global::EggLink.DanhengServer.Proto.MonsterBattleType.None) hash ^= DDMHGFBHDBN.GetHashCode();
      if (MINCKFMCCMH != 0) hash ^= MINCKFMCCMH.GetHashCode();
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
      if (DDMHGFBHDBN != global::EggLink.DanhengServer.Proto.MonsterBattleType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) DDMHGFBHDBN);
      }
      if (MINCKFMCCMH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MINCKFMCCMH);
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
      if (DDMHGFBHDBN != global::EggLink.DanhengServer.Proto.MonsterBattleType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) DDMHGFBHDBN);
      }
      if (MINCKFMCCMH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MINCKFMCCMH);
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
      if (DDMHGFBHDBN != global::EggLink.DanhengServer.Proto.MonsterBattleType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DDMHGFBHDBN);
      }
      if (MINCKFMCCMH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MINCKFMCCMH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KBJHMPOODMJ other) {
      if (other == null) {
        return;
      }
      if (other.DDMHGFBHDBN != global::EggLink.DanhengServer.Proto.MonsterBattleType.None) {
        DDMHGFBHDBN = other.DDMHGFBHDBN;
      }
      if (other.MINCKFMCCMH != 0) {
        MINCKFMCCMH = other.MINCKFMCCMH;
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
          case 64: {
            DDMHGFBHDBN = (global::EggLink.DanhengServer.Proto.MonsterBattleType) input.ReadEnum();
            break;
          }
          case 88: {
            MINCKFMCCMH = input.ReadUInt32();
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
          case 64: {
            DDMHGFBHDBN = (global::EggLink.DanhengServer.Proto.MonsterBattleType) input.ReadEnum();
            break;
          }
          case 88: {
            MINCKFMCCMH = input.ReadUInt32();
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