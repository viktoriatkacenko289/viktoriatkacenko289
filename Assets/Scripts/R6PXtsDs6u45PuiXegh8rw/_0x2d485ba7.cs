using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Builders for the themed UGUI primitives this game is made of. Everything is laid out in the
// fixed 1242x2688 panel space (CasinoPalette.PanelWidth/PanelHeight): the template's AspecterSA
// is an AspectRatioFitter in FitInParent mode at that exact ratio, so the body is the same size
// on every device and the numbers below need no per-device correction.
public static class _0x2d485ba7
{
    public static void SetMeter(Image _0x1d591264, float _0x8c9f4873, float _0x4b905f1f)
    {
        if (_0x1d591264 == null)
            return;
        RectTransform _0xf3f8a95b = _0x1d591264.rectTransform;
        float width = Mathf.Max(8f, _0x4b905f1f * Mathf.Clamp01(_0x8c9f4873));
        _0xf3f8a95b.sizeDelta = new Vector2(width, _0xf3f8a95b.sizeDelta.y);
    }

    // A horizontal meter. The fill is a child anchored to the LEFT edge, so setting its width
    // is the whole animation and nothing has to re-derive anchors every frame.
    public static Image Meter(Transform _0xbc1be5a2, string _0x3e72b577, Vector2 _0xfd149235, Vector2 _0xa5907e18, _0x31f8b05c _0xed42c67c, Color _0x89ab8f67, Color _0x1122a342)
    {
        Plate(_0xbc1be5a2, _0x3e72b577 + _0x361c3576._0xa8f97769(new byte[5] { 19, 53, 38, 36, 44 }, 71), _0xfd149235, _0xa5907e18, _0xed42c67c != null ? _0xed42c67c.Plate : null, _0x89ab8f67, _0xa5907e18.y * 0.5f);
        RectTransform _0x26a15340 = Node(_0xbc1be5a2, _0x3e72b577 + _0x361c3576._0xa8f97769(new byte[4] { 161, 142, 139, 139 }, 231), new Vector2(_0xfd149235.x - (_0xa5907e18.x * 0.5f), _0xfd149235.y), new Vector2(_0xa5907e18.x, _0xa5907e18.y - 10f));
        _0x26a15340.anchorMin = new Vector2(0.5f, 0.5f);
        _0x26a15340.anchorMax = new Vector2(0.5f, 0.5f);
        _0x26a15340.pivot = new Vector2(0f, 0.5f);
        _0x26a15340.anchoredPosition = new Vector2(_0xfd149235.x - (_0xa5907e18.x * 0.5f) + 5f, _0xfd149235.y);
        _0x26a15340.sizeDelta = new Vector2(_0xa5907e18.x - 10f, _0xa5907e18.y - 10f);
        Image _0x69f6bf43 = _0x26a15340.gameObject.AddComponent<Image>();
        _0x69f6bf43.sprite = _0xed42c67c != null ? _0xed42c67c.Plate : null;
        _0x69f6bf43.type = Image.Type.Sliced;
        _0x69f6bf43.pixelsPerUnitMultiplier = PlateRadius(_0xa5907e18.x - 10f, _0xa5907e18.y - 10f, (_0xa5907e18.y - 10f) * 0.5f);
        _0x69f6bf43.color = _0x1122a342;
        _0x69f6bf43.raycastTarget = false;
        return _0x69f6bf43;
    }

    // A container that fills its parent completely. A host made with `new GameObject(...)`
    // starts at 100x100 anchored to the centre, which would silently resolve every child
    // anchor against 100x100 instead of the panel.
    public static RectTransform Stretch(Transform _0x7010130d, string _0x0f5f74d3)
    {
        GameObject _0xfa858237 = new GameObject(_0x0f5f74d3, typeof(RectTransform));
        RectTransform _0xc20b6999 = _0xfa858237.GetComponent<RectTransform>();
        _0xc20b6999.SetParent(_0x7010130d, false);
        _0xc20b6999.anchorMin = Vector2.zero;
        _0xc20b6999.anchorMax = Vector2.one;
        _0xc20b6999.pivot = new Vector2(0.5f, 0.5f);
        _0xc20b6999.offsetMin = Vector2.zero;
        _0xc20b6999.offsetMax = Vector2.zero;
        _0xc20b6999.localScale = Vector3.one;
        return _0xc20b6999;
    }

    // The plate sprite's 9-slice border is 127px, so the drawn corner radius is
    // 127 / pixelsPerUnitMultiplier. Deriving the multiplier from the RECT (never a literal)
    // is what stops two 127px borders meeting across a short box and smearing it.
    public static float PlateRadius(float width, float height, float _0xdfaa3768)
    {
        float _0x9b7c732b = Mathf.Min(width, height) * 0.45f;
        float _0x8c2ff475 = Mathf.Max(6f, Mathf.Min(_0xdfaa3768, _0x9b7c732b));
        return 127f / _0x8c2ff475;
    }

    // A transparent catcher that closes a modal when the player taps OUTSIDE its card. A fully
    // transparent Image is CULLED by the raycaster, so it carries a sliver of alpha and
    // cullTransparentMesh off.
    public static Button Shade(Transform _0x90334d67, string _0xc5c9fd7c, Color _0x7047c838)
    {
        RectTransform _0x07348a59 = Stretch(_0x90334d67, _0xc5c9fd7c);
        Image _0xa90f584a = _0x07348a59.gameObject.AddComponent<Image>();
        _0xa90f584a.color = _0x7047c838.a < 0.01f ? new Color(_0x7047c838.r, _0x7047c838.g, _0x7047c838.b, 0.004f) : _0x7047c838;
        _0xa90f584a.raycastTarget = true;
        _0xa90f584a.canvasRenderer.cullTransparentMesh = false;
        Button _0x716d6561 = _0x07348a59.gameObject.AddComponent<Button>();
        _0x716d6561.transition = Selectable.Transition.None;
        return _0x716d6561;
    }

    // A content sprite: Simple + preserveAspect, so a 512x512 PNG is never drawn as an egg.
    public static Image Picture(Transform _0x7fac28a1, string _0xb3d8ca2d, Vector2 _0xaf60b726, Vector2 _0xfe7f197c, Sprite _0x9242a264)
    {
        RectTransform _0x0525661e = Node(_0x7fac28a1, _0xb3d8ca2d, _0xaf60b726, _0xfe7f197c);
        Image _0xf3215839 = _0x0525661e.gameObject.AddComponent<Image>();
        _0xf3215839.sprite = _0x9242a264;
        _0xf3215839.type = Image.Type.Simple;
        _0xf3215839.preserveAspect = true;
        _0xf3215839.raycastTarget = false;
        return _0xf3215839;
    }

    public static RectTransform Node(Transform _0x88d6bdd4, string _0xdf30aadc, Vector2 _0x79cdf418, Vector2 _0xb6140493)
    {
        GameObject _0x1fb52974 = new GameObject(_0xdf30aadc, typeof(RectTransform));
        RectTransform _0x7e719cb8 = _0x1fb52974.GetComponent<RectTransform>();
        _0x7e719cb8.SetParent(_0x88d6bdd4, false);
        _0x7e719cb8.anchorMin = new Vector2(0.5f, 0.5f);
        _0x7e719cb8.anchorMax = new Vector2(0.5f, 0.5f);
        _0x7e719cb8.pivot = new Vector2(0.5f, 0.5f);
        _0x7e719cb8.anchoredPosition = _0x79cdf418;
        _0x7e719cb8.sizeDelta = _0xb6140493;
        _0x7e719cb8.localScale = Vector3.one;
        return _0x7e719cb8;
    }

    // A pressable surface: plate, optional icon, caption LAST so the background can never cover
    // its own text (CLAUDE-unity.md C.13 / E.1). The caption colour is always a LIGHT palette
    // colour - one shared font material means one shared dark outline (C.14).
    public static Button Action(Transform _0x6398cab7, string _0xd7b505e8, Vector2 _0x34283d97, Vector2 _0x786270cd, _0x31f8b05c _0xbecef666, string _0x46a350fd, float _0x256d5e91, Color _0x4bbed298, Color _0x473c3a26, float _0x85d6efb0)
    {
        RectTransform _0x31ab3828 = Node(_0x6398cab7, _0xd7b505e8, _0x34283d97, _0x786270cd);
        Image _0xd42e522c = _0x31ab3828.gameObject.AddComponent<Image>();
        _0xd42e522c.sprite = _0xbecef666 != null ? _0xbecef666.Plate : null;
        _0xd42e522c.type = Image.Type.Sliced;
        _0xd42e522c.pixelsPerUnitMultiplier = PlateRadius(_0x786270cd.x, _0x786270cd.y, _0x85d6efb0);
        _0xd42e522c.color = _0x4bbed298;
        _0xd42e522c.raycastTarget = true;
        Button _0x6c887c52 = _0x31ab3828.gameObject.AddComponent<Button>();
        _0x6c887c52.targetGraphic = _0xd42e522c;
        ColorBlock _0xeafa9ced = _0x6c887c52.colors;
        _0xeafa9ced.normalColor = Color.white;
        _0xeafa9ced.highlightedColor = new Color(1.08f, 1.08f, 1.08f, 1f);
        _0xeafa9ced.pressedColor = new Color(0.76f, 0.76f, 0.76f, 1f);
        _0xeafa9ced.selectedColor = Color.white;
        _0xeafa9ced.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.75f);
        _0x6c887c52.colors = _0xeafa9ced;
        if (!string.IsNullOrEmpty(_0x46a350fd))
        {
            Vector2 _0x944728f6 = new Vector2(_0x786270cd.x - 36f, _0x786270cd.y - 24f);
            TextMeshProUGUI _0xd4781dbf = Label(_0x31ab3828, _0x361c3576._0xa8f97769(new byte[7] { 177, 147, 130, 134, 155, 157, 156 }, 242), Vector2.zero, _0x944728f6, _0xbecef666, _0x46a350fd, _0x256d5e91, Mathf.Max(_0xc406d6f3.FontFloor, _0x256d5e91 * 0.62f), _0x473c3a26, TextAlignmentOptions.Center);
            _0xd4781dbf.name = _0x361c3576._0xa8f97769(new byte[7] { 177, 147, 130, 134, 155, 157, 156 }, 242);
        }

        return _0x6c887c52;
    }

    // An icon button (back, pause, close): square plate plus a centred picture, no caption.
    public static Button IconAction(Transform _0xebab1e30, string _0x5282229c, Vector2 _0x0eda8547, float _0x6b4cd6a9, _0x31f8b05c _0x9a67bc76, Sprite _0xbeb9a6e5, Color _0x441eaa11, float _0x1cdf21c9)
    {
        RectTransform _0x19325cbd = Node(_0xebab1e30, _0x5282229c, _0x0eda8547, new Vector2(_0x6b4cd6a9, _0x6b4cd6a9));
        Image _0x0195447a = _0x19325cbd.gameObject.AddComponent<Image>();
        _0x0195447a.sprite = _0x9a67bc76 != null ? _0x9a67bc76.Plate : null;
        _0x0195447a.type = Image.Type.Sliced;
        _0x0195447a.pixelsPerUnitMultiplier = PlateRadius(_0x6b4cd6a9, _0x6b4cd6a9, _0x1cdf21c9);
        _0x0195447a.color = _0x441eaa11;
        _0x0195447a.raycastTarget = true;
        Button _0x8813f688 = _0x19325cbd.gameObject.AddComponent<Button>();
        _0x8813f688.targetGraphic = _0x0195447a;
        ColorBlock _0x2ff872d4 = _0x8813f688.colors;
        _0x2ff872d4.normalColor = Color.white;
        _0x2ff872d4.highlightedColor = new Color(1.1f, 1.1f, 1.1f, 1f);
        _0x2ff872d4.pressedColor = new Color(0.74f, 0.74f, 0.74f, 1f);
        _0x2ff872d4.selectedColor = Color.white;
        _0x2ff872d4.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.75f);
        _0x8813f688.colors = _0x2ff872d4;
        // An Image with no sprite is drawn by Unity as a solid WHITE RECTANGLE, so a caller
        // that wants a text-only square button (BET -, BET +) passes null and gets no icon
        // child at all rather than a white plate behind its caption (CLAUDE-unity.md B.1).
        if (_0xbeb9a6e5 != null)
            Picture(_0x19325cbd, _0x361c3576._0xa8f97769(new byte[4] { 237, 199, 203, 202 }, 164), Vector2.zero, new Vector2(_0x6b4cd6a9 * 0.52f, _0x6b4cd6a9 * 0.52f), _0xbeb9a6e5);
        return _0x8813f688;
    }

    // Word wrap OFF, autosize ALWAYS on, minimum at the readability floor: a line that does not
    // fit shrinks to `minSize` instead of being clipped, and the break points are the author's.
    public static TextMeshProUGUI Label(Transform _0x6e7fa4ab, string _0x5c930ad1, Vector2 _0x2c90f692, Vector2 _0x64a80f0a, _0x31f8b05c _0x84575135, string _0x4094776f, float _0xdb838c4a, float _0xed204c4f, Color _0x5856d16b, TextAlignmentOptions _0x2e686f58)
    {
        RectTransform _0x753f07b6 = Node(_0x6e7fa4ab, _0x5c930ad1, _0x2c90f692, _0x64a80f0a);
        TextMeshProUGUI _0xa5308eb2 = _0x753f07b6.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x84575135 != null && _0x84575135.Font != null)
            _0xa5308eb2.font = _0x84575135.Font;
        _0xa5308eb2.text = _0x4094776f;
        _0xa5308eb2.color = _0x5856d16b;
        _0xa5308eb2.alignment = _0x2e686f58;
        _0xa5308eb2.textWrappingMode = TextWrappingModes.NoWrap;
        _0xa5308eb2.overflowMode = TextOverflowModes.Overflow;
        _0xa5308eb2.enableAutoSizing = true;
        _0xa5308eb2.fontSizeMax = _0xdb838c4a;
        _0xa5308eb2.fontSizeMin = Mathf.Max(_0xc406d6f3.FontFloor, _0xed204c4f);
        _0xa5308eb2.fontSize = _0xdb838c4a;
        _0xa5308eb2.raycastTarget = false;
        _0xac23041c.ApplyOutline(_0xa5308eb2);
        return _0xa5308eb2;
    }

    // A themed 9-slice surface. `radius` is the corner radius in canvas units.
    public static Image Plate(Transform _0x4269e3b7, string _0x86ded17c, Vector2 _0x8db8ef9d, Vector2 _0x73d9cd20, Sprite _0xf54f7d06, Color _0x8a7bdf24, float _0x4dc17a5f)
    {
        RectTransform _0x21c3db53 = Node(_0x4269e3b7, _0x86ded17c, _0x8db8ef9d, _0x73d9cd20);
        Image _0xd88372d4 = _0x21c3db53.gameObject.AddComponent<Image>();
        _0xd88372d4.sprite = _0xf54f7d06;
        _0xd88372d4.type = Image.Type.Sliced;
        _0xd88372d4.pixelsPerUnitMultiplier = PlateRadius(_0x73d9cd20.x, _0x73d9cd20.y, _0x4dc17a5f);
        _0xd88372d4.color = _0x8a7bdf24;
        _0xd88372d4.raycastTarget = false;
        return _0xd88372d4;
    }
}

internal static class _0x361c3576
{
    internal static string _0xa8f97769(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}