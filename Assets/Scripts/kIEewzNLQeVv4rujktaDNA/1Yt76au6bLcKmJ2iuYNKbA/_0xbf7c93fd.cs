using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xbf7c93fd : MonoBehaviour
{
    private static readonly List<_0xbf7c93fd> _0x83accb04 = new();
    private void Update()
    {
        if (_0x83accb04.Count == 0 || _0x83accb04[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x2e0b1ec9)
            OrientationChanged();
        if (Screen.safeArea != _0x92142ff0)
            SafeAreaChanged();
        if (Screen.width != _0xd19fd60e.x || Screen.height != _0xd19fd60e.y)
            ResolutionChanged();
    }

    private static UnityEvent _0xf7b5eada = new();
    private static bool _0x9f22b766;
    private static void ResolutionChanged()
    {
        _0xd19fd60e.x = Screen.width;
        _0xd19fd60e.y = Screen.height;
        _0x92142ff0 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf7b5eada.Invoke();
    }

    private static ScreenOrientation _0x2e0b1ec9 = ScreenOrientation.LandscapeLeft;
    private Vector2 _0xe8329de7;
    private CanvasScaler _0x7979e65e;
    private RectTransform _0xb6d5d3ce;
    private void OnDestroy()
    {
        if (_0x83accb04 != null && _0x83accb04.Contains(this))
            _0x83accb04.Remove(this);
    }

    private void Start()
    {
    }

    private void Awake()
    {
        if (!_0x83accb04.Contains(this))
            _0x83accb04.Add(this);
        this._0x657c9b8e = this.GetComponent<Canvas>();
        this._0x7979e65e = this.GetComponent<CanvasScaler>();
        if (this._0x7979e65e != null)
            this._0xe8329de7 = this._0x7979e65e.referenceResolution;
        this._0x8f316347 = this.GetComponent<RectTransform>();
        this._0xb6d5d3ce = this.transform.Find(_0xb2cb6ef7._0xf6cd39d0(new byte[8] { 254, 204, 203, 200, 236, 223, 200, 204 }, 173)) as RectTransform;
        if (!_0x9f22b766)
        {
            _0x2e0b1ec9 = Screen.orientation;
            _0xd19fd60e.x = Screen.width;
            _0xd19fd60e.y = Screen.height;
            _0x92142ff0 = Screen.safeArea;
            _0x9f22b766 = true;
        }

        this._0x26748d3a();
    }

    private void _0x26748d3a()
    {
        if (this._0xb6d5d3ce == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xd965213b = Screen.safeArea;
        Vector2 _0x204edea6 = _0xd965213b.position;
        Vector2 _0x322d12f0 = _0xd965213b.position + _0xd965213b.size;
        _0x204edea6.x /= screenWidth;
        _0x204edea6.y /= screenHeight;
        _0x322d12f0.x /= screenWidth;
        _0x322d12f0.y /= screenHeight;
        this._0xb6d5d3ce.anchorMin = _0x204edea6;
        this._0xb6d5d3ce.anchorMax = _0x322d12f0;
        this._0xb6d5d3ce.offsetMin = Vector2.zero;
        this._0xb6d5d3ce.offsetMax = Vector2.zero;
        if (this._0x7979e65e == null)
            return;
        Vector2 _0x3d104bab = _0x322d12f0 - _0x204edea6;
        float _0x4b081825 = 2f - _0x3d104bab.x;
        float _0x82bab3f1 = 2f - _0x3d104bab.y;
        this._0x7979e65e.referenceResolution = this._0xe8329de7 * new Vector2(_0x4b081825, _0x82bab3f1);
    }

    private static void SafeAreaChanged()
    {
        _0x92142ff0 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x2c4587d6 = 0; _0x2c4587d6 < _0x83accb04.Count; _0x2c4587d6++)
            _0x83accb04[_0x2c4587d6]._0x26748d3a();
    }

    private static void OrientationChanged()
    {
        _0x2e0b1ec9 = Screen.orientation;
        _0xd19fd60e.x = Screen.width;
        _0xd19fd60e.y = Screen.height;
        _0x92142ff0 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf7b5eada.Invoke();
    }

    private RectTransform _0x8f316347;
    private static Vector2 _0xd19fd60e = Vector2.zero;
    private static Rect _0x92142ff0 = Rect.zero;
    private Canvas _0x657c9b8e;
}

internal static class _0xb2cb6ef7
{
    internal static string _0xf6cd39d0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}