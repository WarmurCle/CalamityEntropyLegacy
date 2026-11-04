using CalamityEntropyLegacy.Common;
using InnoVault;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy.Core
{
    public static class CrossModSystem
    {
        public static bool IEoRBalancing = (ServerConfig.Instance.IEoRBalancing || ModLoader.HasMod("InfernalEclipseAPI"));
    }
}
