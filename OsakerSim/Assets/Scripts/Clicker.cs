using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour {

    public Animator osaka;
    public AudioSource screamSFX;
    public AudioSource clickSFX;
    public AudioSource leanSFX;

    public TextMeshProUGUI clickerStatsLabel;
    public Animator clickerStatsLabelAnimator;

    public static int Osakers;
    public static int Leans;

    private void Awake () {

        //Load
        Osakers = PlayerPrefs.GetInt("Clicker.Osakers", 0);
        Leans = PlayerPrefs.GetInt("Clicker.Leans", 0);
    }

    private void FixedUpdate () {

        clickerStatsLabel.text = $"OSAKERS: {Osakers}\nLEANS: {Leans}";
    }

    public void Click () {

        clickSFX.PlayOneShot();
        screamSFX.PlayOneShot();

        osaka.Play("Scream", -1, 0);

        Osakers++;

        if (Osakers > 0 && Osakers % 10 == 0) {

            leanSFX.PlayOneShot();

            clickerStatsLabelAnimator.Play("Lean", -1, 0);

            Leans++;

        } else {

            clickerStatsLabelAnimator.Play("Click", -1, 0);
        }

        //Save
        PlayerPrefs.SetInt("Clicker.Osakers", Osakers);
        PlayerPrefs.SetInt("Clicker.Leans", Leans);
    }
}