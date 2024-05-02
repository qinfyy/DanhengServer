// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartChallengeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartChallengeScRsp.proto</summary>
  public static partial class StartChallengeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartChallengeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartChallengeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTdGFydENoYWxsZW5nZVNjUnNwLnByb3RvGhJDdXJDaGFsbGVuZ2UucHJv",
            "dG8aD1NjZW5lSW5mby5wcm90bxoQTGluZXVwSW5mby5wcm90byKEAQoTU3Rh",
            "cnRDaGFsbGVuZ2VTY1JzcBIZCgVzY2VuZRgDIAEoCzIKLlNjZW5lSW5mbxIb",
            "CgZsaW5ldXAYAiABKAsyCy5MaW5ldXBJbmZvEg8KB3JldGNvZGUYASABKA0S",
            "JAoNY3VyX2NoYWxsZW5nZRgKIAEoCzINLkN1ckNoYWxsZW5nZUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CurChallengeReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartChallengeScRsp), global::EggLink.DanhengServer.Proto.StartChallengeScRsp.Parser, new[]{ "Scene", "Lineup", "Retcode", "CurChallenge" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartChallengeScRsp : pb::IMessage<StartChallengeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartChallengeScRsp> _parser = new pb::MessageParser<StartChallengeScRsp>(() => new StartChallengeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartChallengeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartChallengeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp(StartChallengeScRsp other) : this() {
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      lineup_ = other.lineup_ != null ? other.lineup_.Clone() : null;
      retcode_ = other.retcode_;
      curChallenge_ = other.curChallenge_ != null ? other.curChallenge_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeScRsp Clone() {
      return new StartChallengeScRsp(this);
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.SceneInfo scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneInfo Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "lineup" field.</summary>
    public const int LineupFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.LineupInfo lineup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo Lineup {
      get { return lineup_; }
      set {
        lineup_ = value;
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

    /// <summary>Field number for the "cur_challenge" field.</summary>
    public const int CurChallengeFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.CurChallenge curChallenge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CurChallenge CurChallenge {
      get { return curChallenge_; }
      set {
        curChallenge_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartChallengeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartChallengeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Scene, other.Scene)) return false;
      if (!object.Equals(Lineup, other.Lineup)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(CurChallenge, other.CurChallenge)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (scene_ != null) hash ^= Scene.GetHashCode();
      if (lineup_ != null) hash ^= Lineup.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (curChallenge_ != null) hash ^= CurChallenge.GetHashCode();
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
      if (lineup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lineup);
      }
      if (scene_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Scene);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CurChallenge);
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
      if (lineup_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lineup);
      }
      if (scene_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Scene);
      }
      if (curChallenge_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CurChallenge);
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
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
      if (lineup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lineup);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (curChallenge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurChallenge);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartChallengeScRsp other) {
      if (other == null) {
        return;
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
        }
        Scene.MergeFrom(other.Scene);
      }
      if (other.lineup_ != null) {
        if (lineup_ == null) {
          Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        Lineup.MergeFrom(other.Lineup);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.curChallenge_ != null) {
        if (curChallenge_ == null) {
          CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
        }
        CurChallenge.MergeFrom(other.CurChallenge);
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
          case 18: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 26: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 82: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
          case 18: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 26: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
            break;
          }
          case 82: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
