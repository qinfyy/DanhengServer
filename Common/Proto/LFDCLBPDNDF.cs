// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LFDCLBPDNDF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LFDCLBPDNDF.proto</summary>
  public static partial class LFDCLBPDNDFReflection {

    #region Descriptor
    /// <summary>File descriptor for LFDCLBPDNDF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LFDCLBPDNDFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFMRkRDTEJQRE5ERi5wcm90bxoRQUFLT0FJTk5HSEsucHJvdG8aEUxKR0VD",
            "UEZKTk5ELnByb3RvGhFIS0pJRENHTUtPRy5wcm90byJ2CgtMRkRDTEJQRE5E",
            "RhIhCgtGT0pJQ05FSERLTBgJIAEoCzIMLkxKR0VDUEZKTk5EEiEKC0lPSE1N",
            "T01NR0FQGAIgASgLMgwuQUFLT0FJTk5HSEsSIQoLRUZKSElJTEVDR0EYCyAB",
            "KAsyDC5IS0pJRENHTUtPR0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AAKOAINNGHKReflection.Descriptor, global::EggLink.DanhengServer.Proto.LJGECPFJNNDReflection.Descriptor, global::EggLink.DanhengServer.Proto.HKJIDCGMKOGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LFDCLBPDNDF), global::EggLink.DanhengServer.Proto.LFDCLBPDNDF.Parser, new[]{ "FOJICNEHDKL", "IOHMMOMMGAP", "EFJHIILECGA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LFDCLBPDNDF : pb::IMessage<LFDCLBPDNDF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LFDCLBPDNDF> _parser = new pb::MessageParser<LFDCLBPDNDF>(() => new LFDCLBPDNDF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LFDCLBPDNDF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LFDCLBPDNDFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LFDCLBPDNDF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LFDCLBPDNDF(LFDCLBPDNDF other) : this() {
      fOJICNEHDKL_ = other.fOJICNEHDKL_ != null ? other.fOJICNEHDKL_.Clone() : null;
      iOHMMOMMGAP_ = other.iOHMMOMMGAP_ != null ? other.iOHMMOMMGAP_.Clone() : null;
      eFJHIILECGA_ = other.eFJHIILECGA_ != null ? other.eFJHIILECGA_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LFDCLBPDNDF Clone() {
      return new LFDCLBPDNDF(this);
    }

    /// <summary>Field number for the "FOJICNEHDKL" field.</summary>
    public const int FOJICNEHDKLFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.LJGECPFJNND fOJICNEHDKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LJGECPFJNND FOJICNEHDKL {
      get { return fOJICNEHDKL_; }
      set {
        fOJICNEHDKL_ = value;
      }
    }

    /// <summary>Field number for the "IOHMMOMMGAP" field.</summary>
    public const int IOHMMOMMGAPFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.AAKOAINNGHK iOHMMOMMGAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AAKOAINNGHK IOHMMOMMGAP {
      get { return iOHMMOMMGAP_; }
      set {
        iOHMMOMMGAP_ = value;
      }
    }

    /// <summary>Field number for the "EFJHIILECGA" field.</summary>
    public const int EFJHIILECGAFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.HKJIDCGMKOG eFJHIILECGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKJIDCGMKOG EFJHIILECGA {
      get { return eFJHIILECGA_; }
      set {
        eFJHIILECGA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LFDCLBPDNDF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LFDCLBPDNDF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FOJICNEHDKL, other.FOJICNEHDKL)) return false;
      if (!object.Equals(IOHMMOMMGAP, other.IOHMMOMMGAP)) return false;
      if (!object.Equals(EFJHIILECGA, other.EFJHIILECGA)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (fOJICNEHDKL_ != null) hash ^= FOJICNEHDKL.GetHashCode();
      if (iOHMMOMMGAP_ != null) hash ^= IOHMMOMMGAP.GetHashCode();
      if (eFJHIILECGA_ != null) hash ^= EFJHIILECGA.GetHashCode();
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
      if (iOHMMOMMGAP_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IOHMMOMMGAP);
      }
      if (fOJICNEHDKL_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(FOJICNEHDKL);
      }
      if (eFJHIILECGA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EFJHIILECGA);
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
      if (iOHMMOMMGAP_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IOHMMOMMGAP);
      }
      if (fOJICNEHDKL_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(FOJICNEHDKL);
      }
      if (eFJHIILECGA_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(EFJHIILECGA);
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
      if (fOJICNEHDKL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FOJICNEHDKL);
      }
      if (iOHMMOMMGAP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IOHMMOMMGAP);
      }
      if (eFJHIILECGA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFJHIILECGA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LFDCLBPDNDF other) {
      if (other == null) {
        return;
      }
      if (other.fOJICNEHDKL_ != null) {
        if (fOJICNEHDKL_ == null) {
          FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
        }
        FOJICNEHDKL.MergeFrom(other.FOJICNEHDKL);
      }
      if (other.iOHMMOMMGAP_ != null) {
        if (iOHMMOMMGAP_ == null) {
          IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
        }
        IOHMMOMMGAP.MergeFrom(other.IOHMMOMMGAP);
      }
      if (other.eFJHIILECGA_ != null) {
        if (eFJHIILECGA_ == null) {
          EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
        }
        EFJHIILECGA.MergeFrom(other.EFJHIILECGA);
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
            if (iOHMMOMMGAP_ == null) {
              IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
            }
            input.ReadMessage(IOHMMOMMGAP);
            break;
          }
          case 74: {
            if (fOJICNEHDKL_ == null) {
              FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
            }
            input.ReadMessage(FOJICNEHDKL);
            break;
          }
          case 90: {
            if (eFJHIILECGA_ == null) {
              EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
            }
            input.ReadMessage(EFJHIILECGA);
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
            if (iOHMMOMMGAP_ == null) {
              IOHMMOMMGAP = new global::EggLink.DanhengServer.Proto.AAKOAINNGHK();
            }
            input.ReadMessage(IOHMMOMMGAP);
            break;
          }
          case 74: {
            if (fOJICNEHDKL_ == null) {
              FOJICNEHDKL = new global::EggLink.DanhengServer.Proto.LJGECPFJNND();
            }
            input.ReadMessage(FOJICNEHDKL);
            break;
          }
          case 90: {
            if (eFJHIILECGA_ == null) {
              EFJHIILECGA = new global::EggLink.DanhengServer.Proto.HKJIDCGMKOG();
            }
            input.ReadMessage(EFJHIILECGA);
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