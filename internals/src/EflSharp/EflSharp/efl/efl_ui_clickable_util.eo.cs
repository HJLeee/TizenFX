#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

[Efl.Ui.ClickableUtil.NativeMethods]
public class ClickableUtil : Efl.Eo.EoWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(ClickableUtil))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_clickable_util_class_get();
    /// <summary>Initializes a new instance of the <see cref="ClickableUtil"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public ClickableUtil(Efl.Object parent= null
            ) : base(efl_ui_clickable_util_class_get(), typeof(ClickableUtil), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="ClickableUtil"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected ClickableUtil(System.IntPtr raw) : base(raw)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="ClickableUtil"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected ClickableUtil(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>This will listen to the standard events of a theme, and emit the events on clickable
    /// This means, widgets themselfs do not neccessarily need to listen to the theme signals. This function does this, and calls the correct clickable functions.</summary>
    /// <param name="kw_object">The object to listen on</param>
    /// <param name="clickable">The object to call the clickable events on</param>
    public static void BindToTheme(Efl.Canvas.Layout kw_object, Efl.Ui.IClickable clickable) {
                                                         Efl.Ui.ClickableUtil.NativeMethods.efl_ui_clickable_util_bind_to_theme_ptr.Value.Delegate(kw_object, clickable);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>This will listen to the standard events on a object, and call the correct methods on clickable
    /// This means, widgets themselfs do not neccessarily need to listen to the events on the object. This function does this, and calls the correct clickable functions.</summary>
    /// <param name="kw_object">The object to listen on</param>
    /// <param name="clickable">The object to call the clickable events on</param>
    public static void BindToObject(Efl.Input.IInterface kw_object, Efl.Ui.IClickable clickable) {
                                                         Efl.Ui.ClickableUtil.NativeMethods.efl_ui_clickable_util_bind_to_object_ptr.Value.Delegate(kw_object, clickable);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.ClickableUtil.efl_ui_clickable_util_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.ClickableUtil.efl_ui_clickable_util_class_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        
        private delegate void efl_ui_clickable_util_bind_to_theme_delegate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Layout kw_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.IClickable clickable);

        
        public delegate void efl_ui_clickable_util_bind_to_theme_api_delegate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Layout kw_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.IClickable clickable);

        public static Efl.Eo.FunctionWrapper<efl_ui_clickable_util_bind_to_theme_api_delegate> efl_ui_clickable_util_bind_to_theme_ptr = new Efl.Eo.FunctionWrapper<efl_ui_clickable_util_bind_to_theme_api_delegate>(Module, "efl_ui_clickable_util_bind_to_theme");

        private static void bind_to_theme(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Layout kw_object, Efl.Ui.IClickable clickable)
        {
            Eina.Log.Debug("function efl_ui_clickable_util_bind_to_theme was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ClickableUtil.BindToTheme(kw_object, clickable);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_clickable_util_bind_to_theme_ptr.Value.Delegate(kw_object, clickable);
            }
        }

        
        private delegate void efl_ui_clickable_util_bind_to_object_delegate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Input.IInterface kw_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.IClickable clickable);

        
        public delegate void efl_ui_clickable_util_bind_to_object_api_delegate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Input.IInterface kw_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.IClickable clickable);

        public static Efl.Eo.FunctionWrapper<efl_ui_clickable_util_bind_to_object_api_delegate> efl_ui_clickable_util_bind_to_object_ptr = new Efl.Eo.FunctionWrapper<efl_ui_clickable_util_bind_to_object_api_delegate>(Module, "efl_ui_clickable_util_bind_to_object");

        private static void bind_to_object(System.IntPtr obj, System.IntPtr pd, Efl.Input.IInterface kw_object, Efl.Ui.IClickable clickable)
        {
            Eina.Log.Debug("function efl_ui_clickable_util_bind_to_object was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ClickableUtil.BindToObject(kw_object, clickable);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_clickable_util_bind_to_object_ptr.Value.Delegate(kw_object, clickable);
            }
        }

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

