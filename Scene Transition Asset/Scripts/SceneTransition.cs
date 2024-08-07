using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace SceneTransition
{

    public class SceneTransition : MonoBehaviour
    {
        public TMP_Text LoadingPrecentageTMP;
        public Text LoadingPrecentage;
        public Image LoadingProgressBar;

        public static Action StartSwitchScene;
        public static Action EndSwitchScene;

        private static SceneTransition instance;
        private static bool shouldPlayOpeningAnimation = false;

        private Animator componentAnimator;
        private AsyncOperation loadingSceneOperaiton;


        public static void SwitchToScene(string sceneName)
        {
            StartSwitchScene?.Invoke();

            instance.componentAnimator.SetTrigger("sceneClosing");

            instance.loadingSceneOperaiton = SceneManager.LoadSceneAsync(sceneName);
            instance.loadingSceneOperaiton.allowSceneActivation = false;
        }


        void Start()
        {
            instance = this;

            componentAnimator = GetComponent<Animator>();

            if (shouldPlayOpeningAnimation) componentAnimator.SetTrigger("sceneOpening");
        }

        private void Update()
        {
            if (loadingSceneOperaiton != null)
            {
                string loadingPrecentage = Mathf.RoundToInt(loadingSceneOperaiton.progress * 100) + "%";
                
                if (LoadingPrecentageTMP != null) LoadingPrecentageTMP.text = loadingPrecentage;
                if (LoadingPrecentage != null) LoadingPrecentage.text = loadingPrecentage;

                LoadingProgressBar.fillAmount = loadingSceneOperaiton.progress;
            }
        }

        public void OnAnimatoinOver()
        {
            shouldPlayOpeningAnimation = true;
            loadingSceneOperaiton.allowSceneActivation = true;

            EndSwitchScene?.Invoke();
        }
    }
}
