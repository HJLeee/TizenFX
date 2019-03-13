#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>Efl UI window class</summary>
[WinNativeInherit]
public class Win : Efl.Ui.Widget, Efl.Eo.IWrapper,Efl.Config,Efl.Content,Efl.Screen,Efl.Text,Efl.Access.Window,Efl.Canvas.Scene,Efl.Input.State,Efl.Ui.WidgetFocusManager,Efl.Ui.Focus.Manager,Efl.Ui.Focus.ManagerWindowRoot
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Ui.WinNativeInherit nativeInherit = new Efl.Ui.WinNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (Win))
            return Efl.Ui.WinNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      efl_ui_win_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   ///<param name="winName">The window name. See <see cref="Efl.Ui.Win.SetWinName"/></param>
   ///<param name="winType">The type of the window. See <see cref="Efl.Ui.Win.SetWinType"/></param>
   ///<param name="accelPreference">The hardware acceleration preference for this window. See <see cref="Efl.Ui.Win.SetAccelPreference"/></param>
   ///<param name="style">The widget style to use. See <see cref="Efl.Ui.Widget.SetStyle"/></param>
   public Win(Efl.Object parent
         ,  System.String winName = null, Efl.Ui.WinType? winType = null,  System.String accelPreference = null,  System.String style = null) :
      base(efl_ui_win_class_get(), typeof(Win), parent)
   {
      if (Efl.Eo.Globals.ParamHelperCheck(winName))
         SetWinName(Efl.Eo.Globals.GetParamHelper(winName));
      if (Efl.Eo.Globals.ParamHelperCheck(winType))
         SetWinType(Efl.Eo.Globals.GetParamHelper(winType));
      if (Efl.Eo.Globals.ParamHelperCheck(accelPreference))
         SetAccelPreference(Efl.Eo.Globals.GetParamHelper(accelPreference));
      if (Efl.Eo.Globals.ParamHelperCheck(style))
         SetStyle(Efl.Eo.Globals.GetParamHelper(style));
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public Win(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected Win(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static Win static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new Win(obj.NativeHandle);
   }
   ///<summary>Verifies if the given object is equal to this one.</summary>
   public override bool Equals(object obj)
   {
      var other = obj as Efl.Object;
      if (other == null)
         return false;
      return this.NativeHandle == other.NativeHandle;
   }
   ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
   public override int GetHashCode()
   {
      return this.NativeHandle.ToInt32();
   }
   ///<summary>Turns the native pointer into a string representation.</summary>
   public override String ToString()
   {
      return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
   }
private static object DeleteRequestEvtKey = new object();
   /// <summary>Called when the window receives a delete request</summary>
   public event EventHandler DeleteRequestEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_DELETE_REQUEST";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_DeleteRequestEvt_delegate)) {
               eventHandlers.AddHandler(DeleteRequestEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_DELETE_REQUEST";
            if (remove_cpp_event_handler(key, this.evt_DeleteRequestEvt_delegate)) { 
               eventHandlers.RemoveHandler(DeleteRequestEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event DeleteRequestEvt.</summary>
   public void On_DeleteRequestEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[DeleteRequestEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_DeleteRequestEvt_delegate;
   private void on_DeleteRequestEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_DeleteRequestEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WithdrawnEvtKey = new object();
   /// <summary>Called when window is withdrawn</summary>
   public event EventHandler WithdrawnEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_WITHDRAWN";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WithdrawnEvt_delegate)) {
               eventHandlers.AddHandler(WithdrawnEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_WITHDRAWN";
            if (remove_cpp_event_handler(key, this.evt_WithdrawnEvt_delegate)) { 
               eventHandlers.RemoveHandler(WithdrawnEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WithdrawnEvt.</summary>
   public void On_WithdrawnEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WithdrawnEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WithdrawnEvt_delegate;
   private void on_WithdrawnEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WithdrawnEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object MinimizedEvtKey = new object();
   /// <summary>Called when window is minimized</summary>
   public event EventHandler MinimizedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_MINIMIZED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_MinimizedEvt_delegate)) {
               eventHandlers.AddHandler(MinimizedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_MINIMIZED";
            if (remove_cpp_event_handler(key, this.evt_MinimizedEvt_delegate)) { 
               eventHandlers.RemoveHandler(MinimizedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event MinimizedEvt.</summary>
   public void On_MinimizedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[MinimizedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_MinimizedEvt_delegate;
   private void on_MinimizedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_MinimizedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object NormalEvtKey = new object();
   /// <summary>Called when window is set to normal state</summary>
   public event EventHandler NormalEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_NORMAL";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_NormalEvt_delegate)) {
               eventHandlers.AddHandler(NormalEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_NORMAL";
            if (remove_cpp_event_handler(key, this.evt_NormalEvt_delegate)) { 
               eventHandlers.RemoveHandler(NormalEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event NormalEvt.</summary>
   public void On_NormalEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[NormalEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_NormalEvt_delegate;
   private void on_NormalEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_NormalEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object StickEvtKey = new object();
   /// <summary>Called when window is set as sticky</summary>
   public event EventHandler StickEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_STICK";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_StickEvt_delegate)) {
               eventHandlers.AddHandler(StickEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_STICK";
            if (remove_cpp_event_handler(key, this.evt_StickEvt_delegate)) { 
               eventHandlers.RemoveHandler(StickEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event StickEvt.</summary>
   public void On_StickEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[StickEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_StickEvt_delegate;
   private void on_StickEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_StickEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object UnstickEvtKey = new object();
   /// <summary>Called when window is no  longer set as sticky</summary>
   public event EventHandler UnstickEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNSTICK";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_UnstickEvt_delegate)) {
               eventHandlers.AddHandler(UnstickEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNSTICK";
            if (remove_cpp_event_handler(key, this.evt_UnstickEvt_delegate)) { 
               eventHandlers.RemoveHandler(UnstickEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event UnstickEvt.</summary>
   public void On_UnstickEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[UnstickEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_UnstickEvt_delegate;
   private void on_UnstickEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_UnstickEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object FullscreenEvtKey = new object();
   /// <summary>Called when window is set to fullscreen</summary>
   public event EventHandler FullscreenEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_FULLSCREEN";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_FullscreenEvt_delegate)) {
               eventHandlers.AddHandler(FullscreenEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_FULLSCREEN";
            if (remove_cpp_event_handler(key, this.evt_FullscreenEvt_delegate)) { 
               eventHandlers.RemoveHandler(FullscreenEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event FullscreenEvt.</summary>
   public void On_FullscreenEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[FullscreenEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_FullscreenEvt_delegate;
   private void on_FullscreenEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_FullscreenEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object UnfullscreenEvtKey = new object();
   /// <summary>Called when window is no longer set to fullscreen</summary>
   public event EventHandler UnfullscreenEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNFULLSCREEN";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_UnfullscreenEvt_delegate)) {
               eventHandlers.AddHandler(UnfullscreenEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNFULLSCREEN";
            if (remove_cpp_event_handler(key, this.evt_UnfullscreenEvt_delegate)) { 
               eventHandlers.RemoveHandler(UnfullscreenEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event UnfullscreenEvt.</summary>
   public void On_UnfullscreenEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[UnfullscreenEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_UnfullscreenEvt_delegate;
   private void on_UnfullscreenEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_UnfullscreenEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object MaximizedEvtKey = new object();
   /// <summary>Called when window is set to maximized</summary>
   public event EventHandler MaximizedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_MAXIMIZED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_MaximizedEvt_delegate)) {
               eventHandlers.AddHandler(MaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_MAXIMIZED";
            if (remove_cpp_event_handler(key, this.evt_MaximizedEvt_delegate)) { 
               eventHandlers.RemoveHandler(MaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event MaximizedEvt.</summary>
   public void On_MaximizedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[MaximizedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_MaximizedEvt_delegate;
   private void on_MaximizedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_MaximizedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object UnmaximizedEvtKey = new object();
   /// <summary>Called when window is no longer set to maximized</summary>
   public event EventHandler UnmaximizedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNMAXIMIZED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_UnmaximizedEvt_delegate)) {
               eventHandlers.AddHandler(UnmaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_UNMAXIMIZED";
            if (remove_cpp_event_handler(key, this.evt_UnmaximizedEvt_delegate)) { 
               eventHandlers.RemoveHandler(UnmaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event UnmaximizedEvt.</summary>
   public void On_UnmaximizedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[UnmaximizedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_UnmaximizedEvt_delegate;
   private void on_UnmaximizedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_UnmaximizedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object IndicatorPropChangedEvtKey = new object();
   /// <summary>Called when indicator is property changed</summary>
   public event EventHandler IndicatorPropChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_INDICATOR_PROP_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_IndicatorPropChangedEvt_delegate)) {
               eventHandlers.AddHandler(IndicatorPropChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_INDICATOR_PROP_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_IndicatorPropChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(IndicatorPropChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event IndicatorPropChangedEvt.</summary>
   public void On_IndicatorPropChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[IndicatorPropChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_IndicatorPropChangedEvt_delegate;
   private void on_IndicatorPropChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_IndicatorPropChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object RotationChangedEvtKey = new object();
   /// <summary>Called when window rotation is changed</summary>
   public event EventHandler RotationChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_ROTATION_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_RotationChangedEvt_delegate)) {
               eventHandlers.AddHandler(RotationChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_ROTATION_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_RotationChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(RotationChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RotationChangedEvt.</summary>
   public void On_RotationChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[RotationChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RotationChangedEvt_delegate;
   private void on_RotationChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_RotationChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ProfileChangedEvtKey = new object();
   /// <summary>Called when profile is changed</summary>
   public event EventHandler ProfileChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_PROFILE_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_ProfileChangedEvt_delegate)) {
               eventHandlers.AddHandler(ProfileChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_PROFILE_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_ProfileChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(ProfileChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ProfileChangedEvt.</summary>
   public void On_ProfileChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ProfileChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ProfileChangedEvt_delegate;
   private void on_ProfileChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ProfileChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WmRotationChangedEvtKey = new object();
   /// <summary>Called when window manager rotation is changed</summary>
   public event EventHandler WmRotationChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_WM_ROTATION_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WmRotationChangedEvt_delegate)) {
               eventHandlers.AddHandler(WmRotationChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_WM_ROTATION_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_WmRotationChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WmRotationChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WmRotationChangedEvt.</summary>
   public void On_WmRotationChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WmRotationChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WmRotationChangedEvt_delegate;
   private void on_WmRotationChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WmRotationChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ThemeChangedEvtKey = new object();
   /// <summary>Called when theme is changed</summary>
   public event EventHandler ThemeChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_THEME_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_ThemeChangedEvt_delegate)) {
               eventHandlers.AddHandler(ThemeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_THEME_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_ThemeChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(ThemeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ThemeChangedEvt.</summary>
   public void On_ThemeChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ThemeChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ThemeChangedEvt_delegate;
   private void on_ThemeChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ThemeChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ElmActionBlock_menuEvtKey = new object();
   /// <summary>Called when elementary block menu action occurs</summary>
   public event EventHandler ElmActionBlock_menuEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_ELM_ACTION_BLOCK_MENU";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_ElmActionBlock_menuEvt_delegate)) {
               eventHandlers.AddHandler(ElmActionBlock_menuEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_ELM_ACTION_BLOCK_MENU";
            if (remove_cpp_event_handler(key, this.evt_ElmActionBlock_menuEvt_delegate)) { 
               eventHandlers.RemoveHandler(ElmActionBlock_menuEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ElmActionBlock_menuEvt.</summary>
   public void On_ElmActionBlock_menuEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ElmActionBlock_menuEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ElmActionBlock_menuEvt_delegate;
   private void on_ElmActionBlock_menuEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ElmActionBlock_menuEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object PauseEvtKey = new object();
   /// <summary>Called when the window is not going be displayed for some time</summary>
   public event EventHandler PauseEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_PAUSE";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_PauseEvt_delegate)) {
               eventHandlers.AddHandler(PauseEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_PAUSE";
            if (remove_cpp_event_handler(key, this.evt_PauseEvt_delegate)) { 
               eventHandlers.RemoveHandler(PauseEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event PauseEvt.</summary>
   public void On_PauseEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[PauseEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_PauseEvt_delegate;
   private void on_PauseEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_PauseEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ResumeEvtKey = new object();
   /// <summary>Called before a window is rendered after a pause event</summary>
   public event EventHandler ResumeEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_RESUME";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_ResumeEvt_delegate)) {
               eventHandlers.AddHandler(ResumeEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_WIN_EVENT_RESUME";
            if (remove_cpp_event_handler(key, this.evt_ResumeEvt_delegate)) { 
               eventHandlers.RemoveHandler(ResumeEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ResumeEvt.</summary>
   public void On_ResumeEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ResumeEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ResumeEvt_delegate;
   private void on_ResumeEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ResumeEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ContentChangedEvtKey = new object();
   /// <summary>Sent after the content is set or unset using the current content object.</summary>
   public event EventHandler<Efl.ContentContentChangedEvt_Args> ContentChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CONTENT_EVENT_CONTENT_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ContentChangedEvt_delegate)) {
               eventHandlers.AddHandler(ContentChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CONTENT_EVENT_CONTENT_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_ContentChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(ContentChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ContentChangedEvt.</summary>
   public void On_ContentChangedEvt(Efl.ContentContentChangedEvt_Args e)
   {
      EventHandler<Efl.ContentContentChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.ContentContentChangedEvt_Args>)eventHandlers[ContentChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ContentChangedEvt_delegate;
   private void on_ContentChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.ContentContentChangedEvt_Args args = new Efl.ContentContentChangedEvt_Args();
      args.arg = new Efl.Gfx.EntityConcrete(evt.Info);
      try {
         On_ContentChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowCreatedEvtKey = new object();
   /// <summary>Called when new window has been created.</summary>
   public event EventHandler WindowCreatedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_CREATED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowCreatedEvt_delegate)) {
               eventHandlers.AddHandler(WindowCreatedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_CREATED";
            if (remove_cpp_event_handler(key, this.evt_WindowCreatedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowCreatedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowCreatedEvt.</summary>
   public void On_WindowCreatedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowCreatedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowCreatedEvt_delegate;
   private void on_WindowCreatedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowCreatedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowDestroyedEvtKey = new object();
   /// <summary>Called when window has been destroyed.</summary>
   public event EventHandler WindowDestroyedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_DESTROYED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowDestroyedEvt_delegate)) {
               eventHandlers.AddHandler(WindowDestroyedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_DESTROYED";
            if (remove_cpp_event_handler(key, this.evt_WindowDestroyedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowDestroyedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowDestroyedEvt.</summary>
   public void On_WindowDestroyedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowDestroyedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowDestroyedEvt_delegate;
   private void on_WindowDestroyedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowDestroyedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowActivatedEvtKey = new object();
   /// <summary>Called when window has been activated. (focused)</summary>
   public event EventHandler WindowActivatedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_ACTIVATED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowActivatedEvt_delegate)) {
               eventHandlers.AddHandler(WindowActivatedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_ACTIVATED";
            if (remove_cpp_event_handler(key, this.evt_WindowActivatedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowActivatedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowActivatedEvt.</summary>
   public void On_WindowActivatedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowActivatedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowActivatedEvt_delegate;
   private void on_WindowActivatedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowActivatedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowDeactivatedEvtKey = new object();
   /// <summary>Called when window has been deactivated (unfocused).</summary>
   public event EventHandler WindowDeactivatedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_DEACTIVATED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowDeactivatedEvt_delegate)) {
               eventHandlers.AddHandler(WindowDeactivatedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_DEACTIVATED";
            if (remove_cpp_event_handler(key, this.evt_WindowDeactivatedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowDeactivatedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowDeactivatedEvt.</summary>
   public void On_WindowDeactivatedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowDeactivatedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowDeactivatedEvt_delegate;
   private void on_WindowDeactivatedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowDeactivatedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowMaximizedEvtKey = new object();
   /// <summary>Called when window has been maximized</summary>
   public event EventHandler WindowMaximizedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_MAXIMIZED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowMaximizedEvt_delegate)) {
               eventHandlers.AddHandler(WindowMaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_MAXIMIZED";
            if (remove_cpp_event_handler(key, this.evt_WindowMaximizedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowMaximizedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowMaximizedEvt.</summary>
   public void On_WindowMaximizedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowMaximizedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowMaximizedEvt_delegate;
   private void on_WindowMaximizedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowMaximizedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowMinimizedEvtKey = new object();
   /// <summary>Called when window has been minimized</summary>
   public event EventHandler WindowMinimizedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_MINIMIZED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowMinimizedEvt_delegate)) {
               eventHandlers.AddHandler(WindowMinimizedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_MINIMIZED";
            if (remove_cpp_event_handler(key, this.evt_WindowMinimizedEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowMinimizedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowMinimizedEvt.</summary>
   public void On_WindowMinimizedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowMinimizedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowMinimizedEvt_delegate;
   private void on_WindowMinimizedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowMinimizedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object WindowRestoredEvtKey = new object();
   /// <summary>Called when window has been restored</summary>
   public event EventHandler WindowRestoredEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_RESTORED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_WindowRestoredEvt_delegate)) {
               eventHandlers.AddHandler(WindowRestoredEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_ACCESS_WINDOW_EVENT_WINDOW_RESTORED";
            if (remove_cpp_event_handler(key, this.evt_WindowRestoredEvt_delegate)) { 
               eventHandlers.RemoveHandler(WindowRestoredEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event WindowRestoredEvt.</summary>
   public void On_WindowRestoredEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[WindowRestoredEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_WindowRestoredEvt_delegate;
   private void on_WindowRestoredEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_WindowRestoredEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Efl_Canvas_Scene_FocusInEvtKey = new object();
   /// <summary>Called when canvas got focus</summary>
    event EventHandler<Efl.Canvas.SceneFocusInEvt_Args> Efl.Canvas.Scene.FocusInEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_FOCUS_IN";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_Efl_Canvas_Scene_FocusInEvt_delegate)) {
               eventHandlers.AddHandler(Efl_Canvas_Scene_FocusInEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_FOCUS_IN";
            if (remove_cpp_event_handler(key, this.evt_Efl_Canvas_Scene_FocusInEvt_delegate)) { 
               eventHandlers.RemoveHandler(Efl_Canvas_Scene_FocusInEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Efl_Canvas_Scene_FocusInEvt.</summary>
   public void On_Efl_Canvas_Scene_FocusInEvt(Efl.Canvas.SceneFocusInEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneFocusInEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneFocusInEvt_Args>)eventHandlers[Efl_Canvas_Scene_FocusInEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Efl_Canvas_Scene_FocusInEvt_delegate;
   private void on_Efl_Canvas_Scene_FocusInEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneFocusInEvt_Args args = new Efl.Canvas.SceneFocusInEvt_Args();
      args.arg = new Efl.Input.Focus(evt.Info);
      try {
         On_Efl_Canvas_Scene_FocusInEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Efl_Canvas_Scene_FocusOutEvtKey = new object();
   /// <summary>Called when canvas lost focus</summary>
    event EventHandler<Efl.Canvas.SceneFocusOutEvt_Args> Efl.Canvas.Scene.FocusOutEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_FOCUS_OUT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_Efl_Canvas_Scene_FocusOutEvt_delegate)) {
               eventHandlers.AddHandler(Efl_Canvas_Scene_FocusOutEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_FOCUS_OUT";
            if (remove_cpp_event_handler(key, this.evt_Efl_Canvas_Scene_FocusOutEvt_delegate)) { 
               eventHandlers.RemoveHandler(Efl_Canvas_Scene_FocusOutEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Efl_Canvas_Scene_FocusOutEvt.</summary>
   public void On_Efl_Canvas_Scene_FocusOutEvt(Efl.Canvas.SceneFocusOutEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneFocusOutEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneFocusOutEvt_Args>)eventHandlers[Efl_Canvas_Scene_FocusOutEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Efl_Canvas_Scene_FocusOutEvt_delegate;
   private void on_Efl_Canvas_Scene_FocusOutEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneFocusOutEvt_Args args = new Efl.Canvas.SceneFocusOutEvt_Args();
      args.arg = new Efl.Input.Focus(evt.Info);
      try {
         On_Efl_Canvas_Scene_FocusOutEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ObjectFocusInEvtKey = new object();
   /// <summary>Called when object got focus</summary>
   public event EventHandler<Efl.Canvas.SceneObjectFocusInEvt_Args> ObjectFocusInEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_OBJECT_FOCUS_IN";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ObjectFocusInEvt_delegate)) {
               eventHandlers.AddHandler(ObjectFocusInEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_OBJECT_FOCUS_IN";
            if (remove_cpp_event_handler(key, this.evt_ObjectFocusInEvt_delegate)) { 
               eventHandlers.RemoveHandler(ObjectFocusInEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ObjectFocusInEvt.</summary>
   public void On_ObjectFocusInEvt(Efl.Canvas.SceneObjectFocusInEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneObjectFocusInEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneObjectFocusInEvt_Args>)eventHandlers[ObjectFocusInEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ObjectFocusInEvt_delegate;
   private void on_ObjectFocusInEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneObjectFocusInEvt_Args args = new Efl.Canvas.SceneObjectFocusInEvt_Args();
      args.arg = new Efl.Input.Focus(evt.Info);
      try {
         On_ObjectFocusInEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ObjectFocusOutEvtKey = new object();
   /// <summary>Called when object lost focus</summary>
   public event EventHandler<Efl.Canvas.SceneObjectFocusOutEvt_Args> ObjectFocusOutEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_OBJECT_FOCUS_OUT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ObjectFocusOutEvt_delegate)) {
               eventHandlers.AddHandler(ObjectFocusOutEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_OBJECT_FOCUS_OUT";
            if (remove_cpp_event_handler(key, this.evt_ObjectFocusOutEvt_delegate)) { 
               eventHandlers.RemoveHandler(ObjectFocusOutEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ObjectFocusOutEvt.</summary>
   public void On_ObjectFocusOutEvt(Efl.Canvas.SceneObjectFocusOutEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneObjectFocusOutEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneObjectFocusOutEvt_Args>)eventHandlers[ObjectFocusOutEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ObjectFocusOutEvt_delegate;
   private void on_ObjectFocusOutEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneObjectFocusOutEvt_Args args = new Efl.Canvas.SceneObjectFocusOutEvt_Args();
      args.arg = new Efl.Input.Focus(evt.Info);
      try {
         On_ObjectFocusOutEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object RenderPreEvtKey = new object();
   /// <summary>Called when pre render happens</summary>
   public event EventHandler RenderPreEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_RENDER_PRE";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_RenderPreEvt_delegate)) {
               eventHandlers.AddHandler(RenderPreEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_RENDER_PRE";
            if (remove_cpp_event_handler(key, this.evt_RenderPreEvt_delegate)) { 
               eventHandlers.RemoveHandler(RenderPreEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RenderPreEvt.</summary>
   public void On_RenderPreEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[RenderPreEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RenderPreEvt_delegate;
   private void on_RenderPreEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_RenderPreEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object RenderPostEvtKey = new object();
   /// <summary>Called when post render happens</summary>
   public event EventHandler<Efl.Canvas.SceneRenderPostEvt_Args> RenderPostEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_RENDER_POST";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_RenderPostEvt_delegate)) {
               eventHandlers.AddHandler(RenderPostEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_RENDER_POST";
            if (remove_cpp_event_handler(key, this.evt_RenderPostEvt_delegate)) { 
               eventHandlers.RemoveHandler(RenderPostEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RenderPostEvt.</summary>
   public void On_RenderPostEvt(Efl.Canvas.SceneRenderPostEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneRenderPostEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneRenderPostEvt_Args>)eventHandlers[RenderPostEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RenderPostEvt_delegate;
   private void on_RenderPostEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneRenderPostEvt_Args args = new Efl.Canvas.SceneRenderPostEvt_Args();
      args.arg =  evt.Info;;
      try {
         On_RenderPostEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object DeviceChangedEvtKey = new object();
   /// <summary>Called when input device changed</summary>
   public event EventHandler<Efl.Canvas.SceneDeviceChangedEvt_Args> DeviceChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_DeviceChangedEvt_delegate)) {
               eventHandlers.AddHandler(DeviceChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_DeviceChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(DeviceChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event DeviceChangedEvt.</summary>
   public void On_DeviceChangedEvt(Efl.Canvas.SceneDeviceChangedEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneDeviceChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneDeviceChangedEvt_Args>)eventHandlers[DeviceChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_DeviceChangedEvt_delegate;
   private void on_DeviceChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneDeviceChangedEvt_Args args = new Efl.Canvas.SceneDeviceChangedEvt_Args();
      args.arg = new Efl.Input.Device(evt.Info);
      try {
         On_DeviceChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object DeviceAddedEvtKey = new object();
   /// <summary>Called when input device was added</summary>
   public event EventHandler<Efl.Canvas.SceneDeviceAddedEvt_Args> DeviceAddedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_ADDED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_DeviceAddedEvt_delegate)) {
               eventHandlers.AddHandler(DeviceAddedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_ADDED";
            if (remove_cpp_event_handler(key, this.evt_DeviceAddedEvt_delegate)) { 
               eventHandlers.RemoveHandler(DeviceAddedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event DeviceAddedEvt.</summary>
   public void On_DeviceAddedEvt(Efl.Canvas.SceneDeviceAddedEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneDeviceAddedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneDeviceAddedEvt_Args>)eventHandlers[DeviceAddedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_DeviceAddedEvt_delegate;
   private void on_DeviceAddedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneDeviceAddedEvt_Args args = new Efl.Canvas.SceneDeviceAddedEvt_Args();
      args.arg = new Efl.Input.Device(evt.Info);
      try {
         On_DeviceAddedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object DeviceRemovedEvtKey = new object();
   /// <summary>Called when input device was removed</summary>
   public event EventHandler<Efl.Canvas.SceneDeviceRemovedEvt_Args> DeviceRemovedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_REMOVED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_DeviceRemovedEvt_delegate)) {
               eventHandlers.AddHandler(DeviceRemovedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_CANVAS_SCENE_EVENT_DEVICE_REMOVED";
            if (remove_cpp_event_handler(key, this.evt_DeviceRemovedEvt_delegate)) { 
               eventHandlers.RemoveHandler(DeviceRemovedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event DeviceRemovedEvt.</summary>
   public void On_DeviceRemovedEvt(Efl.Canvas.SceneDeviceRemovedEvt_Args e)
   {
      EventHandler<Efl.Canvas.SceneDeviceRemovedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Canvas.SceneDeviceRemovedEvt_Args>)eventHandlers[DeviceRemovedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_DeviceRemovedEvt_delegate;
   private void on_DeviceRemovedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Canvas.SceneDeviceRemovedEvt_Args args = new Efl.Canvas.SceneDeviceRemovedEvt_Args();
      args.arg = new Efl.Input.Device(evt.Info);
      try {
         On_DeviceRemovedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object RedirectChangedEvtKey = new object();
   /// <summary>Redirect object has changed, the old manager is passed as an event argument.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args> RedirectChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_RedirectChangedEvt_delegate)) {
               eventHandlers.AddHandler(RedirectChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_RedirectChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(RedirectChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RedirectChangedEvt.</summary>
   public void On_RedirectChangedEvt(Efl.Ui.Focus.ManagerRedirectChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args>)eventHandlers[RedirectChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RedirectChangedEvt_delegate;
   private void on_RedirectChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerRedirectChangedEvt_Args args = new Efl.Ui.Focus.ManagerRedirectChangedEvt_Args();
      args.arg = new Efl.Ui.Focus.ManagerConcrete(evt.Info);
      try {
         On_RedirectChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object FlushPreEvtKey = new object();
   /// <summary>After this event, the manager object will calculate relations in the graph. Can be used to add / remove children in a lazy fashion.
   /// 1.20</summary>
   public event EventHandler FlushPreEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_FlushPreEvt_delegate)) {
               eventHandlers.AddHandler(FlushPreEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
            if (remove_cpp_event_handler(key, this.evt_FlushPreEvt_delegate)) { 
               eventHandlers.RemoveHandler(FlushPreEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event FlushPreEvt.</summary>
   public void On_FlushPreEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[FlushPreEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_FlushPreEvt_delegate;
   private void on_FlushPreEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_FlushPreEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object CoordsDirtyEvtKey = new object();
   /// <summary>Cached relationship calculation results have been invalidated.
   /// 1.20</summary>
   public event EventHandler CoordsDirtyEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_CoordsDirtyEvt_delegate)) {
               eventHandlers.AddHandler(CoordsDirtyEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
            if (remove_cpp_event_handler(key, this.evt_CoordsDirtyEvt_delegate)) { 
               eventHandlers.RemoveHandler(CoordsDirtyEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event CoordsDirtyEvt.</summary>
   public void On_CoordsDirtyEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[CoordsDirtyEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_CoordsDirtyEvt_delegate;
   private void on_CoordsDirtyEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_CoordsDirtyEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Manager_focusChangedEvtKey = new object();
   /// <summary>The manager_focus property has changed. The previously focused object is passed as an event argument.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args> Manager_focusChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_Manager_focusChangedEvt_delegate)) {
               eventHandlers.AddHandler(Manager_focusChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_Manager_focusChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(Manager_focusChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Manager_focusChangedEvt.</summary>
   public void On_Manager_focusChangedEvt(Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args>)eventHandlers[Manager_focusChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Manager_focusChangedEvt_delegate;
   private void on_Manager_focusChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args args = new Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args();
      args.arg = new Efl.Ui.Focus.ObjectConcrete(evt.Info);
      try {
         On_Manager_focusChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Dirty_logic_freezeChangedEvtKey = new object();
   /// <summary>Called when this focus manager is frozen or thawed, even_info beeing <c>true</c> indicates that it is now frozen, <c>false</c> indicates that it is thawed.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args> Dirty_logic_freezeChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_Dirty_logic_freezeChangedEvt_delegate)) {
               eventHandlers.AddHandler(Dirty_logic_freezeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_Dirty_logic_freezeChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(Dirty_logic_freezeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Dirty_logic_freezeChangedEvt.</summary>
   public void On_Dirty_logic_freezeChangedEvt(Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args>)eventHandlers[Dirty_logic_freezeChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Dirty_logic_freezeChangedEvt_delegate;
   private void on_Dirty_logic_freezeChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args args = new Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args();
      args.arg = evt.Info != IntPtr.Zero;
      try {
         On_Dirty_logic_freezeChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

   protected override void register_event_proxies()
   {
      base.register_event_proxies();
      evt_DeleteRequestEvt_delegate = new Efl.EventCb(on_DeleteRequestEvt_NativeCallback);
      evt_WithdrawnEvt_delegate = new Efl.EventCb(on_WithdrawnEvt_NativeCallback);
      evt_MinimizedEvt_delegate = new Efl.EventCb(on_MinimizedEvt_NativeCallback);
      evt_NormalEvt_delegate = new Efl.EventCb(on_NormalEvt_NativeCallback);
      evt_StickEvt_delegate = new Efl.EventCb(on_StickEvt_NativeCallback);
      evt_UnstickEvt_delegate = new Efl.EventCb(on_UnstickEvt_NativeCallback);
      evt_FullscreenEvt_delegate = new Efl.EventCb(on_FullscreenEvt_NativeCallback);
      evt_UnfullscreenEvt_delegate = new Efl.EventCb(on_UnfullscreenEvt_NativeCallback);
      evt_MaximizedEvt_delegate = new Efl.EventCb(on_MaximizedEvt_NativeCallback);
      evt_UnmaximizedEvt_delegate = new Efl.EventCb(on_UnmaximizedEvt_NativeCallback);
      evt_IndicatorPropChangedEvt_delegate = new Efl.EventCb(on_IndicatorPropChangedEvt_NativeCallback);
      evt_RotationChangedEvt_delegate = new Efl.EventCb(on_RotationChangedEvt_NativeCallback);
      evt_ProfileChangedEvt_delegate = new Efl.EventCb(on_ProfileChangedEvt_NativeCallback);
      evt_WmRotationChangedEvt_delegate = new Efl.EventCb(on_WmRotationChangedEvt_NativeCallback);
      evt_ThemeChangedEvt_delegate = new Efl.EventCb(on_ThemeChangedEvt_NativeCallback);
      evt_ElmActionBlock_menuEvt_delegate = new Efl.EventCb(on_ElmActionBlock_menuEvt_NativeCallback);
      evt_PauseEvt_delegate = new Efl.EventCb(on_PauseEvt_NativeCallback);
      evt_ResumeEvt_delegate = new Efl.EventCb(on_ResumeEvt_NativeCallback);
      evt_ContentChangedEvt_delegate = new Efl.EventCb(on_ContentChangedEvt_NativeCallback);
      evt_WindowCreatedEvt_delegate = new Efl.EventCb(on_WindowCreatedEvt_NativeCallback);
      evt_WindowDestroyedEvt_delegate = new Efl.EventCb(on_WindowDestroyedEvt_NativeCallback);
      evt_WindowActivatedEvt_delegate = new Efl.EventCb(on_WindowActivatedEvt_NativeCallback);
      evt_WindowDeactivatedEvt_delegate = new Efl.EventCb(on_WindowDeactivatedEvt_NativeCallback);
      evt_WindowMaximizedEvt_delegate = new Efl.EventCb(on_WindowMaximizedEvt_NativeCallback);
      evt_WindowMinimizedEvt_delegate = new Efl.EventCb(on_WindowMinimizedEvt_NativeCallback);
      evt_WindowRestoredEvt_delegate = new Efl.EventCb(on_WindowRestoredEvt_NativeCallback);
      evt_Efl_Canvas_Scene_FocusInEvt_delegate = new Efl.EventCb(on_Efl_Canvas_Scene_FocusInEvt_NativeCallback);
      evt_Efl_Canvas_Scene_FocusOutEvt_delegate = new Efl.EventCb(on_Efl_Canvas_Scene_FocusOutEvt_NativeCallback);
      evt_ObjectFocusInEvt_delegate = new Efl.EventCb(on_ObjectFocusInEvt_NativeCallback);
      evt_ObjectFocusOutEvt_delegate = new Efl.EventCb(on_ObjectFocusOutEvt_NativeCallback);
      evt_RenderPreEvt_delegate = new Efl.EventCb(on_RenderPreEvt_NativeCallback);
      evt_RenderPostEvt_delegate = new Efl.EventCb(on_RenderPostEvt_NativeCallback);
      evt_DeviceChangedEvt_delegate = new Efl.EventCb(on_DeviceChangedEvt_NativeCallback);
      evt_DeviceAddedEvt_delegate = new Efl.EventCb(on_DeviceAddedEvt_NativeCallback);
      evt_DeviceRemovedEvt_delegate = new Efl.EventCb(on_DeviceRemovedEvt_NativeCallback);
      evt_RedirectChangedEvt_delegate = new Efl.EventCb(on_RedirectChangedEvt_NativeCallback);
      evt_FlushPreEvt_delegate = new Efl.EventCb(on_FlushPreEvt_NativeCallback);
      evt_CoordsDirtyEvt_delegate = new Efl.EventCb(on_CoordsDirtyEvt_NativeCallback);
      evt_Manager_focusChangedEvt_delegate = new Efl.EventCb(on_Manager_focusChangedEvt_NativeCallback);
      evt_Dirty_logic_freezeChangedEvt_delegate = new Efl.EventCb(on_Dirty_logic_freezeChangedEvt_NativeCallback);
   }
   /// <summary>In some environments you may have an indicator that shows battery status, reception, time etc. This is the indicator.
   /// Sometimes you don&apos;t want this because you provide the same functionality inside your app, so this will request that the indicator is disabled in such circumstances. The default settings depends on the environment. For example, on phones, the default is to enable the indicator. The indicator is disabled on devices like televisions however.
   /// 1.18</summary>
   /// <returns>The mype, one of <see cref="Efl.Ui.WinIndicatorMode"/>.</returns>
   virtual public Efl.Ui.WinIndicatorMode GetIndicatorMode() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_indicator_mode_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>In some environments you may have an indicator that shows battery status, reception, time etc. This is the indicator.
   /// Sometimes you don&apos;t want this because you provide the same functionality inside your app, so this will request that the indicator is disabled in such circumstances. The default settings depends on the environment. For example, on phones, the default is to enable the indicator. The indicator is disabled on devices like televisions however.
   /// 1.18</summary>
   /// <param name="type">The mype, one of <see cref="Efl.Ui.WinIndicatorMode"/>.</param>
   /// <returns></returns>
   virtual public  void SetIndicatorMode( Efl.Ui.WinIndicatorMode type) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_indicator_mode_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), type);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the keyboard mode of the window.</summary>
   /// <returns>The mode, one of <see cref="Efl.Ui.WinKeyboardMode"/>.</returns>
   virtual public Efl.Ui.WinKeyboardMode GetKeyboardMode() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_keyboard_mode_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Sets the keyboard mode of the window.</summary>
   /// <param name="mode">The mode, one of <see cref="Efl.Ui.WinKeyboardMode"/>.</param>
   /// <returns></returns>
   virtual public  void SetKeyboardMode( Efl.Ui.WinKeyboardMode mode) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_keyboard_mode_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), mode);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Defines which rotations this window supports.
   /// The window manager will refer to these hints and rotate the window accordingly, depending on the device orientation, for instance.</summary>
   /// <param name="allow_0">Normal orientation.</param>
   /// <param name="allow_90">Rotated 90 degrees CCW.</param>
   /// <param name="allow_180">Rotated 180 degrees.</param>
   /// <param name="allow_270">Rotated 270 degrees CCW (i.e. 90 CW).</param>
   /// <returns>Returns <c>false</c> if available rotations were not specified.</returns>
   virtual public bool GetWmAvailableRotations( out bool allow_0,  out bool allow_90,  out bool allow_180,  out bool allow_270) {
                                                                               var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_wm_available_rotations_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out allow_0,  out allow_90,  out allow_180,  out allow_270);
      Eina.Error.RaiseIfUnhandledException();
                                                      return _ret_var;
 }
   /// <summary>Defines which rotations this window supports.
   /// The window manager will refer to these hints and rotate the window accordingly, depending on the device orientation, for instance.</summary>
   /// <param name="allow_0">Normal orientation.</param>
   /// <param name="allow_90">Rotated 90 degrees CCW.</param>
   /// <param name="allow_180">Rotated 180 degrees.</param>
   /// <param name="allow_270">Rotated 270 degrees CCW (i.e. 90 CW).</param>
   /// <returns></returns>
   virtual public  void SetWmAvailableRotations( bool allow_0,  bool allow_90,  bool allow_180,  bool allow_270) {
                                                                               Efl.Ui.WinNativeInherit.efl_ui_win_wm_available_rotations_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), allow_0,  allow_90,  allow_180,  allow_270);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Available profiles on a window.</summary>
   /// <returns>A list of profiles.</returns>
   virtual public Eina.Array< System.String> GetWmAvailableProfiles() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_wm_available_profiles_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return new Eina.Array< System.String>(_ret_var, false, false);
 }
   /// <summary>Available profiles on a window.</summary>
   /// <param name="profiles">A list of profiles.</param>
   /// <returns></returns>
   virtual public  void SetWmAvailableProfiles( Eina.Array< System.String> profiles) {
       var _in_profiles = profiles.Handle;
                  Efl.Ui.WinNativeInherit.efl_ui_win_wm_available_profiles_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_profiles);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the constraints on the maximum width and height of a window relative to the width and height of the screen.
   /// When this function returns <c>true</c>, <c>obj</c> will never resize larger than the screen.</summary>
   /// <returns><c>true</c> to restrict the window&apos;s maximum size.</returns>
   virtual public bool GetScreenConstrain() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_screen_constrain_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Constrain the maximum width and height of a window to the width and height of the screen.
   /// When <c>constrain</c> is <c>true</c>, <c>obj</c> will never resize larger than the screen.</summary>
   /// <param name="constrain"><c>true</c> to restrict the window&apos;s maximum size.</param>
   /// <returns></returns>
   virtual public  void SetScreenConstrain( bool constrain) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_screen_constrain_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), constrain);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the window to be skipped by keyboard focus.
   /// This sets the window to be skipped by normal keyboard input. This means a window manager will be asked not to focus this window as well as omit it from things like the taskbar, pager, &quot;alt-tab&quot; list etc. etc.
   /// 
   /// Call this and enable it on a window BEFORE you show it for the first time, otherwise it may have no effect.
   /// 
   /// Use this for windows that have only output information or might only be interacted with by the mouse or touchscreen, never for typing. This may have side-effects like making the window non-accessible in some cases unless the window is specially handled. Use this with care.</summary>
   /// <param name="skip">The skip flag state (<c>true</c> if it is to be skipped).</param>
   /// <returns></returns>
   virtual public  void SetPropFocusSkip( bool skip) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_prop_focus_skip_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), skip);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Window&apos;s autohide state.
   /// When closing the window in any way outside of the program control, like pressing the X button in the titlebar or using a command from the Window Manager, a &quot;delete,request&quot; signal is emitted to indicate that this event occurred and the developer can take any action, which may include, or not, destroying the window object.
   /// 
   /// When this property is set to <c>true</c>, the window will be automatically hidden when this event occurs, after the signal is emitted. If this property is <c>false</c> nothing will happen, beyond the event emission.
   /// 
   /// C applications can use this option along with the quit policy <c>ELM_POLICY_QUIT_LAST_WINDOW_HIDDEN</c> which allows exiting EFL&apos;s main loop when all the windows are hidden.
   /// 
   /// Note: <c>autodel</c> and <c>autohide</c> are not mutually exclusive. The window will be deleted if both are set to <c>true</c>.</summary>
   /// <returns>If <c>true</c>, the window will automatically hide itself when closed.</returns>
   virtual public bool GetAutohide() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_autohide_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Window&apos;s autohide state.
   /// When closing the window in any way outside of the program control, like pressing the X button in the titlebar or using a command from the Window Manager, a &quot;delete,request&quot; signal is emitted to indicate that this event occurred and the developer can take any action, which may include, or not, destroying the window object.
   /// 
   /// When this property is set to <c>true</c>, the window will be automatically hidden when this event occurs, after the signal is emitted. If this property is <c>false</c> nothing will happen, beyond the event emission.
   /// 
   /// C applications can use this option along with the quit policy <c>ELM_POLICY_QUIT_LAST_WINDOW_HIDDEN</c> which allows exiting EFL&apos;s main loop when all the windows are hidden.
   /// 
   /// Note: <c>autodel</c> and <c>autohide</c> are not mutually exclusive. The window will be deleted if both are set to <c>true</c>.</summary>
   /// <param name="autohide">If <c>true</c>, the window will automatically hide itself when closed.</param>
   /// <returns></returns>
   virtual public  void SetAutohide( bool autohide) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_autohide_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), autohide);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Enable quitting the main loop when this window is closed.
   /// When set, the window&apos;s loop object will exit using the passed exit code if the window is closed.
   /// 
   /// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
   /// <returns>The exit code to use when exiting</returns>
   virtual public  Eina.Value GetExitOnClose() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_exit_on_close_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Enable quitting the main loop when this window is closed.
   /// When set, the window&apos;s loop object will exit using the passed exit code if the window is closed.
   /// 
   /// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
   /// <param name="exit_code">The exit code to use when exiting</param>
   /// <returns></returns>
   virtual public  void SetExitOnClose(  Eina.Value exit_code) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_exit_on_close_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), exit_code);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the icon object used for the window.
   /// The object returns is the one marked by <see cref="Efl.Ui.Win.SetIconObject"/> as the object to use for the window icon.</summary>
   /// <returns>The Evas image object to use for an icon.</returns>
   virtual public Efl.Canvas.Object GetIconObject() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_icon_object_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set a window object&apos;s icon.
   /// This sets an image to be used as the icon for the given window, in the window manager decoration part. The exact pixel dimensions of the object (not object size) will be used and the image pixels will be used as-is when this function is called. If the image object has been updated, then call this function again to source the image pixels and place them in the window&apos;s icon. Note that only objects of type <see cref="Efl.Canvas.Image"/> or <see cref="Efl.Ui.Image"/> are allowed.</summary>
   /// <param name="icon">The image object to use for an icon.</param>
   /// <returns></returns>
   virtual public  void SetIconObject( Efl.Canvas.Object icon) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_icon_object_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), icon);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the minimized state of a window.</summary>
   /// <returns>If <c>true</c>, the window is minimized.</returns>
   virtual public bool GetMinimized() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_minimized_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the minimized state of a window.</summary>
   /// <param name="state">If <c>true</c>, the window is minimized.</param>
   /// <returns></returns>
   virtual public  void SetMinimized( bool state) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_minimized_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), state);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the maximized state of a window.</summary>
   /// <returns>If <c>true</c>, the window is maximized.</returns>
   virtual public bool GetMaximized() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_maximized_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the maximized state of a window.</summary>
   /// <param name="maximized">If <c>true</c>, the window is maximized.</param>
   /// <returns></returns>
   virtual public  void SetMaximized( bool maximized) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_maximized_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), maximized);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the fullscreen state of a window.</summary>
   /// <returns>If <c>true</c>, the window is fullscreen.</returns>
   virtual public bool GetFullscreen() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_fullscreen_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the fullscreen state of a window.</summary>
   /// <param name="fullscreen">If <c>true</c>, the window is fullscreen.</param>
   /// <returns></returns>
   virtual public  void SetFullscreen( bool fullscreen) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_fullscreen_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), fullscreen);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the sticky state of the window.</summary>
   /// <returns>If <c>true</c>, the window&apos;s sticky state is enabled.</returns>
   virtual public bool GetSticky() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_sticky_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the sticky state of the window.
   /// Hints the Window Manager that the window in <c>obj</c> should be left fixed at its position even when the virtual desktop it&apos;s on moves or changes.</summary>
   /// <param name="sticky">If <c>true</c>, the window&apos;s sticky state is enabled.</param>
   /// <returns></returns>
   virtual public  void SetSticky( bool sticky) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_sticky_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), sticky);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the urgent state of a window.</summary>
   /// <returns>The mode of a urgent window, one of <see cref="Efl.Ui.WinUrgentMode"/>.</returns>
   virtual public Efl.Ui.WinUrgentMode GetUrgent() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_urgent_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the urgent state of a window.</summary>
   /// <param name="urgent">The mode of a urgent window, one of <see cref="Efl.Ui.WinUrgentMode"/>.</param>
   /// <returns></returns>
   virtual public  void SetUrgent( Efl.Ui.WinUrgentMode urgent) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_urgent_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), urgent);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the modal state of a window.</summary>
   /// <returns>The mode of a window, one of <see cref="Efl.Ui.WinModalMode"/>.</returns>
   virtual public Efl.Ui.WinModalMode GetModal() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_modal_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the modal state of a window.</summary>
   /// <param name="modal">The mode of a window, one of <see cref="Efl.Ui.WinModalMode"/>.</param>
   /// <returns></returns>
   virtual public  void SetModal( Efl.Ui.WinModalMode modal) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_modal_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), modal);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the noblank property of a window.
   /// 1.11</summary>
   /// <returns>If <c>true</c>, the window is set to noblank.</returns>
   virtual public bool GetNoblank() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_noblank_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the noblank property of a window.
   /// The &quot;noblank&quot; property is a way to request the display on which the window is shown does not blank, go to screensaver or otherwise hide or obscure the window. It is intended for uses such as media playback on a television where a user may not want to be interrupted by an idle screen. The noblank property may have no effect if the window is minimized or hidden.
   /// 1.11</summary>
   /// <param name="noblank">If <c>true</c>, the window is set to noblank.</param>
   /// <returns></returns>
   virtual public  void SetNoblank( bool noblank) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_noblank_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), noblank);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the borderless state of a window.</summary>
   /// <returns>If <c>true</c>, the window is borderless.</returns>
   virtual public bool GetBorderless() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_borderless_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the borderless state of a window.
   /// This function requests the Window Manager not to draw any decoration around the window.</summary>
   /// <param name="borderless">If <c>true</c>, the window is borderless.</param>
   /// <returns></returns>
   virtual public  void SetBorderless( bool borderless) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_borderless_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), borderless);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the role of the window.
   /// The returned string is an internal one and should not be freed or modified. It will also be invalid if a new role is set or if the window is destroyed.</summary>
   /// <returns>The role to set.</returns>
   virtual public  System.String GetWinRole() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_role_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the role of the window.</summary>
   /// <param name="role">The role to set.</param>
   /// <returns></returns>
   virtual public  void SetWinRole(  System.String role) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_role_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), role);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>No description supplied.
   /// 1.18</summary>
   /// <returns>Window name</returns>
   virtual public  System.String GetWinName() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_name_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Name can only be set before finalize.</summary>
   /// <param name="name">Window name</param>
   /// <returns></returns>
   virtual public  void SetWinName(  System.String name) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_name_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>If the object is not window object, returns <c>unknown</c>.</summary>
   /// <returns>Window type</returns>
   virtual public Efl.Ui.WinType GetWinType() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_type_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Type can on be set before finalize.</summary>
   /// <param name="type">Window type</param>
   /// <returns></returns>
   virtual public  void SetWinType( Efl.Ui.WinType type) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_type_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), type);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>This will return the value of &quot;accel_preference&quot; when the window was created.</summary>
   /// <returns>Acceleration</returns>
   virtual public  System.String GetAccelPreference() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_accel_preference_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The hardware acceleration preference for this window.
   /// This is a constructor function and can only be called before <see cref="Efl.Object.FinalizeAdd"/>.
   /// 
   /// This property overrides the global EFL configuration option &quot;accel_preference&quot; for this single window, and accepts the same syntax.
   /// 
   /// The <c>accel</c> string is a freeform C string that indicates what kind of acceleration is preferred. Here &quot;acceleration&quot; generally refers to rendering and the hardware with which the unit application renders GUIs. This may or may not be honored but a best attempt will be made. Known strings are as follows:
   /// 
   /// &quot;gl&quot;, &quot;opengl&quot; - try use OpenGL. &quot;3d&quot; - try to use a 3d acceleration unit. &quot;hw&quot;, &quot;hardware&quot;, &quot;accel&quot; - try any acceleration unit (best possible) &quot;none&quot; - use no acceleration but software instead (since 1.16)
   /// 
   /// Since 1.14, it is also possible to specify some GL properties for the GL window surface. This allows applications to use GLView with depth, stencil and MSAA buffers with direct rendering. The new accel preference string format is thus &quot;{HW Accel}[:depth{value}[:stencil{value}[:msaa{str}$]$]$]&quot;.
   /// 
   /// Accepted values for depth are for instance &quot;depth&quot;, &quot;depth16&quot;, &quot;depth24&quot;. Accepted values for stencil are &quot;stencil&quot;, &quot;stencil1&quot;, &quot;stencil8&quot;. For MSAA, only predefined strings are accepted: &quot;msaa&quot;, &quot;msaa_low&quot;, &quot;msaa_mid&quot; and &quot;msaa_high&quot;. The selected configuration is not guaranteed and is only valid in case of GL acceleration. Only the base acceleration string will be saved (e.g. &quot;gl&quot; or &quot;hw&quot;).
   /// 
   /// Full examples include:
   /// 
   /// &quot;gl&quot;, - try to use OpenGL &quot;hw:depth:stencil&quot;, - use HW acceleration with default depth and stencil buffers &quot;opengl:depth24:stencil8:msaa_mid&quot; - use OpenGL with 24-bit depth, 8-bit stencil and a medium number of MSAA samples in the backbuffer.
   /// 
   /// Note that this option may be overriden by environment variables or the configuration option &quot;accel_preference_override&quot;.
   /// 1.18</summary>
   /// <param name="accel">Acceleration</param>
   /// <returns></returns>
   virtual public  void SetAccelPreference(  System.String accel) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_accel_preference_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), accel);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the alpha channel state of a window.</summary>
   /// <returns><c>true</c> if the window alpha channel is enabled, <c>false</c> otherwise.</returns>
   virtual public bool GetAlpha() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_alpha_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the alpha channel state of a window.
   /// If <c>alpha</c> is true, the alpha channel of the canvas will be enabled possibly making parts of the window completely or partially transparent. This is also subject to the underlying system supporting it, for example a system using a compositing manager.
   /// 
   /// Note: Alpha window can be enabled automatically by window theme style&apos;s property. If &quot;alpha&quot; data.item is &quot;1&quot; or &quot;true&quot; in window style(eg. elm/win/base/default), the window is switched to alpha automatically without the explicit api call.</summary>
   /// <param name="alpha"><c>true</c> if the window alpha channel is enabled, <c>false</c> otherwise.</param>
   /// <returns></returns>
   virtual public  void SetAlpha( bool alpha) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_alpha_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), alpha);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the stack ID string of the window as an opaque string.
   /// This ID is immutable and can never be modified. It will be an opaque string that has no specific defined format or content other than being a string (no character with a value of 0).
   /// 
   /// This string is intended for use as a stack master ID to be use by other windows to make this window part of a stack of windows to be placed on top of each other as if they are a series of dialogs or questions one after the other, allowing you to go back through history.</summary>
   /// <returns>An opaque string that has no specific format but identifies a specific unique window on the display.</returns>
   virtual public  System.String GetStackId() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_stack_id_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get the stack master Id that has been set.</summary>
   /// <returns>An opaque string that has no specific format, but identifies a specific unique window on the display.</returns>
   virtual public  System.String GetStackMasterId() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_stack_master_id_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the window stack ID to use as the master top-level.
   /// This sets the ID string to be used as the master top-level window as the base of a stack of windows. This must be set before the first time the window is shown and should never be changed afterwards.</summary>
   /// <param name="id">An opaque string that has no specific format, but identifies a specific unique window on the display.</param>
   /// <returns></returns>
   virtual public  void SetStackMasterId(  System.String id) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_stack_master_id_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), id);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>The stack base state of this window
   /// This is a boolean flag that determines if this window will become the base of a stack at all. You must enable this on a base (the bottom of a window stack) for things to work correctly.
   /// 
   /// This state should be set before a window is shown for the first time and never changed afterwards.</summary>
   /// <returns><c>true</c> if this is a stack base window, <c>false</c> otherwise.</returns>
   virtual public bool GetStackBase() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_stack_base_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The stack base state of this window
   /// This is a boolean flag that determines if this window will become the base of a stack at all. You must enable this on a base (the bottom of a window stack) for things to work correctly.
   /// 
   /// This state should be set before a window is shown for the first time and never changed afterwards.</summary>
   /// <param name="kw_base"><c>true</c> if this is a stack base window, <c>false</c> otherwise.</param>
   /// <returns></returns>
   virtual public  void SetStackBase( bool kw_base) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_stack_base_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), kw_base);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Enable quitting the main loop when all windows are closed.
   /// When set, the main loop will quit with the passed exit code once all windows have been closed.
   /// 
   /// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
   /// <returns>The exit code to use when exiting</returns>
   public static  Eina.Value GetExitOnAllWindowsClosed() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_exit_on_all_windows_closed_get_ptr.Value.Delegate();
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Enable quitting the main loop when all windows are closed.
   /// When set, the main loop will quit with the passed exit code once all windows have been closed.
   /// 
   /// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
   /// <param name="exit_code">The exit code to use when exiting</param>
   /// <returns></returns>
   public static  void SetExitOnAllWindowsClosed(  Eina.Value exit_code) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_exit_on_all_windows_closed_set_ptr.Value.Delegate( exit_code);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Base size for objects with sizing restrictions.
   /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
   /// 
   /// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.
   /// 
   /// See also <see cref="Efl.Ui.Win.HintStep"/>.</summary>
   /// <returns>Base size (hint) in pixels.</returns>
   virtual public Eina.Size2D GetHintBase() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_hint_base_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Size2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Base size for objects with sizing restrictions.
   /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
   /// 
   /// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.
   /// 
   /// See also <see cref="Efl.Ui.Win.HintStep"/>.</summary>
   /// <param name="sz">Base size (hint) in pixels.</param>
   /// <returns></returns>
   virtual public  void SetHintBase( Eina.Size2D sz) {
       var _in_sz = Eina.Size2D_StructConversion.ToInternal(sz);
                  Efl.Ui.WinNativeInherit.efl_ui_win_hint_base_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_sz);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Step size for objects with sizing restrictions.
   /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
   /// 
   /// Set this to for an object to scale up by steps and not continuously.
   /// 
   /// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.</summary>
   /// <returns>Step size (hint) in pixels.</returns>
   virtual public Eina.Size2D GetHintStep() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_hint_step_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Size2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Step size for objects with sizing restrictions.
   /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
   /// 
   /// Set this to for an object to scale up by steps and not continuously.
   /// 
   /// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.</summary>
   /// <param name="sz">Step size (hint) in pixels.</param>
   /// <returns></returns>
   virtual public  void SetHintStep( Eina.Size2D sz) {
       var _in_sz = Eina.Size2D_StructConversion.ToInternal(sz);
                  Efl.Ui.WinNativeInherit.efl_ui_win_hint_step_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_sz);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the enabled value of the focus highlight for this window.</summary>
   /// <returns>The enabled value for the highlight.</returns>
   virtual public bool GetFocusHighlightEnabled() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_enabled_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the enabled status for the focus highlight in a window.
   /// This function will enable or disable the focus highlight, regardless of the global setting for it.</summary>
   /// <param name="enabled">The enabled value for the highlight.</param>
   /// <returns></returns>
   virtual public  void SetFocusHighlightEnabled( bool enabled) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_enabled_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), enabled);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Control the widget focus highlight style.
   /// If <c>style</c> is <c>null</c>, the default will be used.
   /// 
   /// See also <see cref="Efl.Ui.Win.FocusHighlightEnabled"/>. See also <see cref="Efl.Ui.Win.FocusHighlightAnimate"/>.</summary>
   /// <returns>The name of the focus highlight style.</returns>
   virtual public  System.String GetFocusHighlightStyle() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_style_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Control the widget focus highlight style.
   /// If <c>style</c> is <c>null</c>, the default will be used.
   /// 
   /// See also <see cref="Efl.Ui.Win.FocusHighlightEnabled"/>. See also <see cref="Efl.Ui.Win.FocusHighlightAnimate"/>.</summary>
   /// <param name="style">The name of the focus highlight style.</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise.</returns>
   virtual public bool SetFocusHighlightStyle(  System.String style) {
                         var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_style_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), style);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Get the animate value of the focus highlight for this window.</summary>
   /// <returns>The enabled value for the highlight animation.</returns>
   virtual public bool GetFocusHighlightAnimate() {
       var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_animate_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the animate status for the focus highlight for this window.
   /// This function will enable or disable the animation of focus highlight.</summary>
   /// <param name="animate">The enabled value for the highlight animation.</param>
   /// <returns></returns>
   virtual public  void SetFocusHighlightAnimate( bool animate) {
                         Efl.Ui.WinNativeInherit.efl_ui_win_focus_highlight_animate_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), animate);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Pop (delete) all windows in the stack above this window.
   /// This will try and delete all the windows in the stack that are above the window.</summary>
   /// <returns></returns>
   virtual public  void StackPopTo() {
       Efl.Ui.WinNativeInherit.efl_ui_win_stack_pop_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Activate a window object.
   /// This function sends a request to the Window Manager to activate the window pointed by <c>obj</c>. If honored by the WM, the window will receive the keyboard focus.
   /// 
   /// Note: This is just a request that a Window Manager may ignore, so calling this function does not ensure in any way that the window will be the active one afterwards.</summary>
   /// <returns></returns>
   virtual public  void Activate() {
       Efl.Ui.WinNativeInherit.efl_ui_win_activate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Center a window on the screen.
   /// This function centers window <c>obj</c> horizontally and/or vertically based on the values of <c>h</c> and <c>v</c>.
   /// 
   /// Note: This is just a request that a Window Manager may ignore, so calling this function does not ensure in any way that the window will be centered afterwards.</summary>
   /// <param name="h">If <c>true</c>, center horizontally. If <c>false</c>, do not change horizontal location.</param>
   /// <param name="v">If <c>true</c>, center vertically. If <c>false</c>, do not change vertical location.</param>
   /// <returns></returns>
   virtual public  void Center( bool h,  bool v) {
                                           Efl.Ui.WinNativeInherit.efl_ui_win_center_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), h,  v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set keygrab value of the window
   /// This function grabs the <c>key</c> of window using <c>grab_mode</c>.</summary>
   /// <param name="key">This string is the keyname to grab.</param>
   /// <param name="modifiers">A combination of modifier keys that must be present to trigger the event. Not supported yet.</param>
   /// <param name="not_modifiers">A combination of modifier keys that must not be present to trigger the event. Not supported yet.</param>
   /// <param name="priority">Not supported yet.</param>
   /// <param name="grab_mode">Describes how the key should be grabbed, wrt. focus and stacking.</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
   virtual public bool SetKeygrab(  System.String key,  Efl.Input.Modifier modifiers,  Efl.Input.Modifier not_modifiers,   int priority,  Efl.Ui.WinKeygrabMode grab_mode) {
                                                                                                 var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_keygrab_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), key,  modifiers,  not_modifiers,  priority,  grab_mode);
      Eina.Error.RaiseIfUnhandledException();
                                                                  return _ret_var;
 }
   /// <summary>Unset keygrab value of the window
   /// This function unset keygrab value. Ungrab <c>key</c> of window.</summary>
   /// <param name="key">This string is the keyname to grab.</param>
   /// <param name="modifiers">A combination of modifier keys that must be present to trigger the event. Not supported yet.</param>
   /// <param name="not_modifiers">A combination of modifier keys that must not be present to trigger the event. Not supported yet.</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
   virtual public bool UnsetKeygrab(  System.String key,  Efl.Input.Modifier modifiers,  Efl.Input.Modifier not_modifiers) {
                                                             var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_keygrab_unset_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), key,  modifiers,  not_modifiers);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Start moving or resizing the window.
   /// The user can request the display server to start moving or resizing the window by combining modes from <see cref="Efl.Ui.WinMoveResizeMode"/>. This API can only be called if none of the following conditions is true:
   /// 
   /// 1. Called in the absence of a pointer down event, 2. Called more than once before a pointer up event, 3. Called when the window is already being resized or moved, 4. Called with an unsupported combination of modes.
   /// 
   /// Right usage: 1. Pointer (mouse or touch) down event, 2. <see cref="Efl.Ui.Win.MoveResizeStart"/> called only once with a supported mode, 3. Pointer (mouse or touch) up event.
   /// 
   /// If a pointer up event occurs after calling the function, it automatically ends the window move and resize operation.
   /// 
   /// Currently, only the following 9 combinations are allowed, and possibly more combinations may be added in the future: 1. <see cref="Efl.Ui.WinMoveResizeMode.Move"/> 2. <see cref="Efl.Ui.WinMoveResizeMode.Top"/> 3. <see cref="Efl.Ui.WinMoveResizeMode.Bottom"/> 4. <see cref="Efl.Ui.WinMoveResizeMode.Left"/> 5. <see cref="Efl.Ui.WinMoveResizeMode.Right"/> 6. <see cref="Efl.Ui.WinMoveResizeMode.Top"/> | <see cref="Efl.Ui.WinMoveResizeMode.Left"/> 7. <see cref="Efl.Ui.WinMoveResizeMode.Top"/> | <see cref="Efl.Ui.WinMoveResizeMode.Right"/> 8. <see cref="Efl.Ui.WinMoveResizeMode.Bottom"/> | <see cref="Efl.Ui.WinMoveResizeMode.Left"/> 9. <see cref="Efl.Ui.WinMoveResizeMode.Bottom"/> | <see cref="Efl.Ui.WinMoveResizeMode.Right"/>
   /// 
   /// In particular move and resize cannot happen simultaneously.
   /// 
   /// Note: the result of this API can only guarantee that the request has been forwarded to the server, but there is no guarantee that the request can be processed by the display server.
   /// 1.19</summary>
   /// <param name="mode">The requested move or resize mode.</param>
   /// <returns><c>true</c> if the request was successfully sent to the display server, <c>false</c> in case of error.</returns>
   virtual public bool MoveResizeStart( Efl.Ui.WinMoveResizeMode mode) {
                         var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_move_resize_start_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), mode);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Returns an iterator over the current known pointer positions.
   /// This is used to iterate over the current known multi-touch positions, including the first finger. Each pointer position is represented by an object of type <see cref="Efl.Input.Pointer"/>.
   /// 
   /// Each finger in a multi touch environment can then be identified by the <see cref="Efl.Input.Pointer.Tool"/> property. The order of the pointers in this iterator is not defined.
   /// 
   /// Note: If the input surface supports hovering input, some pointers may not be in a &quot;down&quot; state. To retrieve the list of such pointers, set the <c>hover</c> value to <c>true</c>. Remember though that most devices currently don&apos;t support this.</summary>
   /// <param name="hover"><c>false</c> by default, <c>true</c> means to include fingers that are currently hovering.</param>
   /// <returns>Iterator to pointer positions</returns>
   virtual public Eina.Iterator<Efl.Input.Pointer> PointerIterate( bool hover) {
                         var _ret_var = Efl.Ui.WinNativeInherit.efl_ui_win_pointer_iterate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), hover);
      Eina.Error.RaiseIfUnhandledException();
                  return new Eina.Iterator<Efl.Input.Pointer>(_ret_var, false, false);
 }
   /// <summary>A generic configuration value, referred to by name.</summary>
   /// <param name="name">Configuration option name.</param>
   /// <returns>The value. It will be empty if it doesn&apos;t exist. The caller must free it after use (using <c>eina_value_free</c>() in C).</returns>
   virtual public  Eina.Value GetConfig(  System.String name) {
                         var _ret_var = Efl.ConfigNativeInherit.efl_config_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>A generic configuration value, referred to by name.</summary>
   /// <param name="name">Configuration option name.</param>
   /// <param name="value">Configuration option value. May be <c>null</c> if not found.</param>
   /// <returns><c>false</c> in case of error: value type was invalid, the config can&apos;t be changed, config does not exist...</returns>
   virtual public bool SetConfig(  System.String name,   Eina.Value value) {
                                           var _ret_var = Efl.ConfigNativeInherit.efl_config_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name,  value);
      Eina.Error.RaiseIfUnhandledException();
                              return _ret_var;
 }
   /// <summary>Swallowed sub-object contained in this object.</summary>
   /// <returns>The object to swallow.</returns>
   virtual public Efl.Gfx.Entity GetContent() {
       var _ret_var = Efl.ContentNativeInherit.efl_content_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Swallowed sub-object contained in this object.</summary>
   /// <param name="content">The object to swallow.</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
   virtual public bool SetContent( Efl.Gfx.Entity content) {
                         var _ret_var = Efl.ContentNativeInherit.efl_content_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), content);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Unswallow the object in the current container and return it.</summary>
   /// <returns>Unswallowed object</returns>
   virtual public Efl.Gfx.Entity UnsetContent() {
       var _ret_var = Efl.ContentNativeInherit.efl_content_unset_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get screen size (in pixels) for the screen.
   /// Note that on some display systems this information is not available and a value of 0x0 will be returned.</summary>
   /// <returns>The screen size in pixels.</returns>
   virtual public Eina.Size2D GetScreenSizeInPixels() {
       var _ret_var = Efl.ScreenNativeInherit.efl_screen_size_in_pixels_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Size2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Get screen scaling factor.
   /// This is the factor by which window contents will be scaled on the screen.
   /// 
   /// Note that on some display systems this information is not available and a value of 1.0 will be returned.</summary>
   /// <returns>The screen scaling factor.</returns>
   virtual public float GetScreenScaleFactor() {
       var _ret_var = Efl.ScreenNativeInherit.efl_screen_scale_factor_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get the rotation of the screen.
   /// Most engines only return multiples of 90.
   /// 1.19</summary>
   /// <returns>Screen rotation in degrees.</returns>
   virtual public  int GetScreenRotation() {
       var _ret_var = Efl.ScreenNativeInherit.efl_screen_rotation_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get the pixel density in DPI (Dots Per Inch) for the screen that a window is on.
   /// 1.7</summary>
   /// <param name="xdpi">Horizontal DPI.</param>
   /// <param name="ydpi">Vertical DPI.</param>
   /// <returns></returns>
   virtual public  void GetScreenDpi( out  int xdpi,  out  int ydpi) {
                                           Efl.ScreenNativeInherit.efl_screen_dpi_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out xdpi,  out ydpi);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Retrieves the text string currently being displayed by the given text object.
   /// Do not free() the return value.
   /// 
   /// See also <see cref="Efl.Text.GetText"/>.</summary>
   /// <returns>Text string to display on it.</returns>
   virtual public  System.String GetText() {
       var _ret_var = Efl.TextNativeInherit.efl_text_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Sets the text string to be displayed by the given text object.
   /// See also <see cref="Efl.Text.GetText"/>.</summary>
   /// <param name="text">Text string to display on it.</param>
   /// <returns></returns>
   virtual public  void SetText(  System.String text) {
                         Efl.TextNativeInherit.efl_text_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), text);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the maximum image size the canvas can possibly handle.
   /// This function returns the largest image or surface size that the canvas can handle in pixels, and if there is one, returns <c>true</c>. It returns <c>false</c> if no extra constraint on maximum image size exists.
   /// 
   /// The default limit is 65535x65535.</summary>
   /// <param name="max">The maximum image size (in pixels).</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
   virtual public bool GetImageMaxSize( out Eina.Size2D max) {
             var _out_max = new Eina.Size2D_StructInternal();
            var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_image_max_size_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out _out_max);
      Eina.Error.RaiseIfUnhandledException();
      max = Eina.Size2D_StructConversion.ToManaged(_out_max);
            return _ret_var;
 }
   /// <summary>Get if the canvas is currently calculating group objects.</summary>
   /// <returns><c>true</c> if currently calculating group objects.</returns>
   virtual public bool GetGroupObjectsCalculating() {
       var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_group_objects_calculating_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get a device by name.</summary>
   /// <param name="name">The name of the seat to find.</param>
   /// <returns>The device or seat, <c>null</c> if not found.</returns>
   virtual public Efl.Input.Device GetDevice(  System.String name) {
                         var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_device_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), name);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Get a seat by id.</summary>
   /// <param name="id">The id of the seat to find.</param>
   /// <returns>The seat or <c>null</c> if not found.</returns>
   virtual public Efl.Input.Device GetSeat(  int id) {
                         var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_seat_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), id);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Get the default seat.</summary>
   /// <returns>The default seat or <c>null</c> if one does not exist.</returns>
   virtual public Efl.Input.Device GetSeatDefault() {
       var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_seat_default_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>This function returns the current known pointer coordinates
   /// This function returns the current position of the main input pointer (mouse, pen, etc...).</summary>
   /// <param name="seat">The seat, or <c>null</c> to use the default.</param>
   /// <param name="pos">The pointer position in pixels.</param>
   /// <returns><c>true</c> if a pointer exists for the given seat, otherwise <c>false</c>.</returns>
   virtual public bool GetPointerPosition( Efl.Input.Device seat,  out Eina.Position2D pos) {
                         var _out_pos = new Eina.Position2D_StructInternal();
                  var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_pointer_position_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), seat,  out _out_pos);
      Eina.Error.RaiseIfUnhandledException();
            pos = Eina.Position2D_StructConversion.ToManaged(_out_pos);
                  return _ret_var;
 }
   /// <summary>Call user-provided <c>calculate</c> group functions and unset the flag signalling that the object needs to get recalculated to all group objects in the canvas.</summary>
   /// <returns></returns>
   virtual public  void CalculateGroupObjects() {
       Efl.Canvas.SceneNativeInherit.efl_canvas_scene_group_objects_calculate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Retrieve a list of objects at a given position in a canvas.
   /// This function will traverse all the layers of the given canvas, from top to bottom, querying for objects with areas covering the given position. The user can exclude from the query objects which are hidden and/or which are set to pass events.
   /// 
   /// Warning: This function will only evaluate top-level objects; child or &quot;sub&quot; objects will be skipped.</summary>
   /// <param name="pos">The pixel position.</param>
   /// <param name="include_pass_events_objects">Boolean flag to include or not objects which pass events in this calculation.</param>
   /// <param name="include_hidden_objects">Boolean flag to include or not hidden objects in this calculation.</param>
   /// <returns>The list of objects that are over the given position in <c>e</c>.</returns>
   virtual public Eina.Iterator<Efl.Gfx.Entity> GetObjectsAtXy( Eina.Position2D pos,  bool include_pass_events_objects,  bool include_hidden_objects) {
       var _in_pos = Eina.Position2D_StructConversion.ToInternal(pos);
                                                      var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_objects_at_xy_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_pos,  include_pass_events_objects,  include_hidden_objects);
      Eina.Error.RaiseIfUnhandledException();
                                          return new Eina.Iterator<Efl.Gfx.Entity>(_ret_var, true, false);
 }
   /// <summary>Retrieve the object stacked at the top of a given position in a canvas.
   /// This function will traverse all the layers of the given canvas, from top to bottom, querying for objects with areas covering the given position. The user can exclude from the query objects which are hidden and/or which are set to pass events.
   /// 
   /// Warning: This function will only evaluate top-level objects; child or &quot;sub&quot; objects will be skipped.</summary>
   /// <param name="pos">The pixel position.</param>
   /// <param name="include_pass_events_objects">Boolean flag to include or not objects which pass events in this calculation.</param>
   /// <param name="include_hidden_objects">Boolean flag to include or not hidden objects in this calculation.</param>
   /// <returns>The canvas object that is over all other objects at the given position.</returns>
   virtual public Efl.Gfx.Entity GetObjectTopAtXy( Eina.Position2D pos,  bool include_pass_events_objects,  bool include_hidden_objects) {
       var _in_pos = Eina.Position2D_StructConversion.ToInternal(pos);
                                                      var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_object_top_at_xy_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_pos,  include_pass_events_objects,  include_hidden_objects);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Retrieve a list of objects overlapping a given rectangular region in a canvas.
   /// This function will traverse all the layers of the given canvas, from top to bottom, querying for objects with areas overlapping with the given rectangular region. The user can exclude from the query objects which are hidden and/or which are set to pass events.
   /// 
   /// Warning: This function will only evaluate top-level objects; child or &quot;sub&quot; objects will be skipped.</summary>
   /// <param name="rect">The rectangular region.</param>
   /// <param name="include_pass_events_objects">Boolean flag to include or not objects which pass events in this calculation.</param>
   /// <param name="include_hidden_objects">Boolean flag to include or not hidden objects in this calculation.</param>
   /// <returns>Iterator to objects</returns>
   virtual public Eina.Iterator<Efl.Gfx.Entity> GetObjectsInRectangle( Eina.Rect rect,  bool include_pass_events_objects,  bool include_hidden_objects) {
       var _in_rect = Eina.Rect_StructConversion.ToInternal(rect);
                                                      var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_objects_in_rectangle_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_rect,  include_pass_events_objects,  include_hidden_objects);
      Eina.Error.RaiseIfUnhandledException();
                                          return new Eina.Iterator<Efl.Gfx.Entity>(_ret_var, true, false);
 }
   /// <summary>Retrieve the canvas object stacked at the top of a given rectangular region in a canvas
   /// This function will traverse all the layers of the given canvas, from top to bottom, querying for objects with areas overlapping with the given rectangular region. The user can exclude from the query objects which are hidden and/or which are set to pass events.
   /// 
   /// Warning: This function will only evaluate top-level objects; child or &quot;sub&quot; objects will be skipped.</summary>
   /// <param name="rect">The rectangular region.</param>
   /// <param name="include_pass_events_objects">Boolean flag to include or not objects which pass events in this calculation.</param>
   /// <param name="include_hidden_objects">Boolean flag to include or not hidden objects in this calculation.</param>
   /// <returns>The object that is over all other objects at the given rectangular region.</returns>
   virtual public Efl.Gfx.Entity GetObjectTopInRectangle( Eina.Rect rect,  bool include_pass_events_objects,  bool include_hidden_objects) {
       var _in_rect = Eina.Rect_StructConversion.ToInternal(rect);
                                                      var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_object_top_in_rectangle_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_rect,  include_pass_events_objects,  include_hidden_objects);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Iterate over the available input device seats for the canvas.
   /// A &quot;seat&quot; is the term used for a group of input devices, typically including a pointer and a keyboard. A seat object is the parent of the individual input devices.
   /// 1.20</summary>
   /// <returns>An iterator over the attached seats.</returns>
   virtual public Eina.Iterator<Efl.Input.Device> Seats() {
       var _ret_var = Efl.Canvas.SceneNativeInherit.efl_canvas_scene_seats_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return new Eina.Iterator<Efl.Input.Device>(_ret_var, true, false);
 }
   /// <summary>Indicates whether a key modifier is on, such as Ctrl, Shift, ...</summary>
   /// <param name="mod">The modifier key to test.</param>
   /// <param name="seat">The seat device, may be <c>null</c></param>
   /// <returns><c>true</c> if the key modifier is pressed.</returns>
   virtual public bool GetModifierEnabled( Efl.Input.Modifier mod,  Efl.Input.Device seat) {
                                           var _ret_var = Efl.Input.StateNativeInherit.efl_input_modifier_enabled_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), mod,  seat);
      Eina.Error.RaiseIfUnhandledException();
                              return _ret_var;
 }
   /// <summary>Indicates whether a key lock is on, such as NumLock, CapsLock, ...</summary>
   /// <param name="kw_lock">The lock key to test.</param>
   /// <param name="seat">The seat device, may be <c>null</c></param>
   /// <returns><c>true</c> if the key lock is on.</returns>
   virtual public bool GetLockEnabled( Efl.Input.Lock kw_lock,  Efl.Input.Device seat) {
                                           var _ret_var = Efl.Input.StateNativeInherit.efl_input_lock_enabled_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), kw_lock,  seat);
      Eina.Error.RaiseIfUnhandledException();
                              return _ret_var;
 }
   /// <summary>If the widget needs a focus manager, this function will be called.
   /// It can be used and overriden to inject your own manager or set custom options on the focus manager.</summary>
   /// <param name="root">The logical root object for focus.</param>
   /// <returns>The focus manager.</returns>
   virtual public Efl.Ui.Focus.Manager FocusManagerCreate( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.WidgetFocusManagerNativeInherit.efl_ui_widget_focus_manager_create_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>The element which is currently focused by this manager
   /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
   /// 1.20</summary>
   /// <returns>Currently focused element.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Object GetManagerFocus() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_focus_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The element which is currently focused by this manager
   /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
   /// 1.20</summary>
   /// <param name="focus">Currently focused element.
   /// 1.20</param>
   /// <returns></returns>
   virtual public  void SetManagerFocus( Efl.Ui.Focus.Object focus) {
                         Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_focus_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), focus);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Add another manager to serve the move requests.
   /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
   /// 1.20</summary>
   /// <returns>The redirect manager.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Manager GetRedirect() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_redirect_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Add another manager to serve the move requests.
   /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
   /// 1.20</summary>
   /// <param name="redirect">The redirect manager.
   /// 1.20</param>
   /// <returns></returns>
   virtual public  void SetRedirect( Efl.Ui.Focus.Manager redirect) {
                         Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_redirect_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), redirect);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>The list of elements which are at the border of the graph.
   /// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.Manager.Move"/>
   /// 1.20</summary>
   /// <returns>An iterator over the border objects.
   /// 1.20</returns>
   virtual public Eina.Iterator<Efl.Ui.Focus.Object> GetBorderElements() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return new Eina.Iterator<Efl.Ui.Focus.Object>(_ret_var, false, false);
 }
   /// <summary>Get all elements that are at the border of the viewport
   /// Every element returned by this is located inside the viewport rectangle, but has a right, left, down or up neighbor outside the viewport.
   /// 1.20</summary>
   /// <param name="viewport">The rectangle defining the viewport.
   /// 1.20</param>
   /// <returns>The list of border objects.
   /// 1.20</returns>
   virtual public Eina.Iterator<Efl.Ui.Focus.Object> GetViewportElements( Eina.Rect viewport) {
       var _in_viewport = Eina.Rect_StructConversion.ToInternal(viewport);
                  var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_viewport);
      Eina.Error.RaiseIfUnhandledException();
                  return new Eina.Iterator<Efl.Ui.Focus.Object>(_ret_var, false, false);
 }
   /// <summary>Root node for all logical subtrees.
   /// This property can only be set once.
   /// 1.20</summary>
   /// <returns>Will be registered into this manager object.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Object GetRoot() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_root_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Root node for all logical subtrees.
   /// This property can only be set once.
   /// 1.20</summary>
   /// <param name="root">Will be registered into this manager object.
   /// 1.20</param>
   /// <returns>If <c>true</c>, this is the root node
   /// 1.20</returns>
   virtual public bool SetRoot( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_root_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Move the focus in the given direction.
   /// This call flushes all changes. This means all changes between the last flush and now are computed.
   /// 1.20</summary>
   /// <param name="direction">The direction to move to.
   /// 1.20</param>
   /// <returns>The element which is now focused.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Object Move( Efl.Ui.Focus.Direction direction) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_move_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), direction);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Return the object in the <c>direction</c> from <c>child</c>.
   /// 1.20</summary>
   /// <param name="direction">Direction to move focus.
   /// 1.20</param>
   /// <param name="child">The child to move from. Pass <c>null</c> to indicate the currently focused child.
   /// 1.20</param>
   /// <param name="logical">Wether you want to have a logical node as result or a non-logical. Note, in a <see cref="Efl.Ui.Focus.Manager.Move"/> call no logical node will get focus.
   /// 1.20</param>
   /// <returns>Object that would receive focus if moved in the given direction.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Object MoveRequest( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object child,  bool logical) {
                                                             var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_request_move_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), direction,  child,  logical);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Return the widget in the direction next.
   /// The returned widget is a child of <c>root</c>. It&apos;s guaranteed that child will not be prepared once again, so you can call this function inside a <see cref="Efl.Ui.Focus.Object.SetupOrder"/> call.
   /// 1.20</summary>
   /// <param name="root">Parent for returned child.
   /// 1.20</param>
   /// <returns>Child of passed parameter.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Object RequestSubchild( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_request_subchild_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>This will fetch the data from a registered node.
   /// Be aware this function will trigger a computation of all dirty nodes.
   /// 1.20</summary>
   /// <param name="child">The child object to inspect.
   /// 1.20</param>
   /// <returns>The list of relations starting from <c>child</c>.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.Relations Fetch( Efl.Ui.Focus.Object child) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_fetch_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), child);
      Eina.Error.RaiseIfUnhandledException();
                  var __ret_tmp = Eina.PrimitiveConversion.PointerToManaged<Efl.Ui.Focus.Relations>(_ret_var);
      Marshal.FreeHGlobal(_ret_var);
      return __ret_tmp;
 }
   /// <summary>Return the last logical object.
   /// The returned object is the last object that would be returned if you start at the root and move the direction into next.
   /// 1.20</summary>
   /// <returns>Last object.
   /// 1.20</returns>
   virtual public Efl.Ui.Focus.ManagerLogicalEndDetail LogicalEnd() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_logical_end_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Efl.Ui.Focus.ManagerLogicalEndDetail_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Reset the history stack of this manager object. This means the uppermost element will be unfocused, and all other elements will be removed from the remembered list.
   /// You should focus another element immediately after calling this, in order to always have a focused object.
   /// 1.20</summary>
   /// <returns></returns>
   virtual public  void ResetHistory() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_reset_history_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Remove the uppermost history element, and focus the previous one.
   /// If there is an element that was focused before, it will be used. Otherwise, the best fitting element from the registered elements will be focused.
   /// 1.20</summary>
   /// <returns></returns>
   virtual public  void PopHistoryStack() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Called when this manager is set as redirect.
   /// In case that this is called as an result of a move call, <c>direction</c> and <c>entry</c> will be set to the direction of the move call, and the <c>entry</c> object will be set to the object that had this manager as redirect property.
   /// 1.20</summary>
   /// <param name="direction">The direction in which this should be setup.
   /// 1.20</param>
   /// <param name="entry">The object that caused this manager to be redirect.
   /// 1.20</param>
   /// <returns></returns>
   virtual public  void SetupOnFirstTouch( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object entry) {
                                           Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), direction,  entry);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>This disables the cache invalidation when an object is moved.
   /// Even if an object is moved, the focus manager will not recalculate its relations. This can be used when you know that the set of widgets in the focus manager is moved the same way, so the relations between the widets in the set do not change and the complex calculations can be avoided. Use <see cref="Efl.Ui.Focus.Manager.DirtyLogicUnfreeze"/> to re-enable relationship calculation.
   /// 1.20</summary>
   /// <returns></returns>
   virtual public  void FreezeDirtyLogic() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>This enables the cache invalidation when an object is moved.
   /// This is the counterpart to <see cref="Efl.Ui.Focus.Manager.FreezeDirtyLogic"/>.
   /// 1.20</summary>
   /// <returns></returns>
   virtual public  void DirtyLogicUnfreeze() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>In some environments you may have an indicator that shows battery status, reception, time etc. This is the indicator.
/// Sometimes you don&apos;t want this because you provide the same functionality inside your app, so this will request that the indicator is disabled in such circumstances. The default settings depends on the environment. For example, on phones, the default is to enable the indicator. The indicator is disabled on devices like televisions however.
/// 1.18</summary>
/// <value>The mype, one of <see cref="Efl.Ui.WinIndicatorMode"/>.</value>
   public Efl.Ui.WinIndicatorMode IndicatorMode {
      get { return GetIndicatorMode(); }
      set { SetIndicatorMode( value); }
   }
   /// <summary>Get the keyboard mode of the window.</summary>
/// <value>The mode, one of <see cref="Efl.Ui.WinKeyboardMode"/>.</value>
   public Efl.Ui.WinKeyboardMode KeyboardMode {
      get { return GetKeyboardMode(); }
      set { SetKeyboardMode( value); }
   }
   /// <summary>Available profiles on a window.</summary>
/// <value>A list of profiles.</value>
   public Eina.Array< System.String> WmAvailableProfiles {
      get { return GetWmAvailableProfiles(); }
      set { SetWmAvailableProfiles( value); }
   }
   /// <summary>Get the constraints on the maximum width and height of a window relative to the width and height of the screen.
/// When this function returns <c>true</c>, <c>obj</c> will never resize larger than the screen.</summary>
/// <value><c>true</c> to restrict the window&apos;s maximum size.</value>
   public bool ScreenConstrain {
      get { return GetScreenConstrain(); }
      set { SetScreenConstrain( value); }
   }
   /// <summary>Set the window to be skipped by keyboard focus.
/// This sets the window to be skipped by normal keyboard input. This means a window manager will be asked not to focus this window as well as omit it from things like the taskbar, pager, &quot;alt-tab&quot; list etc. etc.
/// 
/// Call this and enable it on a window BEFORE you show it for the first time, otherwise it may have no effect.
/// 
/// Use this for windows that have only output information or might only be interacted with by the mouse or touchscreen, never for typing. This may have side-effects like making the window non-accessible in some cases unless the window is specially handled. Use this with care.</summary>
/// <value>The skip flag state (<c>true</c> if it is to be skipped).</value>
   public bool PropFocusSkip {
      set { SetPropFocusSkip( value); }
   }
   /// <summary>Window&apos;s autohide state.
/// When closing the window in any way outside of the program control, like pressing the X button in the titlebar or using a command from the Window Manager, a &quot;delete,request&quot; signal is emitted to indicate that this event occurred and the developer can take any action, which may include, or not, destroying the window object.
/// 
/// When this property is set to <c>true</c>, the window will be automatically hidden when this event occurs, after the signal is emitted. If this property is <c>false</c> nothing will happen, beyond the event emission.
/// 
/// C applications can use this option along with the quit policy <c>ELM_POLICY_QUIT_LAST_WINDOW_HIDDEN</c> which allows exiting EFL&apos;s main loop when all the windows are hidden.
/// 
/// Note: <c>autodel</c> and <c>autohide</c> are not mutually exclusive. The window will be deleted if both are set to <c>true</c>.</summary>
/// <value>If <c>true</c>, the window will automatically hide itself when closed.</value>
   public bool Autohide {
      get { return GetAutohide(); }
      set { SetAutohide( value); }
   }
   /// <summary>Enable quitting the main loop when this window is closed.
/// When set, the window&apos;s loop object will exit using the passed exit code if the window is closed.
/// 
/// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
/// <value>The exit code to use when exiting</value>
   public  Eina.Value ExitOnClose {
      get { return GetExitOnClose(); }
      set { SetExitOnClose( value); }
   }
   /// <summary>Get the icon object used for the window.
/// The object returns is the one marked by <see cref="Efl.Ui.Win.SetIconObject"/> as the object to use for the window icon.</summary>
/// <value>The image object to use for an icon.</value>
   public Efl.Canvas.Object IconObject {
      get { return GetIconObject(); }
      set { SetIconObject( value); }
   }
   /// <summary>Get the minimized state of a window.</summary>
/// <value>If <c>true</c>, the window is minimized.</value>
   public bool Minimized {
      get { return GetMinimized(); }
      set { SetMinimized( value); }
   }
   /// <summary>Get the maximized state of a window.</summary>
/// <value>If <c>true</c>, the window is maximized.</value>
   public bool Maximized {
      get { return GetMaximized(); }
      set { SetMaximized( value); }
   }
   /// <summary>Get the fullscreen state of a window.</summary>
/// <value>If <c>true</c>, the window is fullscreen.</value>
   public bool Fullscreen {
      get { return GetFullscreen(); }
      set { SetFullscreen( value); }
   }
   /// <summary>Get the sticky state of the window.</summary>
/// <value>If <c>true</c>, the window&apos;s sticky state is enabled.</value>
   public bool Sticky {
      get { return GetSticky(); }
      set { SetSticky( value); }
   }
   /// <summary>Get the urgent state of a window.</summary>
/// <value>The mode of a urgent window, one of <see cref="Efl.Ui.WinUrgentMode"/>.</value>
   public Efl.Ui.WinUrgentMode Urgent {
      get { return GetUrgent(); }
      set { SetUrgent( value); }
   }
   /// <summary>Get the modal state of a window.</summary>
/// <value>The mode of a window, one of <see cref="Efl.Ui.WinModalMode"/>.</value>
   public Efl.Ui.WinModalMode Modal {
      get { return GetModal(); }
      set { SetModal( value); }
   }
   /// <summary>Get the noblank property of a window.
/// 1.11</summary>
/// <value>If <c>true</c>, the window is set to noblank.</value>
   public bool Noblank {
      get { return GetNoblank(); }
      set { SetNoblank( value); }
   }
   /// <summary>Get the borderless state of a window.</summary>
/// <value>If <c>true</c>, the window is borderless.</value>
   public bool Borderless {
      get { return GetBorderless(); }
      set { SetBorderless( value); }
   }
   /// <summary>The role of the window.
/// It is a hint of how the Window Manager should handle it. Unlike <see cref="Efl.Ui.Win.WinType"/> and <see cref="Efl.Ui.Win.WinName"/> this can be changed at runtime.</summary>
/// <value>The role to set.</value>
   public  System.String WinRole {
      get { return GetWinRole(); }
      set { SetWinRole( value); }
   }
   /// <summary>The window name.
/// The meaning of name depends on the underlying windowing system.
/// 
/// The window name is a construction property that can only be set at creation time, before finalize. In C this means inside <c>efl_add</c>().
/// 
/// Note: Once set, it cannot be modified afterwards.</summary>
/// <value>Window name</value>
   public  System.String WinName {
      get { return GetWinName(); }
      set { SetWinName( value); }
   }
   /// <summary>The type of the window.
/// It is a hint of how the Window Manager should handle it.
/// 
/// The window type is a construction property that can only be set at creation time, before finalize. In C this means inside <c>efl_add</c>().
/// 
/// Note: Once set, it cannot be modified afterward.</summary>
/// <value>Window type</value>
   public Efl.Ui.WinType WinType {
      get { return GetWinType(); }
      set { SetWinType( value); }
   }
   /// <summary>The hardware acceleration preference for this window.
/// This is a constructor function and can only be called before <see cref="Efl.Object.FinalizeAdd"/>.
/// 
/// This property overrides the global EFL configuration option &quot;accel_preference&quot; for this single window, and accepts the same syntax.
/// 
/// The <c>accel</c> string is a freeform C string that indicates what kind of acceleration is preferred. Here &quot;acceleration&quot; generally refers to rendering and the hardware with which the unit application renders GUIs. This may or may not be honored but a best attempt will be made. Known strings are as follows:
/// 
/// &quot;gl&quot;, &quot;opengl&quot; - try use OpenGL. &quot;3d&quot; - try to use a 3d acceleration unit. &quot;hw&quot;, &quot;hardware&quot;, &quot;accel&quot; - try any acceleration unit (best possible) &quot;none&quot; - use no acceleration but software instead (since 1.16)
/// 
/// Since 1.14, it is also possible to specify some GL properties for the GL window surface. This allows applications to use GLView with depth, stencil and MSAA buffers with direct rendering. The new accel preference string format is thus &quot;{HW Accel}[:depth{value}[:stencil{value}[:msaa{str}$]$]$]&quot;.
/// 
/// Accepted values for depth are for instance &quot;depth&quot;, &quot;depth16&quot;, &quot;depth24&quot;. Accepted values for stencil are &quot;stencil&quot;, &quot;stencil1&quot;, &quot;stencil8&quot;. For MSAA, only predefined strings are accepted: &quot;msaa&quot;, &quot;msaa_low&quot;, &quot;msaa_mid&quot; and &quot;msaa_high&quot;. The selected configuration is not guaranteed and is only valid in case of GL acceleration. Only the base acceleration string will be saved (e.g. &quot;gl&quot; or &quot;hw&quot;).
/// 
/// Full examples include:
/// 
/// &quot;gl&quot;, - try to use OpenGL &quot;hw:depth:stencil&quot;, - use HW acceleration with default depth and stencil buffers &quot;opengl:depth24:stencil8:msaa_mid&quot; - use OpenGL with 24-bit depth, 8-bit stencil and a medium number of MSAA samples in the backbuffer.
/// 
/// Note that this option may be overriden by environment variables or the configuration option &quot;accel_preference_override&quot;.
/// 1.18</summary>
/// <value>Acceleration</value>
   public  System.String AccelPreference {
      get { return GetAccelPreference(); }
      set { SetAccelPreference( value); }
   }
   /// <summary>Get the alpha channel state of a window.</summary>
/// <value><c>true</c> if the window alpha channel is enabled, <c>false</c> otherwise.</value>
   public bool Alpha {
      get { return GetAlpha(); }
      set { SetAlpha( value); }
   }
   /// <summary>Get the stack ID string of the window as an opaque string.
/// This ID is immutable and can never be modified. It will be an opaque string that has no specific defined format or content other than being a string (no character with a value of 0).
/// 
/// This string is intended for use as a stack master ID to be use by other windows to make this window part of a stack of windows to be placed on top of each other as if they are a series of dialogs or questions one after the other, allowing you to go back through history.</summary>
/// <value>An opaque string that has no specific format but identifies a specific unique window on the display.</value>
   public  System.String StackId {
      get { return GetStackId(); }
   }
   /// <summary>Get the stack master Id that has been set.</summary>
/// <value>An opaque string that has no specific format, but identifies a specific unique window on the display.</value>
   public  System.String StackMasterId {
      get { return GetStackMasterId(); }
      set { SetStackMasterId( value); }
   }
   /// <summary>The stack base state of this window
/// This is a boolean flag that determines if this window will become the base of a stack at all. You must enable this on a base (the bottom of a window stack) for things to work correctly.
/// 
/// This state should be set before a window is shown for the first time and never changed afterwards.</summary>
/// <value><c>true</c> if this is a stack base window, <c>false</c> otherwise.</value>
   public bool StackBase {
      get { return GetStackBase(); }
      set { SetStackBase( value); }
   }
   /// <summary>Enable quitting the main loop when all windows are closed.
/// When set, the main loop will quit with the passed exit code once all windows have been closed.
/// 
/// The Eina.Value passed should be <c>EMPTY</c> to unset this state or an int value to be used as the exit code.</summary>
/// <value>The exit code to use when exiting</value>
   public static  Eina.Value ExitOnAllWindowsClosed {
      get { return GetExitOnAllWindowsClosed(); }
      set { SetExitOnAllWindowsClosed( value); }
   }
   /// <summary>Base size for objects with sizing restrictions.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.
/// 
/// See also <see cref="Efl.Ui.Win.HintStep"/>.</summary>
/// <value>Base size (hint) in pixels.</value>
   public Eina.Size2D HintBase {
      get { return GetHintBase(); }
      set { SetHintBase( value); }
   }
   /// <summary>Step size for objects with sizing restrictions.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Set this to for an object to scale up by steps and not continuously.
/// 
/// <see cref="Efl.Ui.Win.HintBase"/> + N x <see cref="Efl.Ui.Win.HintStep"/> is what is calculated for object sizing restrictions.</summary>
/// <value>Step size (hint) in pixels.</value>
   public Eina.Size2D HintStep {
      get { return GetHintStep(); }
      set { SetHintStep( value); }
   }
   /// <summary>Whether focus highlight is enabled or not.
/// See also <see cref="Efl.Ui.Win.FocusHighlightStyle"/>. See also <see cref="Efl.Ui.Win.FocusHighlightAnimate"/>.</summary>
/// <value>The enabled value for the highlight.</value>
   public bool FocusHighlightEnabled {
      get { return GetFocusHighlightEnabled(); }
      set { SetFocusHighlightEnabled( value); }
   }
   /// <summary>Control the widget focus highlight style.
/// If <c>style</c> is <c>null</c>, the default will be used.
/// 
/// See also <see cref="Efl.Ui.Win.FocusHighlightEnabled"/>. See also <see cref="Efl.Ui.Win.FocusHighlightAnimate"/>.</summary>
/// <value>The name of the focus highlight style.</value>
   public  System.String FocusHighlightStyle {
      get { return GetFocusHighlightStyle(); }
      set { SetFocusHighlightStyle( value); }
   }
   /// <summary>Whether focus highlight should animate or not.
/// See also <see cref="Efl.Ui.Win.FocusHighlightStyle"/>. See also <see cref="Efl.Ui.Win.FocusHighlightEnabled"/>.</summary>
/// <value>The enabled value for the highlight animation.</value>
   public bool FocusHighlightAnimate {
      get { return GetFocusHighlightAnimate(); }
      set { SetFocusHighlightAnimate( value); }
   }
   /// <summary>Swallowed sub-object contained in this object.</summary>
/// <value>The object to swallow.</value>
   public Efl.Gfx.Entity Content {
      get { return GetContent(); }
      set { SetContent( value); }
   }
   /// <summary>Get screen size (in pixels) for the screen.
/// Note that on some display systems this information is not available and a value of 0x0 will be returned.</summary>
/// <value>The screen size in pixels.</value>
   public Eina.Size2D ScreenSizeInPixels {
      get { return GetScreenSizeInPixels(); }
   }
   /// <summary>Get screen scaling factor.
/// This is the factor by which window contents will be scaled on the screen.
/// 
/// Note that on some display systems this information is not available and a value of 1.0 will be returned.</summary>
/// <value>The screen scaling factor.</value>
   public float ScreenScaleFactor {
      get { return GetScreenScaleFactor(); }
   }
   /// <summary>Get the rotation of the screen.
/// Most engines only return multiples of 90.
/// 1.19</summary>
/// <value>Screen rotation in degrees.</value>
   public  int ScreenRotation {
      get { return GetScreenRotation(); }
   }
   /// <summary>Get if the canvas is currently calculating group objects.</summary>
/// <value><c>true</c> if currently calculating group objects.</value>
   public bool GroupObjectsCalculating {
      get { return GetGroupObjectsCalculating(); }
   }
   /// <summary>Get the default seat attached to this canvas.
/// A canvas may have exactly one default seat.
/// 
/// See also <see cref="Efl.Canvas.Scene.GetDevice"/> to find a seat by name. See also <see cref="Efl.Canvas.Scene.GetSeat"/> to find a seat by id.</summary>
/// <value>The default seat or <c>null</c> if one does not exist.</value>
   public Efl.Input.Device SeatDefault {
      get { return GetSeatDefault(); }
   }
   /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// 1.20</summary>
/// <value>Currently focused element.
/// 1.20</value>
   public Efl.Ui.Focus.Object ManagerFocus {
      get { return GetManagerFocus(); }
      set { SetManagerFocus( value); }
   }
   /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// 1.20</summary>
/// <value>The redirect manager.
/// 1.20</value>
   public Efl.Ui.Focus.Manager Redirect {
      get { return GetRedirect(); }
      set { SetRedirect( value); }
   }
   /// <summary>The list of elements which are at the border of the graph.
/// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.Manager.Move"/>
/// 1.20</summary>
/// <value>An iterator over the border objects.
/// 1.20</value>
   public Eina.Iterator<Efl.Ui.Focus.Object> BorderElements {
      get { return GetBorderElements(); }
   }
   /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// 1.20</summary>
/// <value>Will be registered into this manager object.
/// 1.20</value>
   public Efl.Ui.Focus.Object Root {
      get { return GetRoot(); }
      set { SetRoot( value); }
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.Win.efl_ui_win_class_get();
   }
}
public class WinNativeInherit : Efl.Ui.WidgetNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_ui_win_indicator_mode_get_static_delegate == null)
      efl_ui_win_indicator_mode_get_static_delegate = new efl_ui_win_indicator_mode_get_delegate(indicator_mode_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_indicator_mode_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_indicator_mode_get_static_delegate)});
      if (efl_ui_win_indicator_mode_set_static_delegate == null)
      efl_ui_win_indicator_mode_set_static_delegate = new efl_ui_win_indicator_mode_set_delegate(indicator_mode_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_indicator_mode_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_indicator_mode_set_static_delegate)});
      if (efl_ui_win_keyboard_mode_get_static_delegate == null)
      efl_ui_win_keyboard_mode_get_static_delegate = new efl_ui_win_keyboard_mode_get_delegate(keyboard_mode_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_keyboard_mode_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_keyboard_mode_get_static_delegate)});
      if (efl_ui_win_keyboard_mode_set_static_delegate == null)
      efl_ui_win_keyboard_mode_set_static_delegate = new efl_ui_win_keyboard_mode_set_delegate(keyboard_mode_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_keyboard_mode_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_keyboard_mode_set_static_delegate)});
      if (efl_ui_win_wm_available_rotations_get_static_delegate == null)
      efl_ui_win_wm_available_rotations_get_static_delegate = new efl_ui_win_wm_available_rotations_get_delegate(wm_available_rotations_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_wm_available_rotations_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_wm_available_rotations_get_static_delegate)});
      if (efl_ui_win_wm_available_rotations_set_static_delegate == null)
      efl_ui_win_wm_available_rotations_set_static_delegate = new efl_ui_win_wm_available_rotations_set_delegate(wm_available_rotations_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_wm_available_rotations_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_wm_available_rotations_set_static_delegate)});
      if (efl_ui_win_wm_available_profiles_get_static_delegate == null)
      efl_ui_win_wm_available_profiles_get_static_delegate = new efl_ui_win_wm_available_profiles_get_delegate(wm_available_profiles_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_wm_available_profiles_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_wm_available_profiles_get_static_delegate)});
      if (efl_ui_win_wm_available_profiles_set_static_delegate == null)
      efl_ui_win_wm_available_profiles_set_static_delegate = new efl_ui_win_wm_available_profiles_set_delegate(wm_available_profiles_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_wm_available_profiles_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_wm_available_profiles_set_static_delegate)});
      if (efl_ui_win_screen_constrain_get_static_delegate == null)
      efl_ui_win_screen_constrain_get_static_delegate = new efl_ui_win_screen_constrain_get_delegate(screen_constrain_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_screen_constrain_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_screen_constrain_get_static_delegate)});
      if (efl_ui_win_screen_constrain_set_static_delegate == null)
      efl_ui_win_screen_constrain_set_static_delegate = new efl_ui_win_screen_constrain_set_delegate(screen_constrain_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_screen_constrain_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_screen_constrain_set_static_delegate)});
      if (efl_ui_win_prop_focus_skip_set_static_delegate == null)
      efl_ui_win_prop_focus_skip_set_static_delegate = new efl_ui_win_prop_focus_skip_set_delegate(prop_focus_skip_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_prop_focus_skip_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_prop_focus_skip_set_static_delegate)});
      if (efl_ui_win_autohide_get_static_delegate == null)
      efl_ui_win_autohide_get_static_delegate = new efl_ui_win_autohide_get_delegate(autohide_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_autohide_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_autohide_get_static_delegate)});
      if (efl_ui_win_autohide_set_static_delegate == null)
      efl_ui_win_autohide_set_static_delegate = new efl_ui_win_autohide_set_delegate(autohide_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_autohide_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_autohide_set_static_delegate)});
      if (efl_ui_win_exit_on_close_get_static_delegate == null)
      efl_ui_win_exit_on_close_get_static_delegate = new efl_ui_win_exit_on_close_get_delegate(exit_on_close_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_exit_on_close_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_exit_on_close_get_static_delegate)});
      if (efl_ui_win_exit_on_close_set_static_delegate == null)
      efl_ui_win_exit_on_close_set_static_delegate = new efl_ui_win_exit_on_close_set_delegate(exit_on_close_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_exit_on_close_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_exit_on_close_set_static_delegate)});
      if (efl_ui_win_icon_object_get_static_delegate == null)
      efl_ui_win_icon_object_get_static_delegate = new efl_ui_win_icon_object_get_delegate(icon_object_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_icon_object_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_icon_object_get_static_delegate)});
      if (efl_ui_win_icon_object_set_static_delegate == null)
      efl_ui_win_icon_object_set_static_delegate = new efl_ui_win_icon_object_set_delegate(icon_object_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_icon_object_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_icon_object_set_static_delegate)});
      if (efl_ui_win_minimized_get_static_delegate == null)
      efl_ui_win_minimized_get_static_delegate = new efl_ui_win_minimized_get_delegate(minimized_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_minimized_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_minimized_get_static_delegate)});
      if (efl_ui_win_minimized_set_static_delegate == null)
      efl_ui_win_minimized_set_static_delegate = new efl_ui_win_minimized_set_delegate(minimized_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_minimized_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_minimized_set_static_delegate)});
      if (efl_ui_win_maximized_get_static_delegate == null)
      efl_ui_win_maximized_get_static_delegate = new efl_ui_win_maximized_get_delegate(maximized_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_maximized_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_maximized_get_static_delegate)});
      if (efl_ui_win_maximized_set_static_delegate == null)
      efl_ui_win_maximized_set_static_delegate = new efl_ui_win_maximized_set_delegate(maximized_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_maximized_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_maximized_set_static_delegate)});
      if (efl_ui_win_fullscreen_get_static_delegate == null)
      efl_ui_win_fullscreen_get_static_delegate = new efl_ui_win_fullscreen_get_delegate(fullscreen_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_fullscreen_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_fullscreen_get_static_delegate)});
      if (efl_ui_win_fullscreen_set_static_delegate == null)
      efl_ui_win_fullscreen_set_static_delegate = new efl_ui_win_fullscreen_set_delegate(fullscreen_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_fullscreen_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_fullscreen_set_static_delegate)});
      if (efl_ui_win_sticky_get_static_delegate == null)
      efl_ui_win_sticky_get_static_delegate = new efl_ui_win_sticky_get_delegate(sticky_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_sticky_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_sticky_get_static_delegate)});
      if (efl_ui_win_sticky_set_static_delegate == null)
      efl_ui_win_sticky_set_static_delegate = new efl_ui_win_sticky_set_delegate(sticky_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_sticky_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_sticky_set_static_delegate)});
      if (efl_ui_win_urgent_get_static_delegate == null)
      efl_ui_win_urgent_get_static_delegate = new efl_ui_win_urgent_get_delegate(urgent_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_urgent_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_urgent_get_static_delegate)});
      if (efl_ui_win_urgent_set_static_delegate == null)
      efl_ui_win_urgent_set_static_delegate = new efl_ui_win_urgent_set_delegate(urgent_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_urgent_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_urgent_set_static_delegate)});
      if (efl_ui_win_modal_get_static_delegate == null)
      efl_ui_win_modal_get_static_delegate = new efl_ui_win_modal_get_delegate(modal_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_modal_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_modal_get_static_delegate)});
      if (efl_ui_win_modal_set_static_delegate == null)
      efl_ui_win_modal_set_static_delegate = new efl_ui_win_modal_set_delegate(modal_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_modal_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_modal_set_static_delegate)});
      if (efl_ui_win_noblank_get_static_delegate == null)
      efl_ui_win_noblank_get_static_delegate = new efl_ui_win_noblank_get_delegate(noblank_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_noblank_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_noblank_get_static_delegate)});
      if (efl_ui_win_noblank_set_static_delegate == null)
      efl_ui_win_noblank_set_static_delegate = new efl_ui_win_noblank_set_delegate(noblank_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_noblank_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_noblank_set_static_delegate)});
      if (efl_ui_win_borderless_get_static_delegate == null)
      efl_ui_win_borderless_get_static_delegate = new efl_ui_win_borderless_get_delegate(borderless_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_borderless_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_borderless_get_static_delegate)});
      if (efl_ui_win_borderless_set_static_delegate == null)
      efl_ui_win_borderless_set_static_delegate = new efl_ui_win_borderless_set_delegate(borderless_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_borderless_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_borderless_set_static_delegate)});
      if (efl_ui_win_role_get_static_delegate == null)
      efl_ui_win_role_get_static_delegate = new efl_ui_win_role_get_delegate(win_role_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_role_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_role_get_static_delegate)});
      if (efl_ui_win_role_set_static_delegate == null)
      efl_ui_win_role_set_static_delegate = new efl_ui_win_role_set_delegate(win_role_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_role_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_role_set_static_delegate)});
      if (efl_ui_win_name_get_static_delegate == null)
      efl_ui_win_name_get_static_delegate = new efl_ui_win_name_get_delegate(win_name_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_name_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_name_get_static_delegate)});
      if (efl_ui_win_name_set_static_delegate == null)
      efl_ui_win_name_set_static_delegate = new efl_ui_win_name_set_delegate(win_name_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_name_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_name_set_static_delegate)});
      if (efl_ui_win_type_get_static_delegate == null)
      efl_ui_win_type_get_static_delegate = new efl_ui_win_type_get_delegate(win_type_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_type_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_type_get_static_delegate)});
      if (efl_ui_win_type_set_static_delegate == null)
      efl_ui_win_type_set_static_delegate = new efl_ui_win_type_set_delegate(win_type_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_type_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_type_set_static_delegate)});
      if (efl_ui_win_accel_preference_get_static_delegate == null)
      efl_ui_win_accel_preference_get_static_delegate = new efl_ui_win_accel_preference_get_delegate(accel_preference_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_accel_preference_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_accel_preference_get_static_delegate)});
      if (efl_ui_win_accel_preference_set_static_delegate == null)
      efl_ui_win_accel_preference_set_static_delegate = new efl_ui_win_accel_preference_set_delegate(accel_preference_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_accel_preference_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_accel_preference_set_static_delegate)});
      if (efl_ui_win_alpha_get_static_delegate == null)
      efl_ui_win_alpha_get_static_delegate = new efl_ui_win_alpha_get_delegate(alpha_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_alpha_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_alpha_get_static_delegate)});
      if (efl_ui_win_alpha_set_static_delegate == null)
      efl_ui_win_alpha_set_static_delegate = new efl_ui_win_alpha_set_delegate(alpha_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_alpha_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_alpha_set_static_delegate)});
      if (efl_ui_win_stack_id_get_static_delegate == null)
      efl_ui_win_stack_id_get_static_delegate = new efl_ui_win_stack_id_get_delegate(stack_id_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_id_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_id_get_static_delegate)});
      if (efl_ui_win_stack_master_id_get_static_delegate == null)
      efl_ui_win_stack_master_id_get_static_delegate = new efl_ui_win_stack_master_id_get_delegate(stack_master_id_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_master_id_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_master_id_get_static_delegate)});
      if (efl_ui_win_stack_master_id_set_static_delegate == null)
      efl_ui_win_stack_master_id_set_static_delegate = new efl_ui_win_stack_master_id_set_delegate(stack_master_id_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_master_id_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_master_id_set_static_delegate)});
      if (efl_ui_win_stack_base_get_static_delegate == null)
      efl_ui_win_stack_base_get_static_delegate = new efl_ui_win_stack_base_get_delegate(stack_base_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_base_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_base_get_static_delegate)});
      if (efl_ui_win_stack_base_set_static_delegate == null)
      efl_ui_win_stack_base_set_static_delegate = new efl_ui_win_stack_base_set_delegate(stack_base_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_base_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_base_set_static_delegate)});
      if (efl_ui_win_hint_base_get_static_delegate == null)
      efl_ui_win_hint_base_get_static_delegate = new efl_ui_win_hint_base_get_delegate(hint_base_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_hint_base_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_hint_base_get_static_delegate)});
      if (efl_ui_win_hint_base_set_static_delegate == null)
      efl_ui_win_hint_base_set_static_delegate = new efl_ui_win_hint_base_set_delegate(hint_base_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_hint_base_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_hint_base_set_static_delegate)});
      if (efl_ui_win_hint_step_get_static_delegate == null)
      efl_ui_win_hint_step_get_static_delegate = new efl_ui_win_hint_step_get_delegate(hint_step_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_hint_step_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_hint_step_get_static_delegate)});
      if (efl_ui_win_hint_step_set_static_delegate == null)
      efl_ui_win_hint_step_set_static_delegate = new efl_ui_win_hint_step_set_delegate(hint_step_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_hint_step_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_hint_step_set_static_delegate)});
      if (efl_ui_win_focus_highlight_enabled_get_static_delegate == null)
      efl_ui_win_focus_highlight_enabled_get_static_delegate = new efl_ui_win_focus_highlight_enabled_get_delegate(focus_highlight_enabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_enabled_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_enabled_get_static_delegate)});
      if (efl_ui_win_focus_highlight_enabled_set_static_delegate == null)
      efl_ui_win_focus_highlight_enabled_set_static_delegate = new efl_ui_win_focus_highlight_enabled_set_delegate(focus_highlight_enabled_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_enabled_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_enabled_set_static_delegate)});
      if (efl_ui_win_focus_highlight_style_get_static_delegate == null)
      efl_ui_win_focus_highlight_style_get_static_delegate = new efl_ui_win_focus_highlight_style_get_delegate(focus_highlight_style_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_style_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_style_get_static_delegate)});
      if (efl_ui_win_focus_highlight_style_set_static_delegate == null)
      efl_ui_win_focus_highlight_style_set_static_delegate = new efl_ui_win_focus_highlight_style_set_delegate(focus_highlight_style_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_style_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_style_set_static_delegate)});
      if (efl_ui_win_focus_highlight_animate_get_static_delegate == null)
      efl_ui_win_focus_highlight_animate_get_static_delegate = new efl_ui_win_focus_highlight_animate_get_delegate(focus_highlight_animate_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_animate_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_animate_get_static_delegate)});
      if (efl_ui_win_focus_highlight_animate_set_static_delegate == null)
      efl_ui_win_focus_highlight_animate_set_static_delegate = new efl_ui_win_focus_highlight_animate_set_delegate(focus_highlight_animate_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_focus_highlight_animate_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_focus_highlight_animate_set_static_delegate)});
      if (efl_ui_win_stack_pop_to_static_delegate == null)
      efl_ui_win_stack_pop_to_static_delegate = new efl_ui_win_stack_pop_to_delegate(stack_pop_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_stack_pop_to"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_stack_pop_to_static_delegate)});
      if (efl_ui_win_activate_static_delegate == null)
      efl_ui_win_activate_static_delegate = new efl_ui_win_activate_delegate(activate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_activate"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_activate_static_delegate)});
      if (efl_ui_win_center_static_delegate == null)
      efl_ui_win_center_static_delegate = new efl_ui_win_center_delegate(center);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_center"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_center_static_delegate)});
      if (efl_ui_win_keygrab_set_static_delegate == null)
      efl_ui_win_keygrab_set_static_delegate = new efl_ui_win_keygrab_set_delegate(keygrab_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_keygrab_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_keygrab_set_static_delegate)});
      if (efl_ui_win_keygrab_unset_static_delegate == null)
      efl_ui_win_keygrab_unset_static_delegate = new efl_ui_win_keygrab_unset_delegate(keygrab_unset);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_keygrab_unset"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_keygrab_unset_static_delegate)});
      if (efl_ui_win_move_resize_start_static_delegate == null)
      efl_ui_win_move_resize_start_static_delegate = new efl_ui_win_move_resize_start_delegate(move_resize_start);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_move_resize_start"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_move_resize_start_static_delegate)});
      if (efl_ui_win_pointer_iterate_static_delegate == null)
      efl_ui_win_pointer_iterate_static_delegate = new efl_ui_win_pointer_iterate_delegate(pointer_iterate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_win_pointer_iterate"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_win_pointer_iterate_static_delegate)});
      if (efl_config_get_static_delegate == null)
      efl_config_get_static_delegate = new efl_config_get_delegate(config_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_config_get"), func = Marshal.GetFunctionPointerForDelegate(efl_config_get_static_delegate)});
      if (efl_config_set_static_delegate == null)
      efl_config_set_static_delegate = new efl_config_set_delegate(config_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_config_set"), func = Marshal.GetFunctionPointerForDelegate(efl_config_set_static_delegate)});
      if (efl_content_get_static_delegate == null)
      efl_content_get_static_delegate = new efl_content_get_delegate(content_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_get"), func = Marshal.GetFunctionPointerForDelegate(efl_content_get_static_delegate)});
      if (efl_content_set_static_delegate == null)
      efl_content_set_static_delegate = new efl_content_set_delegate(content_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_set"), func = Marshal.GetFunctionPointerForDelegate(efl_content_set_static_delegate)});
      if (efl_content_unset_static_delegate == null)
      efl_content_unset_static_delegate = new efl_content_unset_delegate(content_unset);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_content_unset"), func = Marshal.GetFunctionPointerForDelegate(efl_content_unset_static_delegate)});
      if (efl_screen_size_in_pixels_get_static_delegate == null)
      efl_screen_size_in_pixels_get_static_delegate = new efl_screen_size_in_pixels_get_delegate(screen_size_in_pixels_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_screen_size_in_pixels_get"), func = Marshal.GetFunctionPointerForDelegate(efl_screen_size_in_pixels_get_static_delegate)});
      if (efl_screen_scale_factor_get_static_delegate == null)
      efl_screen_scale_factor_get_static_delegate = new efl_screen_scale_factor_get_delegate(screen_scale_factor_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_screen_scale_factor_get"), func = Marshal.GetFunctionPointerForDelegate(efl_screen_scale_factor_get_static_delegate)});
      if (efl_screen_rotation_get_static_delegate == null)
      efl_screen_rotation_get_static_delegate = new efl_screen_rotation_get_delegate(screen_rotation_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_screen_rotation_get"), func = Marshal.GetFunctionPointerForDelegate(efl_screen_rotation_get_static_delegate)});
      if (efl_screen_dpi_get_static_delegate == null)
      efl_screen_dpi_get_static_delegate = new efl_screen_dpi_get_delegate(screen_dpi_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_screen_dpi_get"), func = Marshal.GetFunctionPointerForDelegate(efl_screen_dpi_get_static_delegate)});
      if (efl_text_get_static_delegate == null)
      efl_text_get_static_delegate = new efl_text_get_delegate(text_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_get_static_delegate)});
      if (efl_text_set_static_delegate == null)
      efl_text_set_static_delegate = new efl_text_set_delegate(text_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_set_static_delegate)});
      if (efl_canvas_scene_image_max_size_get_static_delegate == null)
      efl_canvas_scene_image_max_size_get_static_delegate = new efl_canvas_scene_image_max_size_get_delegate(image_max_size_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_image_max_size_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_image_max_size_get_static_delegate)});
      if (efl_canvas_scene_group_objects_calculating_get_static_delegate == null)
      efl_canvas_scene_group_objects_calculating_get_static_delegate = new efl_canvas_scene_group_objects_calculating_get_delegate(group_objects_calculating_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_group_objects_calculating_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_group_objects_calculating_get_static_delegate)});
      if (efl_canvas_scene_device_get_static_delegate == null)
      efl_canvas_scene_device_get_static_delegate = new efl_canvas_scene_device_get_delegate(device_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_device_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_device_get_static_delegate)});
      if (efl_canvas_scene_seat_get_static_delegate == null)
      efl_canvas_scene_seat_get_static_delegate = new efl_canvas_scene_seat_get_delegate(seat_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_seat_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_seat_get_static_delegate)});
      if (efl_canvas_scene_seat_default_get_static_delegate == null)
      efl_canvas_scene_seat_default_get_static_delegate = new efl_canvas_scene_seat_default_get_delegate(seat_default_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_seat_default_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_seat_default_get_static_delegate)});
      if (efl_canvas_scene_pointer_position_get_static_delegate == null)
      efl_canvas_scene_pointer_position_get_static_delegate = new efl_canvas_scene_pointer_position_get_delegate(pointer_position_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_pointer_position_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_pointer_position_get_static_delegate)});
      if (efl_canvas_scene_group_objects_calculate_static_delegate == null)
      efl_canvas_scene_group_objects_calculate_static_delegate = new efl_canvas_scene_group_objects_calculate_delegate(group_objects_calculate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_group_objects_calculate"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_group_objects_calculate_static_delegate)});
      if (efl_canvas_scene_objects_at_xy_get_static_delegate == null)
      efl_canvas_scene_objects_at_xy_get_static_delegate = new efl_canvas_scene_objects_at_xy_get_delegate(objects_at_xy_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_objects_at_xy_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_objects_at_xy_get_static_delegate)});
      if (efl_canvas_scene_object_top_at_xy_get_static_delegate == null)
      efl_canvas_scene_object_top_at_xy_get_static_delegate = new efl_canvas_scene_object_top_at_xy_get_delegate(object_top_at_xy_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_object_top_at_xy_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_object_top_at_xy_get_static_delegate)});
      if (efl_canvas_scene_objects_in_rectangle_get_static_delegate == null)
      efl_canvas_scene_objects_in_rectangle_get_static_delegate = new efl_canvas_scene_objects_in_rectangle_get_delegate(objects_in_rectangle_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_objects_in_rectangle_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_objects_in_rectangle_get_static_delegate)});
      if (efl_canvas_scene_object_top_in_rectangle_get_static_delegate == null)
      efl_canvas_scene_object_top_in_rectangle_get_static_delegate = new efl_canvas_scene_object_top_in_rectangle_get_delegate(object_top_in_rectangle_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_object_top_in_rectangle_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_object_top_in_rectangle_get_static_delegate)});
      if (efl_canvas_scene_seats_static_delegate == null)
      efl_canvas_scene_seats_static_delegate = new efl_canvas_scene_seats_delegate(seats);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_scene_seats"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_scene_seats_static_delegate)});
      if (efl_input_modifier_enabled_get_static_delegate == null)
      efl_input_modifier_enabled_get_static_delegate = new efl_input_modifier_enabled_get_delegate(modifier_enabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_modifier_enabled_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_modifier_enabled_get_static_delegate)});
      if (efl_input_lock_enabled_get_static_delegate == null)
      efl_input_lock_enabled_get_static_delegate = new efl_input_lock_enabled_get_delegate(lock_enabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_input_lock_enabled_get"), func = Marshal.GetFunctionPointerForDelegate(efl_input_lock_enabled_get_static_delegate)});
      if (efl_ui_widget_focus_manager_create_static_delegate == null)
      efl_ui_widget_focus_manager_create_static_delegate = new efl_ui_widget_focus_manager_create_delegate(focus_manager_create);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_widget_focus_manager_create"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_widget_focus_manager_create_static_delegate)});
      if (efl_ui_focus_manager_focus_get_static_delegate == null)
      efl_ui_focus_manager_focus_get_static_delegate = new efl_ui_focus_manager_focus_get_delegate(manager_focus_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_get_static_delegate)});
      if (efl_ui_focus_manager_focus_set_static_delegate == null)
      efl_ui_focus_manager_focus_set_static_delegate = new efl_ui_focus_manager_focus_set_delegate(manager_focus_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_set_static_delegate)});
      if (efl_ui_focus_manager_redirect_get_static_delegate == null)
      efl_ui_focus_manager_redirect_get_static_delegate = new efl_ui_focus_manager_redirect_get_delegate(redirect_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_get_static_delegate)});
      if (efl_ui_focus_manager_redirect_set_static_delegate == null)
      efl_ui_focus_manager_redirect_set_static_delegate = new efl_ui_focus_manager_redirect_set_delegate(redirect_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_set_static_delegate)});
      if (efl_ui_focus_manager_border_elements_get_static_delegate == null)
      efl_ui_focus_manager_border_elements_get_static_delegate = new efl_ui_focus_manager_border_elements_get_delegate(border_elements_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_border_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_border_elements_get_static_delegate)});
      if (efl_ui_focus_manager_viewport_elements_get_static_delegate == null)
      efl_ui_focus_manager_viewport_elements_get_static_delegate = new efl_ui_focus_manager_viewport_elements_get_delegate(viewport_elements_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_viewport_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_viewport_elements_get_static_delegate)});
      if (efl_ui_focus_manager_root_get_static_delegate == null)
      efl_ui_focus_manager_root_get_static_delegate = new efl_ui_focus_manager_root_get_delegate(root_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_get_static_delegate)});
      if (efl_ui_focus_manager_root_set_static_delegate == null)
      efl_ui_focus_manager_root_set_static_delegate = new efl_ui_focus_manager_root_set_delegate(root_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_set_static_delegate)});
      if (efl_ui_focus_manager_move_static_delegate == null)
      efl_ui_focus_manager_move_static_delegate = new efl_ui_focus_manager_move_delegate(move);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_move_static_delegate)});
      if (efl_ui_focus_manager_request_move_static_delegate == null)
      efl_ui_focus_manager_request_move_static_delegate = new efl_ui_focus_manager_request_move_delegate(request_move);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_move_static_delegate)});
      if (efl_ui_focus_manager_request_subchild_static_delegate == null)
      efl_ui_focus_manager_request_subchild_static_delegate = new efl_ui_focus_manager_request_subchild_delegate(request_subchild);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_subchild"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_subchild_static_delegate)});
      if (efl_ui_focus_manager_fetch_static_delegate == null)
      efl_ui_focus_manager_fetch_static_delegate = new efl_ui_focus_manager_fetch_delegate(fetch);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_fetch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_fetch_static_delegate)});
      if (efl_ui_focus_manager_logical_end_static_delegate == null)
      efl_ui_focus_manager_logical_end_static_delegate = new efl_ui_focus_manager_logical_end_delegate(logical_end);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_logical_end"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_logical_end_static_delegate)});
      if (efl_ui_focus_manager_reset_history_static_delegate == null)
      efl_ui_focus_manager_reset_history_static_delegate = new efl_ui_focus_manager_reset_history_delegate(reset_history);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_reset_history"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_reset_history_static_delegate)});
      if (efl_ui_focus_manager_pop_history_stack_static_delegate == null)
      efl_ui_focus_manager_pop_history_stack_static_delegate = new efl_ui_focus_manager_pop_history_stack_delegate(pop_history_stack);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_pop_history_stack"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_pop_history_stack_static_delegate)});
      if (efl_ui_focus_manager_setup_on_first_touch_static_delegate == null)
      efl_ui_focus_manager_setup_on_first_touch_static_delegate = new efl_ui_focus_manager_setup_on_first_touch_delegate(setup_on_first_touch);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_setup_on_first_touch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_setup_on_first_touch_static_delegate)});
      if (efl_ui_focus_manager_dirty_logic_freeze_static_delegate == null)
      efl_ui_focus_manager_dirty_logic_freeze_static_delegate = new efl_ui_focus_manager_dirty_logic_freeze_delegate(dirty_logic_freeze);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_freeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_freeze_static_delegate)});
      if (efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate == null)
      efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate = new efl_ui_focus_manager_dirty_logic_unfreeze_delegate(dirty_logic_unfreeze);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_unfreeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate)});
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Ui.Win.efl_ui_win_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.Win.efl_ui_win_class_get();
   }


    private delegate Efl.Ui.WinIndicatorMode efl_ui_win_indicator_mode_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.WinIndicatorMode efl_ui_win_indicator_mode_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_indicator_mode_get_api_delegate> efl_ui_win_indicator_mode_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_indicator_mode_get_api_delegate>(_Module, "efl_ui_win_indicator_mode_get");
    private static Efl.Ui.WinIndicatorMode indicator_mode_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_indicator_mode_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.WinIndicatorMode _ret_var = default(Efl.Ui.WinIndicatorMode);
         try {
            _ret_var = ((Win)wrapper).GetIndicatorMode();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_indicator_mode_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_indicator_mode_get_delegate efl_ui_win_indicator_mode_get_static_delegate;


    private delegate  void efl_ui_win_indicator_mode_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinIndicatorMode type);


    public delegate  void efl_ui_win_indicator_mode_set_api_delegate(System.IntPtr obj,   Efl.Ui.WinIndicatorMode type);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_indicator_mode_set_api_delegate> efl_ui_win_indicator_mode_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_indicator_mode_set_api_delegate>(_Module, "efl_ui_win_indicator_mode_set");
    private static  void indicator_mode_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinIndicatorMode type)
   {
      Eina.Log.Debug("function efl_ui_win_indicator_mode_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetIndicatorMode( type);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_indicator_mode_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  type);
      }
   }
   private static efl_ui_win_indicator_mode_set_delegate efl_ui_win_indicator_mode_set_static_delegate;


    private delegate Efl.Ui.WinKeyboardMode efl_ui_win_keyboard_mode_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.WinKeyboardMode efl_ui_win_keyboard_mode_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_keyboard_mode_get_api_delegate> efl_ui_win_keyboard_mode_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_keyboard_mode_get_api_delegate>(_Module, "efl_ui_win_keyboard_mode_get");
    private static Efl.Ui.WinKeyboardMode keyboard_mode_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_keyboard_mode_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.WinKeyboardMode _ret_var = default(Efl.Ui.WinKeyboardMode);
         try {
            _ret_var = ((Win)wrapper).GetKeyboardMode();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_keyboard_mode_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_keyboard_mode_get_delegate efl_ui_win_keyboard_mode_get_static_delegate;


    private delegate  void efl_ui_win_keyboard_mode_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinKeyboardMode mode);


    public delegate  void efl_ui_win_keyboard_mode_set_api_delegate(System.IntPtr obj,   Efl.Ui.WinKeyboardMode mode);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_keyboard_mode_set_api_delegate> efl_ui_win_keyboard_mode_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_keyboard_mode_set_api_delegate>(_Module, "efl_ui_win_keyboard_mode_set");
    private static  void keyboard_mode_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinKeyboardMode mode)
   {
      Eina.Log.Debug("function efl_ui_win_keyboard_mode_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetKeyboardMode( mode);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_keyboard_mode_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  mode);
      }
   }
   private static efl_ui_win_keyboard_mode_set_delegate efl_ui_win_keyboard_mode_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_wm_available_rotations_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  out bool allow_0,  [MarshalAs(UnmanagedType.U1)]  out bool allow_90,  [MarshalAs(UnmanagedType.U1)]  out bool allow_180,  [MarshalAs(UnmanagedType.U1)]  out bool allow_270);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_wm_available_rotations_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  out bool allow_0,  [MarshalAs(UnmanagedType.U1)]  out bool allow_90,  [MarshalAs(UnmanagedType.U1)]  out bool allow_180,  [MarshalAs(UnmanagedType.U1)]  out bool allow_270);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_rotations_get_api_delegate> efl_ui_win_wm_available_rotations_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_rotations_get_api_delegate>(_Module, "efl_ui_win_wm_available_rotations_get");
    private static bool wm_available_rotations_get(System.IntPtr obj, System.IntPtr pd,  out bool allow_0,  out bool allow_90,  out bool allow_180,  out bool allow_270)
   {
      Eina.Log.Debug("function efl_ui_win_wm_available_rotations_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       allow_0 = default(bool);      allow_90 = default(bool);      allow_180 = default(bool);      allow_270 = default(bool);                                 bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetWmAvailableRotations( out allow_0,  out allow_90,  out allow_180,  out allow_270);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                      return _ret_var;
      } else {
         return efl_ui_win_wm_available_rotations_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out allow_0,  out allow_90,  out allow_180,  out allow_270);
      }
   }
   private static efl_ui_win_wm_available_rotations_get_delegate efl_ui_win_wm_available_rotations_get_static_delegate;


    private delegate  void efl_ui_win_wm_available_rotations_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool allow_0,  [MarshalAs(UnmanagedType.U1)]  bool allow_90,  [MarshalAs(UnmanagedType.U1)]  bool allow_180,  [MarshalAs(UnmanagedType.U1)]  bool allow_270);


    public delegate  void efl_ui_win_wm_available_rotations_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool allow_0,  [MarshalAs(UnmanagedType.U1)]  bool allow_90,  [MarshalAs(UnmanagedType.U1)]  bool allow_180,  [MarshalAs(UnmanagedType.U1)]  bool allow_270);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_rotations_set_api_delegate> efl_ui_win_wm_available_rotations_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_rotations_set_api_delegate>(_Module, "efl_ui_win_wm_available_rotations_set");
    private static  void wm_available_rotations_set(System.IntPtr obj, System.IntPtr pd,  bool allow_0,  bool allow_90,  bool allow_180,  bool allow_270)
   {
      Eina.Log.Debug("function efl_ui_win_wm_available_rotations_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((Win)wrapper).SetWmAvailableRotations( allow_0,  allow_90,  allow_180,  allow_270);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_ui_win_wm_available_rotations_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  allow_0,  allow_90,  allow_180,  allow_270);
      }
   }
   private static efl_ui_win_wm_available_rotations_set_delegate efl_ui_win_wm_available_rotations_set_static_delegate;


    private delegate  System.IntPtr efl_ui_win_wm_available_profiles_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  System.IntPtr efl_ui_win_wm_available_profiles_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_profiles_get_api_delegate> efl_ui_win_wm_available_profiles_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_profiles_get_api_delegate>(_Module, "efl_ui_win_wm_available_profiles_get");
    private static  System.IntPtr wm_available_profiles_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_wm_available_profiles_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Array< System.String> _ret_var = default(Eina.Array< System.String>);
         try {
            _ret_var = ((Win)wrapper).GetWmAvailableProfiles();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var.Handle;
      } else {
         return efl_ui_win_wm_available_profiles_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_wm_available_profiles_get_delegate efl_ui_win_wm_available_profiles_get_static_delegate;


    private delegate  void efl_ui_win_wm_available_profiles_set_delegate(System.IntPtr obj, System.IntPtr pd,    System.IntPtr profiles);


    public delegate  void efl_ui_win_wm_available_profiles_set_api_delegate(System.IntPtr obj,    System.IntPtr profiles);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_profiles_set_api_delegate> efl_ui_win_wm_available_profiles_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_wm_available_profiles_set_api_delegate>(_Module, "efl_ui_win_wm_available_profiles_set");
    private static  void wm_available_profiles_set(System.IntPtr obj, System.IntPtr pd,   System.IntPtr profiles)
   {
      Eina.Log.Debug("function efl_ui_win_wm_available_profiles_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_profiles = new Eina.Array< System.String>(profiles, false, false);
                     
         try {
            ((Win)wrapper).SetWmAvailableProfiles( _in_profiles);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_wm_available_profiles_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  profiles);
      }
   }
   private static efl_ui_win_wm_available_profiles_set_delegate efl_ui_win_wm_available_profiles_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_screen_constrain_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_screen_constrain_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_screen_constrain_get_api_delegate> efl_ui_win_screen_constrain_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_screen_constrain_get_api_delegate>(_Module, "efl_ui_win_screen_constrain_get");
    private static bool screen_constrain_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_screen_constrain_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetScreenConstrain();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_screen_constrain_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_screen_constrain_get_delegate efl_ui_win_screen_constrain_get_static_delegate;


    private delegate  void efl_ui_win_screen_constrain_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool constrain);


    public delegate  void efl_ui_win_screen_constrain_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool constrain);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_screen_constrain_set_api_delegate> efl_ui_win_screen_constrain_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_screen_constrain_set_api_delegate>(_Module, "efl_ui_win_screen_constrain_set");
    private static  void screen_constrain_set(System.IntPtr obj, System.IntPtr pd,  bool constrain)
   {
      Eina.Log.Debug("function efl_ui_win_screen_constrain_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetScreenConstrain( constrain);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_screen_constrain_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  constrain);
      }
   }
   private static efl_ui_win_screen_constrain_set_delegate efl_ui_win_screen_constrain_set_static_delegate;


    private delegate  void efl_ui_win_prop_focus_skip_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool skip);


    public delegate  void efl_ui_win_prop_focus_skip_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool skip);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_prop_focus_skip_set_api_delegate> efl_ui_win_prop_focus_skip_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_prop_focus_skip_set_api_delegate>(_Module, "efl_ui_win_prop_focus_skip_set");
    private static  void prop_focus_skip_set(System.IntPtr obj, System.IntPtr pd,  bool skip)
   {
      Eina.Log.Debug("function efl_ui_win_prop_focus_skip_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetPropFocusSkip( skip);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_prop_focus_skip_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  skip);
      }
   }
   private static efl_ui_win_prop_focus_skip_set_delegate efl_ui_win_prop_focus_skip_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_autohide_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_autohide_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_autohide_get_api_delegate> efl_ui_win_autohide_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_autohide_get_api_delegate>(_Module, "efl_ui_win_autohide_get");
    private static bool autohide_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_autohide_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetAutohide();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_autohide_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_autohide_get_delegate efl_ui_win_autohide_get_static_delegate;


    private delegate  void efl_ui_win_autohide_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool autohide);


    public delegate  void efl_ui_win_autohide_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool autohide);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_autohide_set_api_delegate> efl_ui_win_autohide_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_autohide_set_api_delegate>(_Module, "efl_ui_win_autohide_set");
    private static  void autohide_set(System.IntPtr obj, System.IntPtr pd,  bool autohide)
   {
      Eina.Log.Debug("function efl_ui_win_autohide_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetAutohide( autohide);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_autohide_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  autohide);
      }
   }
   private static efl_ui_win_autohide_set_delegate efl_ui_win_autohide_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))] private delegate  Eina.Value efl_ui_win_exit_on_close_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))] public delegate  Eina.Value efl_ui_win_exit_on_close_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_close_get_api_delegate> efl_ui_win_exit_on_close_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_close_get_api_delegate>(_Module, "efl_ui_win_exit_on_close_get");
    private static  Eina.Value exit_on_close_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_exit_on_close_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   Eina.Value _ret_var = default( Eina.Value);
         try {
            _ret_var = ((Win)wrapper).GetExitOnClose();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_exit_on_close_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_exit_on_close_get_delegate efl_ui_win_exit_on_close_get_static_delegate;


    private delegate  void efl_ui_win_exit_on_close_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value exit_code);


    public delegate  void efl_ui_win_exit_on_close_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value exit_code);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_close_set_api_delegate> efl_ui_win_exit_on_close_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_close_set_api_delegate>(_Module, "efl_ui_win_exit_on_close_set");
    private static  void exit_on_close_set(System.IntPtr obj, System.IntPtr pd,   Eina.Value exit_code)
   {
      Eina.Log.Debug("function efl_ui_win_exit_on_close_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetExitOnClose( exit_code);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_exit_on_close_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  exit_code);
      }
   }
   private static efl_ui_win_exit_on_close_set_delegate efl_ui_win_exit_on_close_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))] private delegate Efl.Canvas.Object efl_ui_win_icon_object_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))] public delegate Efl.Canvas.Object efl_ui_win_icon_object_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_icon_object_get_api_delegate> efl_ui_win_icon_object_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_icon_object_get_api_delegate>(_Module, "efl_ui_win_icon_object_get");
    private static Efl.Canvas.Object icon_object_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_icon_object_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Canvas.Object _ret_var = default(Efl.Canvas.Object);
         try {
            _ret_var = ((Win)wrapper).GetIconObject();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_icon_object_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_icon_object_get_delegate efl_ui_win_icon_object_get_static_delegate;


    private delegate  void efl_ui_win_icon_object_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object icon);


    public delegate  void efl_ui_win_icon_object_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object icon);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_icon_object_set_api_delegate> efl_ui_win_icon_object_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_icon_object_set_api_delegate>(_Module, "efl_ui_win_icon_object_set");
    private static  void icon_object_set(System.IntPtr obj, System.IntPtr pd,  Efl.Canvas.Object icon)
   {
      Eina.Log.Debug("function efl_ui_win_icon_object_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetIconObject( icon);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_icon_object_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  icon);
      }
   }
   private static efl_ui_win_icon_object_set_delegate efl_ui_win_icon_object_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_minimized_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_minimized_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_minimized_get_api_delegate> efl_ui_win_minimized_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_minimized_get_api_delegate>(_Module, "efl_ui_win_minimized_get");
    private static bool minimized_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_minimized_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetMinimized();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_minimized_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_minimized_get_delegate efl_ui_win_minimized_get_static_delegate;


    private delegate  void efl_ui_win_minimized_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool state);


    public delegate  void efl_ui_win_minimized_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool state);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_minimized_set_api_delegate> efl_ui_win_minimized_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_minimized_set_api_delegate>(_Module, "efl_ui_win_minimized_set");
    private static  void minimized_set(System.IntPtr obj, System.IntPtr pd,  bool state)
   {
      Eina.Log.Debug("function efl_ui_win_minimized_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetMinimized( state);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_minimized_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  state);
      }
   }
   private static efl_ui_win_minimized_set_delegate efl_ui_win_minimized_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_maximized_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_maximized_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_maximized_get_api_delegate> efl_ui_win_maximized_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_maximized_get_api_delegate>(_Module, "efl_ui_win_maximized_get");
    private static bool maximized_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_maximized_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetMaximized();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_maximized_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_maximized_get_delegate efl_ui_win_maximized_get_static_delegate;


    private delegate  void efl_ui_win_maximized_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool maximized);


    public delegate  void efl_ui_win_maximized_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool maximized);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_maximized_set_api_delegate> efl_ui_win_maximized_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_maximized_set_api_delegate>(_Module, "efl_ui_win_maximized_set");
    private static  void maximized_set(System.IntPtr obj, System.IntPtr pd,  bool maximized)
   {
      Eina.Log.Debug("function efl_ui_win_maximized_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetMaximized( maximized);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_maximized_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  maximized);
      }
   }
   private static efl_ui_win_maximized_set_delegate efl_ui_win_maximized_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_fullscreen_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_fullscreen_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_fullscreen_get_api_delegate> efl_ui_win_fullscreen_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_fullscreen_get_api_delegate>(_Module, "efl_ui_win_fullscreen_get");
    private static bool fullscreen_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_fullscreen_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetFullscreen();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_fullscreen_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_fullscreen_get_delegate efl_ui_win_fullscreen_get_static_delegate;


    private delegate  void efl_ui_win_fullscreen_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool fullscreen);


    public delegate  void efl_ui_win_fullscreen_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool fullscreen);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_fullscreen_set_api_delegate> efl_ui_win_fullscreen_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_fullscreen_set_api_delegate>(_Module, "efl_ui_win_fullscreen_set");
    private static  void fullscreen_set(System.IntPtr obj, System.IntPtr pd,  bool fullscreen)
   {
      Eina.Log.Debug("function efl_ui_win_fullscreen_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetFullscreen( fullscreen);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_fullscreen_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  fullscreen);
      }
   }
   private static efl_ui_win_fullscreen_set_delegate efl_ui_win_fullscreen_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_sticky_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_sticky_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_sticky_get_api_delegate> efl_ui_win_sticky_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_sticky_get_api_delegate>(_Module, "efl_ui_win_sticky_get");
    private static bool sticky_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_sticky_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetSticky();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_sticky_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_sticky_get_delegate efl_ui_win_sticky_get_static_delegate;


    private delegate  void efl_ui_win_sticky_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool sticky);


    public delegate  void efl_ui_win_sticky_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool sticky);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_sticky_set_api_delegate> efl_ui_win_sticky_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_sticky_set_api_delegate>(_Module, "efl_ui_win_sticky_set");
    private static  void sticky_set(System.IntPtr obj, System.IntPtr pd,  bool sticky)
   {
      Eina.Log.Debug("function efl_ui_win_sticky_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetSticky( sticky);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_sticky_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  sticky);
      }
   }
   private static efl_ui_win_sticky_set_delegate efl_ui_win_sticky_set_static_delegate;


    private delegate Efl.Ui.WinUrgentMode efl_ui_win_urgent_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.WinUrgentMode efl_ui_win_urgent_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_urgent_get_api_delegate> efl_ui_win_urgent_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_urgent_get_api_delegate>(_Module, "efl_ui_win_urgent_get");
    private static Efl.Ui.WinUrgentMode urgent_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_urgent_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.WinUrgentMode _ret_var = default(Efl.Ui.WinUrgentMode);
         try {
            _ret_var = ((Win)wrapper).GetUrgent();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_urgent_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_urgent_get_delegate efl_ui_win_urgent_get_static_delegate;


    private delegate  void efl_ui_win_urgent_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinUrgentMode urgent);


    public delegate  void efl_ui_win_urgent_set_api_delegate(System.IntPtr obj,   Efl.Ui.WinUrgentMode urgent);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_urgent_set_api_delegate> efl_ui_win_urgent_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_urgent_set_api_delegate>(_Module, "efl_ui_win_urgent_set");
    private static  void urgent_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinUrgentMode urgent)
   {
      Eina.Log.Debug("function efl_ui_win_urgent_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetUrgent( urgent);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_urgent_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  urgent);
      }
   }
   private static efl_ui_win_urgent_set_delegate efl_ui_win_urgent_set_static_delegate;


    private delegate Efl.Ui.WinModalMode efl_ui_win_modal_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.WinModalMode efl_ui_win_modal_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_modal_get_api_delegate> efl_ui_win_modal_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_modal_get_api_delegate>(_Module, "efl_ui_win_modal_get");
    private static Efl.Ui.WinModalMode modal_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_modal_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.WinModalMode _ret_var = default(Efl.Ui.WinModalMode);
         try {
            _ret_var = ((Win)wrapper).GetModal();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_modal_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_modal_get_delegate efl_ui_win_modal_get_static_delegate;


    private delegate  void efl_ui_win_modal_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinModalMode modal);


    public delegate  void efl_ui_win_modal_set_api_delegate(System.IntPtr obj,   Efl.Ui.WinModalMode modal);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_modal_set_api_delegate> efl_ui_win_modal_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_modal_set_api_delegate>(_Module, "efl_ui_win_modal_set");
    private static  void modal_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinModalMode modal)
   {
      Eina.Log.Debug("function efl_ui_win_modal_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetModal( modal);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_modal_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  modal);
      }
   }
   private static efl_ui_win_modal_set_delegate efl_ui_win_modal_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_noblank_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_noblank_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_noblank_get_api_delegate> efl_ui_win_noblank_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_noblank_get_api_delegate>(_Module, "efl_ui_win_noblank_get");
    private static bool noblank_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_noblank_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetNoblank();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_noblank_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_noblank_get_delegate efl_ui_win_noblank_get_static_delegate;


    private delegate  void efl_ui_win_noblank_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool noblank);


    public delegate  void efl_ui_win_noblank_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool noblank);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_noblank_set_api_delegate> efl_ui_win_noblank_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_noblank_set_api_delegate>(_Module, "efl_ui_win_noblank_set");
    private static  void noblank_set(System.IntPtr obj, System.IntPtr pd,  bool noblank)
   {
      Eina.Log.Debug("function efl_ui_win_noblank_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetNoblank( noblank);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_noblank_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  noblank);
      }
   }
   private static efl_ui_win_noblank_set_delegate efl_ui_win_noblank_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_borderless_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_borderless_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_borderless_get_api_delegate> efl_ui_win_borderless_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_borderless_get_api_delegate>(_Module, "efl_ui_win_borderless_get");
    private static bool borderless_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_borderless_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetBorderless();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_borderless_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_borderless_get_delegate efl_ui_win_borderless_get_static_delegate;


    private delegate  void efl_ui_win_borderless_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool borderless);


    public delegate  void efl_ui_win_borderless_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool borderless);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_borderless_set_api_delegate> efl_ui_win_borderless_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_borderless_set_api_delegate>(_Module, "efl_ui_win_borderless_set");
    private static  void borderless_set(System.IntPtr obj, System.IntPtr pd,  bool borderless)
   {
      Eina.Log.Debug("function efl_ui_win_borderless_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetBorderless( borderless);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_borderless_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  borderless);
      }
   }
   private static efl_ui_win_borderless_set_delegate efl_ui_win_borderless_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_role_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_role_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_role_get_api_delegate> efl_ui_win_role_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_role_get_api_delegate>(_Module, "efl_ui_win_role_get");
    private static  System.String win_role_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_role_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetWinRole();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_role_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_role_get_delegate efl_ui_win_role_get_static_delegate;


    private delegate  void efl_ui_win_role_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String role);


    public delegate  void efl_ui_win_role_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String role);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_role_set_api_delegate> efl_ui_win_role_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_role_set_api_delegate>(_Module, "efl_ui_win_role_set");
    private static  void win_role_set(System.IntPtr obj, System.IntPtr pd,   System.String role)
   {
      Eina.Log.Debug("function efl_ui_win_role_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetWinRole( role);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_role_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  role);
      }
   }
   private static efl_ui_win_role_set_delegate efl_ui_win_role_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_name_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_name_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_name_get_api_delegate> efl_ui_win_name_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_name_get_api_delegate>(_Module, "efl_ui_win_name_get");
    private static  System.String win_name_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_name_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetWinName();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_name_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_name_get_delegate efl_ui_win_name_get_static_delegate;


    private delegate  void efl_ui_win_name_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


    public delegate  void efl_ui_win_name_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_name_set_api_delegate> efl_ui_win_name_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_name_set_api_delegate>(_Module, "efl_ui_win_name_set");
    private static  void win_name_set(System.IntPtr obj, System.IntPtr pd,   System.String name)
   {
      Eina.Log.Debug("function efl_ui_win_name_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetWinName( name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_name_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name);
      }
   }
   private static efl_ui_win_name_set_delegate efl_ui_win_name_set_static_delegate;


    private delegate Efl.Ui.WinType efl_ui_win_type_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.WinType efl_ui_win_type_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_type_get_api_delegate> efl_ui_win_type_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_type_get_api_delegate>(_Module, "efl_ui_win_type_get");
    private static Efl.Ui.WinType win_type_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_type_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.WinType _ret_var = default(Efl.Ui.WinType);
         try {
            _ret_var = ((Win)wrapper).GetWinType();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_type_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_type_get_delegate efl_ui_win_type_get_static_delegate;


    private delegate  void efl_ui_win_type_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinType type);


    public delegate  void efl_ui_win_type_set_api_delegate(System.IntPtr obj,   Efl.Ui.WinType type);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_type_set_api_delegate> efl_ui_win_type_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_type_set_api_delegate>(_Module, "efl_ui_win_type_set");
    private static  void win_type_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinType type)
   {
      Eina.Log.Debug("function efl_ui_win_type_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetWinType( type);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_type_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  type);
      }
   }
   private static efl_ui_win_type_set_delegate efl_ui_win_type_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_accel_preference_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_accel_preference_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_accel_preference_get_api_delegate> efl_ui_win_accel_preference_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_accel_preference_get_api_delegate>(_Module, "efl_ui_win_accel_preference_get");
    private static  System.String accel_preference_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_accel_preference_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetAccelPreference();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_accel_preference_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_accel_preference_get_delegate efl_ui_win_accel_preference_get_static_delegate;


    private delegate  void efl_ui_win_accel_preference_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String accel);


    public delegate  void efl_ui_win_accel_preference_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String accel);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_accel_preference_set_api_delegate> efl_ui_win_accel_preference_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_accel_preference_set_api_delegate>(_Module, "efl_ui_win_accel_preference_set");
    private static  void accel_preference_set(System.IntPtr obj, System.IntPtr pd,   System.String accel)
   {
      Eina.Log.Debug("function efl_ui_win_accel_preference_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetAccelPreference( accel);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_accel_preference_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  accel);
      }
   }
   private static efl_ui_win_accel_preference_set_delegate efl_ui_win_accel_preference_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_alpha_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_alpha_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_alpha_get_api_delegate> efl_ui_win_alpha_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_alpha_get_api_delegate>(_Module, "efl_ui_win_alpha_get");
    private static bool alpha_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_alpha_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetAlpha();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_alpha_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_alpha_get_delegate efl_ui_win_alpha_get_static_delegate;


    private delegate  void efl_ui_win_alpha_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool alpha);


    public delegate  void efl_ui_win_alpha_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool alpha);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_alpha_set_api_delegate> efl_ui_win_alpha_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_alpha_set_api_delegate>(_Module, "efl_ui_win_alpha_set");
    private static  void alpha_set(System.IntPtr obj, System.IntPtr pd,  bool alpha)
   {
      Eina.Log.Debug("function efl_ui_win_alpha_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetAlpha( alpha);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_alpha_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  alpha);
      }
   }
   private static efl_ui_win_alpha_set_delegate efl_ui_win_alpha_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_stack_id_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_stack_id_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_id_get_api_delegate> efl_ui_win_stack_id_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_id_get_api_delegate>(_Module, "efl_ui_win_stack_id_get");
    private static  System.String stack_id_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_stack_id_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetStackId();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_stack_id_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_stack_id_get_delegate efl_ui_win_stack_id_get_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_stack_master_id_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_stack_master_id_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_master_id_get_api_delegate> efl_ui_win_stack_master_id_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_master_id_get_api_delegate>(_Module, "efl_ui_win_stack_master_id_get");
    private static  System.String stack_master_id_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_stack_master_id_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetStackMasterId();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_stack_master_id_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_stack_master_id_get_delegate efl_ui_win_stack_master_id_get_static_delegate;


    private delegate  void efl_ui_win_stack_master_id_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String id);


    public delegate  void efl_ui_win_stack_master_id_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String id);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_master_id_set_api_delegate> efl_ui_win_stack_master_id_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_master_id_set_api_delegate>(_Module, "efl_ui_win_stack_master_id_set");
    private static  void stack_master_id_set(System.IntPtr obj, System.IntPtr pd,   System.String id)
   {
      Eina.Log.Debug("function efl_ui_win_stack_master_id_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetStackMasterId( id);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_stack_master_id_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  id);
      }
   }
   private static efl_ui_win_stack_master_id_set_delegate efl_ui_win_stack_master_id_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_stack_base_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_stack_base_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_base_get_api_delegate> efl_ui_win_stack_base_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_base_get_api_delegate>(_Module, "efl_ui_win_stack_base_get");
    private static bool stack_base_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_stack_base_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetStackBase();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_stack_base_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_stack_base_get_delegate efl_ui_win_stack_base_get_static_delegate;


    private delegate  void efl_ui_win_stack_base_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool kw_base);


    public delegate  void efl_ui_win_stack_base_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool kw_base);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_base_set_api_delegate> efl_ui_win_stack_base_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_base_set_api_delegate>(_Module, "efl_ui_win_stack_base_set");
    private static  void stack_base_set(System.IntPtr obj, System.IntPtr pd,  bool kw_base)
   {
      Eina.Log.Debug("function efl_ui_win_stack_base_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetStackBase( kw_base);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_stack_base_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  kw_base);
      }
   }
   private static efl_ui_win_stack_base_set_delegate efl_ui_win_stack_base_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))] private delegate  Eina.Value efl_ui_win_exit_on_all_windows_closed_get_delegate();


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))] public delegate  Eina.Value efl_ui_win_exit_on_all_windows_closed_get_api_delegate();
    public static Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_all_windows_closed_get_api_delegate> efl_ui_win_exit_on_all_windows_closed_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_all_windows_closed_get_api_delegate>(_Module, "efl_ui_win_exit_on_all_windows_closed_get");
    private static  Eina.Value exit_on_all_windows_closed_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_exit_on_all_windows_closed_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   Eina.Value _ret_var = default( Eina.Value);
         try {
            _ret_var = Win.GetExitOnAllWindowsClosed();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_exit_on_all_windows_closed_get_ptr.Value.Delegate();
      }
   }


    private delegate  void efl_ui_win_exit_on_all_windows_closed_set_delegate( [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value exit_code);


    public delegate  void efl_ui_win_exit_on_all_windows_closed_set_api_delegate( [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value exit_code);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_all_windows_closed_set_api_delegate> efl_ui_win_exit_on_all_windows_closed_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_exit_on_all_windows_closed_set_api_delegate>(_Module, "efl_ui_win_exit_on_all_windows_closed_set");
    private static  void exit_on_all_windows_closed_set(System.IntPtr obj, System.IntPtr pd,   Eina.Value exit_code)
   {
      Eina.Log.Debug("function efl_ui_win_exit_on_all_windows_closed_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            Win.SetExitOnAllWindowsClosed( exit_code);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_exit_on_all_windows_closed_set_ptr.Value.Delegate( exit_code);
      }
   }


    private delegate Eina.Size2D_StructInternal efl_ui_win_hint_base_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Size2D_StructInternal efl_ui_win_hint_base_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_hint_base_get_api_delegate> efl_ui_win_hint_base_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_hint_base_get_api_delegate>(_Module, "efl_ui_win_hint_base_get");
    private static Eina.Size2D_StructInternal hint_base_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_hint_base_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Size2D _ret_var = default(Eina.Size2D);
         try {
            _ret_var = ((Win)wrapper).GetHintBase();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Size2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_ui_win_hint_base_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_hint_base_get_delegate efl_ui_win_hint_base_get_static_delegate;


    private delegate  void efl_ui_win_hint_base_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Size2D_StructInternal sz);


    public delegate  void efl_ui_win_hint_base_set_api_delegate(System.IntPtr obj,   Eina.Size2D_StructInternal sz);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_hint_base_set_api_delegate> efl_ui_win_hint_base_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_hint_base_set_api_delegate>(_Module, "efl_ui_win_hint_base_set");
    private static  void hint_base_set(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D_StructInternal sz)
   {
      Eina.Log.Debug("function efl_ui_win_hint_base_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_sz = Eina.Size2D_StructConversion.ToManaged(sz);
                     
         try {
            ((Win)wrapper).SetHintBase( _in_sz);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_hint_base_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  sz);
      }
   }
   private static efl_ui_win_hint_base_set_delegate efl_ui_win_hint_base_set_static_delegate;


    private delegate Eina.Size2D_StructInternal efl_ui_win_hint_step_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Size2D_StructInternal efl_ui_win_hint_step_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_hint_step_get_api_delegate> efl_ui_win_hint_step_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_hint_step_get_api_delegate>(_Module, "efl_ui_win_hint_step_get");
    private static Eina.Size2D_StructInternal hint_step_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_hint_step_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Size2D _ret_var = default(Eina.Size2D);
         try {
            _ret_var = ((Win)wrapper).GetHintStep();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Size2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_ui_win_hint_step_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_hint_step_get_delegate efl_ui_win_hint_step_get_static_delegate;


    private delegate  void efl_ui_win_hint_step_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Size2D_StructInternal sz);


    public delegate  void efl_ui_win_hint_step_set_api_delegate(System.IntPtr obj,   Eina.Size2D_StructInternal sz);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_hint_step_set_api_delegate> efl_ui_win_hint_step_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_hint_step_set_api_delegate>(_Module, "efl_ui_win_hint_step_set");
    private static  void hint_step_set(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D_StructInternal sz)
   {
      Eina.Log.Debug("function efl_ui_win_hint_step_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_sz = Eina.Size2D_StructConversion.ToManaged(sz);
                     
         try {
            ((Win)wrapper).SetHintStep( _in_sz);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_hint_step_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  sz);
      }
   }
   private static efl_ui_win_hint_step_set_delegate efl_ui_win_hint_step_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_focus_highlight_enabled_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_focus_highlight_enabled_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_enabled_get_api_delegate> efl_ui_win_focus_highlight_enabled_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_enabled_get_api_delegate>(_Module, "efl_ui_win_focus_highlight_enabled_get");
    private static bool focus_highlight_enabled_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_enabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetFocusHighlightEnabled();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_focus_highlight_enabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_focus_highlight_enabled_get_delegate efl_ui_win_focus_highlight_enabled_get_static_delegate;


    private delegate  void efl_ui_win_focus_highlight_enabled_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool enabled);


    public delegate  void efl_ui_win_focus_highlight_enabled_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool enabled);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_enabled_set_api_delegate> efl_ui_win_focus_highlight_enabled_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_enabled_set_api_delegate>(_Module, "efl_ui_win_focus_highlight_enabled_set");
    private static  void focus_highlight_enabled_set(System.IntPtr obj, System.IntPtr pd,  bool enabled)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_enabled_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetFocusHighlightEnabled( enabled);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_focus_highlight_enabled_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  enabled);
      }
   }
   private static efl_ui_win_focus_highlight_enabled_set_delegate efl_ui_win_focus_highlight_enabled_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_ui_win_focus_highlight_style_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_ui_win_focus_highlight_style_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_style_get_api_delegate> efl_ui_win_focus_highlight_style_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_style_get_api_delegate>(_Module, "efl_ui_win_focus_highlight_style_get");
    private static  System.String focus_highlight_style_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_style_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetFocusHighlightStyle();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_focus_highlight_style_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_focus_highlight_style_get_delegate efl_ui_win_focus_highlight_style_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_focus_highlight_style_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String style);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_focus_highlight_style_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String style);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_style_set_api_delegate> efl_ui_win_focus_highlight_style_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_style_set_api_delegate>(_Module, "efl_ui_win_focus_highlight_style_set");
    private static bool focus_highlight_style_set(System.IntPtr obj, System.IntPtr pd,   System.String style)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_style_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).SetFocusHighlightStyle( style);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_win_focus_highlight_style_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  style);
      }
   }
   private static efl_ui_win_focus_highlight_style_set_delegate efl_ui_win_focus_highlight_style_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_focus_highlight_animate_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_focus_highlight_animate_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_animate_get_api_delegate> efl_ui_win_focus_highlight_animate_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_animate_get_api_delegate>(_Module, "efl_ui_win_focus_highlight_animate_get");
    private static bool focus_highlight_animate_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_animate_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetFocusHighlightAnimate();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_win_focus_highlight_animate_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_focus_highlight_animate_get_delegate efl_ui_win_focus_highlight_animate_get_static_delegate;


    private delegate  void efl_ui_win_focus_highlight_animate_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool animate);


    public delegate  void efl_ui_win_focus_highlight_animate_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool animate);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_animate_set_api_delegate> efl_ui_win_focus_highlight_animate_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_focus_highlight_animate_set_api_delegate>(_Module, "efl_ui_win_focus_highlight_animate_set");
    private static  void focus_highlight_animate_set(System.IntPtr obj, System.IntPtr pd,  bool animate)
   {
      Eina.Log.Debug("function efl_ui_win_focus_highlight_animate_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetFocusHighlightAnimate( animate);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_win_focus_highlight_animate_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  animate);
      }
   }
   private static efl_ui_win_focus_highlight_animate_set_delegate efl_ui_win_focus_highlight_animate_set_static_delegate;


    private delegate  void efl_ui_win_stack_pop_to_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_win_stack_pop_to_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_stack_pop_to_api_delegate> efl_ui_win_stack_pop_to_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_stack_pop_to_api_delegate>(_Module, "efl_ui_win_stack_pop_to");
    private static  void stack_pop_to(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_stack_pop_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).StackPopTo();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_win_stack_pop_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_stack_pop_to_delegate efl_ui_win_stack_pop_to_static_delegate;


    private delegate  void efl_ui_win_activate_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_win_activate_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_activate_api_delegate> efl_ui_win_activate_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_activate_api_delegate>(_Module, "efl_ui_win_activate");
    private static  void activate(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_win_activate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).Activate();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_win_activate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_win_activate_delegate efl_ui_win_activate_static_delegate;


    private delegate  void efl_ui_win_center_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool h,  [MarshalAs(UnmanagedType.U1)]  bool v);


    public delegate  void efl_ui_win_center_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool h,  [MarshalAs(UnmanagedType.U1)]  bool v);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_center_api_delegate> efl_ui_win_center_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_center_api_delegate>(_Module, "efl_ui_win_center");
    private static  void center(System.IntPtr obj, System.IntPtr pd,  bool h,  bool v)
   {
      Eina.Log.Debug("function efl_ui_win_center was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Win)wrapper).Center( h,  v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_ui_win_center_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  h,  v);
      }
   }
   private static efl_ui_win_center_delegate efl_ui_win_center_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_keygrab_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String key,   Efl.Input.Modifier modifiers,   Efl.Input.Modifier not_modifiers,    int priority,   Efl.Ui.WinKeygrabMode grab_mode);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_keygrab_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String key,   Efl.Input.Modifier modifiers,   Efl.Input.Modifier not_modifiers,    int priority,   Efl.Ui.WinKeygrabMode grab_mode);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_keygrab_set_api_delegate> efl_ui_win_keygrab_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_keygrab_set_api_delegate>(_Module, "efl_ui_win_keygrab_set");
    private static bool keygrab_set(System.IntPtr obj, System.IntPtr pd,   System.String key,  Efl.Input.Modifier modifiers,  Efl.Input.Modifier not_modifiers,   int priority,  Efl.Ui.WinKeygrabMode grab_mode)
   {
      Eina.Log.Debug("function efl_ui_win_keygrab_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                            bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).SetKeygrab( key,  modifiers,  not_modifiers,  priority,  grab_mode);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                  return _ret_var;
      } else {
         return efl_ui_win_keygrab_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  key,  modifiers,  not_modifiers,  priority,  grab_mode);
      }
   }
   private static efl_ui_win_keygrab_set_delegate efl_ui_win_keygrab_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_keygrab_unset_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String key,   Efl.Input.Modifier modifiers,   Efl.Input.Modifier not_modifiers);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_keygrab_unset_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String key,   Efl.Input.Modifier modifiers,   Efl.Input.Modifier not_modifiers);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_keygrab_unset_api_delegate> efl_ui_win_keygrab_unset_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_keygrab_unset_api_delegate>(_Module, "efl_ui_win_keygrab_unset");
    private static bool keygrab_unset(System.IntPtr obj, System.IntPtr pd,   System.String key,  Efl.Input.Modifier modifiers,  Efl.Input.Modifier not_modifiers)
   {
      Eina.Log.Debug("function efl_ui_win_keygrab_unset was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).UnsetKeygrab( key,  modifiers,  not_modifiers);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_ui_win_keygrab_unset_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  key,  modifiers,  not_modifiers);
      }
   }
   private static efl_ui_win_keygrab_unset_delegate efl_ui_win_keygrab_unset_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_win_move_resize_start_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.WinMoveResizeMode mode);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_win_move_resize_start_api_delegate(System.IntPtr obj,   Efl.Ui.WinMoveResizeMode mode);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_move_resize_start_api_delegate> efl_ui_win_move_resize_start_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_move_resize_start_api_delegate>(_Module, "efl_ui_win_move_resize_start");
    private static bool move_resize_start(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.WinMoveResizeMode mode)
   {
      Eina.Log.Debug("function efl_ui_win_move_resize_start was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).MoveResizeStart( mode);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_win_move_resize_start_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  mode);
      }
   }
   private static efl_ui_win_move_resize_start_delegate efl_ui_win_move_resize_start_static_delegate;


    private delegate  System.IntPtr efl_ui_win_pointer_iterate_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool hover);


    public delegate  System.IntPtr efl_ui_win_pointer_iterate_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool hover);
    public static Efl.Eo.FunctionWrapper<efl_ui_win_pointer_iterate_api_delegate> efl_ui_win_pointer_iterate_ptr = new Efl.Eo.FunctionWrapper<efl_ui_win_pointer_iterate_api_delegate>(_Module, "efl_ui_win_pointer_iterate");
    private static  System.IntPtr pointer_iterate(System.IntPtr obj, System.IntPtr pd,  bool hover)
   {
      Eina.Log.Debug("function efl_ui_win_pointer_iterate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Eina.Iterator<Efl.Input.Pointer> _ret_var = default(Eina.Iterator<Efl.Input.Pointer>);
         try {
            _ret_var = ((Win)wrapper).PointerIterate( hover);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var.Handle;
      } else {
         return efl_ui_win_pointer_iterate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hover);
      }
   }
   private static efl_ui_win_pointer_iterate_delegate efl_ui_win_pointer_iterate_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshalerOwn))] private delegate  Eina.Value efl_config_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshalerOwn))] public delegate  Eina.Value efl_config_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_config_get_api_delegate> efl_config_get_ptr = new Efl.Eo.FunctionWrapper<efl_config_get_api_delegate>(_Module, "efl_config_get");
    private static  Eina.Value config_get(System.IntPtr obj, System.IntPtr pd,   System.String name)
   {
      Eina.Log.Debug("function efl_config_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                     Eina.Value _ret_var = default( Eina.Value);
         try {
            _ret_var = ((Win)wrapper).GetConfig( name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_config_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name);
      }
   }
   private static efl_config_get_delegate efl_config_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_config_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value value);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_config_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value value);
    public static Efl.Eo.FunctionWrapper<efl_config_set_api_delegate> efl_config_set_ptr = new Efl.Eo.FunctionWrapper<efl_config_set_api_delegate>(_Module, "efl_config_set");
    private static bool config_set(System.IntPtr obj, System.IntPtr pd,   System.String name,   Eina.Value value)
   {
      Eina.Log.Debug("function efl_config_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).SetConfig( name,  value);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                              return _ret_var;
      } else {
         return efl_config_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name,  value);
      }
   }
   private static efl_config_set_delegate efl_config_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Entity efl_content_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Entity efl_content_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_content_get_api_delegate> efl_content_get_ptr = new Efl.Eo.FunctionWrapper<efl_content_get_api_delegate>(_Module, "efl_content_get");
    private static Efl.Gfx.Entity content_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_content_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Gfx.Entity _ret_var = default(Efl.Gfx.Entity);
         try {
            _ret_var = ((Win)wrapper).GetContent();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_content_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_content_get_delegate efl_content_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_content_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Entity content);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_content_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Entity content);
    public static Efl.Eo.FunctionWrapper<efl_content_set_api_delegate> efl_content_set_ptr = new Efl.Eo.FunctionWrapper<efl_content_set_api_delegate>(_Module, "efl_content_set");
    private static bool content_set(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.Entity content)
   {
      Eina.Log.Debug("function efl_content_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).SetContent( content);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_content_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  content);
      }
   }
   private static efl_content_set_delegate efl_content_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Entity efl_content_unset_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Entity efl_content_unset_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_content_unset_api_delegate> efl_content_unset_ptr = new Efl.Eo.FunctionWrapper<efl_content_unset_api_delegate>(_Module, "efl_content_unset");
    private static Efl.Gfx.Entity content_unset(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_content_unset was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Gfx.Entity _ret_var = default(Efl.Gfx.Entity);
         try {
            _ret_var = ((Win)wrapper).UnsetContent();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_content_unset_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_content_unset_delegate efl_content_unset_static_delegate;


    private delegate Eina.Size2D_StructInternal efl_screen_size_in_pixels_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Size2D_StructInternal efl_screen_size_in_pixels_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_screen_size_in_pixels_get_api_delegate> efl_screen_size_in_pixels_get_ptr = new Efl.Eo.FunctionWrapper<efl_screen_size_in_pixels_get_api_delegate>(_Module, "efl_screen_size_in_pixels_get");
    private static Eina.Size2D_StructInternal screen_size_in_pixels_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_screen_size_in_pixels_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Size2D _ret_var = default(Eina.Size2D);
         try {
            _ret_var = ((Win)wrapper).GetScreenSizeInPixels();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Size2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_screen_size_in_pixels_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_screen_size_in_pixels_get_delegate efl_screen_size_in_pixels_get_static_delegate;


    private delegate float efl_screen_scale_factor_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate float efl_screen_scale_factor_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_screen_scale_factor_get_api_delegate> efl_screen_scale_factor_get_ptr = new Efl.Eo.FunctionWrapper<efl_screen_scale_factor_get_api_delegate>(_Module, "efl_screen_scale_factor_get");
    private static float screen_scale_factor_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_screen_scale_factor_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  float _ret_var = default(float);
         try {
            _ret_var = ((Win)wrapper).GetScreenScaleFactor();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_screen_scale_factor_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_screen_scale_factor_get_delegate efl_screen_scale_factor_get_static_delegate;


    private delegate  int efl_screen_rotation_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  int efl_screen_rotation_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_screen_rotation_get_api_delegate> efl_screen_rotation_get_ptr = new Efl.Eo.FunctionWrapper<efl_screen_rotation_get_api_delegate>(_Module, "efl_screen_rotation_get");
    private static  int screen_rotation_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_screen_rotation_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   int _ret_var = default( int);
         try {
            _ret_var = ((Win)wrapper).GetScreenRotation();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_screen_rotation_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_screen_rotation_get_delegate efl_screen_rotation_get_static_delegate;


    private delegate  void efl_screen_dpi_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int xdpi,   out  int ydpi);


    public delegate  void efl_screen_dpi_get_api_delegate(System.IntPtr obj,   out  int xdpi,   out  int ydpi);
    public static Efl.Eo.FunctionWrapper<efl_screen_dpi_get_api_delegate> efl_screen_dpi_get_ptr = new Efl.Eo.FunctionWrapper<efl_screen_dpi_get_api_delegate>(_Module, "efl_screen_dpi_get");
    private static  void screen_dpi_get(System.IntPtr obj, System.IntPtr pd,  out  int xdpi,  out  int ydpi)
   {
      Eina.Log.Debug("function efl_screen_dpi_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           xdpi = default( int);      ydpi = default( int);                     
         try {
            ((Win)wrapper).GetScreenDpi( out xdpi,  out ydpi);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_screen_dpi_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out xdpi,  out ydpi);
      }
   }
   private static efl_screen_dpi_get_delegate efl_screen_dpi_get_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_text_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_text_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_text_get_api_delegate> efl_text_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_get_api_delegate>(_Module, "efl_text_get");
    private static  System.String text_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_text_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Win)wrapper).GetText();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_text_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_text_get_delegate efl_text_get_static_delegate;


    private delegate  void efl_text_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String text);


    public delegate  void efl_text_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String text);
    public static Efl.Eo.FunctionWrapper<efl_text_set_api_delegate> efl_text_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_set_api_delegate>(_Module, "efl_text_set");
    private static  void text_set(System.IntPtr obj, System.IntPtr pd,   System.String text)
   {
      Eina.Log.Debug("function efl_text_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetText( text);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_text_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  text);
      }
   }
   private static efl_text_set_delegate efl_text_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_canvas_scene_image_max_size_get_delegate(System.IntPtr obj, System.IntPtr pd,   out Eina.Size2D_StructInternal max);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_canvas_scene_image_max_size_get_api_delegate(System.IntPtr obj,   out Eina.Size2D_StructInternal max);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_image_max_size_get_api_delegate> efl_canvas_scene_image_max_size_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_image_max_size_get_api_delegate>(_Module, "efl_canvas_scene_image_max_size_get");
    private static bool image_max_size_get(System.IntPtr obj, System.IntPtr pd,  out Eina.Size2D_StructInternal max)
   {
      Eina.Log.Debug("function efl_canvas_scene_image_max_size_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                     Eina.Size2D _out_max = default(Eina.Size2D);
               bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetImageMaxSize( out _out_max);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      max = Eina.Size2D_StructConversion.ToInternal(_out_max);
            return _ret_var;
      } else {
         return efl_canvas_scene_image_max_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out max);
      }
   }
   private static efl_canvas_scene_image_max_size_get_delegate efl_canvas_scene_image_max_size_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_canvas_scene_group_objects_calculating_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_canvas_scene_group_objects_calculating_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_group_objects_calculating_get_api_delegate> efl_canvas_scene_group_objects_calculating_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_group_objects_calculating_get_api_delegate>(_Module, "efl_canvas_scene_group_objects_calculating_get");
    private static bool group_objects_calculating_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_canvas_scene_group_objects_calculating_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetGroupObjectsCalculating();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_canvas_scene_group_objects_calculating_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_canvas_scene_group_objects_calculating_get_delegate efl_canvas_scene_group_objects_calculating_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] private delegate Efl.Input.Device efl_canvas_scene_device_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] public delegate Efl.Input.Device efl_canvas_scene_device_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_device_get_api_delegate> efl_canvas_scene_device_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_device_get_api_delegate>(_Module, "efl_canvas_scene_device_get");
    private static Efl.Input.Device device_get(System.IntPtr obj, System.IntPtr pd,   System.String name)
   {
      Eina.Log.Debug("function efl_canvas_scene_device_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Input.Device _ret_var = default(Efl.Input.Device);
         try {
            _ret_var = ((Win)wrapper).GetDevice( name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_canvas_scene_device_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name);
      }
   }
   private static efl_canvas_scene_device_get_delegate efl_canvas_scene_device_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] private delegate Efl.Input.Device efl_canvas_scene_seat_get_delegate(System.IntPtr obj, System.IntPtr pd,    int id);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] public delegate Efl.Input.Device efl_canvas_scene_seat_get_api_delegate(System.IntPtr obj,    int id);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_seat_get_api_delegate> efl_canvas_scene_seat_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_seat_get_api_delegate>(_Module, "efl_canvas_scene_seat_get");
    private static Efl.Input.Device seat_get(System.IntPtr obj, System.IntPtr pd,   int id)
   {
      Eina.Log.Debug("function efl_canvas_scene_seat_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Input.Device _ret_var = default(Efl.Input.Device);
         try {
            _ret_var = ((Win)wrapper).GetSeat( id);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_canvas_scene_seat_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  id);
      }
   }
   private static efl_canvas_scene_seat_get_delegate efl_canvas_scene_seat_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] private delegate Efl.Input.Device efl_canvas_scene_seat_default_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))] public delegate Efl.Input.Device efl_canvas_scene_seat_default_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_seat_default_get_api_delegate> efl_canvas_scene_seat_default_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_seat_default_get_api_delegate>(_Module, "efl_canvas_scene_seat_default_get");
    private static Efl.Input.Device seat_default_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_canvas_scene_seat_default_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Input.Device _ret_var = default(Efl.Input.Device);
         try {
            _ret_var = ((Win)wrapper).GetSeatDefault();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_canvas_scene_seat_default_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_canvas_scene_seat_default_get_delegate efl_canvas_scene_seat_default_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_canvas_scene_pointer_position_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat,   out Eina.Position2D_StructInternal pos);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_canvas_scene_pointer_position_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat,   out Eina.Position2D_StructInternal pos);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_pointer_position_get_api_delegate> efl_canvas_scene_pointer_position_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_pointer_position_get_api_delegate>(_Module, "efl_canvas_scene_pointer_position_get");
    private static bool pointer_position_get(System.IntPtr obj, System.IntPtr pd,  Efl.Input.Device seat,  out Eina.Position2D_StructInternal pos)
   {
      Eina.Log.Debug("function efl_canvas_scene_pointer_position_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                 Eina.Position2D _out_pos = default(Eina.Position2D);
                     bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetPointerPosition( seat,  out _out_pos);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            pos = Eina.Position2D_StructConversion.ToInternal(_out_pos);
                  return _ret_var;
      } else {
         return efl_canvas_scene_pointer_position_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  seat,  out pos);
      }
   }
   private static efl_canvas_scene_pointer_position_get_delegate efl_canvas_scene_pointer_position_get_static_delegate;


    private delegate  void efl_canvas_scene_group_objects_calculate_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_canvas_scene_group_objects_calculate_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_group_objects_calculate_api_delegate> efl_canvas_scene_group_objects_calculate_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_group_objects_calculate_api_delegate>(_Module, "efl_canvas_scene_group_objects_calculate");
    private static  void group_objects_calculate(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_canvas_scene_group_objects_calculate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).CalculateGroupObjects();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_canvas_scene_group_objects_calculate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_canvas_scene_group_objects_calculate_delegate efl_canvas_scene_group_objects_calculate_static_delegate;


    private delegate  System.IntPtr efl_canvas_scene_objects_at_xy_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Position2D_StructInternal pos,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);


    public delegate  System.IntPtr efl_canvas_scene_objects_at_xy_get_api_delegate(System.IntPtr obj,   Eina.Position2D_StructInternal pos,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_objects_at_xy_get_api_delegate> efl_canvas_scene_objects_at_xy_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_objects_at_xy_get_api_delegate>(_Module, "efl_canvas_scene_objects_at_xy_get");
    private static  System.IntPtr objects_at_xy_get(System.IntPtr obj, System.IntPtr pd,  Eina.Position2D_StructInternal pos,  bool include_pass_events_objects,  bool include_hidden_objects)
   {
      Eina.Log.Debug("function efl_canvas_scene_objects_at_xy_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_pos = Eina.Position2D_StructConversion.ToManaged(pos);
                                                         Eina.Iterator<Efl.Gfx.Entity> _ret_var = default(Eina.Iterator<Efl.Gfx.Entity>);
         try {
            _ret_var = ((Win)wrapper).GetObjectsAtXy( _in_pos,  include_pass_events_objects,  include_hidden_objects);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          _ret_var.Own = false; return _ret_var.Handle;
      } else {
         return efl_canvas_scene_objects_at_xy_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pos,  include_pass_events_objects,  include_hidden_objects);
      }
   }
   private static efl_canvas_scene_objects_at_xy_get_delegate efl_canvas_scene_objects_at_xy_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Entity efl_canvas_scene_object_top_at_xy_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Position2D_StructInternal pos,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Entity efl_canvas_scene_object_top_at_xy_get_api_delegate(System.IntPtr obj,   Eina.Position2D_StructInternal pos,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_object_top_at_xy_get_api_delegate> efl_canvas_scene_object_top_at_xy_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_object_top_at_xy_get_api_delegate>(_Module, "efl_canvas_scene_object_top_at_xy_get");
    private static Efl.Gfx.Entity object_top_at_xy_get(System.IntPtr obj, System.IntPtr pd,  Eina.Position2D_StructInternal pos,  bool include_pass_events_objects,  bool include_hidden_objects)
   {
      Eina.Log.Debug("function efl_canvas_scene_object_top_at_xy_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_pos = Eina.Position2D_StructConversion.ToManaged(pos);
                                                         Efl.Gfx.Entity _ret_var = default(Efl.Gfx.Entity);
         try {
            _ret_var = ((Win)wrapper).GetObjectTopAtXy( _in_pos,  include_pass_events_objects,  include_hidden_objects);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_canvas_scene_object_top_at_xy_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pos,  include_pass_events_objects,  include_hidden_objects);
      }
   }
   private static efl_canvas_scene_object_top_at_xy_get_delegate efl_canvas_scene_object_top_at_xy_get_static_delegate;


    private delegate  System.IntPtr efl_canvas_scene_objects_in_rectangle_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect_StructInternal rect,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);


    public delegate  System.IntPtr efl_canvas_scene_objects_in_rectangle_get_api_delegate(System.IntPtr obj,   Eina.Rect_StructInternal rect,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_objects_in_rectangle_get_api_delegate> efl_canvas_scene_objects_in_rectangle_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_objects_in_rectangle_get_api_delegate>(_Module, "efl_canvas_scene_objects_in_rectangle_get");
    private static  System.IntPtr objects_in_rectangle_get(System.IntPtr obj, System.IntPtr pd,  Eina.Rect_StructInternal rect,  bool include_pass_events_objects,  bool include_hidden_objects)
   {
      Eina.Log.Debug("function efl_canvas_scene_objects_in_rectangle_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_rect = Eina.Rect_StructConversion.ToManaged(rect);
                                                         Eina.Iterator<Efl.Gfx.Entity> _ret_var = default(Eina.Iterator<Efl.Gfx.Entity>);
         try {
            _ret_var = ((Win)wrapper).GetObjectsInRectangle( _in_rect,  include_pass_events_objects,  include_hidden_objects);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          _ret_var.Own = false; return _ret_var.Handle;
      } else {
         return efl_canvas_scene_objects_in_rectangle_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  rect,  include_pass_events_objects,  include_hidden_objects);
      }
   }
   private static efl_canvas_scene_objects_in_rectangle_get_delegate efl_canvas_scene_objects_in_rectangle_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Entity efl_canvas_scene_object_top_in_rectangle_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect_StructInternal rect,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.EntityConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Entity efl_canvas_scene_object_top_in_rectangle_get_api_delegate(System.IntPtr obj,   Eina.Rect_StructInternal rect,  [MarshalAs(UnmanagedType.U1)]  bool include_pass_events_objects,  [MarshalAs(UnmanagedType.U1)]  bool include_hidden_objects);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_object_top_in_rectangle_get_api_delegate> efl_canvas_scene_object_top_in_rectangle_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_object_top_in_rectangle_get_api_delegate>(_Module, "efl_canvas_scene_object_top_in_rectangle_get");
    private static Efl.Gfx.Entity object_top_in_rectangle_get(System.IntPtr obj, System.IntPtr pd,  Eina.Rect_StructInternal rect,  bool include_pass_events_objects,  bool include_hidden_objects)
   {
      Eina.Log.Debug("function efl_canvas_scene_object_top_in_rectangle_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_rect = Eina.Rect_StructConversion.ToManaged(rect);
                                                         Efl.Gfx.Entity _ret_var = default(Efl.Gfx.Entity);
         try {
            _ret_var = ((Win)wrapper).GetObjectTopInRectangle( _in_rect,  include_pass_events_objects,  include_hidden_objects);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_canvas_scene_object_top_in_rectangle_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  rect,  include_pass_events_objects,  include_hidden_objects);
      }
   }
   private static efl_canvas_scene_object_top_in_rectangle_get_delegate efl_canvas_scene_object_top_in_rectangle_get_static_delegate;


    private delegate  System.IntPtr efl_canvas_scene_seats_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  System.IntPtr efl_canvas_scene_seats_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_canvas_scene_seats_api_delegate> efl_canvas_scene_seats_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_scene_seats_api_delegate>(_Module, "efl_canvas_scene_seats");
    private static  System.IntPtr seats(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_canvas_scene_seats was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Iterator<Efl.Input.Device> _ret_var = default(Eina.Iterator<Efl.Input.Device>);
         try {
            _ret_var = ((Win)wrapper).Seats();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      _ret_var.Own = false; return _ret_var.Handle;
      } else {
         return efl_canvas_scene_seats_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_canvas_scene_seats_delegate efl_canvas_scene_seats_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_input_modifier_enabled_get_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Input.Modifier mod, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_input_modifier_enabled_get_api_delegate(System.IntPtr obj,   Efl.Input.Modifier mod, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat);
    public static Efl.Eo.FunctionWrapper<efl_input_modifier_enabled_get_api_delegate> efl_input_modifier_enabled_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_modifier_enabled_get_api_delegate>(_Module, "efl_input_modifier_enabled_get");
    private static bool modifier_enabled_get(System.IntPtr obj, System.IntPtr pd,  Efl.Input.Modifier mod,  Efl.Input.Device seat)
   {
      Eina.Log.Debug("function efl_input_modifier_enabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetModifierEnabled( mod,  seat);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                              return _ret_var;
      } else {
         return efl_input_modifier_enabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  mod,  seat);
      }
   }
   private static efl_input_modifier_enabled_get_delegate efl_input_modifier_enabled_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_input_lock_enabled_get_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Input.Lock kw_lock, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_input_lock_enabled_get_api_delegate(System.IntPtr obj,   Efl.Input.Lock kw_lock, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Input.Device, Efl.Eo.NonOwnTag>))]  Efl.Input.Device seat);
    public static Efl.Eo.FunctionWrapper<efl_input_lock_enabled_get_api_delegate> efl_input_lock_enabled_get_ptr = new Efl.Eo.FunctionWrapper<efl_input_lock_enabled_get_api_delegate>(_Module, "efl_input_lock_enabled_get");
    private static bool lock_enabled_get(System.IntPtr obj, System.IntPtr pd,  Efl.Input.Lock kw_lock,  Efl.Input.Device seat)
   {
      Eina.Log.Debug("function efl_input_lock_enabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).GetLockEnabled( kw_lock,  seat);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                              return _ret_var;
      } else {
         return efl_input_lock_enabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  kw_lock,  seat);
      }
   }
   private static efl_input_lock_enabled_get_delegate efl_input_lock_enabled_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Manager efl_ui_widget_focus_manager_create_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Manager efl_ui_widget_focus_manager_create_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_widget_focus_manager_create_api_delegate> efl_ui_widget_focus_manager_create_ptr = new Efl.Eo.FunctionWrapper<efl_ui_widget_focus_manager_create_api_delegate>(_Module, "efl_ui_widget_focus_manager_create");
    private static Efl.Ui.Focus.Manager focus_manager_create(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_widget_focus_manager_create was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Manager _ret_var = default(Efl.Ui.Focus.Manager);
         try {
            _ret_var = ((Win)wrapper).FocusManagerCreate( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_widget_focus_manager_create_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_widget_focus_manager_create_delegate efl_ui_widget_focus_manager_create_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_focus_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_focus_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate> efl_ui_focus_manager_focus_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate>(_Module, "efl_ui_focus_manager_focus_get");
    private static Efl.Ui.Focus.Object manager_focus_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_focus_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((Win)wrapper).GetManagerFocus();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_focus_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_focus_get_delegate efl_ui_focus_manager_focus_get_static_delegate;


    private delegate  void efl_ui_focus_manager_focus_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object focus);


    public delegate  void efl_ui_focus_manager_focus_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object focus);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate> efl_ui_focus_manager_focus_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate>(_Module, "efl_ui_focus_manager_focus_set");
    private static  void manager_focus_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object focus)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_focus_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetManagerFocus( focus);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_focus_manager_focus_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  focus);
      }
   }
   private static efl_ui_focus_manager_focus_set_delegate efl_ui_focus_manager_focus_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Manager efl_ui_focus_manager_redirect_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Manager efl_ui_focus_manager_redirect_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate> efl_ui_focus_manager_redirect_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate>(_Module, "efl_ui_focus_manager_redirect_get");
    private static Efl.Ui.Focus.Manager redirect_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_redirect_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Manager _ret_var = default(Efl.Ui.Focus.Manager);
         try {
            _ret_var = ((Win)wrapper).GetRedirect();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_redirect_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_redirect_get_delegate efl_ui_focus_manager_redirect_get_static_delegate;


    private delegate  void efl_ui_focus_manager_redirect_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Manager redirect);


    public delegate  void efl_ui_focus_manager_redirect_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Manager redirect);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate> efl_ui_focus_manager_redirect_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate>(_Module, "efl_ui_focus_manager_redirect_set");
    private static  void redirect_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Manager redirect)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_redirect_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Win)wrapper).SetRedirect( redirect);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_focus_manager_redirect_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  redirect);
      }
   }
   private static efl_ui_focus_manager_redirect_set_delegate efl_ui_focus_manager_redirect_set_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_border_elements_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  System.IntPtr efl_ui_focus_manager_border_elements_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate> efl_ui_focus_manager_border_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_border_elements_get");
    private static  System.IntPtr border_elements_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_border_elements_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Iterator<Efl.Ui.Focus.Object> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.Object>);
         try {
            _ret_var = ((Win)wrapper).GetBorderElements();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var.Handle;
      } else {
         return efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_border_elements_get_delegate efl_ui_focus_manager_border_elements_get_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_viewport_elements_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect_StructInternal viewport);


    public delegate  System.IntPtr efl_ui_focus_manager_viewport_elements_get_api_delegate(System.IntPtr obj,   Eina.Rect_StructInternal viewport);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate> efl_ui_focus_manager_viewport_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_viewport_elements_get");
    private static  System.IntPtr viewport_elements_get(System.IntPtr obj, System.IntPtr pd,  Eina.Rect_StructInternal viewport)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_viewport_elements_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_viewport = Eina.Rect_StructConversion.ToManaged(viewport);
                     Eina.Iterator<Efl.Ui.Focus.Object> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.Object>);
         try {
            _ret_var = ((Win)wrapper).GetViewportElements( _in_viewport);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var.Handle;
      } else {
         return efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  viewport);
      }
   }
   private static efl_ui_focus_manager_viewport_elements_get_delegate efl_ui_focus_manager_viewport_elements_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_root_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_root_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate> efl_ui_focus_manager_root_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate>(_Module, "efl_ui_focus_manager_root_get");
    private static Efl.Ui.Focus.Object root_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_root_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((Win)wrapper).GetRoot();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_root_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_root_get_delegate efl_ui_focus_manager_root_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_focus_manager_root_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_focus_manager_root_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate> efl_ui_focus_manager_root_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate>(_Module, "efl_ui_focus_manager_root_set");
    private static bool root_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_root_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((Win)wrapper).SetRoot( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_root_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_focus_manager_root_set_delegate efl_ui_focus_manager_root_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate> efl_ui_focus_manager_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate>(_Module, "efl_ui_focus_manager_move");
    private static Efl.Ui.Focus.Object move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_move was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((Win)wrapper).Move( direction);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction);
      }
   }
   private static efl_ui_focus_manager_move_delegate efl_ui_focus_manager_move_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child,  [MarshalAs(UnmanagedType.U1)]  bool logical);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child,  [MarshalAs(UnmanagedType.U1)]  bool logical);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate> efl_ui_focus_manager_request_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate>(_Module, "efl_ui_focus_manager_request_move");
    private static Efl.Ui.Focus.Object request_move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object child,  bool logical)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_request_move was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((Win)wrapper).MoveRequest( direction,  child,  logical);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_ui_focus_manager_request_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  child,  logical);
      }
   }
   private static efl_ui_focus_manager_request_move_delegate efl_ui_focus_manager_request_move_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_subchild_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_subchild_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate> efl_ui_focus_manager_request_subchild_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate>(_Module, "efl_ui_focus_manager_request_subchild");
    private static Efl.Ui.Focus.Object request_subchild(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_request_subchild was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((Win)wrapper).RequestSubchild( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_request_subchild_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_focus_manager_request_subchild_delegate efl_ui_focus_manager_request_subchild_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_fetch_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child);


    public delegate  System.IntPtr efl_ui_focus_manager_fetch_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate> efl_ui_focus_manager_fetch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate>(_Module, "efl_ui_focus_manager_fetch");
    private static  System.IntPtr fetch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object child)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_fetch was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Relations _ret_var = default(Efl.Ui.Focus.Relations);
         try {
            _ret_var = ((Win)wrapper).Fetch( child);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return Eina.PrimitiveConversion.ManagedToPointerAlloc(_ret_var);
      } else {
         return efl_ui_focus_manager_fetch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  child);
      }
   }
   private static efl_ui_focus_manager_fetch_delegate efl_ui_focus_manager_fetch_static_delegate;


    private delegate Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal efl_ui_focus_manager_logical_end_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal efl_ui_focus_manager_logical_end_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate> efl_ui_focus_manager_logical_end_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate>(_Module, "efl_ui_focus_manager_logical_end");
    private static Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal logical_end(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_logical_end was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.ManagerLogicalEndDetail _ret_var = default(Efl.Ui.Focus.ManagerLogicalEndDetail);
         try {
            _ret_var = ((Win)wrapper).LogicalEnd();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Efl.Ui.Focus.ManagerLogicalEndDetail_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_ui_focus_manager_logical_end_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_logical_end_delegate efl_ui_focus_manager_logical_end_static_delegate;


    private delegate  void efl_ui_focus_manager_reset_history_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_reset_history_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate> efl_ui_focus_manager_reset_history_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate>(_Module, "efl_ui_focus_manager_reset_history");
    private static  void reset_history(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_reset_history was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).ResetHistory();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_reset_history_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_reset_history_delegate efl_ui_focus_manager_reset_history_static_delegate;


    private delegate  void efl_ui_focus_manager_pop_history_stack_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_pop_history_stack_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate> efl_ui_focus_manager_pop_history_stack_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate>(_Module, "efl_ui_focus_manager_pop_history_stack");
    private static  void pop_history_stack(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_pop_history_stack was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).PopHistoryStack();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_pop_history_stack_delegate efl_ui_focus_manager_pop_history_stack_static_delegate;


    private delegate  void efl_ui_focus_manager_setup_on_first_touch_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object entry);


    public delegate  void efl_ui_focus_manager_setup_on_first_touch_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object entry);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate> efl_ui_focus_manager_setup_on_first_touch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate>(_Module, "efl_ui_focus_manager_setup_on_first_touch");
    private static  void setup_on_first_touch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object entry)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_setup_on_first_touch was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Win)wrapper).SetupOnFirstTouch( direction,  entry);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  entry);
      }
   }
   private static efl_ui_focus_manager_setup_on_first_touch_delegate efl_ui_focus_manager_setup_on_first_touch_static_delegate;


    private delegate  void efl_ui_focus_manager_dirty_logic_freeze_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_dirty_logic_freeze_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate> efl_ui_focus_manager_dirty_logic_freeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_freeze");
    private static  void dirty_logic_freeze(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_freeze was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).FreezeDirtyLogic();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_dirty_logic_freeze_delegate efl_ui_focus_manager_dirty_logic_freeze_static_delegate;


    private delegate  void efl_ui_focus_manager_dirty_logic_unfreeze_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate> efl_ui_focus_manager_dirty_logic_unfreeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_unfreeze");
    private static  void dirty_logic_unfreeze(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_unfreeze was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Win)wrapper).DirtyLogicUnfreeze();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_dirty_logic_unfreeze_delegate efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate;
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Defines the types of window that can be created
/// These are hints set on a window so that a running Window Manager knows how the window should be handled and/or what kind of decorations it should have.
/// 
/// Currently, only the X11 backed engines use them.</summary>
public enum WinType
{
/// <summary>Default, unknown, type</summary>
Unknown = 0,
/// <summary>A normal window. Indicates a normal, top-level window. Almost every window will be created with this type.</summary>
Basic = 1,
/// <summary>Used for simple dialog windows.</summary>
DialogBasic = 2,
/// <summary>For special desktop windows, like a background window holding desktop icons.</summary>
Desktop = 3,
/// <summary>The window is used as a dock or panel. Usually would be kept on top of any other window by the Window Manager.</summary>
Dock = 4,
/// <summary>The window is used to hold a floating toolbar, or similar.</summary>
Toolbar = 5,
/// <summary>Similar to @.toolbar.</summary>
Menu = 6,
/// <summary>A persistent utility window, like a toolbox or palette.</summary>
Utility = 7,
/// <summary>Splash window for a starting up application.</summary>
Splash = 8,
/// <summary>The window is a dropdown menu, as when an  entry in a menubar is clicked. This hint exists for completion only, as the EFL way of implementing a menu would not normally use a separate window for its contents.</summary>
DropdownMenu = 9,
/// <summary>Like @.dropdown_menu, but for the menu triggered by right-clicking an object.</summary>
PopupMenu = 10,
/// <summary>The window is a tooltip. A short piece of explanatory text that typically appear after the mouse cursor hovers over an object for a while. Typically not very commonly used in the EFL.</summary>
Tooltip = 11,
/// <summary>A notification window, like a warning about battery life or a new E-Mail received.</summary>
Notification = 12,
/// <summary>A window holding the contents of a combo box. Not usually used in the EFL.</summary>
Combo = 13,
/// <summary>Used for naviframe style replacement with a back button instead of a close button.
/// 1.19</summary>
NaviframeBasic = 17,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>The different layouts that can be requested for the virtual keyboard.
/// When the application window is being managed by Illume it may request any of the following layouts for the virtual keyboard.</summary>
public enum WinKeyboardMode
{
/// <summary>Unknown keyboard state</summary>
Unknown = 0,
/// <summary>Request to deactivate the keyboard</summary>
Off = 1,
/// <summary>Enable keyboard with default layout</summary>
On = 2,
/// <summary>Alpha (a-z) keyboard layout</summary>
Alpha = 3,
/// <summary>Numeric keyboard layout</summary>
Numeric = 4,
/// <summary>PIN keyboard layout</summary>
Pin = 5,
/// <summary>Phone keyboard layout</summary>
PhoneNumber = 6,
/// <summary>Hexadecimal numeric keyboard layout</summary>
Hex = 7,
/// <summary>Full (QWERTY) keyboard layout</summary>
Terminal = 8,
/// <summary>Password keyboard layout</summary>
Password = 9,
/// <summary>IP keyboard layout</summary>
Ip = 10,
/// <summary>Host keyboard layout</summary>
Host = 11,
/// <summary>File keyboard layout</summary>
File = 12,
/// <summary>URL keyboard layout</summary>
Url = 13,
/// <summary>Keypad layout</summary>
Keypad = 14,
/// <summary>J2ME keyboard layout</summary>
J2me = 15,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Defines the type indicator that can be shown</summary>
public enum WinIndicatorMode
{
/// <summary>Request to deactivate the indicator</summary>
Off = 0,
/// <summary>The indicator icon is opaque, as is the indicator background. The content of window is located at the end of the indicator. The area of indicator and window content are not overlapped</summary>
BgOpaque = 1,
/// <summary>Be translucent the indicator</summary>
Translucent = 2,
/// <summary>Transparentizes the indicator</summary>
Transparent = 3,
/// <summary>The icon of indicator is opaque, but the background is transparent. The content of window is located under the indicator in Z-order. The area of indicator and window content are overlapped</summary>
BgTransparent = 4,
/// <summary>The indicator is hidden so user can see only the content of window such as in video mode. If user flicks the upper side of window, the indicator is shown temporarily.</summary>
Hidden = 5,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Define the keygrab modes of window. A window may send commands to the Keyrouter according this mode, and perform different actions.</summary>
public enum WinKeygrabMode
{
/// <summary>Unknown keygrab mode</summary>
Unknown = 0,
/// <summary>Get the grabbed-key together with the other client windows</summary>
Shared = 256,
/// <summary>Get the grabbed-key only when window is top of the stack</summary>
Topmost = 512,
/// <summary>Get the grabbed-key exclusively regardless of window&apos;s position</summary>
Exclusive = 1024,
/// <summary>Get the grabbed-key exclusively regardless of window&apos;s position. This is overrided by grabs from the other client window</summary>
OverrideExclusive = 2048,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Defines the mode of a modal window</summary>
public enum WinModalMode
{
/// <summary>The window is not modal window.</summary>
None = 0,
/// <summary>The window is modal window.</summary>
Modal = 1,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Defines the mode of a urgent window.</summary>
public enum WinUrgentMode
{
/// <summary>The window is not a urgent window.</summary>
None = 0,
/// <summary>The window is a urgent window.</summary>
Urgent = 1,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>Define the move or resize mode of window.
/// The user can request the display server to start moving or resizing the window by combining these modes. However only limited combinations are allowed.
/// 
/// Currently, only the following 9 combinations are permitted. More combinations may be added in future: 1. move, 2. top, 3. bottom, 4. left, 5. right, 6. top | left, 7. top | right, 8. bottom | left, 9. bottom | right.
/// 1.19</summary>
public enum WinMoveResizeMode
{
/// <summary>Start moving window</summary>
Move = 1,
/// <summary>Start resizing window to the top</summary>
Top = 2,
/// <summary>Start resizing window to the bottom</summary>
Bottom = 4,
/// <summary>Start resizing window to the left</summary>
Left = 8,
/// <summary>Start resizing window to the right</summary>
Right = 16,
}
} } 
namespace Efl { namespace Ui { 
/// <summary>List of window effect.
/// These list indicates types of window effect. When the effect started or done, the Elm_Win is notified with type information of window effect.</summary>
public enum WinEffectType
{
/// <summary></summary>
Unknown = 0,
/// <summary></summary>
Show = 1,
/// <summary></summary>
Hide = 2,
/// <summary></summary>
Restack = 3,
}
} } 
namespace Efl { namespace Ui { 
/// <summary></summary>
public enum WinConformantProperty
{
/// <summary></summary>
Default = 0,
/// <summary></summary>
IndicatorState = 1,
/// <summary></summary>
IndicatorGeometry = 2,
/// <summary></summary>
KeyboardState = 4,
/// <summary></summary>
KeyboardGeometry = 8,
/// <summary></summary>
ClipboardState = 16,
/// <summary></summary>
ClipboardGeometry = 32,
}
} } 
