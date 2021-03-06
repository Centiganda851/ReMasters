// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/TrainerBase.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/TrainerBase.proto</summary>
  public static partial class TrainerBaseReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/TrainerBase.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainerBaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90by9UcmFpbmVyQmFzZS5wcm90bxIMUmVNYXN0ZXJzTGliIugBCgtU",
            "cmFpbmVyQmFzZRIXCg90cmFpbmVyX2Jhc2VfaWQYASABKAQSEAoIYWN0b3Jf",
            "aWQYAiABKAkSFwoPdHJhaW5lcl9uYW1lX2lkGAMgASgJEgoKAnU0GAQgASgF",
            "EgoKAnU1GAUgASgJEgoKAnU2GAYgASgFEgoKAnU3GAcgASgFEg4KBmdlbmRl",
            "chgIIAEoBRITCgtwb2tlYmFsbF9pZBgJIAEoCRISCgppc19nZW5lcmljGAog",
            "ASgFEhUKDWJhdHRsZV9iZ21faWQYCyABKAkSFQoNcmVzdWx0X2JnbV9pZBgM",
            "IAEoCSI+ChBUcmFpbmVyQmFzZVRhYmxlEioKB2VudHJpZXMYASADKAsyGS5S",
            "ZU1hc3RlcnNMaWIuVHJhaW5lckJhc2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TrainerBase), global::ReMastersLib.TrainerBase.Parser, new[]{ "TrainerBaseId", "ActorId", "TrainerNameId", "U4", "U5", "U6", "U7", "Gender", "PokeballId", "IsGeneric", "BattleBgmId", "ResultBgmId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TrainerBaseTable), global::ReMastersLib.TrainerBaseTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrainerBase : pb::IMessage<TrainerBase> {
    private static readonly pb::MessageParser<TrainerBase> _parser = new pb::MessageParser<TrainerBase>(() => new TrainerBase());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrainerBase> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TrainerBaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBase() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBase(TrainerBase other) : this() {
      trainerBaseId_ = other.trainerBaseId_;
      actorId_ = other.actorId_;
      trainerNameId_ = other.trainerNameId_;
      u4_ = other.u4_;
      u5_ = other.u5_;
      u6_ = other.u6_;
      u7_ = other.u7_;
      gender_ = other.gender_;
      pokeballId_ = other.pokeballId_;
      isGeneric_ = other.isGeneric_;
      battleBgmId_ = other.battleBgmId_;
      resultBgmId_ = other.resultBgmId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBase Clone() {
      return new TrainerBase(this);
    }

    /// <summary>Field number for the "trainer_base_id" field.</summary>
    public const int TrainerBaseIdFieldNumber = 1;
    private ulong trainerBaseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TrainerBaseId {
      get { return trainerBaseId_; }
      set {
        trainerBaseId_ = value;
      }
    }

    /// <summary>Field number for the "actor_id" field.</summary>
    public const int ActorIdFieldNumber = 2;
    private string actorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActorId {
      get { return actorId_; }
      set {
        actorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "trainer_name_id" field.</summary>
    public const int TrainerNameIdFieldNumber = 3;
    private string trainerNameId_ = "";
    /// <summary>
    /// trainer_name_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TrainerNameId {
      get { return trainerNameId_; }
      set {
        trainerNameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private int u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U4 {
      get { return u4_; }
      set {
        u4_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private string u5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string U5 {
      get { return u5_; }
      set {
        u5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 6;
    private int u6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 7;
    private int u7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U7 {
      get { return u7_; }
      set {
        u7_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 8;
    private int gender_;
    /// <summary>
    /// 1 for male, 2 for female
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "pokeball_id" field.</summary>
    public const int PokeballIdFieldNumber = 9;
    private string pokeballId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PokeballId {
      get { return pokeballId_; }
      set {
        pokeballId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_generic" field.</summary>
    public const int IsGenericFieldNumber = 10;
    private int isGeneric_;
    /// <summary>
    /// 1 for generic trainers, else 0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int IsGeneric {
      get { return isGeneric_; }
      set {
        isGeneric_ = value;
      }
    }

    /// <summary>Field number for the "battle_bgm_id" field.</summary>
    public const int BattleBgmIdFieldNumber = 11;
    private string battleBgmId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BattleBgmId {
      get { return battleBgmId_; }
      set {
        battleBgmId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result_bgm_id" field.</summary>
    public const int ResultBgmIdFieldNumber = 12;
    private string resultBgmId_ = "";
    /// <summary>
    /// battle result theme
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResultBgmId {
      get { return resultBgmId_; }
      set {
        resultBgmId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrainerBase);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrainerBase other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TrainerBaseId != other.TrainerBaseId) return false;
      if (ActorId != other.ActorId) return false;
      if (TrainerNameId != other.TrainerNameId) return false;
      if (U4 != other.U4) return false;
      if (U5 != other.U5) return false;
      if (U6 != other.U6) return false;
      if (U7 != other.U7) return false;
      if (Gender != other.Gender) return false;
      if (PokeballId != other.PokeballId) return false;
      if (IsGeneric != other.IsGeneric) return false;
      if (BattleBgmId != other.BattleBgmId) return false;
      if (ResultBgmId != other.ResultBgmId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TrainerBaseId != 0UL) hash ^= TrainerBaseId.GetHashCode();
      if (ActorId.Length != 0) hash ^= ActorId.GetHashCode();
      if (TrainerNameId.Length != 0) hash ^= TrainerNameId.GetHashCode();
      if (U4 != 0) hash ^= U4.GetHashCode();
      if (U5.Length != 0) hash ^= U5.GetHashCode();
      if (U6 != 0) hash ^= U6.GetHashCode();
      if (U7 != 0) hash ^= U7.GetHashCode();
      if (Gender != 0) hash ^= Gender.GetHashCode();
      if (PokeballId.Length != 0) hash ^= PokeballId.GetHashCode();
      if (IsGeneric != 0) hash ^= IsGeneric.GetHashCode();
      if (BattleBgmId.Length != 0) hash ^= BattleBgmId.GetHashCode();
      if (ResultBgmId.Length != 0) hash ^= ResultBgmId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TrainerBaseId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TrainerBaseId);
      }
      if (ActorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ActorId);
      }
      if (TrainerNameId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TrainerNameId);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (U5.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(U7);
      }
      if (Gender != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Gender);
      }
      if (PokeballId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PokeballId);
      }
      if (IsGeneric != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(IsGeneric);
      }
      if (BattleBgmId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(BattleBgmId);
      }
      if (ResultBgmId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ResultBgmId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TrainerBaseId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TrainerBaseId);
      }
      if (ActorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActorId);
      }
      if (TrainerNameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TrainerNameId);
      }
      if (U4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U4);
      }
      if (U5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(U5);
      }
      if (U6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U6);
      }
      if (U7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U7);
      }
      if (Gender != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gender);
      }
      if (PokeballId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PokeballId);
      }
      if (IsGeneric != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IsGeneric);
      }
      if (BattleBgmId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleBgmId);
      }
      if (ResultBgmId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResultBgmId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrainerBase other) {
      if (other == null) {
        return;
      }
      if (other.TrainerBaseId != 0UL) {
        TrainerBaseId = other.TrainerBaseId;
      }
      if (other.ActorId.Length != 0) {
        ActorId = other.ActorId;
      }
      if (other.TrainerNameId.Length != 0) {
        TrainerNameId = other.TrainerNameId;
      }
      if (other.U4 != 0) {
        U4 = other.U4;
      }
      if (other.U5.Length != 0) {
        U5 = other.U5;
      }
      if (other.U6 != 0) {
        U6 = other.U6;
      }
      if (other.U7 != 0) {
        U7 = other.U7;
      }
      if (other.Gender != 0) {
        Gender = other.Gender;
      }
      if (other.PokeballId.Length != 0) {
        PokeballId = other.PokeballId;
      }
      if (other.IsGeneric != 0) {
        IsGeneric = other.IsGeneric;
      }
      if (other.BattleBgmId.Length != 0) {
        BattleBgmId = other.BattleBgmId;
      }
      if (other.ResultBgmId.Length != 0) {
        ResultBgmId = other.ResultBgmId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            TrainerBaseId = input.ReadUInt64();
            break;
          }
          case 18: {
            ActorId = input.ReadString();
            break;
          }
          case 26: {
            TrainerNameId = input.ReadString();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 42: {
            U5 = input.ReadString();
            break;
          }
          case 48: {
            U6 = input.ReadInt32();
            break;
          }
          case 56: {
            U7 = input.ReadInt32();
            break;
          }
          case 64: {
            Gender = input.ReadInt32();
            break;
          }
          case 74: {
            PokeballId = input.ReadString();
            break;
          }
          case 80: {
            IsGeneric = input.ReadInt32();
            break;
          }
          case 90: {
            BattleBgmId = input.ReadString();
            break;
          }
          case 98: {
            ResultBgmId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TrainerBaseTable : pb::IMessage<TrainerBaseTable> {
    private static readonly pb::MessageParser<TrainerBaseTable> _parser = new pb::MessageParser<TrainerBaseTable>(() => new TrainerBaseTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrainerBaseTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TrainerBaseReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBaseTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBaseTable(TrainerBaseTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerBaseTable Clone() {
      return new TrainerBaseTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.TrainerBase> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.TrainerBase.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.TrainerBase> entries_ = new pbc::RepeatedField<global::ReMastersLib.TrainerBase>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.TrainerBase> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrainerBaseTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrainerBaseTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrainerBaseTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
