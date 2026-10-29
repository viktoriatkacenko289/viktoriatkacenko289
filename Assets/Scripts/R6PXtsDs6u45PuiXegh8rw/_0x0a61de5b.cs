using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The reel frame: five columns under a mask, the metal trim, and the payline flashes.
// Geometry is derived from the frame rect, never eyeballed - outer 1128x784 with a 34 trim
// gives a 1060x716 window; 5 columns with four 10-unit gutters give a 204 cell, 3 rows with two
// give 232 (CLAUDE-unity.md C.0 applied to UGUI).
public sealed class _0x0a61de5b : MonoBehaviour
{
    private readonly List<Image> _0xf6c0bebc = new List<Image>();
    // Builds the frame INTO `host`. The trim and the column backdrops are created BEFORE the
    // symbols, so nothing opaque can ever be drawn on top of them (CLAUDE-unity.md C.13).
    public void _0xc2c5fba3(RectTransform _0x0c3efebc, _0x31f8b05c _0x165e40c7, _0xa4ea1eef _0x7e51ee73, int[][] _0x4061b2e2, int[] _0x55a33afc)
    {
        this._0x930b0c7c = _0x165e40c7;
        this._0x6cce84cc = _0x4061b2e2;
        RectTransform _0x83a21205 = _0x2d485ba7.Node(_0x0c3efebc, _0x88c5df5c._0xd699a799(new byte[10] { 199, 240, 240, 249, 194, 252, 251, 241, 250, 226 }, 149), Vector2.zero, new Vector2(this._0x0a5b925e, FrameHeight - (Trim * 2f)));
        _0x83a21205.gameObject.AddComponent<RectMask2D>();
        this._0x286f42c2 = _0x83a21205;
        float _0xfd8b03fe = this._0xa9136586;
        float _0xda2813b8 = (-this._0x0a5b925e * 0.5f) + (_0xfd8b03fe * 0.5f);
        for (int _0x2e1802e6 = 0; _0x2e1802e6 < _0x27cd1a19.Reels; _0x2e1802e6++)
        {
            float _0x7224efcc = _0xda2813b8 + (_0x2e1802e6 * (_0xfd8b03fe + Gutter));
            _0xa4ea1eef _0xaac64ccc = Instantiate(_0x7e51ee73, _0x83a21205, false);
            _0xaac64ccc.name = _0x88c5df5c._0xd699a799(new byte[4] { 141, 186, 186, 179 }, 223) + _0x2e1802e6.ToString();
            RectTransform _0x07f3105f = _0xaac64ccc._0x970b9aab;
            if (_0x07f3105f != null)
            {
                _0x07f3105f.anchorMin = new Vector2(0.5f, 0.5f);
                _0x07f3105f.anchorMax = new Vector2(0.5f, 0.5f);
                _0x07f3105f.anchoredPosition = new Vector2(_0x7224efcc, 0f);
                _0x07f3105f.sizeDelta = new Vector2(_0xfd8b03fe, FrameHeight - (Trim * 2f));
            }

            _0xaac64ccc._0xda06bbdb(_0x165e40c7, _0x4061b2e2[_0x2e1802e6], _0x55a33afc[_0x2e1802e6]);
            this._0x9d347e26[_0x2e1802e6] = _0xaac64ccc;
        }

        // Payline bars live ABOVE the symbols on purpose: they are thin, low-alpha highlights,
        // which is the one thing C.13 allows over content.
        for (int _0x2b9da2f6 = 0; _0x2b9da2f6 < _0x27cd1a19.Paylines.Length; _0x2b9da2f6++)
        {
            Image _0xabd7a598 = _0x2d485ba7.Plate(_0x83a21205, _0x88c5df5c._0xd699a799(new byte[4] { 195, 230, 225, 234 }, 143) + _0x2b9da2f6.ToString(), Vector2.zero, new Vector2(this._0x0a5b925e, 6f), _0x165e40c7.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0f), 3f);
            this._0xf6c0bebc.Add(_0xabd7a598);
        }

        // The metal trim is a 9-sliced frame with a transparent centre, created AFTER the mask
        // but OUTSIDE it, so it rims the window instead of covering it.
        RectTransform _0x70811dd0 = _0x2d485ba7.Node(_0x0c3efebc, _0x88c5df5c._0xd699a799(new byte[8] { 95, 104, 104, 97, 89, 127, 100, 96 }, 13), Vector2.zero, new Vector2(FrameWidth, FrameHeight));
        Image _0xaf22e4d0 = _0x70811dd0.gameObject.AddComponent<Image>();
        _0xaf22e4d0.sprite = _0x165e40c7.FrameReel;
        _0xaf22e4d0.type = Image.Type.Sliced;
        _0xaf22e4d0.pixelsPerUnitMultiplier = 1.4f;
        // Only the 9-slice BORDER is drawn: whatever the generated PNG has in its middle, the
        // trim can never cover the symbols it rims (CLAUDE-unity.md C.13).
        _0xaf22e4d0.fillCenter = false;
        _0xaf22e4d0.color = Color.white;
        _0xaf22e4d0.raycastTarget = false;
        this._0x63dd3780 = _0xaf22e4d0;
    }

    private Image _0x63dd3780;
    public void _0xecf517e2(_0x27cd1a19._0x9c1f3a9c _0xf5525296, bool _0x9ff4dfd1)
    {
        if (_0xf5525296 == null)
            return;
        this._0xb44dcf40();
        for (int _0xa9d789ff = 0; _0xa9d789ff < _0xf5525296.Lines.Count && _0xa9d789ff < this._0xf6c0bebc.Count; _0xa9d789ff++)
        {
            _0x27cd1a19._0x4113515c _0xb5d0b1bb = _0xf5525296.Lines[_0xa9d789ff];
            int[] _0xc4ab43f8 = _0x27cd1a19.Paylines[_0xb5d0b1bb.Line];
            Image _0x93125ec8 = this._0xf6c0bebc[_0xa9d789ff];
            float _0x8741303f = 0f;
            for (int _0x0f1ad342 = 0; _0x0f1ad342 < _0xb5d0b1bb.Length; _0x0f1ad342++)
                _0x8741303f += _0xa4ea1eef.CellPitch - (_0xc4ab43f8[_0x0f1ad342] * _0xa4ea1eef.CellPitch);
            _0x8741303f /= Mathf.Max(1, _0xb5d0b1bb.Length);
            _0x93125ec8.rectTransform.anchoredPosition = new Vector2(0f, _0x8741303f);
            DOTween.Kill(_0x93125ec8);
            _0x93125ec8.color = _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0f);
            Sequence _0xdd14fc71 = DOTween.Sequence().SetLink(_0x93125ec8.gameObject);
            _0xdd14fc71.Append(_0x93125ec8.DOFade(0.85f, 0.3f));
            _0xdd14fc71.Append(_0x93125ec8.DOFade(0f, 0.6f));
            if (_0x9ff4dfd1)
                continue;
            for (int _0x4f7f2637 = 0; _0x4f7f2637 < _0xb5d0b1bb.Length; _0x4f7f2637++)
            {
                _0xbc83cefe _0x3f1d6416 = this._0x9d347e26[_0x4f7f2637] != null ? this._0x9d347e26[_0x4f7f2637]._0x31c15825(_0xc4ab43f8[_0x4f7f2637]) : null;
                if (_0x3f1d6416 != null)
                    _0x3f1d6416._0x3fc7bc7c(_0x4f7f2637 * 0.06f);
            }
        }
    }

    public const float Trim = 34f;
    // Reels start together and stop left to right on their own clock - there is no tap-to-stop
    // and no reaction window anywhere in this game.
    public void _0xd16b2526(int[] _0xd8578e82, bool _0xf8d74027, System.Action _0x7f6aeda9)
    {
        this._0x9ff40dc6 = _0x7f6aeda9;
        this._0xb44dcf40();
        float _0x866a164c = _0xf8d74027 ? 0.45f : 0.85f;
        float _0xa10ab523 = _0xf8d74027 ? 0.10f : 0.20f;
        float _0x921434f7 = _0xf8d74027 ? 0.12f : 0.18f;
        for (int _0x89ee8229 = 0; _0x89ee8229 < _0x27cd1a19.Reels; _0x89ee8229++)
        {
            _0xa4ea1eef _0x758c17a2 = this._0x9d347e26[_0x89ee8229];
            if (_0x758c17a2 == null)
                continue;
            _0x758c17a2._0x1949823e(_0xd8578e82[_0x89ee8229], 3 + _0x89ee8229, _0x866a164c + (_0x89ee8229 * _0xa10ab523), _0x921434f7);
        }

        float _0xdc7ea15b = _0x866a164c + ((_0x27cd1a19.Reels - 1) * _0xa10ab523) + _0x921434f7 + 0.05f;
        DOVirtual.DelayedCall(_0xdc7ea15b, () => this._0x19007b70()).SetLink(this.gameObject);
    }

    private int[][] _0x6cce84cc;
    public const float Gutter = 10f;
    private RectTransform _0x286f42c2;
    private _0x31f8b05c _0x930b0c7c;
    private readonly _0xa4ea1eef[] _0x9d347e26 = new _0xa4ea1eef[_0x27cd1a19.Reels];
    public const float FrameWidth = 1128f;
    public float _0xa9136586
    {
        get
        {
            return (this._0x0a5b925e - (Gutter * (_0x27cd1a19.Reels - 1))) / _0x27cd1a19.Reels;
        }
    }

    public void _0x7eb56f0e(int[] _0x08c221e2)
    {
        for (int _0x80cf7fcb = 0; _0x80cf7fcb < _0x27cd1a19.Reels; _0x80cf7fcb++)
            if (this._0x9d347e26[_0x80cf7fcb] != null)
                this._0x9d347e26[_0x80cf7fcb]._0x02e73bfd(_0x08c221e2[_0x80cf7fcb]);
    }

    private System.Action _0x9ff40dc6;
    private void OnDestroy()
    {
        for (int _0x5308c054 = 0; _0x5308c054 < this._0xf6c0bebc.Count; _0x5308c054++)
            if (this._0xf6c0bebc[_0x5308c054] != null)
                DOTween.Kill(this._0xf6c0bebc[_0x5308c054]);
        if (this._0x63dd3780 != null)
            DOTween.Kill(this._0x63dd3780);
        DOTween.Kill(this.gameObject);
    }

    public float _0x0a5b925e
    {
        get
        {
            return FrameWidth - (Trim * 2f);
        }
    }

    public void _0x6ebb08b1(int[][] _0x40627db4)
    {
        this._0x6cce84cc = _0x40627db4;
        for (int _0x705b1d7e = 0; _0x705b1d7e < _0x27cd1a19.Reels; _0x705b1d7e++)
            if (this._0x9d347e26[_0x705b1d7e] != null)
                this._0x9d347e26[_0x705b1d7e]._0xfc723eab(_0x40627db4[_0x705b1d7e]);
    }

    public const float FrameHeight = 784f;
    private void _0x19007b70()
    {
        if (this._0x9ff40dc6 != null)
            this._0x9ff40dc6.Invoke();
    }

    public void _0x72e49720(Color _0x67a73729)
    {
        if (this._0x63dd3780 == null)
            return;
        DOTween.Kill(this._0x63dd3780);
        this._0x63dd3780.DOColor(_0x67a73729, 0.35f).SetLink(this._0x63dd3780.gameObject);
    }

    private void _0xb44dcf40()
    {
        for (int _0x88d16235 = 0; _0x88d16235 < this._0xf6c0bebc.Count; _0x88d16235++)
        {
            Image _0xae6e2d73 = this._0xf6c0bebc[_0x88d16235];
            if (_0xae6e2d73 == null)
                continue;
            DOTween.Kill(_0xae6e2d73);
            _0xae6e2d73.color = _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0f);
        }
    }
}

internal static class _0x88c5df5c
{
    internal static string _0xd699a799(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}