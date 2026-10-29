using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Dresses the splash body. The brand here is an ABSTRACT mark only - a forked bolt inside a
// laurel ring - and carries no letters: the app's name appears nowhere on screen (hard rule 1).
// The splash is deliberately much darker than the lobby and has no sheet and no PLAY, so the
// two screens can never read as one picture.
public sealed class _0xb065bdca : MonoBehaviour
{
    private void _0xfeb8fabb()
    {
        if (this._0x2b5ec48a == null)
            return;
        RectTransform _0xd47c8835 = this._0x2b5ec48a.rectTransform;
        _0xd47c8835.localScale = Vector3.one * 0.86f;
        Sequence _0x8afe7b1c = DOTween.Sequence().SetLink(_0xd47c8835.gameObject);
        _0x8afe7b1c.Append(_0xd47c8835.DOScale(1f, 0.45f).SetEase(Ease.OutBack));
        _0x8afe7b1c.OnComplete(() => this._0x1cfbb178(_0xd47c8835));
    }

    [SerializeField]
    private Slider _loadingSlider;
    private static readonly Color _0xcdeb72d9 = new Color(0.164706f, 0.109804f, 0.062745f, 0.9f); // #2A1C10 a 0.90
    // The bar keeps the size the prefab gives it - resizing its root is what collapsed the
    // whole chain on ANDROID-3578, because "Fill Area" insets itself by 30 units. Only the
    // two colours change here.
    private void _0x233b027b()
    {
        if (this._loadingSlider == null)
            return;
        RectTransform _0x14e417a9 = this._loadingSlider.fillRect;
        if (_0x14e417a9 != null)
        {
            Image _0xa6ae9742 = _0x14e417a9.GetComponent<Image>();
            if (_0xa6ae9742 != null)
                _0xa6ae9742.color = _0xf0c74e53;
            RectTransform _0x6e563dca = _0x14e417a9.parent as RectTransform;
            Image _0xff63cb55 = _0x6e563dca != null ? _0x6e563dca.GetComponent<Image>() : null;
            if (_0xff63cb55 != null)
                _0xff63cb55.color = _0xcdeb72d9;
        }
    }

    // The template ships the bar white-on-white (fill alpha 1, track alpha 1/255), i.e.
    // invisible. Rule G: accent fill, dark track with real alpha.
    private static readonly Color _0xf0c74e53 = new Color(0.980392f, 0.800000f, 0.082353f, 1f); // #FACC15
    public void _0xa18fc5ec(RectTransform _0xeef32243, _0x31f8b05c _0x9f4789c3)
    {
        _0x2d485ba7.Plate(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[5] { 0, 39, 41, 38, 58 }, 78), Vector2.zero, new Vector2(_0xc406d6f3.PanelWidth, _0xc406d6f3.PanelHeight), _0x9f4789c3.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.DeepInk, 0.93f), 1f);
        _0x2d485ba7.Plate(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[6] { 20, 57, 61, 46, 40, 52 }, 92), new Vector2(0f, -260f), new Vector2(1000f, 1000f), _0x9f4789c3.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Storm, 0.55f), 500f);
        this._0x2b5ec48a = _0x2d485ba7.Picture(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[4] { 226, 206, 221, 196 }, 175), new Vector2(0f, 216f), new Vector2(440f, 440f), _0x9f4789c3.MarkBolt);
        _0x2d485ba7.Plate(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[4] { 25, 62, 39, 46 }, 75), new Vector2(0f, -64f), new Vector2(320f, 4f), _0x9f4789c3.Plate, _0xc406d6f3.Alpha(_0xc406d6f3.Gold, 0.8f), 2f);
        _0x2d485ba7.Label(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[7] { 91, 110, 104, 99, 102, 97, 106 }, 15), new Vector2(0f, -160f), new Vector2(900f, 56f), _0x9f4789c3, _0x58d23b7d._0x06c92fba(new byte[17] { 253, 225, 236, 137, 250, 253, 230, 251, 228, 137, 238, 232, 253, 225, 236, 251, 250 }, 169), 34f, 26f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        _0x2d485ba7.Label(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[7] { 42, 9, 7, 2, 15, 8, 1 }, 102), new Vector2(0f, -1020f), new Vector2(700f, 48f), _0x9f4789c3, _0x58d23b7d._0x06c92fba(new byte[7] { 57, 58, 52, 49, 60, 59, 50 }, 117), _0xc406d6f3.SizeCaption, 24f, _0xc406d6f3.CreamDim, TextAlignmentOptions.Center);
        _0x2d485ba7.Label(_0xeef32243, _0x58d23b7d._0x06c92fba(new byte[10] { 106, 70, 68, 89, 69, 64, 72, 71, 74, 76 }, 41), new Vector2(0f, -1230f), new Vector2(1100f, 44f), _0x9f4789c3, _0xc406d6f3.ComplianceLine, _0xc406d6f3.SizeCompliance, 24f, _0xc406d6f3.Muted, TextAlignmentOptions.Center);
        this._0x233b027b();
        this._0xfeb8fabb();
    }

    private void OnDestroy()
    {
        if (this._0x2b5ec48a != null)
            DOTween.Kill(this._0x2b5ec48a.rectTransform);
        DOTween.Kill(this.gameObject);
    }

    // The endless part is its own sequence so the entry overshoot is never replayed.
    private void _0x1cfbb178(RectTransform _0xaf7556e5)
    {
        if (_0xaf7556e5 == null)
            return;
        Sequence _0xb32819c0 = DOTween.Sequence().SetLink(_0xaf7556e5.gameObject);
        _0xb32819c0.Append(_0xaf7556e5.DOScale(1.04f, 1.2f).SetEase(Ease.InOutSine));
        _0xb32819c0.Append(_0xaf7556e5.DOScale(1f, 1.2f).SetEase(Ease.InOutSine));
        _0xb32819c0.SetLoops(-1, LoopType.Restart);
    }

    private Image _0x2b5ec48a;
}

internal static class _0x58d23b7d
{
    internal static string _0x06c92fba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}