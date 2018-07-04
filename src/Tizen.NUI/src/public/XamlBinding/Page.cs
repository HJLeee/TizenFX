/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tizen.NUI.Binding.Internals;
using Tizen.NUI.Binding;

namespace Tizen.NUI
{
    /// <summary>
    /// A BaseHandle that occupies the entire screen.
    /// </summary>
    // [RenderWith(typeof(_PageRenderer))]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class Page : /*VisualElement*/BaseHandle, ILayout, IPageController, IElementConfiguration<Page>, IPaddingElement
    {
        /// <summary>
        /// For internal use.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public const string BusySetSignalName = "NUI.BusySet";

        /// <summary>
        /// For internal use.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public const string AlertSignalName = "NUI.SendAlert";

        /// <summary>
        /// For internal use.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public const string ActionSheetSignalName = "NUI.ShowActionSheet";

        internal static readonly BindableProperty IgnoresContainerAreaProperty = BindableProperty.Create("IgnoresContainerArea", typeof(bool), typeof(Page), false);

        /// <summary>
        /// Identifies the BackgroundImage property.
        /// </summary>
        internal static readonly BindableProperty BackgroundImageProperty = BindableProperty.Create("BackgroundImage", typeof(string), typeof(Page), default(string));

        /// <summary>
        /// Identifies the IsBusy property.
        /// </summary>
        internal static readonly BindableProperty IsBusyProperty = BindableProperty.Create("IsBusy", typeof(bool), typeof(Page), false, propertyChanged: (bo, o, n) => ((Page)bo).OnPageBusyChanged());

        /// <summary>
        /// Identifies the Padding property.
        /// </summary>
        internal static readonly BindableProperty PaddingProperty = PaddingElement.PaddingProperty;

        /// <summary>
        /// Identifies the Title property.
        /// </summary>
        internal static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(Page), null);

        /// <summary>
        /// Identifies the Icon property.
        /// </summary>
        internal static readonly BindableProperty IconProperty = BindableProperty.Create("Icon", typeof(FileImageSource), typeof(Page), default(FileImageSource));

        readonly Lazy<PlatformConfigurationRegistry<Page>> _platformConfigurationRegistry;

        bool _allocatedFlag;
        Rectangle _containerArea;

        bool _containerAreaSet;

        bool _hasAppeared;

        ReadOnlyCollection<Element> _logicalChildren;

        /// <summary>
        /// Creates a new Page element with default values.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Page()
        {
            var toolbarItems = new ObservableCollection<ToolbarItem>();
            toolbarItems.CollectionChanged += OnToolbarItemsCollectionChanged;
            // ToolbarItems = toolbarItems;
            InternalChildren.CollectionChanged += InternalChildrenOnCollectionChanged;
            _platformConfigurationRegistry = new Lazy<PlatformConfigurationRegistry<Page>>(() => new PlatformConfigurationRegistry<Page>(this));
        }

        /// <summary>
        /// Identifies the image used as a background for the Page.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string BackgroundImage
        {
            get { return (string)GetValue(BackgroundImageProperty); }
            set { SetValue(BackgroundImageProperty, value); }
        }

        internal FileImageSource Icon
        {
            get { return (FileImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// Marks the Page as busy. This will cause the platform specific global activity indicator to show a busy state.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        /// <summary>
        /// The space between the content of the Page and it's border.
        /// </summary>
        internal Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingElement.PaddingProperty); }
            set { SetValue(PaddingElement.PaddingProperty, value); }
        }

        Thickness IPaddingElement.PaddingDefaultValueCreator()
        {
            return default(Thickness);
        }

        void IPaddingElement.OnPaddingPropertyChanged(Thickness oldValue, Thickness newValue)
        {
            UpdateChildrenLayout();
        }

        /// <summary>
        /// The Page's title.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        internal IList<ToolbarItem> ToolbarItems { get;/* internal set;*/ }

        /// <summary>
        /// For internal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Rectangle ContainerArea
        {
            get { return _containerArea; }
            set
            {
                if (_containerArea == value)
                    return;
                _containerAreaSet = true;
                _containerArea = value;
                ForceLayout();
            }
        }

        /// <summary>
        /// For internal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IgnoresContainerArea
        {
            get { return (bool)GetValue(IgnoresContainerAreaProperty); }
            set { SetValue(IgnoresContainerAreaProperty, value); }
        }

        /// <summary>
        /// For internal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ObservableCollection<Element> InternalChildren { get; } = new ObservableCollection<Element>();

        internal override ReadOnlyCollection<Element> LogicalChildrenInternal => 
            _logicalChildren ?? (_logicalChildren = new ReadOnlyCollection<Element>(InternalChildren));

        /// <summary>
        /// Raised when the layout of the Page has changed.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler LayoutChanged;

        /// <summary>
        /// ndicates that the Page is about to appear.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler Appearing;

        /// <summary>
        /// Indicates that the Page is about to cease displaying.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public event EventHandler Disappearing;

        /// <summary>
        /// Displays a native platform action sheet, allowing the application user to choose from several buttons.
        /// </summary>
        /// <param name="title">Title of the displayed action sheet. Must not be null.</param>
        /// <param name="cancel">Text to be displayed in the 'Cancel' button. Can be null to hide the cancel action.</param>
        /// <param name="destruction">Text to be displayed in the 'Destruct' button. Can be null to hide the destructive option.</param>
        /// <param name="buttons">Text labels for additional buttons. Must not be null.</param>
        /// <returns>An awaitable Task that displays an action sheet and returns the Text of the button pressed by the user.</returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Task<string> DisplayActionSheet(string title, string cancel, string destruction, params string[] buttons)
        {
            var args = new ActionSheetArguments(title, cancel, destruction, buttons);
            MessagingCenter.Send(this, ActionSheetSignalName, args);
            return args.Result.Task;
        }

        /// <summary>
        /// Presents an alert dialog to the application user with a single cancel button.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The body text of the alert dialog.</param>
        /// <param name="cancel">Text to be displayed on the 'Cancel' button.</param>
        /// <returns></returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Task DisplayAlert(string title, string message, string cancel)
        {
            return DisplayAlert(title, message, null, cancel);
        }

        /// <summary>
        /// resents an alert dialog to the application user with an accept and a cancel button.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The body text of the alert dialog.</param>
        /// <param name="accept">Text to be displayed on the 'Accept' button.</param>
        /// <param name="cancel">Text to be displayed on the 'Cancel' button.</param>
        /// <returns></returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            if (string.IsNullOrEmpty(cancel))
                throw new ArgumentNullException("cancel");

            var args = new AlertArguments(title, message, accept, cancel);
            MessagingCenter.Send(this, AlertSignalName, args);
            return args.Result.Task;
        }

        /// <summary>
        /// Forces the Page to perform a layout pass.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ForceLayout()
        {
            // SizeAllocated(Width, Height);
        }

        /// <summary>
        /// Calls OnBackButtonPressed().
        /// </summary>
        /// <returns></returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool SendBackButtonPressed()
        {
            return OnBackButtonPressed();
        }

        /// <summary>
        /// Lays out children Elements into the specified area.
        /// </summary>
        /// <param name="x">Left-hand side of layout area.</param>
        /// <param name="y">Top of layout area.</param>
        /// <param name="width">Width of layout area.</param>
        /// <param name="height">Height of layout area.</param>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void LayoutChildren(double x, double y, double width, double height)
        {
            var area = new Rectangle((int)x, (int)y, (int)width, (int)height);
            Rectangle originalArea = area;
            if (_containerAreaSet)
            {
                area = ContainerArea;
                area.X += (int)Padding.Left;
                area.Y += (int)Padding.Right;
                area.Width -= (int)Padding.HorizontalThickness;
                area.Height -= (int)Padding.VerticalThickness;
                area.Width = Math.Max(0, area.Width);
                area.Height = Math.Max(0, area.Height);
            }

            List<Element> elements = LogicalChildren.ToList();
            foreach (Element element in elements)
            {
                var child = element as /*VisualElement*/BaseHandle;
                if (child == null)
                    continue;
                var page = child as Page;
                // if (page != null && page.IgnoresContainerArea)
                    // Forms.Layout.LayoutChildIntoBoundingRegion(child, originalArea);
                // else
                    // Forms.Layout.LayoutChildIntoBoundingRegion(child, area);
            }
        }

        /// <summary>
        /// When overridden, allows application developers to customize behavior immediately prior to the Page becoming visible.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void OnAppearing()
        {
        }

        /// <summary>
        /// Application developers can override this method to provide behavior when the back button is pressed.
        /// </summary>
        /// <returns>true if consumed</returns>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual bool OnBackButtonPressed()
        {
            var application = RealParent as Application;
            // if (application == null || this == application.MainPage)
                // return false;

            var canceled = false;
            EventHandler handler = (sender, args) => { canceled = true; };
            // application.PopCanceled += handler;
            Navigation.PopModalAsync().ContinueWith(t => { throw t.Exception; }, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.FromCurrentSynchronizationContext());

            // application.PopCanceled -= handler;
            return !canceled;
        }

        /// <summary>
        /// Invoked whenever the binding context of the Page changes. Override this method to add class handling for this event.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            // foreach (ToolbarItem toolbarItem in ToolbarItems)
            // {
            // 	SetInheritedBindingContext(toolbarItem, BindingContext);
            // }
        }

        /// <summary>
        /// Indicates that the preferred size of a child Element has changed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void OnChildMeasureInvalidated(object sender, EventArgs e)
        {
            InvalidationTrigger trigger = (e as InvalidationEventArgs)?.Trigger ?? InvalidationTrigger.Undefined;
            OnChildMeasureInvalidated((/*VisualElement*/BaseHandle)sender, trigger);
        }

        /// <summary>
        /// When overridden, allows the application developer to customize behavior as the Page disappears.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected virtual void OnDisappearing()
        {
        }

        /// <summary>
        /// Called when the Page's Parent property has changed.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void OnParentSet()
        {
            //if (!Application.IsApplicationOrNull(RealParent) && !(RealParent is Page))
                // throw new InvalidOperationException("Parent of a Page must also be a Page");
            base.OnParentSet();
        }

        ///// <summary>
        ///// Indicates that the Page has been assigned a size.
        ///// </summary>
        // protected override void OnSizeAllocated(double width, double height)
        // {
        // 	_allocatedFlag = true;
        // 	//base.OnSizeAllocated(width, height);
        // 	UpdateChildrenLayout();
        // }

        /// <summary>
        /// Requests that the children Elements of the Page update their layouts.
        /// </summary>
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected void UpdateChildrenLayout()
        {
            if (!ShouldLayoutChildren())
                return;

            var startingLayout = new List<Rectangle>(LogicalChildren.Count);
            foreach (/*VisualElement*/BaseHandle c in LogicalChildren)
            {
                //startingLayout.Add(c.Bounds);
            }

            double x = Padding.Left;
            double y = Padding.Top;
            //double w = Math.Max(0, Width - Padding.HorizontalThickness);
            //double h = Math.Max(0, Height - Padding.VerticalThickness);

            //LayoutChildren(x, y, w, h);

            for (var i = 0; i < LogicalChildren.Count; i++)
            {
                var c = (/*VisualElement*/BaseHandle)LogicalChildren[i];

                // if (c.Bounds != startingLayout[i])
                // {
                // 	LayoutChanged?.Invoke(this, EventArgs.Empty);
                // 	return;
                // }
            }
        }

        internal virtual void OnChildMeasureInvalidated(/*VisualElement*/BaseHandle child, InvalidationTrigger trigger)
        {
            var container = this as IPageContainer<Page>;
            if (container != null)
            {
                Page page = container.CurrentPage;
                if (page != null /*&& page.IsVisible && (!page.IsPlatformEnabled || !page.IsNativeStateConsistent)*/)
                    return;
            }
            else
            {
                for (var i = 0; i < LogicalChildren.Count; i++)
                {
                    var v = LogicalChildren[i] as /*VisualElement*/BaseHandle;
                    if (v != null /*&& v.IsVisible && (!v.IsPlatformEnabled || !v.IsNativeStateConsistent)*/)
                        return;
                }
            }

            _allocatedFlag = false;
            // InvalidateMeasureInternal(InvalidationTrigger.MeasureChanged);
            if (!_allocatedFlag /*&& Width >= 0 && Height >= 0*/)
            {
                // SizeAllocated(Width, Height);
            }
        }

        /// <summary>
        /// For intarnal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SendAppearing()
        {
            if (_hasAppeared)
                return;

            _hasAppeared = true;

            if (IsBusy)
                MessagingCenter.Send(this, BusySetSignalName, true);

            OnAppearing();
            Appearing?.Invoke(this, EventArgs.Empty);

            var pageContainer = this as IPageContainer<Page>;
            pageContainer?.CurrentPage?.SendAppearing();

            //FindApplication(this)?.OnPageAppearing(this);
        }

        /// <summary>
        /// For intarnal use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SendDisappearing()
        {
            if (!_hasAppeared)
                return;

            _hasAppeared = false;

            if (IsBusy)
                MessagingCenter.Send(this, BusySetSignalName, false);

            var pageContainer = this as IPageContainer<Page>;
            pageContainer?.CurrentPage?.SendDisappearing();

            OnDisappearing();
            Disappearing?.Invoke(this, EventArgs.Empty);

            //FindApplication(this)?.OnPageDisappearing(this);
        }

        Application FindApplication(Element element)
        {
            if (element == null)
                return null;

            return (element.Parent is Application app) ? app : FindApplication(element.Parent);
        }

        void InternalChildrenOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (/*VisualElement*/BaseHandle item in e.OldItems.OfType</*VisualElement*/BaseHandle>())
                    OnInternalRemoved(item);
            }

            if (e.NewItems != null)
            {
                foreach (/*VisualElement*/BaseHandle item in e.NewItems.OfType</*VisualElement*/BaseHandle>())
                    OnInternalAdded(item);
            }
        }

        void OnInternalAdded(/*VisualElement*/BaseHandle view)
        {
            // view.MeasureInvalidated += OnChildMeasureInvalidated;

            OnChildAdded(view);
            // InvalidateMeasureInternal(InvalidationTrigger.MeasureChanged);
        }

        void OnInternalRemoved(/*VisualElement*/BaseHandle view)
        {
            // view.MeasureInvalidated -= OnChildMeasureInvalidated;

            OnChildRemoved(view);
        }

        void OnPageBusyChanged()
        {
            if (!_hasAppeared)
                return;

            MessagingCenter.Send(this, BusySetSignalName, IsBusy);
        }

        void OnToolbarItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            if (args.Action != NotifyCollectionChangedAction.Add)
                return;
            foreach (IElement item in args.NewItems)
                item.Parent = this;
        }

        bool ShouldLayoutChildren()
        {
            if (!LogicalChildren.Any()/* || Width <= 0 || Height <= 0 || !IsNativeStateConsistent*/)
                return false;

            var container = this as IPageContainer<Page>;
            if (container?.CurrentPage != null)
            {
                // if (InternalChildren.Contains(container.CurrentPage))
                // 	return container.CurrentPage.IsPlatformEnabled && container.CurrentPage.IsNativeStateConsistent;
                return true;
            }

            var any = false;
            for (var i = 0; i < LogicalChildren.Count; i++)
            {
                var v = LogicalChildren[i] as /*VisualElement*/BaseHandle;
                if (v != null /*&& (!v.IsPlatformEnabled || !v.IsNativeStateConsistent)*/)
                {
                    any = true;
                    break;
                }
            }
            return !any;
        }

        /// <summary>
        /// Returns the platform-specific instance of this Page, on which a platform-specific method may be called.
        /// </summary>
        /// <typeparam name="T">The platform for which to return an instance.</typeparam>
        /// <returns>The platform-specific instance of this Page</returns>
        internal IPlatformElementConfiguration<T, Page> On<T>() where T : IConfigPlatform
        {
            return _platformConfigurationRegistry.Value.On<T>();
        }
    }
}