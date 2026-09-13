using CalamityMod.UI.DraedonSummoning;
using System;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace CalamityEntropyLegacy
{
    public partial class CalamityEntropyLegacy : Mod
    {
        internal static DraedonDialogEntry CreateFromKey(string key, Func<bool> condition = null) =>
            new($"Mods.CalamityEntropyLegacy.DraedonDialogs.{key}", condition);
        public static void RegistryDraedonDialogs()
        {
            var t = typeof(DraedonDialogRegistry).GetField("DialogOptions", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            if (t != null)
            {
                List<DraedonDialogEntry> dialogs = (List<DraedonDialogEntry>)t.GetValue(null);
                dialogs.Add(CreateFromKey("Void"));
            }
            else
            {
                Instance.Logger.Warn("Cannot add Draedon dialog!");
            }
        }
    }
}
