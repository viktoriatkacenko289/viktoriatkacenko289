using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// This game's own Back and Pause. Rule H option 2 is taken deliberately: pipeline stage 5da
// switches the template's TopPanel LEFT_BUTTON / RIGHT_BUTTON off by name on this template
// family, so "reuse the template slots" would ship a panel with no Back and no Pause at all.
// Nothing of ours hangs on those objects and nothing of ours references them.
public sealed class _0x785218b7 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private Button _0x5ca5167d;
    public void _0x7fa7d748(RectTransform _0xb8fafd7b, _0x31f8b05c _0xffbba515, _0x643422fd _0x3d7a57c4)
    {
        if (this._0x994619a0 != null)
            return;
        this._0x994619a0 = _0x2d485ba7.IconAction(_0xb8fafd7b, _0x8506bd20._0x21d88bc0(new byte[10] { 254, 221, 223, 215, 254, 201, 200, 200, 211, 210 }, 188), new Vector2(-481f, 0f), ButtonSide, _0xffbba515, _0xffbba515.IconBack, _0xc406d6f3.PanelRaise, 26f);
        this._0x994619a0.onClick.AddListener(() => this._0x6ea5117f());
        this._0x5ca5167d = _0x2d485ba7.IconAction(_0xb8fafd7b, _0x8506bd20._0x21d88bc0(new byte[11] { 200, 249, 237, 235, 253, 218, 237, 236, 236, 247, 246 }, 152), new Vector2(481f, 0f), ButtonSide, _0xffbba515, _0xffbba515.IconPause, _0xc406d6f3.PanelRaise, 26f);
        this._0x5ca5167d.onClick.AddListener(() => _0x3d7a57c4._0x564d9a2c());
    }

    public const float ButtonSide = 116f;
    private void _0x6ea5117f()
    {
        if (_0x51e11591.Instance == null)
            return;
        _0x51e11591.Instance._0x05618a99(_0xe06f358c._0x55066aa5.SCENE_0);
    }

    private Button _0x994619a0;
}

internal static class _0x8506bd20
{
    internal static string _0x21d88bc0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}