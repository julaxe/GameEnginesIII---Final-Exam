using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[CreateAssetMenu(fileName = "DarkAndSpookyEffect", menuName = "ScriptableObjects/Effect/DarkAndSpookyEffect", order = 1)]
public class DarkAndSpookyEffect : Effect
{

    private GameObject _globalLight;
    public override void ActivateEffect()
    {
        base.ActivateEffect();
        foreach (var gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (gameObject.name == "GlobalLight")
            {
                _globalLight = gameObject;
            }
        }
        _globalLight.GetComponent<Light2D>().intensity = 0.2f;
    }

    public override void ExitEffect()
    {
        base.ExitEffect();
        _globalLight.GetComponent<Light2D>().intensity = 0.86f;
    }
}
