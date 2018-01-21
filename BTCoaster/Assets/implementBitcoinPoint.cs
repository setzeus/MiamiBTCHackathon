using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class implementBitcoinPoint : MonoBehaviour
{

    public Text priceLabel;
    List<string> pricePoints = new List<string>(new string[] {
        "$663",
        "$1,013",
        "$1,056",
        "$1,085",
        "$1,091",
        "$1,142",
        "$1,185",
        "$1,331",
        "$1,720",
        "$2,212",
        "$2,827",
        "$2,671",
        "$2,491",
        "$2,682",
        "$2,874",
        "$4,130",
        "$4,912",
        "$4,311",
        "$4,194",
        "$4,819",
        "$5,773",
        "$7,158",
        "$8,251",
        "$13,541",
        "$15,191",
        "$13,541",
        "What Comes Next?",
    });
    List<string> datePoints = new List<string>(new string[] {
        "Jan 20th 2017",
        "Feb 3rd",
        "Feb 17th",
        "Feb 20th",
        "Mar 17th",
        "Apr 3rd",
        "Apr 14th",
        "Apr 28th",
        "May 12th",
        "May 26th",
        "Jun 9th",
        "Jun 21st",
        "Jul 7th",
        "Jul 21st",
        "Aug 4th",
        "Aug 18th",
        "Sept 1st",
        "Sep 8th",
        "Sep 29th",
        "Oct 11th",
        "Oct 27th",
        "Nov 9th",
        "Nov 24th",
        "Dec 6th",
        "Dec 22nd",
        "Jan 11th 2018",
        "Jan 19th",
    });
    public int counter = 0;

    //List<BitcoinPoint> bitcoinpointsTest = new List<BitcoinPoint> ();
    // Use this for initialization
    void Start()
    {
        priceLabel = GetComponent<Text>();
        StartCoroutine(Example());
    }



    IEnumerator Example()
    {
        while (enabled)
        {
            priceLabel.text = datePoints[counter] + ":   " + pricePoints[counter];
            counter++;
            yield return new WaitForSecondsRealtime(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //updateCounter ();	
    }
}
