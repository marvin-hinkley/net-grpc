// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: person.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Person {

  /// <summary>Holder for reflection information generated from person.proto</summary>
  public static partial class PersonReflection {

    #region Descriptor
    /// <summary>File descriptor for person.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwZXJzb24ucHJvdG8SBnBlcnNvbiIdCgxTcGVha01lc3NhZ2USDQoFdmFs",
            "dWUYASABKAkiHQoMQ29sb3JNZXNzYWdlEg0KBWNvbG9yGAEgASgJIlIKDVBl",
            "cnNvbk1lc3NhZ2USDAoEbmFtZRgBIAEoCRIQCghleWVDb2xvchgCIAEoCRIR",
            "CgloYWlyQ29sb3IYAyABKAkSDgoGaGVpZ2h0GAQgASgNIgYKBFZvaWQynQEK",
            "DVBlcnNvblNlcnZpY2USKwoFU3BlYWsSDC5wZXJzb24uVm9pZBoULnBlcnNv",
            "bi5TcGVha01lc3NhZ2USLQoHRHllSGFpchIULnBlcnNvbi5Db2xvck1lc3Nh",
            "Z2UaDC5wZXJzb24uVm9pZBIwCglHZXRQZXJzb24SDC5wZXJzb24uVm9pZBoV",
            "LnBlcnNvbi5QZXJzb25NZXNzYWdlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Person.SpeakMessage), global::Person.SpeakMessage.Parser, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Person.ColorMessage), global::Person.ColorMessage.Parser, new[]{ "Color" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Person.PersonMessage), global::Person.PersonMessage.Parser, new[]{ "Name", "EyeColor", "HairColor", "Height" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Person.Void), global::Person.Void.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpeakMessage : pb::IMessage<SpeakMessage> {
    private static readonly pb::MessageParser<SpeakMessage> _parser = new pb::MessageParser<SpeakMessage>(() => new SpeakMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpeakMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Person.PersonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeakMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeakMessage(SpeakMessage other) : this() {
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeakMessage Clone() {
      return new SpeakMessage(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpeakMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpeakMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpeakMessage other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ColorMessage : pb::IMessage<ColorMessage> {
    private static readonly pb::MessageParser<ColorMessage> _parser = new pb::MessageParser<ColorMessage>(() => new ColorMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ColorMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Person.PersonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColorMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColorMessage(ColorMessage other) : this() {
      color_ = other.color_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ColorMessage Clone() {
      return new ColorMessage(this);
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 1;
    private string color_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Color {
      get { return color_; }
      set {
        color_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ColorMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ColorMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Color != other.Color) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Color.Length != 0) hash ^= Color.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Color.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Color);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Color.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Color);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ColorMessage other) {
      if (other == null) {
        return;
      }
      if (other.Color.Length != 0) {
        Color = other.Color;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Color = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PersonMessage : pb::IMessage<PersonMessage> {
    private static readonly pb::MessageParser<PersonMessage> _parser = new pb::MessageParser<PersonMessage>(() => new PersonMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PersonMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Person.PersonReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersonMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersonMessage(PersonMessage other) : this() {
      name_ = other.name_;
      eyeColor_ = other.eyeColor_;
      hairColor_ = other.hairColor_;
      height_ = other.height_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PersonMessage Clone() {
      return new PersonMessage(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "eyeColor" field.</summary>
    public const int EyeColorFieldNumber = 2;
    private string eyeColor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EyeColor {
      get { return eyeColor_; }
      set {
        eyeColor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hairColor" field.</summary>
    public const int HairColorFieldNumber = 3;
    private string hairColor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HairColor {
      get { return hairColor_; }
      set {
        hairColor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 4;
    private uint height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PersonMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PersonMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (EyeColor != other.EyeColor) return false;
      if (HairColor != other.HairColor) return false;
      if (Height != other.Height) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (EyeColor.Length != 0) hash ^= EyeColor.GetHashCode();
      if (HairColor.Length != 0) hash ^= HairColor.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (EyeColor.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EyeColor);
      }
      if (HairColor.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(HairColor);
      }
      if (Height != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Height);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (EyeColor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EyeColor);
      }
      if (HairColor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HairColor);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Height);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PersonMessage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.EyeColor.Length != 0) {
        EyeColor = other.EyeColor;
      }
      if (other.HairColor.Length != 0) {
        HairColor = other.HairColor;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            EyeColor = input.ReadString();
            break;
          }
          case 26: {
            HairColor = input.ReadString();
            break;
          }
          case 32: {
            Height = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Void : pb::IMessage<Void> {
    private static readonly pb::MessageParser<Void> _parser = new pb::MessageParser<Void>(() => new Void());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Void> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Person.PersonReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void(Void other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void Clone() {
      return new Void(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Void);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Void other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Void other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
