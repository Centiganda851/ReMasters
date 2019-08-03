// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/BadgeItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/BadgeItem.proto</summary>
  public static partial class BadgeItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/BadgeItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BadgeItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90by9CYWRnZUl0ZW0ucHJvdG8SDFJlTWFzdGVyc0xpYiJVCglCYWRn",
            "ZUl0ZW0SEAoIdW5rbm93bjEYASABKAQSEAoIYmFkZ2VfaWQYAiABKA0SEgoK",
            "YmFkZ2VfbmFtZRgDIAEoCRIQCgh1bmtub3duMhgEIAEoDSI6Cg5CYWRnZUl0",
            "ZW1UYWJsZRIoCgdlbnRyaWVzGAEgAygLMhcuUmVNYXN0ZXJzTGliLkJhZGdl",
            "SXRlbWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BadgeItem), global::ReMastersLib.BadgeItem.Parser, new[]{ "Unknown1", "BadgeId", "BadgeName", "Unknown2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BadgeItemTable), global::ReMastersLib.BadgeItemTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BadgeItem : pb::IMessage<BadgeItem> {
    private static readonly pb::MessageParser<BadgeItem> _parser = new pb::MessageParser<BadgeItem>(() => new BadgeItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BadgeItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BadgeItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItem(BadgeItem other) : this() {
      unknown1_ = other.unknown1_;
      badgeId_ = other.badgeId_;
      badgeName_ = other.badgeName_;
      unknown2_ = other.unknown2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItem Clone() {
      return new BadgeItem(this);
    }

    /// <summary>Field number for the "unknown1" field.</summary>
    public const int Unknown1FieldNumber = 1;
    private ulong unknown1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Unknown1 {
      get { return unknown1_; }
      set {
        unknown1_ = value;
      }
    }

    /// <summary>Field number for the "badge_id" field.</summary>
    public const int BadgeIdFieldNumber = 2;
    private uint badgeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint BadgeId {
      get { return badgeId_; }
      set {
        badgeId_ = value;
      }
    }

    /// <summary>Field number for the "badge_name" field.</summary>
    public const int BadgeNameFieldNumber = 3;
    private string badgeName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BadgeName {
      get { return badgeName_; }
      set {
        badgeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unknown2" field.</summary>
    public const int Unknown2FieldNumber = 4;
    private uint unknown2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Unknown2 {
      get { return unknown2_; }
      set {
        unknown2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BadgeItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BadgeItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unknown1 != other.Unknown1) return false;
      if (BadgeId != other.BadgeId) return false;
      if (BadgeName != other.BadgeName) return false;
      if (Unknown2 != other.Unknown2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Unknown1 != 0UL) hash ^= Unknown1.GetHashCode();
      if (BadgeId != 0) hash ^= BadgeId.GetHashCode();
      if (BadgeName.Length != 0) hash ^= BadgeName.GetHashCode();
      if (Unknown2 != 0) hash ^= Unknown2.GetHashCode();
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
      if (Unknown1 != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Unknown1);
      }
      if (BadgeId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BadgeId);
      }
      if (BadgeName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BadgeName);
      }
      if (Unknown2 != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unknown2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Unknown1 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unknown1);
      }
      if (BadgeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BadgeId);
      }
      if (BadgeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BadgeName);
      }
      if (Unknown2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unknown2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BadgeItem other) {
      if (other == null) {
        return;
      }
      if (other.Unknown1 != 0UL) {
        Unknown1 = other.Unknown1;
      }
      if (other.BadgeId != 0) {
        BadgeId = other.BadgeId;
      }
      if (other.BadgeName.Length != 0) {
        BadgeName = other.BadgeName;
      }
      if (other.Unknown2 != 0) {
        Unknown2 = other.Unknown2;
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
            Unknown1 = input.ReadUInt64();
            break;
          }
          case 16: {
            BadgeId = input.ReadUInt32();
            break;
          }
          case 26: {
            BadgeName = input.ReadString();
            break;
          }
          case 32: {
            Unknown2 = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BadgeItemTable : pb::IMessage<BadgeItemTable> {
    private static readonly pb::MessageParser<BadgeItemTable> _parser = new pb::MessageParser<BadgeItemTable>(() => new BadgeItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BadgeItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BadgeItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItemTable(BadgeItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BadgeItemTable Clone() {
      return new BadgeItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.BadgeItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.BadgeItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.BadgeItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.BadgeItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.BadgeItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BadgeItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BadgeItemTable other) {
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
    public void MergeFrom(BadgeItemTable other) {
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