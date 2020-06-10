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
using System.Runtime.InteropServices;

using Tizen.Internals;

internal static partial class Interop
{
    internal static partial class Eina
    {
        [NativeStruct("Eina_Size2D", Include="Elementary.h", PkgConfig="elementary")]
        [StructLayout(LayoutKind.Sequential)]
        internal struct Size2D
        {
            public int w;
            public int h;
        }

        [DllImport(Libraries.Eina)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool eina_main_loop_is();
    }
}
