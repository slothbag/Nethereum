using System.Threading.Tasks;
using edjCase.JsonRpc.Core;
using Nethereum.JsonRpc.Client;
using Newtonsoft.Json.Linq;

namespace Nethereum.RPC.DebugGeth
{
    /// <Summary>
    ///     The traceBlock method will return a full stack trace of all invoked opcodes of all transaction that were included
    ///     included in this block. Note, the parent of this block must be present or it will fail.
    /// </Summary>
    public class DebugTraceBlock : RpcRequestResponseHandler<JObject>
    {
        public DebugTraceBlock(IClient client) : base(client, ApiMethods.debug_traceBlock.ToString())
        {
        }

        public Task<JObject> SendRequestAsync(string blockRlpHex, object id = null)
        {
            return base.SendRequestAsync(id, blockRlpHex);
        }

        public RpcRequest BuildRequest(string blockRlpHex, object id = null)
        {
            return base.BuildRequest(id, blockRlpHex);
        }
    }
}