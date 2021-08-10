// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: pb_Parcel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from pb_Parcel.proto</summary>
public static partial class PbParcelReflection {

  #region Descriptor
  /// <summary>File descriptor for pb_Parcel.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PbParcelReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9wYl9QYXJjZWwucHJvdG8aEXBiX0VuZHBvaW50LnByb3RvImsKCXBiX1Bh",
          "cmNlbBIcCgZzb3VyY2UYASABKAsyDC5wYl9FbmRwb2ludBIhCgtkZXN0aW5h",
          "dGlvbhgCIAEoCzIMLnBiX0VuZHBvaW50EgwKBHR5cGUYAyABKAkSDwoHY29u",
          "dGVudBgEIAEoDGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::PbEndpointReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::pb_Parcel), global::pb_Parcel.Parser, new[]{ "Source", "Destination", "Type", "Content" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class pb_Parcel : pb::IMessage<pb_Parcel>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<pb_Parcel> _parser = new pb::MessageParser<pb_Parcel>(() => new pb_Parcel());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<pb_Parcel> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PbParcelReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb_Parcel() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb_Parcel(pb_Parcel other) : this() {
    source_ = other.source_ != null ? other.source_.Clone() : null;
    destination_ = other.destination_ != null ? other.destination_.Clone() : null;
    type_ = other.type_;
    content_ = other.content_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb_Parcel Clone() {
    return new pb_Parcel(this);
  }

  /// <summary>Field number for the "source" field.</summary>
  public const int SourceFieldNumber = 1;
  private global::pb_Endpoint source_;
  /// <summary>
  /// Sender endpoint
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::pb_Endpoint Source {
    get { return source_; }
    set {
      source_ = value;
    }
  }

  /// <summary>Field number for the "destination" field.</summary>
  public const int DestinationFieldNumber = 2;
  private global::pb_Endpoint destination_;
  /// <summary>
  /// Recipient endpoint
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::pb_Endpoint Destination {
    get { return destination_; }
    set {
      destination_ = value;
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 3;
  private string type_ = "";
  /// <summary>
  /// Protobuf name of parcel content
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Type {
    get { return type_; }
    set {
      type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "content" field.</summary>
  public const int ContentFieldNumber = 4;
  private pb::ByteString content_ = pb::ByteString.Empty;
  /// <summary>
  /// Serialised protobuf of parcel content
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb::ByteString Content {
    get { return content_; }
    set {
      content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as pb_Parcel);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(pb_Parcel other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Source, other.Source)) return false;
    if (!object.Equals(Destination, other.Destination)) return false;
    if (Type != other.Type) return false;
    if (Content != other.Content) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (source_ != null) hash ^= Source.GetHashCode();
    if (destination_ != null) hash ^= Destination.GetHashCode();
    if (Type.Length != 0) hash ^= Type.GetHashCode();
    if (Content.Length != 0) hash ^= Content.GetHashCode();
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
    if (source_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Source);
    }
    if (destination_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Destination);
    }
    if (Type.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Type);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Content);
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
    if (source_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Source);
    }
    if (destination_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Destination);
    }
    if (Type.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Type);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Content);
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
    if (source_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Source);
    }
    if (destination_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Destination);
    }
    if (Type.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
    }
    if (Content.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb_Parcel other) {
    if (other == null) {
      return;
    }
    if (other.source_ != null) {
      if (source_ == null) {
        Source = new global::pb_Endpoint();
      }
      Source.MergeFrom(other.Source);
    }
    if (other.destination_ != null) {
      if (destination_ == null) {
        Destination = new global::pb_Endpoint();
      }
      Destination.MergeFrom(other.Destination);
    }
    if (other.Type.Length != 0) {
      Type = other.Type;
    }
    if (other.Content.Length != 0) {
      Content = other.Content;
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
          if (source_ == null) {
            Source = new global::pb_Endpoint();
          }
          input.ReadMessage(Source);
          break;
        }
        case 18: {
          if (destination_ == null) {
            Destination = new global::pb_Endpoint();
          }
          input.ReadMessage(Destination);
          break;
        }
        case 26: {
          Type = input.ReadString();
          break;
        }
        case 34: {
          Content = input.ReadBytes();
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
          if (source_ == null) {
            Source = new global::pb_Endpoint();
          }
          input.ReadMessage(Source);
          break;
        }
        case 18: {
          if (destination_ == null) {
            Destination = new global::pb_Endpoint();
          }
          input.ReadMessage(Destination);
          break;
        }
        case 26: {
          Type = input.ReadString();
          break;
        }
        case 34: {
          Content = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code