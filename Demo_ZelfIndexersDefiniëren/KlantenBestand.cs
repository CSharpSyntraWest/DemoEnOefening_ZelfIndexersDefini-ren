using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ZelfIndexersDefiniëren
{
    class KlantenBestand
    {
        private Dictionary<long, string> _klanten;
        public KlantenBestand()
        {
            _klanten = new Dictionary<long, string>();
        }
        public void VoegKlantToe(string klantNaam, long rijksRegNr)
        {
            _klanten.Add(rijksRegNr, klantNaam);
        }
        public void VerwijderKlant(long rijksRegNr)
        {
            _klanten.Remove(rijksRegNr);
        }
      //indexers definiëren:
        public string this[long rijksRegNr]
        {
            get {
                return _klanten[rijksRegNr];
            }
            set {
                _klanten[rijksRegNr] = value;
            }
        }
        public long this[string klantNaam]
        {
            //enkel leestoegang enkel get
            get {
                foreach (KeyValuePair<long, string> element in _klanten)
                {
                    if (element.Value == klantNaam) return element.Key;
                }
                return -1;//indien niet gevonden
            }
        }

    }
}
