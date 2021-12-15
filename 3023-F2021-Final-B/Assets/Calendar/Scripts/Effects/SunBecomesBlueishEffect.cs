using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[CreateAssetMenu(fileName = "SunBecomesBlueishEffect", menuName = "ScriptableObjects/Effect/SunBecomesBlueishEffect", order = 1)]
public class SunBecomesBlueishEffect : Effect
{
    private GameObject _globalLight;

    public override void ActivateEffect()
    {
        base.ActivateEffect();
        _globalLight = GameObject.Find("GlobalLight");
        _globalLight.GetComponent<Light2D>().color = new Color(0.5711672f,0.5440251f, 1.0f );
        
    }

    public override void ExitEffect()
    {
        base.ExitEffect();
        if(_globalLight == null)
            _globalLight = GameObject.Find("GlobalLight");
        _globalLight.GetComponent<Light2D>().color = new Color(0.990566f, 0.8192417f, 0.8826951f);
    }
}
