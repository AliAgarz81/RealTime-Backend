using System.Collections.Concurrent;
using RealTime.Models;

namespace RealTime.Data;

public class SharedDb
{
    private readonly ConcurrentDictionary<string, UserConnection> _connections = new();
    public ConcurrentDictionary<string, UserConnection> connections => _connections;
}