using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(CharacterAppearance))]
public class DeathEffectSetter : MonoBehaviour
{
    public bool overridePlayer = false;
    public bool overrideEnemy = true;
    public bool isVanillaEffect;
    public CharacterDeadEffect effect;
    public string vanillaEffect;
    void Start()
    {
        var appearance = GetComponent<CharacterAppearance>();
        var filter = BattleObjectManager.instance.GetList().Select(m => m.view).Where(v => v.charAppearance == appearance);
        foreach (var view in filter)
		{
            view.deadEffect = effect;
		}
    }
}