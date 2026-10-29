using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xbc09f3bb : MonoBehaviour
{
    private void LateUpdate()
    {
        if (this._0x25bcf341.Count == 0)
            return;
        this._0x4388a93e.Clear();
        this._0x4388a93e.AddRange(this._0x25bcf341);
        this._0x25bcf341.Clear();
        for (int _0xfd16e474 = 0; _0xfd16e474 < this._0x4388a93e.Count; _0xfd16e474++)
            Fix(this._0x4388a93e[_0xfd16e474]);
    }

    private void OnDisable()
    {
        if (this._0x21151cd4 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x21151cd4);
    }

    private const float MinRatio = 4.5f;
    private static _0xbc09f3bb _0x86d2a38c;
    private const float TargetRatio = 7f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x4286523e)
    {
        return 0.2126f * Linear(_0x4286523e.r) + 0.7152f * Linear(_0x4286523e.g) + 0.0722f * Linear(_0x4286523e.b);
    }

    private readonly List<TMP_Text> _0x4388a93e = new List<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xdb3e6dc7(Object _0x37ed1a00)
    {
        TMP_Text _0xdc23573d = _0x37ed1a00 as TMP_Text;
        if (_0xdc23573d != null)
            this._0x25bcf341.Add(_0xdc23573d);
    }

    private static void Fix(TMP_Text _0x9b5d97f7)
    {
        if (_0x9b5d97f7 == null || !_0x9b5d97f7.isActiveAndEnabled)
            return;
        Material _0x8f082a50 = _0x9b5d97f7.fontSharedMaterial;
        if (_0x8f082a50 == null || !_0x8f082a50.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x8f082a50.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x8f082a50.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xcefc8331 = _0x9b5d97f7.color;
        if (_0xcefc8331.a <= 0f)
            return;
        Color _0x1f716038 = _0x8f082a50.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xcefc8331, _0x1f716038) >= MinRatio)
            return;
        Color _0x92f0fc00 = Luminance(_0x1f716038) < 0.5f ? Color.white : Color.black;
        Color _0x744f055d;
        if (Ratio(_0x92f0fc00, _0x1f716038) < TargetRatio)
        {
            _0x744f055d = _0x92f0fc00;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x3a4af560 = 0f;
            float _0x2e64a7a2 = 1f;
            for (int _0x61995fba = 0; _0x61995fba < 20; _0x61995fba++)
            {
                float _0x79dd9da6 = (_0x3a4af560 + _0x2e64a7a2) * 0.5f;
                if (Ratio(Color.Lerp(_0xcefc8331, _0x92f0fc00, _0x79dd9da6), _0x1f716038) >= TargetRatio)
                    _0x2e64a7a2 = _0x79dd9da6;
                else
                    _0x3a4af560 = _0x79dd9da6;
            }

            _0x744f055d = Color.Lerp(_0xcefc8331, _0x92f0fc00, _0x2e64a7a2);
        }

        _0x744f055d.a = _0xcefc8331.a;
        _0x9b5d97f7.color = _0x744f055d;
    }

    private const float MinOutlineWidth = 0.01f;
    private static float Ratio(Color _0x3b29563e, Color _0x83c0111e)
    {
        float _0xe9919d6e = Luminance(_0x3b29563e);
        float _0x85c6194b = Luminance(_0x83c0111e);
        return (Mathf.Max(_0xe9919d6e, _0x85c6194b) + 0.05f) / (Mathf.Min(_0xe9919d6e, _0x85c6194b) + 0.05f);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x21151cd4;
    private static float Linear(float _0x698bf609)
    {
        _0x698bf609 = Mathf.Clamp01(_0x698bf609);
        return _0x698bf609 <= 0.03928f ? _0x698bf609 / 12.92f : Mathf.Pow((_0x698bf609 + 0.055f) / 1.055f, 2.4f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x86d2a38c != null)
            return;
        GameObject _0xbbca56fe = new GameObject(_0xd9f73638._0x6f296864(new byte[16] { 191, 134, 155, 168, 132, 133, 159, 153, 138, 152, 159, 172, 158, 138, 153, 143 }, 235));
        _0xbbca56fe.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xbbca56fe);
        _0x86d2a38c = _0xbbca56fe.AddComponent<_0xbc09f3bb>();
    }

    private void OnEnable()
    {
        if (this._0x21151cd4 == null)
            this._0x21151cd4 = _0x1233d0cd => this._0xdb3e6dc7(_0x1233d0cd);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x21151cd4);
    }

    private readonly HashSet<TMP_Text> _0x25bcf341 = new HashSet<TMP_Text>();
}

internal static class _0xd9f73638
{
    internal static string _0x6f296864(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}