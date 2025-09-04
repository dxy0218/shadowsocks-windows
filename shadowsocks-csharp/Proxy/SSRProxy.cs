using System;

namespace Shadowsocks.Proxy
{
    /// <summary>
    /// Simple ShadowsocksR forward proxy placeholder that currently behaves as a
    /// direct connection. This can be extended with SSR handshake logic in the future.
    /// </summary>
    public class SSRProxy : DirectConnect
    {
        // TODO: implement SSR forward proxy handshake.
    }
}
