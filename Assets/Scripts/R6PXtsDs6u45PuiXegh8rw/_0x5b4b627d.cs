using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The album of storms: nine symbols, three tiers each. A card shows the symbol, its name and a
// three-pip tier strip; a symbol with no shards yet is dimmed and reads ??? instead of a name.
public sealed class _0x5b4b627d : MonoBehaviour
{
    public void _0xe5ccb456()
    {
        if (!this._0xf1680d2a)
            return;
        _0xce074dd9 _0x4e5c5f6c = this._0x0c73e3d2 != null ? this._0x0c73e3d2._0x1f37b099 : null;
        int _0x1b92d185 = _0x4e5c5f6c != null ? _0x4e5c5f6c._0x7498f300 : 0;
        bool _0x39370286 = _0x1b92d185 <= 0;
        if (this._0x647cbe05 != null)
            this._0x647cbe05.gameObject.SetActive(!_0x39370286);
        if (this._0xf8003b1a != null)
            this._0xf8003b1a.gameObject.SetActive(_0x39370286);
        if (this._0x6c45697c != null)
            _0xac23041c.SetText(this._0x6c45697c, _0x1b92d185.ToString() + _0xbd933669._0xfe0b7c7f(new byte[1] { 126 }, 81) + _0x289589d1.ShardTotal.ToString() + _0xbd933669._0xfe0b7c7f(new byte[7] { 200, 187, 160, 169, 186, 172, 187 }, 232));
        for (int _0xbfeeef1c = 0; _0xbfeeef1c < _0x27cd1a19.SymbolCount; _0xbfeeef1c++)
        {
            int _0xda2dc6e0 = _0x4e5c5f6c != null ? _0x4e5c5f6c._0xf84acb46(_0xbfeeef1c) : 0;
            bool _0x7097ac76 = _0xda2dc6e0 != 0;
            if (this._0xb6ffd266[_0xbfeeef1c] != null)
                this._0xb6ffd266[_0xbfeeef1c].color = _0x7097ac76 ? Color.white : new Color(0.228f, 0.181f, 0.134f, 0.9f);
            if (this._0x66a63ff5[_0xbfeeef1c] != null)
            {
                _0xac23041c.SetText(this._0x66a63ff5[_0xbfeeef1c], _0x7097ac76 ? _0x27cd1a19.SymbolNames[_0xbfeeef1c] : _0xbd933669._0xfe0b7c7f(new byte[3] { 229, 229, 229 }, 218));
                this._0x66a63ff5[_0xbfeeef1c].color = _0x7097ac76 ? _0xc406d6f3.Cream : _0xc406d6f3.Muted;
            }

            this._0x37dd8336(_0xbfeeef1c, 0, (_0xda2dc6e0 & _0xce074dd9.TierBronze) != 0, _0xc406d6f3.Bronze);
            this._0x37dd8336(_0xbfeeef1c, 1, (_0xda2dc6e0 & _0xce074dd9.TierSilver) != 0, _0xc406d6f3.Silver);
            this._0x37dd8336(_0xbfeeef1c, 2, (_0xda2dc6e0 & _0xce074dd9.TierGold) != 0, _0xc406d6f3.Amber);
        }

        for (int _0x703ba7fb = 0; _0x703ba7fb < 3; _0x703ba7fb++)
        {
            bool _0xf8bfb29c = _0x4e5c5f6c != null && _0x4e5c5f6c._0x1911857e(_0x703ba7fb);
            if (this._0x2c020b03[_0x703ba7fb] != null)
                this._0x2c020b03[_0x703ba7fb].color = _0xf8bfb29c ? _0xc406d6f3.Alpha(_0xc406d6f3.Gold, 0.3f) : _0xc406d6f3.Locked;
            if (this._0xa59ac85a[_0x703ba7fb] == null)
                continue;
            _0xac23041c.SetText(this._0xa59ac85a[_0x703ba7fb], _0xf8bfb29c ? _0xbd933669._0xfe0b7c7f(new byte[8] { 174, 181, 183, 180, 184, 176, 190, 191 }, 251) : (_0xce074dd9.RoomThresholds[_0x703ba7fb + 1].ToString() + _0xbd933669._0xfe0b7c7f(new byte[7] { 136, 251, 224, 233, 250, 236, 251 }, 168)));
            this._0xa59ac85a[_0x703ba7fb].color = _0xf8bfb29c ? _0xc406d6f3.Amber : _0xc406d6f3.Muted;
        }
    }

    private void _0x37dd8336(int _0x5ea92a68, int _0x110660b0, bool _0x419e47dd, Color _0x07ee737e)
    {
        Image _0x6607602d = this._0x917d5995[(_0x5ea92a68 * 3) + _0x110660b0];
        if (_0x6607602d == null)
            return;
        _0x6607602d.color = _0x419e47dd ? _0x07ee737e : _0xc406d6f3.Locked;
    }

    private readonly TextMeshProUGUI[] _0x66a63ff5 = new TextMeshProUGUI[_0x27cd1a19.SymbolCount];
    private TextMeshProUGUI _0x6c45697c;
    private TextMeshProUGUI _0xf8003b1a;
    private readonly Image[] _0x2c020b03 = new Image[3];
    private bool _0xf1680d2a;
    public void _0x690c49a6(RectTransform _0x78c2b89c, _0x31f8b05c _0x63be2342, _0xa4199123 _0xa8fa75c1)
    {
        if (this._0xf1680d2a)
            return;
        this._0xf1680d2a = true;
        this._0x0c73e3d2 = _0xa8fa75c1;
        this._0x6c45697c = _0x2d485ba7.Label(_0x78c2b89c, _0xbd933669._0xfe0b7c7f(new byte[5] { 102, 74, 80, 75, 81 }, 37), new Vector2(0f, 492f), new Vector2(900f, 46f), _0x63be2342, _0xbd933669._0xfe0b7c7f(new byte[11] { 117, 106, 119, 114, 101, 22, 13, 4, 23, 1, 22 }, 69), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Gold, TextAlignmentOptions.Center);
        this._0x647cbe05 = _0x2d485ba7.Node(_0x78c2b89c, _0xbd933669._0xfe0b7c7f(new byte[4] { 229, 208, 203, 198 }, 162), new Vector2(0f, -10f), new Vector2((3f * CardSide) + (2f * Gap), (3f * CardSide) + (2f * Gap)));
        for (int _0x1296fbbb = 0; _0x1296fbbb < _0x27cd1a19.SymbolCount; _0x1296fbbb++)
        {
            int _0x36b373f7 = _0x1296fbbb / 3;
            int _0xb2dc146e = _0x1296fbbb % 3;
            float _0xd8c5499c = (_0xb2dc146e - 1) * (CardSide + Gap);
            float _0x64b28c65 = (1 - _0x36b373f7) * (CardSide + Gap);
            RectTransform _0x29461b40 = _0x2d485ba7.Node(this._0x647cbe05, _0xbd933669._0xfe0b7c7f(new byte[3] { 155, 177, 165 }, 200) + _0x1296fbbb.ToString(), new Vector2(_0xd8c5499c, _0x64b28c65), new Vector2(CardSide, CardSide));
            _0x2d485ba7.Plate(_0x29461b40, _0xbd933669._0xfe0b7c7f(new byte[4] { 221, 250, 248, 254 }, 155), Vector2.zero, new Vector2(CardSide, CardSide), _0x63be2342.Plate, _0xc406d6f3.PanelRaise, 26f);
            this._0xb6ffd266[_0x1296fbbb] = _0x2d485ba7.Picture(_0x29461b40, _0xbd933669._0xfe0b7c7f(new byte[4] { 92, 118, 122, 123 }, 21), new Vector2(0f, 46f), new Vector2(170f, 170f), _0x63be2342._0x988888bb(_0x1296fbbb));
            // Pips own their own gutter; the name column starts to the right of it, so the two
            // never overlap whatever the name's length (CLAUDE-unity.md C.25).
            for (int _0x318d0aa7 = 0; _0x318d0aa7 < 3; _0x318d0aa7++)
                this._0x917d5995[(_0x1296fbbb * 3) + _0x318d0aa7] = _0x2d485ba7.Plate(_0x29461b40, _0xbd933669._0xfe0b7c7f(new byte[3] { 181, 140, 149 }, 229) + _0x318d0aa7.ToString(), new Vector2(PipFirstX + (_0x318d0aa7 * PipStepX), -108f), new Vector2(22f, 22f), _0x63be2342.Plate, _0xc406d6f3.Locked, 11f);
            this._0x66a63ff5[_0x1296fbbb] = _0x2d485ba7.Label(_0x29461b40, _0xbd933669._0xfe0b7c7f(new byte[4] { 179, 156, 144, 152 }, 253), new Vector2(NameCentreX, -108f), new Vector2(NameWidth, 46f), _0x63be2342, _0x27cd1a19.SymbolNames[_0x1296fbbb], _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Right);
        }

        this._0xf8003b1a = _0x2d485ba7.Label(_0x78c2b89c, _0xbd933669._0xfe0b7c7f(new byte[5] { 160, 136, 149, 145, 156 }, 229), new Vector2(0f, -10f), new Vector2(980f, 120f), _0x63be2342, _0xbd933669._0xfe0b7c7f(new byte[36] { 71, 70, 93, 65, 64, 71, 78, 41, 92, 71, 69, 70, 74, 66, 76, 77, 41, 80, 76, 93, 3, 89, 69, 72, 80, 41, 93, 70, 41, 74, 70, 69, 69, 76, 74, 93 }, 9), 36f, 26f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        for (int _0x66119f13 = 0; _0x66119f13 < 3; _0x66119f13++)
        {
            float _0x696e2788 = (_0x66119f13 - 1) * 350f;
            RectTransform _0x5331995c = _0x2d485ba7.Node(_0x78c2b89c, _0xbd933669._0xfe0b7c7f(new byte[4] { 209, 236, 236, 238 }, 131) + _0x66119f13.ToString(), new Vector2(_0x696e2788, -590f), new Vector2(330f, 110f));
            this._0x2c020b03[_0x66119f13] = _0x2d485ba7.Plate(_0x5331995c, _0xbd933669._0xfe0b7c7f(new byte[4] { 151, 176, 178, 180 }, 209), Vector2.zero, new Vector2(330f, 110f), _0x63be2342.Plate, _0xc406d6f3.Locked, 24f);
            _0x2d485ba7.Label(_0x5331995c, _0xbd933669._0xfe0b7c7f(new byte[4] { 19, 60, 48, 56 }, 93), new Vector2(0f, 24f), new Vector2(310f, 40f), _0x63be2342, _0xce074dd9.RoomNames[_0x66119f13], 26f, 24f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
            this._0xa59ac85a[_0x66119f13] = _0x2d485ba7.Label(_0x5331995c, _0xbd933669._0xfe0b7c7f(new byte[5] { 214, 241, 228, 241, 224 }, 133), new Vector2(0f, -22f), new Vector2(310f, 38f), _0x63be2342, _0xbd933669._0xfe0b7c7f(new byte[6] { 156, 159, 147, 155, 149, 148 }, 208), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        }

        _0x2d485ba7.Label(_0x78c2b89c, _0xbd933669._0xfe0b7c7f(new byte[10] { 163, 143, 141, 144, 140, 137, 129, 142, 131, 133 }, 224), new Vector2(0f, -690f), new Vector2(980f, 44f), _0x63be2342, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
    }

    private readonly Image[] _0x917d5995 = new Image[_0x27cd1a19.SymbolCount * 3];
    // The pip gutter spans x -131..-53; the name column starts at -29, i.e. 24 units clear of
    // it, so a long name can never run under a pip (CLAUDE-unity.md C.25).
    private const float PipFirstX = -120f;
    private _0xa4199123 _0x0c73e3d2;
    private const float NameCentreX = 56f;
    private const float NameWidth = 160f;
    private readonly Image[] _0xb6ffd266 = new Image[_0x27cd1a19.SymbolCount];
    private readonly TextMeshProUGUI[] _0xa59ac85a = new TextMeshProUGUI[3];
    private RectTransform _0x647cbe05;
    public const float CardSide = 320f;
    public const float Gap = 24f;
    private const float PipStepX = 28f;
}

internal static class _0xbd933669
{
    internal static string _0xfe0b7c7f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}