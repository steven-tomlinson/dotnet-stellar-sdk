// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  struct TopologyResponseBody
//  {
//      PeerStatList inboundPeers;
//      PeerStatList outboundPeers;
//  
//      uint32 totalInboundPeerCount;
//      uint32 totalOutboundPeerCount;
//  };
//  ===========================================================================
    public class TopologyResponseBody
    {
        public TopologyResponseBody()
        {
        }

        public PeerStatList InboundPeers { get; set; }
        public PeerStatList OutboundPeers { get; set; }
        public Uint32 TotalInboundPeerCount { get; set; }
        public Uint32 TotalOutboundPeerCount { get; set; }

        public static void Encode(XdrDataOutputStream stream, TopologyResponseBody encodedTopologyResponseBody)
        {
            PeerStatList.Encode(stream, encodedTopologyResponseBody.InboundPeers);
            PeerStatList.Encode(stream, encodedTopologyResponseBody.OutboundPeers);
            Uint32.Encode(stream, encodedTopologyResponseBody.TotalInboundPeerCount);
            Uint32.Encode(stream, encodedTopologyResponseBody.TotalOutboundPeerCount);
        }

        public static TopologyResponseBody Decode(XdrDataInputStream stream)
        {
            TopologyResponseBody decodedTopologyResponseBody = new TopologyResponseBody();
            decodedTopologyResponseBody.InboundPeers = PeerStatList.Decode(stream);
            decodedTopologyResponseBody.OutboundPeers = PeerStatList.Decode(stream);
            decodedTopologyResponseBody.TotalInboundPeerCount = Uint32.Decode(stream);
            decodedTopologyResponseBody.TotalOutboundPeerCount = Uint32.Decode(stream);
            return decodedTopologyResponseBody;
        }
    }
}