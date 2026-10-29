using UnityEngine;

// Puts the splash dressing and the casino lobby inside the template's own panels. Both are
// addressed by INDEX (SETTINGS.PANELS), never by name, and both are plain children of
// Panel.Content: a second root Canvas would draw above the pops and would sit visible
// underneath the splash for its whole ten seconds.
public sealed class _0xc3671458 : MonoBehaviour
{
    private _0x8f14dba3 _0x88ad6ceb(int _0x166f89da)
    {
        if (_0x166f89da < 0 || _0x166f89da >= _0x7f8d8525.Instance.Panels.Count)
            return null;
        return _0x7f8d8525.Instance.Panels[_0x166f89da];
    }

    [SerializeField]
    private _0x5b4583ca _sweeper;
    private void Start()
    {
        if (_0x7f8d8525.Instance == null || _0x7f8d8525.Instance.Panels == null)
            return;
        _0x8f14dba3 _0x3f95f0a8 = this._0x88ad6ceb(_0xe06f358c._0x9fe1a6a5.SPLASH);
        if (_0x3f95f0a8 != null && _0x3f95f0a8.Content != null && this._splash != null)
        {
            RectTransform _0x02989ab9 = _0x2d485ba7.Stretch(_0x3f95f0a8.Content.transform, _0x11e00f8b._0x67872657(new byte[13] { 55, 20, 1, 21, 8, 13, 11, 43, 8, 20, 25, 11, 16 }, 120));
            _0x02989ab9.SetAsFirstSibling();
            this._splash._0xa18fc5ec(_0x02989ab9, this._art);
        }

        _0x8f14dba3 _0xbc654300 = this._0x88ad6ceb(_0xe06f358c._0x9fe1a6a5.DEFAULT);
        if (_0xbc654300 != null && _0xbc654300.Content != null && this._lobby != null)
        {
            // The lobby art goes UNDER the template's PLAY button, which is the only child
            // this container has; the overlays go above everything (hierarchy = draw order).
            RectTransform _0x5e96811a = _0x2d485ba7.Stretch(_0xbc654300.Content.transform, _0x11e00f8b._0x67872657(new byte[12] { 105, 74, 95, 75, 86, 83, 85, 106, 73, 68, 68, 95 }, 38));
            _0x5e96811a.SetAsFirstSibling();
            this._lobby._0x52b89565(_0x5e96811a, this._art, this._playButton, this._overlays);
            if (this._overlays != null)
            {
                RectTransform _0xd6b53022 = _0x2d485ba7.Stretch(_0xbc654300.Content.transform, _0x11e00f8b._0x67872657(new byte[13] { 49, 18, 7, 19, 14, 11, 13, 45, 22, 27, 27, 10, 13 }, 126));
                _0xd6b53022.SetAsLastSibling();
                this._overlays._0xb3cb6a7b(_0xd6b53022, this._art);
            }
        }

        if (this._sweeper != null)
            this._sweeper._0x34214308();
    }

    [SerializeField]
    private _0xa4199123 _overlays;
    [SerializeField]
    private _0xb065bdca _splash;
    [SerializeField]
    private _0x8886c59a _lobby;
    // The template's own scene-loading button, resized to the §G.3 rect in the scene file.
    // The lobby builds its FACE as a child of this object, so the tap still reaches the
    // template driver and the menu never carries a second PLAY.
    [SerializeField]
    private RectTransform _playButton;
    [SerializeField]
    private _0x31f8b05c _art;
}

internal static class _0x11e00f8b
{
    internal static string _0x67872657(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}