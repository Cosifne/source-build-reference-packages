// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Security.AllowPartiallyTrustedCallers]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyTitle("System.Buffers")]
[assembly: System.Reflection.AssemblyDescription("System.Buffers")]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Buffers")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET Framework")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: System.Reflection.AssemblyFileVersion("4.6.25519.03")]
[assembly: System.Reflection.AssemblyInformationalVersion("4.6.25519.03 built by: dlab-DDVSOWINAGE013. Commit Hash: 8321c729934c0f8be754953439b88e6e1c120c24")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System.Buffers
{
    public abstract partial class ArrayPool<T>
    {
        public static ArrayPool<T> Shared { get { throw null; } }

        public static ArrayPool<T> Create() { throw null; }

        public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket) { throw null; }

        public abstract T[] Rent(int minimumLength);
        public abstract void Return(T[] array, bool clearArray = false);
    }
}