using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x93855911 : MonoBehaviour
{
    public BoxCollider2D CameraTouchBounds;
    private bool _0xd925e1a2(Touch? _0x4ed94e11, Bounds _0xbffe14db, TouchPhase _0x6eae5e6f)
    {
        if (!_0x51e11591.Instance._0x13f79269)
        {
            _0x4ed94e11 = null;
            return false;
        }

        if (_0x4ed94e11 != null)
            if (_0x4ed94e11.Value.phase == _0x6eae5e6f)
            {
                Vector3 _0xc01cdc1b = Camera.main.ScreenToWorldPoint(_0x4ed94e11.Value.screenPosition);
                Vector3 _0x13440ec9 = new(_0xc01cdc1b.x, _0xc01cdc1b.y, _0xbffe14db.center.z);
                if (_0xbffe14db.Contains(_0x13440ec9) && this._0xbb8a84b6(_0x4ed94e11.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xf9a8539c(Bounds _0x69ad982d)
    {
        if (!_0x51e11591.Instance._0x13f79269)
            return null;
        foreach (Touch _0x86a5b784 in Touch.activeTouches)
            if (!_0x86a5b784.ended)
            {
                Vector3 _0x22bf75e6 = Camera.main.ScreenToWorldPoint(_0x86a5b784.screenPosition);
                Vector3 _0xe5cf1233 = new(_0x22bf75e6.x, _0x22bf75e6.y, _0x69ad982d.center.z);
                if (_0x69ad982d.Contains(_0xe5cf1233) && this._0xbb8a84b6(_0x86a5b784))
                    return _0x86a5b784;
            }

        return null;
    }

    private void _0xd5dbe0c3(Touch? _0x41890761)
    {
        if (!_0x51e11591.Instance._0x13f79269)
        {
            _0x41890761 = null;
            return;
        }

        int _0x087d6dc8 = _0x41890761.Value.touchId;
        _0x41890761 = Touch.activeTouches.FirstOrDefault(_0x8e58a443 => _0x8e58a443.touchId == _0x087d6dc8);
        if (!this._0xbb8a84b6(_0x41890761.Value))
            _0x41890761 = null;
    }

    private Touch? _0x9ba762f0()
    {
        if (!_0x51e11591.Instance._0x13f79269)
            return null;
        foreach (Touch _0x3c75258c in Touch.activeTouches)
            if (_0x3c75258c.ended)
                if (this._0xbb8a84b6(_0x3c75258c))
                    return _0x3c75258c;
        return null;
    }

    private static _0x93855911 _0x34ad4652;
    private bool _0xbb8a84b6(Touch? _0xe717e154)
    {
        if (!_0xe717e154.HasValue)
            return false;
        Vector3 _0x6ce1f7e9 = Camera.main.ScreenToWorldPoint(_0xe717e154.Value.screenPosition);
        Vector3 _0x2fe94d3a = _0x6ce1f7e9;
        _0x2fe94d3a.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x2fe94d3a))
            return true;
        _0xe717e154 = null;
        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x34ad4652 = this.gameObject.GetComponent<_0x93855911>();
    }

    private Touch? _0x5fbc9ec3(Bounds _0x8e232f79)
    {
        if (!_0x51e11591.Instance._0x13f79269)
            return null;
        foreach (Touch _0x1cd1d10f in Touch.activeTouches)
            if (_0x1cd1d10f.ended)
            {
                Vector3 _0xcecf5e59 = Camera.main.ScreenToWorldPoint(_0x1cd1d10f.screenPosition);
                Vector3 _0x1e1c6492 = new(_0xcecf5e59.x, _0xcecf5e59.y, _0x8e232f79.center.z);
                if (_0x8e232f79.Contains(_0x1e1c6492) && this._0xbb8a84b6(_0x1cd1d10f))
                    return _0x1cd1d10f;
            }

        return null;
    }

    private Touch? _0xe3f6013f(Bounds _0x7dbb9602, TouchPhase _0x3f54945b)
    {
        if (!_0x51e11591.Instance._0x13f79269)
            return null;
        foreach (Touch _0xe79e1879 in Touch.activeTouches)
            if (_0xe79e1879.phase == _0x3f54945b)
            {
                Vector3 _0x6228bdc1 = Camera.main.ScreenToWorldPoint(_0xe79e1879.screenPosition);
                Vector3 _0x24910e06 = new(_0x6228bdc1.x, _0x6228bdc1.y, _0x7dbb9602.center.z);
                if (_0x7dbb9602.Contains(_0x24910e06) && this._0xbb8a84b6(_0xe79e1879))
                    return _0xe79e1879;
            }

        return null;
    }

    private Touch? _0x33e30f3f()
    {
        if (!_0x51e11591.Instance._0x13f79269)
            return null;
        foreach (Touch _0x444621a2 in Touch.activeTouches)
            if (!_0x444621a2.ended)
                if (this._0xbb8a84b6(_0x444621a2))
                    return _0x444621a2;
        return null;
    }
}