using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The casino lobby, laid out as a bottom sheet under full-bleed art. The PLAY button is the
// template's own scene-loading instance resized to the G.3 rect in the scene file; this builds
// its FACE as a child of that button, so the tap still reaches the template driver and there is
// never a second PLAY next to it.
public sealed class _0x8886c59a : MonoBehaviour
{
    [SerializeField]
    private _0xc7929e6b _wallet;
    private Image _0x429e0fa6;
    public const float SheetWidth = 1194f;
    private Image _0x8ea8044d;
    private void _0xe17af213(RectTransform _0x2da116d8, _0xa4199123 _0xa018d195)
    {
        float _0xd07b5950 = 900f - 1344f - SheetCentre;
        Button _0x0389ca3f = _0x2d485ba7.Action(_0x2da116d8, _0x715eb77d._0x34379689(new byte[10] { 134, 163, 171, 174, 187, 128, 173, 172, 183, 177 }, 194), new Vector2(-355f, _0xd07b5950), new Vector2(340f, 150f), this._0x50546657, _0x715eb77d._0x34379689(new byte[11] { 55, 50, 58, 63, 42, 121, 49, 60, 61, 38, 32 }, 115), _0xc406d6f3.SizeButton, _0xc406d6f3.PanelRaise, _0xc406d6f3.Cream, 26f);
        _0x0389ca3f.onClick.AddListener(() => _0xa018d195._0xda73ade9());
        Button _0xa2c89eae = _0x2d485ba7.Action(_0x2da116d8, _0x715eb77d._0x34379689(new byte[10] { 78, 98, 97, 97, 104, 110, 121, 100, 98, 99 }, 13), new Vector2(0f, _0xd07b5950), new Vector2(340f, 150f), this._0x50546657, _0x715eb77d._0x34379689(new byte[10] { 209, 221, 222, 222, 215, 209, 198, 219, 221, 220 }, 146), _0xc406d6f3.SizeButton, _0xc406d6f3.PanelRaise, _0xc406d6f3.Cream, 26f);
        _0xa2c89eae.onClick.AddListener(() => _0xa018d195._0x25f764c8());
        Button _0xf28319e6 = _0x2d485ba7.Action(_0x2da116d8, _0x715eb77d._0x34379689(new byte[10] { 213, 242, 232, 238, 248, 207, 232, 241, 248, 238 }, 157), new Vector2(355f, _0xd07b5950), new Vector2(340f, 150f), this._0x50546657, _0x715eb77d._0x34379689(new byte[8] { 142, 152, 137, 137, 148, 147, 154, 142 }, 221), _0xc406d6f3.SizeButton, _0xc406d6f3.PanelRaise, _0xc406d6f3.Cream, 26f);
        _0xf28319e6.onClick.AddListener(() => _0xa018d195._0x8536aa39());
    }

    public void _0x52b89565(RectTransform _0x9d61029b, _0x31f8b05c _0x15d88027, RectTransform _0x35235772, _0xa4199123 _0xc0103e55)
    {
        this._0x50546657 = _0x15d88027;
        this._wallet._0x64c75b9b();
        this._album._0x947dd036();
        this._0x86d00bcd(_0x9d61029b);
        RectTransform _0x363177cf = this._0xde0d8120(_0x9d61029b);
        this._0xd35a2a39(_0x363177cf);
        this._0x59775c86(_0x363177cf);
        this._0xe17af213(_0x363177cf, _0xc0103e55);
        _0x2d485ba7.Label(_0x363177cf, _0x715eb77d._0x34379689(new byte[10] { 98, 78, 76, 81, 77, 72, 64, 79, 66, 68 }, 33), new Vector2(0f, 330f - 1344f - SheetCentre), new Vector2(1050f, 44f), _0x15d88027, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        this._0x2b595f83(_0x35235772);
        this._0x786db210();
        _0x363177cf.anchoredPosition = new Vector2(0f, SheetCentre - 200f);
        _0x363177cf.DOAnchorPosY(SheetCentre, 0.32f).SetEase(Ease.OutCubic).SetLink(_0x363177cf.gameObject);
    }

    [SerializeField]
    private _0xce074dd9 _album;
    private RectTransform _0xde0d8120(RectTransform _0x61a22cdf)
    {
        RectTransform _0xda175a18 = _0x2d485ba7.Node(_0x61a22cdf, _0x715eb77d._0x34379689(new byte[5] { 167, 156, 145, 145, 128 }, 244), new Vector2(0f, SheetCentre), new Vector2(SheetWidth, SheetHeight));
        this._0x429e0fa6 = _0x2d485ba7.Plate(_0xda175a18, _0x715eb77d._0x34379689(new byte[4] { 240, 214, 205, 201 }, 164), Vector2.zero, new Vector2(SheetWidth, SheetHeight), this._0x50546657.Plate, _0xc406d6f3.Gold, 40f);
        _0x2d485ba7.Plate(_0xda175a18, _0x715eb77d._0x34379689(new byte[4] { 106, 77, 79, 73 }, 44), Vector2.zero, new Vector2(SheetWidth - 10f, SheetHeight - 10f), this._0x50546657.Plate, _0xc406d6f3.Panel, 36f);
        _0x2d485ba7.Plate(_0xda175a18, _0x715eb77d._0x34379689(new byte[5] { 149, 174, 163, 163, 168 }, 198), new Vector2(0f, (SheetHeight * 0.5f) - 34f), new Vector2(SheetWidth - 140f, 3f), this._0x50546657.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.GoldLight, 0.35f), 2f);
        return _0xda175a18;
    }

    private TextMeshProUGUI _0x470aefa5;
    private TextMeshProUGUI _0x3758b3b3;
    // The template's EMPTY_BASE_BUTTON variant switches every one of its own graphics off, so
    // the button renders nothing and nothing under it is a raycast target. The face below is a
    // CHILD of that button with raycastTarget on: UGUI bubbles the click up to the ancestor
    // Button, and its LoadSceneButton driver does the scene load.
    private void _0x2b595f83(RectTransform _0x23b77f5a)
    {
        if (_0x23b77f5a == null)
            return;
        RectTransform _0x7c85db6b = _0x2d485ba7.Stretch(_0x23b77f5a, _0x715eb77d._0x34379689(new byte[8] { 188, 128, 141, 149, 170, 141, 143, 137 }, 236));
        Vector2 _0x036cab90 = _0x23b77f5a.sizeDelta;
        Image _0x0c0ad444 = _0x7c85db6b.gameObject.AddComponent<Image>();
        _0x0c0ad444.sprite = this._0x50546657.Plate;
        _0x0c0ad444.type = Image.Type.Sliced;
        _0x0c0ad444.pixelsPerUnitMultiplier = _0x2d485ba7.PlateRadius(_0x036cab90.x, _0x036cab90.y, 38f);
        _0x0c0ad444.color = _0xc406d6f3.Gold;
        _0x0c0ad444.raycastTarget = true;
        Image _0x42ffbe09 = _0x2d485ba7.Plate(_0x7c85db6b, _0x715eb77d._0x34379689(new byte[5] { 130, 165, 165, 174, 185 }, 203), Vector2.zero, new Vector2(_0x036cab90.x - 14f, _0x036cab90.y - 14f), this._0x50546657.Plate, _0xc406d6f3.Ember, 34f);
        _0x42ffbe09.raycastTarget = true;
        _0x2d485ba7.Plate(_0x7c85db6b, _0x715eb77d._0x34379689(new byte[5] { 93, 108, 113, 105, 112 }, 30), new Vector2(0f, (_0x036cab90.y * 0.5f) - 26f), new Vector2(_0x036cab90.x - 120f, 4f), this._0x50546657.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Amber, 0.65f), 2f);
        _0x2d485ba7.Label(_0x7c85db6b, _0x715eb77d._0x34379689(new byte[7] { 47, 13, 28, 24, 5, 3, 2 }, 108), Vector2.zero, new Vector2(_0x036cab90.x - 60f, _0x036cab90.y - 40f), this._0x50546657, _0x715eb77d._0x34379689(new byte[4] { 122, 102, 107, 115 }, 42), _0xc406d6f3.SizeCta, 40f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
    }

    public void _0x786db210()
    {
        int _0xf32b2530 = this._album._0x7498f300;
        int _0x3504845e = this._album._0xf4877ba6;
        Color _0x2ea6509e = this._album._0xa03b593b(_0x3504845e);
        if (this._0x429e0fa6 != null)
            this._0x429e0fa6.color = _0x2ea6509e;
        if (this._0x02825b11 != null)
            this._0x02825b11.color = _0xc406d6f3.Alpha(_0x2ea6509e, 0.28f);
        if (this._0x470aefa5 != null)
            _0xac23041c.SetText(this._0x470aefa5, _0xce074dd9.RoomNames[Mathf.Clamp(_0x3504845e, 0, 2)]);
        if (this._0xb2574353 != null)
        {
            string _0xc7fcf4f8 = _0xf32b2530 >= 27 ? _0x715eb77d._0x34379689(new byte[18] { 53, 38, 53, 34, 41, 80, 34, 63, 63, 61, 80, 57, 35, 80, 63, 32, 53, 62 }, 112) : (_0x715eb77d._0x34379689(new byte[13] { 212, 223, 194, 206, 186, 200, 213, 213, 215, 186, 219, 206, 186 }, 154) + _0xce074dd9.RoomThresholds[Mathf.Clamp(_0x3504845e + 1, 0, 3)].ToString() + _0x715eb77d._0x34379689(new byte[7] { 249, 138, 145, 152, 139, 157, 138 }, 217));
            _0xac23041c.SetText(this._0xb2574353, _0x715eb77d._0x34379689(new byte[18] { 136, 148, 153, 252, 143, 136, 147, 142, 145, 252, 155, 157, 136, 148, 153, 142, 143, 214 }, 220) + _0xc7fcf4f8);
        }

        bool _0x5954b2c8 = _0xf32b2530 <= 0;
        if (this._0x3758b3b3 != null)
            this._0x3758b3b3.gameObject.SetActive(_0x5954b2c8);
        if (this._0x721e4991 != null)
        {
            this._0x721e4991.gameObject.SetActive(!_0x5954b2c8);
            _0xac23041c.SetText(this._0x721e4991, _0xf32b2530.ToString() + _0x715eb77d._0x34379689(new byte[1] { 24 }, 55) + _0x289589d1.ShardTotal.ToString());
        }

        if (this._0x2db83cb7 != null)
            this._0x2db83cb7.gameObject.SetActive(!_0x5954b2c8);
        if (this._0x8ea8044d != null)
        {
            this._0x8ea8044d.color = _0x2ea6509e;
            _0x2d485ba7.SetMeter(this._0x8ea8044d, (float)_0xf32b2530 / _0x289589d1.ShardTotal, this._0x89104b31 - 10f);
        }

        if (this._wallet != null)
            this._wallet._0x183a034b(false);
    }

    private Image _0x6d5e4e75;
    public const float SheetHeight = 1300f;
    private void OnDestroy()
    {
        if (this._0x6d5e4e75 != null)
            DOTween.Kill(this._0x6d5e4e75.rectTransform);
        DOTween.Kill(this.gameObject);
    }

    private RectTransform _0x2db83cb7;
    private const float SheetCentre = -598f; // 96 + 1300/2 - 1344
    public void _0x996066bc()
    {
        if (this._wallet != null)
            this._wallet._0x183a034b(true);
    }

    private TextMeshProUGUI _0xb2574353;
    // The bar and its label live in separate x-bands; before the first shard the row carries a
    // sentence instead of an empty bar (rule G: a list that can be empty always says so).
    private void _0x59775c86(RectTransform _0xffbc1aa9)
    {
        float _0x72c5c941 = 1080f - 1344f - SheetCentre;
        RectTransform _0xa309a881 = _0x2d485ba7.Node(_0xffbc1aa9, _0x715eb77d._0x34379689(new byte[8] { 173, 128, 142, 153, 129, 190, 131, 155 }, 236), new Vector2(0f, _0x72c5c941), new Vector2(1050f, 110f));
        _0x2d485ba7.Label(_0xa309a881, _0x715eb77d._0x34379689(new byte[7] { 209, 243, 226, 230, 251, 253, 252 }, 146), new Vector2(-400f, 0f), new Vector2(220f, 56f), this._0x50546657, _0x715eb77d._0x34379689(new byte[5] { 123, 118, 120, 111, 119 }, 58), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Left);
        this._0x89104b31 = 530f;
        this._0x2db83cb7 = _0x2d485ba7.Node(_0xa309a881, _0x715eb77d._0x34379689(new byte[8] { 73, 100, 106, 125, 101, 74, 105, 122 }, 8), new Vector2(10f, 0f), new Vector2(this._0x89104b31, 26f));
        this._0x8ea8044d = _0x2d485ba7.Meter(this._0x2db83cb7, _0x715eb77d._0x34379689(new byte[6] { 135, 188, 181, 166, 176, 167 }, 212), Vector2.zero, new Vector2(this._0x89104b31, 26f), this._0x50546657, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.95f), _0xc406d6f3.Gold);
        this._0x721e4991 = _0x2d485ba7.Label(_0xa309a881, _0x715eb77d._0x34379689(new byte[5] { 105, 69, 95, 68, 94 }, 42), new Vector2(420f, 0f), new Vector2(180f, 56f), this._0x50546657, _0x715eb77d._0x34379689(new byte[4] { 126, 97, 124, 121 }, 78), 32f, 24f, _0xc406d6f3.Gold, TextAlignmentOptions.Right);
        this._0x3758b3b3 = _0x2d485ba7.Label(_0xa309a881, _0x715eb77d._0x34379689(new byte[5] { 57, 17, 12, 8, 5 }, 124), new Vector2(70f, 0f), new Vector2(820f, 56f), this._0x50546657, _0x715eb77d._0x34379689(new byte[31] { 48, 49, 94, 45, 54, 63, 44, 58, 45, 94, 39, 59, 42, 94, 83, 94, 45, 46, 55, 48, 94, 42, 49, 94, 61, 49, 50, 50, 59, 61, 42 }, 126), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
    }

    private _0x31f8b05c _0x50546657;
    private void _0x86d00bcd(RectTransform _0x9dfdec9c)
    {
        this._0x6d5e4e75 = _0x2d485ba7.Picture(_0x9dfdec9c, _0x715eb77d._0x34379689(new byte[4] { 225, 205, 222, 199 }, 172), new Vector2(0f, 796f), new Vector2(320f, 320f), this._0x50546657.MarkBolt);
        RectTransform _0x0dd9b32e = this._0x6d5e4e75.rectTransform;
        Sequence _0x92fb6aa5 = DOTween.Sequence().SetLink(_0x0dd9b32e.gameObject);
        _0x92fb6aa5.Append(_0x0dd9b32e.DOAnchorPosY(806f, 1.6f).SetEase(Ease.InOutSine));
        _0x92fb6aa5.Append(_0x0dd9b32e.DOAnchorPosY(786f, 1.6f).SetEase(Ease.InOutSine));
        _0x92fb6aa5.SetLoops(-1, LoopType.Restart);
        this._0x02825b11 = _0x2d485ba7.Plate(_0x9dfdec9c, _0x715eb77d._0x34379689(new byte[8] { 30, 35, 35, 33, 15, 36, 37, 60 }, 76), new Vector2(0f, 546f), new Vector2(480f, 76f), this._0x50546657.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.9f), 38f);
        this._0x470aefa5 = _0x2d485ba7.Label(_0x9dfdec9c, _0x715eb77d._0x34379689(new byte[8] { 146, 175, 175, 173, 142, 161, 173, 165 }, 192), new Vector2(0f, 546f), new Vector2(440f, 56f), this._0x50546657, _0xce074dd9.RoomNames[0], _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.Cream, TextAlignmentOptions.Center);
        RectTransform _0x2e4820bb = _0x2d485ba7.Node(_0x9dfdec9c, _0x715eb77d._0x34379689(new byte[10] { 253, 220, 218, 214, 203, 233, 213, 216, 205, 220 }, 185), new Vector2(0f, 316f), new Vector2(1060f, 150f));
        _0x2d485ba7.Plate(_0x2e4820bb, _0x715eb77d._0x34379689(new byte[7] { 232, 203, 201, 193, 195, 196, 205 }, 170), Vector2.zero, new Vector2(1060f, 150f), this._0x50546657.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.DeepInk, 0.6f), 26f);
        _0x2d485ba7.Picture(_0x2e4820bb, _0x715eb77d._0x34379689(new byte[3] { 150, 177, 173 }, 195), new Vector2(-440f, 0f), new Vector2(110f, 110f), this._0x50546657.UrnBonus);
        this._0xb2574353 = _0x2d485ba7.Label(_0x2e4820bb, _0x715eb77d._0x34379689(new byte[4] { 253, 209, 206, 199 }, 190), new Vector2(50f, 0f), new Vector2(880f, 110f), this._0x50546657, _0x715eb77d._0x34379689(new byte[50] { 223, 195, 206, 171, 216, 223, 196, 217, 198, 171, 204, 202, 223, 195, 206, 217, 216, 129, 217, 196, 196, 198, 216, 171, 196, 219, 206, 197, 171, 202, 223, 171, 178, 171, 164, 171, 186, 179, 171, 164, 171, 185, 188, 171, 216, 195, 202, 217, 207, 216 }, 139), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Left);
    }

    private void _0xd35a2a39(RectTransform _0xce58cef1)
    {
        float _0xa8ffa1e0 = 1250f - 1344f - SheetCentre;
        RectTransform _0x8f329efe = _0x2d485ba7.Node(_0xce58cef1, _0x715eb77d._0x34379689(new byte[12] { 22, 53, 56, 53, 58, 55, 49, 4, 56, 53, 32, 49 }, 84), new Vector2(0f, _0xa8ffa1e0), new Vector2(1050f, 150f));
        _0x2d485ba7.Plate(_0x8f329efe, _0x715eb77d._0x34379689(new byte[7] { 185, 154, 152, 144, 146, 149, 156 }, 251), Vector2.zero, new Vector2(1050f, 150f), this._0x50546657.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.PanelSink, 0.95f), 28f);
        _0x2d485ba7.Label(_0x8f329efe, _0x715eb77d._0x34379689(new byte[7] { 20, 54, 39, 35, 62, 56, 57 }, 87), new Vector2(-355f, 0f), new Vector2(300f, 60f), this._0x50546657, _0x715eb77d._0x34379689(new byte[7] { 252, 255, 242, 255, 240, 253, 251 }, 190), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Left);
        TextMeshProUGUI _0x51af6285 = _0x2d485ba7.Label(_0x8f329efe, _0x715eb77d._0x34379689(new byte[5] { 199, 240, 253, 228, 244 }, 145), new Vector2(90f, 0f), new Vector2(560f, 90f), this._0x50546657, _0x715eb77d._0x34379689(new byte[7] { 217, 217, 217, 217, 217, 217, 217 }, 233), _0xc406d6f3.SizeBalance, 34f, _0xc406d6f3.Amber, TextAlignmentOptions.Right);
        _0x2d485ba7.Label(_0x8f329efe, _0x715eb77d._0x34379689(new byte[4] { 70, 125, 122, 103 }, 19), new Vector2(455f, 0f), new Vector2(120f, 48f), this._0x50546657, _0x715eb77d._0x34379689(new byte[5] { 167, 171, 173, 170, 183 }, 228), 26f, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Right);
        _0x6d688570 _0x8a0d10cb = _0x51af6285.gameObject.AddComponent<_0x6d688570>();
        _0x8a0d10cb.MoneyCountText = _0x51af6285;
        this._wallet._0x54a5bfb5(_0x8a0d10cb, _0x8f329efe);
    }

    private TextMeshProUGUI _0x721e4991;
    private float _0x89104b31;
    private Image _0x02825b11;
}

internal static class _0x715eb77d
{
    internal static string _0x34379689(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}