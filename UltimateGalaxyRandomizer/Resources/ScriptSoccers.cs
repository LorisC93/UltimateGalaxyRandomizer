using System.Collections.Generic;

namespace UltimateGalaxyRandomizer.Resources
{
    public class ScriptSoccer(List<int> playerIndex, uint moveId)
    {
        public List<int> PlayerIndex { get; set; } = playerIndex;
        public uint RightMove { get; set; } = moveId;
    }

    public static class ScriptSoccers
    {
        public static readonly IReadOnlyDictionary<uint, ScriptSoccer> ScriptSoccerGalaxy = new Dictionary<uint, ScriptSoccer>()
        {
            {0x02, new ScriptSoccer([8, 9, 10], 0x5B620610) },
            {0x03, new ScriptSoccer([7], 0x656CB642) },
            {0x05, new ScriptSoccer([9, 10], 0xB201A325) },
            {0x06, new ScriptSoccer([10], 0x2B08F29F) },
            {0x08, new ScriptSoccer([8, 9, 10], 0x5C0FC209) },
            {0x09, new ScriptSoccer([8, 9], 0xCCB0DF98) },
            {0x0A, new ScriptSoccer([9], 0xBBB7EF0E) },
            {0x0B, new ScriptSoccer([9], 0x42793751) },
            {0X0D, new ScriptSoccer([9, 10], 0xF05D3528) },
            {0X0F, new ScriptSoccer([9], 0xAB1A9264) },
            {0x10, new ScriptSoccer([9], 0xAB1A9264) },
            {0x11, new ScriptSoccer([9], 0xAB1A9264) },
            {0x12, new ScriptSoccer([9], 0xAB1A9264) },
            {0x13, new ScriptSoccer([9], 0xAB1A9264) },
            {0x14, new ScriptSoccer([9], 0xAB1A9264) },
        };
    }
}
