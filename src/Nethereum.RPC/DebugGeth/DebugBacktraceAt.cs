using System.Threading.Tasks;
using edjCase.JsonRpc.Core;
using Nethereum.JsonRpc.Client;

namespace Nethereum.RPC.DebugGeth
{
    /// <Summary>
    ///     Sets the logging backtrace location. When a backtrace location is set and a log message is emitted at that
    ///     location, the stack of the goroutine executing the log statement will be printed to stderr.
    ///     The location is specified as
    ///     <filename>
    ///         :
    ///         <line>
    ///             .
    ///             debug.backtraceAt("server.go:443")
    /// </Summary>
    public class DebugBacktraceAt : RpcRequestResponseHandler<string>
    {
        public DebugBacktraceAt(IClient client) : base(client, ApiMethods.debug_backtraceAt.ToString())
        {
        }

        public Task<string> SendRequestAsync(string fileAndLine, object id = null)
        {
            return base.SendRequestAsync(id, fileAndLine);
        }

        public RpcRequest BuildRequest(string fileAndLine, object id = null)
        {
            return base.BuildRequest(id, fileAndLine);
        }
    }
}