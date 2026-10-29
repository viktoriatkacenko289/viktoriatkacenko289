using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The daily offering: a seven-day ladder of FICTIONAL coins. Nothing here is purchasable and
// nothing is redeemable - the only way coins enter the purse is play and this grant.
public sealed class _0xdfb0a4c5 : MonoBehaviour
{
    private bool _0xaca23379;
    private readonly Image[] _0x9d000f2e = new Image[Days];
    public const int Days = 7;
    private TextMeshProUGUI _0x9f8cf358;
    private int _0x1f3fb10d()
    {
        return Mathf.Clamp(_0x289589d1._0xf08ea6bb, 0, Days - 1);
    }

    private void _0x9f0f3c41()
    {
        if (!this._0x4b7f5771())
            return;
        int _0x5bfcc40e = this._0x1f3fb10d();
        _0x289589d1._0x09211c8d = _0x289589d1.Today();
        _0x289589d1._0xf08ea6bb = (_0x5bfcc40e + 1) % Days;
        if (this._0x4a85e0a6 != null && this._0x4a85e0a6._0xb46fc652 != null)
            this._0x4a85e0a6._0xb46fc652.Add(_0x54e2a280[_0x5bfcc40e]);
        if (this._0x4a85e0a6 != null && this._0x4a85e0a6._0xbfc63296 != null)
        {
            this._0x4a85e0a6._0xbfc63296._0x786db210();
            this._0x4a85e0a6._0xbfc63296._0x996066bc();
        }

        if (this._0x209a97b3 != null)
        {
            DOTween.Kill(this._0x209a97b3);
            this._0x209a97b3.localScale = Vector3.one;
            Sequence _0x9eb3fab0 = DOTween.Sequence().SetLink(this._0x209a97b3.gameObject);
            _0x9eb3fab0.Append(this._0x209a97b3.DOScale(1.14f, 0.14f).SetEase(Ease.OutQuad));
            _0x9eb3fab0.Append(this._0x209a97b3.DOScale(1f, 0.18f).SetEase(Ease.InQuad));
        }

        this._0xd1eda6a6();
    }

    private readonly TextMeshProUGUI[] _0x35b53726 = new TextMeshProUGUI[Days];
    public void _0xd1eda6a6()
    {
        if (!this._0xaca23379)
            return;
        int _0xf359c924 = this._0x1f3fb10d();
        bool _0x2e800f27 = this._0x4b7f5771();
        for (int _0x75c7c874 = 0; _0x75c7c874 < Days; _0x75c7c874++)
        {
            bool _0x4978dfd5 = _0x75c7c874 < _0xf359c924 || (_0x75c7c874 == _0xf359c924 && !_0x2e800f27);
            bool _0xd7a160c4 = _0x75c7c874 == _0xf359c924 && _0x2e800f27;
            Color _0x2e6181a8 = _0x4978dfd5 ? _0xc406d6f3.PanelSink : (_0xd7a160c4 ? _0xc406d6f3.Alpha(_0xc406d6f3.Ember, 0.35f) : _0xc406d6f3.PanelRaise);
            if (this._0x6bcf1b1f[_0x75c7c874] != null)
                this._0x6bcf1b1f[_0x75c7c874].color = _0x2e6181a8;
            if (this._0x9d000f2e[_0x75c7c874] != null)
                this._0x9d000f2e[_0x75c7c874].color = _0x4978dfd5 ? _0xc406d6f3.Gold : (_0xd7a160c4 ? _0xc406d6f3.Amber : _0xc406d6f3.Locked);
            if (this._0x35b53726[_0x75c7c874] != null)
                _0xac23041c.SetText(this._0x35b53726[_0x75c7c874], _0x4978dfd5 ? _0x8e6ece8a._0x6bb4e6b6(new byte[1] { 8 }, 35) : (_0x75c7c874 + 1).ToString());
            if (this._0xf0c4d0ed[_0x75c7c874] != null)
                this._0xf0c4d0ed[_0x75c7c874].color = _0x4978dfd5 ? _0xc406d6f3.Muted : (_0xd7a160c4 ? _0xc406d6f3.Amber : _0xc406d6f3.CreamDim);
        }

        _0xac23041c.SetText(this._0x9f8cf358, _0x2e800f27 ? _0x8e6ece8a._0x6bb4e6b6(new byte[23] { 173, 182, 189, 184, 160, 217, 176, 170, 217, 171, 188, 184, 189, 160, 217, 173, 182, 217, 186, 181, 184, 176, 180 }, 249) : _0x8e6ece8a._0x6bb4e6b6(new byte[27] { 252, 240, 242, 250, 159, 253, 254, 252, 244, 159, 235, 240, 242, 240, 237, 237, 240, 232, 159, 249, 240, 237, 159, 242, 240, 237, 250 }, 191));
        if (this._0x335994fd != null)
            _0xac23041c.SetText(this._0x335994fd, _0x2e800f27 ? _0x8e6ece8a._0x6bb4e6b6(new byte[5] { 138, 133, 136, 128, 132 }, 201) : _0x8e6ece8a._0x6bb4e6b6(new byte[18] { 224, 236, 238, 230, 131, 225, 226, 224, 232, 131, 247, 236, 238, 236, 241, 241, 236, 244 }, 163));
        if (this._0x0869f383 != null)
            this._0x0869f383.interactable = _0x2e800f27;
    }

    public void _0x3858019e(RectTransform _0xa6e9612d, _0x31f8b05c _0xfae81a04, _0xa4199123 _0x78a83994)
    {
        if (this._0xaca23379)
            return;
        this._0xaca23379 = true;
        this._0x323181dd = _0xfae81a04;
        this._0x4a85e0a6 = _0x78a83994;
        this._0x209a97b3 = _0x2d485ba7.Picture(_0xa6e9612d, _0x8e6ece8a._0x6bb4e6b6(new byte[3] { 75, 108, 112 }, 30), new Vector2(0f, 330f), new Vector2(300f, 300f), _0xfae81a04.UrnBonus).rectTransform;
        for (int _0x64a8c09b = 0; _0x64a8c09b < Days; _0x64a8c09b++)
        {
            int _0x0bf08e37 = _0x64a8c09b < 4 ? 0 : 1;
            int _0x76a91ee2 = _0x64a8c09b < 4 ? _0x64a8c09b : _0x64a8c09b - 4;
            int _0x1ab11b3a = _0x0bf08e37 == 0 ? 4 : 3;
            float _0x62cc13b8 = (_0x1ab11b3a * TileWidth) + ((_0x1ab11b3a - 1) * 20f);
            float _0xbb205a53 = (-_0x62cc13b8 * 0.5f) + (TileWidth * 0.5f) + (_0x76a91ee2 * (TileWidth + 20f));
            float _0xdea79ae2 = _0x0bf08e37 == 0 ? 60f : -120f;
            RectTransform _0x111cf13f = _0x2d485ba7.Node(_0xa6e9612d, _0x8e6ece8a._0x6bb4e6b6(new byte[3] { 34, 7, 31 }, 102) + (_0x64a8c09b + 1).ToString(), new Vector2(_0xbb205a53, _0xdea79ae2), new Vector2(TileWidth, TileHeight));
            this._0x6bcf1b1f[_0x64a8c09b] = _0x2d485ba7.Plate(_0x111cf13f, _0x8e6ece8a._0x6bb4e6b6(new byte[4] { 7, 32, 34, 36 }, 65), Vector2.zero, new Vector2(TileWidth, TileHeight), _0xfae81a04.Plate, _0xc406d6f3.PanelRaise, 22f);
            // The day badge owns the gutter; the amount column starts clear of it, so an
            // indicator and a text never share one x-band (CLAUDE-unity.md C.25).
            this._0x9d000f2e[_0x64a8c09b] = _0x2d485ba7.Plate(_0x111cf13f, _0x8e6ece8a._0x6bb4e6b6(new byte[5] { 101, 70, 67, 64, 66 }, 39), new Vector2(-86f, 0f), new Vector2(56f, 56f), _0xfae81a04.Plate, _0xc406d6f3.Locked, 28f);
            this._0x35b53726[_0x64a8c09b] = _0x2d485ba7.Label(_0x111cf13f, _0x8e6ece8a._0x6bb4e6b6(new byte[5] { 155, 190, 166, 145, 176 }, 223), new Vector2(-86f, 0f), new Vector2(52f, 44f), _0xfae81a04, (_0x64a8c09b + 1).ToString(), 30f, 24f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
            this._0xf0c4d0ed[_0x64a8c09b] = _0x2d485ba7.Label(_0x111cf13f, _0x8e6ece8a._0x6bb4e6b6(new byte[6] { 16, 60, 62, 36, 63, 37 }, 81), new Vector2(38f, 0f), new Vector2(144f, 60f), _0xfae81a04, _0xc406d6f3.Coins(_0x54e2a280[_0x64a8c09b]), 40f, 24f, _0xc406d6f3.Amber, TextAlignmentOptions.Center);
        }

        this._0x9f8cf358 = _0x2d485ba7.Label(_0xa6e9612d, _0x8e6ece8a._0x6bb4e6b6(new byte[6] { 253, 218, 207, 218, 219, 221 }, 174), new Vector2(0f, -240f), new Vector2(980f, 48f), _0xfae81a04, _0x8e6ece8a._0x6bb4e6b6(new byte[23] { 167, 188, 183, 178, 170, 211, 186, 160, 211, 161, 182, 178, 183, 170, 211, 167, 188, 211, 176, 191, 178, 186, 190 }, 243), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        this._0x0869f383 = _0x2d485ba7.Action(_0xa6e9612d, _0x8e6ece8a._0x6bb4e6b6(new byte[11] { 216, 247, 250, 242, 246, 218, 248, 239, 242, 244, 245 }, 155), new Vector2(0f, -370f), new Vector2(760f, 160f), _0xfae81a04, _0x8e6ece8a._0x6bb4e6b6(new byte[5] { 196, 203, 198, 206, 202 }, 135), _0xc406d6f3.SizeButton + 10f, _0xc406d6f3.Ember, _0xc406d6f3.Cream, 32f);
        this._0x0869f383.onClick.AddListener(() => this._0x9f0f3c41());
        this._0x335994fd = this._0x0869f383.GetComponentInChildren<TextMeshProUGUI>();
        _0x2d485ba7.Label(_0xa6e9612d, _0x8e6ece8a._0x6bb4e6b6(new byte[10] { 94, 114, 112, 109, 113, 116, 124, 115, 126, 120 }, 29), new Vector2(0f, -600f), new Vector2(980f, 44f), _0xfae81a04, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
    }

    public const float TileHeight = 160f;
    private readonly TextMeshProUGUI[] _0xf0c4d0ed = new TextMeshProUGUI[Days];
    private bool _0x4b7f5771()
    {
        return _0x289589d1._0x09211c8d != _0x289589d1.Today();
    }

    private readonly Image[] _0x6bcf1b1f = new Image[Days];
    private _0x31f8b05c _0x323181dd;
    private _0xa4199123 _0x4a85e0a6;
    private static readonly int[] _0x54e2a280 =
    {
        500,
        750,
        1000,
        1500,
        2500,
        4000,
        7500
    };
    public const float TileWidth = 240f;
    private RectTransform _0x209a97b3;
    private TextMeshProUGUI _0x335994fd;
    private Button _0x0869f383;
    private void OnDestroy()
    {
        if (this._0x209a97b3 != null)
            DOTween.Kill(this._0x209a97b3);
        DOTween.Kill(this.gameObject);
    }
}

internal static class _0x8e6ece8a
{
    internal static string _0x6bb4e6b6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}