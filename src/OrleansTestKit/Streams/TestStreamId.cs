﻿// using System;
// using System.Diagnostics;
// using Orleans.Runtime;
// using Orleans.Streams;
//
// namespace Orleans.TestKit.Streams
// {
//     [DebuggerStepThrough]
//     internal sealed class TestStreamId :
//         IStreamIdentity
//     {
//         public Guid Guid { get; }
//
//         public string Namespace { get; }
//
//         public TestStreamId(StreamId streamId)
//         {
//             Guid = streamId.GetKeyAsString();
//             Namespace = streamId.GetNamespace();
//         }
//
//         public override bool Equals(object obj) =>
//             obj is TestStreamId o && Guid == o.Guid && Namespace == o.Namespace;
//
//         public override int GetHashCode()
//         {
//             var hash = 13;
//             hash = hash * 7 + Guid.GetHashCode();
//
//             if (Namespace != null)
//                 hash = hash * 7 + Namespace.GetHashCode();
//
//             return hash;
//         }
//     }
// }
