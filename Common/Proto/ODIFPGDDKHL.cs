// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ODIFPGDDKHL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ODIFPGDDKHL.proto</summary>
  public static partial class ODIFPGDDKHLReflection {

    #region Descriptor
    /// <summary>File descriptor for ODIFPGDDKHL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ODIFPGDDKHLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPRElGUEdEREtITC5wcm90byI3CgtPRElGUEdEREtITBITCgtHTUdOR0dM",
            "RkdQUBgGIAEoDRITCgtDT0VDUE9IS0dEUBgCIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ODIFPGDDKHL), global::EggLink.DanhengServer.Proto.ODIFPGDDKHL.Parser, new[]{ "GMGNGGLFGPP", "COECPOHKGDP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ODIFPGDDKHL : pb::IMessage<ODIFPGDDKHL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ODIFPGDDKHL> _parser = new pb::MessageParser<ODIFPGDDKHL>(() => new ODIFPGDDKHL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ODIFPGDDKHL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ODIFPGDDKHLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ODIFPGDDKHL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ODIFPGDDKHL(ODIFPGDDKHL other) : this() {
      gMGNGGLFGPP_ = other.gMGNGGLFGPP_;
      cOECPOHKGDP_ = other.cOECPOHKGDP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ODIFPGDDKHL Clone() {
      return new ODIFPGDDKHL(this);
    }

    /// <summary>Field number for the "GMGNGGLFGPP" field.</summary>
    public const int GMGNGGLFGPPFieldNumber = 6;
    private uint gMGNGGLFGPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GMGNGGLFGPP {
      get { return gMGNGGLFGPP_; }
      set {
        gMGNGGLFGPP_ = value;
      }
    }

    /// <summary>Field number for the "COECPOHKGDP" field.</summary>
    public const int COECPOHKGDPFieldNumber = 2;
    private uint cOECPOHKGDP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COECPOHKGDP {
      get { return cOECPOHKGDP_; }
      set {
        cOECPOHKGDP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ODIFPGDDKHL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ODIFPGDDKHL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GMGNGGLFGPP != other.GMGNGGLFGPP) return false;
      if (COECPOHKGDP != other.COECPOHKGDP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GMGNGGLFGPP != 0) hash ^= GMGNGGLFGPP.GetHashCode();
      if (COECPOHKGDP != 0) hash ^= COECPOHKGDP.GetHashCode();
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
      if (COECPOHKGDP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(COECPOHKGDP);
      }
      if (GMGNGGLFGPP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GMGNGGLFGPP);
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
      if (COECPOHKGDP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(COECPOHKGDP);
      }
      if (GMGNGGLFGPP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GMGNGGLFGPP);
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
      if (GMGNGGLFGPP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GMGNGGLFGPP);
      }
      if (COECPOHKGDP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COECPOHKGDP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ODIFPGDDKHL other) {
      if (other == null) {
        return;
      }
      if (other.GMGNGGLFGPP != 0) {
        GMGNGGLFGPP = other.GMGNGGLFGPP;
      }
      if (other.COECPOHKGDP != 0) {
        COECPOHKGDP = other.COECPOHKGDP;
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
          case 16: {
            COECPOHKGDP = input.ReadUInt32();
            break;
          }
          case 48: {
            GMGNGGLFGPP = input.ReadUInt32();
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
          case 16: {
            COECPOHKGDP = input.ReadUInt32();
            break;
          }
          case 48: {
            GMGNGGLFGPP = input.ReadUInt32();
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