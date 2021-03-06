using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Hod02
{
    public class Teos : Npc
    {
        public override void OnInit()
        {
            MapName = "Hod_f02";
            Type = 1171;
            Name = "Teos";
            StartX = -5440F;
            StartY = -14208F;
            StartZ = 344;
            Startyaw = 34000;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}