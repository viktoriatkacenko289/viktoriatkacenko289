using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xd110da96 : MonoBehaviour
{
    private string _0xfa01d017 = "";
    private async void Start()
    {
        await _0x59c757ca();
    }

    internal bool firstLoadShown = false;
    private void _0x6a9e526f(string _0xf7a4b3fe)
    {
        bool _0xf97a029e = !string.IsNullOrEmpty(_0xf7a4b3fe);
        if (_0xf97a029e)
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[13] { 59, 52, 5, 19, 20, 61, 64, 51, 8, 15, 23, 90, 64 }, 96) + _0xf7a4b3fe);
#endif
            }

            _0x7afbad31(_0xf7a4b3fe);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[39] { 230, 233, 216, 206, 201, 224, 157, 251, 220, 209, 209, 223, 220, 222, 214, 157, 95, 59, 47, 157, 250, 220, 208, 216, 157, 149, 211, 210, 157, 219, 212, 211, 220, 209, 157, 232, 239, 241, 148 }, 189));
#endif
            }

            _0x735c3a7b();
            return;
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0x1dfb1ade()
    {
        float _0x6c877bfa = Time.realtimeSinceStartup;
        if (_0x6c877bfa < 0f)
            _0x6c877bfa = 0f;
        int _0xea7928df = (int)(_0x6c877bfa * 1000f);
        int _0xdebcdd4d = _0xea7928df / 60000;
        int _0x5e6f722e = (_0xea7928df / 1000) % 60;
        int _0xb8ef8fa8 = _0xea7928df % 1000;
        return string.Format(_0xb11edeec._0x1de8009f(new byte[21] { 70, 13, 7, 13, 13, 64, 7, 70, 12, 7, 13, 13, 64, 7, 70, 15, 7, 13, 13, 13, 64 }, 61), _0xdebcdd4d, _0x5e6f722e, _0xb8ef8fa8);
    }

    private string Decrypt(string _0x842fb969, string _0x39a3dd2f)
    {
        try
        {
            var _0xdad41f9a = Convert.FromBase64String(_0x842fb969);
            using var _0xeadb335c = Aes.Create();
            _0xeadb335c.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x39a3dd2f));
            var _0x2d971287 = new byte[16];
            Buffer.BlockCopy(_0xdad41f9a, 0, _0x2d971287, 0, 16);
            _0xeadb335c.IV = _0x2d971287;
            using var _0x3fa1df81 = new MemoryStream(_0xdad41f9a, 16, _0xdad41f9a.Length - 16);
            using var _0xdf9122b3 = new CryptoStream(_0x3fa1df81, _0xeadb335c.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x51bb44f9 = new StreamReader(_0xdf9122b3, Encoding.UTF8);
            return _0x51bb44f9.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private JObject _0x5eedacb3(params string[] _0x9a7d8b82)
    {
        JObject _0x23b4d9c5 = new JObject();
        foreach (var _0x14844908 in _0x9a7d8b82)
        {
            string _0xce1bafe3 = _0xe7aaf485();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xce1bafe3} val={_0x14844908}");
#endif
            }

            _0x23b4d9c5.Add(_0xce1bafe3, _0x14844908 == null ? "" : _0x14844908);
        }

        return _0x23b4d9c5;
    }

    private int _0x1da33fd9 = -1;
    private Task _0x6a788541(IEnumerator _0x0005142b)
    {
        var _0xbc805e00 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xb4f961e2(_0x0005142b, _0xbc805e00));
        return _0xbc805e00.Task;
    }

    // WEB VIEW LOGIC
    public bool _0x166e15e0 { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x6a329bfa = null;
    internal bool _0x3f8300c9(string _0x907971f3)
    {
        return _0x907971f3.StartsWith(_0xb11edeec._0x1de8009f(new byte[9] { 166, 170, 185, 160, 174, 191, 241, 228, 228 }, 203), StringComparison.OrdinalIgnoreCase) || _0x907971f3.StartsWith(_0xb11edeec._0x1de8009f(new byte[24] { 115, 111, 111, 107, 104, 33, 52, 52, 107, 119, 122, 98, 53, 124, 116, 116, 124, 119, 126, 53, 120, 116, 118, 52 }, 27), StringComparison.OrdinalIgnoreCase) || _0x907971f3.StartsWith(_0xb11edeec._0x1de8009f(new byte[23] { 142, 146, 146, 150, 220, 201, 201, 150, 138, 135, 159, 200, 129, 137, 137, 129, 138, 131, 200, 133, 137, 139, 201 }, 230), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x4c009a40 = "";
    private string _0xf533ddb8 = "";
    private string _0x7819158e = "";
    // MAIN FLOW
    private bool _0x70454d0b { get; set; }

    private void StopCurrentFailedLoad(UniWebView _0xc99c3404)
    {
        _0x6ff6762e(false);
        if (_0xc99c3404 == null)
            return;
        _0xc99c3404.Stop();
        if (_0xc99c3404.CanGoBack)
            _0xc99c3404.GoBack();
    }

    private string _0x8d63a735 = "";
    private AndroidJavaObject _0x3847c8af { get; set; }

    private IEnumerator _0x19a8ceb2(string _0x68e3cc83)
    {
        if (_0x6a329bfa != null && _0x166e15e0)
            yield break;
        _0x6a329bfa = gameObject.AddComponent<UniWebView>();
        _0x83c6d2ee(_0x6a329bfa);
        _0x06bc7586(_0x6a329bfa);
        _0x6a329bfa.BackgroundColor = Color.clear;
        var _0x5baf2e6c = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xa0542076();
        yield return new WaitForEndOfFrame();
        _0x166e15e0 = true;
        _0x87fca9f8();
        _0x6ff6762e(true);
        _0xff84a9d0 = false;
        _0x75b37112 = false;
        _0xc10edd98.Clear();
        _0x1da33fd9 = -1;
        firstLoadShown = false;
        _0xad1e39c7 = false;
        _0x4260046e = false;
        _0x6a329bfa.SetUserAgent("");
        _0x22e23149 = Time.realtimeSinceStartup;
        _0x6a329bfa.Stop();
        _0x6a329bfa.Load(_0x68e3cc83);
        _0x6a329bfa.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xb11edeec._0x1de8009f(new byte[25] { 117, 89, 81, 86, 24, 111, 93, 90, 110, 81, 93, 79, 24, 113, 86, 81, 76, 81, 89, 84, 24, 107, 80, 87, 79 }, 56));
    }

    private string _0x9ae07dd1 = "";
    // WS_SOURCE MONO
    public static _0xd110da96 _0xf08c2322 { get; private set; }

    private void Awake()
    {
        if (_0xf08c2322 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xf08c2322 = gameObject.GetComponent<_0xd110da96>();
        DontDestroyOnLoad(gameObject);
        _0xfbd31b8e = _0xe5511bfd = _0x5cadc9ae = "";
        _0x4c009a40 = "";
        _0x166e15e0 = false;
    }

    private void _0xf04ae4fd()
    {
        if (_0x6a329bfa == null)
            return;
        if (_0x75b37112)
            _0x6a329bfa.SetUserAgent(_0xf8be7f86());
        else
            _0x6a329bfa.SetUserAgent("");
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x335dba01)
    {
        if (_0x335dba01 == null || _0x335dba01.Extra == null)
            return null;
        object _0xbeda6f65;
        if (!_0x335dba01.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xbeda6f65))
            return null;
        return _0xbeda6f65 as string;
    }

    private void OnApplicationPause(bool _0xdffca134)
    {
        isApplicationPause = _0xdffca134;
    }

    private void _0x766bd773(string _0xce5e1577)
    {
        if (string.IsNullOrEmpty(_0xce5e1577))
            return;
        if (TryOpenExternalLikeChrome(_0xce5e1577))
            return;
        OpenUrlExternally(_0xce5e1577);
    }

    internal void Update()
    {
        if (_0x6a329bfa == null)
            return;
        if (_0x0f6cfb92())
            _0x8df35525();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xa0542076();
        if (_0x33e9a0b8 && _0x9b8e5f18 != null)
            _0x9b8e5f18.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private void _0xc00a46d6(string _0x3d31b74a)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[34] { 245, 250, 203, 221, 218, 243, 142, 232, 203, 218, 205, 198, 142, 235, 214, 218, 220, 207, 142, 254, 219, 221, 198, 142, 234, 207, 218, 207, 142, 252, 207, 217, 148, 142 }, 174) + _0x3d31b74a);
#endif
            }
        }

        var _0xfe860832 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x3d31b74a);
        StartCoroutine(_0x84a05429(_0xfe860832));
    }

    private bool _0xff84a9d0 = false;
    private bool _0xa4e71bb5(int _0xddce1396, string _0x5bc7fe90, string _0xf068e1c1)
    {
        if (string.IsNullOrEmpty(_0xf068e1c1))
            return false;
        if (!IsHttpUrl(_0xf068e1c1))
            return true;
        if (string.IsNullOrEmpty(_0x5bc7fe90))
            return false;
        return _0x5bc7fe90.IndexOf(_0xb11edeec._0x1de8009f(new byte[20] { 188, 171, 171, 166, 186, 182, 183, 183, 188, 186, 173, 176, 182, 183, 166, 171, 188, 170, 188, 173 }, 249), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5bc7fe90.IndexOf(_0xb11edeec._0x1de8009f(new byte[22] { 138, 157, 157, 144, 140, 128, 129, 129, 138, 140, 155, 134, 128, 129, 144, 157, 138, 137, 154, 156, 138, 139 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5bc7fe90.IndexOf(_0xb11edeec._0x1de8009f(new byte[21] { 108, 123, 123, 118, 106, 102, 103, 103, 108, 106, 125, 96, 102, 103, 118, 106, 101, 102, 122, 108, 109 }, 41), StringComparison.OrdinalIgnoreCase) >= 0 || _0x5bc7fe90.IndexOf(_0xb11edeec._0x1de8009f(new byte[22] { 122, 109, 109, 96, 106, 113, 116, 113, 112, 104, 113, 96, 106, 109, 115, 96, 108, 124, 119, 122, 114, 122 }, 63), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private RectTransform _0x9b8e5f18;
    // PART 3
    private string _0x551f5da1()
    {
        try
        {
            var _0x7ee957ad = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 90, 86, 84, 23, 76, 87, 80, 77, 64, 10, 93, 23, 73, 85, 88, 64, 92, 75, 23, 108, 87, 80, 77, 64, 105, 85, 88, 64, 92, 75 }, 57));
            var _0xdf7d8f1c = _0x7ee957ad.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 173, 187, 188, 188, 171, 160, 186, 143, 173, 186, 167, 184, 167, 186, 183 }, 206));
            var _0x8d64c2ba = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[57] { 176, 188, 190, 253, 180, 188, 188, 180, 191, 182, 253, 178, 189, 183, 161, 188, 186, 183, 253, 180, 190, 160, 253, 178, 183, 160, 253, 186, 183, 182, 189, 167, 186, 181, 186, 182, 161, 253, 146, 183, 165, 182, 161, 167, 186, 160, 186, 189, 180, 154, 183, 144, 191, 186, 182, 189, 167 }, 211));
            var _0xc38c8264 = _0x8d64c2ba.CallStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[20] { 95, 93, 76, 121, 92, 78, 93, 74, 76, 81, 75, 81, 86, 95, 113, 92, 113, 86, 94, 87 }, 56), _0xdf7d8f1c);
            var _0xb94219cf = _0xc38c8264.Call<string>(_0xb11edeec._0x1de8009f(new byte[5] { 205, 207, 222, 227, 206 }, 170));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xb94219cf}");
#endif
            }

            return string.IsNullOrEmpty(_0xb94219cf) ? "" : _0xb94219cf;
        }
        catch
        {
            return "";
        }
    }

    private void _0xf5650e73(string _0xd7db172a)
    {
        Dictionary<string, object> _0x41685690;
        try
        {
            _0x41685690 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd7db172a);
        }
        catch
        {
            return;
        }

        var _0x3ee11b57 = ReadPushField(_0x41685690, _0xb11edeec._0x1de8009f(new byte[3] { 191, 184, 166 }, 202));
        if (string.IsNullOrWhiteSpace(_0x3ee11b57))
            return;
        _0x3ee11b57 = _0x3ee11b57.Trim();
        if (!IsHttpUrl(_0x3ee11b57))
            return;
        if (string.Equals(_0x3ee11b57, _0x51289862, StringComparison.Ordinal))
            return;
        _0x51289862 = _0x3ee11b57;
        OpenUrlExternally(_0x3ee11b57);
    }

    private void _0xc8cd8a01()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private async Task _0xd689168a(string _0x0559ad08)
    {
        if (_0x52c55135 || string.IsNullOrEmpty(_0xa53eb895) || string.IsNullOrEmpty(_0x0559ad08) || _0xe64b4e5c)
            return;
        _0x52c55135 = true;
        try
        {
            JObject _0x3c108b0a = _0x5eedacb3(_0x0559ad08, _0xa53eb895, _0x1dfb1ade());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x0559ad08} payload: {_0x3c108b0a}");
                }
#endif
            }

            var _0x94f3a50d = _0xf7a61fa5(_0x3c108b0a.ToString(), _0xa53eb895);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xb11edeec._0x1de8009f(new byte[4] { 98, 97, 111, 106 }, 14) + _0xa53eb895, _0x94f3a50d } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[24] { 94, 81, 64, 86, 81, 88, 37, 73, 106, 100, 97, 37, 117, 100, 118, 118, 37, 96, 119, 119, 106, 119, 63, 37 }, 5) + e.Message);
#endif
            }
        }
    }

    private string _0xa53eb895 = "";
    private async Task<string> _0xb03c39c5(int _0x8cc10034 = 5, int _0x08270c00 = 500)
    {
        try
        {
            List<EntityData> _0x02123113 = new List<EntityData>();
            int _0x3ecaffab = 0;
            do
            {
                _0x02123113 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xb11edeec._0x1de8009f(new byte[8] { 179, 175, 162, 186, 166, 177, 138, 167 }, 195), _0xa53eb895, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xa53eb895 }), new QueryOptions())).ToList();
                await Task.Delay(_0x08270c00);
            }
            while (_0x02123113.Count == 0 && _0x3ecaffab++ < _0x8cc10034);
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[33] { 138, 133, 180, 162, 165, 140, 241, 130, 176, 167, 180, 181, 241, 157, 184, 191, 186, 241, 128, 164, 180, 163, 168, 241, 163, 180, 162, 164, 189, 165, 162, 235, 241 }, 209) + JsonConvert.SerializeObject(_0x02123113, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[39] { 121, 118, 71, 81, 86, 127, 2, 113, 67, 84, 71, 70, 2, 110, 75, 76, 73, 2, 115, 87, 71, 80, 91, 2, 80, 71, 81, 87, 78, 86, 81, 2, 65, 77, 87, 76, 86, 24, 2 }, 34) + _0x02123113.Count);
                }
#endif
            }

            var _0x682f57e1 = _0x02123113.SelectMany(_0x9a642949 => _0x9a642949.Data).FirstOrDefault(_0xac6a24c1 => _0xac6a24c1.Key == _0xa53eb895)?.Value.GetAs<string>() ?? string.Empty;
            _0x682f57e1 = Decrypt(_0x682f57e1, _0xa53eb895);
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[24] { 248, 247, 198, 208, 215, 254, 131, 239, 204, 194, 199, 131, 208, 194, 213, 198, 199, 131, 207, 202, 205, 200, 153, 131 }, 163) + _0x682f57e1);
                }
#endif
            }

            return _0x682f57e1;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[39] { 207, 192, 241, 231, 224, 201, 180, 211, 241, 224, 180, 251, 230, 180, 228, 245, 230, 231, 241, 180, 231, 245, 226, 241, 240, 180, 248, 253, 250, 255, 180, 242, 245, 253, 248, 241, 240, 174, 180 }, 148) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private int _0xb4f63dc9 = 0;
    internal bool IsAboutBlank(string _0x4b15b7a8)
    {
        if (string.IsNullOrEmpty(_0x4b15b7a8))
            return false;
        return _0x4b15b7a8.StartsWith(_0xb11edeec._0x1de8009f(new byte[11] { 68, 71, 74, 80, 81, 31, 71, 73, 68, 75, 78 }, 37), StringComparison.OrdinalIgnoreCase);
    }

    internal string _0x308f1707(string _0x028a2031)
    {
        int _0x45b5901f = _0x028a2031.IndexOf(_0xb11edeec._0x1de8009f(new byte[3] { 92, 81, 8 }, 53), StringComparison.OrdinalIgnoreCase);
        if (_0x45b5901f < 0)
            return null;
        string _0xe1ec5a38 = _0x028a2031.Substring(_0x45b5901f + 3);
        int _0x3812ebd6 = _0xe1ec5a38.IndexOf('&');
        return _0x3812ebd6 >= 0 ? _0xe1ec5a38.Substring(0, _0x3812ebd6) : _0xe1ec5a38;
    }

    private async Task<bool> _0x6c799a40()
    {
        _0x2196ea34.Instance?._0xe66f1a4e();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x7b4feabe) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[32] { 197, 202, 251, 237, 234, 195, 190, 203, 240, 247, 234, 231, 190, 206, 235, 237, 246, 190, 208, 241, 234, 247, 248, 247, 253, 255, 234, 247, 241, 240, 164, 190 }, 158) + string.Join(_0xb11edeec._0x1de8009f(new byte[1] { 188 }, 181), _0x7b4feabe));
                }
#endif
            }
        };
        try
        {
            _0xfbd31b8e = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[31] { 169, 166, 151, 129, 134, 175, 210, 180, 147, 155, 158, 151, 150, 210, 134, 157, 210, 149, 151, 134, 210, 130, 135, 129, 154, 210, 134, 157, 153, 151, 156 }, 242));
                }
#endif
            }

            _0xfbd31b8e = "";
        }

        _0x35c7a7cc = !string.IsNullOrEmpty(_0xfbd31b8e);
        _0x9a322251 = _0x1dfb1ade();
        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[25] { 169, 166, 151, 129, 134, 175, 210, 167, 156, 155, 134, 139, 210, 162, 135, 129, 154, 210, 166, 157, 153, 151, 156, 200, 210 }, 242) + _0xfbd31b8e);
#endif
        }

        _0x2196ea34.Instance?._0x30e8d2a1();
        return false;
    }

    private float _0x22e23149 = 0f;
    private string _0x6f6f5584 = "";
    private void _0x06bc7586(UniWebView _0x9756fdf3)
    {
        if (_0x3ead24a2)
            return;
        _0x3ead24a2 = true;
        _0x9756fdf3.AddUrlScheme(_0xb11edeec._0x1de8009f(new byte[2] { 217, 202 }, 173));
        _0x9756fdf3.AddUrlScheme(_0xb11edeec._0x1de8009f(new byte[6] { 21, 18, 8, 25, 18, 8 }, 124));
        _0x9756fdf3.AddUrlScheme(_0xb11edeec._0x1de8009f(new byte[6] { 242, 254, 237, 244, 250, 235 }, 159));
        _0x9756fdf3.OnMessageReceived += (_0xb165ee29, _0xabc116b6) =>
        {
            if (TryOpenExternalLikeChrome(_0xabc116b6.RawMessage))
            {
                _0x6ff6762e(false);
                return;
            }
        };
        _0x9756fdf3.RegisterShouldHandleRequest(_0x3fbd2a43 =>
        {
            string _0xad5c7610 = _0x3fbd2a43 != null ? _0x3fbd2a43.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xad5c7610))
                return true;
            WLog(_0xb11edeec._0x1de8009f(new byte[21] { 57, 2, 5, 31, 6, 14, 34, 11, 4, 14, 6, 15, 56, 15, 27, 31, 15, 25, 30, 80, 74 }, 106) + _0xad5c7610);
            if (TryOpenExternalLikeChrome(_0xad5c7610))
            {
                _0x6ff6762e(false);
                return false;
            }

            if (_0x3fbd2a43 != null && _0x3fbd2a43.IsMainFrame && IsGoogleAuthFlowUrl(_0xad5c7610) && !_0x75b37112)
            {
                WLog(_0xb11edeec._0x1de8009f(new byte[62] { 15, 35, 43, 44, 98, 21, 39, 32, 20, 43, 39, 53, 98, 38, 39, 54, 39, 33, 54, 39, 38, 98, 5, 45, 45, 37, 46, 39, 98, 35, 55, 54, 42, 98, 23, 16, 14, 98, 111, 124, 98, 48, 39, 46, 45, 35, 38, 98, 53, 43, 54, 42, 98, 5, 45, 45, 37, 46, 39, 98, 23, 3 }, 66));
                _0x75b37112 = true;
                _0x6ff6762e(true);
                _0x6a329bfa.SetUserAgent(_0xf8be7f86());
                _0x6a329bfa.Load(_0xad5c7610);
                return false;
            }

            return true;
        });
        _0x9756fdf3.OnLoadingErrorReceived += (_0xb165ee29, _0x91d8980e, _0xabc116b6, _0xecc620de) =>
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[25] { 40, 4, 12, 11, 69, 50, 0, 7, 51, 12, 0, 18, 69, 32, 23, 23, 10, 23, 95, 69, 6, 10, 1, 0, 88 }, 101) + _0x91d8980e + _0xb11edeec._0x1de8009f(new byte[9] { 254, 179, 187, 173, 173, 191, 185, 187, 227 }, 222) + _0xabc116b6);
            string _0x69cacbba = GetFailingUrl(_0xecc620de);
            if (string.IsNullOrEmpty(_0x69cacbba) || IsAboutBlank(_0x69cacbba))
                return;
            _ = _0xd689168a(_0xb11edeec._0x1de8009f(new byte[8] { 82, 83, 122, 64, 87, 87, 74, 87 }, 37));
            WLog(_0xb11edeec._0x1de8009f(new byte[45] { 127, 83, 91, 92, 18, 101, 87, 80, 100, 91, 87, 69, 18, 84, 83, 91, 94, 91, 92, 85, 18, 103, 96, 126, 18, 31, 12, 18, 93, 66, 87, 92, 18, 87, 74, 70, 87, 64, 92, 83, 94, 94, 75, 8, 18 }, 50) + _0x69cacbba);
            StopCurrentFailedLoad(_0xb165ee29);
            _0x766bd773(_0x69cacbba);
        };
        _0x9756fdf3.OnPageStarted += (_0xb165ee29, _0x6c491fbd) =>
        {
            _0xb4f63dc9 = 0;
            if (_0xff84a9d0 && IsAboutBlank(_0x6c491fbd))
            {
                WLog(_0xb11edeec._0x1de8009f(new byte[27] { 21, 55, 32, 50, 36, 55, 40, 101, 36, 39, 42, 48, 49, 127, 39, 41, 36, 43, 46, 101, 54, 49, 36, 55, 49, 32, 33 }, 69));
                return;
            }

            WLog(_0xb11edeec._0x1de8009f(new byte[29] { 137, 165, 173, 170, 228, 147, 161, 166, 146, 173, 161, 179, 228, 139, 170, 148, 165, 163, 161, 151, 176, 165, 182, 176, 161, 160, 254, 228, 239 }, 196) + (Time.realtimeSinceStartup - _0x22e23149).ToString(_0xb11edeec._0x1de8009f(new byte[5] { 7, 25, 7, 7, 7 }, 55)) + _0xb11edeec._0x1de8009f(new byte[2] { 0, 83 }, 115) + _0x6c491fbd);
            if (TryOpenExternalLikeChrome(_0x6c491fbd))
            {
                StopCurrentFailedLoad(_0xb165ee29);
                return;
            }

            if (ContainsIgnoreCase(_0x6c491fbd, _0xb11edeec._0x1de8009f(new byte[8] { 113, 124, 124, 116, 59, 116, 101, 101 }, 21)) || ContainsIgnoreCase(_0x6c491fbd, _0xb11edeec._0x1de8009f(new byte[15] { 129, 144, 136, 223, 134, 152, 149, 150, 148, 133, 223, 147, 157, 158, 150 }, 241)) || _0x6c491fbd.StartsWith(_0xb11edeec._0x1de8009f(new byte[25] { 129, 157, 157, 153, 154, 211, 198, 198, 139, 153, 142, 133, 134, 139, 136, 133, 143, 136, 159, 199, 133, 128, 159, 140, 198 }, 233), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xb165ee29);
                OpenUrlExternally(_0x6c491fbd);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x6c491fbd))
            {
                _0x6ff6762e(true);
                WLog(_0xb11edeec._0x1de8009f(new byte[41] { 239, 199, 199, 207, 196, 205, 136, 201, 221, 220, 192, 136, 206, 196, 199, 223, 136, 204, 205, 220, 205, 203, 220, 205, 204, 136, 133, 150, 136, 195, 205, 205, 216, 136, 222, 193, 219, 193, 202, 196, 205 }, 168));
                return;
            }

            _0xad1e39c7 = true;
            _0x6ff6762e(true);
            WLog(_0xb11edeec._0x1de8009f(new byte[43] { 32, 18, 21, 33, 30, 18, 0, 87, 27, 24, 22, 19, 30, 25, 16, 88, 5, 18, 19, 30, 5, 18, 20, 3, 30, 25, 16, 87, 90, 73, 87, 28, 18, 18, 7, 87, 1, 30, 4, 30, 21, 27, 18 }, 119));
        };
        _0x9756fdf3.OnPageCommitted += (_0xb165ee29, _0x6c491fbd) =>
        {
            if (_0xff84a9d0 && IsAboutBlank(_0x6c491fbd))
                return;
            WLog(_0xb11edeec._0x1de8009f(new byte[31] { 186, 150, 158, 153, 215, 160, 146, 149, 161, 158, 146, 128, 215, 184, 153, 167, 150, 144, 146, 180, 152, 154, 154, 158, 131, 131, 146, 147, 205, 215, 220 }, 247) + (Time.realtimeSinceStartup - _0x22e23149).ToString(_0xb11edeec._0x1de8009f(new byte[5] { 112, 110, 112, 112, 112 }, 64)) + _0xb11edeec._0x1de8009f(new byte[2] { 229, 182 }, 150) + _0x6c491fbd);
            if (!firstLoadShown && IsHttpUrl(_0x6c491fbd))
            {
                firstLoadShown = true;
                _0xad1e39c7 = false;
                _0x6ff6762e(false);
                _0xc8cd8a01();
                _0xa0542076();
                _0xb165ee29.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd689168a(_0xb11edeec._0x1de8009f(new byte[9] { 34, 35, 10, 58, 37, 48, 59, 48, 49 }, 85));
                WLog(_0xb11edeec._0x1de8009f(new byte[39] { 160, 140, 132, 131, 205, 186, 136, 143, 187, 132, 136, 154, 205, 158, 133, 130, 154, 131, 205, 130, 131, 205, 142, 130, 128, 128, 132, 153, 153, 136, 137, 205, 142, 130, 131, 153, 136, 131, 153 }, 237));
            }
        };
        _0x9756fdf3.OnPageProgressChanged += (_0xb165ee29, _0x462a2c74) =>
        {
            if (_0xff84a9d0)
                return;
            if (!firstLoadShown && _0x462a2c74 >= 0.65f)
            {
                firstLoadShown = true;
                _0xad1e39c7 = false;
                _0x6ff6762e(false);
                _0xc8cd8a01();
                _0xa0542076();
                _0xb165ee29.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd689168a(_0xb11edeec._0x1de8009f(new byte[9] { 226, 227, 202, 250, 229, 240, 251, 240, 241 }, 149));
                WLog(_0xb11edeec._0x1de8009f(new byte[32] { 192, 236, 228, 227, 173, 218, 232, 239, 219, 228, 232, 250, 173, 254, 229, 226, 250, 227, 173, 239, 244, 173, 253, 255, 226, 234, 255, 232, 254, 254, 183, 173 }, 141) + _0x462a2c74);
            }
        };
        _0x9756fdf3.OnPageFinished += (_0xb165ee29, _0x91d8980e, _0x6c491fbd) =>
        {
            if (_0xff84a9d0 && IsAboutBlank(_0x6c491fbd))
            {
                _0xff84a9d0 = false;
                WLog(_0xb11edeec._0x1de8009f(new byte[28] { 204, 238, 249, 235, 253, 238, 241, 188, 253, 254, 243, 233, 232, 166, 254, 240, 253, 242, 247, 188, 250, 245, 242, 245, 239, 244, 249, 248 }, 156));
                return;
            }

            WLog(_0xb11edeec._0x1de8009f(new byte[24] { 212, 248, 240, 247, 185, 206, 252, 251, 207, 240, 252, 238, 185, 223, 240, 247, 240, 234, 241, 252, 253, 163, 185, 178 }, 153) + (Time.realtimeSinceStartup - _0x22e23149).ToString(_0xb11edeec._0x1de8009f(new byte[5] { 8, 22, 8, 8, 8 }, 56)) + _0xb11edeec._0x1de8009f(new byte[7] { 135, 212, 151, 155, 144, 145, 201 }, 244) + _0x91d8980e + _0xb11edeec._0x1de8009f(new byte[5] { 146, 199, 192, 222, 143 }, 178) + _0x6c491fbd);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xad1e39c7 = false;
                _0x6ff6762e(false);
                _0xc8cd8a01();
                _0xa0542076();
                _0xb165ee29.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xd689168a(_0xb11edeec._0x1de8009f(new byte[9] { 239, 238, 199, 247, 232, 253, 246, 253, 252 }, 152));
                WLog(_0xb11edeec._0x1de8009f(new byte[33] { 186, 150, 158, 153, 215, 160, 146, 149, 161, 158, 146, 128, 215, 145, 158, 133, 132, 131, 215, 155, 152, 150, 147, 215, 148, 152, 154, 135, 155, 146, 131, 146, 147 }, 247));
            }
            else if (_0xad1e39c7)
            {
                _0xad1e39c7 = false;
                _0x6ff6762e(false);
                _0xb165ee29.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xb11edeec._0x1de8009f(new byte[40] { 69, 105, 97, 102, 40, 95, 109, 106, 94, 97, 109, 127, 40, 91, 96, 103, 127, 40, 105, 110, 124, 109, 122, 40, 100, 103, 105, 108, 97, 102, 111, 40, 110, 97, 102, 97, 123, 96, 109, 108 }, 8));
            }
            else
            {
                _0x6ff6762e(false);
            }

            if (_0x75b37112 && !IsGoogleAuthFlowUrl(_0x6c491fbd) && !IsGoogleAuthFlowUrl(_0x6c491fbd))
            {
                WLog(_0xb11edeec._0x1de8009f(new byte[48] { 156, 180, 180, 188, 183, 190, 251, 186, 174, 175, 179, 251, 168, 190, 190, 182, 168, 251, 189, 178, 181, 178, 168, 179, 190, 191, 251, 246, 229, 251, 169, 190, 168, 175, 180, 169, 190, 251, 191, 190, 189, 186, 174, 183, 175, 251, 142, 154 }, 219));
                _0x75b37112 = false;
                _0x6a329bfa.SetUserAgent("");
            }
        };
        _0x9756fdf3.OnShouldClose += _0xb165ee29 =>
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[41] { 33, 46, 31, 9, 14, 39, 90, 55, 27, 19, 20, 90, 45, 31, 24, 44, 19, 31, 13, 90, 53, 20, 41, 18, 21, 15, 22, 30, 57, 22, 21, 9, 31, 90, 19, 20, 12, 21, 17, 31, 30 }, 122));
            _0x8df35525();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x9756fdf3.SetPopupPageEventEnabled(true);
        bool _0x87af88b4 = false;
        bool _0x910830e8 = false;
        _0x9756fdf3.OnMultipleWindowOpened += (_0xb165ee29, _0xfeb6d157) =>
        {
            _0xb165ee29.ScrollTo(0, 0, false);
            WLog(_0xb11edeec._0x1de8009f(new byte[43] { 154, 149, 164, 178, 181, 156, 225, 140, 160, 168, 175, 225, 150, 164, 163, 151, 168, 164, 182, 225, 140, 180, 173, 181, 168, 177, 173, 164, 150, 168, 175, 165, 174, 182, 225, 142, 177, 164, 175, 164, 165, 251, 225 }, 193) + _0xfeb6d157);
            var _0xb8b58d43 = _0x9756fdf3.GetPopupWindow(_0xfeb6d157);
            if (_0xb8b58d43 == null)
                return;
            _0xc10edd98.Add(_0xb8b58d43);
            Debug.Log($"[Test] Popup ID: {_0xb8b58d43.Id}");
            _0xb8b58d43.OnPageStarted += (_0xb1bfa6b8, _0x6c491fbd) =>
            {
                WLog(_0xb11edeec._0x1de8009f(new byte[36] { 194, 205, 252, 234, 237, 196, 185, 201, 246, 233, 236, 233, 185, 206, 252, 251, 207, 240, 252, 238, 185, 214, 247, 201, 248, 254, 252, 202, 237, 248, 235, 237, 252, 253, 163, 185 }, 153) + _0x6c491fbd);
                _0xb4f63dc9 = 0;
                if (string.IsNullOrEmpty(_0x6c491fbd) || IsAboutBlank(_0x6c491fbd))
                    return;
                if (IsGoogleAuthFlowUrl(_0x6c491fbd))
                {
                    WLog(_0xb11edeec._0x1de8009f(new byte[57] { 63, 48, 1, 23, 16, 57, 68, 52, 11, 20, 17, 20, 68, 35, 11, 11, 3, 8, 1, 68, 5, 17, 16, 12, 68, 2, 8, 11, 19, 68, 73, 90, 68, 23, 20, 11, 11, 2, 68, 35, 11, 11, 3, 8, 1, 68, 39, 12, 22, 11, 9, 1, 68, 49, 37, 94, 68 }, 100) + _0x6c491fbd);
                    _0x87af88b4 = false;
                    _0x7d521876();
                    if (_0xb1bfa6b8 != null && _0xb1bfa6b8.IsAlive)
                        _0xb1bfa6b8.EvaluateJavaScript(_0xfbdd9f50());
                    return;
                }

                if (_0x6a329bfa == null)
                    return;
                if (!_0x87af88b4)
                {
                    _0x87af88b4 = true;
                    _0x6a329bfa.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xb11edeec._0x1de8009f(new byte[39] { 201, 198, 247, 225, 230, 207, 178, 194, 253, 226, 231, 226, 178, 243, 226, 226, 254, 235, 178, 197, 251, 252, 246, 253, 229, 225, 178, 246, 247, 225, 249, 230, 253, 226, 178, 199, 211, 168, 178 }, 146) + _0x6c491fbd);
                }

                if (_0xb1bfa6b8 != null && _0xb1bfa6b8.IsAlive)
                    _0xb1bfa6b8.EvaluateJavaScript(_0x4faff544());
                if (!_0x910830e8 && _0xb1bfa6b8 != null && _0xb1bfa6b8.IsAlive && IsHttpUrl(_0x6c491fbd))
                {
                    _0x910830e8 = true;
                }
            };
            _0xb8b58d43.OnPageFinished += (_0xb1bfa6b8, _0xecc620de) =>
            {
                string _0xba999e4e = _0xecc620de != null ? _0xecc620de.data : string.Empty;
                WLog(_0xb11edeec._0x1de8009f(new byte[35] { 137, 134, 183, 161, 166, 143, 242, 130, 189, 162, 167, 162, 242, 133, 183, 176, 132, 187, 183, 165, 242, 148, 187, 188, 187, 161, 186, 183, 182, 232, 242, 167, 160, 190, 239 }, 210) + _0xba999e4e);
                if (_0xb1bfa6b8 == null || !_0xb1bfa6b8.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xba999e4e))
                {
                    _0x7d521876();
                    _0xb1bfa6b8.EvaluateJavaScript(_0xfbdd9f50());
                    return;
                }

                if (!_0x87af88b4)
                    return;
                _0xb1bfa6b8.EvaluateJavaScript(_0x4faff544());
            };
        };
        _0x9756fdf3.OnMultipleWindowClosed += (_0xb165ee29, _0xfeb6d157) =>
        {
            _0xc10edd98.RemoveAll(_0x61dea055 => _0x61dea055 == null || _0x61dea055.Id == _0xfeb6d157 || !_0x61dea055.IsAlive);
            _0x6ff6762e(false);
            if (_0xc10edd98.Count == 0 && _0x6a329bfa != null)
            {
                _0x87af88b4 = false;
                _0x910830e8 = false;
                _0xf04ae4fd();
            }

            WLog(_0xb11edeec._0x1de8009f(new byte[43] { 145, 158, 175, 185, 190, 151, 234, 135, 171, 163, 164, 234, 157, 175, 168, 156, 163, 175, 189, 234, 135, 191, 166, 190, 163, 186, 166, 175, 157, 163, 164, 174, 165, 189, 234, 137, 166, 165, 185, 175, 174, 240, 234 }, 202) + _0xfeb6d157);
        };
        _0x9756fdf3.RegisterOnRequestMediaCapturePermission(_0x3fbd2a43 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal bool IsHttpUrl(string _0x009d9a11)
    {
        if (string.IsNullOrEmpty(_0x009d9a11))
            return false;
        return _0x009d9a11.StartsWith(_0xb11edeec._0x1de8009f(new byte[7] { 205, 209, 209, 213, 159, 138, 138 }, 165), StringComparison.OrdinalIgnoreCase) || _0x009d9a11.StartsWith(_0xb11edeec._0x1de8009f(new byte[8] { 179, 175, 175, 171, 168, 225, 244, 244 }, 219), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x6ff6762e(bool _0x100484b5)
    {
        _0x87fca9f8();
        _0xc7fdd2fd.SetActive(_0x100484b5);
        _0x33e9a0b8 = _0x100484b5;
        if (_0x100484b5)
        {
            _0xc7fdd2fd.transform.SetAsLastSibling();
            if (_0x9b8e5f18 != null)
                _0x9b8e5f18.localRotation = Quaternion.identity;
        }
    }

    private GameObject _0xc7fdd2fd;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xf7a61fa5(string _0xf1eafcca, string _0xfcaba69f)
    {
        try
        {
            using var _0xdcea8f7e = Aes.Create();
            _0xdcea8f7e.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xfcaba69f));
            _0xdcea8f7e.GenerateIV();
            using var _0xa677297a = new MemoryStream();
            _0xa677297a.Write(_0xdcea8f7e.IV, 0, _0xdcea8f7e.IV.Length);
            using (var _0x6ff40d8c = new CryptoStream(_0xa677297a, _0xdcea8f7e.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x665d27e3 = Encoding.UTF8.GetBytes(_0xf1eafcca);
                _0x6ff40d8c.Write(_0x665d27e3, 0, _0x665d27e3.Length);
                _0x6ff40d8c.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xa677297a.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private Action _0x076e4250;
    private string _0xe7aaf485()
    {
        string _0xc1bbd158 = _0xb11edeec._0x1de8009f(new byte[62] { 222, 221, 220, 219, 218, 217, 216, 215, 214, 213, 212, 211, 210, 209, 208, 207, 206, 205, 204, 203, 202, 201, 200, 199, 198, 197, 254, 253, 252, 251, 250, 249, 248, 247, 246, 245, 244, 243, 242, 241, 240, 239, 238, 237, 236, 235, 234, 233, 232, 231, 230, 229, 143, 142, 141, 140, 139, 138, 137, 136, 135, 134 }, 191);
        System.Random _0xc77d3e3a = new System.Random();
        int _0xe0c917e8 = _0xc77d3e3a.Next(8, 16);
        return new string (Enumerable.Repeat(_0xc1bbd158, _0xe0c917e8).Select(_0x9be1d7b3 => _0x9be1d7b3[_0xc77d3e3a.Next(_0x9be1d7b3.Length)]).ToArray());
    }

    public void _0xb1c34085()
    {
        if (_0x166e15e0)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[33] { 166, 169, 152, 142, 137, 160, 221, 169, 148, 144, 152, 143, 221, 146, 136, 137, 221, 208, 195, 221, 144, 146, 139, 152, 221, 137, 146, 221, 142, 158, 152, 147, 152 }, 253));
            }
#endif
        }

        _0x735c3a7b();
    }

    private IEnumerator _0x4f0dc90c(string _0xa3a5a84f)
    {
        if (Permission.HasUserAuthorizedPermission(_0xa3a5a84f))
            yield break;
        bool _0x40eb72b2 = false;
        var _0xa811a73b = new PermissionCallbacks();
        _0xa811a73b.PermissionGranted += _0xa1df1f7e => _0x40eb72b2 = true;
        _0xa811a73b.PermissionDenied += _0xa1df1f7e => _0x40eb72b2 = true;
        Permission.RequestUserPermission(_0xa3a5a84f, _0xa811a73b);
        yield return new WaitUntil(() => _0x40eb72b2);
    }

    private string _0x43fc6de6 = "";
    private bool _0xdc7b42e2()
    {
        _0xc10edd98.RemoveAll(_0x61dea055 => _0x61dea055 == null || !_0x61dea055.IsAlive);
        return _0xc10edd98.Count > 0;
    }

    private void _0xb94017f3()
    {
        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[22] { 192, 207, 254, 232, 239, 198, 187, 200, 239, 244, 233, 254, 223, 254, 237, 242, 248, 254, 210, 245, 253, 244 }, 155));
#endif
        }

        _0x7819158e = SystemInfo.deviceModel;
        _0x43fc6de6 = Application.version;
        _0xe8e364c1 = Application.installMode;
        _0x0856737c = Application.installerName;
        _0x9044ffe2 = Application.identifier;
        _0x9ae07dd1 = _0x551f5da1();
        _0x2f1caddc = _0xb0d28e8f();
        _0xf3eed12c = SystemInfo.deviceUniqueIdentifier;
        _0x6f6f5584 = SystemInfo.graphicsDeviceName;
        _0xc70bb372 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x43fc6de6 = _0xb11edeec._0x1de8009f(new byte[5] { 154, 131, 154, 131, 154 }, 173);
                _0xe8e364c1 = ApplicationInstallMode.Store;
                _0x0856737c = _0xb11edeec._0x1de8009f(new byte[19] { 237, 225, 227, 160, 239, 224, 234, 252, 225, 231, 234, 160, 248, 235, 224, 234, 231, 224, 233 }, 142);
                _0x2f1caddc = _0xb11edeec._0x1de8009f(new byte[8] { 199, 207, 210, 214, 219, 130, 215, 195 }, 162);
                _0xf3eed12c = Guid.NewGuid().ToString().Replace(_0xb11edeec._0x1de8009f(new byte[1] { 22 }, 59), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[17] { 208, 223, 238, 248, 255, 214, 171, 239, 238, 253, 198, 228, 239, 238, 231, 177, 171 }, 139) + _0x7819158e);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[19] { 115, 124, 77, 91, 92, 117, 8, 73, 88, 88, 126, 77, 90, 91, 65, 71, 70, 18, 8 }, 40) + _0x43fc6de6);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[20] { 231, 232, 217, 207, 200, 225, 156, 213, 210, 207, 200, 221, 208, 208, 241, 211, 216, 217, 134, 156 }, 188) + _0xe8e364c1);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[23] { 233, 230, 215, 193, 198, 239, 146, 219, 220, 193, 198, 211, 222, 222, 215, 192, 225, 198, 221, 192, 215, 136, 146 }, 178) + _0x0856737c);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[14] { 6, 9, 56, 46, 41, 0, 125, 60, 45, 45, 20, 57, 103, 125 }, 93) + _0x9044ffe2);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[14] { 2, 13, 60, 42, 45, 4, 121, 56, 61, 47, 16, 61, 99, 121 }, 89) + _0x9ae07dd1);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[18] { 213, 218, 235, 253, 250, 211, 174, 251, 253, 235, 252, 207, 233, 235, 224, 250, 180, 174 }, 142) + _0x2f1caddc);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[17] { 81, 94, 111, 121, 126, 87, 42, 121, 115, 121, 78, 111, 124, 67, 110, 48, 42 }, 10) + _0xf3eed12c);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[12] { 128, 143, 190, 168, 175, 134, 251, 188, 171, 174, 225, 251 }, 219) + _0x6f6f5584);
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[12] { 254, 241, 192, 214, 209, 248, 133, 198, 213, 208, 159, 133 }, 165) + _0xc70bb372);
#endif
        }
    }

    private async Task<bool> _0x527ce3da()
    {
        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[29] { 144, 159, 174, 184, 191, 150, 235, 130, 184, 155, 185, 162, 189, 170, 168, 178, 138, 165, 175, 152, 170, 189, 174, 175, 136, 163, 174, 168, 160 }, 203));
#endif
        }

        string _0x80a13b42 = "";
        for (int _0xf92356b3 = 0; _0xf92356b3 < 2; _0xf92356b3++)
        {
            if (await _0x6db12b35(1, 100))
            {
                await _0xd689168a(_0xb11edeec._0x1de8009f(new byte[7] { 196, 202, 201, 197, 205, 195, 194 }, 166));
                _0x735c3a7b();
                return true;
            }

            _0x80a13b42 = await _0xb03c39c5(1, 100);
            if (!string.IsNullOrEmpty(_0x80a13b42))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x80a13b42))
            {
                if (!string.IsNullOrEmpty(_0x07deb841))
                {
                    _0x80a13b42 = _0x2eac393c(_0x80a13b42, _0x07deb841);
                    {
#if B_LOGS
                        Debug.Log(_0xb11edeec._0x1de8009f(new byte[53] { 107, 100, 85, 67, 68, 109, 16, 115, 81, 83, 88, 85, 84, 16, 86, 89, 94, 81, 92, 101, 66, 92, 16, 71, 89, 68, 88, 16, 67, 85, 94, 84, 89, 84, 16, 210, 182, 162, 16, 67, 88, 95, 71, 16, 103, 85, 82, 102, 89, 85, 71, 10, 16 }, 48) + _0x80a13b42);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xb11edeec._0x1de8009f(new byte[39] { 37, 42, 27, 13, 10, 35, 94, 61, 31, 29, 22, 27, 26, 94, 24, 23, 16, 31, 18, 43, 12, 18, 94, 156, 248, 236, 94, 13, 22, 17, 9, 94, 41, 27, 28, 40, 23, 27, 9 }, 126));
#endif
                    }
                }

                _0xe64b4e5c = true;
                _0x7afbad31(_0x80a13b42);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[44] { 240, 255, 206, 216, 223, 246, 139, 238, 211, 200, 206, 219, 223, 194, 196, 197, 139, 220, 195, 194, 199, 206, 139, 200, 195, 206, 200, 192, 194, 197, 204, 139, 216, 202, 221, 206, 207, 139, 199, 194, 197, 192, 145, 139 }, 171) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0xe5511bfd { get; set; }

    private string _0xf3eed12c = "";
    private bool OpenUrlExternally(string _0xe5a43aba)
    {
        return _0xf1039cdc(_0xe5a43aba);
    }

    internal bool isApplicationPause = false;
    private bool _0xf06fffc9(string _0xf68a68af, string _0xaf3cee32)
    {
        string _0x2c558465 = _0x308f1707(_0xf68a68af);
        if (string.IsNullOrEmpty(_0x2c558465))
            _0x2c558465 = _0xaf3cee32;
        if (_0x415c13bc(_0x2c558465))
            return true;
        string _0xf33e86f8 = string.IsNullOrEmpty(_0x2c558465) ? _0xb11edeec._0x1de8009f(new byte[29] { 164, 184, 184, 188, 191, 246, 227, 227, 188, 160, 173, 181, 226, 171, 163, 163, 171, 160, 169, 226, 175, 163, 161, 227, 191, 184, 163, 190, 169 }, 204) : _0xb11edeec._0x1de8009f(new byte[46] { 71, 91, 91, 95, 92, 21, 0, 0, 95, 67, 78, 86, 1, 72, 64, 64, 72, 67, 74, 1, 76, 64, 66, 0, 92, 91, 64, 93, 74, 0, 78, 95, 95, 92, 0, 75, 74, 91, 78, 70, 67, 92, 16, 70, 75, 18 }, 47) + _0x2c558465;
        WLog(_0xb11edeec._0x1de8009f(new byte[35] { 213, 254, 228, 249, 251, 243, 218, 255, 253, 243, 182, 251, 247, 228, 253, 243, 226, 182, 240, 247, 250, 250, 244, 247, 245, 253, 182, 247, 229, 182, 225, 243, 244, 172, 182 }, 150) + _0xf33e86f8);
        return _0xf1039cdc(_0xf33e86f8);
    }

    private async Task<bool> _0x2e52b269()
    {
        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[37] { 193, 206, 255, 233, 238, 199, 186, 201, 243, 253, 244, 211, 244, 207, 244, 243, 238, 227, 201, 255, 232, 236, 243, 249, 255, 233, 219, 244, 245, 244, 227, 247, 245, 239, 233, 246, 227 }, 154));
#endif
        }

        try
        {
            var _0x0e3a2c18 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x0e3a2c18);
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[32] { 107, 100, 85, 67, 68, 109, 16, 101, 94, 89, 68, 73, 99, 85, 66, 70, 89, 83, 85, 67, 16, 121, 94, 89, 68, 89, 81, 92, 89, 74, 85, 84 }, 48));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[20] { 4, 21, 3, 4, 112, 5, 62, 57, 36, 41, 3, 53, 34, 38, 57, 51, 53, 35, 106, 112 }, 80) + ex.Message);
#endif
            }

            _0xf08c2322?._0x735c3a7b();
            return true;
        }

        bool _0x7742113d = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x7742113d = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xb11edeec._0x1de8009f(new byte[37] { 30, 17, 32, 54, 49, 24, 101, 22, 44, 34, 43, 104, 44, 43, 101, 4, 43, 42, 43, 60, 40, 42, 48, 54, 107, 101, 21, 41, 36, 60, 32, 55, 101, 12, 1, 127, 101 }, 69) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xa53eb895 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[25] { 176, 161, 183, 176, 196, 183, 141, 131, 138, 201, 141, 138, 196, 165, 145, 144, 140, 196, 161, 182, 182, 171, 182, 222, 196 }, 228) + ex.Message);
#endif
                }

                _0xf08c2322?._0x735c3a7b();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[28] { 114, 99, 117, 114, 6, 117, 79, 65, 72, 11, 79, 72, 6, 116, 67, 87, 83, 67, 85, 82, 6, 99, 116, 116, 105, 116, 28, 6 }, 38) + ex.Message);
#endif
                }

                _0xf08c2322?._0x735c3a7b();
                return true;
            }
        }
        while (!_0x7742113d);
        return false;
    }

    internal bool ContainsIgnoreCase(string _0x500e2290, string _0xf91a8c05)
    {
        if (string.IsNullOrEmpty(_0x500e2290) || string.IsNullOrEmpty(_0xf91a8c05))
            return false;
        return _0x500e2290.IndexOf(_0xf91a8c05, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x01bdaaea = "";
    private string _0xfbd31b8e = "";
    private string _0x2f1caddc = "";
    internal bool isDestroyedForce = false;
    private void WLog(string _0xa5339689)
    {
#if B_LOGS
        {
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[7] { 47, 32, 17, 7, 0, 41, 84 }, 116) + _0xa5339689);
        }
#endif
    }

    private string _0xc70bb372 = "";
    private bool _0x9021c467(string _0x472bdc26)
    {
        try
        {
            using (var _0xc4952dc5 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 140, 128, 130, 193, 154, 129, 134, 155, 150, 220, 139, 193, 159, 131, 142, 150, 138, 157, 193, 186, 129, 134, 155, 150, 191, 131, 142, 150, 138, 157 }, 239)))
            using (var _0xab5fe664 = _0xc4952dc5.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 26, 12, 11, 11, 28, 23, 13, 56, 26, 13, 16, 15, 16, 13, 0 }, 121)))
            using (var _0x9c9794f2 = _0xab5fe664.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[17] { 73, 75, 90, 126, 79, 77, 69, 79, 73, 75, 99, 79, 64, 79, 73, 75, 92 }, 46)))
            using (var _0x9c962a69 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[22] { 246, 249, 243, 229, 248, 254, 243, 185, 244, 248, 249, 227, 242, 249, 227, 185, 222, 249, 227, 242, 249, 227 }, 151)))
            using (var _0x0ca844b4 = _0x9c962a69.CallStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[8] { 129, 144, 131, 130, 148, 164, 131, 152 }, 241), _0x472bdc26, 1))
            {
                string _0xe71b9047 = _0x0ca844b4.Call<string>(_0xb11edeec._0x1de8009f(new byte[14] { 138, 136, 153, 190, 153, 159, 132, 131, 138, 168, 149, 153, 159, 140 }, 237), _0xb11edeec._0x1de8009f(new byte[20] { 110, 126, 99, 123, 127, 105, 126, 83, 106, 109, 96, 96, 110, 109, 111, 103, 83, 121, 126, 96 }, 12));
                string _0xa7bbc571 = _0x0ca844b4.Call<string>(_0xb11edeec._0x1de8009f(new byte[10] { 242, 240, 225, 197, 244, 246, 254, 244, 242, 240 }, 149));
                _0x0ca844b4.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[11] { 216, 221, 221, 250, 216, 205, 220, 222, 214, 203, 192 }, 185), _0xb11edeec._0x1de8009f(new byte[33] { 70, 73, 67, 85, 72, 78, 67, 9, 78, 73, 83, 66, 73, 83, 9, 68, 70, 83, 66, 64, 72, 85, 94, 9, 101, 117, 104, 112, 116, 102, 101, 107, 98 }, 39));
                _0x0ca844b4.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[11] { 3, 20, 28, 30, 7, 20, 52, 9, 5, 3, 16 }, 113), _0xb11edeec._0x1de8009f(new byte[20] { 89, 73, 84, 76, 72, 94, 73, 100, 93, 90, 87, 87, 89, 90, 88, 80, 100, 78, 73, 87 }, 59));
                if (_0x0ca844b4.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 38, 49, 39, 59, 56, 34, 49, 21, 55, 32, 61, 34, 61, 32, 45 }, 84), _0x9c9794f2) != null)
                {
                    WLog(_0xb11edeec._0x1de8009f(new byte[24] { 60, 23, 13, 16, 18, 26, 51, 22, 20, 26, 95, 16, 15, 26, 17, 95, 22, 17, 11, 26, 17, 11, 69, 95 }, 127) + _0x472bdc26);
                    _0x0ca844b4.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[8] { 67, 70, 70, 100, 78, 67, 69, 81 }, 34), 0x10000000);
                    _0xab5fe664.Call(_0xb11edeec._0x1de8009f(new byte[13] { 71, 64, 85, 70, 64, 117, 87, 64, 93, 66, 93, 64, 77 }, 52), _0x0ca844b4);
                    return true;
                }

                if (_0x415c13bc(_0xa7bbc571))
                    return true;
                if (!string.IsNullOrEmpty(_0xe71b9047))
                {
                    WLog(_0xb11edeec._0x1de8009f(new byte[28] { 211, 248, 226, 255, 253, 245, 220, 249, 251, 245, 176, 249, 254, 228, 245, 254, 228, 176, 246, 241, 252, 252, 242, 241, 243, 251, 170, 176 }, 144) + _0xe71b9047);
                    if (_0x3f8300c9(_0xe71b9047))
                        return _0xf06fffc9(_0xe71b9047, _0xa7bbc571);
                    return _0xf1039cdc(_0xe71b9047);
                }

                WLog(_0xb11edeec._0x1de8009f(new byte[30] { 196, 239, 245, 232, 234, 226, 203, 238, 236, 226, 167, 238, 233, 243, 226, 233, 243, 167, 233, 232, 167, 239, 230, 233, 227, 235, 226, 245, 189, 167 }, 135) + _0x472bdc26);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[26] { 168, 131, 153, 132, 134, 142, 167, 130, 128, 142, 203, 130, 133, 159, 142, 133, 159, 203, 141, 138, 130, 135, 142, 143, 209, 203 }, 235) + e.Message);
            return true;
        }
    }

    private readonly string[] _0xbfcc39ac = new string[]
    {
        _0xb11edeec._0x1de8009f(new byte[60] { 248, 151, 134, 184, 40, 92, 96, 109, 40, 122, 109, 109, 100, 123, 40, 105, 122, 109, 40, 96, 103, 124, 40, 122, 97, 111, 96, 124, 40, 102, 103, 127, 40, 234, 136, 155, 40, 108, 103, 102, 234, 136, 145, 124, 40, 101, 97, 123, 123, 40, 113, 103, 125, 122, 40, 123, 120, 97, 102, 41 }, 8),
        _0xb11edeec._0x1de8009f(new byte[52] { 212, 187, 169, 164, 4, 109, 80, 4, 71, 75, 81, 72, 64, 4, 70, 65, 4, 93, 75, 81, 86, 4, 72, 81, 71, 79, 93, 4, 73, 75, 73, 65, 74, 80, 4, 198, 164, 183, 4, 83, 76, 93, 4, 87, 80, 75, 84, 4, 74, 75, 83, 27 }, 36),
        _0xb11edeec._0x1de8009f(new byte[66] { 148, 236, 215, 153, 206, 249, 86, 52, 31, 17, 86, 1, 31, 24, 5, 86, 23, 4, 19, 86, 30, 31, 2, 2, 31, 24, 17, 86, 27, 25, 4, 19, 86, 25, 16, 2, 19, 24, 86, 2, 25, 18, 23, 15, 86, 148, 246, 229, 86, 5, 2, 23, 15, 86, 31, 24, 86, 2, 30, 19, 86, 17, 23, 27, 19, 88 }, 118),
        _0xb11edeec._0x1de8009f(new byte[54] { 173, 194, 200, 207, 125, 9, 53, 52, 46, 125, 52, 46, 125, 45, 47, 52, 48, 56, 125, 41, 52, 48, 56, 125, 191, 221, 206, 125, 41, 53, 56, 125, 63, 56, 46, 41, 125, 45, 49, 60, 36, 56, 47, 46, 125, 45, 49, 60, 36, 125, 51, 50, 42, 115 }, 93),
        _0xb11edeec._0x1de8009f(new byte[48] { 228, 139, 128, 177, 52, 77, 123, 97, 102, 52, 99, 125, 122, 122, 125, 122, 115, 52, 103, 96, 102, 113, 117, 127, 52, 119, 123, 97, 120, 112, 52, 118, 113, 52, 123, 122, 113, 52, 103, 100, 125, 122, 52, 117, 99, 117, 109, 58 }, 20),
        _0xb11edeec._0x1de8009f(new byte[65] { 193, 174, 171, 177, 17, 123, 80, 82, 90, 65, 94, 69, 66, 17, 80, 67, 84, 17, 92, 94, 67, 84, 17, 80, 82, 69, 88, 71, 84, 17, 69, 94, 95, 88, 86, 89, 69, 17, 211, 177, 162, 17, 66, 69, 80, 72, 17, 80, 95, 85, 17, 69, 67, 72, 17, 72, 94, 68, 67, 17, 93, 68, 82, 90, 31 }, 49),
        _0xb11edeec._0x1de8009f(new byte[55] { 156, 243, 226, 222, 76, 41, 26, 9, 30, 21, 76, 31, 28, 5, 2, 76, 15, 3, 25, 2, 24, 31, 76, 142, 236, 255, 76, 24, 4, 9, 76, 2, 9, 20, 24, 76, 3, 2, 9, 76, 15, 3, 25, 0, 8, 76, 14, 9, 76, 21, 3, 25, 30, 31, 66 }, 108),
        _0xb11edeec._0x1de8009f(new byte[63] { 250, 181, 136, 247, 160, 151, 56, 72, 116, 121, 97, 125, 106, 107, 56, 106, 113, 127, 112, 108, 56, 118, 119, 111, 56, 121, 106, 125, 56, 111, 113, 118, 118, 113, 118, 127, 56, 250, 152, 139, 56, 124, 119, 118, 250, 152, 129, 108, 56, 111, 121, 116, 115, 56, 121, 111, 121, 97, 56, 97, 125, 108, 54 }, 24),
        _0xb11edeec._0x1de8009f(new byte[51] { 3, 108, 124, 117, 211, 188, 157, 159, 138, 211, 135, 155, 156, 128, 150, 211, 132, 155, 156, 211, 128, 135, 146, 138, 211, 154, 157, 211, 135, 155, 150, 211, 148, 146, 158, 150, 211, 132, 154, 157, 211, 135, 155, 150, 211, 131, 129, 154, 137, 150, 221 }, 243),
        _0xb11edeec._0x1de8009f(new byte[64] { 144, 232, 211, 157, 202, 253, 82, 63, 29, 31, 23, 28, 6, 7, 31, 82, 27, 1, 82, 23, 4, 23, 0, 11, 6, 26, 27, 28, 21, 82, 144, 242, 225, 82, 25, 23, 23, 2, 82, 1, 2, 27, 28, 28, 27, 28, 21, 82, 20, 29, 0, 82, 11, 29, 7, 0, 82, 17, 26, 19, 28, 17, 23, 92 }, 114)
    };
    private ApplicationInstallMode _0xe8e364c1 = ApplicationInstallMode.Unknown;
    private UniWebViewPopup _0x69493401()
    {
        for (int _0xbf815838 = _0xc10edd98.Count - 1; _0xbf815838 >= 0; _0xbf815838--)
        {
            var _0x54ad9655 = _0xc10edd98[_0xbf815838];
            if (_0x54ad9655 != null && _0x54ad9655.IsAlive)
                return _0x54ad9655;
            _0xc10edd98.RemoveAt(_0xbf815838);
        }

        return null;
    }

    internal void _0xa0542076()
    {
        Rect _0x7186cb8c = Screen.safeArea;
        Vector2 _0xd8de28bc = new Vector2(Screen.width, Screen.height);
        if (_0x7186cb8c == lastSafe && _0xd8de28bc == lastSize)
            return;
        // Apply manual padding
        _0x7186cb8c.xMin += _0xee2b8627;
        _0x7186cb8c.xMax -= _0x901af057;
        _0x7186cb8c.yMin += _0x8236b488;
        _0x7186cb8c.yMax -= _0x5cba5a5f;
        // Convert Unity safe area -> native WebView frame
        Rect _0xa8434d8d = new Rect(_0x7186cb8c.x, _0xd8de28bc.y - _0x7186cb8c.y - _0x7186cb8c.height, // Y flip for native coordinate system
 _0x7186cb8c.width, _0x7186cb8c.height);
        _0x6a329bfa.Frame = _0xa8434d8d;
        lastSafe = Screen.safeArea;
        lastSize = _0xd8de28bc;
    }

    private string _0x9044ffe2 = "";
    private string _0xb25a332c = "";
    private string _0x5cadc9ae { get; set; }

    private string _0x4faff544()
    {
        return _0xb11edeec._0x1de8009f(new byte[12] { 194, 140, 159, 132, 137, 158, 131, 133, 132, 194, 195, 145 }, 234) + _0xb11edeec._0x1de8009f(new byte[8] { 49, 38, 53, 103, 50, 38, 122, 96 }, 71) + WindowsDesktopUserAgent + _0xb11edeec._0x1de8009f(new byte[2] { 100, 120 }, 67) + _0xb11edeec._0x1de8009f(new byte[30] { 225, 246, 229, 183, 231, 229, 248, 227, 248, 170, 217, 246, 225, 254, 240, 246, 227, 248, 229, 185, 231, 229, 248, 227, 248, 227, 238, 231, 242, 172 }, 151) + _0xb11edeec._0x1de8009f(new byte[121] { 89, 74, 81, 92, 75, 86, 80, 81, 31, 91, 90, 89, 23, 80, 93, 85, 19, 84, 90, 70, 19, 73, 94, 83, 22, 68, 75, 77, 70, 68, 112, 93, 85, 90, 92, 75, 17, 91, 90, 89, 86, 81, 90, 111, 77, 80, 79, 90, 77, 75, 70, 23, 80, 93, 85, 19, 84, 90, 70, 19, 68, 88, 90, 75, 5, 89, 74, 81, 92, 75, 86, 80, 81, 23, 22, 68, 77, 90, 75, 74, 77, 81, 31, 73, 94, 83, 4, 66, 19, 92, 80, 81, 89, 86, 88, 74, 77, 94, 93, 83, 90, 5, 75, 77, 74, 90, 66, 22, 4, 66, 92, 94, 75, 92, 87, 23, 90, 22, 68, 66, 66 }, 63) + _0xb11edeec._0x1de8009f(new byte[26] { 8, 9, 10, 68, 28, 30, 3, 24, 3, 64, 75, 25, 31, 9, 30, 45, 11, 9, 2, 24, 75, 64, 25, 13, 69, 87 }, 108) + _0xb11edeec._0x1de8009f(new byte[130] { 187, 186, 185, 247, 175, 173, 176, 171, 176, 243, 248, 190, 175, 175, 137, 186, 173, 172, 182, 176, 177, 248, 243, 248, 234, 241, 239, 255, 247, 136, 182, 177, 187, 176, 168, 172, 255, 145, 139, 255, 238, 239, 241, 239, 228, 255, 136, 182, 177, 233, 235, 228, 255, 167, 233, 235, 246, 255, 158, 175, 175, 179, 186, 136, 186, 189, 148, 182, 171, 240, 234, 236, 232, 241, 236, 233, 255, 247, 148, 151, 139, 146, 147, 243, 255, 179, 182, 180, 186, 255, 152, 186, 188, 180, 176, 246, 255, 156, 183, 173, 176, 178, 186, 240, 238, 237, 239, 241, 239, 241, 239, 241, 239, 255, 140, 190, 185, 190, 173, 182, 240, 234, 236, 232, 241, 236, 233, 248, 246, 228 }, 223) + _0xb11edeec._0x1de8009f(new byte[30] { 4, 5, 6, 72, 16, 18, 15, 20, 15, 76, 71, 16, 12, 1, 20, 6, 15, 18, 13, 71, 76, 71, 55, 9, 14, 83, 82, 71, 73, 91 }, 96) + _0xb11edeec._0x1de8009f(new byte[34] { 21, 20, 23, 89, 1, 3, 30, 5, 30, 93, 86, 7, 20, 31, 21, 30, 3, 86, 93, 86, 54, 30, 30, 22, 29, 20, 81, 56, 31, 18, 95, 86, 88, 74 }, 113) + _0xb11edeec._0x1de8009f(new byte[30] { 141, 140, 143, 193, 153, 155, 134, 157, 134, 197, 206, 132, 136, 145, 189, 134, 156, 138, 129, 185, 134, 128, 135, 157, 154, 206, 197, 217, 192, 210 }, 233) + _0xb11edeec._0x1de8009f(new byte[449] { 194, 196, 207, 205, 192, 215, 196, 150, 195, 215, 210, 139, 205, 212, 196, 215, 216, 210, 197, 140, 237, 205, 212, 196, 215, 216, 210, 140, 145, 245, 222, 196, 217, 219, 223, 195, 219, 145, 154, 192, 211, 196, 197, 223, 217, 216, 140, 145, 135, 132, 134, 145, 203, 154, 205, 212, 196, 215, 216, 210, 140, 145, 241, 217, 217, 209, 218, 211, 150, 245, 222, 196, 217, 219, 211, 145, 154, 192, 211, 196, 197, 223, 217, 216, 140, 145, 135, 132, 134, 145, 203, 154, 205, 212, 196, 215, 216, 210, 140, 145, 248, 217, 194, 139, 247, 137, 244, 196, 215, 216, 210, 145, 154, 192, 211, 196, 197, 223, 217, 216, 140, 145, 132, 130, 145, 203, 235, 154, 219, 217, 212, 223, 218, 211, 140, 208, 215, 218, 197, 211, 154, 198, 218, 215, 194, 208, 217, 196, 219, 140, 145, 225, 223, 216, 210, 217, 193, 197, 145, 154, 209, 211, 194, 254, 223, 209, 222, 243, 216, 194, 196, 217, 198, 207, 224, 215, 218, 195, 211, 197, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 196, 211, 194, 195, 196, 216, 150, 230, 196, 217, 219, 223, 197, 211, 152, 196, 211, 197, 217, 218, 192, 211, 158, 205, 215, 196, 213, 222, 223, 194, 211, 213, 194, 195, 196, 211, 140, 145, 206, 142, 128, 145, 154, 212, 223, 194, 216, 211, 197, 197, 140, 145, 128, 130, 145, 154, 219, 217, 212, 223, 218, 211, 140, 208, 215, 218, 197, 211, 154, 219, 217, 210, 211, 218, 140, 145, 145, 154, 198, 218, 215, 194, 208, 217, 196, 219, 140, 145, 225, 223, 216, 210, 217, 193, 197, 145, 154, 198, 218, 215, 194, 208, 217, 196, 219, 224, 211, 196, 197, 223, 217, 216, 140, 145, 135, 131, 152, 134, 152, 134, 145, 154, 195, 215, 240, 195, 218, 218, 224, 211, 196, 197, 223, 217, 216, 140, 145, 135, 132, 134, 152, 134, 152, 134, 152, 134, 145, 203, 159, 141, 203, 203, 141, 249, 212, 220, 211, 213, 194, 152, 210, 211, 208, 223, 216, 211, 230, 196, 217, 198, 211, 196, 194, 207, 158, 198, 196, 217, 194, 217, 154, 145, 195, 197, 211, 196, 247, 209, 211, 216, 194, 242, 215, 194, 215, 145, 154, 205, 209, 211, 194, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 196, 211, 194, 195, 196, 216, 150, 195, 215, 210, 141, 203, 154, 213, 217, 216, 208, 223, 209, 195, 196, 215, 212, 218, 211, 140, 194, 196, 195, 211, 203, 159, 141, 203, 213, 215, 194, 213, 222, 158, 211, 159, 205, 203 }, 182) + _0xb11edeec._0x1de8009f(new byte[112] { 164, 165, 166, 232, 179, 163, 178, 165, 165, 174, 236, 231, 183, 169, 164, 180, 168, 231, 236, 241, 249, 242, 240, 233, 251, 164, 165, 166, 232, 179, 163, 178, 165, 165, 174, 236, 231, 168, 165, 169, 167, 168, 180, 231, 236, 241, 240, 248, 240, 233, 251, 164, 165, 166, 232, 179, 163, 178, 165, 165, 174, 236, 231, 161, 182, 161, 169, 172, 151, 169, 164, 180, 168, 231, 236, 241, 249, 242, 240, 233, 251, 164, 165, 166, 232, 179, 163, 178, 165, 165, 174, 236, 231, 161, 182, 161, 169, 172, 136, 165, 169, 167, 168, 180, 231, 236, 241, 240, 244, 240, 233, 251 }, 192) + _0xb11edeec._0x1de8009f(new byte[45] { 102, 96, 107, 105, 101, 123, 124, 118, 125, 101, 60, 125, 124, 102, 125, 103, 113, 122, 97, 102, 115, 96, 102, 47, 103, 124, 118, 119, 116, 123, 124, 119, 118, 41, 111, 113, 115, 102, 113, 122, 58, 119, 59, 105, 111 }, 18) + _0xb11edeec._0x1de8009f(new byte[721] { 1, 7, 12, 14, 3, 20, 7, 85, 26, 7, 28, 18, 72, 2, 28, 27, 17, 26, 2, 91, 24, 20, 1, 22, 29, 56, 16, 17, 28, 20, 91, 23, 28, 27, 17, 93, 2, 28, 27, 17, 26, 2, 92, 78, 2, 28, 27, 17, 26, 2, 91, 24, 20, 1, 22, 29, 56, 16, 17, 28, 20, 72, 19, 0, 27, 22, 1, 28, 26, 27, 93, 4, 92, 14, 3, 20, 7, 85, 6, 72, 38, 1, 7, 28, 27, 18, 93, 4, 92, 91, 1, 26, 57, 26, 2, 16, 7, 54, 20, 6, 16, 93, 92, 78, 28, 19, 93, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 5, 26, 28, 27, 1, 16, 7, 79, 85, 22, 26, 20, 7, 6, 16, 82, 92, 75, 72, 69, 9, 9, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 29, 26, 3, 16, 7, 79, 85, 27, 26, 27, 16, 82, 92, 75, 72, 69, 9, 9, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 24, 20, 13, 88, 2, 28, 17, 1, 29, 82, 92, 75, 72, 69, 9, 9, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 24, 20, 13, 88, 17, 16, 3, 28, 22, 16, 88, 2, 28, 17, 1, 29, 82, 92, 75, 72, 69, 92, 7, 16, 1, 0, 7, 27, 85, 14, 24, 20, 1, 22, 29, 16, 6, 79, 19, 20, 25, 6, 16, 89, 24, 16, 17, 28, 20, 79, 4, 89, 26, 27, 22, 29, 20, 27, 18, 16, 79, 27, 0, 25, 25, 89, 20, 17, 17, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 7, 16, 24, 26, 3, 16, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 20, 17, 17, 48, 3, 16, 27, 1, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 7, 16, 24, 26, 3, 16, 48, 3, 16, 27, 1, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 17, 28, 6, 5, 20, 1, 22, 29, 48, 3, 16, 27, 1, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 7, 16, 1, 0, 7, 27, 85, 19, 20, 25, 6, 16, 78, 8, 8, 78, 28, 19, 93, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 5, 26, 28, 27, 1, 16, 7, 79, 85, 19, 28, 27, 16, 82, 92, 75, 72, 69, 9, 9, 6, 91, 28, 27, 17, 16, 13, 58, 19, 93, 82, 29, 26, 3, 16, 7, 79, 85, 29, 26, 3, 16, 7, 82, 92, 75, 72, 69, 92, 7, 16, 1, 0, 7, 27, 85, 14, 24, 20, 1, 22, 29, 16, 6, 79, 1, 7, 0, 16, 89, 24, 16, 17, 28, 20, 79, 4, 89, 26, 27, 22, 29, 20, 27, 18, 16, 79, 27, 0, 25, 25, 89, 20, 17, 17, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 7, 16, 24, 26, 3, 16, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 20, 17, 17, 48, 3, 16, 27, 1, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 7, 16, 24, 26, 3, 16, 48, 3, 16, 27, 1, 57, 28, 6, 1, 16, 27, 16, 7, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 8, 89, 17, 28, 6, 5, 20, 1, 22, 29, 48, 3, 16, 27, 1, 79, 19, 0, 27, 22, 1, 28, 26, 27, 93, 92, 14, 7, 16, 1, 0, 7, 27, 85, 19, 20, 25, 6, 16, 78, 8, 8, 78, 7, 16, 1, 0, 7, 27, 85, 26, 7, 28, 18, 93, 4, 92, 78, 8, 78, 8, 22, 20, 1, 22, 29, 93, 16, 92, 14, 8 }, 117) + _0xb11edeec._0x1de8009f(new byte[5] { 42, 126, 127, 126, 108 }, 87);
    }

    private async Task _0x3b034626()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xe8597674 = _0xb11edeec._0x1de8009f(new byte[5] { 92, 91, 86, 73, 95 }, 58);
        _0xb25a332c = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x01bdaaea = DateTime.UtcNow.Ticks.ToString();
        _0xf533ddb8 = "";
        JObject _0x82a7f8b3 = _0x5eedacb3(_0x9044ffe2, _0xfa01d017, _0x9ae07dd1, _0xfbd31b8e, _0xb7d0c370, _0xe5511bfd, _0x5cadc9ae, _0x2f1caddc, _0x8d63a735, _0xf3eed12c, _0xe8597674, _0xf533ddb8, _0x7819158e, _0x43fc6de6, _0xe8e364c1.ToString(), _0x0856737c, _0x01bdaaea, _0xb25a332c, _0xa53eb895, _0x6f6f5584, _0xc70bb372, _0x9a322251, _0x1dfb1ade());
        var _0xc58da42e = _0xf7a61fa5(_0x82a7f8b3.ToString(), _0xa53eb895);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x82a7f8b3}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xb11edeec._0x1de8009f(new byte[7] { 225, 240, 232, 253, 254, 240, 245 }, 145) + _0xa53eb895, _0xc58da42e } });
            await Task.Delay(500);
            string _0xbd71f730 = "";
            for (int _0x1580e798 = 0; _0x1580e798 < 20; _0x1580e798++)
            {
                if (await _0x6db12b35(1, 1))
                {
                    await _0xd689168a(_0xb11edeec._0x1de8009f(new byte[7] { 187, 181, 182, 186, 178, 188, 189 }, 217));
                    _0x735c3a7b();
                    return;
                }

                _0xbd71f730 = await _0xb03c39c5(1, 500);
                if (!string.IsNullOrEmpty(_0xbd71f730))
                    break;
            }

            _0x6a9e526f(_0xbd71f730);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[22] { 76, 67, 82, 68, 67, 74, 55, 80, 114, 121, 114, 101, 118, 123, 55, 114, 101, 101, 120, 101, 45, 55 }, 23) + e.Message);
#endif
            }

            _0x735c3a7b();
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xe8cd3f2b)
    {
        if (string.IsNullOrEmpty(_0xe8cd3f2b))
            return false;
        if (_0xe8cd3f2b.StartsWith(_0xb11edeec._0x1de8009f(new byte[9] { 17, 22, 12, 29, 22, 12, 66, 87, 87 }, 120), StringComparison.OrdinalIgnoreCase))
            return _0x9021c467(_0xe8cd3f2b);
        if (_0x3f8300c9(_0xe8cd3f2b))
            return _0xf06fffc9(_0xe8cd3f2b, null);
        if (!_0xe8cd3f2b.StartsWith(_0xb11edeec._0x1de8009f(new byte[7] { 146, 142, 142, 138, 192, 213, 213 }, 250), StringComparison.OrdinalIgnoreCase) && !_0xe8cd3f2b.StartsWith(_0xb11edeec._0x1de8009f(new byte[8] { 215, 203, 203, 207, 204, 133, 144, 144 }, 191), StringComparison.OrdinalIgnoreCase) && !_0xe8cd3f2b.StartsWith(_0xb11edeec._0x1de8009f(new byte[11] { 221, 222, 211, 201, 200, 134, 222, 208, 221, 210, 215 }, 188), StringComparison.OrdinalIgnoreCase))
        {
            return _0xf1039cdc(_0xe8cd3f2b);
        }

        return false;
    }

    private IEnumerator _0x4272c0c5()
    {
        yield return _0x4f0dc90c(Permission.Camera);
    }

    private string _0x07deb841;
    private string _0xb7d0c370 = "";
    private void _0x87fca9f8()
    {
        if (_0xc7fdd2fd != null)
            return;
        var _0xeab98f9d = _0x2cb3b45c();
        _0xc7fdd2fd = new GameObject(_0xb11edeec._0x1de8009f(new byte[14] { 160, 146, 149, 161, 158, 146, 128, 164, 135, 158, 153, 153, 146, 133 }, 247), typeof(RectTransform), typeof(Text));
        _0x9b8e5f18 = _0xc7fdd2fd.GetComponent<RectTransform>();
        _0x9b8e5f18.SetParent(_0xeab98f9d.transform, false);
        _0x9b8e5f18.anchorMin = new Vector2(0.5f, 0.5f);
        _0x9b8e5f18.anchorMax = new Vector2(0.5f, 0.5f);
        _0x9b8e5f18.pivot = new Vector2(0.5f, 0.5f);
        _0x9b8e5f18.sizeDelta = new Vector2(600f, 600f);
        _0x9b8e5f18.anchoredPosition = Vector2.zero;
        _0x14c94d78 = _0xc7fdd2fd.GetComponent<Text>();
        _0x14c94d78.text = _0xb11edeec._0x1de8009f(new byte[1] { 48 }, 31);
        _0x14c94d78.font = Resources.GetBuiltinResource<Font>(_0xb11edeec._0x1de8009f(new byte[17] { 28, 53, 55, 49, 51, 41, 2, 37, 62, 36, 57, 61, 53, 126, 36, 36, 54 }, 80));
        _0x14c94d78.fontSize = 200;
        _0x14c94d78.alignment = TextAnchor.MiddleCenter;
        _0x14c94d78.color = Color.white;
        _0x14c94d78.raycastTarget = false;
        _0xc7fdd2fd.SetActive(false);
    }

    private string _0x9a322251 = "";
    private string _0xe8597674 = "";
    private string _0x0856737c = "";
    private async Task<bool> _0x6db12b35(int _0xabccde22 = 5, int _0x038081f3 = 500)
    {
        List<EntityData> _0xc3f3c31a = new List<EntityData>();
        int _0x6526945f = 0;
        do
        {
            try
            {
                _0xc3f3c31a = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xb11edeec._0x1de8009f(new byte[8] { 10, 22, 27, 3, 31, 8, 51, 30 }, 122), _0xa53eb895, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xb11edeec._0x1de8009f(new byte[9] { 116, 110, 77, 111, 116, 107, 124, 126, 100 }, 29) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xb11edeec._0x1de8009f(new byte[32] { 64, 79, 126, 104, 111, 70, 59, 106, 110, 126, 105, 98, 90, 104, 98, 117, 120, 73, 126, 104, 110, 119, 111, 104, 59, 126, 105, 105, 116, 105, 33, 59 }, 27) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x038081f3);
        }
        while (_0xc3f3c31a.Count == 0 && _0x6526945f++ < _0xabccde22);
        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[32] { 61, 50, 3, 21, 18, 59, 70, 47, 21, 54, 20, 15, 16, 7, 5, 31, 70, 55, 19, 3, 20, 31, 70, 20, 3, 21, 19, 10, 18, 21, 92, 70 }, 102) + JsonConvert.SerializeObject(_0xc3f3c31a, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[38] { 221, 210, 227, 245, 242, 219, 166, 207, 245, 214, 244, 239, 240, 231, 229, 255, 166, 215, 243, 227, 244, 255, 166, 244, 227, 245, 243, 234, 242, 245, 166, 229, 233, 243, 232, 242, 188, 166 }, 134) + _0xc3f3c31a.Count);
            }
#endif
        }

        bool _0xfbc11313 = true;
        if (_0xc3f3c31a.Count == 0)
        {
            _0xfbc11313 = false;
        }
        else
        {
            _0xfbc11313 = _0xc3f3c31a.Any(_0x9a642949 => _0x9a642949.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[25] { 141, 130, 179, 165, 162, 139, 246, 159, 165, 134, 164, 191, 160, 183, 181, 175, 246, 164, 179, 165, 163, 186, 162, 236, 246 }, 214) + _0xfbc11313);
            }
#endif
        }

        return _0xfbc11313;
    }

    private IEnumerator _0xb4f961e2(IEnumerator _0xff7a1e5d, TaskCompletionSource<bool> _0xc0cdf8e0)
    {
        yield return _0xff7a1e5d;
        _0xc0cdf8e0.SetResult(true);
    }

    // WEB VIEW LOGIC END
    internal void _0x8ae72c02()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x6fdbf34c = new AndroidNotificationChannel
        {
            Id = _0xb11edeec._0x1de8009f(new byte[15] { 115, 114, 113, 118, 98, 123, 99, 72, 116, 127, 118, 121, 121, 114, 123 }, 23),
            Name = _0xb11edeec._0x1de8009f(new byte[15] { 103, 70, 69, 66, 86, 79, 87, 3, 96, 75, 66, 77, 77, 70, 79 }, 35),
            Importance = Importance.High,
            Description = _0xb11edeec._0x1de8009f(new byte[21] { 137, 171, 160, 171, 188, 175, 162, 238, 160, 161, 186, 167, 168, 167, 173, 175, 186, 167, 161, 160, 189 }, 206)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x6fdbf34c);
        // Build notification
        var _0x83b93db0 = new AndroidNotification
        {
            Title = _0xbfcc39ac[UnityEngine.Random.Range(0, _0xbfcc39ac.Length)],
            Text = _0xb11edeec._0x1de8009f(new byte[21] { 158, 173, 186, 255, 166, 176, 170, 255, 172, 170, 173, 186, 255, 171, 176, 255, 186, 167, 182, 171, 224 }, 223),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x83b93db0, _0xb11edeec._0x1de8009f(new byte[15] { 75, 74, 73, 78, 90, 67, 91, 112, 76, 71, 78, 65, 65, 74, 67 }, 47));
    }

    internal bool IsGoogleAuthFlowUrl(string _0x03d457a9)
    {
        if (string.IsNullOrEmpty(_0x03d457a9))
            return false;
        return _0x03d457a9.IndexOf(_0xb11edeec._0x1de8009f(new byte[19] { 194, 192, 192, 204, 214, 205, 215, 208, 141, 196, 204, 204, 196, 207, 198, 141, 192, 204, 206 }, 163), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03d457a9.IndexOf(_0xb11edeec._0x1de8009f(new byte[16] { 119, 117, 117, 121, 99, 120, 98, 101, 56, 113, 121, 121, 113, 122, 115, 56 }, 22), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03d457a9.IndexOf(_0xb11edeec._0x1de8009f(new byte[21] { 116, 124, 124, 116, 127, 118, 102, 96, 118, 97, 112, 124, 125, 103, 118, 125, 103, 61, 112, 124, 126 }, 19), StringComparison.OrdinalIgnoreCase) >= 0 || _0x03d457a9.IndexOf(_0xb11edeec._0x1de8009f(new byte[11] { 37, 49, 54, 35, 54, 43, 33, 108, 33, 45, 47 }, 66), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0x83c6d2ee(UniWebView _0x95a1ede8)
    {
        _0x95a1ede8.BackgroundColor = Color.clear;
        _0x95a1ede8.SetSupportMultipleWindows(true, true);
        _0x95a1ede8.SetBackButtonEnabled(false);
        _0x6a329bfa.SetUserAgent(_0xf8be7f86());
    }

    private bool _0x52c55135 = false;
    private string _0xb0d28e8f()
    {
        try
        {
            using (var _0xdf0020dd = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 176, 188, 190, 253, 166, 189, 186, 167, 170, 224, 183, 253, 163, 191, 178, 170, 182, 161, 253, 134, 189, 186, 167, 170, 131, 191, 178, 170, 182, 161 }, 211)))
            {
                var _0xbc7c9805 = _0xdf0020dd.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 124, 106, 109, 109, 122, 113, 107, 94, 124, 107, 118, 105, 118, 107, 102 }, 31));
                var _0x2cc95849 = _0xbc7c9805.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[21] { 250, 248, 233, 220, 237, 237, 241, 244, 254, 252, 233, 244, 242, 243, 222, 242, 243, 233, 248, 229, 233 }, 157));
                using (var _0xc036e3b8 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[26] { 87, 88, 82, 68, 89, 95, 82, 24, 65, 83, 84, 93, 95, 66, 24, 97, 83, 84, 101, 83, 66, 66, 95, 88, 81, 69 }, 54)))
                {
                    return _0xc036e3b8.CallStatic<string>(_0xb11edeec._0x1de8009f(new byte[19] { 33, 35, 50, 2, 35, 32, 39, 51, 42, 50, 19, 53, 35, 52, 7, 33, 35, 40, 50 }, 70), _0x2cc95849);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x99049bd2()
    {
        var _0x0d78e46b = _0xb11edeec._0x1de8009f(new byte[40] { 123, 103, 103, 99, 96, 41, 60, 60, 100, 100, 100, 61, 112, 127, 124, 102, 119, 117, 127, 114, 97, 118, 61, 112, 124, 126, 60, 112, 119, 125, 62, 112, 116, 122, 60, 103, 97, 114, 112, 118 }, 19);
        using (UnityWebRequest _0xb4f0513a = UnityWebRequest.Get(_0x0d78e46b))
        {
            await _0xb4f0513a.SendWebRequest();
            string[] _0xdd33afc4 = _0xb4f0513a.downloadHandler.text.Split('\n');
            foreach (string _0x96835535 in _0xdd33afc4)
            {
                if (_0x96835535.StartsWith(_0xb11edeec._0x1de8009f(new byte[3] { 104, 113, 60 }, 1)))
                {
                    string _0xa65b659d = _0x96835535.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xa65b659d} from {_0x0d78e46b}");
                        }
#endif
                    }

                    return _0xa65b659d;
                }
            }
        }

        return "";
    }

    private bool _0xe8506f72()
    {
        if (_0x8fbac276())
            return true;
        if (_0x6a329bfa != null && _0x6a329bfa.CanGoBack)
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[36] { 78, 103, 116, 98, 113, 103, 116, 99, 38, 100, 103, 101, 109, 38, 43, 56, 38, 107, 103, 111, 104, 38, 81, 99, 100, 80, 111, 99, 113, 38, 65, 105, 68, 103, 101, 109 }, 6));
            _0x6a329bfa.GoBack();
            return true;
        }

        return false;
    }

    internal bool isApplicationFocus = false;
    private int _0x5cba5a5f = 5, _0x8236b488 = 5, _0xee2b8627 = 5, _0x901af057 = 5;
    private void _0xbf5d4f7f()
    {
        if (_0x4260046e)
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[18] { 156, 161, 176, 173, 249, 184, 181, 171, 188, 184, 189, 160, 249, 170, 177, 182, 174, 183 }, 217));
            return;
        }

        _0x6ff6762e(false);
        WLog(_0xb11edeec._0x1de8009f(new byte[46] { 210, 254, 246, 241, 191, 200, 250, 253, 201, 246, 250, 232, 191, 207, 234, 236, 247, 191, 209, 240, 235, 246, 249, 246, 252, 254, 235, 246, 240, 241, 191, 183, 247, 254, 237, 251, 232, 254, 237, 250, 191, 253, 254, 252, 244, 182 }, 159));
        ++_0xb4f63dc9;
        _0x8ae72c02();
        if (_0xb4f63dc9 <= 1)
            return;
        if (_0xdc7b42e2())
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[37] { 212, 233, 248, 229, 177, 226, 250, 248, 225, 225, 244, 245, 177, 188, 175, 177, 225, 254, 225, 228, 225, 226, 177, 226, 229, 248, 253, 253, 177, 254, 225, 244, 255, 244, 245, 171, 177 }, 145) + _0xc10edd98.Count);
            return;
        }

        Application.Quit();
    }

    private bool _0x3ead24a2 = false;
    private static string ReadPushField(Dictionary<string, object> _0x51e55772, string _0xfe5c5289)
    {
        if (_0x51e55772 == null || string.IsNullOrEmpty(_0xfe5c5289))
            return string.Empty;
        if (_0x51e55772.TryGetValue(_0xb11edeec._0x1de8009f(new byte[16] { 111, 110, 117, 104, 103, 104, 98, 96, 117, 104, 110, 111, 69, 96, 117, 96 }, 1), out var raw))
        {
            try
            {
                var _0x2456ee22 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x2456ee22 != null && _0x2456ee22.TryGetValue(_0xfe5c5289, out var nestedVal))
                {
                    var _0x5fccafcc = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x5fccafcc))
                        return _0x5fccafcc;
                }
            }
            catch
            {
            }
        }

        if (_0x51e55772.TryGetValue(_0xfe5c5289, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private bool _0xe64b4e5c = false;
    private void _0x7afbad31(string _0xbc36a841)
    {
        _0xb3bdb8c4();
        StartCoroutine(_0x19a8ceb2(_0xbc36a841));
    }

    private string _0xfbdd9f50()
    {
        string _0xed9c4d83 = _0xf8be7f86();
        if (string.IsNullOrEmpty(_0xed9c4d83))
            return _0xb11edeec._0x1de8009f(new byte[7] { 13, 20, 18, 31, 91, 75, 64 }, 123);
        string _0x228772b1 = _0xed9c4d83.Replace(_0xb11edeec._0x1de8009f(new byte[1] { 43 }, 119), _0xb11edeec._0x1de8009f(new byte[2] { 112, 112 }, 44)).Replace(_0xb11edeec._0x1de8009f(new byte[1] { 174 }, 137), _0xb11edeec._0x1de8009f(new byte[2] { 22, 109 }, 74));
        var _0x2e91a3e2 = Regex.Match(_0xed9c4d83, _0xb11edeec._0x1de8009f(new byte[12] { 59, 16, 10, 23, 21, 29, 87, 80, 36, 28, 83, 81 }, 120));
        string _0xf9b5a326 = _0x2e91a3e2.Success ? _0x2e91a3e2.Groups[1].Value : _0xb11edeec._0x1de8009f(new byte[3] { 220, 223, 221 }, 237);
        return _0xb11edeec._0x1de8009f(new byte[12] { 216, 150, 133, 158, 147, 132, 153, 159, 158, 216, 217, 139 }, 240) + _0xb11edeec._0x1de8009f(new byte[8] { 180, 163, 176, 226, 183, 163, 255, 229 }, 194) + _0x228772b1 + _0xb11edeec._0x1de8009f(new byte[2] { 97, 125 }, 70) + _0xb11edeec._0x1de8009f(new byte[30] { 122, 109, 126, 44, 124, 126, 99, 120, 99, 49, 66, 109, 122, 101, 107, 109, 120, 99, 126, 34, 124, 126, 99, 120, 99, 120, 117, 124, 105, 55 }, 12) + _0xb11edeec._0x1de8009f(new byte[121] { 5, 22, 13, 0, 23, 10, 12, 13, 67, 7, 6, 5, 75, 12, 1, 9, 79, 8, 6, 26, 79, 21, 2, 15, 74, 24, 23, 17, 26, 24, 44, 1, 9, 6, 0, 23, 77, 7, 6, 5, 10, 13, 6, 51, 17, 12, 19, 6, 17, 23, 26, 75, 12, 1, 9, 79, 8, 6, 26, 79, 24, 4, 6, 23, 89, 5, 22, 13, 0, 23, 10, 12, 13, 75, 74, 24, 17, 6, 23, 22, 17, 13, 67, 21, 2, 15, 88, 30, 79, 0, 12, 13, 5, 10, 4, 22, 17, 2, 1, 15, 6, 89, 23, 17, 22, 6, 30, 74, 88, 30, 0, 2, 23, 0, 11, 75, 6, 74, 24, 30, 30 }, 99) + _0xb11edeec._0x1de8009f(new byte[26] { 186, 187, 184, 246, 174, 172, 177, 170, 177, 242, 249, 171, 173, 187, 172, 159, 185, 187, 176, 170, 249, 242, 171, 191, 247, 229 }, 222) + _0xb11edeec._0x1de8009f(new byte[52] { 205, 204, 207, 129, 217, 219, 198, 221, 198, 133, 142, 200, 217, 217, 255, 204, 219, 218, 192, 198, 199, 142, 133, 220, 200, 135, 219, 204, 217, 197, 200, 202, 204, 129, 134, 247, 228, 198, 211, 192, 197, 197, 200, 245, 134, 134, 133, 142, 142, 128, 128, 146 }, 169) + _0xb11edeec._0x1de8009f(new byte[37] { 137, 136, 139, 197, 157, 159, 130, 153, 130, 193, 202, 157, 129, 140, 153, 139, 130, 159, 128, 202, 193, 202, 161, 132, 131, 152, 149, 205, 140, 159, 128, 155, 213, 129, 202, 196, 214 }, 237) + _0xb11edeec._0x1de8009f(new byte[34] { 193, 192, 195, 141, 213, 215, 202, 209, 202, 137, 130, 211, 192, 203, 193, 202, 215, 130, 137, 130, 226, 202, 202, 194, 201, 192, 133, 236, 203, 198, 139, 130, 140, 158 }, 165) + _0xb11edeec._0x1de8009f(new byte[30] { 19, 18, 17, 95, 7, 5, 24, 3, 24, 91, 80, 26, 22, 15, 35, 24, 2, 20, 31, 39, 24, 30, 25, 3, 4, 80, 91, 66, 94, 76 }, 119) + _0xb11edeec._0x1de8009f(new byte[48] { 127, 121, 114, 112, 125, 106, 121, 43, 126, 106, 111, 54, 112, 105, 121, 106, 101, 111, 120, 49, 80, 112, 105, 121, 106, 101, 111, 49, 44, 72, 99, 121, 100, 102, 98, 126, 102, 44, 39, 125, 110, 121, 120, 98, 100, 101, 49, 44 }, 11) + _0xf9b5a326 + _0xb11edeec._0x1de8009f(new byte[35] { 203, 145, 192, 151, 142, 158, 141, 130, 136, 214, 203, 171, 131, 131, 139, 128, 137, 204, 175, 132, 158, 131, 129, 137, 203, 192, 154, 137, 158, 159, 133, 131, 130, 214, 203 }, 236) + _0xf9b5a326 + _0xb11edeec._0x1de8009f(new byte[238] { 227, 185, 232, 191, 166, 182, 165, 170, 160, 254, 227, 138, 171, 176, 249, 133, 251, 134, 182, 165, 170, 160, 227, 232, 178, 161, 182, 183, 173, 171, 170, 254, 227, 246, 240, 227, 185, 153, 232, 169, 171, 166, 173, 168, 161, 254, 176, 182, 177, 161, 232, 180, 168, 165, 176, 162, 171, 182, 169, 254, 227, 133, 170, 160, 182, 171, 173, 160, 227, 232, 163, 161, 176, 140, 173, 163, 172, 129, 170, 176, 182, 171, 180, 189, 146, 165, 168, 177, 161, 183, 254, 162, 177, 170, 167, 176, 173, 171, 170, 236, 237, 191, 182, 161, 176, 177, 182, 170, 228, 148, 182, 171, 169, 173, 183, 161, 234, 182, 161, 183, 171, 168, 178, 161, 236, 191, 165, 182, 167, 172, 173, 176, 161, 167, 176, 177, 182, 161, 254, 227, 165, 182, 169, 227, 232, 166, 173, 176, 170, 161, 183, 183, 254, 227, 242, 240, 227, 232, 169, 171, 166, 173, 168, 161, 254, 176, 182, 177, 161, 232, 169, 171, 160, 161, 168, 254, 227, 227, 232, 180, 168, 165, 176, 162, 171, 182, 169, 254, 227, 133, 170, 160, 182, 171, 173, 160, 227, 232, 180, 168, 165, 176, 162, 171, 182, 169, 146, 161, 182, 183, 173, 171, 170, 254, 227, 245, 240, 234, 244, 234, 244, 227, 232, 177, 165, 130, 177, 168, 168, 146, 161, 182, 183, 173, 171, 170, 254, 227 }, 196) + _0xf9b5a326 + _0xb11edeec._0x1de8009f(new byte[117] { 42, 52, 42, 52, 42, 52, 35, 121, 45, 63, 121, 121, 63, 75, 102, 110, 97, 103, 112, 42, 96, 97, 98, 109, 106, 97, 84, 118, 107, 116, 97, 118, 112, 125, 44, 116, 118, 107, 112, 107, 40, 35, 113, 119, 97, 118, 69, 99, 97, 106, 112, 64, 101, 112, 101, 35, 40, 127, 99, 97, 112, 62, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127, 118, 97, 112, 113, 118, 106, 36, 113, 101, 96, 63, 121, 40, 103, 107, 106, 98, 109, 99, 113, 118, 101, 102, 104, 97, 62, 112, 118, 113, 97, 121, 45, 63, 121, 103, 101, 112, 103, 108, 44, 97, 45, 127, 121 }, 4) + _0xb11edeec._0x1de8009f(new byte[5] { 74, 30, 31, 30, 12 }, 55);
    }

    private bool _0xad1e39c7 = false;
    private bool _0x8fbac276()
    {
        var _0x6f2860e9 = _0x69493401();
        if (_0x6f2860e9 == null)
            return false;
        WLog(_0xb11edeec._0x1de8009f(new byte[31] { 111, 70, 85, 67, 80, 70, 85, 66, 7, 69, 70, 68, 76, 7, 10, 25, 7, 87, 72, 87, 82, 87, 7, 96, 72, 101, 70, 68, 76, 29, 7 }, 39) + _0x6f2860e9.Id);
        _0x6f2860e9.GoBack();
        return true;
    }

    private bool _0x0f6cfb92()
    {
        var _0x40dd274e = Keyboard.current;
        return _0x40dd274e != null && _0x40dd274e.escapeKey.wasPressedThisFrame;
    }

    private string _0x2eac393c(string _0x6b4e9ae0, string _0x556b9c09)
    {
        if (string.IsNullOrEmpty(_0x556b9c09))
            return _0x6b4e9ae0;
        if (_0x6b4e9ae0.Contains(_0xb11edeec._0x1de8009f(new byte[1] { 159 }, 160)))
            return _0x6b4e9ae0 + _0xb11edeec._0x1de8009f(new byte[8] { 57, 108, 122, 113, 123, 118, 123, 34 }, 31) + UnityWebRequest.EscapeURL(_0x556b9c09);
        else
            return _0x6b4e9ae0 + _0xb11edeec._0x1de8009f(new byte[8] { 254, 178, 164, 175, 165, 168, 165, 252 }, 193) + UnityWebRequest.EscapeURL(_0x556b9c09);
    }

    private void OnApplicationFocus(bool _0x58dbcdc7)
    {
        isApplicationFocus = _0x58dbcdc7;
        if (_0x58dbcdc7 && _0x166e15e0)
        {
            _0xb3bdb8c4();
        }
    }

    private void _0x8df35525()
    {
        WLog(_0xb11edeec._0x1de8009f(new byte[21] { 159, 182, 165, 179, 160, 182, 165, 178, 247, 181, 182, 180, 188, 247, 167, 165, 178, 164, 164, 178, 179 }, 215));
        if (Time.frameCount == _0x1da33fd9)
            return;
        _0x1da33fd9 = Time.frameCount;
        if (_0xe8506f72())
            return;
        _0xbf5d4f7f();
    }

    private static bool IsPrivacyItemTrue(Item _0x4736223d)
    {
        if (_0x4736223d.Key != _0xb11edeec._0x1de8009f(new byte[9] { 87, 77, 110, 76, 87, 72, 95, 93, 71 }, 62))
            return false;
        try
        {
            var _0x82d85930 = _0x4736223d.Value.GetAs<object>();
            return _0x82d85930 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0xb3bdb8c4()
    {
        using (var _0x7ff7ab61 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 25, 21, 23, 84, 15, 20, 19, 14, 3, 73, 30, 84, 10, 22, 27, 3, 31, 8, 84, 47, 20, 19, 14, 3, 42, 22, 27, 3, 31, 8 }, 122)))
        using (var _0x28816734 = _0x7ff7ab61.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 116, 98, 101, 101, 114, 121, 99, 86, 116, 99, 126, 97, 126, 99, 110 }, 23)))
        using (var _0xcfa19661 = _0x28816734.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[9] { 39, 37, 52, 9, 46, 52, 37, 46, 52 }, 64)))
        {
            if (_0xcfa19661 == null)
                return;
            using (var _0xf0d4844e = _0xcfa19661.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[9] { 162, 160, 177, 128, 189, 177, 183, 164, 182 }, 197)))
            {
                if (_0xf0d4844e == null)
                    return;
                using (var _0xd25dab53 = new AndroidJavaObject(_0xb11edeec._0x1de8009f(new byte[19] { 155, 134, 147, 218, 158, 135, 155, 154, 218, 190, 167, 187, 186, 187, 150, 158, 145, 151, 128 }, 244)))
                using (var _0xc4d785dd = _0xf0d4844e.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[6] { 190, 176, 172, 134, 176, 161 }, 213)))
                using (var _0xa1c6854b = _0xc4d785dd.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[8] { 242, 239, 254, 233, 250, 239, 244, 233 }, 155)))
                {
                    while (_0xa1c6854b.Call<bool>(_0xb11edeec._0x1de8009f(new byte[7] { 195, 202, 216, 229, 206, 211, 223 }, 171)))
                    {
                        string _0x38246b28 = _0xa1c6854b.Call<string>(_0xb11edeec._0x1de8009f(new byte[4] { 205, 198, 219, 215 }, 163));
                        using (var _0xe5cdcd3a = _0xf0d4844e.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[3] { 48, 50, 35 }, 87), _0x38246b28))
                        {
                            _0xd25dab53.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[3] { 148, 145, 144 }, 228), _0x38246b28, _0xe5cdcd3a);
                        }
                    }

                    string _0x40dd1923 = _0xd25dab53.Call<string>(_0xb11edeec._0x1de8009f(new byte[8] { 88, 67, 127, 88, 94, 69, 66, 75 }, 44));
                    if (!string.IsNullOrEmpty(_0x40dd1923))
                    {
                        _0xf5650e73(_0x40dd1923);
                        _0xc00a46d6(_0x40dd1923);
                    }
                }
            }
        }
    }

    private readonly List<UniWebViewPopup> _0xc10edd98 = new List<UniWebViewPopup>();
    private bool _0xf1039cdc(string _0x0bcd786a)
    {
        try
        {
            using (var _0xf671e23f = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 68, 72, 74, 9, 82, 73, 78, 83, 94, 20, 67, 9, 87, 75, 70, 94, 66, 85, 9, 114, 73, 78, 83, 94, 119, 75, 70, 94, 66, 85 }, 39)))
            using (var _0xd7ba29aa = _0xf671e23f.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 66, 84, 83, 83, 68, 79, 85, 96, 66, 85, 72, 87, 72, 85, 88 }, 33)))
            using (var _0x4b77f7f7 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[15] { 31, 16, 26, 12, 17, 23, 26, 80, 16, 27, 10, 80, 43, 12, 23 }, 126)))
            using (var _0x0ff0d5bc = _0x4b77f7f7.CallStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[5] { 254, 239, 252, 253, 235 }, 142), _0x0bcd786a))
            using (var _0x6867bb06 = new AndroidJavaObject(_0xb11edeec._0x1de8009f(new byte[22] { 114, 125, 119, 97, 124, 122, 119, 61, 112, 124, 125, 103, 118, 125, 103, 61, 90, 125, 103, 118, 125, 103 }, 19), _0xb11edeec._0x1de8009f(new byte[26] { 90, 85, 95, 73, 84, 82, 95, 21, 82, 85, 79, 94, 85, 79, 21, 90, 88, 79, 82, 84, 85, 21, 109, 114, 126, 108 }, 59), _0x0ff0d5bc))
            {
                WLog(_0xb11edeec._0x1de8009f(new byte[26] { 21, 62, 36, 57, 59, 51, 26, 63, 61, 51, 118, 57, 38, 51, 56, 118, 51, 46, 34, 51, 36, 56, 55, 58, 108, 118 }, 86) + _0x0bcd786a);
                _0x6867bb06.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[11] { 253, 248, 248, 223, 253, 232, 249, 251, 243, 238, 229 }, 156), _0xb11edeec._0x1de8009f(new byte[33] { 69, 74, 64, 86, 75, 77, 64, 10, 77, 74, 80, 65, 74, 80, 10, 71, 69, 80, 65, 67, 75, 86, 93, 10, 102, 118, 107, 115, 119, 101, 102, 104, 97 }, 36));
                _0x6867bb06.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[8] { 59, 62, 62, 28, 54, 59, 61, 41 }, 90), 0x10000000);
                _0xd7ba29aa.Call(_0xb11edeec._0x1de8009f(new byte[13] { 253, 250, 239, 252, 250, 207, 237, 250, 231, 248, 231, 250, 247 }, 142), _0x6867bb06);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xb11edeec._0x1de8009f(new byte[28] { 141, 166, 188, 161, 163, 171, 130, 167, 165, 171, 238, 171, 182, 186, 171, 188, 160, 175, 162, 238, 168, 175, 167, 162, 171, 170, 244, 238 }, 206) + e.Message);
            Application.OpenURL(_0x0bcd786a);
            return true;
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x735c3a7b();
    }

    private IEnumerator _0x84a05429(Dictionary<string, object> _0xb29dc7d6)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[30] { 233, 230, 215, 193, 198, 239, 146, 244, 215, 198, 209, 218, 146, 247, 202, 198, 192, 211, 146, 226, 199, 193, 218, 146, 246, 211, 198, 211, 136, 146 }, 178) + string.Join(_0xb11edeec._0x1de8009f(new byte[1] { 194 }, 203), _0xb29dc7d6));
#endif
            }
        }

        string _0x08c93b18 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xb29dc7d6 != null && _0xb29dc7d6.TryGetValue(_0xb11edeec._0x1de8009f(new byte[16] { 149, 148, 143, 146, 157, 146, 152, 154, 143, 146, 148, 149, 191, 154, 143, 154 }, 251), out var raw))
        {
            try
            {
                var _0x4b760f6e = raw?.ToString();
                var _0x77ca68b9 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x4b760f6e);
                if (_0x77ca68b9 != null && _0x77ca68b9.TryGetValue(_0xb11edeec._0x1de8009f(new byte[6] { 54, 32, 43, 33, 44, 33 }, 69), out var val))
                {
                    _0x08c93b18 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xb11edeec._0x1de8009f(new byte[30] { 11, 4, 53, 35, 36, 112, 0, 37, 35, 56, 13, 112, 26, 3, 31, 30, 112, 32, 49, 34, 35, 53, 112, 53, 34, 34, 63, 34, 106, 112 }, 80) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x08c93b18) && _0xb29dc7d6 != null && _0xb29dc7d6.TryGetValue(_0xb11edeec._0x1de8009f(new byte[6] { 249, 239, 228, 238, 227, 238 }, 138), out var lab))
        {
            _0x08c93b18 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[38] { 49, 62, 15, 25, 30, 74, 58, 31, 25, 2, 55, 74, 44, 15, 30, 9, 2, 15, 14, 74, 25, 15, 4, 14, 3, 14, 74, 12, 24, 5, 7, 74, 0, 25, 5, 4, 80, 74 }, 106) + _0x08c93b18);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x08c93b18))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[38] { 220, 211, 226, 244, 243, 167, 215, 242, 244, 239, 218, 167, 208, 230, 238, 243, 167, 243, 232, 167, 232, 247, 226, 233, 167, 240, 238, 243, 239, 167, 244, 226, 233, 227, 238, 227, 189, 167 }, 135) + _0x08c93b18);
            }
#endif
        }

        _0x07deb841 = _0x08c93b18;
        yield return new WaitUntil(() => _0x166e15e0);
        var _0x64f37f72 = _0xb03c39c5(2, 100);
        yield return new WaitUntil(() => _0x64f37f72.IsCompleted);
        string _0x9c016487 = _0x64f37f72.Result;
        if (!string.IsNullOrEmpty(_0x9c016487))
        {
            string _0xeb537526 = _0x2eac393c(_0x9c016487, _0x08c93b18);
            {
#if B_LOGS
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[33] { 251, 244, 197, 211, 212, 128, 240, 213, 211, 200, 253, 128, 242, 197, 204, 207, 193, 196, 128, 247, 197, 194, 246, 201, 197, 215, 128, 215, 201, 212, 200, 154, 128 }, 160) + _0xeb537526);
#endif
            }

            _0x6a329bfa.Load(_0xeb537526);
        }
    }

    private bool _0x4260046e = false;
    private Canvas _0xf4f781d4;
    private async Task _0x59c757ca()
    {
        if (await _0x2e52b269())
            return;
        if (await _0x6c799a40())
            return;
        if (await _0x527ce3da())
            return;
        _0xb94017f3();
        await _0x6a788541(_0xe80c7238());
        _0x8d63a735 = await _0x99049bd2();
        await _0x3b034626();
    }

    private IEnumerator _0xe80c7238()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xb11edeec._0x1de8009f(new byte[26] { 235, 228, 213, 195, 196, 237, 144, 249, 222, 217, 196, 217, 209, 220, 217, 202, 213, 226, 213, 214, 214, 213, 194, 213, 194, 144 }, 176));
            }
#endif
        }

        bool _0x14edabbe = false;
        InstallReferrer.GetReferrer((_0x096c2356) =>
        {
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[24] { 44, 35, 18, 4, 3, 87, 37, 18, 17, 18, 5, 5, 18, 5, 42, 87, 16, 18, 3, 87, 149, 241, 229, 87 }, 119) + _0xb7d0c370);
            if (_0x096c2356.IsSuccess)
            {
                _0xb7d0c370 = _0x096c2356.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[28] { 247, 248, 201, 223, 216, 140, 254, 201, 202, 201, 222, 222, 201, 222, 241, 140, 255, 217, 207, 207, 201, 223, 223, 140, 78, 42, 62, 140 }, 172) + _0xb7d0c370);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xb11edeec._0x1de8009f(new byte[27] { 93, 82, 99, 117, 114, 38, 84, 99, 96, 99, 116, 116, 99, 116, 91, 38, 64, 103, 111, 106, 99, 98, 38, 228, 128, 148, 38 }, 6) + _0x096c2356);
#endif
                }

                _0xb7d0c370 = "";
            }

            _0x70454d0b = true;
        });
        StartCoroutine(_0xe3936223(2f));
        yield return new WaitUntil(() => _0x70454d0b);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xb7d0c370}");
#endif
        }

        bool _0x7e090082 = _0xb7d0c370.Contains(_0xb11edeec._0x1de8009f(new byte[6] { 34, 38, 41, 44, 33, 120 }, 69));
        _0x14edabbe = _0x7e090082 || _0xb7d0c370.Contains(_0xb11edeec._0x1de8009f(new byte[18] { 15, 30, 30, 29, 64, 7, 0, 29, 26, 15, 9, 28, 15, 3, 64, 13, 1, 3 }, 110)) || _0xb7d0c370.Contains(_0xb11edeec._0x1de8009f(new byte[17] { 107, 122, 122, 121, 36, 108, 107, 105, 111, 104, 101, 101, 97, 36, 105, 101, 103 }, 10));
        _0xe5511bfd = _0x7e090082 ? "" : (_0x14edabbe ? "" : _0xe5511bfd);
        _0xe5511bfd = _0xe5511bfd ?? "";
        _0x5cadc9ae = _0x5cadc9ae ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xe5511bfd}");
#endif
        }
    }

    private bool _0x415c13bc(string _0x66a7c5db)
    {
        if (string.IsNullOrEmpty(_0x66a7c5db))
            return false;
        try
        {
            using (var _0x7d6c31b4 = new AndroidJavaClass(_0xb11edeec._0x1de8009f(new byte[30] { 108, 96, 98, 33, 122, 97, 102, 123, 118, 60, 107, 33, 127, 99, 110, 118, 106, 125, 33, 90, 97, 102, 123, 118, 95, 99, 110, 118, 106, 125 }, 15)))
            using (var _0x9e5cf61d = _0x7d6c31b4.GetStatic<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[15] { 32, 54, 49, 49, 38, 45, 55, 2, 32, 55, 42, 53, 42, 55, 58 }, 67)))
            using (var _0xa51511a9 = _0x9e5cf61d.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[17] { 101, 103, 118, 82, 99, 97, 105, 99, 101, 103, 79, 99, 108, 99, 101, 103, 112 }, 2)))
            using (var _0xb38c3923 = _0xa51511a9.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[25] { 71, 69, 84, 108, 65, 85, 78, 67, 72, 105, 78, 84, 69, 78, 84, 102, 79, 82, 112, 65, 67, 75, 65, 71, 69 }, 32), _0x66a7c5db))
            {
                if (_0xb38c3923 == null)
                    return false;
                WLog(_0xb11edeec._0x1de8009f(new byte[37] { 101, 78, 84, 73, 75, 67, 106, 79, 77, 67, 6, 74, 71, 83, 72, 69, 78, 6, 79, 72, 85, 82, 71, 74, 74, 67, 66, 6, 86, 71, 69, 77, 71, 65, 67, 28, 6 }, 38) + _0x66a7c5db);
                _0xb38c3923.Call<AndroidJavaObject>(_0xb11edeec._0x1de8009f(new byte[8] { 160, 165, 165, 135, 173, 160, 166, 178 }, 193), 0x10000000);
                _0x9e5cf61d.Call(_0xb11edeec._0x1de8009f(new byte[13] { 238, 233, 252, 239, 233, 220, 254, 233, 244, 235, 244, 233, 228 }, 157), _0xb38c3923);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    public void _0x735c3a7b()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xb11edeec._0x1de8009f(new byte[18] { 185, 182, 135, 145, 150, 191, 194, 174, 131, 151, 140, 129, 138, 194, 165, 131, 143, 135 }, 226));
#endif
        }

        _0x2196ea34.Instance?._0xff13fb9b();
        _0x7f8d8525.Instance._0x8b4ff67b(_0xe06f358c._0x9fe1a6a5.DEFAULT);
    }

    internal Button _0x3f8bec99(string _0xfb9cff58, Transform _0x17f542b1)
    {
        var _0x27228df1 = new GameObject(_0xfb9cff58 + _0xb11edeec._0x1de8009f(new byte[3] { 245, 195, 217 }, 183), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x6152bde4 = _0x27228df1.GetComponent<RectTransform>();
        _0x6152bde4.SetParent(_0x17f542b1, false);
        var _0x00156f8b = _0x27228df1.GetComponent<Image>();
        _0x00156f8b.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x41eaf0bb = _0x27228df1.GetComponent<Button>();
        var _0xd03030aa = _0x41eaf0bb.colors;
        _0xd03030aa.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xd03030aa.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x41eaf0bb.colors = _0xd03030aa;
        var _0x52f74c7c = new GameObject(_0xb11edeec._0x1de8009f(new byte[4] { 204, 253, 224, 236 }, 152), typeof(RectTransform), typeof(Text));
        var _0x34fda05c = _0x52f74c7c.GetComponent<RectTransform>();
        _0x34fda05c.SetParent(_0x27228df1.transform, false);
        _0x34fda05c.anchorMin = Vector2.zero;
        _0x34fda05c.anchorMax = Vector2.one;
        _0x34fda05c.offsetMin = _0x34fda05c.offsetMax = Vector2.zero;
        var _0x9081adc0 = _0x52f74c7c.GetComponent<Text>();
        _0x9081adc0.text = _0xfb9cff58;
        _0x9081adc0.alignment = TextAnchor.MiddleCenter;
        _0x9081adc0.color = Color.black;
        _0x9081adc0.font = Resources.GetBuiltinResource<Font>(_0xb11edeec._0x1de8009f(new byte[9] { 204, 255, 228, 236, 225, 163, 249, 249, 235 }, 141));
        _0x9081adc0.fontSize = 28;
        WLog(_0xb11edeec._0x1de8009f(new byte[14] { 160, 145, 134, 130, 151, 134, 161, 150, 151, 151, 140, 141, 195, 196 }, 227) + _0xfb9cff58 + _0xb11edeec._0x1de8009f(new byte[1] { 75 }, 108));
        return _0x41eaf0bb;
    }

    private static readonly string WindowsDesktopUserAgent = _0xb11edeec._0x1de8009f(new byte[111] { 113, 83, 70, 85, 80, 80, 93, 19, 9, 18, 12, 28, 20, 107, 85, 82, 88, 83, 75, 79, 28, 114, 104, 28, 13, 12, 18, 12, 7, 28, 107, 85, 82, 10, 8, 7, 28, 68, 10, 8, 21, 28, 125, 76, 76, 80, 89, 107, 89, 94, 119, 85, 72, 19, 9, 15, 11, 18, 15, 10, 28, 20, 119, 116, 104, 113, 112, 16, 28, 80, 85, 87, 89, 28, 123, 89, 95, 87, 83, 21, 28, 127, 84, 78, 83, 81, 89, 19, 13, 14, 12, 18, 12, 18, 12, 18, 12, 28, 111, 93, 90, 93, 78, 85, 19, 9, 15, 11, 18, 15, 10 }, 60);
    private bool _0x33e9a0b8 = false;
    private bool _0x35c7a7cc = false;
    private void _0x7d521876()
    {
        _0x75b37112 = true;
        if (_0x6a329bfa != null)
            _0x6a329bfa.SetUserAgent(_0xf8be7f86());
    }

    private Text _0x14c94d78;
    private string _0xf8be7f86()
    {
        if (string.IsNullOrEmpty(_0x2f1caddc) && _0x6a329bfa != null)
            _0x2f1caddc = _0x6a329bfa.GetUserAgent();
        if (string.IsNullOrEmpty(_0x2f1caddc))
            return string.Empty;
        string _0x2a90369b = Regex.Replace(_0x2f1caddc, _0xb11edeec._0x1de8009f(new byte[11] { 71, 104, 49, 32, 71, 104, 49, 108, 109, 71, 121 }, 27), string.Empty);
        _0x2a90369b = Regex.Replace(_0x2a90369b, _0xb11edeec._0x1de8009f(new byte[15] { 124, 83, 11, 98, 85, 73, 76, 68, 15, 123, 126, 27, 9, 125, 11 }, 32), string.Empty);
        _0x2a90369b = Regex.Replace(_0x2a90369b, _0xb11edeec._0x1de8009f(new byte[15] { 222, 237, 250, 251, 225, 231, 230, 167, 188, 212, 166, 184, 212, 251, 162 }, 136), string.Empty);
        return Regex.Replace(_0x2a90369b, _0xb11edeec._0x1de8009f(new byte[6] { 45, 2, 10, 67, 93, 12 }, 113), _0xb11edeec._0x1de8009f(new byte[1] { 52 }, 20)).Trim();
    }

    private string _0x51289862;
    internal Rect lastSafe = Rect.zero;
    private bool _0x75b37112 = false;
    private Canvas _0x2cb3b45c()
    {
        if (_0xf4f781d4 != null)
            return _0xf4f781d4;
        var _0xd2345dc2 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xd2345dc2 == null)
        {
            var _0x33eca1f7 = new GameObject(_0xb11edeec._0x1de8009f(new byte[6] { 106, 72, 71, 95, 72, 90 }, 41), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xd2345dc2 = _0x33eca1f7.GetComponent<Canvas>();
            _0xd2345dc2.transform.SetParent(transform, false);
            _0xd2345dc2.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xf4f781d4 = _0xd2345dc2;
        return _0xf4f781d4;
    }

    private IEnumerator _0xe3936223(float _0x317df448)
    {
        yield return new WaitForSeconds(_0x317df448);
        if (!_0x70454d0b)
        {
            _0x70454d0b = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xb7d0c370}");
                }
#endif
            }
        }
    }
}

internal static class _0xb11edeec
{
    internal static string _0x1de8009f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}