// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::FlatBuffers;

/// Time type. The physical storage type depends on the unit
/// - SECOND and MILLISECOND: 32 bits
/// - MICROSECOND and NANOSECOND: 64 bits
public struct Time : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Time GetRootAsTime(ByteBuffer _bb) { return GetRootAsTime(_bb, new Time()); }
  public static Time GetRootAsTime(ByteBuffer _bb, Time obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Time __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public TimeUnit Unit { get { int o = __p.__offset(4); return o != 0 ? (TimeUnit)__p.bb.GetShort(o + __p.bb_pos) : TimeUnit.MILLISECOND; } }
  public int BitWidth { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)32; } }

  public static Offset<Time> CreateTime(FlatBufferBuilder builder,
      TimeUnit unit = TimeUnit.MILLISECOND,
      int bitWidth = 32) {
    builder.StartObject(2);
    Time.AddBitWidth(builder, bitWidth);
    Time.AddUnit(builder, unit);
    return Time.EndTime(builder);
  }

  public static void StartTime(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddUnit(FlatBufferBuilder builder, TimeUnit unit) { builder.AddShort(0, (short)unit, 1); }
  public static void AddBitWidth(FlatBufferBuilder builder, int bitWidth) { builder.AddInt(1, bitWidth, 32); }
  public static Offset<Time> EndTime(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Time>(o);
  }
};


}
