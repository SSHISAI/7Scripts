namespace _7Scripts
{
    class Operators
    {
        #region **Attackers**
        public static void Attackers()
        {
            Dashboard.weapons.Clear();

            if (Dashboard.selectedoperator == "Recruit")
            {
                Dashboard.weapons.Add("L85A2");
                Dashboard.weapons.Add("Mk 14 EBR");
                Dashboard.weapons.Add("M249");
                Dashboard.weapons.Add("C75 Auto");
                Dashboard.weapons.Add("P12");
                Dashboard.weapons.Add("Super Shorty");
            }
            else if (Dashboard.selectedoperator == "Sledge")
            {
                Dashboard.weapons.Add("M590A1");
                Dashboard.weapons.Add("L85A2");
                Dashboard.weapons.Add("P226 Mk 25");
                Dashboard.weapons.Add("SMG-11");
            }
            else if (Dashboard.selectedoperator == "Thatcher")
            {
                Dashboard.weapons.Add("AR33");
                Dashboard.weapons.Add("L85A2");
                Dashboard.weapons.Add("M590A1");
                Dashboard.weapons.Add("P226 Mk 25");
            }
            else if (Dashboard.selectedoperator == "Ash")
            {
                Dashboard.weapons.Add("G36C");
                Dashboard.weapons.Add("R4-C");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("M45 MEUSOC");
            }
            else if (Dashboard.selectedoperator == "Thermite")
            {
                Dashboard.weapons.Add("M1014");
                Dashboard.weapons.Add("556xi");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("M45 MEUSOC");
            }
            else if (Dashboard.selectedoperator == "Twitch")
            {
                Dashboard.weapons.Add("F2");
                Dashboard.weapons.Add("417");
                Dashboard.weapons.Add("SG-CQB");
                Dashboard.weapons.Add("P9");
                Dashboard.weapons.Add("LFP586");
            }
            else if (Dashboard.selectedoperator == "Montagne")
            {
                Dashboard.weapons.Add("P9");
                Dashboard.weapons.Add("LFP586");
            }
            else if (Dashboard.selectedoperator == "Glaz")
            {
                Dashboard.weapons.Add("OTs-03");
                Dashboard.weapons.Add("PMM");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Fuze")
            {
                Dashboard.weapons.Add("AK-12");
                Dashboard.weapons.Add("6P41");
                Dashboard.weapons.Add("PMM");
                Dashboard.weapons.Add("GSh-18");
            }
            else if (Dashboard.selectedoperator == "Blitz")
            {
                Dashboard.weapons.Add("P12");
            }
            else if (Dashboard.selectedoperator == "IQ")
            {
                Dashboard.weapons.Add("AUG A2");
                Dashboard.weapons.Add("552 Commando");
                Dashboard.weapons.Add("G8A1");
                Dashboard.weapons.Add("P12");
            }
            else if (Dashboard.selectedoperator == "Buck")
            {
                Dashboard.weapons.Add("C8-SFW");
                Dashboard.weapons.Add("CAMRS");
                Dashboard.weapons.Add("Mk1 9mm");
            }
            else if (Dashboard.selectedoperator == "Blackbeard")
            {
                Dashboard.weapons.Add("Mk17 CQB");
                Dashboard.weapons.Add("SR-25");
                Dashboard.weapons.Add("D-50");
            }
            else if (Dashboard.selectedoperator == "Capitão")
            {
                Dashboard.weapons.Add("PARA-308");
                Dashboard.weapons.Add("M249");
                Dashboard.weapons.Add("PRB92");
            }
            else if (Dashboard.selectedoperator == "Hibana")
            {
                Dashboard.weapons.Add("Type-89");
                Dashboard.weapons.Add("SuperNova");
                Dashboard.weapons.Add("P229");
                Dashboard.weapons.Add("Bearing 9");
            }
            else if (Dashboard.selectedoperator == "Jackal")
            {
                Dashboard.weapons.Add("C7E");
                Dashboard.weapons.Add("PDW9");
                Dashboard.weapons.Add("ITA12L");
                Dashboard.weapons.Add("USP40");
                Dashboard.weapons.Add("ITA12S");
            }
            else if (Dashboard.selectedoperator == "Ying")
            {
                Dashboard.weapons.Add("T-95 LSW");
                Dashboard.weapons.Add("SIX12");
                Dashboard.weapons.Add("Q-929");
            }
            else if (Dashboard.selectedoperator == "Zofia")
            {
                Dashboard.weapons.Add("LMG-E");
                Dashboard.weapons.Add("M762");
                Dashboard.weapons.Add("RG15");
            }
            else if (Dashboard.selectedoperator == "Dokkaebi")
            {
                Dashboard.weapons.Add("Mk 14 EBR");
                Dashboard.weapons.Add("BOSG.12.2");
                Dashboard.weapons.Add("SMG-12");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Lion")
            {
                Dashboard.weapons.Add("V308");
                Dashboard.weapons.Add("417");
                Dashboard.weapons.Add("SG-CQB");
                Dashboard.weapons.Add("LFP586");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Finka")
            {
                Dashboard.weapons.Add("Spear .308");
                Dashboard.weapons.Add("6P41");
                Dashboard.weapons.Add("SASG-12");
                Dashboard.weapons.Add("PMM");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Maverick")
            {
                Dashboard.weapons.Add("AR-15.50");
                Dashboard.weapons.Add("M4");
                Dashboard.weapons.Add("1911 TACOPS");
            }
            else if (Dashboard.selectedoperator == "Nomad")
            {
                Dashboard.weapons.Add("AK-74M");
                Dashboard.weapons.Add("ARX200");
                Dashboard.weapons.Add(".44 Mag Semi-Auto");
                Dashboard.weapons.Add("PRB92");
            }
            else if (Dashboard.selectedoperator == "Gridlock")
            {
                Dashboard.weapons.Add("F90");
                Dashboard.weapons.Add("M249 SAW");
                Dashboard.weapons.Add("Super Shorty");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Nøkk")
            {
                Dashboard.weapons.Add("FMG-9");
                Dashboard.weapons.Add("SIX12 SD");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("D-50");
            }
            else if (Dashboard.selectedoperator == "Amaru")
            {
                Dashboard.weapons.Add("G8A1");
                Dashboard.weapons.Add("SuperNova");
                Dashboard.weapons.Add("SMG-11");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Kali")
            {
                Dashboard.weapons.Add("CSRX 300");
                Dashboard.weapons.Add("SPSMG9");
                Dashboard.weapons.Add("C75 Auto");
            }
            else if (Dashboard.selectedoperator == "Iana")
            {
                Dashboard.weapons.Add("ARX200");
                Dashboard.weapons.Add("G36C");
                Dashboard.weapons.Add("Mk1 9mm");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Ace")
            {
                Dashboard.weapons.Add("AK-12");
                Dashboard.weapons.Add("M1014");
                Dashboard.weapons.Add("P9");
            }
            else if (Dashboard.selectedoperator == "Zero")
            {
                Dashboard.weapons.Add("SC3000K");
                Dashboard.weapons.Add("MP7");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("GONNE-6");
            }
            else if (Dashboard.selectedoperator == "Flores")
            {
                Dashboard.weapons.Add("AR33");
                Dashboard.weapons.Add("SR-25");
                Dashboard.weapons.Add("GSh-18");
            }
            else if (Dashboard.selectedoperator == "Osa")
            {
                Dashboard.weapons.Add("556xi");
                Dashboard.weapons.Add("PDW9");
                Dashboard.weapons.Add("PMM");
            }
        }
        #endregion **Attackers**

        #region **Defenders**
        public static void Defenders()
        {
            Dashboard.weapons.Clear();
            if (Dashboard.selectedoperator == "Recruit")
            {
                Dashboard.weapons.Add("M870");
                Dashboard.weapons.Add("MP5K");
                Dashboard.weapons.Add("P9");
                Dashboard.weapons.Add("SMG-11");
            }
            else if (Dashboard.selectedoperator == "Smoke")
            {
                Dashboard.weapons.Add("M590A1");
                Dashboard.weapons.Add("FMG-9");
                Dashboard.weapons.Add("P226 Mk 25");
                Dashboard.weapons.Add("SMG-11");
            }
            else if (Dashboard.selectedoperator == "Mute")
            {
                Dashboard.weapons.Add("MP5K");
                Dashboard.weapons.Add("M590A1");
                Dashboard.weapons.Add("P226 Mk 25");
                Dashboard.weapons.Add("SMG-11");
            }
            else if (Dashboard.selectedoperator == "Castle")
            {
                Dashboard.weapons.Add("UMP45");
                Dashboard.weapons.Add("M1014");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("Super Shorty");
            }
            else if (Dashboard.selectedoperator == "Pulse")
            {
                Dashboard.weapons.Add("UMP45");
                Dashboard.weapons.Add("M1014");
                Dashboard.weapons.Add("5.7 USG");
                Dashboard.weapons.Add("M45 MEUSOC");
            }
            else if (Dashboard.selectedoperator == "Doc")
            {
                Dashboard.weapons.Add("MP5");
                Dashboard.weapons.Add("P90");
                Dashboard.weapons.Add("SG-CQB");
                Dashboard.weapons.Add("P9");
                Dashboard.weapons.Add("LFP586");
            }
            else if (Dashboard.selectedoperator == "Rook")
            {
                Dashboard.weapons.Add("MP5");
                Dashboard.weapons.Add("P90");
                Dashboard.weapons.Add("SG-CQB");
                Dashboard.weapons.Add("P9");
                Dashboard.weapons.Add("LFP586");
            }
            else if (Dashboard.selectedoperator == "Kapkan")
            {
                Dashboard.weapons.Add("9x19VSN");
                Dashboard.weapons.Add("SASG-12");
                Dashboard.weapons.Add("PMM");
                Dashboard.weapons.Add("GSh-18");
            }
            else if (Dashboard.selectedoperator == "Tachanka")
            {
                Dashboard.weapons.Add("DP27");
                Dashboard.weapons.Add("9x19VSN");
                Dashboard.weapons.Add("PMM");
                Dashboard.weapons.Add("GSh-18");
            }
            else if (Dashboard.selectedoperator == "Jäger")
            {
                Dashboard.weapons.Add("M870");
                Dashboard.weapons.Add("416-C Carbine");
                Dashboard.weapons.Add("P12");
            }
            else if (Dashboard.selectedoperator == "Bandit")
            {
                Dashboard.weapons.Add("M870");
                Dashboard.weapons.Add("MP7");
                Dashboard.weapons.Add("P12");
            }
            else if (Dashboard.selectedoperator == "Frost")
            {
                Dashboard.weapons.Add("Super 90");
                Dashboard.weapons.Add("9mm C1");
                Dashboard.weapons.Add("Mk1 9mm");
                Dashboard.weapons.Add("ITA12S");
            }
            else if (Dashboard.selectedoperator == "Valkyrie")
            {
                Dashboard.weapons.Add("MPX");
                Dashboard.weapons.Add("SPAS-12");
                Dashboard.weapons.Add("D-50");
            }
            else if (Dashboard.selectedoperator == "Caveira")
            {
                Dashboard.weapons.Add("Luison");
                Dashboard.weapons.Add("M12");
                Dashboard.weapons.Add("SPAS-15");
            }
            else if (Dashboard.selectedoperator == "Echo")
            {
                Dashboard.weapons.Add("MP5SD");
                Dashboard.weapons.Add("SuperNova");
                Dashboard.weapons.Add("P229");
                Dashboard.weapons.Add("Bearing 9");
            }
            else if (Dashboard.selectedoperator == "Mira")
            {
                Dashboard.weapons.Add("Vector .45 ACP");
                Dashboard.weapons.Add("ITA12L");
                Dashboard.weapons.Add("USP40");
                Dashboard.weapons.Add("ITA12S");
            }
            else if (Dashboard.selectedoperator == "Lesion")
            {
                Dashboard.weapons.Add("SIX12 SD");
                Dashboard.weapons.Add("T-5 SMG");
                Dashboard.weapons.Add("Q-929");
            }
            else if (Dashboard.selectedoperator == "Ela")
            {
                Dashboard.weapons.Add("Scorpion EVO 3 A1");
                Dashboard.weapons.Add("FO-12");
                Dashboard.weapons.Add("RG15");
            }
            else if (Dashboard.selectedoperator == "Vigil")
            {
                Dashboard.weapons.Add("K1A");
                Dashboard.weapons.Add("BOSG.12.2");
                Dashboard.weapons.Add("C75 Auto");
                Dashboard.weapons.Add("SMG-12");
            }
            else if (Dashboard.selectedoperator == "Alibi")
            {
                Dashboard.weapons.Add("ACS12");
                Dashboard.weapons.Add("Mx4 Storm");
                Dashboard.weapons.Add("Bailiff 410");
                Dashboard.weapons.Add("Keratos .357");
            }
            else if (Dashboard.selectedoperator == "Maestro")
            {
                Dashboard.weapons.Add("ALDA 5.56");
                Dashboard.weapons.Add("ACS12");
                Dashboard.weapons.Add("Keratos .357");
                Dashboard.weapons.Add("Bailiff 410");
            }
            else if (Dashboard.selectedoperator == "Clash")
            {
                Dashboard.weapons.Add("P-10C");
                Dashboard.weapons.Add("SPSMG9");
            }
            else if (Dashboard.selectedoperator == "Kaid")
            {
                Dashboard.weapons.Add("AUG A3");
                Dashboard.weapons.Add("TCSG12");
                Dashboard.weapons.Add(".44 Mag Semi-Auto");
                Dashboard.weapons.Add("LFP586");
            }
            else if (Dashboard.selectedoperator == "Mozzie")
            {
                Dashboard.weapons.Add("Commando 9");
                Dashboard.weapons.Add("P10 RONI");
                Dashboard.weapons.Add("SDP 9mm");
            }
            else if (Dashboard.selectedoperator == "Warden")
            {
                Dashboard.weapons.Add("M590A1");
                Dashboard.weapons.Add("MPX");
                Dashboard.weapons.Add("P-10C");
                Dashboard.weapons.Add("SMG-12");
            }
            else if (Dashboard.selectedoperator == "Goyo")
            {
                Dashboard.weapons.Add("Vector .45 ACP");
                Dashboard.weapons.Add("TCSG12");
                Dashboard.weapons.Add("P229");
            }
            else if (Dashboard.selectedoperator == "Wamai")
            {
                Dashboard.weapons.Add("AUG A2");
                Dashboard.weapons.Add("MP5K");
                Dashboard.weapons.Add("P12");
                Dashboard.weapons.Add("Keratos .357");
            }
            else if (Dashboard.selectedoperator == "Oryx")
            {
                Dashboard.weapons.Add("SPAS-12");
                Dashboard.weapons.Add("T-5 SMG");
                Dashboard.weapons.Add("Bailiff 410");
                Dashboard.weapons.Add("USP40");
            }
            else if (Dashboard.selectedoperator == "Melusi")
            {
                Dashboard.weapons.Add("MP5");
                Dashboard.weapons.Add("Super 90");
                Dashboard.weapons.Add("RG15");
            }
            else if (Dashboard.selectedoperator == "Aruni")
            {
                Dashboard.weapons.Add("P10 RONI");
                Dashboard.weapons.Add("Mk 14 EBR");
                Dashboard.weapons.Add("PRB92");
            }
            else if (Dashboard.selectedoperator == "Thunderbird")
            {
                Dashboard.weapons.Add("Spear .308");
                Dashboard.weapons.Add("SPAS-15");
                Dashboard.weapons.Add("Bearing 9");
                Dashboard.weapons.Add("Q-929");
            }
            else if (Dashboard.selectedoperator == "Thorn")
            {
                Dashboard.weapons.Add("M870");
                Dashboard.weapons.Add("1911 TACOPS");
                Dashboard.weapons.Add("C75 Auto");
                Dashboard.weapons.Add("UZK50GI");
            }
        }
        #endregion **Defenders**

        #region **Operator List**
        public static string[] GetAttackers = new string[] { "Recruit", "Sledge", "Thatcher", "Ash", "Thermite", "Twitch", "Montagne", "Glaz", "Fuze", "Blitz", "IQ", "Buck", "Blackbeard", "Capitão", "Hibana", "Jackal", "Ying", "Zofia", "Dokkaebi", "Lion", "Finka", "Maverick", "Nomad", "Gridlock", "Nøkk", "Amaru", "Kali", "Iana", "Ace", "Zero", "Flores", "Osa" };
        public static string[] GetDefenders = new string[] { "Recruit", "Smoke", "Mute", "Castle", "Pulse", "Doc", "Rook", "Kapkan", "Tachanka", "Jäger", "Bandit", "Frost", "Valkyrie", "Caveira", "Echo", "Mira", "Lesion", "Ela", "Vigil", "Alibi", "Maestro", "Clash", "Kaid", "Mozzie", "Warden", "Goyo", "Wamai", "Oryx", "Melusi", "Aruni", "Thunderbird", "Thorn" };
        #endregion **Operator List**
    }
}
