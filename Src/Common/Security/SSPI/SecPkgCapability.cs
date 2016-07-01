//+Copyright (c) 2014, Kevin Thompson
//+All rights reserved.
//+
//+Redistribution and use in source and binary forms, with or without
//+modification, are permitted provided that the following conditions are met:
//+
//+1. Redistributions of source code must retain the above copyright notice, this
//+   list of conditions and the following disclaimer. 
//+2. Redistributions in binary form must reproduce the above copyright notice,
//+   this list of conditions and the following disclaimer in the documentation
//+   and/or other materials provided with the distribution.
//+
//+THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//+ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//+WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//+DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
//+ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//+(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//+LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//+ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//+(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//+SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;

namespace Alachisoft.NosDB.Common.Security.SSPI
{
    /// <summary>
    /// Describes the capabilities of a security package. 
    /// </summary>
    [Flags]
    public enum SecPkgCapability : uint 
    {
        /// <summary>
        /// Whether the package supports generating messages with integrity information. Required for MakeSignature and VerifySignature.
        /// </summary>
        Integrity       = 0x1,

        /// <summary>
        /// Whether the package supports generating encrypted messages. Required for EncryptMessage and DecryptMessage.
        /// </summary>
        Privacy         = 0x2,

        /// <summary>
        /// Whether the package uses any other buffer information than token buffers.
        /// </summary>
        TokenOnly       = 0x4,

        /// <summary>
        /// Whether the package supports datagram-style authentication.
        /// </summary>
        Datagram        = 0x8,

        /// <summary>
        /// Whether the package supports creating contexts with connection semantics
        /// </summary>
        Connection      = 0x10,

        /// <summary>
        /// Multiple legs are neccessary for authentication.
        /// </summary>
        MultiLeg        = 0x20,

        /// <summary>
        /// Server authentication is not supported.
        /// </summary>
        ClientOnly      = 0x40,

        /// <summary>
        /// Supports extended error handling facilities.
        /// </summary>
        ExtendedError   = 0x80,

        /// <summary>
        /// Supports client impersonation on the server.
        /// </summary>
        Impersonation   = 0x100,

        /// <summary>
        /// Understands Windows princple and target names.
        /// </summary>
        AcceptWin32Name = 0x200,

        /// <summary>
        /// Supports stream semantics
        /// </summary>
        Stream          = 0x400,

        /// <summary>
        /// Package may be used by the Negiotiate meta-package.
        /// </summary>
        Negotiable      = 0x800,

        /// <summary>
        /// Compatible with GSS.
        /// </summary>
        GssCompatible   = 0x1000,

        /// <summary>
        /// Supports LsaLogonUser
        /// </summary>
        Logon           = 0x2000,

        /// <summary>
        /// Token buffers are in Ascii format.
        /// </summary>
        AsciiBuffers    = 0x4000,

        /// <summary>
        /// Supports separating large tokens into multiple buffers.
        /// </summary>
        Fragment        = 0x8000,

        /// <summary>
        /// Supports mutual authentication between a client and server.
        /// </summary>
        MutualAuth      = 0x10000,

        /// <summary>
        /// Supports credential delegation from the server to a third context.
        /// </summary>
        Delegation      = 0x20000,

        /// <summary>
        /// Supports calling EncryptMessage with the read-only-checksum flag, which protects data only 
        /// with a checksum and does not encrypt it.
        /// </summary>
        ReadOnlyChecksum = 0x40000,

        /// <summary>
        /// Whether the package supports handling restricted tokens, which are tokens derived from existing tokens
        /// that have had restrictions placed on them.
        /// </summary>
        RestrictedTokens = 0x80000,

        /// <summary>
        /// Extends the negotiate package; only one such package may be registered at any time.
        /// </summary>
        ExtendsNego     = 0x00100000,

        /// <summary>
        /// This package is negotiated by the package of type ExtendsNego.
        /// </summary>
        Negotiable2     = 0x00200000,
    }
}