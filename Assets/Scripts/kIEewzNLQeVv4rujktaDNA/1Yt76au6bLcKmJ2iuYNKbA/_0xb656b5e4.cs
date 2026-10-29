using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xb656b5e4 : MonoBehaviour
{
    private static ScreenOrientation _0x521ccc0b = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x826ab630;
    private void Awake()
    {
        if (!_0xe9323285.Contains(this))
            _0xe9323285.Add(this);
        this._0x33a3f2e8 = this.GetComponent<Canvas>();
        this._0x826ab630 = this.GetComponent<RectTransform>();
        this._0x82175050 = this.transform.Find(_0xb015c39f._0x9ff2a63b(new byte[8] { 127, 77, 74, 73, 109, 94, 73, 77 }, 44)) as RectTransform;
        if (!_0x69329fba)
        {
            _0x521ccc0b = Screen.orientation;
            _0xde0fcf00.x = Screen.width;
            _0xde0fcf00.y = Screen.height;
            _0xc777863c = Screen.safeArea;
            _0x69329fba = true;
        }

        this._0x17b02c76();
    }

    private RectTransform _0x82175050;
    private void Update()
    {
        if (_0xe9323285[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x521ccc0b)
            OrientationChanged();
        if (Screen.safeArea != _0xc777863c)
            SafeAreaChanged();
        if (Screen.width != _0xde0fcf00.x || Screen.height != _0xde0fcf00.y)
            ResolutionChanged();
    }

    private static bool _0x69329fba;
    private static UnityEvent _0x2d36ab57 = new();
    private static readonly List<_0xb656b5e4> _0xe9323285 = new();
    private void _0x17b02c76()
    {
        if (this._0x82175050 == null)
            return;
        Rect _0x421b06e8 = Screen.safeArea;
        Vector2 _0x8168a042 = _0x421b06e8.position;
        Vector2 _0x575c9b89 = _0x421b06e8.position + _0x421b06e8.size;
        _0x8168a042.x /= this._0x33a3f2e8.pixelRect.width;
        _0x8168a042.y /= this._0x33a3f2e8.pixelRect.height;
        _0x575c9b89.x /= this._0x33a3f2e8.pixelRect.width;
        _0x575c9b89.y /= this._0x33a3f2e8.pixelRect.height;
        this._0x82175050.anchorMin = _0x8168a042;
        this._0x82175050.anchorMax = _0x575c9b89;
    }

    private void OnDestroy()
    {
        if (_0xe9323285 != null && _0xe9323285.Contains(this))
            _0xe9323285.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0x521ccc0b = Screen.orientation;
        _0xde0fcf00.x = Screen.width;
        _0xde0fcf00.y = Screen.height;
        _0x2d36ab57.Invoke();
    }

    private static Rect _0xc777863c = Rect.zero;
    private static void ResolutionChanged()
    {
        _0xde0fcf00.x = Screen.width;
        _0xde0fcf00.y = Screen.height;
        _0x2d36ab57.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0xc777863c = Screen.safeArea;
        for (int _0xbe366cc7 = 0; _0xbe366cc7 < _0xe9323285.Count; _0xbe366cc7++)
            _0xe9323285[_0xbe366cc7]._0x17b02c76();
    }

    private Canvas _0x33a3f2e8;
    private static Vector2 _0xde0fcf00 = Vector2.zero;
}

internal static class _0xb015c39f
{
    internal static string _0x9ff2a63b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}