// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeartDialScriptChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeartDialScriptChangeScNotify.proto</summary>
  public static partial class HeartDialScriptChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HeartDialScriptChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartDialScriptChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxobSGVhcnRE",
            "aWFsVW5sb2NrU3RhdHVzLnByb3RvGhFIUE1BRlBHTkxQSC5wcm90bxoRR01G",
            "TkhOR0xPUEcucHJvdG8aEUJIRUhETkdPUEZCLnByb3RvIrUBCh1IZWFydERp",
            "YWxTY3JpcHRDaGFuZ2VTY05vdGlmeRIrCgtFSEhORkhLT0dKSxgMIAEoDjIW",
            "LkhlYXJ0RGlhbFVubG9ja1N0YXR1cxIhCgtIQ0xPUEROTElDRBgBIAMoCzIM",
            "LkhQTUFGUEdOTFBIEiEKC0lHQlBGS09IRkRKGAsgAygLMgwuQkhFSEROR09Q",
            "RkISIQoLTUpBQ05OSEhDUFAYByADKAsyDC5HTUZOSE5HTE9QR0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeartDialUnlockStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.HPMAFPGNLPHReflection.Descriptor, global::EggLink.DanhengServer.Proto.GMFNHNGLOPGReflection.Descriptor, global::EggLink.DanhengServer.Proto.BHEHDNGOPFBReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify), global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify.Parser, new[]{ "EHHNFHKOGJK", "HCLOPDNLICD", "IGBPFKOHFDJ", "MJACNNHHCPP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeartDialScriptChangeScNotify : pb::IMessage<HeartDialScriptChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeartDialScriptChangeScNotify> _parser = new pb::MessageParser<HeartDialScriptChangeScNotify>(() => new HeartDialScriptChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeartDialScriptChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify(HeartDialScriptChangeScNotify other) : this() {
      eHHNFHKOGJK_ = other.eHHNFHKOGJK_;
      hCLOPDNLICD_ = other.hCLOPDNLICD_.Clone();
      iGBPFKOHFDJ_ = other.iGBPFKOHFDJ_.Clone();
      mJACNNHHCPP_ = other.mJACNNHHCPP_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify Clone() {
      return new HeartDialScriptChangeScNotify(this);
    }

    /// <summary>Field number for the "EHHNFHKOGJK" field.</summary>
    public const int EHHNFHKOGJKFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus eHHNFHKOGJK_ = global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus EHHNFHKOGJK {
      get { return eHHNFHKOGJK_; }
      set {
        eHHNFHKOGJK_ = value;
      }
    }

    /// <summary>Field number for the "HCLOPDNLICD" field.</summary>
    public const int HCLOPDNLICDFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HPMAFPGNLPH> _repeated_hCLOPDNLICD_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.HPMAFPGNLPH.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HPMAFPGNLPH> hCLOPDNLICD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HPMAFPGNLPH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HPMAFPGNLPH> HCLOPDNLICD {
      get { return hCLOPDNLICD_; }
    }

    /// <summary>Field number for the "IGBPFKOHFDJ" field.</summary>
    public const int IGBPFKOHFDJFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BHEHDNGOPFB> _repeated_iGBPFKOHFDJ_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.BHEHDNGOPFB.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BHEHDNGOPFB> iGBPFKOHFDJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BHEHDNGOPFB>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BHEHDNGOPFB> IGBPFKOHFDJ {
      get { return iGBPFKOHFDJ_; }
    }

    /// <summary>Field number for the "MJACNNHHCPP" field.</summary>
    public const int MJACNNHHCPPFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GMFNHNGLOPG> _repeated_mJACNNHHCPP_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.GMFNHNGLOPG.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMFNHNGLOPG> mJACNNHHCPP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMFNHNGLOPG>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GMFNHNGLOPG> MJACNNHHCPP {
      get { return mJACNNHHCPP_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeartDialScriptChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeartDialScriptChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EHHNFHKOGJK != other.EHHNFHKOGJK) return false;
      if(!hCLOPDNLICD_.Equals(other.hCLOPDNLICD_)) return false;
      if(!iGBPFKOHFDJ_.Equals(other.iGBPFKOHFDJ_)) return false;
      if(!mJACNNHHCPP_.Equals(other.mJACNNHHCPP_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EHHNFHKOGJK != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) hash ^= EHHNFHKOGJK.GetHashCode();
      hash ^= hCLOPDNLICD_.GetHashCode();
      hash ^= iGBPFKOHFDJ_.GetHashCode();
      hash ^= mJACNNHHCPP_.GetHashCode();
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
      hCLOPDNLICD_.WriteTo(output, _repeated_hCLOPDNLICD_codec);
      mJACNNHHCPP_.WriteTo(output, _repeated_mJACNNHHCPP_codec);
      iGBPFKOHFDJ_.WriteTo(output, _repeated_iGBPFKOHFDJ_codec);
      if (EHHNFHKOGJK != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) EHHNFHKOGJK);
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
      hCLOPDNLICD_.WriteTo(ref output, _repeated_hCLOPDNLICD_codec);
      mJACNNHHCPP_.WriteTo(ref output, _repeated_mJACNNHHCPP_codec);
      iGBPFKOHFDJ_.WriteTo(ref output, _repeated_iGBPFKOHFDJ_codec);
      if (EHHNFHKOGJK != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) EHHNFHKOGJK);
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
      if (EHHNFHKOGJK != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EHHNFHKOGJK);
      }
      size += hCLOPDNLICD_.CalculateSize(_repeated_hCLOPDNLICD_codec);
      size += iGBPFKOHFDJ_.CalculateSize(_repeated_iGBPFKOHFDJ_codec);
      size += mJACNNHHCPP_.CalculateSize(_repeated_mJACNNHHCPP_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeartDialScriptChangeScNotify other) {
      if (other == null) {
        return;
      }
      if (other.EHHNFHKOGJK != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        EHHNFHKOGJK = other.EHHNFHKOGJK;
      }
      hCLOPDNLICD_.Add(other.hCLOPDNLICD_);
      iGBPFKOHFDJ_.Add(other.iGBPFKOHFDJ_);
      mJACNNHHCPP_.Add(other.mJACNNHHCPP_);
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
            hCLOPDNLICD_.AddEntriesFrom(input, _repeated_hCLOPDNLICD_codec);
            break;
          }
          case 58: {
            mJACNNHHCPP_.AddEntriesFrom(input, _repeated_mJACNNHHCPP_codec);
            break;
          }
          case 90: {
            iGBPFKOHFDJ_.AddEntriesFrom(input, _repeated_iGBPFKOHFDJ_codec);
            break;
          }
          case 96: {
            EHHNFHKOGJK = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
            hCLOPDNLICD_.AddEntriesFrom(ref input, _repeated_hCLOPDNLICD_codec);
            break;
          }
          case 58: {
            mJACNNHHCPP_.AddEntriesFrom(ref input, _repeated_mJACNNHHCPP_codec);
            break;
          }
          case 90: {
            iGBPFKOHFDJ_.AddEntriesFrom(ref input, _repeated_iGBPFKOHFDJ_codec);
            break;
          }
          case 96: {
            EHHNFHKOGJK = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
