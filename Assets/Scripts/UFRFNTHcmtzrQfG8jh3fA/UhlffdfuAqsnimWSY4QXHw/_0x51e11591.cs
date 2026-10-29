using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xe06f358c;

public class _0x51e11591 : MonoBehaviour
{
    [HideInInspector]
    public List<_0x6d688570> MoneyCountContainers = new();
    public Button ShowResetTutorialButton;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x51e11591>();
        this.RootGameObject = GameObject.FindWithTag(_0x74c6331f._0xde4132f5(new byte[4] { 228, 217, 217, 194 }, 182));
        if (this._0x98004973 == _0x55066aa5.SCENE_0)
            this._0xc5f3775b(true);
        else
            this._0xc5f3775b(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x6d688570>(true).ToList();
    }

    public void _0xfa9d91a1()
    {
        _0xb220032e._0x37528f6e = true;
    }

    private static _0x24d7a178 GAME_INDEX_SETTINGS(int _0xc4f911e2)
    {
        return _0x24d7a178.ALL_SCENES_SETTING_SINGLETONS[_0xc4f911e2];
    }

    private void _0x1754ace5(Transform _0xe57979ab)
    {
        Transform[] _0x365dbdb8 = _0xe57979ab.GetComponentsInChildren<Transform>();
        foreach (Transform _0x5bfe649c in _0x365dbdb8)
            if (_0x5bfe649c != null && DOTween.IsTweening(_0x5bfe649c))
            {
                if (this._0x13f79269)
                    DOTween.Play(_0x5bfe649c);
                else
                    DOTween.Pause(_0x5bfe649c);
            }
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public bool _0x13f79269 { get; private set; }

    private IEnumerator _0x55feb0bd(string _0x22d640d5)
    {
        _0x7f8d8525.Instance._0x8b4ff67b(_0x9fe1a6a5.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x79b4a951 = SceneManager.LoadSceneAsync(_0x22d640d5);
        while (!_0x79b4a951.isDone)
            yield return null;
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public static _0x24d7a178 _0xb220032e => _0x24d7a178.ALL_SCENES_SETTING_SINGLETONS[Instance._0x98004973];

    private IEnumerator _0xb5412d68(int _0x2e6c5581)
    {
        _0x7f8d8525.Instance._0x8b4ff67b(_0x9fe1a6a5.SPLASH);
        AsyncOperation _0xb41097d6 = SceneManager.LoadSceneAsync(_0x2e6c5581);
        while (!_0xb41097d6.isDone)
            yield return null;
    }

    public Canvas MainCanvas;
    private void _0xf4c10316()
    {
        IsAfterLevelComplete = true;
        Instance._0x05618a99(_0x55066aa5.SCENE_0);
    }

    private void _0xfa7b6009(bool _0x23fb96ec)
    {
        Rigidbody2D[] _0xe754107e = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x56996a83 in _0xe754107e)
            if (_0x23fb96ec)
                _0x56996a83.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x56996a83.constraints = RigidbodyConstraints2D.None;
    }

    public Transform Environment;
    public void _0xc5f3775b(bool _0xbe8f1e58)
    {
        this._0x13f79269 = _0xbe8f1e58;
        this._0xfa7b6009(!this._0x13f79269);
        Physics2D.simulationMode = this._0x13f79269 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x1754ace5(this.EnvironmentWithTweensToToggle);
    }

    private static _0x24d7a178 _0x6eb72099 => _0x24d7a178.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0x05618a99(int _0x7c998d48)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xb5412d68(_0x7c998d48));
    }

    public Button DeleteProgressDataButton;
    public static bool IsAfterLevelComplete;
    public Transform EnvironmentWithTweensToToggle;
    public int _0x98004973 => SceneManager.GetActiveScene().buildIndex;

    public static _0x51e11591 Instance;
    private static void MakeGrid(List<RectTransform> _0xb42f1f1e, AspectRatioFitter _0x18b8cd19, float _0x5ac73251, int _0x8e3337cd, int _0x3a06acd5)
    {
        _0x18b8cd19.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x18b8cd19.aspectRatio = _0x5ac73251;
        foreach (RectTransform _0x087738b1 in _0xb42f1f1e)
        {
            int _0x9d439c12 = _0x087738b1.transform.GetSiblingIndex();
            _0x087738b1.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x9d439c12 % _0x8e3337cd) * (1f / _0x8e3337cd), (_0x3a06acd5 - (Mathf.FloorToInt((float)_0x9d439c12 / _0x8e3337cd) % _0x3a06acd5 + 1f)) * (1f / _0x3a06acd5));
            _0x087738b1.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x9d439c12 % _0x8e3337cd + 1f) * (1f / _0x8e3337cd), (_0x3a06acd5 - Mathf.FloorToInt((float)_0x9d439c12 / _0x8e3337cd) % _0x3a06acd5) * (1f / _0x3a06acd5));
            _0x087738b1.offsetMin = Vector2.zero;
            _0x087738b1.offsetMax = Vector2.zero;
        }
    }

    public static bool IsAfterLevelFailed = false;
    public void _0x6547b8de()
    {
        this._0x05618a99(SceneManager.GetActiveScene().buildIndex);
    }

    public void _0xa7bf546d()
    {
        foreach (_0x6d688570 _0x60d03bab in this.MoneyCountContainers)
            _0x60d03bab._0xa12ded5c();
    }

    private void Start()
    {
        if (this._0x98004973 != _0x55066aa5.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x05618a99(_0x55066aa5.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xb220032e._0x37528f6e = false;
            _0x8f0aa4a3.Instance._0xed11e002();
            _0x7f8d8525.Instance._0x8b4ff67b(_0x9fe1a6a5.TUTORIAL0);
        });
    }
}

internal static class _0x74c6331f
{
    internal static string _0xde4132f5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}