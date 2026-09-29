using static System.Windows.Forms.AxHost;

namespace WoordenWisselen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zin = Convert.ToString(ZinTextBox.Text);
            int spatie = zin.IndexOf(" ");
            string EersteWoord = zin.Substring(0, spatie);
            string zin2 = zin.Substring(spatie);
            EersteWoordLabel.Text = Convert.ToString(zin2 + " " + EersteWoord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string zin = Convert.ToString(ZinTextBox.Text);
            int spatie1 = zin.IndexOf(" ");
            int spatie2 = zin.LastIndexOf(" ");
            int lengte = zin.Length;
            string EersteWoord = zin.Substring(0, spatie1);
            int lengteLaatsteWoord = lengte - spatie2;
            string LaatsteWoord = zin.Substring(spatie2 + 1);
            string zin2 = zin.Substring(spatie1, spatie2 - spatie1);
            EersteEnLaatsteWoordLabel.Text = LaatsteWoord + zin2 + " " + EersteWoord;
        }
        /*==========Analyse==========
1. Invoer: Welke invoer mag ik verwachten in de eerste situatie? Geef zowel een naam/beschrijving als een datatype.
een zin - string

2a. Bewerking:Welke stappen moet je doorlopen om het eerste woord te bepalen? Welke ingebouwde functie ga je hiervoor gebruiken?
de eerste spatie vinden en alles ervoor in een string variable zetten

2b. Welke stappen moet je doorlopen om dit eerste woord uit de zin te verwijderen en achteraan te zetten?
alles na de eerste spatie + het eerste woord

----------------------------------------------
3. Invoer:Welke invoer mag je verwachten in de tweede situatie? Geef zowel een naam/beschrijving als een datatype.
een zin - string

4a. Bewerking: Welke stappen moet je doorlopen om het eerste én laatste woord te bepalen? Welke ingebouwde functies ga je hiervoor gebruiken?
de eerste spatie vinden en alles ervoor pakken 
de laatste spatie vinden en alles er na pakken

4b. Welke stappen moet je doorlopen om deze woorden van plaats te wisselen (uiteraard ZONDER aan de rest van de zin te raken)?
het laatste woord + alles tussen de 2 spaties + het eerste woord

5.Testdata: Verzin en noteer testgegevens, en bereken zelf de juiste oplossing. Zo weet je of je oefening klopt.
dit is een zin
wordt: is een zin dit
en wordt: zin is een dit

==========Analyse==========*/

    }
}
