﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CodeLens;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.CodeLens
{
    /// <summary>
    /// This interface is solely here to prevent VS.Next dll from loading
    /// when RemoteHost option is off
    /// </summary>
    internal interface IRemoteCodeLensReferencesService : ICodeLensReferencesService
    {
    }
}
