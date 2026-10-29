using UnityEngine;

// Puts the reel screen inside the template's own DefaultPanel body. The panel is addressed by
// INDEX (SETTINGS.PANELS.DEFAULT), never by name, and the view is a plain child of
// Panel.Content - no second root Canvas, which would draw above the Win/Lose/Pause pops and sit
// visible underneath the splash for its whole duration.
public sealed class _0x3452953e : MonoBehaviour
{
    [SerializeField]
    private _0xb065bdca _splash;
    [SerializeField]
    private _0x5b4583ca _sweeper;
    private _0x8f14dba3 _0x28b7a1dc(int _0xc4238f18)
    {
        if (_0xc4238f18 < 0 || _0xc4238f18 >= _0x7f8d8525.Instance.Panels.Count)
            return null;
        return _0x7f8d8525.Instance.Panels[_0xc4238f18];
    }

    [SerializeField]
    private _0x643422fd _session;
    [SerializeField]
    private _0x31f8b05c _art;
    private void Start()
    {
        if (_0x7f8d8525.Instance == null || _0x7f8d8525.Instance.Panels == null || this._session == null)
            return;
        // This scene shows its OWN splash while it loads, and an undressed one would be the
        // template's. It is dressed exactly like the menu's, so the two loaders match.
        _0x8f14dba3 _0x34d7a0e0 = this._0x28b7a1dc(_0xe06f358c._0x9fe1a6a5.SPLASH);
        if (_0x34d7a0e0 != null && _0x34d7a0e0.Content != null && this._splash != null)
        {
            RectTransform _0xf86dc9c7 = _0x2d485ba7.Stretch(_0x34d7a0e0.Content.transform, _0x87d46c39._0x3ff82412(new byte[13] { 243, 208, 197, 209, 204, 201, 207, 239, 204, 208, 221, 207, 212 }, 188));
            _0xf86dc9c7.SetAsFirstSibling();
            this._splash._0xa18fc5ec(_0xf86dc9c7, this._art);
        }

        _0x8f14dba3 _0x0c5b8123 = this._0x28b7a1dc(_0xe06f358c._0x9fe1a6a5.DEFAULT);
        if (_0x0c5b8123 == null || _0x0c5b8123.Content == null)
            return;
        Transform _0xf12881b7 = _0x0c5b8123.Content.transform;
        // The template HUD drawn for a different game (TopPanel's LEFT/RIGHT buttons, the
        // 00:00 timer, ScoreText, the coin pills) is switched off here, so this scene carries
        // ONE consistent button set instead of template plus generated.
        for (int _0x342d63df = _0xf12881b7.childCount - 1; _0x342d63df >= 0; _0x342d63df--)
            _0xf12881b7.GetChild(_0x342d63df).gameObject.SetActive(false);
        RectTransform _0xbbc490f3 = _0x2d485ba7.Stretch(_0xf12881b7, _0x87d46c39._0x3ff82412(new byte[12] { 123, 88, 77, 89, 68, 65, 71, 102, 81, 81, 88, 71 }, 52));
        this._session._0x51032cbb(_0xbbc490f3);
        if (this._sweeper != null)
            this._sweeper._0x34214308();
    }
}

internal static class _0x87d46c39
{
    internal static string _0x3ff82412(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}