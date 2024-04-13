﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Rogue
{
    [Opcode(CmdIds.QuitRogueCsReq)]
    public class HandlerQuitRogueCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {

            connection.SendPacket(CmdIds.QuitRogueScRsp);
        }
    }
}
