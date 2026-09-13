using Terraria.Audio;

namespace CalamityEntropyLegacy.Assets.Register
{
    public class SoundRegister
    {
        private static string SetPath => "CalamityEntropyLegacy/Assets/Sounds/";
        //下面的字段名最好和资源名一致……
        public static SoundStyle SmashToGroundHeavy => new(SetPath + nameof(SmashToGroundHeavy));
        public static SoundStyle Pipes => new(SetPath + nameof(Pipes));
        private static string SoundPath => "CalamityEntropyLegacy/Assets/Sounds/";

    }
}
