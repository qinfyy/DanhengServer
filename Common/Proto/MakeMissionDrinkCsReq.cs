// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MakeMissionDrinkCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MakeMissionDrinkCsReq.proto</summary>
  public static partial class MakeMissionDrinkCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MakeMissionDrinkCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MakeMissionDrinkCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNYWtlTWlzc2lvbkRyaW5rQ3NSZXEucHJvdG8aEUpQR0ZJQ0pCTEhOLnBy",
            "b3RvImQKFU1ha2VNaXNzaW9uRHJpbmtDc1JlcRITCgtOQUhLS0ZFSE9DRhgO",
            "IAEoCBIhCgtLS0RNT0ZDRUlERBgGIAEoCzIMLkpQR0ZJQ0pCTEhOEhMKC0xP",
            "UFBBQkFFRUxEGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JPGFICJBLHNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MakeMissionDrinkCsReq), global::EggLink.DanhengServer.Proto.MakeMissionDrinkCsReq.Parser, new[]{ "NAHKKFEHOCF", "KKDMOFCEIDD", "LOPPABAEELD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MakeMissionDrinkCsReq : pb::IMessage<MakeMissionDrinkCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MakeMissionDrinkCsReq> _parser = new pb::MessageParser<MakeMissionDrinkCsReq>(() => new MakeMissionDrinkCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MakeMissionDrinkCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MakeMissionDrinkCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkCsReq(MakeMissionDrinkCsReq other) : this() {
      nAHKKFEHOCF_ = other.nAHKKFEHOCF_;
      kKDMOFCEIDD_ = other.kKDMOFCEIDD_ != null ? other.kKDMOFCEIDD_.Clone() : null;
      lOPPABAEELD_ = other.lOPPABAEELD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MakeMissionDrinkCsReq Clone() {
      return new MakeMissionDrinkCsReq(this);
    }

    /// <summary>Field number for the "NAHKKFEHOCF" field.</summary>
    public const int NAHKKFEHOCFFieldNumber = 14;
    private bool nAHKKFEHOCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NAHKKFEHOCF {
      get { return nAHKKFEHOCF_; }
      set {
        nAHKKFEHOCF_ = value;
      }
    }

    /// <summary>Field number for the "KKDMOFCEIDD" field.</summary>
    public const int KKDMOFCEIDDFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.JPGFICJBLHN kKDMOFCEIDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPGFICJBLHN KKDMOFCEIDD {
      get { return kKDMOFCEIDD_; }
      set {
        kKDMOFCEIDD_ = value;
      }
    }

    /// <summary>Field number for the "LOPPABAEELD" field.</summary>
    public const int LOPPABAEELDFieldNumber = 1;
    private uint lOPPABAEELD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LOPPABAEELD {
      get { return lOPPABAEELD_; }
      set {
        lOPPABAEELD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MakeMissionDrinkCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MakeMissionDrinkCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NAHKKFEHOCF != other.NAHKKFEHOCF) return false;
      if (!object.Equals(KKDMOFCEIDD, other.KKDMOFCEIDD)) return false;
      if (LOPPABAEELD != other.LOPPABAEELD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NAHKKFEHOCF != false) hash ^= NAHKKFEHOCF.GetHashCode();
      if (kKDMOFCEIDD_ != null) hash ^= KKDMOFCEIDD.GetHashCode();
      if (LOPPABAEELD != 0) hash ^= LOPPABAEELD.GetHashCode();
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
      if (LOPPABAEELD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LOPPABAEELD);
      }
      if (kKDMOFCEIDD_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(KKDMOFCEIDD);
      }
      if (NAHKKFEHOCF != false) {
        output.WriteRawTag(112);
        output.WriteBool(NAHKKFEHOCF);
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
      if (LOPPABAEELD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LOPPABAEELD);
      }
      if (kKDMOFCEIDD_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(KKDMOFCEIDD);
      }
      if (NAHKKFEHOCF != false) {
        output.WriteRawTag(112);
        output.WriteBool(NAHKKFEHOCF);
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
      if (NAHKKFEHOCF != false) {
        size += 1 + 1;
      }
      if (kKDMOFCEIDD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KKDMOFCEIDD);
      }
      if (LOPPABAEELD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LOPPABAEELD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MakeMissionDrinkCsReq other) {
      if (other == null) {
        return;
      }
      if (other.NAHKKFEHOCF != false) {
        NAHKKFEHOCF = other.NAHKKFEHOCF;
      }
      if (other.kKDMOFCEIDD_ != null) {
        if (kKDMOFCEIDD_ == null) {
          KKDMOFCEIDD = new global::EggLink.DanhengServer.Proto.JPGFICJBLHN();
        }
        KKDMOFCEIDD.MergeFrom(other.KKDMOFCEIDD);
      }
      if (other.LOPPABAEELD != 0) {
        LOPPABAEELD = other.LOPPABAEELD;
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
            LOPPABAEELD = input.ReadUInt32();
            break;
          }
          case 50: {
            if (kKDMOFCEIDD_ == null) {
              KKDMOFCEIDD = new global::EggLink.DanhengServer.Proto.JPGFICJBLHN();
            }
            input.ReadMessage(KKDMOFCEIDD);
            break;
          }
          case 112: {
            NAHKKFEHOCF = input.ReadBool();
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
            LOPPABAEELD = input.ReadUInt32();
            break;
          }
          case 50: {
            if (kKDMOFCEIDD_ == null) {
              KKDMOFCEIDD = new global::EggLink.DanhengServer.Proto.JPGFICJBLHN();
            }
            input.ReadMessage(KKDMOFCEIDD);
            break;
          }
          case 112: {
            NAHKKFEHOCF = input.ReadBool();
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
