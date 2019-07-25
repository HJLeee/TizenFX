#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

/// <summary>EFL Gesture Momentum class</summary>
[Efl.Canvas.GestureMomentum.NativeMethods]
[Efl.Eo.BindingEntity]
public class GestureMomentum : Efl.Canvas.Gesture
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(GestureMomentum))
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
        efl_canvas_gesture_momentum_class_get();
    /// <summary>Initializes a new instance of the <see cref="GestureMomentum"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public GestureMomentum(Efl.Object parent= null
            ) : base(efl_canvas_gesture_momentum_class_get(), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Constructor to be used when objects are expected to be constructed from native code.</summary>
    /// <param name="ch">Tag struct storing the native handle of the object being constructed.</param>
    protected GestureMomentum(ConstructingHandle ch) : base(ch)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="GestureMomentum"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="wh">The native pointer to be wrapped.</param>
    protected GestureMomentum(Efl.Eo.Globals.WrappingHandle wh) : base(wh)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="GestureMomentum"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected GestureMomentum(IntPtr baseKlass, Efl.Object parent) : base(baseKlass, parent)
    {
    }

    /// <summary>Gets momentum value</summary>
    /// <returns>The momentum vector</returns>
    virtual public Eina.Vector2 GetMomentum() {
         var _ret_var = Efl.Canvas.GestureMomentum.NativeMethods.efl_gesture_momentum_get_ptr.Value.Delegate((IsGeneratedBindingClass ? this.NativeHandle : Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass)));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.GestureMomentum.efl_canvas_gesture_momentum_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Gesture.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Evas);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_gesture_momentum_get_static_delegate == null)
            {
                efl_gesture_momentum_get_static_delegate = new efl_gesture_momentum_get_delegate(momentum_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetMomentum") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gesture_momentum_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gesture_momentum_get_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.GestureMomentum.efl_canvas_gesture_momentum_class_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        
        private delegate Eina.Vector2.NativeStruct efl_gesture_momentum_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Vector2.NativeStruct efl_gesture_momentum_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gesture_momentum_get_api_delegate> efl_gesture_momentum_get_ptr = new Efl.Eo.FunctionWrapper<efl_gesture_momentum_get_api_delegate>(Module, "efl_gesture_momentum_get");

        private static Eina.Vector2.NativeStruct momentum_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gesture_momentum_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Eina.Vector2 _ret_var = default(Eina.Vector2);
                try
                {
                    _ret_var = ((GestureMomentum)ws.Target).GetMomentum();
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
                return efl_gesture_momentum_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gesture_momentum_get_delegate efl_gesture_momentum_get_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

