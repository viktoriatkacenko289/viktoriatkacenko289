using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The three lobby sheets - the daily offering, the album and the house rules. The menu scene
// registers no pops of its own (its --- Pops --- group is empty), so these are OUR objects held
// by serialized references: codegen reliably controls only what it created itself.
// Each overlay is built once, kept inactive, and raised by its own open method; the sheet that
// is open is always closed by its OWN cross, never by the lobby's.
public sealed class _0xa4199123 : MonoBehaviour
{
    // Built as the LAST children of the lobby host, so every sheet draws above the lobby
    // itself (hierarchy order is the only draw order UGUI has).
    public void _0xb3cb6a7b(RectTransform _0x7dda93ed, _0x31f8b05c _0x65ecec48)
    {
        if (this._0x733c19c7)
            return;
        this._0x733c19c7 = true;
        this._0xc4bdbced = _0x65ecec48;
        RectTransform _0x26a0e16b = this._0x0cedd0f9(_0x7dda93ed, _0xba977312._0x49225f8c(new byte[17] { 237, 200, 192, 197, 208, 235, 198, 199, 220, 218, 230, 223, 204, 219, 197, 200, 208 }, 169), _0xba977312._0x49225f8c(new byte[18] { 64, 92, 81, 52, 80, 85, 93, 88, 77, 52, 91, 82, 82, 81, 70, 93, 90, 83 }, 20), _0xba977312._0x49225f8c(new byte[36] { 150, 151, 156, 249, 154, 149, 152, 144, 148, 249, 156, 152, 154, 145, 249, 157, 152, 128, 249, 244, 249, 159, 144, 154, 141, 144, 150, 151, 152, 149, 249, 154, 150, 144, 151, 138 }, 217), out this._0xb6ee4721);
        if (this._bonus != null)
            this._bonus._0x3858019e(_0x26a0e16b, _0x65ecec48, this);
        RectTransform _0x5d9b4b86 = this._0x0cedd0f9(_0x7dda93ed, _0xba977312._0x49225f8c(new byte[17] { 99, 79, 76, 76, 69, 67, 84, 73, 79, 78, 111, 86, 69, 82, 76, 65, 89 }, 32), _0xba977312._0x49225f8c(new byte[19] { 237, 241, 252, 153, 248, 245, 251, 236, 244, 153, 246, 255, 153, 234, 237, 246, 235, 244, 234 }, 185), _0xba977312._0x49225f8c(new byte[28] { 178, 187, 161, 166, 212, 187, 178, 212, 181, 212, 191, 189, 186, 176, 212, 177, 181, 166, 186, 167, 212, 181, 212, 167, 188, 181, 166, 176 }, 244), out this._0x5df1efe2);
        if (this._album != null)
            this._album._0x690c49a6(_0x5d9b4b86, _0x65ecec48, this);
        RectTransform _0x087ce7f0 = this._0x0cedd0f9(_0x7dda93ed, _0xba977312._0x49225f8c(new byte[17] { 92, 123, 97, 103, 113, 70, 97, 120, 113, 103, 91, 98, 113, 102, 120, 117, 109 }, 20), _0xba977312._0x49225f8c(new byte[11] { 17, 22, 12, 10, 28, 121, 11, 12, 21, 28, 10 }, 89), _0xba977312._0x49225f8c(new byte[33] { 225, 242, 225, 246, 253, 132, 247, 243, 237, 240, 231, 236, 132, 231, 236, 229, 234, 227, 225, 247, 132, 243, 236, 229, 240, 132, 253, 235, 241, 132, 247, 225, 225 }, 164), out this._0x020b64cf);
        if (this._settings != null)
            this._settings._0x8a1c4d6c(_0x087ce7f0, _0x65ecec48, this);
    }

    [SerializeField]
    private _0x8886c59a _sheet;
    public void _0x8536aa39()
    {
        if (this._settings != null)
            this._settings._0xba0e6de2();
        this._0xf4626cee(this._0x020b64cf);
    }

    private RectTransform _0xb6ee4721;
    [SerializeField]
    private _0xce074dd9 _ledger;
    public void _0x25f764c8()
    {
        if (this._album != null)
            this._album._0xe5ccb456();
        this._0xf4626cee(this._0x5df1efe2);
    }

    public _0xce074dd9 _0x1f37b099
    {
        get
        {
            return this._ledger;
        }
    }

    private bool _0x733c19c7;
    public void _0xf363f21e()
    {
        this._0x08e11339(this._0xb6ee4721);
        this._0x08e11339(this._0x5df1efe2);
        this._0x08e11339(this._0x020b64cf);
        if (this._sheet != null)
            this._sheet._0x786db210();
    }

    public void _0xda73ade9()
    {
        if (this._bonus != null)
            this._bonus._0xd1eda6a6();
        this._0xf4626cee(this._0xb6ee4721);
    }

    public const float CrossInset = 70f;
    private _0x31f8b05c _0xc4bdbced;
    [SerializeField]
    private _0xdfb0a4c5 _bonus;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    // Dim + framed card + header + its own close cross. Returns the card to fill.
    private RectTransform _0x0cedd0f9(RectTransform _0x9d39918f, string _0x2cd54c45, string _0x705fd154, string _0x149bd17d, out RectTransform _0x8abf1879)
    {
        _0x8abf1879 = _0x2d485ba7.Stretch(_0x9d39918f, _0x2cd54c45);
        Button _0xa14a236d = _0x2d485ba7.Shade(_0x8abf1879, _0xba977312._0x49225f8c(new byte[3] { 81, 124, 120 }, 21), _0xc406d6f3.Alpha(_0xc406d6f3.DeepInk, 0.7f));
        _0xa14a236d.onClick.AddListener(() => this._0xf363f21e());
        RectTransform _0x22175942 = _0x2d485ba7.Node(_0x8abf1879, _0xba977312._0x49225f8c(new byte[4] { 237, 207, 220, 202 }, 174), Vector2.zero, new Vector2(CardWidth, CardHeight));
        _0x2d485ba7.Plate(_0x22175942, _0xba977312._0x49225f8c(new byte[4] { 225, 218, 221, 212 }, 179), Vector2.zero, new Vector2(CardWidth, CardHeight), this._0xc4bdbced.Plate, _0xc406d6f3.Gold, 36f);
        _0x2d485ba7.Plate(_0x22175942, _0xba977312._0x49225f8c(new byte[4] { 43, 12, 14, 8 }, 109), Vector2.zero, new Vector2(CardWidth - 16f, CardHeight - 16f), this._0xc4bdbced.Plate, _0xc406d6f3.Panel, 32f);
        _0x2d485ba7.Plate(_0x22175942, _0xba977312._0x49225f8c(new byte[5] { 107, 80, 93, 93, 86 }, 56), new Vector2(0f, 470f), new Vector2(CardWidth - 140f, 3f), this._0xc4bdbced.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.GoldLight, 0.4f), 2f);
        _0x2d485ba7.Label(_0x22175942, _0xba977312._0x49225f8c(new byte[6] { 131, 174, 170, 175, 174, 185 }, 203), new Vector2(0f, 640f), new Vector2(900f, 110f), this._0xc4bdbced, _0x705fd154, 64f, 40f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
        _0x2d485ba7.Label(_0x22175942, _0xba977312._0x49225f8c(new byte[3] { 76, 106, 125 }, 31), new Vector2(0f, 553f), new Vector2(940f, 48f), this._0xc4bdbced, _0x149bd17d, _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        // Our own cross sprite: the template's close Image carries no sprite at all, which
        // Unity draws as a solid white rectangle (CLAUDE-unity.md B.1 / C.3).
        Button _0x382d16ba = _0x2d485ba7.IconAction(_0x22175942, _0xba977312._0x49225f8c(new byte[11] { 179, 156, 159, 131, 149, 177, 147, 132, 153, 159, 158 }, 240), new Vector2((CardWidth * 0.5f) - CrossInset, (CardHeight * 0.5f) - CrossInset), 104f, this._0xc4bdbced, this._0xc4bdbced.IconClose, _0xc406d6f3.PanelRaise, 24f);
        _0x382d16ba.onClick.AddListener(() => this._0xf363f21e());
        _0x8abf1879.gameObject.SetActive(false);
        return _0x22175942;
    }

    public _0x8886c59a _0xbfc63296
    {
        get
        {
            return this._sheet;
        }
    }

    [SerializeField]
    private _0xc7929e6b _wallet;
    private void _0x08e11339(RectTransform _0xec1c84c5)
    {
        if (_0xec1c84c5 == null || !_0xec1c84c5.gameObject.activeSelf)
            return;
        Transform _0x1f1253d2 = _0xec1c84c5.childCount > 1 ? _0xec1c84c5.GetChild(1) : null;
        if (_0x1f1253d2 != null)
            DOTween.Kill(_0x1f1253d2);
        _0xec1c84c5.gameObject.SetActive(false);
    }

    [SerializeField]
    private _0x5b4b627d _album;
    public const float CardWidth = 1120f;
    public const float CardHeight = 1500f;
    private RectTransform _0x020b64cf;
    public _0xc7929e6b _0xb46fc652
    {
        get
        {
            return this._wallet;
        }
    }

    private void _0xf4626cee(RectTransform _0xd2d94758)
    {
        if (_0xd2d94758 == null)
            return;
        this._0x08e11339(this._0xb6ee4721);
        this._0x08e11339(this._0x5df1efe2);
        this._0x08e11339(this._0x020b64cf);
        _0xd2d94758.gameObject.SetActive(true);
        _0xd2d94758.SetAsLastSibling();
        Transform _0x5306ef9d = _0xd2d94758.childCount > 1 ? _0xd2d94758.GetChild(1) : null;
        if (_0x5306ef9d == null)
            return;
        _0x5306ef9d.localScale = Vector3.one * 0.94f;
        _0x5306ef9d.DOScale(1f, 0.24f).SetEase(Ease.OutBack).SetLink(_0x5306ef9d.gameObject);
    }

    [SerializeField]
    private _0x0acfd169 _settings;
    private RectTransform _0x5df1efe2;
}

internal static class _0xba977312
{
    internal static string _0x49225f8c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}