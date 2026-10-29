using TMPro;
using UnityEngine;

// Every TMP label this game creates in code gets its own outline here (CLAUDE-unity.md C.10):
// stage 5c3 only reads labels SERIALISED in scenes and prefabs, so a runtime caption is
// invisible to it and would ship with whatever the shared material happens to carry.
public static class _0xac23041c
{
    // Reading fontMaterial creates a per-label INSTANCE; the shared font SDF asset is untouched.
    public static void ApplyOutline(TMP_Text _0x5c93c6d9)
    {
        if (_0x5c93c6d9 == null)
            return;
        Color _0x0d3785b6 = _0x5c93c6d9.color;
        float _0xb1f383a7 = (0.299f * _0x0d3785b6.r) + (0.587f * _0x0d3785b6.g) + (0.114f * _0x0d3785b6.b);
        Color _0xcc048dc1 = _0xb1f383a7 < 0.5f ? _0xc406d6f3.Cream : _0xc406d6f3.DeepInk;
        Material _0x489f18a6 = _0x5c93c6d9.fontMaterial;
        if (_0x489f18a6 == null)
            return;
        _0x489f18a6.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x489f18a6.SetColor(ShaderUtilities.ID_OutlineColor, _0xcc048dc1);
        _0x489f18a6.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
    }

    // Line breaks are placed BY HAND (an explicit \n in the string); the engine never decides
    // where a line ends, so the layout is identical on every device and locale.
    public static void SetText(TMP_Text _0xafd3487f, string _0xa528f7dc)
    {
        if (_0xafd3487f == null)
            return;
        _0xafd3487f.text = _0xa528f7dc;
    }
}