// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetHeroBasicTypeInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetHeroBasicTypeInfoScRsp.proto</summary>
  public static partial class GetHeroBasicTypeInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetHeroBasicTypeInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetHeroBasicTypeInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRIZXJvQmFzaWNUeXBlSW5mb1NjUnNwLnByb3RvGh1QbGF5ZXJIZXJv",
            "QmFzaWNUeXBlSW5mby5wcm90bxoMR2VuZGVyLnByb3RvGhNIZXJvQmFzaWNU",
            "eXBlLnByb3RvItYBChlHZXRIZXJvQmFzaWNUeXBlSW5mb1NjUnNwEjYKFGJh",
            "c2ljX3R5cGVfaW5mb19saXN0GAIgAygLMhguUGxheWVySGVyb0Jhc2ljVHlw",
            "ZUluZm8SGgoSaXNfZ2VuZGVyX21vZGlmaWVkGA8gASgIEg8KB3JldGNvZGUY",
            "BiABKA0SFwoGZ2VuZGVyGA0gASgOMgcuR2VuZGVyEiYKDmN1cl9iYXNpY190",
            "eXBlGAUgASgOMg4uSGVyb0Jhc2ljVHlwZRITCgtDSEFCTkxDR0xNUBgDIAEo",
            "CEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GenderReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeroBasicTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRsp), global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRsp.Parser, new[]{ "BasicTypeInfoList", "IsGenderModified", "Retcode", "Gender", "CurBasicType", "CHABNLCGLMP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetHeroBasicTypeInfoScRsp : pb::IMessage<GetHeroBasicTypeInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetHeroBasicTypeInfoScRsp> _parser = new pb::MessageParser<GetHeroBasicTypeInfoScRsp>(() => new GetHeroBasicTypeInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetHeroBasicTypeInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetHeroBasicTypeInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp(GetHeroBasicTypeInfoScRsp other) : this() {
      basicTypeInfoList_ = other.basicTypeInfoList_.Clone();
      isGenderModified_ = other.isGenderModified_;
      retcode_ = other.retcode_;
      gender_ = other.gender_;
      curBasicType_ = other.curBasicType_;
      cHABNLCGLMP_ = other.cHABNLCGLMP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeroBasicTypeInfoScRsp Clone() {
      return new GetHeroBasicTypeInfoScRsp(this);
    }

    /// <summary>Field number for the "basic_type_info_list" field.</summary>
    public const int BasicTypeInfoListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> _repeated_basicTypeInfoList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> basicTypeInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerHeroBasicTypeInfo> BasicTypeInfoList {
      get { return basicTypeInfoList_; }
    }

    /// <summary>Field number for the "is_gender_modified" field.</summary>
    public const int IsGenderModifiedFieldNumber = 15;
    private bool isGenderModified_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGenderModified {
      get { return isGenderModified_; }
      set {
        isGenderModified_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.Gender gender_ = global::EggLink.DanhengServer.Proto.Gender.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "cur_basic_type" field.</summary>
    public const int CurBasicTypeFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.HeroBasicType curBasicType_ = global::EggLink.DanhengServer.Proto.HeroBasicType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeroBasicType CurBasicType {
      get { return curBasicType_; }
      set {
        curBasicType_ = value;
      }
    }

    /// <summary>Field number for the "CHABNLCGLMP" field.</summary>
    public const int CHABNLCGLMPFieldNumber = 3;
    private bool cHABNLCGLMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CHABNLCGLMP {
      get { return cHABNLCGLMP_; }
      set {
        cHABNLCGLMP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetHeroBasicTypeInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetHeroBasicTypeInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!basicTypeInfoList_.Equals(other.basicTypeInfoList_)) return false;
      if (IsGenderModified != other.IsGenderModified) return false;
      if (Retcode != other.Retcode) return false;
      if (Gender != other.Gender) return false;
      if (CurBasicType != other.CurBasicType) return false;
      if (CHABNLCGLMP != other.CHABNLCGLMP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= basicTypeInfoList_.GetHashCode();
      if (IsGenderModified != false) hash ^= IsGenderModified.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) hash ^= Gender.GetHashCode();
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) hash ^= CurBasicType.GetHashCode();
      if (CHABNLCGLMP != false) hash ^= CHABNLCGLMP.GetHashCode();
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
      basicTypeInfoList_.WriteTo(output, _repeated_basicTypeInfoList_codec);
      if (CHABNLCGLMP != false) {
        output.WriteRawTag(24);
        output.WriteBool(CHABNLCGLMP);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CurBasicType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Gender);
      }
      if (IsGenderModified != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGenderModified);
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
      basicTypeInfoList_.WriteTo(ref output, _repeated_basicTypeInfoList_codec);
      if (CHABNLCGLMP != false) {
        output.WriteRawTag(24);
        output.WriteBool(CHABNLCGLMP);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) CurBasicType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Gender);
      }
      if (IsGenderModified != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGenderModified);
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
      size += basicTypeInfoList_.CalculateSize(_repeated_basicTypeInfoList_codec);
      if (IsGenderModified != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CurBasicType);
      }
      if (CHABNLCGLMP != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetHeroBasicTypeInfoScRsp other) {
      if (other == null) {
        return;
      }
      basicTypeInfoList_.Add(other.basicTypeInfoList_);
      if (other.IsGenderModified != false) {
        IsGenderModified = other.IsGenderModified;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        Gender = other.Gender;
      }
      if (other.CurBasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        CurBasicType = other.CurBasicType;
      }
      if (other.CHABNLCGLMP != false) {
        CHABNLCGLMP = other.CHABNLCGLMP;
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
            basicTypeInfoList_.AddEntriesFrom(input, _repeated_basicTypeInfoList_codec);
            break;
          }
          case 24: {
            CHABNLCGLMP = input.ReadBool();
            break;
          }
          case 40: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
            break;
          }
          case 120: {
            IsGenderModified = input.ReadBool();
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
            basicTypeInfoList_.AddEntriesFrom(ref input, _repeated_basicTypeInfoList_codec);
            break;
          }
          case 24: {
            CHABNLCGLMP = input.ReadBool();
            break;
          }
          case 40: {
            CurBasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
            break;
          }
          case 120: {
            IsGenderModified = input.ReadBool();
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
