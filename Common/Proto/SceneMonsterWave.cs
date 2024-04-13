// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneMonsterWave.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneMonsterWave.proto</summary>
  public static partial class SceneMonsterWaveReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneMonsterWave.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneMonsterWaveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTY2VuZU1vbnN0ZXJXYXZlLnByb3RvGg5JdGVtTGlzdC5wcm90bxoSU2Nl",
            "bmVNb25zdGVyLnByb3RvGhtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8i",
            "pwEKEFNjZW5lTW9uc3RlcldhdmUSLQoNbW9uc3Rlcl9wYXJhbRgFIAEoCzIW",
            "LlNjZW5lTW9uc3RlcldhdmVQYXJhbRIjCgxtb25zdGVyX2xpc3QYCCADKAsy",
            "DS5TY2VuZU1vbnN0ZXISDwoHd2F2ZV9pZBgLIAEoDRIQCghzdGFnZV9pZBgJ",
            "IAEoDRIcCglkcm9wX2xpc3QYBiADKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterWaveParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneMonsterWave), global::EggLink.DanhengServer.Proto.SceneMonsterWave.Parser, new[]{ "MonsterParam", "MonsterList", "WaveId", "StageId", "DropList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneMonsterWave : pb::IMessage<SceneMonsterWave>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneMonsterWave> _parser = new pb::MessageParser<SceneMonsterWave>(() => new SceneMonsterWave());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneMonsterWave> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneMonsterWaveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave(SceneMonsterWave other) : this() {
      monsterParam_ = other.monsterParam_ != null ? other.monsterParam_.Clone() : null;
      monsterList_ = other.monsterList_.Clone();
      waveId_ = other.waveId_;
      stageId_ = other.stageId_;
      dropList_ = other.dropList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave Clone() {
      return new SceneMonsterWave(this);
    }

    /// <summary>Field number for the "monster_param" field.</summary>
    public const int MonsterParamFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam monsterParam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam MonsterParam {
      get { return monsterParam_; }
      set {
        monsterParam_ = value;
      }
    }

    /// <summary>Field number for the "monster_list" field.</summary>
    public const int MonsterListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneMonster> _repeated_monsterList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.SceneMonster.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster> monsterList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster> MonsterList {
      get { return monsterList_; }
    }

    /// <summary>Field number for the "wave_id" field.</summary>
    public const int WaveIdFieldNumber = 11;
    private uint waveId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaveId {
      get { return waveId_; }
      set {
        waveId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 9;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "drop_list" field.</summary>
    public const int DropListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemList> _repeated_dropList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.ItemList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> dropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> DropList {
      get { return dropList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneMonsterWave);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneMonsterWave other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MonsterParam, other.MonsterParam)) return false;
      if(!monsterList_.Equals(other.monsterList_)) return false;
      if (WaveId != other.WaveId) return false;
      if (StageId != other.StageId) return false;
      if(!dropList_.Equals(other.dropList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (monsterParam_ != null) hash ^= MonsterParam.GetHashCode();
      hash ^= monsterList_.GetHashCode();
      if (WaveId != 0) hash ^= WaveId.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= dropList_.GetHashCode();
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
      if (monsterParam_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MonsterParam);
      }
      dropList_.WriteTo(output, _repeated_dropList_codec);
      monsterList_.WriteTo(output, _repeated_monsterList_codec);
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (WaveId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WaveId);
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
      if (monsterParam_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MonsterParam);
      }
      dropList_.WriteTo(ref output, _repeated_dropList_codec);
      monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (WaveId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WaveId);
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
      if (monsterParam_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MonsterParam);
      }
      size += monsterList_.CalculateSize(_repeated_monsterList_codec);
      if (WaveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaveId);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += dropList_.CalculateSize(_repeated_dropList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneMonsterWave other) {
      if (other == null) {
        return;
      }
      if (other.monsterParam_ != null) {
        if (monsterParam_ == null) {
          MonsterParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
        }
        MonsterParam.MergeFrom(other.MonsterParam);
      }
      monsterList_.Add(other.monsterList_);
      if (other.WaveId != 0) {
        WaveId = other.WaveId;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      dropList_.Add(other.dropList_);
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
          case 42: {
            if (monsterParam_ == null) {
              MonsterParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
            }
            input.ReadMessage(MonsterParam);
            break;
          }
          case 50: {
            dropList_.AddEntriesFrom(input, _repeated_dropList_codec);
            break;
          }
          case 66: {
            monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 88: {
            WaveId = input.ReadUInt32();
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
          case 42: {
            if (monsterParam_ == null) {
              MonsterParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
            }
            input.ReadMessage(MonsterParam);
            break;
          }
          case 50: {
            dropList_.AddEntriesFrom(ref input, _repeated_dropList_codec);
            break;
          }
          case 66: {
            monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 88: {
            WaveId = input.ReadUInt32();
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
