﻿/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
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
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using System.ComponentModel;

namespace Tizen.NUI.Components
{
    /// <summary>
    /// Popup is one kind of common component, it can be used as popup window.
    /// User can handle Popup button count, head title and content area.
    /// </summary>
    /// <since_tizen> 6 </since_tizen>
    public class Popup : Control
    {
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonHeightProperty = BindableProperty.Create(nameof(ButtonHeight), typeof(int), typeof(Popup), default(int), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null && instance?.Style?.Buttons?.Size != null )
            {
                instance.Style.Buttons.Size.Height = (int)newValue;
                instance.btGroup.Itemheight = (int)newValue;
                instance.UpdateView();
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return (int)(instance.Style?.Buttons?.Size?.Height ?? 0);
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonTextPointSizeProperty = BindableProperty.Create(nameof(ButtonTextPointSize), typeof(float), typeof(Popup), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                if (instance.Style?.Buttons?.Text != null)
                {
                    instance.Style.Buttons.Text.PointSize = (float)newValue;
                }
                instance.btGroup.ItemPointSize = (float)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.Text?.PointSize?.All ?? 0;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonFontFamilyProperty = BindableProperty.Create(nameof(ButtonFontFamily), typeof(string), typeof(Popup), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                instance.Style.Buttons.Text.FontFamily = (string)newValue;
                instance.btGroup.ItemFontFamily = (string)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.Text?.FontFamily.All;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create(nameof(ButtonTextColor), typeof(Color), typeof(Popup), Color.Transparent, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {  
                if (instance.Style?.Buttons?.Text != null)
                {
                    instance.Style.Buttons.Text.TextColor = (Color)newValue;
                }
                instance.btGroup.ItemTextColor = (Color)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.Text?.TextColor?.All;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonOverLayBackgroundColorSelectorProperty = BindableProperty.Create(nameof(ButtonOverLayBackgroundColorSelector), typeof(Selector<Color>), typeof(Popup), new Selector<Color>(), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                instance.Style.Buttons.Overlay.BackgroundColor = (Selector<Color>)newValue;
                instance.btGroup.OverLayBackgroundColorSelector = (Selector<Color>)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.Overlay?.BackgroundColor;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonTextAlignmentProperty = BindableProperty.Create(nameof(ButtonTextAlignment), typeof(HorizontalAlignment), typeof(Popup), new HorizontalAlignment(), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                instance.Style.Buttons.Text.HorizontalAlignment = (HorizontalAlignment)newValue;
                instance.btGroup.ItemTextAlignment = (HorizontalAlignment)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.Text?.HorizontalAlignment ?? HorizontalAlignment.Center;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonBackgroundProperty = BindableProperty.Create(nameof(ButtonBackground), typeof(string), typeof(Popup), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                if (instance.Style.Buttons.BackgroundImage == null)
                {
                    instance.Style.Buttons.BackgroundImage = new Selector<string>();
                }
                instance.btGroup.ItemBackgroundImageUrl = (string)newValue;
                instance.Style.Buttons.BackgroundImage = (string)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.BackgroundImage?.All;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonBackgroundBorderProperty = BindableProperty.Create(nameof(ButtonBackgroundBorder), typeof(Rectangle), typeof(Popup), new Rectangle(0, 0, 0, 0), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            if (newValue != null)
            {
                if (instance.Style.Buttons.BackgroundImageBorder == null)
                {
                    instance.Style.Buttons.BackgroundImageBorder = new Selector<Rectangle>();
                }
                instance.Style.Buttons.BackgroundImageBorder = (Rectangle)newValue;
                instance.btGroup.ItemBackgroundBorder = (Rectangle)newValue;
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.BackgroundImageBorder?.All;
        });

        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ButtonImageShadowProperty = BindableProperty.Create(nameof(ButtonImageShadow), typeof(ImageShadow), typeof(Popup), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var instance = (Popup)bindable;
            ImageShadow shadow = (ImageShadow)newValue;
            instance.btGroup.ItemImageShadow = new ImageShadow(shadow);
            instance.Style.Buttons.ImageShadow = new ImageShadow(shadow);
        },
        defaultValueCreator: (bindable) =>
        {
            var instance = (Popup)bindable;
            return instance.Style?.Buttons?.ImageShadow?.All;
        });


        private TextLabel titleText;
        private ButtonGroup btGroup = null;
        private Window window = null;
        private Layer container = new Layer();
        static Popup() { }

        /// <summary>
        /// Creates a new instance of a Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Popup() : base()
        {
            Initialize();
        }

        /// <summary>
        /// Creates a new instance of a Popup with style.
        /// </summary>
        /// <param name="style">Create Popup by special style defined in UX.</param>
        /// <since_tizen> 8 </since_tizen>
        public Popup(string style) : base(style)
        {
            Initialize();
        }

        /// <summary>
        /// Creates a new instance of a Popup with style.
        /// </summary>
        /// <param name="popupStyle">Create Popup by style customized by user.</param>
        /// <since_tizen> 8 </since_tizen>
        public Popup(PopupStyle popupStyle) : base(popupStyle)
        {
            Initialize();
        }

        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual void Post(Window targetWindow)
        {
            if (targetWindow == null)
            {
                return;
            }

            window = targetWindow;
            window.AddLayer(container);
            container.RaiseToTop();
        }

        /// <summary>
        /// Dismiss the dialog
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual void Dismiss()
        {
            if (window == null)
            {
                return;
            }

            window.RemoveLayer(container);
            window = null;
        }

        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddButton(string buttonText)
        {
            if (Style.Buttons != null)
            {
                Button btn = new Button(Style.Buttons);
                btn.Style.Text.Text = buttonText;
                btn.ClickEvent += ButtonClickEvent;
                btGroup.AddItem(btn);
                UpdateView();
            }
        }

        /// <summary>
        /// Add button by style's name.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public void AddButton(string buttonText, string style)
        {
            AddButton(buttonText);
        }

        /// <summary>
        /// Add button by style.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public void AddButton(string buttonText, ButtonStyle style)
        {
            if (Style.Buttons != null && style != null)
            {
                Style.Buttons.CopyFrom(style);
                AddButton(buttonText);
            }
        }

        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Button GetButton(int index)
        {
            return btGroup.GetItem(index);
        }

        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveButton(int index)
        {
            btGroup.RemoveItem(index);
        }

        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddContentText(View childView)
        {
            if (null != ContentView)
            {
                ContentView.Add(childView);
            }
            UpdateView();
        }

        /// <summary>
        /// An event for the button clicked signal which can be used to subscribe or unsubscribe the event handler provided by the user.<br />
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public event EventHandler<ButtonClickEventArgs> PopupButtonClickEvent;

        /// <summary>
        /// Get style of popup.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public new PopupStyle Style => ViewStyle as PopupStyle;

        /// <summary>
        /// Title text string in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string TitleText
        {
            get
            {
                return Style?.Title?.Text?.All;
            }
            set
            {
                if (value != null)
                {
                    if (Style?.Title != null)
                    {
                        Style.Title.Text = value;
                    }
                }
            }
        }

        /// <summary>
        /// Title text point size in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public float TitlePointSize
        {
            get
            {
                return Style?.Title?.PointSize?.All ?? 0;
            }
            set
            {
                if (Style?.Title != null)
                {
                    Style.Title.PointSize = value;
                }
            }
        }

        /// <summary>
        /// Title text color in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Color TitleTextColor
        {
            get
            {
                return Style?.Title?.TextColor?.All;
            }
            set
            {
                if (Style?.Title != null)
                {
                    Style.Title.TextColor = value;
                }
            }
        }

        /// <summary>
        /// Title text horizontal alignment in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public HorizontalAlignment TitleTextHorizontalAlignment
        {
            get
            {
                return Style?.Title?.HorizontalAlignment ?? HorizontalAlignment.Center;
            }
            set
            {
                Style.Title.HorizontalAlignment = value;
            }
        }

        /// <summary>
        /// Title text's position in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Position TitleTextPosition
        {
            get
            {
                return Style?.Title?.Position ?? new Position(0, 0, 0);
            }
            set
            {
                Style.Title.Position = value;
            }
        }

        /// <summary>
        /// Title text's height in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public int TitleHeight
        {
            get
            {
                return (int)(Style?.Title?.Size?.Height ?? 0);
            }
            set
            {
                if (Style?.Title?.Size != null)
                {
                     Style.Title.Size.Height = value;
                }
            }
        }

        /// <summary>
        /// Content view in Popup, only can be gotten.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public View ContentView
        {
            get;
            private set;
        }

        /// <summary>
        /// Button count in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public int ButtonCount
        {
            get;
            set;
        }

        /// <summary>
        /// Button height in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public int ButtonHeight
        {
            get
            {
                return (int)GetValue(ButtonHeightProperty);
            }
            set
            {
                SetValue(ButtonHeightProperty, value);
            }
        }

        /// <summary>
        /// Button text point size in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public float ButtonTextPointSize
        {
            get
            {
                return (float)GetValue(ButtonTextPointSizeProperty);
            }
            set
            {
                SetValue(ButtonTextPointSizeProperty, value);
            }
        }

        /// <summary>
        /// Button text font family in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public string ButtonFontFamily
        {
            get
            {           
                return (string)GetValue(ButtonFontFamilyProperty);
            }
            set
            {
                SetValue(ButtonFontFamilyProperty, value);
            }
        }

        /// <summary>
        /// Button text color in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public Color ButtonTextColor
        {
            get
            {
                return (Color)GetValue(ButtonTextColorProperty);
            }
            set
            {
                SetValue(ButtonTextColorProperty, value);
            }
        }

        /// <summary>
        /// Button overlay background color selector in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector<Color> ButtonOverLayBackgroundColorSelector
        {
            get
            {
                return (Selector<Color>)GetValue(ButtonOverLayBackgroundColorSelectorProperty);
            }
            set
            {
                SetValue(ButtonOverLayBackgroundColorSelectorProperty, value);
            }
        }

        /// <summary>
        /// Button text horizontal alignment in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public HorizontalAlignment ButtonTextAlignment
        {
            get
            {   
                return (HorizontalAlignment)GetValue(ButtonTextAlignmentProperty);
            }
            set
            {
                SetValue(ButtonTextAlignmentProperty, value);
            }
        }

        /// <summary>
        /// Button background image's resource url in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ButtonBackground
        {
            get
            {     
                return (string)GetValue(ButtonBackgroundProperty);
            }
            set
            {
                SetValue(ButtonBackgroundProperty, value);
            }
        }

        /// <summary>
        /// Button background image's border in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Rectangle ButtonBackgroundBorder
        {
            get
            {
                
                return (Rectangle)GetValue(ButtonBackgroundBorderProperty);
            }
            set
            {
                SetValue(ButtonBackgroundBorderProperty, value);
            }
        }

        /// <summary>
        /// Button's image shadow in Popup.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ImageShadow ButtonImageShadow
        {
            get => (ImageShadow)GetValue(ButtonImageShadowProperty);
            set => SetValue(ButtonImageShadowProperty, value);
        }


        /// <summary>
        /// Set button text by index.
        /// </summary>
        /// <param name="index">Button index.</param>
        /// <param name="text">Button text string.</param>
        /// <since_tizen> 6 </since_tizen>
        public void SetButtonText(int index, string text)
        {
            AddButton(text);
        }

        /// <summary>
        /// Dispose Popup and all children on it.
        /// </summary>
        /// <param name="type">Dispose type.</param>
        /// <since_tizen> 6 </since_tizen>
        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                if (titleText != null)
                {
                    Remove(titleText);
                    titleText.Dispose();
                    titleText = null;
                }
                if (ContentView != null)
                {
                    Remove(ContentView);
                    ContentView.Dispose();
                    ContentView = null;
                }

                if (btGroup != null)
                {
                    btGroup.Dispose();
                    btGroup = null;
                }
            }

            base.Dispose(type);
        }

        /// <summary>
        /// Focus gained callback.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void OnFocusGained()
        {
            base.OnFocusGained();
        }

        /// <summary>
        /// Focus lost callback.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void OnFocusLost()
        {
            base.OnFocusLost();
        }

        /// <summary>
        /// Apply style to popup.
        /// </summary>
        /// <param name="viewStyle">The style to apply.</param>
        /// <since_tizen> 8 </since_tizen>
        public override void ApplyStyle(ViewStyle viewStyle)
        {
            base.ApplyStyle(viewStyle);
            PopupStyle ppStyle = viewStyle as PopupStyle;
            if (null != ppStyle)
            {
                if (null == titleText)
                {
                    titleText = new TextLabel();
                    Add(titleText);
                }
                titleText.RaiseToTop();
                titleText.ApplyStyle(ppStyle.Title);
            }
        }

        /// <summary>
        /// Get Popup style.
        /// </summary>
        /// <returns>The default popup style.</returns>
        /// <since_tizen> 8 </since_tizen>
        protected override ViewStyle GetViewStyle()
        {
            return new PopupStyle();
        }

        /// <summary>
        /// Theme change callback when theme is changed, this callback will be trigger.
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event data</param>
        /// <since_tizen> 8 </since_tizen>
        protected override void OnThemeChangedEvent(object sender, StyleManager.ThemeChangeEventArgs e)
        {
            PopupStyle popupStyle = StyleManager.Instance.GetViewStyle(style) as PopupStyle;
            if (popupStyle != null)
            {
                string strSaveTitleText = TitleText;
                Style.CopyFrom(popupStyle);
                Style.Title.Text = strSaveTitleText;
                UpdateView();
            }
        }

        private void Initialize()
        {
            container.Add(this);
            container.SetTouchConsumed(true);
            container.SetHoverConsumed(true);

            LeaveRequired = true;
            PropertyChanged += PopupStylePropertyChanged;

            // ContentView
            ContentView = new View()
            {
                ParentOrigin = Tizen.NUI.ParentOrigin.TopLeft,
                PivotPoint = Tizen.NUI.PivotPoint.TopLeft,
                PositionUsesPivotPoint = true
            };
            Add(ContentView);
            ContentView.RaiseToTop();

            // Title
            if (null == titleText)
            {
                titleText = new TextLabel();
                titleText.RaiseToTop();
                Add(titleText);
            }

            // Button
            btGroup = new ButtonGroup(this);
        }

        private void UpdateView()
        {
            btGroup.UpdateButton(Style.Buttons);
            UpdateContentView();
            UpdateTitle();
        }

        private void ButtonClickEvent(object sender, Button.ClickEventArgs e)
        {
            if (PopupButtonClickEvent != null && btGroup.Count > 0)
            {
                Button button = sender as Button;
                for (int i = 0; i < btGroup.Count; i++)
                {
                    if (button == GetButton(i))
                    {
                        ButtonClickEventArgs args = new ButtonClickEventArgs();
                        args.ButtonIndex = i;
                        PopupButtonClickEvent(this, args);
                    }
                }
            }
        }

        private void PopupStylePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("LayoutDirection"))
            {
                btGroup.UpdateButton(Style.Buttons);
            }
        }

        private void UpdateContentView()
        {
            int titleX = 0;
            int titleY = 0;
            int titleH = 0;
            int buttonH = 0;
            string strText = Style.Title.Text.All;
            if (!string.IsNullOrEmpty(strText) && Style.Title.Size != null)
            {
                titleH = (int)titleText.Size.Height;
            }

            if (!string.IsNullOrEmpty(strText) && Style.Title.Position != null)
            {
                titleX = (int)Style.Title.Position.X;
                titleY = (int)Style.Title.Position.Y;
            }

            if (btGroup.Count != 0 && Style?.Buttons?.Size != null )
            {
                buttonH = (int)Style.Buttons.Size.Height;
            }
            ContentView.Size = new Size(Size.Width - titleX * 2, Size.Height - titleY - titleH - buttonH);
            ContentView.Position = new Position(titleX, titleY + titleH);
            ContentView.RaiseToTop();
        }

        private void UpdateTitle()
        {
            if (titleText != null && string.IsNullOrEmpty(Style.Title.Text.All) && Style.Title.Size != null)
            {
                titleText.RaiseToTop();
            }
        }
        /// <summary>
        /// ButtonClickEventArgs is a class to record button click event arguments which will sent to user.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public class ButtonClickEventArgs : EventArgs
        {
            /// <summary> Button index which is clicked in Popup </summary>
            /// <since_tizen> 6 </since_tizen>
            public int ButtonIndex;
        }
    }
}
