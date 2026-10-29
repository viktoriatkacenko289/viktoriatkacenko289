using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x2196ea34 : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xe06f358c._0x55066aa5.SCENE_0 && !_0x69cb75ef)
        {
            this._0x740f2993();
        }
        else
        {
            this._0x4f4b514f();
        }
    }

    public void _0xe66f1a4e()
    {
        this._0xf2e4c15a?.Pause();
    }

    public float FirstAnimationTime = 10.0f;
    public GameObject Background;
    public void _0x0991aefb()
    {
        this._0xf2e4c15a?.Kill();
        this.AnimationSlider.value = _0x69cb75ef ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0x30e8d2a1()
    {
        this._0xf2e4c15a?.Play();
    }

    public static _0x2196ea34 Instance;
    private void _0x740f2993()
    {
        this.AnimationSlider.value = 0.05f;
        _0x69cb75ef = !_0x69cb75ef;
        this._0xf2e4c15a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8efb2805 => this.AnimationSlider.value = _0x8efb2805, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xd110da96._0xf08c2322?._0xb1c34085();
        });
    }

    public float DefaultAnimationTime = 0.4f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2196ea34>();
    }

    public GameObject Content;
    public void _0x4f4b514f()
    {
        this._0x0991aefb();
        bool _0x08135752 = _0x69cb75ef;
        this._0xf2e4c15a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8efb2805 => this.AnimationSlider.value = _0x8efb2805, _0x08135752 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x69cb75ef = !_0x69cb75ef;
    }

    private Sequence _0xf2e4c15a;
    public float SecondPassSliderValue = 0.5f;
    public GameObject Error;
    private static bool _0x69cb75ef = false;
    public Slider AnimationSlider;
    public void _0xff13fb9b()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xf2e4c15a?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x69cb75ef = false;
    }
}