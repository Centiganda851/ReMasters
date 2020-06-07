// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/BingoMissionReward.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/BingoMissionReward.proto</summary>
  public static partial class BingoMissionRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/BingoMissionReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BingoMissionRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qcm90by9CaW5nb01pc3Npb25SZXdhcmQucHJvdG8SDFJlTWFzdGVyc0xp",
            "YiJcChJCaW5nb01pc3Npb25SZXdhcmQSHwoXYmluZ29fbWlzc2lvbl9yZXdh",
            "cmRfaWQYASABKAUSEAoIbmJfbGluZXMYAiABKAUSEwoLaXRlbV9zZXRfaWQY",
            "AyABKAMiTAoXQmluZ29NaXNzaW9uUmV3YXJkVGFibGUSMQoHZW50cmllcxgB",
            "IAMoCzIgLlJlTWFzdGVyc0xpYi5CaW5nb01pc3Npb25SZXdhcmRiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BingoMissionReward), global::ReMastersLib.BingoMissionReward.Parser, new[]{ "BingoMissionRewardId", "NbLines", "ItemSetId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BingoMissionRewardTable), global::ReMastersLib.BingoMissionRewardTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BingoMissionReward : pb::IMessage<BingoMissionReward> {
    private static readonly pb::MessageParser<BingoMissionReward> _parser = new pb::MessageParser<BingoMissionReward>(() => new BingoMissionReward());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BingoMissionReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BingoMissionRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionReward(BingoMissionReward other) : this() {
      bingoMissionRewardId_ = other.bingoMissionRewardId_;
      nbLines_ = other.nbLines_;
      itemSetId_ = other.itemSetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionReward Clone() {
      return new BingoMissionReward(this);
    }

    /// <summary>Field number for the "bingo_mission_reward_id" field.</summary>
    public const int BingoMissionRewardIdFieldNumber = 1;
    private int bingoMissionRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BingoMissionRewardId {
      get { return bingoMissionRewardId_; }
      set {
        bingoMissionRewardId_ = value;
      }
    }

    /// <summary>Field number for the "nb_lines" field.</summary>
    public const int NbLinesFieldNumber = 2;
    private int nbLines_;
    /// <summary>
    /// 0 = bingo blackout
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NbLines {
      get { return nbLines_; }
      set {
        nbLines_ = value;
      }
    }

    /// <summary>Field number for the "item_set_id" field.</summary>
    public const int ItemSetIdFieldNumber = 3;
    private long itemSetId_;
    /// <summary>
    /// ItemSet.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemSetId {
      get { return itemSetId_; }
      set {
        itemSetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BingoMissionReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BingoMissionReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BingoMissionRewardId != other.BingoMissionRewardId) return false;
      if (NbLines != other.NbLines) return false;
      if (ItemSetId != other.ItemSetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BingoMissionRewardId != 0) hash ^= BingoMissionRewardId.GetHashCode();
      if (NbLines != 0) hash ^= NbLines.GetHashCode();
      if (ItemSetId != 0L) hash ^= ItemSetId.GetHashCode();
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
      if (BingoMissionRewardId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BingoMissionRewardId);
      }
      if (NbLines != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NbLines);
      }
      if (ItemSetId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ItemSetId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BingoMissionRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BingoMissionRewardId);
      }
      if (NbLines != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NbLines);
      }
      if (ItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemSetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BingoMissionReward other) {
      if (other == null) {
        return;
      }
      if (other.BingoMissionRewardId != 0) {
        BingoMissionRewardId = other.BingoMissionRewardId;
      }
      if (other.NbLines != 0) {
        NbLines = other.NbLines;
      }
      if (other.ItemSetId != 0L) {
        ItemSetId = other.ItemSetId;
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
            BingoMissionRewardId = input.ReadInt32();
            break;
          }
          case 16: {
            NbLines = input.ReadInt32();
            break;
          }
          case 24: {
            ItemSetId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BingoMissionRewardTable : pb::IMessage<BingoMissionRewardTable> {
    private static readonly pb::MessageParser<BingoMissionRewardTable> _parser = new pb::MessageParser<BingoMissionRewardTable>(() => new BingoMissionRewardTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BingoMissionRewardTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BingoMissionRewardReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionRewardTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionRewardTable(BingoMissionRewardTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BingoMissionRewardTable Clone() {
      return new BingoMissionRewardTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.BingoMissionReward> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.BingoMissionReward.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.BingoMissionReward> entries_ = new pbc::RepeatedField<global::ReMastersLib.BingoMissionReward>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.BingoMissionReward> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BingoMissionRewardTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BingoMissionRewardTable other) {
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
    public void MergeFrom(BingoMissionRewardTable other) {
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