using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UIManager : MonoBehaviour
    {
        public Text ScoreTxt;
        public List<Image> Hearts;
        public Sprite DamagedHeartSprite;

        void Start()
        {
            Hearts = new List<Image>
            {
                GameObject.Find("Heart1").GetComponent<Image>(),
                GameObject.Find("Heart2").GetComponent<Image>(),
                GameObject.Find("Heart3").GetComponent<Image>()
            };

            SetScoreTxt(0);
        }

        public void SetScoreTxt(int score)
        {
            ScoreTxt.text = $"Score: {score}";
        }

        public void TakeDmg(int health)
        {
            Hearts[health].sprite = DamagedHeartSprite;
        }
    }
}
