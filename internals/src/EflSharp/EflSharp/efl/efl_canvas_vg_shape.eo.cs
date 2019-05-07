#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

namespace Vg {

/// <summary>Efl vector graphics shape class</summary>
[Efl.Canvas.Vg.Shape.NativeMethods]
public class Shape : Efl.Canvas.Vg.Node, Efl.Eo.IWrapper,Efl.Gfx.IShape
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(Shape))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
        efl_canvas_vg_shape_class_get();
    /// <summary>Initializes a new instance of the <see cref="Shape"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public Shape(Efl.Object parent= null
            ) : base(efl_canvas_vg_shape_class_get(), typeof(Shape), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="Shape"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected Shape(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="Shape"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected Shape(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    /// <summary>Fill of the shape object</summary>
    /// <returns>Fill object</returns>
    virtual public Efl.Canvas.Vg.Node GetFill() {
         var _ret_var = Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_fill_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Fill of the shape object</summary>
    /// <param name="f">Fill object</param>
    virtual public void SetFill(Efl.Canvas.Vg.Node f) {
                                 Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_fill_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),f);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Stroke fill of the shape object</summary>
    /// <returns>Stroke fill object</returns>
    virtual public Efl.Canvas.Vg.Node GetStrokeFill() {
         var _ret_var = Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_stroke_fill_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Stroke fill of the shape object</summary>
    /// <param name="f">Stroke fill object</param>
    virtual public void SetStrokeFill(Efl.Canvas.Vg.Node f) {
                                 Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_stroke_fill_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),f);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Stroke marker of the shape object</summary>
    /// <returns>Stroke marker object</returns>
    virtual public Efl.Canvas.Vg.Node GetStrokeMarker() {
         var _ret_var = Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_stroke_marker_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Stroke marker of the shape object</summary>
    /// <param name="m">Stroke marker object</param>
    virtual public void SetStrokeMarker(Efl.Canvas.Vg.Node m) {
                                 Efl.Canvas.Vg.Shape.NativeMethods.efl_canvas_vg_shape_stroke_marker_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),m);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The stroke scale to be used for stroking the path. Will be used along with stroke width property.</summary>
    /// <returns>Stroke scale value</returns>
    virtual public double GetStrokeScale() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_scale_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The stroke scale to be used for stroking the path. Will be used along with stroke width property.</summary>
    /// <param name="s">Stroke scale value</param>
    virtual public void SetStrokeScale(double s) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_scale_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),s);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The color to be used for stroking the path.</summary>
    /// <param name="r">The red component of the given color.</param>
    /// <param name="g">The green component of the given color.</param>
    /// <param name="b">The blue component of the given color.</param>
    /// <param name="a">The alpha component of the given color.</param>
    virtual public void GetStrokeColor(out int r, out int g, out int b, out int a) {
                                                                                                         Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_color_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out r, out g, out b, out a);
        Eina.Error.RaiseIfUnhandledException();
                                                                         }
    /// <summary>The color to be used for stroking the path.</summary>
    /// <param name="r">The red component of the given color.</param>
    /// <param name="g">The green component of the given color.</param>
    /// <param name="b">The blue component of the given color.</param>
    /// <param name="a">The alpha component of the given color.</param>
    virtual public void SetStrokeColor(int r, int g, int b, int a) {
                                                                                                         Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_color_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),r, g, b, a);
        Eina.Error.RaiseIfUnhandledException();
                                                                         }
    /// <summary>The stroke width to be used for stroking the path.</summary>
    /// <returns>Stroke width to be used</returns>
    virtual public double GetStrokeWidth() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_width_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The stroke width to be used for stroking the path.</summary>
    /// <param name="w">Stroke width to be used</param>
    virtual public void SetStrokeWidth(double w) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_width_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),w);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Not implemented</summary>
    /// <returns>Centered stroke location</returns>
    virtual public double GetStrokeLocation() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_location_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Not implemented</summary>
    /// <param name="centered">Centered stroke location</param>
    virtual public void SetStrokeLocation(double centered) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_location_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),centered);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Set stroke dash pattern. A dash pattern is specified by dashes, an array of <see cref="Efl.Gfx.Dash"/>. <see cref="Efl.Gfx.Dash"/> values(length, gap) must be positive.
    /// See also <see cref="Efl.Gfx.Dash"/></summary>
    /// <param name="dash">Stroke dash</param>
    /// <param name="length">Stroke dash length</param>
    virtual public void GetStrokeDash(out Efl.Gfx.Dash dash, out uint length) {
                         var _out_dash = new System.IntPtr();
                                Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_dash_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out _out_dash, out length);
        Eina.Error.RaiseIfUnhandledException();
        dash = Eina.PrimitiveConversion.PointerToManaged<Efl.Gfx.Dash>(_out_dash);
                                 }
    /// <summary>Set stroke dash pattern. A dash pattern is specified by dashes, an array of <see cref="Efl.Gfx.Dash"/>. <see cref="Efl.Gfx.Dash"/> values(length, gap) must be positive.
    /// See also <see cref="Efl.Gfx.Dash"/></summary>
    /// <param name="dash">Stroke dash</param>
    /// <param name="length">Stroke dash length</param>
    virtual public void SetStrokeDash(ref Efl.Gfx.Dash dash, uint length) {
         Efl.Gfx.Dash.NativeStruct _in_dash = dash;
                                                Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_dash_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),ref _in_dash, length);
        Eina.Error.RaiseIfUnhandledException();
                        dash = _in_dash;
                 }
    /// <summary>The cap style to be used for stroking the path. The cap will be used for capping the end point of a open subpath.
    /// See also <see cref="Efl.Gfx.Cap"/>.</summary>
    /// <returns>Cap style to use, default is <see cref="Efl.Gfx.Cap.Butt"/></returns>
    virtual public Efl.Gfx.Cap GetStrokeCap() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_cap_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The cap style to be used for stroking the path. The cap will be used for capping the end point of a open subpath.
    /// See also <see cref="Efl.Gfx.Cap"/>.</summary>
    /// <param name="c">Cap style to use, default is <see cref="Efl.Gfx.Cap.Butt"/></param>
    virtual public void SetStrokeCap(Efl.Gfx.Cap c) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_cap_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),c);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The join style to be used for stroking the path. The join style will be used for joining the two line segment while stroking the path.
    /// See also <see cref="Efl.Gfx.Join"/>.</summary>
    /// <returns>Join style to use, default is <see cref="Efl.Gfx.Join.Miter"/></returns>
    virtual public Efl.Gfx.Join GetStrokeJoin() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_join_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The join style to be used for stroking the path. The join style will be used for joining the two line segment while stroking the path.
    /// See also <see cref="Efl.Gfx.Join"/>.</summary>
    /// <param name="j">Join style to use, default is <see cref="Efl.Gfx.Join.Miter"/></param>
    virtual public void SetStrokeJoin(Efl.Gfx.Join j) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_stroke_join_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),j);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The fill rule of the given shape object. <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/>.</summary>
    /// <returns>The current fill rule of the shape object. One of <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/></returns>
    virtual public Efl.Gfx.FillRule GetFillRule() {
         var _ret_var = Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_fill_rule_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The fill rule of the given shape object. <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/>.</summary>
    /// <param name="fill_rule">The current fill rule of the shape object. One of <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/></param>
    virtual public void SetFillRule(Efl.Gfx.FillRule fill_rule) {
                                 Efl.Gfx.IShapeConcrete.NativeMethods.efl_gfx_shape_fill_rule_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),fill_rule);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Fill of the shape object</summary>
/// <value>Fill object</value>
    public Efl.Canvas.Vg.Node Fill {
        get { return GetFill(); }
        set { SetFill(value); }
    }
    /// <summary>Stroke fill of the shape object</summary>
/// <value>Stroke fill object</value>
    public Efl.Canvas.Vg.Node StrokeFill {
        get { return GetStrokeFill(); }
        set { SetStrokeFill(value); }
    }
    /// <summary>Stroke marker of the shape object</summary>
/// <value>Stroke marker object</value>
    public Efl.Canvas.Vg.Node StrokeMarker {
        get { return GetStrokeMarker(); }
        set { SetStrokeMarker(value); }
    }
    /// <summary>The stroke scale to be used for stroking the path. Will be used along with stroke width property.</summary>
/// <value>Stroke scale value</value>
    public double StrokeScale {
        get { return GetStrokeScale(); }
        set { SetStrokeScale(value); }
    }
    /// <summary>The stroke width to be used for stroking the path.</summary>
/// <value>Stroke width to be used</value>
    public double StrokeWidth {
        get { return GetStrokeWidth(); }
        set { SetStrokeWidth(value); }
    }
    /// <summary>Not implemented</summary>
/// <value>Centered stroke location</value>
    public double StrokeLocation {
        get { return GetStrokeLocation(); }
        set { SetStrokeLocation(value); }
    }
    /// <summary>The cap style to be used for stroking the path. The cap will be used for capping the end point of a open subpath.
/// See also <see cref="Efl.Gfx.Cap"/>.</summary>
/// <value>Cap style to use, default is <see cref="Efl.Gfx.Cap.Butt"/></value>
    public Efl.Gfx.Cap StrokeCap {
        get { return GetStrokeCap(); }
        set { SetStrokeCap(value); }
    }
    /// <summary>The join style to be used for stroking the path. The join style will be used for joining the two line segment while stroking the path.
/// See also <see cref="Efl.Gfx.Join"/>.</summary>
/// <value>Join style to use, default is <see cref="Efl.Gfx.Join.Miter"/></value>
    public Efl.Gfx.Join StrokeJoin {
        get { return GetStrokeJoin(); }
        set { SetStrokeJoin(value); }
    }
    /// <summary>The fill rule of the given shape object. <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/>.</summary>
/// <value>The current fill rule of the shape object. One of <see cref="Efl.Gfx.FillRule.Winding"/> or <see cref="Efl.Gfx.FillRule.OddEven"/></value>
    public Efl.Gfx.FillRule FillRule {
        get { return GetFillRule(); }
        set { SetFillRule(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.Vg.Shape.efl_canvas_vg_shape_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Vg.Node.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Evas);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_canvas_vg_shape_fill_get_static_delegate == null)
            {
                efl_canvas_vg_shape_fill_get_static_delegate = new efl_canvas_vg_shape_fill_get_delegate(fill_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_fill_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_fill_get_static_delegate) });
            }

            if (efl_canvas_vg_shape_fill_set_static_delegate == null)
            {
                efl_canvas_vg_shape_fill_set_static_delegate = new efl_canvas_vg_shape_fill_set_delegate(fill_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_fill_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_fill_set_static_delegate) });
            }

            if (efl_canvas_vg_shape_stroke_fill_get_static_delegate == null)
            {
                efl_canvas_vg_shape_stroke_fill_get_static_delegate = new efl_canvas_vg_shape_stroke_fill_get_delegate(stroke_fill_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_stroke_fill_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_stroke_fill_get_static_delegate) });
            }

            if (efl_canvas_vg_shape_stroke_fill_set_static_delegate == null)
            {
                efl_canvas_vg_shape_stroke_fill_set_static_delegate = new efl_canvas_vg_shape_stroke_fill_set_delegate(stroke_fill_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_stroke_fill_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_stroke_fill_set_static_delegate) });
            }

            if (efl_canvas_vg_shape_stroke_marker_get_static_delegate == null)
            {
                efl_canvas_vg_shape_stroke_marker_get_static_delegate = new efl_canvas_vg_shape_stroke_marker_get_delegate(stroke_marker_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeMarker") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_stroke_marker_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_stroke_marker_get_static_delegate) });
            }

            if (efl_canvas_vg_shape_stroke_marker_set_static_delegate == null)
            {
                efl_canvas_vg_shape_stroke_marker_set_static_delegate = new efl_canvas_vg_shape_stroke_marker_set_delegate(stroke_marker_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeMarker") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_shape_stroke_marker_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_shape_stroke_marker_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_scale_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_scale_get_static_delegate = new efl_gfx_shape_stroke_scale_get_delegate(stroke_scale_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeScale") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_scale_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_scale_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_scale_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_scale_set_static_delegate = new efl_gfx_shape_stroke_scale_set_delegate(stroke_scale_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeScale") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_scale_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_scale_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_color_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_color_get_static_delegate = new efl_gfx_shape_stroke_color_get_delegate(stroke_color_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeColor") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_color_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_color_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_color_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_color_set_static_delegate = new efl_gfx_shape_stroke_color_set_delegate(stroke_color_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeColor") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_color_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_color_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_width_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_width_get_static_delegate = new efl_gfx_shape_stroke_width_get_delegate(stroke_width_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeWidth") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_width_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_width_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_width_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_width_set_static_delegate = new efl_gfx_shape_stroke_width_set_delegate(stroke_width_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeWidth") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_width_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_width_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_location_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_location_get_static_delegate = new efl_gfx_shape_stroke_location_get_delegate(stroke_location_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeLocation") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_location_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_location_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_location_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_location_set_static_delegate = new efl_gfx_shape_stroke_location_set_delegate(stroke_location_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeLocation") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_location_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_location_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_dash_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_dash_get_static_delegate = new efl_gfx_shape_stroke_dash_get_delegate(stroke_dash_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeDash") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_dash_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_dash_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_dash_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_dash_set_static_delegate = new efl_gfx_shape_stroke_dash_set_delegate(stroke_dash_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeDash") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_dash_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_dash_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_cap_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_cap_get_static_delegate = new efl_gfx_shape_stroke_cap_get_delegate(stroke_cap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeCap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_cap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_cap_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_cap_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_cap_set_static_delegate = new efl_gfx_shape_stroke_cap_set_delegate(stroke_cap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeCap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_cap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_cap_set_static_delegate) });
            }

            if (efl_gfx_shape_stroke_join_get_static_delegate == null)
            {
                efl_gfx_shape_stroke_join_get_static_delegate = new efl_gfx_shape_stroke_join_get_delegate(stroke_join_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetStrokeJoin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_join_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_join_get_static_delegate) });
            }

            if (efl_gfx_shape_stroke_join_set_static_delegate == null)
            {
                efl_gfx_shape_stroke_join_set_static_delegate = new efl_gfx_shape_stroke_join_set_delegate(stroke_join_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetStrokeJoin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_stroke_join_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_stroke_join_set_static_delegate) });
            }

            if (efl_gfx_shape_fill_rule_get_static_delegate == null)
            {
                efl_gfx_shape_fill_rule_get_static_delegate = new efl_gfx_shape_fill_rule_get_delegate(fill_rule_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetFillRule") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_fill_rule_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_fill_rule_get_static_delegate) });
            }

            if (efl_gfx_shape_fill_rule_set_static_delegate == null)
            {
                efl_gfx_shape_fill_rule_set_static_delegate = new efl_gfx_shape_fill_rule_set_delegate(fill_rule_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetFillRule") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_shape_fill_rule_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_shape_fill_rule_set_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.Vg.Shape.efl_canvas_vg_shape_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_fill_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_fill_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_fill_get_api_delegate> efl_canvas_vg_shape_fill_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_fill_get_api_delegate>(Module, "efl_canvas_vg_shape_fill_get");

        private static Efl.Canvas.Vg.Node fill_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_fill_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Canvas.Vg.Node _ret_var = default(Efl.Canvas.Vg.Node);
                try
                {
                    _ret_var = ((Shape)wrapper).GetFill();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_canvas_vg_shape_fill_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_canvas_vg_shape_fill_get_delegate efl_canvas_vg_shape_fill_get_static_delegate;

        
        private delegate void efl_canvas_vg_shape_fill_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node f);

        
        public delegate void efl_canvas_vg_shape_fill_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node f);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_fill_set_api_delegate> efl_canvas_vg_shape_fill_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_fill_set_api_delegate>(Module, "efl_canvas_vg_shape_fill_set");

        private static void fill_set(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Vg.Node f)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_fill_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetFill(f);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_canvas_vg_shape_fill_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), f);
            }
        }

        private static efl_canvas_vg_shape_fill_set_delegate efl_canvas_vg_shape_fill_set_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_stroke_fill_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_stroke_fill_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_fill_get_api_delegate> efl_canvas_vg_shape_stroke_fill_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_fill_get_api_delegate>(Module, "efl_canvas_vg_shape_stroke_fill_get");

        private static Efl.Canvas.Vg.Node stroke_fill_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_stroke_fill_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Canvas.Vg.Node _ret_var = default(Efl.Canvas.Vg.Node);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeFill();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_canvas_vg_shape_stroke_fill_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_canvas_vg_shape_stroke_fill_get_delegate efl_canvas_vg_shape_stroke_fill_get_static_delegate;

        
        private delegate void efl_canvas_vg_shape_stroke_fill_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node f);

        
        public delegate void efl_canvas_vg_shape_stroke_fill_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node f);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_fill_set_api_delegate> efl_canvas_vg_shape_stroke_fill_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_fill_set_api_delegate>(Module, "efl_canvas_vg_shape_stroke_fill_set");

        private static void stroke_fill_set(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Vg.Node f)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_stroke_fill_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeFill(f);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_canvas_vg_shape_stroke_fill_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), f);
            }
        }

        private static efl_canvas_vg_shape_stroke_fill_set_delegate efl_canvas_vg_shape_stroke_fill_set_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_stroke_marker_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Vg.Node efl_canvas_vg_shape_stroke_marker_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_marker_get_api_delegate> efl_canvas_vg_shape_stroke_marker_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_marker_get_api_delegate>(Module, "efl_canvas_vg_shape_stroke_marker_get");

        private static Efl.Canvas.Vg.Node stroke_marker_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_stroke_marker_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Canvas.Vg.Node _ret_var = default(Efl.Canvas.Vg.Node);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeMarker();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_canvas_vg_shape_stroke_marker_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_canvas_vg_shape_stroke_marker_get_delegate efl_canvas_vg_shape_stroke_marker_get_static_delegate;

        
        private delegate void efl_canvas_vg_shape_stroke_marker_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node m);

        
        public delegate void efl_canvas_vg_shape_stroke_marker_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Vg.Node m);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_marker_set_api_delegate> efl_canvas_vg_shape_stroke_marker_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_shape_stroke_marker_set_api_delegate>(Module, "efl_canvas_vg_shape_stroke_marker_set");

        private static void stroke_marker_set(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Vg.Node m)
        {
            Eina.Log.Debug("function efl_canvas_vg_shape_stroke_marker_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeMarker(m);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_canvas_vg_shape_stroke_marker_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), m);
            }
        }

        private static efl_canvas_vg_shape_stroke_marker_set_delegate efl_canvas_vg_shape_stroke_marker_set_static_delegate;

        
        private delegate double efl_gfx_shape_stroke_scale_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_gfx_shape_stroke_scale_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_scale_get_api_delegate> efl_gfx_shape_stroke_scale_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_scale_get_api_delegate>(Module, "efl_gfx_shape_stroke_scale_get");

        private static double stroke_scale_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_scale_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeScale();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_stroke_scale_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_stroke_scale_get_delegate efl_gfx_shape_stroke_scale_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_scale_set_delegate(System.IntPtr obj, System.IntPtr pd,  double s);

        
        public delegate void efl_gfx_shape_stroke_scale_set_api_delegate(System.IntPtr obj,  double s);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_scale_set_api_delegate> efl_gfx_shape_stroke_scale_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_scale_set_api_delegate>(Module, "efl_gfx_shape_stroke_scale_set");

        private static void stroke_scale_set(System.IntPtr obj, System.IntPtr pd, double s)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_scale_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeScale(s);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_stroke_scale_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), s);
            }
        }

        private static efl_gfx_shape_stroke_scale_set_delegate efl_gfx_shape_stroke_scale_set_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_color_get_delegate(System.IntPtr obj, System.IntPtr pd,  out int r,  out int g,  out int b,  out int a);

        
        public delegate void efl_gfx_shape_stroke_color_get_api_delegate(System.IntPtr obj,  out int r,  out int g,  out int b,  out int a);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_color_get_api_delegate> efl_gfx_shape_stroke_color_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_color_get_api_delegate>(Module, "efl_gfx_shape_stroke_color_get");

        private static void stroke_color_get(System.IntPtr obj, System.IntPtr pd, out int r, out int g, out int b, out int a)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_color_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                        r = default(int);        g = default(int);        b = default(int);        a = default(int);                                            
                try
                {
                    ((Shape)wrapper).GetStrokeColor(out r, out g, out b, out a);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                                        
            }
            else
            {
                efl_gfx_shape_stroke_color_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out r, out g, out b, out a);
            }
        }

        private static efl_gfx_shape_stroke_color_get_delegate efl_gfx_shape_stroke_color_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_color_set_delegate(System.IntPtr obj, System.IntPtr pd,  int r,  int g,  int b,  int a);

        
        public delegate void efl_gfx_shape_stroke_color_set_api_delegate(System.IntPtr obj,  int r,  int g,  int b,  int a);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_color_set_api_delegate> efl_gfx_shape_stroke_color_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_color_set_api_delegate>(Module, "efl_gfx_shape_stroke_color_set");

        private static void stroke_color_set(System.IntPtr obj, System.IntPtr pd, int r, int g, int b, int a)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_color_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                                                                            
                try
                {
                    ((Shape)wrapper).SetStrokeColor(r, g, b, a);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                                        
            }
            else
            {
                efl_gfx_shape_stroke_color_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), r, g, b, a);
            }
        }

        private static efl_gfx_shape_stroke_color_set_delegate efl_gfx_shape_stroke_color_set_static_delegate;

        
        private delegate double efl_gfx_shape_stroke_width_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_gfx_shape_stroke_width_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_width_get_api_delegate> efl_gfx_shape_stroke_width_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_width_get_api_delegate>(Module, "efl_gfx_shape_stroke_width_get");

        private static double stroke_width_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_width_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeWidth();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_stroke_width_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_stroke_width_get_delegate efl_gfx_shape_stroke_width_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_width_set_delegate(System.IntPtr obj, System.IntPtr pd,  double w);

        
        public delegate void efl_gfx_shape_stroke_width_set_api_delegate(System.IntPtr obj,  double w);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_width_set_api_delegate> efl_gfx_shape_stroke_width_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_width_set_api_delegate>(Module, "efl_gfx_shape_stroke_width_set");

        private static void stroke_width_set(System.IntPtr obj, System.IntPtr pd, double w)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_width_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeWidth(w);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_stroke_width_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), w);
            }
        }

        private static efl_gfx_shape_stroke_width_set_delegate efl_gfx_shape_stroke_width_set_static_delegate;

        
        private delegate double efl_gfx_shape_stroke_location_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_gfx_shape_stroke_location_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_location_get_api_delegate> efl_gfx_shape_stroke_location_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_location_get_api_delegate>(Module, "efl_gfx_shape_stroke_location_get");

        private static double stroke_location_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_location_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeLocation();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_stroke_location_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_stroke_location_get_delegate efl_gfx_shape_stroke_location_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_location_set_delegate(System.IntPtr obj, System.IntPtr pd,  double centered);

        
        public delegate void efl_gfx_shape_stroke_location_set_api_delegate(System.IntPtr obj,  double centered);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_location_set_api_delegate> efl_gfx_shape_stroke_location_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_location_set_api_delegate>(Module, "efl_gfx_shape_stroke_location_set");

        private static void stroke_location_set(System.IntPtr obj, System.IntPtr pd, double centered)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_location_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeLocation(centered);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_stroke_location_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), centered);
            }
        }

        private static efl_gfx_shape_stroke_location_set_delegate efl_gfx_shape_stroke_location_set_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_dash_get_delegate(System.IntPtr obj, System.IntPtr pd,  out System.IntPtr dash,  out uint length);

        
        public delegate void efl_gfx_shape_stroke_dash_get_api_delegate(System.IntPtr obj,  out System.IntPtr dash,  out uint length);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_dash_get_api_delegate> efl_gfx_shape_stroke_dash_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_dash_get_api_delegate>(Module, "efl_gfx_shape_stroke_dash_get");

        private static void stroke_dash_get(System.IntPtr obj, System.IntPtr pd, out System.IntPtr dash, out uint length)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_dash_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        Efl.Gfx.Dash _out_dash = default(Efl.Gfx.Dash);
        length = default(uint);                            
                try
                {
                    ((Shape)wrapper).GetStrokeDash(out _out_dash, out length);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        dash = Eina.PrimitiveConversion.ManagedToPointerAlloc(_out_dash);
                                
            }
            else
            {
                efl_gfx_shape_stroke_dash_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out dash, out length);
            }
        }

        private static efl_gfx_shape_stroke_dash_get_delegate efl_gfx_shape_stroke_dash_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_dash_set_delegate(System.IntPtr obj, System.IntPtr pd,  ref Efl.Gfx.Dash.NativeStruct dash,  uint length);

        
        public delegate void efl_gfx_shape_stroke_dash_set_api_delegate(System.IntPtr obj,  ref Efl.Gfx.Dash.NativeStruct dash,  uint length);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_dash_set_api_delegate> efl_gfx_shape_stroke_dash_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_dash_set_api_delegate>(Module, "efl_gfx_shape_stroke_dash_set");

        private static void stroke_dash_set(System.IntPtr obj, System.IntPtr pd, ref Efl.Gfx.Dash.NativeStruct dash, uint length)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_dash_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        Efl.Gfx.Dash _in_dash = dash;
                                                    
                try
                {
                    ((Shape)wrapper).SetStrokeDash(ref _in_dash, length);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        dash = _in_dash;
                
            }
            else
            {
                efl_gfx_shape_stroke_dash_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), ref dash, length);
            }
        }

        private static efl_gfx_shape_stroke_dash_set_delegate efl_gfx_shape_stroke_dash_set_static_delegate;

        
        private delegate Efl.Gfx.Cap efl_gfx_shape_stroke_cap_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.Gfx.Cap efl_gfx_shape_stroke_cap_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_cap_get_api_delegate> efl_gfx_shape_stroke_cap_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_cap_get_api_delegate>(Module, "efl_gfx_shape_stroke_cap_get");

        private static Efl.Gfx.Cap stroke_cap_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_cap_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Gfx.Cap _ret_var = default(Efl.Gfx.Cap);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeCap();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_stroke_cap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_stroke_cap_get_delegate efl_gfx_shape_stroke_cap_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_cap_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.Cap c);

        
        public delegate void efl_gfx_shape_stroke_cap_set_api_delegate(System.IntPtr obj,  Efl.Gfx.Cap c);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_cap_set_api_delegate> efl_gfx_shape_stroke_cap_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_cap_set_api_delegate>(Module, "efl_gfx_shape_stroke_cap_set");

        private static void stroke_cap_set(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.Cap c)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_cap_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeCap(c);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_stroke_cap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), c);
            }
        }

        private static efl_gfx_shape_stroke_cap_set_delegate efl_gfx_shape_stroke_cap_set_static_delegate;

        
        private delegate Efl.Gfx.Join efl_gfx_shape_stroke_join_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.Gfx.Join efl_gfx_shape_stroke_join_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_join_get_api_delegate> efl_gfx_shape_stroke_join_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_join_get_api_delegate>(Module, "efl_gfx_shape_stroke_join_get");

        private static Efl.Gfx.Join stroke_join_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_join_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Gfx.Join _ret_var = default(Efl.Gfx.Join);
                try
                {
                    _ret_var = ((Shape)wrapper).GetStrokeJoin();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_stroke_join_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_stroke_join_get_delegate efl_gfx_shape_stroke_join_get_static_delegate;

        
        private delegate void efl_gfx_shape_stroke_join_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.Join j);

        
        public delegate void efl_gfx_shape_stroke_join_set_api_delegate(System.IntPtr obj,  Efl.Gfx.Join j);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_join_set_api_delegate> efl_gfx_shape_stroke_join_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_stroke_join_set_api_delegate>(Module, "efl_gfx_shape_stroke_join_set");

        private static void stroke_join_set(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.Join j)
        {
            Eina.Log.Debug("function efl_gfx_shape_stroke_join_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetStrokeJoin(j);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_stroke_join_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), j);
            }
        }

        private static efl_gfx_shape_stroke_join_set_delegate efl_gfx_shape_stroke_join_set_static_delegate;

        
        private delegate Efl.Gfx.FillRule efl_gfx_shape_fill_rule_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.Gfx.FillRule efl_gfx_shape_fill_rule_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_fill_rule_get_api_delegate> efl_gfx_shape_fill_rule_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_fill_rule_get_api_delegate>(Module, "efl_gfx_shape_fill_rule_get");

        private static Efl.Gfx.FillRule fill_rule_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_shape_fill_rule_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Gfx.FillRule _ret_var = default(Efl.Gfx.FillRule);
                try
                {
                    _ret_var = ((Shape)wrapper).GetFillRule();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_shape_fill_rule_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_shape_fill_rule_get_delegate efl_gfx_shape_fill_rule_get_static_delegate;

        
        private delegate void efl_gfx_shape_fill_rule_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.FillRule fill_rule);

        
        public delegate void efl_gfx_shape_fill_rule_set_api_delegate(System.IntPtr obj,  Efl.Gfx.FillRule fill_rule);

        public static Efl.Eo.FunctionWrapper<efl_gfx_shape_fill_rule_set_api_delegate> efl_gfx_shape_fill_rule_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_shape_fill_rule_set_api_delegate>(Module, "efl_gfx_shape_fill_rule_set");

        private static void fill_rule_set(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.FillRule fill_rule)
        {
            Eina.Log.Debug("function efl_gfx_shape_fill_rule_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Shape)wrapper).SetFillRule(fill_rule);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_shape_fill_rule_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), fill_rule);
            }
        }

        private static efl_gfx_shape_fill_rule_set_delegate efl_gfx_shape_fill_rule_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

}

