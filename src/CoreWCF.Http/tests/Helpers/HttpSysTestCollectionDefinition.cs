﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace CoreWCF.Http.Tests.Helpers;

[CollectionDefinition(HttpSysTestCollection)]
public class HttpSysTestCollectionDefinition
{
    public const string HttpSysTestCollection = nameof(HttpSysTestCollection);
}
