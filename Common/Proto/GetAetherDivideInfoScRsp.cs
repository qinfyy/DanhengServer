// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAetherDivideInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAetherDivideInfoScRsp.proto</summary>
  public static partial class GetAetherDivideInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAetherDivideInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAetherDivideInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HZXRBZXRoZXJEaXZpZGVJbmZvU2NSc3AucHJvdG8aFUFldGhlclNraWxs",
            "SW5mby5wcm90bxocQWV0aGVyRGl2aWRlU3Bpcml0SW5mby5wcm90bxocQWV0",
            "aGVyRGl2aWRlTGluZXVwSW5mby5wcm90byKXAgoYR2V0QWV0aGVyRGl2aWRl",
            "SW5mb1NjUnNwEhMKC0pHUEhMSktHQUZDGAEgASgNEhMKC0RMRlBPREtHQkxI",
            "GAggASgNEhMKC0ZFQ0lIQkRDS0tFGAMgASgNEiUKC0VQTURGRkFLUE1CGAkg",
            "AygLMhAuQWV0aGVyU2tpbGxJbmZvEhMKC0lGQkpKT09PR09IGA4gASgNEiwK",
            "C0RHUEZETkxQTUVGGAogAygLMhcuQWV0aGVyRGl2aWRlU3Bpcml0SW5mbxIs",
            "CgtsaW5ldXBfbGlzdBgEIAMoCzIXLkFldGhlckRpdmlkZUxpbmV1cEluZm8S",
            "DwoHcmV0Y29kZRgCIAEoDRITCgtLQUlBTktMS05ETRgMIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherSkillInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideLineupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRsp), global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRsp.Parser, new[]{ "JGPHLJKGAFC", "DLFPODKGBLH", "FECIHBDCKKE", "EPMDFFAKPMB", "IFBJJOOOGOH", "DGPFDNLPMEF", "LineupList", "Retcode", "KAIANKLKNDM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAetherDivideInfoScRsp : pb::IMessage<GetAetherDivideInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAetherDivideInfoScRsp> _parser = new pb::MessageParser<GetAetherDivideInfoScRsp>(() => new GetAetherDivideInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAetherDivideInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp(GetAetherDivideInfoScRsp other) : this() {
      jGPHLJKGAFC_ = other.jGPHLJKGAFC_;
      dLFPODKGBLH_ = other.dLFPODKGBLH_;
      fECIHBDCKKE_ = other.fECIHBDCKKE_;
      ePMDFFAKPMB_ = other.ePMDFFAKPMB_.Clone();
      iFBJJOOOGOH_ = other.iFBJJOOOGOH_;
      dGPFDNLPMEF_ = other.dGPFDNLPMEF_.Clone();
      lineupList_ = other.lineupList_.Clone();
      retcode_ = other.retcode_;
      kAIANKLKNDM_ = other.kAIANKLKNDM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp Clone() {
      return new GetAetherDivideInfoScRsp(this);
    }

    /// <summary>Field number for the "JGPHLJKGAFC" field.</summary>
    public const int JGPHLJKGAFCFieldNumber = 1;
    private uint jGPHLJKGAFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JGPHLJKGAFC {
      get { return jGPHLJKGAFC_; }
      set {
        jGPHLJKGAFC_ = value;
      }
    }

    /// <summary>Field number for the "DLFPODKGBLH" field.</summary>
    public const int DLFPODKGBLHFieldNumber = 8;
    private uint dLFPODKGBLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLFPODKGBLH {
      get { return dLFPODKGBLH_; }
      set {
        dLFPODKGBLH_ = value;
      }
    }

    /// <summary>Field number for the "FECIHBDCKKE" field.</summary>
    public const int FECIHBDCKKEFieldNumber = 3;
    private uint fECIHBDCKKE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FECIHBDCKKE {
      get { return fECIHBDCKKE_; }
      set {
        fECIHBDCKKE_ = value;
      }
    }

    /// <summary>Field number for the "EPMDFFAKPMB" field.</summary>
    public const int EPMDFFAKPMBFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherSkillInfo> _repeated_ePMDFFAKPMB_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.AetherSkillInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo> ePMDFFAKPMB_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo> EPMDFFAKPMB {
      get { return ePMDFFAKPMB_; }
    }

    /// <summary>Field number for the "IFBJJOOOGOH" field.</summary>
    public const int IFBJJOOOGOHFieldNumber = 14;
    private uint iFBJJOOOGOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IFBJJOOOGOH {
      get { return iFBJJOOOGOH_; }
      set {
        iFBJJOOOGOH_ = value;
      }
    }

    /// <summary>Field number for the "DGPFDNLPMEF" field.</summary>
    public const int DGPFDNLPMEFFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> _repeated_dGPFDNLPMEF_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> dGPFDNLPMEF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> DGPFDNLPMEF {
      get { return dGPFDNLPMEF_; }
    }

    /// <summary>Field number for the "lineup_list" field.</summary>
    public const int LineupListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> _repeated_lineupList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> lineupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> LineupList {
      get { return lineupList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "KAIANKLKNDM" field.</summary>
    public const int KAIANKLKNDMFieldNumber = 12;
    private uint kAIANKLKNDM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAIANKLKNDM {
      get { return kAIANKLKNDM_; }
      set {
        kAIANKLKNDM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAetherDivideInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAetherDivideInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JGPHLJKGAFC != other.JGPHLJKGAFC) return false;
      if (DLFPODKGBLH != other.DLFPODKGBLH) return false;
      if (FECIHBDCKKE != other.FECIHBDCKKE) return false;
      if(!ePMDFFAKPMB_.Equals(other.ePMDFFAKPMB_)) return false;
      if (IFBJJOOOGOH != other.IFBJJOOOGOH) return false;
      if(!dGPFDNLPMEF_.Equals(other.dGPFDNLPMEF_)) return false;
      if(!lineupList_.Equals(other.lineupList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (KAIANKLKNDM != other.KAIANKLKNDM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JGPHLJKGAFC != 0) hash ^= JGPHLJKGAFC.GetHashCode();
      if (DLFPODKGBLH != 0) hash ^= DLFPODKGBLH.GetHashCode();
      if (FECIHBDCKKE != 0) hash ^= FECIHBDCKKE.GetHashCode();
      hash ^= ePMDFFAKPMB_.GetHashCode();
      if (IFBJJOOOGOH != 0) hash ^= IFBJJOOOGOH.GetHashCode();
      hash ^= dGPFDNLPMEF_.GetHashCode();
      hash ^= lineupList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (KAIANKLKNDM != 0) hash ^= KAIANKLKNDM.GetHashCode();
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
      if (JGPHLJKGAFC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JGPHLJKGAFC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (FECIHBDCKKE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FECIHBDCKKE);
      }
      lineupList_.WriteTo(output, _repeated_lineupList_codec);
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DLFPODKGBLH);
      }
      ePMDFFAKPMB_.WriteTo(output, _repeated_ePMDFFAKPMB_codec);
      dGPFDNLPMEF_.WriteTo(output, _repeated_dGPFDNLPMEF_codec);
      if (KAIANKLKNDM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAIANKLKNDM);
      }
      if (IFBJJOOOGOH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IFBJJOOOGOH);
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
      if (JGPHLJKGAFC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JGPHLJKGAFC);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (FECIHBDCKKE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FECIHBDCKKE);
      }
      lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
      if (DLFPODKGBLH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DLFPODKGBLH);
      }
      ePMDFFAKPMB_.WriteTo(ref output, _repeated_ePMDFFAKPMB_codec);
      dGPFDNLPMEF_.WriteTo(ref output, _repeated_dGPFDNLPMEF_codec);
      if (KAIANKLKNDM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAIANKLKNDM);
      }
      if (IFBJJOOOGOH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IFBJJOOOGOH);
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
      if (JGPHLJKGAFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JGPHLJKGAFC);
      }
      if (DLFPODKGBLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLFPODKGBLH);
      }
      if (FECIHBDCKKE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FECIHBDCKKE);
      }
      size += ePMDFFAKPMB_.CalculateSize(_repeated_ePMDFFAKPMB_codec);
      if (IFBJJOOOGOH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IFBJJOOOGOH);
      }
      size += dGPFDNLPMEF_.CalculateSize(_repeated_dGPFDNLPMEF_codec);
      size += lineupList_.CalculateSize(_repeated_lineupList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (KAIANKLKNDM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAIANKLKNDM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAetherDivideInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.JGPHLJKGAFC != 0) {
        JGPHLJKGAFC = other.JGPHLJKGAFC;
      }
      if (other.DLFPODKGBLH != 0) {
        DLFPODKGBLH = other.DLFPODKGBLH;
      }
      if (other.FECIHBDCKKE != 0) {
        FECIHBDCKKE = other.FECIHBDCKKE;
      }
      ePMDFFAKPMB_.Add(other.ePMDFFAKPMB_);
      if (other.IFBJJOOOGOH != 0) {
        IFBJJOOOGOH = other.IFBJJOOOGOH;
      }
      dGPFDNLPMEF_.Add(other.dGPFDNLPMEF_);
      lineupList_.Add(other.lineupList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.KAIANKLKNDM != 0) {
        KAIANKLKNDM = other.KAIANKLKNDM;
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
            JGPHLJKGAFC = input.ReadUInt32();
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 24: {
            FECIHBDCKKE = input.ReadUInt32();
            break;
          }
          case 34: {
            lineupList_.AddEntriesFrom(input, _repeated_lineupList_codec);
            break;
          }
          case 64: {
            DLFPODKGBLH = input.ReadUInt32();
            break;
          }
          case 74: {
            ePMDFFAKPMB_.AddEntriesFrom(input, _repeated_ePMDFFAKPMB_codec);
            break;
          }
          case 82: {
            dGPFDNLPMEF_.AddEntriesFrom(input, _repeated_dGPFDNLPMEF_codec);
            break;
          }
          case 96: {
            KAIANKLKNDM = input.ReadUInt32();
            break;
          }
          case 112: {
            IFBJJOOOGOH = input.ReadUInt32();
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
            JGPHLJKGAFC = input.ReadUInt32();
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 24: {
            FECIHBDCKKE = input.ReadUInt32();
            break;
          }
          case 34: {
            lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
            break;
          }
          case 64: {
            DLFPODKGBLH = input.ReadUInt32();
            break;
          }
          case 74: {
            ePMDFFAKPMB_.AddEntriesFrom(ref input, _repeated_ePMDFFAKPMB_codec);
            break;
          }
          case 82: {
            dGPFDNLPMEF_.AddEntriesFrom(ref input, _repeated_dGPFDNLPMEF_codec);
            break;
          }
          case 96: {
            KAIANKLKNDM = input.ReadUInt32();
            break;
          }
          case 112: {
            IFBJJOOOGOH = input.ReadUInt32();
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
