﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DASH._Menu
{
    public class Menu_SceneManager : MonoBehaviour
    {
        #region Singleton

        public static Menu_SceneManager instance;

        private void Awake()
        {
            instance = this;
        }

        #endregion

        public void NewGame()
        {
            Debug.Log("load 1");
            SceneManager.LoadScene(1);
        }
        public void NewMenu()
        {
            Debug.Log("load 0");
            SceneManager.LoadScene(0);
        }
    }
}
