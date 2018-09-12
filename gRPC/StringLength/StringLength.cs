// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StringLength.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from StringLength.proto</summary>
public static partial class StringLengthReflection {

  #region Descriptor
  /// <summary>File descriptor for StringLength.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static StringLengthReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJTdHJpbmdMZW5ndGgucHJvdG8iIwoTU3RyaW5nTGVuZ3RoUmVxdWVzdBIM",
          "CgR3b3JkGAEgASgJIi4KEVN0cmluZ0xlbmd0aFJlcGx5EgwKBHdvcmQYASAB",
          "KAkSCwoDbGVuGAIgASgFMlUKE1N0cmluZ0xlbmd0aFNlcnZpY2USPgoMU3Ry",
          "aW5nTGVuZ3RoEhQuU3RyaW5nTGVuZ3RoUmVxdWVzdBoSLlN0cmluZ0xlbmd0",
          "aFJlcGx5IgAoATABYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::StringLengthRequest), global::StringLengthRequest.Parser, new[]{ "Word" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::StringLengthReply), global::StringLengthReply.Parser, new[]{ "Word", "Len" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class StringLengthRequest : pb::IMessage<StringLengthRequest> {
  private static readonly pb::MessageParser<StringLengthRequest> _parser = new pb::MessageParser<StringLengthRequest>(() => new StringLengthRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<StringLengthRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::StringLengthReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthRequest(StringLengthRequest other) : this() {
    word_ = other.word_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthRequest Clone() {
    return new StringLengthRequest(this);
  }

  /// <summary>Field number for the "word" field.</summary>
  public const int WordFieldNumber = 1;
  private string word_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Word {
    get { return word_; }
    set {
      word_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as StringLengthRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(StringLengthRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Word != other.Word) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Word.Length != 0) hash ^= Word.GetHashCode();
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
    if (Word.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Word);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Word.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Word);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(StringLengthRequest other) {
    if (other == null) {
      return;
    }
    if (other.Word.Length != 0) {
      Word = other.Word;
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
        case 10: {
          Word = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class StringLengthReply : pb::IMessage<StringLengthReply> {
  private static readonly pb::MessageParser<StringLengthReply> _parser = new pb::MessageParser<StringLengthReply>(() => new StringLengthReply());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<StringLengthReply> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::StringLengthReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthReply() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthReply(StringLengthReply other) : this() {
    word_ = other.word_;
    len_ = other.len_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StringLengthReply Clone() {
    return new StringLengthReply(this);
  }

  /// <summary>Field number for the "word" field.</summary>
  public const int WordFieldNumber = 1;
  private string word_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Word {
    get { return word_; }
    set {
      word_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "len" field.</summary>
  public const int LenFieldNumber = 2;
  private int len_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Len {
    get { return len_; }
    set {
      len_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as StringLengthReply);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(StringLengthReply other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Word != other.Word) return false;
    if (Len != other.Len) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Word.Length != 0) hash ^= Word.GetHashCode();
    if (Len != 0) hash ^= Len.GetHashCode();
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
    if (Word.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Word);
    }
    if (Len != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Len);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Word.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Word);
    }
    if (Len != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Len);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(StringLengthReply other) {
    if (other == null) {
      return;
    }
    if (other.Word.Length != 0) {
      Word = other.Word;
    }
    if (other.Len != 0) {
      Len = other.Len;
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
        case 10: {
          Word = input.ReadString();
          break;
        }
        case 16: {
          Len = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code