// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NOKNDGIGEHN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NOKNDGIGEHN.proto</summary>
  public static partial class NOKNDGIGEHNReflection {

    #region Descriptor
    /// <summary>File descriptor for NOKNDGIGEHN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NOKNDGIGEHNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOT0tOREdJR0VITi5wcm90bxoOSXRlbUxpc3QucHJvdG8iVQoLTk9LTkRH",
            "SUdFSE4SEwoLUE5LTkRGSkdHTEsYCSABKA0SHAoJaXRlbV9saXN0GAogASgL",
            "MgkuSXRlbUxpc3QSEwoLSEFHRUpGQkRPS1AYDiABKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NOKNDGIGEHN), global::EggLink.DanhengServer.Proto.NOKNDGIGEHN.Parser, new[]{ "PNKNDFJGGLK", "ItemList", "HAGEJFBDOKP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NOKNDGIGEHN : pb::IMessage<NOKNDGIGEHN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NOKNDGIGEHN> _parser = new pb::MessageParser<NOKNDGIGEHN>(() => new NOKNDGIGEHN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NOKNDGIGEHN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NOKNDGIGEHNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOKNDGIGEHN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOKNDGIGEHN(NOKNDGIGEHN other) : this() {
      pNKNDFJGGLK_ = other.pNKNDFJGGLK_;
      itemList_ = other.itemList_ != null ? other.itemList_.Clone() : null;
      hAGEJFBDOKP_ = other.hAGEJFBDOKP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOKNDGIGEHN Clone() {
      return new NOKNDGIGEHN(this);
    }

    /// <summary>Field number for the "PNKNDFJGGLK" field.</summary>
    public const int PNKNDFJGGLKFieldNumber = 9;
    private uint pNKNDFJGGLK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PNKNDFJGGLK {
      get { return pNKNDFJGGLK_; }
      set {
        pNKNDFJGGLK_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList itemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ItemList {
      get { return itemList_; }
      set {
        itemList_ = value;
      }
    }

    /// <summary>Field number for the "HAGEJFBDOKP" field.</summary>
    public const int HAGEJFBDOKPFieldNumber = 14;
    private uint hAGEJFBDOKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HAGEJFBDOKP {
      get { return hAGEJFBDOKP_; }
      set {
        hAGEJFBDOKP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NOKNDGIGEHN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NOKNDGIGEHN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PNKNDFJGGLK != other.PNKNDFJGGLK) return false;
      if (!object.Equals(ItemList, other.ItemList)) return false;
      if (HAGEJFBDOKP != other.HAGEJFBDOKP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PNKNDFJGGLK != 0) hash ^= PNKNDFJGGLK.GetHashCode();
      if (itemList_ != null) hash ^= ItemList.GetHashCode();
      if (HAGEJFBDOKP != 0) hash ^= HAGEJFBDOKP.GetHashCode();
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
      if (PNKNDFJGGLK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PNKNDFJGGLK);
      }
      if (itemList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ItemList);
      }
      if (HAGEJFBDOKP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HAGEJFBDOKP);
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
      if (PNKNDFJGGLK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PNKNDFJGGLK);
      }
      if (itemList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ItemList);
      }
      if (HAGEJFBDOKP != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HAGEJFBDOKP);
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
      if (PNKNDFJGGLK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PNKNDFJGGLK);
      }
      if (itemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemList);
      }
      if (HAGEJFBDOKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HAGEJFBDOKP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NOKNDGIGEHN other) {
      if (other == null) {
        return;
      }
      if (other.PNKNDFJGGLK != 0) {
        PNKNDFJGGLK = other.PNKNDFJGGLK;
      }
      if (other.itemList_ != null) {
        if (itemList_ == null) {
          ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ItemList.MergeFrom(other.ItemList);
      }
      if (other.HAGEJFBDOKP != 0) {
        HAGEJFBDOKP = other.HAGEJFBDOKP;
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
          case 72: {
            PNKNDFJGGLK = input.ReadUInt32();
            break;
          }
          case 82: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 112: {
            HAGEJFBDOKP = input.ReadUInt32();
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
          case 72: {
            PNKNDFJGGLK = input.ReadUInt32();
            break;
          }
          case 82: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 112: {
            HAGEJFBDOKP = input.ReadUInt32();
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
