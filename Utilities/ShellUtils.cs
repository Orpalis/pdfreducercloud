/**********************************************************************
 * Project:                  pdfReducer.Cloud
 * Authors:					- Evan Carr�re.
 *                          - Lo�c Carr�re.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/


using System;
using System.Reflection;

namespace pdfReducerCloud.Utilities
{
    internal static class ShellUtils
    {
        public static Shell32.Folder GetShell32Folder(string folderPath)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            Object shell = Activator.CreateInstance(shellAppType);
            return
                (Shell32.Folder)
                shellAppType.InvokeMember("NameSpace", BindingFlags.InvokeMethod, null, shell,
                    new object[] { folderPath });
        }
    }
}