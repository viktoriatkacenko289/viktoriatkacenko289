using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Dresses the three template pops - Win 7, Lose 8, Pause 6 - completely. Every child the
// template put inside a pop's Content is switched off and this game's own card is built in its
// place, which removes the template's captions, its Score:/Reward: labels and the close button
// with no sprite (Unity draws that one as a solid WHITE RECTANGLE) by construction
// (CLAUDE-unity.md B.1, C.3, C.17).
public sealed class _0x7314f138 : MonoBehaviour
{
    private TextMeshProUGUI _0x2b86364f;
    // A pop the capture lands on must never park the run: if the player's tap misses the
    // button, the card releases itself.
    private void _0x9f9f19bb(System.Action _0x88110fac)
    {
        if (this._0x209ce6f3 != null)
            this._0x209ce6f3.Kill();
        this._0x209ce6f3 = DOVirtual.DelayedCall(ReleaseSeconds, () => _0x88110fac.Invoke()).SetLink(this.gameObject);
    }

    private TextMeshProUGUI _0xdd05e7f9;
    public void _0x5732c3c9(int payout, string _0xac41c3f8)
    {
        if (!this._0xc47672dd)
            return;
        _0x411dd6a7 _0x62e56167 = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.WIN);
        if (_0x62e56167 == null)
            return;
        _0xac23041c.SetText(this._0xc7094736, _0xa6ad08d6._0x62bd8ebc(new byte[16] { 196, 216, 213, 176, 196, 194, 217, 209, 220, 176, 217, 195, 176, 199, 223, 222 }, 144));
        _0xac23041c.SetText(this._0x2b86364f, _0xa6ad08d6._0x62bd8ebc(new byte[1] { 40 }, 3) + _0xc406d6f3.Coins(payout) + _0xa6ad08d6._0x62bd8ebc(new byte[6] { 245, 150, 154, 156, 155, 134 }, 213));
        _0xac23041c.SetText(this._0x28f71569, string.IsNullOrEmpty(_0xac41c3f8) ? _0xa6ad08d6._0x62bd8ebc(new byte[21] { 0, 13, 13, 97, 12, 8, 18, 18, 8, 14, 15, 18, 97, 2, 14, 12, 17, 13, 4, 21, 4 }, 65) : _0xac41c3f8 + _0xa6ad08d6._0x62bd8ebc(new byte[22] { 95, 20, 25, 25, 117, 24, 28, 6, 6, 28, 26, 27, 6, 117, 22, 26, 24, 5, 25, 16, 1, 16 }, 85));
        Finish(this._0xc7094736, this._0x2b86364f, this._0x28f71569);
        this._0xb8581a86._0x348737e1(true);
        _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.WIN);
        this._0x9f9f19bb(() => this._0x3c7c8a1f());
    }

    public void _0xda6c76ff(_0x31f8b05c _0xfcee51da, _0x643422fd _0xca06dff2)
    {
        if (this._0xc47672dd)
            return;
        this._0xc47672dd = true;
        this._0x72b9b365 = _0xfcee51da;
        this._0xb8581a86 = _0xca06dff2;
        _0x411dd6a7 _0x91a18b61 = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.WIN);
        _0x411dd6a7 _0xf938c9e0 = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.LOSE);
        _0x411dd6a7 _0xe0087dc0 = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.PAUSE);
        RectTransform _0xf11da649 = this._0x79379054(_0x91a18b61, _0xa6ad08d6._0x62bd8ebc(new byte[12] { 144, 147, 134, 146, 143, 138, 140, 255, 143, 158, 134, 140 }, 223), _0xa6ad08d6._0x62bd8ebc(new byte[8] { 205, 214, 198, 165, 169, 175, 168, 181 }, 230), _0xa6ad08d6._0x62bd8ebc(new byte[18] { 38, 43, 37, 50, 42, 71, 52, 47, 38, 53, 35, 71, 34, 38, 53, 41, 34, 35 }, 103), _0xc406d6f3.Amber, _0xfcee51da.SymBolt, _0xa6ad08d6._0x62bd8ebc(new byte[10] { 161, 162, 187, 188, 210, 179, 181, 179, 187, 188 }, 242), _0xa6ad08d6._0x62bd8ebc(new byte[5] { 146, 145, 156, 156, 135 }, 222), () => this._0xf98b239a(), out this._0xc7094736, out this._0x2b86364f, out this._0x28f71569);
        RectTransform _0x5ec0580e = this._0x79379054(_0xf938c9e0, _0xa6ad08d6._0x62bd8ebc(new byte[15] { 112, 108, 97, 4, 112, 118, 109, 101, 104, 4, 97, 106, 96, 97, 96 }, 36), _0xa6ad08d6._0x62bd8ebc(new byte[12] { 202, 213, 201, 218, 183, 179, 169, 169, 179, 181, 180, 169 }, 250), _0xa6ad08d6._0x62bd8ebc(new byte[34] { 180, 168, 165, 192, 179, 180, 175, 178, 173, 192, 178, 165, 179, 165, 180, 179, 192, 205, 192, 180, 178, 185, 192, 161, 192, 174, 165, 183, 192, 180, 178, 169, 161, 172 }, 224), _0xc406d6f3.Ember, _0xfcee51da.SymStorm, _0xa6ad08d6._0x62bd8ebc(new byte[9] { 185, 178, 160, 215, 163, 165, 190, 182, 187 }, 247), _0xa6ad08d6._0x62bd8ebc(new byte[5] { 10, 9, 4, 4, 31 }, 70), () => this._0x3c7c8a1f(), out this._0x3d9bbcb9, out this._0xdd05e7f9, out this._0x8f1a49bd);
        RectTransform _0x0586808e = this._0x79379054(_0xe0087dc0, _0xa6ad08d6._0x62bd8ebc(new byte[15] { 58, 38, 43, 78, 61, 58, 33, 60, 35, 78, 57, 47, 39, 58, 61 }, 110), _0xa6ad08d6._0x62bd8ebc(new byte[15] { 180, 164, 199, 203, 205, 202, 215, 164, 169, 164, 198, 193, 208, 164, 180 }, 132), _0xa6ad08d6._0x62bd8ebc(new byte[12] { 242, 246, 236, 236, 246, 240, 241, 236, 159, 143, 144, 140 }, 191), _0xc406d6f3.Gold, _0xfcee51da.SymCrown, _0xa6ad08d6._0x62bd8ebc(new byte[6] { 247, 224, 246, 240, 232, 224 }, 165), _0xa6ad08d6._0x62bd8ebc(new byte[5] { 101, 102, 107, 107, 112 }, 41), () => this._0xf98b239a(), out this._0xeff35ad1, out this._0xa00f824f, out this._0x992f08c5);
        if (_0xf11da649 == null || _0x5ec0580e == null || _0x0586808e == null)
        {
            {
#if B_LOGS
                {
                    Debug.Log($"[pops] a pop card could not be built win={_0xf11da649 != null} lose={_0x5ec0580e != null} pause={_0x0586808e != null}");
                }
#endif
            }
        }
    }

    private TextMeshProUGUI _0x3d9bbcb9;
    private bool _0xc47672dd;
    public void _0xcae2ff30(int payout, string _0x93645dd5)
    {
        if (!this._0xc47672dd)
            return;
        _0x411dd6a7 _0xf33b32ac = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.WIN);
        if (_0xf33b32ac == null)
            return;
        _0xac23041c.SetText(this._0xc7094736, _0xa6ad08d6._0x62bd8ebc(new byte[12] { 195, 192, 213, 193, 220, 217, 223, 172, 220, 205, 213, 223 }, 140));
        _0xac23041c.SetText(this._0x2b86364f, _0xa6ad08d6._0x62bd8ebc(new byte[1] { 22 }, 61) + _0xc406d6f3.Coins(payout) + _0xa6ad08d6._0x62bd8ebc(new byte[6] { 141, 238, 226, 228, 227, 254 }, 173));
        _0xac23041c.SetText(this._0x28f71569, string.IsNullOrEmpty(_0x93645dd5) ? _0xa6ad08d6._0x62bd8ebc(new byte[18] { 169, 164, 170, 189, 165, 200, 187, 160, 169, 186, 172, 200, 173, 169, 186, 166, 173, 172 }, 232) : _0x93645dd5);
        Finish(this._0xc7094736, this._0x2b86364f, this._0x28f71569);
        this._0xb8581a86._0x348737e1(true);
        _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.WIN);
        this._0x9f9f19bb(() => this._0xf98b239a());
    }

    private TextMeshProUGUI _0xc7094736;
    private TextMeshProUGUI _0x8f1a49bd;
    private Tween _0x209ce6f3;
    public void _0xddb073ab()
    {
        if (!this._0xc47672dd)
            return;
        _0x411dd6a7 _0x155300ea = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.PAUSE);
        if (_0x155300ea == null)
            return;
        int _0x23647926 = this._0xb8581a86._0x2b4fb0d7 != null ? this._0xb8581a86._0x2b4fb0d7._0xfc1db04f : 0;
        _0xac23041c.SetText(this._0xeff35ad1, _0xa6ad08d6._0x62bd8ebc(new byte[15] { 224, 252, 241, 148, 231, 224, 251, 230, 249, 148, 227, 245, 253, 224, 231 }, 180));
        _0xac23041c.SetText(this._0xa00f824f, _0xc406d6f3.Coins(_0x23647926) + _0xa6ad08d6._0x62bd8ebc(new byte[6] { 134, 229, 233, 239, 232, 245 }, 166));
        _0xac23041c.SetText(this._0x992f08c5, _0xa6ad08d6._0x62bd8ebc(new byte[10] { 57, 34, 57, 44, 33, 77, 47, 40, 57, 77 }, 109) + _0xc406d6f3.Coins(this._0xb8581a86._0x131f8cc0) + _0xa6ad08d6._0x62bd8ebc(new byte[10] { 82, 21, 17, 11, 11, 17, 23, 22, 11, 120 }, 88) + this._0xb8581a86._0x45ead1dd.ToString() + _0xa6ad08d6._0x62bd8ebc(new byte[1] { 133 }, 170) + this._0xb8581a86._0x84b553a5.ToString());
        Finish(this._0xeff35ad1, this._0xa00f824f, this._0x992f08c5);
        _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.PAUSE);
        this._0x9f9f19bb(() => this._0xf98b239a());
    }

    private void _0x3c7c8a1f()
    {
        if (this._0x209ce6f3 != null)
            this._0x209ce6f3.Kill();
        _0x8f0aa4a3.Instance._0xed11e002();
        this._0xb8581a86._0x0237f6bc();
    }

    private TextMeshProUGUI _0x992f08c5;
    private _0x31f8b05c _0x72b9b365;
    private RectTransform _0x79379054(_0x411dd6a7 _0xf4c14112, string _0xf4e9675d, string _0xac2b0f18, string _0x2e1ac69d, Color _0x12aa5838, Sprite _0xef0ee819, string _0xdd7683e9, string _0xcd809002, System.Action _0x481e643b, out TextMeshProUGUI _0x348a9d54, out TextMeshProUGUI _0x61679c08, out TextMeshProUGUI _0xdb81ae86)
    {
        _0x348a9d54 = null;
        _0x61679c08 = null;
        _0xdb81ae86 = null;
        if (_0xf4c14112 == null || _0xf4c14112.Content == null)
            return null;
        RectTransform _0x983d1ee3 = _0xf4c14112.Content.transform as RectTransform;
        if (_0x983d1ee3 == null)
            return null;
        // Everything the template placed inside this pop goes away; from here the card is ours.
        for (int _0x55ed5c98 = _0x983d1ee3.childCount - 1; _0x55ed5c98 >= 0; _0x55ed5c98--)
            _0x983d1ee3.GetChild(_0x55ed5c98).gameObject.SetActive(false);
        _0x2d485ba7.Plate(_0x983d1ee3, _0xa6ad08d6._0x62bd8ebc(new byte[3] { 251, 214, 210 }, 191), Vector2.zero, new Vector2(_0xc406d6f3.PanelWidth, _0xc406d6f3.PanelHeight), this._0x72b9b365.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.DeepInk, 0.78f), 1f).raycastTarget = true;
        RectTransform _0x2d324232 = _0x2d485ba7.Node(_0x983d1ee3, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 180, 150, 133, 147 }, 247), Vector2.zero, new Vector2(CardWidth, CardHeight));
        _0x2d485ba7.Plate(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 60, 7, 0, 9 }, 110), Vector2.zero, new Vector2(CardWidth, CardHeight), this._0x72b9b365.Plate, _0x12aa5838, 34f);
        _0x2d485ba7.Plate(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 203, 236, 238, 232 }, 141), Vector2.zero, new Vector2(CardWidth - 16f, CardHeight - 16f), this._0x72b9b365.Plate, _0xc406d6f3.Panel, 30f);
        _0x2d485ba7.Plate(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[5] { 75, 112, 125, 125, 118 }, 24), new Vector2(0f, 310f), new Vector2(CardWidth - 120f, 3f), this._0x72b9b365.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.GoldLight, 0.4f), 2f);
        _0x348a9d54 = _0x2d485ba7.Label(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[6] { 148, 185, 189, 184, 185, 174 }, 220), new Vector2(0f, 430f), new Vector2(880f, 120f), this._0x72b9b365, _0xf4e9675d, _0xc406d6f3.SizePopHeader, 48f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
        _0x61679c08 = _0x2d485ba7.Label(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 181, 153, 145, 150 }, 248), new Vector2(0f, 190f), new Vector2(960f, 120f), this._0x72b9b365, _0xac2b0f18, _0xc406d6f3.SizeWinAmount, 44f, _0x12aa5838, TextAlignmentOptions.Center);
        _0xdb81ae86 = _0x2d485ba7.Label(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 174, 143, 148, 133 }, 224), new Vector2(0f, 46f), new Vector2(940f, 110f), this._0x72b9b365, _0x2e1ac69d, _0xc406d6f3.SizeBody, 26f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        _0x2d485ba7.Picture(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[4] { 83, 126, 105, 116 }, 27), new Vector2(0f, -170f), new Vector2(220f, 220f), _0xef0ee819);
        _0x2d485ba7.Label(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[10] { 127, 83, 81, 76, 80, 85, 93, 82, 95, 89 }, 60), new Vector2(0f, -330f), new Vector2(900f, 44f), this._0x72b9b365, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        // One caption per button, each with its own meaning - never the same word on the cross
        // and the action row (CLAUDE-unity.md C.17).
        Button _0x23846cb0 = _0x2d485ba7.Action(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[13] { 121, 91, 64, 68, 72, 91, 80, 104, 74, 93, 64, 70, 71 }, 41), new Vector2(-250f, -440f), new Vector2(460f, 150f), this._0x72b9b365, _0xdd7683e9, _0xc406d6f3.SizeButton + 6f, _0xc406d6f3.Ember, _0xc406d6f3.Cream, 30f);
        _0x23846cb0.onClick.AddListener(() => _0x481e643b.Invoke());
        Button _0x5bbb51c2 = _0x2d485ba7.Action(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[15] { 176, 134, 128, 140, 141, 135, 130, 145, 154, 162, 128, 151, 138, 140, 141 }, 227), new Vector2(250f, -440f), new Vector2(460f, 150f), this._0x72b9b365, _0xcd809002, _0xc406d6f3.SizeButton + 6f, _0xc406d6f3.PanelRaise, _0xc406d6f3.Gold, 30f);
        _0x5bbb51c2.onClick.AddListener(() => this._0x6d123541());
        // Our own cross, assigned from a serialized Sprite - the template leaves this Image with
        // no sprite at all.
        Button _0xdcce9ccc = _0x2d485ba7.IconAction(_0x2d324232, _0xa6ad08d6._0x62bd8ebc(new byte[11] { 228, 203, 200, 212, 194, 230, 196, 211, 206, 200, 201 }, 167), new Vector2((CardWidth * 0.5f) - 70f, (CardHeight * 0.5f) - 70f), 104f, this._0x72b9b365, this._0x72b9b365.IconClose, _0xc406d6f3.PanelRaise, 24f);
        _0xdcce9ccc.onClick.AddListener(() => this._0xf98b239a());
        return _0x2d324232;
    }

    private TextMeshProUGUI _0xa00f824f;
    public const float CardWidth = 1060f;
    private void _0xf98b239a()
    {
        if (this._0x209ce6f3 != null)
            this._0x209ce6f3.Kill();
        _0x8f0aa4a3.Instance._0xed11e002();
        this._0xb8581a86._0x348737e1(false);
    }

    public const float CardHeight = 1200f;
    private void _0x6d123541()
    {
        if (this._0x209ce6f3 != null)
            this._0x209ce6f3.Kill();
        if (_0x51e11591.Instance == null)
            return;
        _0x51e11591.Instance._0x05618a99(_0xe06f358c._0x55066aa5.SCENE_0);
    }

    private const float ReleaseSeconds = 7f;
    private TextMeshProUGUI _0xeff35ad1;
    // A label built inside an INACTIVE pop body has no font material yet, so its outline is
    // applied again the moment the card is actually raised.
    private static void Finish(TextMeshProUGUI _0xb98530c1, TextMeshProUGUI _0xda58d372, TextMeshProUGUI _0x4724b8eb)
    {
        _0xac23041c.ApplyOutline(_0xb98530c1);
        _0xac23041c.ApplyOutline(_0xda58d372);
        _0xac23041c.ApplyOutline(_0x4724b8eb);
    }

    public void _0x50b06def()
    {
        if (!this._0xc47672dd)
            return;
        _0x411dd6a7 _0x16c0654f = _0x8f0aa4a3.Instance._0x36f45b52(_0xe06f358c._0x0d50bd34.LOSE);
        if (_0x16c0654f == null)
            return;
        _0xac23041c.SetText(this._0x3d9bbcb9, _0xa6ad08d6._0x62bd8ebc(new byte[15] { 3, 31, 18, 119, 3, 5, 30, 22, 27, 119, 18, 25, 19, 18, 19 }, 87));
        _0xac23041c.SetText(this._0xdd05e7f9, this._0xb8581a86._0x45ead1dd.ToString() + _0xa6ad08d6._0x62bd8ebc(new byte[1] { 191 }, 144) + this._0xb8581a86._0x84b553a5.ToString() + _0xa6ad08d6._0x62bd8ebc(new byte[9] { 232, 133, 129, 155, 155, 129, 135, 134, 155 }, 200));
        _0xac23041c.SetText(this._0x8f1a49bd, _0xa6ad08d6._0x62bd8ebc(new byte[32] { 28, 0, 13, 104, 27, 28, 7, 26, 5, 104, 26, 13, 27, 13, 28, 27, 66, 28, 26, 17, 104, 9, 104, 6, 13, 31, 104, 28, 26, 1, 9, 4 }, 72));
        Finish(this._0x3d9bbcb9, this._0xdd05e7f9, this._0x8f1a49bd);
        this._0xb8581a86._0x348737e1(true);
        _0x8f0aa4a3.Instance._0x885f3061(_0xe06f358c._0x0d50bd34.LOSE);
        this._0x9f9f19bb(() => this._0x3c7c8a1f());
    }

    private TextMeshProUGUI _0x28f71569;
    private void OnDestroy()
    {
        if (this._0x209ce6f3 != null)
            this._0x209ce6f3.Kill();
        DOTween.Kill(this.gameObject);
    }

    private _0x643422fd _0xb8581a86;
}

internal static class _0xa6ad08d6
{
    internal static string _0x62bd8ebc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}