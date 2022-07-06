using UnityEngine.UI;
using UnityEngine;

public class Player_information : MonoBehaviour {
    public string team;
    public string level;
    public string linemateNbr;
    public string deraumereNbr;
    public string siburNbr;
    public string mendianeNbr;
    public string phirasNbr;
    public string thystameNbr;
    public string aliveNbr;
    public string deadNbr;
    public string maxNbr;
    public Text textTeam;
    public Text textLevel;
    public Text textLinemateNbr;
    public Text textDeraumereNbr;
    public Text textSiburNbr;
    public Text textMendianeNbr;
    public Text textPhirasNbr;
    public Text textThystameNbr;
    public Text textAliveNbr;
    public Text textDeadNbr;
    public Text textMaxNbr;
    public MouseHandler mh;

    public void refresh() {
        mh.refreshPlayer();
        textTeam.text = team;
        textLevel.text = level;
        textLinemateNbr.text = linemateNbr;
        textDeraumereNbr.text = deraumereNbr;
        textSiburNbr.text = siburNbr;
        textMendianeNbr.text = mendianeNbr;
        textPhirasNbr.text = phirasNbr;
        textThystameNbr.text = thystameNbr;
        textAliveNbr.text = aliveNbr;
        textDeadNbr.text = deadNbr;
        textMaxNbr.text = maxNbr;
    }
}
