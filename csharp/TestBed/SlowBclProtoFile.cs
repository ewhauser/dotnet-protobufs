// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.SlowBcl {
  
  public static partial class SlowBclProtoFile {
  
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
    }
    private static readonly pbd::FileDescriptor descriptor = pbd::FileDescriptor.InternalBuildGeneratedFileFrom (
        new byte[] {
            0x0a, 0x0d, 0x73, 0x6c, 0x6f, 0x77, 0x62, 0x63, 0x6c, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x07, 0x73, 0x6c, 0x6f, 
            0x77, 0x62, 0x63, 0x6c, 0x22, 0xad, 0x01, 0x0a, 0x08, 0x54, 0x69, 0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x12, 0x0d, 0x0a, 
            0x05, 0x76, 0x61, 0x6c, 0x75, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x12, 0x12, 0x34, 0x0a, 0x05, 0x73, 0x63, 0x61, 0x6c, 
            0x65, 0x18, 0x02, 0x20, 0x01, 0x28, 0x0e, 0x32, 0x1f, 0x2e, 0x73, 0x6c, 0x6f, 0x77, 0x62, 0x63, 0x6c, 0x2e, 0x54, 0x69, 
            0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x53, 0x63, 0x61, 0x6c, 0x65, 
            0x3a, 0x04, 0x44, 0x41, 0x59, 0x53, 0x22, 0x5c, 0x0a, 0x0d, 0x54, 0x69, 0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x53, 0x63, 
            0x61, 0x6c, 0x65, 0x12, 0x08, 0x0a, 0x04, 0x44, 0x41, 0x59, 0x53, 0x10, 0x00, 0x12, 0x09, 0x0a, 0x05, 0x48, 0x4f, 0x55, 
            0x52, 0x53, 0x10, 0x01, 0x12, 0x0b, 0x0a, 0x07, 0x4d, 0x49, 0x4e, 0x55, 0x54, 0x45, 0x53, 0x10, 0x02, 0x12, 0x0b, 0x0a, 
            0x07, 0x53, 0x45, 0x43, 0x4f, 0x4e, 0x44, 0x53, 0x10, 0x03, 0x12, 0x10, 0x0a, 0x0c, 0x4d, 0x49, 0x4c, 0x4c, 0x49, 0x53, 
            0x45, 0x43, 0x4f, 0x4e, 0x44, 0x53, 0x10, 0x04, 0x12, 0x0a, 0x0a, 0x06, 0x4d, 0x49, 0x4e, 0x4d, 0x41, 0x58, 0x10, 0x0f, 
            0x22, 0xad, 0x01, 0x0a, 0x08, 0x44, 0x61, 0x74, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x12, 0x0d, 0x0a, 0x05, 0x76, 0x61, 0x6c, 
            0x75, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x12, 0x12, 0x34, 0x0a, 0x05, 0x73, 0x63, 0x61, 0x6c, 0x65, 0x18, 0x02, 0x20, 
            0x01, 0x28, 0x0e, 0x32, 0x1f, 0x2e, 0x73, 0x6c, 0x6f, 0x77, 0x62, 0x63, 0x6c, 0x2e, 0x44, 0x61, 0x74, 0x65, 0x54, 0x69, 
            0x6d, 0x65, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x53, 0x63, 0x61, 0x6c, 0x65, 0x3a, 0x04, 0x44, 0x41, 
            0x59, 0x53, 0x22, 0x5c, 0x0a, 0x0d, 0x54, 0x69, 0x6d, 0x65, 0x53, 0x70, 0x61, 0x6e, 0x53, 0x63, 0x61, 0x6c, 0x65, 0x12, 
            0x08, 0x0a, 0x04, 0x44, 0x41, 0x59, 0x53, 0x10, 0x00, 0x12, 0x09, 0x0a, 0x05, 0x48, 0x4f, 0x55, 0x52, 0x53, 0x10, 0x01, 
            0x12, 0x0b, 0x0a, 0x07, 0x4d, 0x49, 0x4e, 0x55, 0x54, 0x45, 0x53, 0x10, 0x02, 0x12, 0x0b, 0x0a, 0x07, 0x53, 0x45, 0x43, 
            0x4f, 0x4e, 0x44, 0x53, 0x10, 0x03, 0x12, 0x10, 0x0a, 0x0c, 0x4d, 0x49, 0x4c, 0x4c, 0x49, 0x53, 0x45, 0x43, 0x4f, 0x4e, 
            0x44, 0x53, 0x10, 0x04, 0x12, 0x0a, 0x0a, 0x06, 0x4d, 0x49, 0x4e, 0x4d, 0x41, 0x58, 0x10, 0x0f, 0x22, 0x1e, 0x0a, 0x04, 
            0x47, 0x75, 0x69, 0x64, 0x12, 0x0a, 0x0a, 0x02, 0x6c, 0x6f, 0x18, 0x01, 0x20, 0x01, 0x28, 0x06, 0x12, 0x0a, 0x0a, 0x02, 
            0x68, 0x69, 0x18, 0x02, 0x20, 0x01, 0x28, 0x06, 0x22, 0x34, 0x0a, 0x07, 0x44, 0x65, 0x63, 0x69, 0x6d, 0x61, 0x6c, 0x12, 
            0x0a, 0x0a, 0x02, 0x6c, 0x6f, 0x18, 0x01, 0x20, 0x01, 0x28, 0x04, 0x12, 0x0a, 0x0a, 0x02, 0x68, 0x69, 0x18, 0x02, 0x20, 
            0x01, 0x28, 0x0d, 0x12, 0x11, 0x0a, 0x09, 0x73, 0x69, 0x67, 0x6e, 0x53, 0x63, 0x61, 0x6c, 0x65, 0x18, 0x03, 0x20, 0x01, 
            0x28, 0x0d, 0x42, 0x34, 0xc2, 0x3e, 0x1e, 0x47, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x50, 0x72, 0x6f, 0x74, 0x6f, 0x63, 
            0x6f, 0x6c, 0x42, 0x75, 0x66, 0x66, 0x65, 0x72, 0x73, 0x2e, 0x53, 0x6c, 0x6f, 0x77, 0x42, 0x63, 0x6c, 0xca, 0x3e, 0x10, 
            0x53, 0x6c, 0x6f, 0x77, 0x42, 0x63, 0x6c, 0x50, 0x72, 0x6f, 0x74, 0x6f, 0x46, 0x69, 0x6c, 0x65, 
        }, new pbd::FileDescriptor[] {
        });
    #endregion
    
    #region Extensions
    #endregion
    
    #region Static variables
    internal static readonly pbd::MessageDescriptor internal__static_slowbcl_TimeSpan__Descriptor 
        = Descriptor.MessageTypes[0];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.TimeSpan, global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Builder> internal__static_slowbcl_TimeSpan__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.TimeSpan, global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Builder>(internal__static_slowbcl_TimeSpan__Descriptor,
            new string[] { "Value", "Scale", });
    internal static readonly pbd::MessageDescriptor internal__static_slowbcl_DateTime__Descriptor 
        = Descriptor.MessageTypes[1];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.DateTime, global::Google.ProtocolBuffers.SlowBcl.DateTime.Builder> internal__static_slowbcl_DateTime__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.DateTime, global::Google.ProtocolBuffers.SlowBcl.DateTime.Builder>(internal__static_slowbcl_DateTime__Descriptor,
            new string[] { "Value", "Scale", });
    internal static readonly pbd::MessageDescriptor internal__static_slowbcl_Guid__Descriptor 
        = Descriptor.MessageTypes[2];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.Guid, global::Google.ProtocolBuffers.SlowBcl.Guid.Builder> internal__static_slowbcl_Guid__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.Guid, global::Google.ProtocolBuffers.SlowBcl.Guid.Builder>(internal__static_slowbcl_Guid__Descriptor,
            new string[] { "Lo", "Hi", });
    internal static readonly pbd::MessageDescriptor internal__static_slowbcl_Decimal__Descriptor 
        = Descriptor.MessageTypes[3];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.Decimal, global::Google.ProtocolBuffers.SlowBcl.Decimal.Builder> internal__static_slowbcl_Decimal__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.SlowBcl.Decimal, global::Google.ProtocolBuffers.SlowBcl.Decimal.Builder>(internal__static_slowbcl_Decimal__Descriptor,
            new string[] { "Lo", "Hi", "SignScale", });
    #endregion
    
  }
  
  #region Enums
  #endregion
  
  #region Messages
  public sealed partial class TimeSpan : pb::GeneratedMessage<TimeSpan, TimeSpan.Builder> {
    private static readonly TimeSpan defaultInstance = new TimeSpan();
    public static TimeSpan DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TimeSpan DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TimeSpan ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_TimeSpan__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TimeSpan, TimeSpan.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_TimeSpan__FieldAccessorTable; }
    }
    
    #region Nested types
    public static class Types {
      public enum TimeSpanScale {
        DAYS = 0,
        HOURS = 1,
        MINUTES = 2,
        SECONDS = 3,
        MILLISECONDS = 4,
        MINMAX = 15,
      }
      
    }
    #endregion
    
    // optional sint64 value = 1;
    private bool hasValue;
    private long value_ = 0L;
    public bool HasValue {
      get { return hasValue; }
    }
    public long Value {
      get { return value_; }
    }
    
    // optional .slowbcl.TimeSpan.TimeSpanScale scale = 2 [default = DAYS];
    private bool hasScale;
    private global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale scale_ = global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale.DAYS;
    public bool HasScale {
      get { return hasScale; }
    }
    public global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale Scale {  get { return scale_; }}
    
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(pb::ByteString data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(byte[] data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(
        global::System.IO.Stream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.TimeSpan ParseFrom(pb::CodedInputStream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(global::Google.ProtocolBuffers.SlowBcl.TimeSpan prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<global::Google.ProtocolBuffers.SlowBcl.TimeSpan, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      
      // Construct using global::Google.ProtocolBuffers.SlowBcl.TimeSpan.CreateBuilder()
      internal Builder() {}
      
      global::Google.ProtocolBuffers.SlowBcl.TimeSpan result = new global::Google.ProtocolBuffers.SlowBcl.TimeSpan();
      
      protected override global::Google.ProtocolBuffers.SlowBcl.TimeSpan MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new global::Google.ProtocolBuffers.SlowBcl.TimeSpan();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Descriptor; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.TimeSpan DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.TimeSpan.DefaultInstance; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.TimeSpan BuildPartial() {
        global::Google.ProtocolBuffers.SlowBcl.TimeSpan returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      // optional sint64 value = 1;
      public bool HasValue {
        get { return result.HasValue; }
      }
      public long Value {
        get { return result.Value; }
        set { SetValue(value); }
      }
      public Builder SetValue(long value) {
        result.hasValue = true;
        result.value_ = value;
        return this;
      }
      public Builder ClearValue() {
        result.hasValue = false;
        result.value_ = 0L;
        return this;
      }
      
      // optional .slowbcl.TimeSpan.TimeSpanScale scale = 2 [default = DAYS];
      public bool HasScale {
        get { return result.HasScale; }
      }
      public global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale Scale {
        get { return result.Scale; }
        set { SetScale(value); }
      }
      public Builder SetScale(global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale value) {
        result.hasScale = true;
        result.scale_ = value;
        return this;
      }
      public Builder ClearScale() {
        result.hasScale = false;
        result.scale_ = global::Google.ProtocolBuffers.SlowBcl.TimeSpan.Types.TimeSpanScale.DAYS;
        return this;
      }
    }
  }
  
  public sealed partial class DateTime : pb::GeneratedMessage<DateTime, DateTime.Builder> {
    private static readonly DateTime defaultInstance = new DateTime();
    public static DateTime DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override DateTime DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override DateTime ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_DateTime__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<DateTime, DateTime.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_DateTime__FieldAccessorTable; }
    }
    
    #region Nested types
    public static class Types {
      public enum TimeSpanScale {
        DAYS = 0,
        HOURS = 1,
        MINUTES = 2,
        SECONDS = 3,
        MILLISECONDS = 4,
        MINMAX = 15,
      }
      
    }
    #endregion
    
    // optional sint64 value = 1;
    private bool hasValue;
    private long value_ = 0L;
    public bool HasValue {
      get { return hasValue; }
    }
    public long Value {
      get { return value_; }
    }
    
    // optional .slowbcl.DateTime.TimeSpanScale scale = 2 [default = DAYS];
    private bool hasScale;
    private global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale scale_ = global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale.DAYS;
    public bool HasScale {
      get { return hasScale; }
    }
    public global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale Scale {  get { return scale_; }}
    
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(pb::ByteString data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(byte[] data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(
        global::System.IO.Stream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.DateTime ParseFrom(pb::CodedInputStream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(global::Google.ProtocolBuffers.SlowBcl.DateTime prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<global::Google.ProtocolBuffers.SlowBcl.DateTime, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      
      // Construct using global::Google.ProtocolBuffers.SlowBcl.DateTime.CreateBuilder()
      internal Builder() {}
      
      global::Google.ProtocolBuffers.SlowBcl.DateTime result = new global::Google.ProtocolBuffers.SlowBcl.DateTime();
      
      protected override global::Google.ProtocolBuffers.SlowBcl.DateTime MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new global::Google.ProtocolBuffers.SlowBcl.DateTime();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.DateTime.Descriptor; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.DateTime DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.DateTime.DefaultInstance; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.DateTime BuildPartial() {
        global::Google.ProtocolBuffers.SlowBcl.DateTime returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      // optional sint64 value = 1;
      public bool HasValue {
        get { return result.HasValue; }
      }
      public long Value {
        get { return result.Value; }
        set { SetValue(value); }
      }
      public Builder SetValue(long value) {
        result.hasValue = true;
        result.value_ = value;
        return this;
      }
      public Builder ClearValue() {
        result.hasValue = false;
        result.value_ = 0L;
        return this;
      }
      
      // optional .slowbcl.DateTime.TimeSpanScale scale = 2 [default = DAYS];
      public bool HasScale {
        get { return result.HasScale; }
      }
      public global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale Scale {
        get { return result.Scale; }
        set { SetScale(value); }
      }
      public Builder SetScale(global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale value) {
        result.hasScale = true;
        result.scale_ = value;
        return this;
      }
      public Builder ClearScale() {
        result.hasScale = false;
        result.scale_ = global::Google.ProtocolBuffers.SlowBcl.DateTime.Types.TimeSpanScale.DAYS;
        return this;
      }
    }
  }
  
  public sealed partial class Guid : pb::GeneratedMessage<Guid, Guid.Builder> {
    private static readonly Guid defaultInstance = new Guid();
    public static Guid DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Guid DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Guid ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_Guid__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Guid, Guid.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_Guid__FieldAccessorTable; }
    }
    
    // optional fixed64 lo = 1;
    private bool hasLo;
    private ulong lo_ = 0UL;
    public bool HasLo {
      get { return hasLo; }
    }
    public ulong Lo {
      get { return lo_; }
    }
    
    // optional fixed64 hi = 2;
    private bool hasHi;
    private ulong hi_ = 0UL;
    public bool HasHi {
      get { return hasHi; }
    }
    public ulong Hi {
      get { return hi_; }
    }
    
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(pb::ByteString data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(byte[] data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(
        global::System.IO.Stream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Guid ParseFrom(pb::CodedInputStream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(global::Google.ProtocolBuffers.SlowBcl.Guid prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<global::Google.ProtocolBuffers.SlowBcl.Guid, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      
      // Construct using global::Google.ProtocolBuffers.SlowBcl.Guid.CreateBuilder()
      internal Builder() {}
      
      global::Google.ProtocolBuffers.SlowBcl.Guid result = new global::Google.ProtocolBuffers.SlowBcl.Guid();
      
      protected override global::Google.ProtocolBuffers.SlowBcl.Guid MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new global::Google.ProtocolBuffers.SlowBcl.Guid();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.Guid.Descriptor; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.Guid DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.Guid.DefaultInstance; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.Guid BuildPartial() {
        global::Google.ProtocolBuffers.SlowBcl.Guid returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      // optional fixed64 lo = 1;
      public bool HasLo {
        get { return result.HasLo; }
      }
      public ulong Lo {
        get { return result.Lo; }
        set { SetLo(value); }
      }
      public Builder SetLo(ulong value) {
        result.hasLo = true;
        result.lo_ = value;
        return this;
      }
      public Builder ClearLo() {
        result.hasLo = false;
        result.lo_ = 0UL;
        return this;
      }
      
      // optional fixed64 hi = 2;
      public bool HasHi {
        get { return result.HasHi; }
      }
      public ulong Hi {
        get { return result.Hi; }
        set { SetHi(value); }
      }
      public Builder SetHi(ulong value) {
        result.hasHi = true;
        result.hi_ = value;
        return this;
      }
      public Builder ClearHi() {
        result.hasHi = false;
        result.hi_ = 0UL;
        return this;
      }
    }
  }
  
  public sealed partial class Decimal : pb::GeneratedMessage<Decimal, Decimal.Builder> {
    private static readonly Decimal defaultInstance = new Decimal();
    public static Decimal DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Decimal DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Decimal ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_Decimal__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Decimal, Decimal.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.SlowBcl.SlowBclProtoFile.internal__static_slowbcl_Decimal__FieldAccessorTable; }
    }
    
    // optional uint64 lo = 1;
    private bool hasLo;
    private ulong lo_ = 0UL;
    public bool HasLo {
      get { return hasLo; }
    }
    public ulong Lo {
      get { return lo_; }
    }
    
    // optional uint32 hi = 2;
    private bool hasHi;
    private uint hi_ = 0;
    public bool HasHi {
      get { return hasHi; }
    }
    public uint Hi {
      get { return hi_; }
    }
    
    // optional uint32 signScale = 3;
    private bool hasSignScale;
    private uint signScale_ = 0;
    public bool HasSignScale {
      get { return hasSignScale; }
    }
    public uint SignScale {
      get { return signScale_; }
    }
    
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(pb::ByteString data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(byte[] data,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(
        global::System.IO.Stream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static global::Google.ProtocolBuffers.SlowBcl.Decimal ParseFrom(pb::CodedInputStream input,
        pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry))
               .BuildParsed();
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(global::Google.ProtocolBuffers.SlowBcl.Decimal prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<global::Google.ProtocolBuffers.SlowBcl.Decimal, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      
      // Construct using global::Google.ProtocolBuffers.SlowBcl.Decimal.CreateBuilder()
      internal Builder() {}
      
      global::Google.ProtocolBuffers.SlowBcl.Decimal result = new global::Google.ProtocolBuffers.SlowBcl.Decimal();
      
      protected override global::Google.ProtocolBuffers.SlowBcl.Decimal MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new global::Google.ProtocolBuffers.SlowBcl.Decimal();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.Decimal.Descriptor; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.Decimal DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.SlowBcl.Decimal.DefaultInstance; }
      }
      
      public override global::Google.ProtocolBuffers.SlowBcl.Decimal BuildPartial() {
        global::Google.ProtocolBuffers.SlowBcl.Decimal returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      // optional uint64 lo = 1;
      public bool HasLo {
        get { return result.HasLo; }
      }
      public ulong Lo {
        get { return result.Lo; }
        set { SetLo(value); }
      }
      public Builder SetLo(ulong value) {
        result.hasLo = true;
        result.lo_ = value;
        return this;
      }
      public Builder ClearLo() {
        result.hasLo = false;
        result.lo_ = 0UL;
        return this;
      }
      
      // optional uint32 hi = 2;
      public bool HasHi {
        get { return result.HasHi; }
      }
      public uint Hi {
        get { return result.Hi; }
        set { SetHi(value); }
      }
      public Builder SetHi(uint value) {
        result.hasHi = true;
        result.hi_ = value;
        return this;
      }
      public Builder ClearHi() {
        result.hasHi = false;
        result.hi_ = 0;
        return this;
      }
      
      // optional uint32 signScale = 3;
      public bool HasSignScale {
        get { return result.HasSignScale; }
      }
      public uint SignScale {
        get { return result.SignScale; }
        set { SetSignScale(value); }
      }
      public Builder SetSignScale(uint value) {
        result.hasSignScale = true;
        result.signScale_ = value;
        return this;
      }
      public Builder ClearSignScale() {
        result.hasSignScale = false;
        result.signScale_ = 0;
        return this;
      }
    }
  }
  
  #endregion
  
  #region Services
  #endregion
}
