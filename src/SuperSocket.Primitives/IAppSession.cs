using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using SuperSocket.Channel;

namespace SuperSocket
{
    public interface IAppSession
    {
        string SessionID { get; }

        DateTimeOffset StartTime { get; }

        DateTimeOffset LastActiveTime { get; }

        IChannel Channel { get; }

        EndPoint RemoteEndPoint { get; }

        EndPoint LocalEndPoint { get; }

        ValueTask SendAsync(ReadOnlyMemory<byte> data);

        IServerInfo Server { get; }

        event EventHandler Connected;

        event EventHandler Closed;

        object DataContext { get; set; }

        void Initialize(IServerInfo server, IChannel channel);

        object this[object name] { get; set; }

        SessionState State { get; }
    }
}