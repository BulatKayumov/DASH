using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DASH._Menu
{
    public class Slot : MonoBehaviour
    {
        public Image icon;
        public Button equipButton;
        public Button unequipButton;
        [SerializeField]
        private int groupId;
        public int id;

        public void Equip()
        {
            if (groupId == 0)
            {
                PlayerPrefs.SetInt("currentLegs", id);
            }
            if (groupId == 1)
            {
                PlayerPrefs.SetInt("currentTorso", id);
            }
            equipButton.gameObject.SetActive(false);
            unequipButton.gameObject.SetActive(true);
            Equipment.instance.EquipItem(groupId, id);
        }

        public void Unequip()
        {
            if (groupId == 0)
            {
                PlayerPrefs.SetInt("currentLegs", 0);
            }
            if (groupId == 1)
            {
                PlayerPrefs.SetInt("currentTorso", 0);
            }
            unequipButton.gameObject.SetActive(false);
            equipButton.gameObject.SetActive(true);
            Equipment.instance.EquipItem(groupId, 0);
        }
    }
}