#if HRYOOBA_LIBRARY_DOTWEEN_SUPPORT
using UnityEngine;
using DG.Tweening;

namespace HRYooba.DOTween
{
    public static class DOTweenExtension
    {
        public static Tween DOFloat(this FloatTweenProperty target, float endValue, float duration)
        {
            return DG.Tweening.DOTween.To(() => target.Value, value => target.Value = value, endValue, duration);
        }

        public static Tween DOVector3(this Vector3TweenProperty target, Vector3 endValue, float duration)
        {
            return DG.Tweening.DOTween.To(() => target.Value, value => target.Value = value, endValue, duration);
        }

        public static Tween DOVector2(this Vector2TweenProperty target, Vector2 endValue, float duration)
        {
            return DG.Tweening.DOTween.To(() => target.Value, value => target.Value = value, endValue, duration);
        }

        public static Tween DOColor(this ColorTweenProperty target, Color endValue, float duration)
        {
            return DG.Tweening.DOTween.To(() => target.Value, value => target.Value = value, endValue, duration);
        }
    }

    [System.Serializable]
    public class FloatTweenProperty
    {
        [SerializeField]
        private float _value;

        public FloatTweenProperty(float value = default)
        {
            _value = value;
        }

        public float Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    public class Vector2TweenProperty
    {
        [SerializeField]
        private Vector2 _value;

        public Vector2TweenProperty(Vector2 value = default)
        {
            _value = value;
        }

        public Vector2 Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    public class Vector3TweenProperty
    {
        [SerializeField]
        private Vector3 _value;

        public Vector3TweenProperty(Vector3 value = default)
        {
            _value = value;
        }

        public Vector3 Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    public class ColorTweenProperty
    {
        [SerializeField]
        private Color _value;

        public ColorTweenProperty(Color value = default)
        {
            _value = value;
        }

        public Color Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
#endif