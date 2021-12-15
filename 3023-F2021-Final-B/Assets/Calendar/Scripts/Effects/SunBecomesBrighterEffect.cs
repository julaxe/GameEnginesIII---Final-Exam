using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[CreateAssetMenu(fileName = "SunBecomesBrighterEffect", menuName = "ScriptableObjects/Effect/SunBecomesBrighterEffect", order = 1)]
public class SunBecomesBrighterEffect : Effect
{

    private GameObject _globalLight;
    public override void ActivateEffect()
    {
        base.ActivateEffect();
        _globalLight = GameObject.Find("GlobalLight");
        _globalLight.GetComponent<Light2D>().intensity = 1.5f;
    }

    public override void ExitEffect()
    {
        base.ExitEffect();
        if(_globalLight == null)
            _globalLight = GameObject.Find("GlobalLight");
        _globalLight.GetComponent<Light2D>().intensity = 0.86f;
    }
}
