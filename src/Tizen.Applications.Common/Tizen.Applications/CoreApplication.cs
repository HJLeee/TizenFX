/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

using Tizen.Applications.CoreBackend;

namespace Tizen.Applications
{
    /// <summary>
    /// This class represents an application controlled lifecycles by the backend system.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class CoreApplication : Application
    {
        private readonly ICoreBackend _backend;
        private bool _disposedValue = false;

        /// <summary>
        /// Initializes the CoreApplication class.
        /// </summary>
        /// <param name="backend">The backend instance implementing ICoreBacked interface.</param>
        /// <since_tizen> 3 </since_tizen>
        public CoreApplication(ICoreBackend backend)
        {
            _backend = backend;
        }

        /// <summary>
        /// Occurs when the application is launched.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler Created;

        /// <summary>
        /// Occurs when the application is about to shutdown.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler Terminated;

        /// <summary>
        /// Occurs whenever the application receives the appcontrol message.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<AppControlReceivedEventArgs> AppControlReceived;

        /// <summary>
        /// Occurs when the system memory is low.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<LowMemoryEventArgs> LowMemory;

        /// <summary>
        /// Occurs when the system battery is low.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<LowBatteryEventArgs> LowBattery;

        /// <summary>
        /// Occurs when the system language is chagned.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<LocaleChangedEventArgs> LocaleChanged;

        /// <summary>
        /// Occurs when the region format is changed.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<RegionFormatChangedEventArgs> RegionFormatChanged;

        /// <summary>
        /// Occurs when the device orientation is changed.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<DeviceOrientationEventArgs> DeviceOrientationChanged;

        /// <summary>
        /// The backend instance.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected ICoreBackend Backend { get { return _backend; } }

        /// <summary>
        /// Runs the application's main loop.
        /// </summary>
        /// <param name="args">Arguments from commandline.</param>
        /// <since_tizen> 3 </since_tizen>
        public override void Run(string[] args)
        {
            base.Run(args);

            _backend.AddEventHandler(EventType.Created, OnCreate);
            _backend.AddEventHandler(EventType.Terminated, OnTerminate);
            _backend.AddEventHandler<AppControlReceivedEventArgs>(EventType.AppControlReceived, OnAppControlReceived);
            _backend.AddEventHandler<LowMemoryEventArgs>(EventType.LowMemory, OnLowMemory);
            _backend.AddEventHandler<LowBatteryEventArgs>(EventType.LowBattery, OnLowBattery);
            _backend.AddEventHandler<LocaleChangedEventArgs>(EventType.LocaleChanged, OnLocaleChanged);
            _backend.AddEventHandler<RegionFormatChangedEventArgs>(EventType.RegionFormatChanged, OnRegionFormatChanged);
            _backend.AddEventHandler<DeviceOrientationEventArgs>(EventType.DeviceOrientationChanged, OnDeviceOrientationChanged);

            string[] argsClone = null;

            if (args == null)
            {
                argsClone = new string[1];
            }
            else
            {
                argsClone = new string[args.Length + 1];
                args.CopyTo(argsClone, 1);
            }
            argsClone[0] = string.Empty;
            _backend.Run(argsClone);
        }

        /// <summary>
        /// Exits the main loop of the application.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public override void Exit()
        {
            _backend.Exit();
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the application is launched.
        /// If base.OnCreated() is not called, the event 'Created' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnCreate()
        {
            Created?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the application is terminated.
        /// If base.OnTerminate() is not called, the event 'Terminated' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnTerminate()
        {
            Terminated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the application receives the appcontrol message.
        /// If base.OnAppControlReceived() is not called, the event 'AppControlReceived' will not be emitted.
        /// </summary>
        /// <param name="e"></param>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnAppControlReceived(AppControlReceivedEventArgs e)
        {
            AppControlReceived?.Invoke(this, e);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the system memory is low.
        /// If base.OnLowMemory() is not called, the event 'LowMemory' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnLowMemory(LowMemoryEventArgs e)
        {
            LowMemory?.Invoke(this, e);
            System.GC.Collect();
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the system battery is low.
        /// If base.OnLowBattery() is not called, the event 'LowBattery' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnLowBattery(LowBatteryEventArgs e)
        {
            LowBattery?.Invoke(this, e);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the system language is changed.
        /// If base.OnLocaleChanged() is not called, the event 'LocaleChanged' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnLocaleChanged(LocaleChangedEventArgs e)
        {
            LocaleChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the region format is changed.
        /// If base.OnRegionFormatChanged() is not called, the event 'RegionFormatChanged' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnRegionFormatChanged(RegionFormatChangedEventArgs e)
        {
            RegionFormatChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Overrides this method if want to handle behavior when the device orientation is changed.
        /// If base.OnRegionFormatChanged() is not called, the event 'RegionFormatChanged' will not be emitted.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected virtual void OnDeviceOrientationChanged(DeviceOrientationEventArgs e)
        {
            DeviceOrientationChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Releases any unmanaged resources used by this object. Can also dispose any other disposable objects.
        /// </summary>
        /// <param name="disposing">If true, disposes any disposable objects. If false, does not dispose disposable objects.</param>
        /// <since_tizen> 3 </since_tizen>
        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _backend.Dispose();
                }

                _disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
}
