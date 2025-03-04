// <auto-generated/>
/*
The MIT License (MIT)

Copyright (c) 2016-2023 Maksim Volkau

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
/*
========================================================================================================
NOTE: The code below is generated automatically at compile-time and not supposed to be changed by hand.
========================================================================================================
Generation is completed successfully.
--------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Threading;
using DryIoc.ImTools;

// Specified `NamespaceUsings` if any:
using Example;

namespace DryIoc
{
    partial class Container
    {
        partial void GetLastGeneratedFactoryID(ref int lastFactoryID)
        {
            lastFactoryID = 674; // generated: equals to the last used Factory.FactoryID
        }

        partial void ResolveGenerated(ref object service, Type serviceType)
        {
            if (serviceType == typeof(IService))
                service = Get_IService_0(this);
        }

        partial void ResolveGenerated(ref object service,
            Type serviceType, object serviceKey, Type requiredServiceType, Request preRequestParent, object[] args)
        {
            if (serviceType == typeof(DependencyB<string>))
            {
                if (serviceKey == null &&
                    requiredServiceType == null &&
                    Equals(preRequestParent, Request.Empty.Push(
                        typeof(IService),
                        669,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall)))
                    service = GetDependency_DependencyB_0(this);
            }
        }

        partial void ResolveManyGenerated(ref IEnumerable<ResolveManyResult> services, Type serviceType)
        {
            services = ResolveManyGenerated(serviceType);
        }

        private IEnumerable<ResolveManyResult> ResolveManyGenerated(Type serviceType)
        {
            if (serviceType == typeof(IService))
                yield return ResolveManyResult.Of(Get_IService_0);
        }

        // IService
        internal static object Get_IService_0(IResolverContext r) =>
            new MyService(
                new DependencyA(),
                ((DependencyB<string>)r.Resolve(
                    typeof(DependencyB<string>),
                    null,
                    IfUnresolved.Throw,
                    null,
                    Request.Empty.Push(
                        typeof(IService),
                        669,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall|RequestFlags.StopRecursiveDependencyCheck),
                    null)),
                ((RuntimeDependencyC)r.Resolve(
                    typeof(RuntimeDependencyC),
                    null,
                    IfUnresolved.Throw,
                    null,
                    Request.Empty.Push(
                        typeof(IService),
                        669,
                        typeof(MyService),
                        Reuse.Transient,
                        RequestFlags.IsResolutionCall|RequestFlags.StopRecursiveDependencyCheck),
                    null)));

        // DependencyB<string>
        internal static object GetDependency_DependencyB_0(IResolverContext r) =>
            new DependencyB<string>();

    }
}
