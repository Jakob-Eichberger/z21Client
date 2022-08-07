﻿/* Z21 - C#-Implementierung des Protokolls der Kommunikation mit der digitalen
 * Steuerzentrale Z21 oder z21 von Fleischmann/Roco
 * ---------------------------------------------------------------------------
 * Datei:     z21.cs
 * Version:   16.06.2014
 * Besitzer:  Mathias Rentsch (rentsch@online.de)
 * Lizenz:    GPL
 *
 * Die Anwendung und die Quelltextdateien sind freie Software und stehen unter der
 * GNU General Public License. Der Originaltext dieser Lizenz kann eingesehen werden
 * unter http://www.gnu.org/licenses/gpl.html.
 * 
 */

using Z21.Enums;

namespace Z21.DTO
{
    public class TurnoutInfoData
    {

        public TurnoutInfoData(int adresse, Position state)
        {
            Adresse = new(adresse);
            Position = state;
        }

        public TurnoutInfoData(long adresse, Position state)
        {
            Adresse = new(adresse);
            Position = state;
        }

        public TurnoutInfoData(TurnoutAdresse adresse, Position state)
        {
            Adresse = adresse;
            Position = state;
        }

        public TurnoutAdresse Adresse { get; private set; }

        public Position Position { get; private set; }
    }
}
