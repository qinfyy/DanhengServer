// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnhanceCommonRogueBuffScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnhanceCommonRogueBuffScRsp.proto</summary>
  public static partial class EnhanceCommonRogueBuffScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnhanceCommonRogueBuffScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnhanceCommonRogueBuffScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbmhhbmNlQ29tbW9uUm9ndWVCdWZmU2NSc3AucHJvdG8aE1JvZ3VlRHJv",
            "cEJ1ZmYucHJvdG8iaAobRW5oYW5jZUNvbW1vblJvZ3VlQnVmZlNjUnNwEhMK",
            "C0JGSkVNSUZBS05GGAwgASgIEg8KB3JldGNvZGUYASABKA0SIwoLR0xJQk9Q",
            "TUFHQUIYDiABKAsyDi5Sb2d1ZURyb3BCdWZmQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDropBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRsp), global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRsp.Parser, new[]{ "BFJEMIFAKNF", "Retcode", "GLIBOPMAGAB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnhanceCommonRogueBuffScRsp : pb::IMessage<EnhanceCommonRogueBuffScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnhanceCommonRogueBuffScRsp> _parser = new pb::MessageParser<EnhanceCommonRogueBuffScRsp>(() => new EnhanceCommonRogueBuffScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnhanceCommonRogueBuffScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnhanceCommonRogueBuffScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp(EnhanceCommonRogueBuffScRsp other) : this() {
      bFJEMIFAKNF_ = other.bFJEMIFAKNF_;
      retcode_ = other.retcode_;
      gLIBOPMAGAB_ = other.gLIBOPMAGAB_ != null ? other.gLIBOPMAGAB_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnhanceCommonRogueBuffScRsp Clone() {
      return new EnhanceCommonRogueBuffScRsp(this);
    }

    /// <summary>Field number for the "BFJEMIFAKNF" field.</summary>
    public const int BFJEMIFAKNFFieldNumber = 12;
    private bool bFJEMIFAKNF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BFJEMIFAKNF {
      get { return bFJEMIFAKNF_; }
      set {
        bFJEMIFAKNF_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GLIBOPMAGAB" field.</summary>
    public const int GLIBOPMAGABFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.RogueDropBuff gLIBOPMAGAB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDropBuff GLIBOPMAGAB {
      get { return gLIBOPMAGAB_; }
      set {
        gLIBOPMAGAB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnhanceCommonRogueBuffScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnhanceCommonRogueBuffScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BFJEMIFAKNF != other.BFJEMIFAKNF) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(GLIBOPMAGAB, other.GLIBOPMAGAB)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BFJEMIFAKNF != false) hash ^= BFJEMIFAKNF.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (gLIBOPMAGAB_ != null) hash ^= GLIBOPMAGAB.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (BFJEMIFAKNF != false) {
        output.WriteRawTag(96);
        output.WriteBool(BFJEMIFAKNF);
      }
      if (gLIBOPMAGAB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(GLIBOPMAGAB);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (BFJEMIFAKNF != false) {
        output.WriteRawTag(96);
        output.WriteBool(BFJEMIFAKNF);
      }
      if (gLIBOPMAGAB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(GLIBOPMAGAB);
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
      if (BFJEMIFAKNF != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (gLIBOPMAGAB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GLIBOPMAGAB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnhanceCommonRogueBuffScRsp other) {
      if (other == null) {
        return;
      }
      if (other.BFJEMIFAKNF != false) {
        BFJEMIFAKNF = other.BFJEMIFAKNF;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.gLIBOPMAGAB_ != null) {
        if (gLIBOPMAGAB_ == null) {
          GLIBOPMAGAB = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
        }
        GLIBOPMAGAB.MergeFrom(other.GLIBOPMAGAB);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            BFJEMIFAKNF = input.ReadBool();
            break;
          }
          case 114: {
            if (gLIBOPMAGAB_ == null) {
              GLIBOPMAGAB = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(GLIBOPMAGAB);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 96: {
            BFJEMIFAKNF = input.ReadBool();
            break;
          }
          case 114: {
            if (gLIBOPMAGAB_ == null) {
              GLIBOPMAGAB = new global::EggLink.DanhengServer.Proto.RogueDropBuff();
            }
            input.ReadMessage(GLIBOPMAGAB);
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