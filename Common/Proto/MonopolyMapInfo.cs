// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyMapInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyMapInfo.proto</summary>
  public static partial class MonopolyMapInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyMapInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyMapInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNb25vcG9seU1hcEluZm8ucHJvdG8aEUdESkJBTklGSERBLnByb3RvIo8B",
            "Cg9Nb25vcG9seU1hcEluZm8SIQoLSkRETURQSE1MT0cYAyADKAsyDC5HREpC",
            "QU5JRkhEQRIhCgtITkJQTEpMRU9OTRgHIAMoCzIMLkdESkJBTklGSERBEiEK",
            "C0FNRkFBTUZMTUVCGAEgASgLMgwuR0RKQkFOSUZIREESEwoLRlBITEpOSEFL",
            "UFAYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GDJBANIFHDAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyMapInfo), global::EggLink.DanhengServer.Proto.MonopolyMapInfo.Parser, new[]{ "JDDMDPHMLOG", "HNBPLJLEONM", "AMFAAMFLMEB", "FPHLJNHAKPP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyMapInfo : pb::IMessage<MonopolyMapInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyMapInfo> _parser = new pb::MessageParser<MonopolyMapInfo>(() => new MonopolyMapInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyMapInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyMapInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyMapInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyMapInfo(MonopolyMapInfo other) : this() {
      jDDMDPHMLOG_ = other.jDDMDPHMLOG_.Clone();
      hNBPLJLEONM_ = other.hNBPLJLEONM_.Clone();
      aMFAAMFLMEB_ = other.aMFAAMFLMEB_ != null ? other.aMFAAMFLMEB_.Clone() : null;
      fPHLJNHAKPP_ = other.fPHLJNHAKPP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyMapInfo Clone() {
      return new MonopolyMapInfo(this);
    }

    /// <summary>Field number for the "JDDMDPHMLOG" field.</summary>
    public const int JDDMDPHMLOGFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> _repeated_jDDMDPHMLOG_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.GDJBANIFHDA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> jDDMDPHMLOG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> JDDMDPHMLOG {
      get { return jDDMDPHMLOG_; }
    }

    /// <summary>Field number for the "HNBPLJLEONM" field.</summary>
    public const int HNBPLJLEONMFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> _repeated_hNBPLJLEONM_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.GDJBANIFHDA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> hNBPLJLEONM_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> HNBPLJLEONM {
      get { return hNBPLJLEONM_; }
    }

    /// <summary>Field number for the "AMFAAMFLMEB" field.</summary>
    public const int AMFAAMFLMEBFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.GDJBANIFHDA aMFAAMFLMEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GDJBANIFHDA AMFAAMFLMEB {
      get { return aMFAAMFLMEB_; }
      set {
        aMFAAMFLMEB_ = value;
      }
    }

    /// <summary>Field number for the "FPHLJNHAKPP" field.</summary>
    public const int FPHLJNHAKPPFieldNumber = 11;
    private uint fPHLJNHAKPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FPHLJNHAKPP {
      get { return fPHLJNHAKPP_; }
      set {
        fPHLJNHAKPP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyMapInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyMapInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jDDMDPHMLOG_.Equals(other.jDDMDPHMLOG_)) return false;
      if(!hNBPLJLEONM_.Equals(other.hNBPLJLEONM_)) return false;
      if (!object.Equals(AMFAAMFLMEB, other.AMFAAMFLMEB)) return false;
      if (FPHLJNHAKPP != other.FPHLJNHAKPP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jDDMDPHMLOG_.GetHashCode();
      hash ^= hNBPLJLEONM_.GetHashCode();
      if (aMFAAMFLMEB_ != null) hash ^= AMFAAMFLMEB.GetHashCode();
      if (FPHLJNHAKPP != 0) hash ^= FPHLJNHAKPP.GetHashCode();
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
      if (aMFAAMFLMEB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AMFAAMFLMEB);
      }
      jDDMDPHMLOG_.WriteTo(output, _repeated_jDDMDPHMLOG_codec);
      hNBPLJLEONM_.WriteTo(output, _repeated_hNBPLJLEONM_codec);
      if (FPHLJNHAKPP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FPHLJNHAKPP);
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
      if (aMFAAMFLMEB_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AMFAAMFLMEB);
      }
      jDDMDPHMLOG_.WriteTo(ref output, _repeated_jDDMDPHMLOG_codec);
      hNBPLJLEONM_.WriteTo(ref output, _repeated_hNBPLJLEONM_codec);
      if (FPHLJNHAKPP != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FPHLJNHAKPP);
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
      size += jDDMDPHMLOG_.CalculateSize(_repeated_jDDMDPHMLOG_codec);
      size += hNBPLJLEONM_.CalculateSize(_repeated_hNBPLJLEONM_codec);
      if (aMFAAMFLMEB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AMFAAMFLMEB);
      }
      if (FPHLJNHAKPP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FPHLJNHAKPP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyMapInfo other) {
      if (other == null) {
        return;
      }
      jDDMDPHMLOG_.Add(other.jDDMDPHMLOG_);
      hNBPLJLEONM_.Add(other.hNBPLJLEONM_);
      if (other.aMFAAMFLMEB_ != null) {
        if (aMFAAMFLMEB_ == null) {
          AMFAAMFLMEB = new global::EggLink.DanhengServer.Proto.GDJBANIFHDA();
        }
        AMFAAMFLMEB.MergeFrom(other.AMFAAMFLMEB);
      }
      if (other.FPHLJNHAKPP != 0) {
        FPHLJNHAKPP = other.FPHLJNHAKPP;
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
            if (aMFAAMFLMEB_ == null) {
              AMFAAMFLMEB = new global::EggLink.DanhengServer.Proto.GDJBANIFHDA();
            }
            input.ReadMessage(AMFAAMFLMEB);
            break;
          }
          case 26: {
            jDDMDPHMLOG_.AddEntriesFrom(input, _repeated_jDDMDPHMLOG_codec);
            break;
          }
          case 58: {
            hNBPLJLEONM_.AddEntriesFrom(input, _repeated_hNBPLJLEONM_codec);
            break;
          }
          case 88: {
            FPHLJNHAKPP = input.ReadUInt32();
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
            if (aMFAAMFLMEB_ == null) {
              AMFAAMFLMEB = new global::EggLink.DanhengServer.Proto.GDJBANIFHDA();
            }
            input.ReadMessage(AMFAAMFLMEB);
            break;
          }
          case 26: {
            jDDMDPHMLOG_.AddEntriesFrom(ref input, _repeated_jDDMDPHMLOG_codec);
            break;
          }
          case 58: {
            hNBPLJLEONM_.AddEntriesFrom(ref input, _repeated_hNBPLJLEONM_codec);
            break;
          }
          case 88: {
            FPHLJNHAKPP = input.ReadUInt32();
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