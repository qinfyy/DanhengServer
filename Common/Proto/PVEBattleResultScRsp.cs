// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PVEBattleResultScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PVEBattleResultScRsp.proto</summary>
  public static partial class PVEBattleResultScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PVEBattleResultScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PVEBattleResultScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQVkVCYXR0bGVSZXN1bHRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8a",
            "EkJhdHRsZUF2YXRhci5wcm90bxoVQmF0dGxlRW5kU3RhdHVzLnByb3RvIvkC",
            "ChRQVkVCYXR0bGVSZXN1bHRTY1JzcBIPCgdyZXRjb2RlGAogASgNEhsKE21p",
            "c21hdGNoX3R1cm5fY291bnQYDSABKA0SEwoLYmluX3ZlcnNpb24YAiABKAkS",
            "EAoIZXZlbnRfaWQYBiABKA0SEAoIc3RhZ2VfaWQYBSABKA0SKQoSYmF0dGxl",
            "X2F2YXRhcl9saXN0GA8gAygLMg0uQmF0dGxlQXZhdGFyEiQKCmVuZF9zdGF0",
            "dXMYCCABKA4yEC5CYXR0bGVFbmRTdGF0dXMSEQoJYmF0dGxlX2lkGAsgASgN",
            "EhMKC3Jlc192ZXJzaW9uGAQgASgJEhcKD2NoZWNrX2lkZW50aWNhbBgOIAEo",
            "CBIcCglkcm9wX2RhdGEYASABKAsyCS5JdGVtTGlzdBIXCgR1bmsxGAcgASgL",
            "MgkuSXRlbUxpc3QSFwoEdW5rMhgMIAEoCzIJLkl0ZW1MaXN0EhgKBHVuazMY",
            "4gwgASgLMgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleAvatarReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEndStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PVEBattleResultScRsp), global::EggLink.DanhengServer.Proto.PVEBattleResultScRsp.Parser, new[]{ "Retcode", "MismatchTurnCount", "BinVersion", "EventId", "StageId", "BattleAvatarList", "EndStatus", "BattleId", "ResVersion", "CheckIdentical", "DropData", "Unk1", "Unk2", "Unk3" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PVEBattleResultScRsp : pb::IMessage<PVEBattleResultScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PVEBattleResultScRsp> _parser = new pb::MessageParser<PVEBattleResultScRsp>(() => new PVEBattleResultScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PVEBattleResultScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PVEBattleResultScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultScRsp(PVEBattleResultScRsp other) : this() {
      retcode_ = other.retcode_;
      mismatchTurnCount_ = other.mismatchTurnCount_;
      binVersion_ = other.binVersion_;
      eventId_ = other.eventId_;
      stageId_ = other.stageId_;
      battleAvatarList_ = other.battleAvatarList_.Clone();
      endStatus_ = other.endStatus_;
      battleId_ = other.battleId_;
      resVersion_ = other.resVersion_;
      checkIdentical_ = other.checkIdentical_;
      dropData_ = other.dropData_ != null ? other.dropData_.Clone() : null;
      unk1_ = other.unk1_ != null ? other.unk1_.Clone() : null;
      unk2_ = other.unk2_ != null ? other.unk2_.Clone() : null;
      unk3_ = other.unk3_ != null ? other.unk3_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultScRsp Clone() {
      return new PVEBattleResultScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "mismatch_turn_count" field.</summary>
    public const int MismatchTurnCountFieldNumber = 13;
    private uint mismatchTurnCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MismatchTurnCount {
      get { return mismatchTurnCount_; }
      set {
        mismatchTurnCount_ = value;
      }
    }

    /// <summary>Field number for the "bin_version" field.</summary>
    public const int BinVersionFieldNumber = 2;
    private string binVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BinVersion {
      get { return binVersion_; }
      set {
        binVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 6;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 5;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "battle_avatar_list" field.</summary>
    public const int BattleAvatarListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleAvatar> _repeated_battleAvatarList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.BattleAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> battleAvatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> BattleAvatarList {
      get { return battleAvatarList_; }
    }

    /// <summary>Field number for the "end_status" field.</summary>
    public const int EndStatusFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.BattleEndStatus endStatus_ = global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEndStatus EndStatus {
      get { return endStatus_; }
      set {
        endStatus_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 11;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "res_version" field.</summary>
    public const int ResVersionFieldNumber = 4;
    private string resVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResVersion {
      get { return resVersion_; }
      set {
        resVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "check_identical" field.</summary>
    public const int CheckIdenticalFieldNumber = 14;
    private bool checkIdentical_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CheckIdentical {
      get { return checkIdentical_; }
      set {
        checkIdentical_ = value;
      }
    }

    /// <summary>Field number for the "drop_data" field.</summary>
    public const int DropDataFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ItemList dropData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList DropData {
      get { return dropData_; }
      set {
        dropData_ = value;
      }
    }

    /// <summary>Field number for the "unk1" field.</summary>
    public const int Unk1FieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ItemList unk1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Unk1 {
      get { return unk1_; }
      set {
        unk1_ = value;
      }
    }

    /// <summary>Field number for the "unk2" field.</summary>
    public const int Unk2FieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ItemList unk2_;
    /// <summary>
    /// extra_drop_data
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Unk2 {
      get { return unk2_; }
      set {
        unk2_ = value;
      }
    }

    /// <summary>Field number for the "unk3" field.</summary>
    public const int Unk3FieldNumber = 1634;
    private global::EggLink.DanhengServer.Proto.ItemList unk3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Unk3 {
      get { return unk3_; }
      set {
        unk3_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PVEBattleResultScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PVEBattleResultScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (MismatchTurnCount != other.MismatchTurnCount) return false;
      if (BinVersion != other.BinVersion) return false;
      if (EventId != other.EventId) return false;
      if (StageId != other.StageId) return false;
      if(!battleAvatarList_.Equals(other.battleAvatarList_)) return false;
      if (EndStatus != other.EndStatus) return false;
      if (BattleId != other.BattleId) return false;
      if (ResVersion != other.ResVersion) return false;
      if (CheckIdentical != other.CheckIdentical) return false;
      if (!object.Equals(DropData, other.DropData)) return false;
      if (!object.Equals(Unk1, other.Unk1)) return false;
      if (!object.Equals(Unk2, other.Unk2)) return false;
      if (!object.Equals(Unk3, other.Unk3)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (MismatchTurnCount != 0) hash ^= MismatchTurnCount.GetHashCode();
      if (BinVersion.Length != 0) hash ^= BinVersion.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= battleAvatarList_.GetHashCode();
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) hash ^= EndStatus.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      if (ResVersion.Length != 0) hash ^= ResVersion.GetHashCode();
      if (CheckIdentical != false) hash ^= CheckIdentical.GetHashCode();
      if (dropData_ != null) hash ^= DropData.GetHashCode();
      if (unk1_ != null) hash ^= Unk1.GetHashCode();
      if (unk2_ != null) hash ^= Unk2.GetHashCode();
      if (unk3_ != null) hash ^= Unk3.GetHashCode();
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
      if (dropData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DropData);
      }
      if (BinVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BinVersion);
      }
      if (ResVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResVersion);
      }
      if (StageId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(StageId);
      }
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (unk1_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk1);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) EndStatus);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (BattleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BattleId);
      }
      if (unk2_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk2);
      }
      if (MismatchTurnCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MismatchTurnCount);
      }
      if (CheckIdentical != false) {
        output.WriteRawTag(112);
        output.WriteBool(CheckIdentical);
      }
      battleAvatarList_.WriteTo(output, _repeated_battleAvatarList_codec);
      if (unk3_ != null) {
        output.WriteRawTag(146, 102);
        output.WriteMessage(Unk3);
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
      if (dropData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DropData);
      }
      if (BinVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BinVersion);
      }
      if (ResVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResVersion);
      }
      if (StageId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(StageId);
      }
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (unk1_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk1);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) EndStatus);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (BattleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BattleId);
      }
      if (unk2_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk2);
      }
      if (MismatchTurnCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MismatchTurnCount);
      }
      if (CheckIdentical != false) {
        output.WriteRawTag(112);
        output.WriteBool(CheckIdentical);
      }
      battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
      if (unk3_ != null) {
        output.WriteRawTag(146, 102);
        output.WriteMessage(Unk3);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (MismatchTurnCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MismatchTurnCount);
      }
      if (BinVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BinVersion);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EndStatus);
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      if (ResVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResVersion);
      }
      if (CheckIdentical != false) {
        size += 1 + 1;
      }
      if (dropData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DropData);
      }
      if (unk1_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk1);
      }
      if (unk2_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2);
      }
      if (unk3_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Unk3);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PVEBattleResultScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.MismatchTurnCount != 0) {
        MismatchTurnCount = other.MismatchTurnCount;
      }
      if (other.BinVersion.Length != 0) {
        BinVersion = other.BinVersion;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      battleAvatarList_.Add(other.battleAvatarList_);
      if (other.EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        EndStatus = other.EndStatus;
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      if (other.ResVersion.Length != 0) {
        ResVersion = other.ResVersion;
      }
      if (other.CheckIdentical != false) {
        CheckIdentical = other.CheckIdentical;
      }
      if (other.dropData_ != null) {
        if (dropData_ == null) {
          DropData = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        DropData.MergeFrom(other.DropData);
      }
      if (other.unk1_ != null) {
        if (unk1_ == null) {
          Unk1 = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Unk1.MergeFrom(other.Unk1);
      }
      if (other.unk2_ != null) {
        if (unk2_ == null) {
          Unk2 = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Unk2.MergeFrom(other.Unk2);
      }
      if (other.unk3_ != null) {
        if (unk3_ == null) {
          Unk3 = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Unk3.MergeFrom(other.Unk3);
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
            if (dropData_ == null) {
              DropData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(DropData);
            break;
          }
          case 18: {
            BinVersion = input.ReadString();
            break;
          }
          case 34: {
            ResVersion = input.ReadString();
            break;
          }
          case 40: {
            StageId = input.ReadUInt32();
            break;
          }
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (unk1_ == null) {
              Unk1 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk1);
            break;
          }
          case 64: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (unk2_ == null) {
              Unk2 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk2);
            break;
          }
          case 104: {
            MismatchTurnCount = input.ReadUInt32();
            break;
          }
          case 112: {
            CheckIdentical = input.ReadBool();
            break;
          }
          case 122: {
            battleAvatarList_.AddEntriesFrom(input, _repeated_battleAvatarList_codec);
            break;
          }
          case 13074: {
            if (unk3_ == null) {
              Unk3 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk3);
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
            if (dropData_ == null) {
              DropData = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(DropData);
            break;
          }
          case 18: {
            BinVersion = input.ReadString();
            break;
          }
          case 34: {
            ResVersion = input.ReadString();
            break;
          }
          case 40: {
            StageId = input.ReadUInt32();
            break;
          }
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (unk1_ == null) {
              Unk1 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk1);
            break;
          }
          case 64: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (unk2_ == null) {
              Unk2 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk2);
            break;
          }
          case 104: {
            MismatchTurnCount = input.ReadUInt32();
            break;
          }
          case 112: {
            CheckIdentical = input.ReadBool();
            break;
          }
          case 122: {
            battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
            break;
          }
          case 13074: {
            if (unk3_ == null) {
              Unk3 = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Unk3);
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
