using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bottlenoselabs.C2CS.Runtime;
using Dojo.Starknet;
using Newtonsoft.Json;
using UnityEngine;

namespace Dojo.Torii
{
    public class ToriiWasmClient
    {
        private string toriiUrl;
        private string rpcUrl;
        private string world;
        public IntPtr clientPtr;

        public ToriiWasmClient(string toriiUrl, string rpcUrl, string world)
        {
            this.toriiUrl = toriiUrl;
            this.rpcUrl = rpcUrl;
            this.world = world;
        }

        public async Task CreateClient()
        {
            clientPtr = await ToriiWasmInterop.CreateClientAsync(rpcUrl, toriiUrl, world);
        }

        public async Task<List<Entity>> Entities(int limit, int offset)
        {
            var entities = await ToriiWasmInterop.GetEntitiesAsync(clientPtr, limit, offset);
            return entities;
        }

        public void RegisterEntityStateUpdates(FieldElement[] entities)
        {
            ToriiWasmInterop.OnEntityUpdated(clientPtr, entities);
        }
    }
}