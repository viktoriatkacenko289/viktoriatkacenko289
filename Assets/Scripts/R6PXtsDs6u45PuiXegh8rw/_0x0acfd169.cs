using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// House rules. There is deliberately NOTHING here about sound, music, volume or vibration:
// this game ships without audio, so such a control would change nothing at all and a button
// that cannot confirm its action is a dead button (CLAUDE-unity.md C.7 / C.20).
// Every row below changes something a screenshot can show.
public sealed class _0x0acfd169 : MonoBehaviour
{
    private RectTransform _0xe774faee;
    private readonly TextMeshProUGUI[] _0xa4c72588 = new TextMeshProUGUI[3];
    private void _0xbb9b1a4c(int _0x70289ed2, bool _0x45f16ed5)
    {
        if (this._0x55e6ba10[_0x70289ed2] != null)
            this._0x55e6ba10[_0x70289ed2].color = _0x45f16ed5 ? _0xc406d6f3.Locked : _0xc406d6f3.Ember;
        if (this._0x8f792797[_0x70289ed2] != null)
            this._0x8f792797[_0x70289ed2].color = _0x45f16ed5 ? _0xc406d6f3.Ember : _0xc406d6f3.Locked;
        if (this._0xa4c72588[_0x70289ed2] != null)
            this._0xa4c72588[_0x70289ed2].color = _0x45f16ed5 ? _0xc406d6f3.Muted : _0xc406d6f3.Cream;
        if (this._0x73aff495[_0x70289ed2] != null)
            this._0x73aff495[_0x70289ed2].color = _0x45f16ed5 ? _0xc406d6f3.Cream : _0xc406d6f3.Muted;
    }

    private void _0x64f86f60(int _0x746061c3, bool _0x2e448978)
    {
        if (_0x746061c3 == 0)
            _0x289589d1._0x3dc83dc0 = _0x2e448978;
        else if (_0x746061c3 == 1)
            _0x289589d1._0x99257a82 = _0x2e448978;
        else
            _0x289589d1._0xf250efdc = _0x2e448978;
        this._0xba0e6de2();
        this._0x7c009678(_0x746061c3);
    }

    // Each switch answers on the spot: the mini reel spins at the new speed, the burst replays
    // at the chosen intensity, and high contrast repaints every label in the sheet at once.
    private void _0x7c009678(int _0xc68b843b)
    {
        if (_0xc68b843b == 0 && this._0xe774faee != null)
        {
            DOTween.Kill(this._0xe774faee);
            this._0xe774faee.localEulerAngles = Vector3.zero;
            float _0x266cdea0 = _0x289589d1._0x3dc83dc0 ? 0.45f : 0.9f;
            this._0xe774faee.DOLocalRotate(new Vector3(0f, 0f, -360f), _0x266cdea0, RotateMode.FastBeyond360).SetEase(Ease.OutCubic).SetLink(this._0xe774faee.gameObject);
        }

        if (_0xc68b843b == 1 && this._0xe8254de9 != null)
        {
            DOTween.Kill(this._0xe8254de9);
            RectTransform _0x969354c7 = this._0xe8254de9.rectTransform;
            _0x969354c7.localScale = Vector3.one;
            float _0x61a4900a = _0x289589d1._0x99257a82 ? 1.08f : 1.5f;
            Sequence _0x78d92a48 = DOTween.Sequence().SetLink(_0x969354c7.gameObject);
            _0x78d92a48.Append(_0x969354c7.DOScale(_0x61a4900a, 0.16f).SetEase(Ease.OutQuad));
            _0x78d92a48.Append(_0x969354c7.DOScale(1f, 0.26f).SetEase(Ease.InQuad));
        }
    }

    private void _0x43ccc434()
    {
        _0x289589d1.ResetProgress();
        if (this._0x94d6aca5 != null && this._0x94d6aca5._0xb46fc652 != null)
            this._0x94d6aca5._0xb46fc652._0x183a034b(true);
        if (this._0x94d6aca5 != null && this._0x94d6aca5._0xbfc63296 != null)
            this._0x94d6aca5._0xbfc63296._0x786db210();
        _0xac23041c.SetText(this._0x6d91abbd, _0x9ba2dd02._0x96f0dbed(new byte[42] { 244, 246, 235, 227, 246, 225, 247, 247, 132, 246, 225, 247, 225, 240, 132, 137, 132, 150, 145, 136, 148, 148, 148, 132, 231, 235, 237, 234, 247, 136, 132, 148, 139, 150, 147, 132, 247, 236, 229, 246, 224, 247 }, 164));
        this._0xba0e6de2();
    }

    // One switch row: title on the left, two option pills on the right, a live preview in its
    // own gutter well clear of the text column.
    private RectTransform _0xa63aba38(RectTransform _0xab385cc1, int _0x0a9c3f2e, float _0xcfdff54d, string _0x5bfb74c7, string _0x6b3c8b24, string _0x918d1fd4)
    {
        RectTransform _0xd0755e2f = _0x2d485ba7.Node(_0xab385cc1, _0x9ba2dd02._0x96f0dbed(new byte[3] { 31, 34, 58 }, 77) + _0x0a9c3f2e.ToString(), new Vector2(0f, _0xcfdff54d), new Vector2(RowWidth, RowHeight));
        _0x2d485ba7.Plate(_0xd0755e2f, _0x9ba2dd02._0x96f0dbed(new byte[4] { 6, 33, 35, 37 }, 64), Vector2.zero, new Vector2(RowWidth, RowHeight), this._0xae63f7c5.Plate, _0xc406d6f3.PanelRaise, 24f);
        this._0x1c3c0048[_0x0a9c3f2e] = _0x2d485ba7.Label(_0xd0755e2f, _0x9ba2dd02._0x96f0dbed(new byte[5] { 3, 62, 35, 59, 50 }, 87), new Vector2(-140f, 0f), new Vector2(380f, 56f), this._0xae63f7c5, _0x5bfb74c7, 32f, 26f, _0xc406d6f3.Cream, TextAlignmentOptions.Left);
        Button _0x1de37b36 = _0x2d485ba7.Action(_0xd0755e2f, _0x9ba2dd02._0x96f0dbed(new byte[7] { 216, 231, 227, 254, 248, 249, 214 }, 151), new Vector2(190f, 0f), new Vector2(200f, 104f), this._0xae63f7c5, _0x6b3c8b24, _0xc406d6f3.SizeButton, _0xc406d6f3.Locked, _0xc406d6f3.Cream, 24f);
        _0x1de37b36.onClick.AddListener(() => this._0x64f86f60(_0x0a9c3f2e, false));
        this._0x55e6ba10[_0x0a9c3f2e] = _0x1de37b36.targetGraphic as Image;
        this._0xa4c72588[_0x0a9c3f2e] = _0x1de37b36.GetComponentInChildren<TextMeshProUGUI>();
        Button _0x7bf26fdb = _0x2d485ba7.Action(_0xd0755e2f, _0x9ba2dd02._0x96f0dbed(new byte[7] { 177, 142, 138, 151, 145, 144, 188 }, 254), new Vector2(410f, 0f), new Vector2(200f, 104f), this._0xae63f7c5, _0x918d1fd4, _0xc406d6f3.SizeButton, _0xc406d6f3.Locked, _0xc406d6f3.Cream, 24f);
        _0x7bf26fdb.onClick.AddListener(() => this._0x64f86f60(_0x0a9c3f2e, true));
        this._0x8f792797[_0x0a9c3f2e] = _0x7bf26fdb.targetGraphic as Image;
        this._0x73aff495[_0x0a9c3f2e] = _0x7bf26fdb.GetComponentInChildren<TextMeshProUGUI>();
        return _0xd0755e2f;
    }

    private _0x31f8b05c _0xae63f7c5;
    private readonly TextMeshProUGUI[] _0x1c3c0048 = new TextMeshProUGUI[4];
    private TextMeshProUGUI _0x6d91abbd;
    private void OnDestroy()
    {
        if (this._0xe774faee != null)
            DOTween.Kill(this._0xe774faee);
        if (this._0xe8254de9 != null)
            DOTween.Kill(this._0xe8254de9);
        DOTween.Kill(this.gameObject);
    }

    private readonly Image[] _0x55e6ba10 = new Image[3];
    private _0xa4199123 _0x94d6aca5;
    public const float RowWidth = 1040f;
    private Image _0xe8254de9;
    public const float RowHeight = 150f;
    private bool _0x0b1fd703;
    public void _0x8a1c4d6c(RectTransform _0x8fd702d9, _0x31f8b05c _0x093dd5cb, _0xa4199123 _0xcaadb41b)
    {
        if (this._0x0b1fd703)
            return;
        this._0x0b1fd703 = true;
        this._0xae63f7c5 = _0x093dd5cb;
        this._0x94d6aca5 = _0xcaadb41b;
        RectTransform _0x8bd72296 = this._0xa63aba38(_0x8fd702d9, 0, 390f, _0x9ba2dd02._0x96f0dbed(new byte[10] { 68, 83, 83, 90, 54, 69, 70, 83, 83, 82 }, 22), _0x9ba2dd02._0x96f0dbed(new byte[6] { 98, 99, 126, 97, 109, 96 }, 44), _0x9ba2dd02._0x96f0dbed(new byte[5] { 199, 195, 223, 213, 221 }, 150));
        this._0xe774faee = _0x2d485ba7.Picture(_0x8bd72296, _0x9ba2dd02._0x96f0dbed(new byte[7] { 3, 33, 54, 37, 58, 54, 36 }, 83), new Vector2(-430f, 0f), new Vector2(96f, 96f), _0x093dd5cb.SymBolt).rectTransform;
        RectTransform _0x5e3c2d98 = this._0xa63aba38(_0x8fd702d9, 1, 220f, _0x9ba2dd02._0x96f0dbed(new byte[14] { 238, 232, 225, 232, 239, 255, 236, 249, 228, 226, 227, 141, 235, 245 }, 173), _0x9ba2dd02._0x96f0dbed(new byte[4] { 199, 212, 205, 205 }, 129), _0x9ba2dd02._0x96f0dbed(new byte[4] { 172, 174, 163, 162 }, 239));
        this._0xe8254de9 = _0x2d485ba7.Plate(_0x5e3c2d98, _0x9ba2dd02._0x96f0dbed(new byte[7] { 179, 145, 134, 149, 138, 134, 148 }, 227), new Vector2(-430f, 0f), new Vector2(96f, 96f), _0x093dd5cb.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0.8f), 48f);
        RectTransform _0x5e9f814e = this._0xa63aba38(_0x8fd702d9, 2, 50f, _0x9ba2dd02._0x96f0dbed(new byte[18] { 156, 157, 147, 156, 249, 151, 155, 154, 128, 134, 149, 135, 128, 244, 128, 145, 140, 128 }, 212), _0x9ba2dd02._0x96f0dbed(new byte[3] { 212, 221, 221 }, 155), _0x9ba2dd02._0x96f0dbed(new byte[2] { 221, 220 }, 146));
        _0x2d485ba7.Picture(_0x5e9f814e, _0x9ba2dd02._0x96f0dbed(new byte[7] { 132, 166, 177, 162, 189, 177, 163 }, 212), new Vector2(-430f, 0f), new Vector2(96f, 96f), _0x093dd5cb.SymColumn);
        RectTransform _0x8f93d2ad = _0x2d485ba7.Node(_0x8fd702d9, _0x9ba2dd02._0x96f0dbed(new byte[8] { 253, 202, 220, 202, 219, 253, 192, 216 }, 175), new Vector2(0f, -120f), new Vector2(RowWidth, RowHeight));
        _0x2d485ba7.Plate(_0x8f93d2ad, _0x9ba2dd02._0x96f0dbed(new byte[4] { 111, 72, 74, 76 }, 41), Vector2.zero, new Vector2(RowWidth, RowHeight), _0x093dd5cb.Plate, _0xc406d6f3.PanelRaise, 24f);
        this._0x1c3c0048[3] = _0x2d485ba7.Label(_0x8f93d2ad, _0x9ba2dd02._0x96f0dbed(new byte[5] { 193, 252, 225, 249, 240 }, 149), new Vector2(-170f, 14f), new Vector2(600f, 56f), _0x093dd5cb, _0x9ba2dd02._0x96f0dbed(new byte[14] { 223, 200, 222, 200, 217, 173, 221, 223, 194, 202, 223, 200, 222, 222 }, 141), 32f, 26f, _0xc406d6f3.Cream, TextAlignmentOptions.Left);
        Button _0x7c9dd117 = _0x2d485ba7.Action(_0x8f93d2ad, _0x9ba2dd02._0x96f0dbed(new byte[11] { 80, 103, 113, 103, 118, 67, 97, 118, 107, 109, 108 }, 2), new Vector2(330f, 0f), new Vector2(300f, 110f), _0x093dd5cb, _0x9ba2dd02._0x96f0dbed(new byte[5] { 44, 59, 45, 59, 42 }, 126), _0xc406d6f3.SizeButton, _0xc406d6f3.EmberDeep, _0xc406d6f3.Cream, 26f);
        _0x7c9dd117.onClick.AddListener(() => this._0x43ccc434());
        this._0x6d91abbd = _0x2d485ba7.Label(_0x8f93d2ad, _0x9ba2dd02._0x96f0dbed(new byte[5] { 43, 12, 25, 12, 29 }, 120), new Vector2(-170f, -46f), new Vector2(600f, 36f), _0x093dd5cb, _0x9ba2dd02._0x96f0dbed(new byte[45] { 154, 153, 148, 153, 150, 155, 157, 244, 248, 153, 148, 154, 141, 149, 248, 153, 150, 156, 248, 140, 138, 145, 153, 148, 248, 159, 151, 248, 154, 153, 155, 147, 248, 140, 151, 248, 140, 144, 157, 248, 139, 140, 153, 138, 140 }, 216), 26f, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Left);
        _0x2d485ba7.Label(_0x8fd702d9, _0x9ba2dd02._0x96f0dbed(new byte[5] { 1, 40, 42, 44, 33 }, 77), new Vector2(0f, -430f), new Vector2(1000f, 130f), _0x093dd5cb, _0x9ba2dd02._0x96f0dbed(new byte[131] { 235, 228, 238, 249, 228, 226, 227, 236, 225, 141, 238, 226, 228, 227, 254, 141, 128, 141, 227, 226, 249, 141, 253, 248, 255, 238, 229, 236, 254, 236, 239, 225, 232, 141, 128, 141, 227, 226, 249, 141, 255, 232, 233, 232, 232, 224, 236, 239, 225, 232, 167, 227, 226, 141, 255, 232, 236, 225, 128, 224, 226, 227, 232, 244, 141, 253, 225, 236, 244, 141, 128, 141, 227, 226, 141, 233, 232, 253, 226, 254, 228, 249, 254, 141, 128, 141, 227, 226, 141, 253, 255, 228, 247, 232, 254, 167, 235, 226, 255, 141, 236, 233, 248, 225, 249, 254, 141, 156, 149, 134, 141, 128, 141, 232, 227, 249, 232, 255, 249, 236, 228, 227, 224, 232, 227, 249, 141, 226, 227, 225, 244 }, 173), 26f, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
    }

    public void _0xba0e6de2()
    {
        if (!this._0x0b1fd703)
            return;
        this._0xbb9b1a4c(0, _0x289589d1._0x3dc83dc0);
        this._0xbb9b1a4c(1, _0x289589d1._0x99257a82);
        this._0xbb9b1a4c(2, _0x289589d1._0xf250efdc);
        Color _0x4bd138cb = _0x289589d1._0xf250efdc ? Color.white : _0xc406d6f3.Cream;
        for (int _0xf5f08a78 = 0; _0xf5f08a78 < this._0x1c3c0048.Length; _0xf5f08a78++)
            if (this._0x1c3c0048[_0xf5f08a78] != null)
                this._0x1c3c0048[_0xf5f08a78].color = _0x4bd138cb;
    }

    private readonly Image[] _0x8f792797 = new Image[3];
    private readonly TextMeshProUGUI[] _0x73aff495 = new TextMeshProUGUI[3];
}

internal static class _0x9ba2dd02
{
    internal static string _0x96f0dbed(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}