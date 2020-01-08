using UnityEngine;
using UnityEngine.UI;

public class hint : MonoBehaviour
{
    public Text textexit;
    public Text textreset;
    public CanvasGroup uicanvusgroup;
    public void ShowDialog(string getname, string getcontent)

    {
        uicanvusgroup.alpha = 1;
        textexit.text = getname;
        textreset.text = getcontent;
    }

    public void HideDialog()
    {
        uicanvusgroup.alpha = 0;
    }
}
