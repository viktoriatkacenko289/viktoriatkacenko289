using UnityEngine;

// Colour and layout constants for the whole app (preset CASINO_GOLD with the brief's accents).
// Every field is an INDEPENDENT literal: no static field here is initialised from another one,
// because string encryption plus declaration reordering can otherwise kill the type at runtime
// (CLAUDE-unity.md C.52).
public static class _0xc406d6f3
{
    public const float SizeBalance = 64f;
    public const float SizeStatValue = 54f;
    public static readonly Color Silver = new Color(0.788235f, 0.796078f, 0.819608f, 1f); // #C9CBD1
    public static readonly Color Amber = new Color(0.980392f, 0.800000f, 0.082353f, 1f); // #FACC15
    // ---- colours -------------------------------------------------------------------------
    public static readonly Color DeepInk = new Color(0.043137f, 0.043137f, 0.058824f, 1f); // #0B0B0F
    public const float SizeCta = 68f;
    public static readonly Color Bronze = new Color(0.549020f, 0.384314f, 0.223529f, 1f); // #8C6239
    public static readonly Color Muted = new Color(0.658824f, 0.572549f, 0.447059f, 1f); // #A89272
    public static readonly Color Sky = new Color(0.231373f, 0.509804f, 0.964706f, 1f); // #3B82F6
    public const float SizeSpin = 64f;
    public static readonly Color Ember = new Color(0.917647f, 0.345098f, 0.047059f, 1f); // #EA580C
    public static readonly Color PanelRaise = new Color(0.164706f, 0.109804f, 0.062745f, 1f); // #2A1C10
    public const float SizeBody = 36f;
    public const float SizeCaption = 28f;
    public const float SizeWinAmount = 88f;
    public static readonly Color Cream = new Color(1f, 0.968627f, 0.909804f, 1f); // #FFF7E8
    public static readonly Color Storm = new Color(0.129412f, 0.070588f, 0.043137f, 1f); // #21120B
    // ---- type scale (CLAUDE-unity.md C.12: the UGUI readability floor is 24) ---------------
    public const float FontFloor = 24f;
    // ---- shared strings --------------------------------------------------------------------
    public static readonly string ComplianceLine = _0x9cb2592b._0x03fc3edc(new byte[37] { 241, 254, 244, 227, 254, 248, 249, 246, 251, 151, 244, 248, 254, 249, 228, 151, 154, 151, 249, 248, 151, 229, 242, 246, 251, 151, 250, 248, 249, 242, 238, 151, 154, 151, 134, 143, 156 }, 183);
    public static readonly Color EmberDeep = new Color(0.721569f, 0.266667f, 0.039216f, 1f); // #B8440A
    public const float SizeCompliance = 24f;
    // Thousands-separated integer in an explicit invariant format: a culture-dependent one
    // would render differently per device locale.
    public static string Coins(int _0x3fdfcbc0)
    {
        return _0x3fdfcbc0.ToString(_0x9cb2592b._0x03fc3edc(new byte[5] { 197, 202, 197, 197, 214 }, 230), System.Globalization.CultureInfo.InvariantCulture);
    }

    public static readonly Color Locked = new Color(0.227451f, 0.180392f, 0.133333f, 1f); // #3A2E22
    public const float SizePopHeader = 96f;
    public static readonly Color GoldLight = new Color(0.960784f, 0.843137f, 0.478431f, 1f); // #F5D77A
    public const float SizeSectionTitle = 52f;
    public static readonly Color Panel = new Color(0.117647f, 0.101961f, 0.078431f, 1f); // #1E1A14
    public static readonly Color Gold = new Color(0.831373f, 0.686275f, 0.215686f, 1f); // #D4AF37
    public const float PanelHeight = 2688f;
    public static readonly Color PanelSink = new Color(0.082353f, 0.062745f, 0.039216f, 1f); // #15100A
    // Colour helper so a tint with a different alpha never needs a second literal.
    public static Color Alpha(Color _0x69dfd4fa, float _0xd90478df)
    {
        return new Color(_0x69dfd4fa.r, _0x69dfd4fa.g, _0x69dfd4fa.b, _0xd90478df);
    }

    public const float SizeButton = 34f;
    public static readonly Color CreamDim = new Color(0.847059f, 0.792157f, 0.690196f, 1f); // #D8CAB0
    // ---- canvas ---------------------------------------------------------------------------
    // AspecterSA carries an AspectRatioFitter in FitInParent mode at 1242/2688, so the panel
    // body is EXACTLY this size on every device; laying out against it needs no device maths.
    public const float PanelWidth = 1242f;
}

internal static class _0x9cb2592b
{
    internal static string _0x03fc3edc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}