﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MiningCore.Blockchain.Bitcoin.DaemonResponses
{
    public class Masternode
    {
        public string Payee { get; set; }
        public string Script { get; set; }
        public long Amount { get; set; }
    }

    public class SuperBlock
    {
        public string Payee { get; set; }
        public long Amount { get; set; }
    }

    public class MasterNodeBlockTemplateExtra
    {
        public string Payee { get; set; }

        [JsonProperty("payee_amount")]
        public long? PayeeAmount { get; set; }

        public Masternode Masternode { get; set; }

        [JsonProperty("masternode_payments_started")]
        public bool MasternodePaymentsStarted { get; set; }

        [JsonProperty("masternode_payments_enforced")]
        public bool MasternodePaymentsEnforced { get; set; }

        [JsonProperty("superblock")]
        public SuperBlock[] SuperBlocks { get; set; }

        [JsonProperty("superblocks_started")]
        public bool SuperblocksStarted { get; set; }

        [JsonProperty("superblocks_enabled")]
        public bool SuperblocksEnabled { get; set; }
    }
}