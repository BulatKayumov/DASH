using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DASH._Units;
using DASH._UI;

namespace DASH._Player
{
    public class PlayerHealth : MonoBehaviour
    {

        public float currentHP;
        private CharacterStats stats;
        private UIManager ui;
        private void Start()
        {
            stats = GetComponent<CharacterStats>();
            ui = UIManager.instance;
            currentHP = stats.maxHealth.GetStat();
            InvokeRepeating("Regenerate", 0, 1);
        }

        public void Heal(float value)
        {
            currentHP += value;
            currentHP = Mathf.Clamp(currentHP, 0, stats.maxHealth.GetStat());
            ui.SetHealText(value);
        }

        private void Regenerate()
        {
            currentHP += stats.regeneration.GetStat();
            currentHP = Mathf.Clamp(currentHP, 0, stats.maxHealth.GetStat());
        }
    }
}