using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DASH._Menu
{
    public class LocationsScript : MonoBehaviour
    {
        public GameObject Locations;
        public GameObject[] cameras;
        private int currentIndex = 0;
        public GameObject cameraCurrent;

        [SerializeField]
        private Shop shop;
        [SerializeField]
        private Equipment equipment;
        public void LocationsChangeVisible()
        {
            if (Locations.activeSelf)
            {
                Locations.SetActive(false);
                cameras[currentIndex].SetActive(false);
                cameraCurrent.SetActive(true);
            }
            else
            {
                Locations.SetActive(true);
                cameraCurrent.SetActive(false);
                cameras[currentIndex].SetActive(true);

            }
        }

        public void changeCamera(int index)
        {
            cameras[currentIndex].SetActive(false);
            currentIndex = index;
            cameras[currentIndex].SetActive(true);
            if (currentIndex == 1)
            {
                shop.OpenShop();
            }
            else
            {
                shop.CloseShop();
            }
            if (currentIndex == 2)
            {
                equipment.OpenEquipment();
            }
            else
            {
                equipment.CloseEquipment();
            }
        }


    }
}