using System;

#nullable enable

namespace Mercoa.Client;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class MercoaException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
