using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TweenColor : Tween
{
    private Color _startColor;
    private Color _targetColor;
    protected Vector3 _direction;

    protected override void PerformTween(float easeStep)
    {
        // hoe kan ik lerpen met eeasestep tussen _currentColor en _targetColor
        //_startColor + (_direction * easeStep);
        base.PerformTween(easeStep);
        _gameObject.GetComponent<Renderer>().material.color = Color.Lerp(_startColor, _targetColor, easeStep);
    }
    protected override void OnTweenComplete()
    {
        base.OnTweenComplete();
        _gameObject.GetComponent<Renderer>().material.color = _targetColor;
    }

    public TweenColor(GameObject objectToMove, Color targetColor, float speed, Func<float, float> easeMethod) : base(objectToMove, speed, easeMethod)
    {
        // wat is mijn huidige kleur?
        _startColor = _gameObject.GetComponent<Renderer>().material.color;
        _targetColor = targetColor;
        //_direction = targetColor - _startColor;
    }
}


