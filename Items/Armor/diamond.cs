using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace towertop.Items.Armor
{
    public class diamond : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Diamond";
            item.width = 20;
            item.height = 26;
            item.toolTip = "Card.";
            item.toolTip2 = "Don't use this.";
            item.value = 1000000;
            item.rare = 12;
            item.defense = 100;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage *= 3f;
            player.AddBuff(BuffID.Lovestruck, 2);
            player.AddBuff(BuffID.Shine, 2);
        }
    }
}