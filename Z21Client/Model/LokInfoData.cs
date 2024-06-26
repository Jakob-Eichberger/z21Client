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
using System.Collections.Generic;

namespace Z21.Model
{
    public class LokInfoData
    {
        /// <summary>
        /// int -> <see cref="FunctionModel.Address"/> |
        /// bool -> TRUE: ON, FALSE, OFF
        /// </summary>
        public List<(int address, bool state)> Functions { get; } = new();

        private int speed = 0;

        public LokInfoData(LokAdresse adresse)
        {
            Adresse = adresse;
        }

        public LokInfoData(int adresse) => Adresse = new(adresse);

        public LokInfoData(long adresse) => Adresse = new((int)adresse);

        public LokInfoData()
        {
        }

        public LokAdresse Adresse { get; set; } = default!;

        public bool DrivingDirection { get; set; } = true;

        public bool InUse { get; set; } = default!;

        public int Speed
        {
            get => speed; set
            {
                speed = value == 1 ? speed > 1 ? 0 : 2 : value;
            }
        }
    }
}
