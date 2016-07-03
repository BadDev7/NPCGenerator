using System;

namespace PersonClass
{
	public class Person
	{
		
			public string FirstName; //So hopefully any objects made from this class will start with placeholder values and reduce any errors... maybe...
			public string LastName;
			public string Gender;
			public string Race;
			public int Age;
			public string Home; //
			public string Work; //
			public string CurrentLocation; //
			public int Crush;//
			public int Likes;//
			public int Dislikes;//
			public string Alignment;
			public string Diety;
			public string Homeland;
		


			public string EyeColor;
			public string IrisType;
			public string HairStyle;
			public string HairLength; //Making this a string because I don't want to deal with a number for hair length. 
			//Figure it will sound better in a description. Subject to Change(SoC)
			public string HairColor;
			public string HairHighlights;
			public string FacialHairColor;
			public string FacialHairStyle;
		


			public int Height;
			public int Weight;
			public string BodyType;
			public string SkinType;
			public string SkinColor;
			public string FingerNailPolish;
			public string ToeNailPolish;
			public string BreastSize;
			public string BreastType;
			public int BreastImplantSize;
			public string AreolaType; //normal, flat, puffy, inverted
			public int AreolaSize; 
			public string NippleType; //this will probably be for very not vanilla stuff like dicknips, cuntnips etc....
			public int NippleSize;
			public string StomachDescriptor;


			public string PubicHairColor;
			public string PubicHairStyle;
			public string AssSize;
			public string AssType;
			public string VaginaType;
			public bool Virgin;
			public bool AnalVirgin;
			public string AnusDescripto; //This will either be for bleaching or transformation.... guys this is literally the first thing i have written for this project...
			public string PenisType; 
			public bool Circumcised; //this may be changed to a string to describe heads better (flared etc)
			public int PenisLength;
			public int PenisWidth;
			public string BallSize;

			public string EarlobeLeftPiercing;
			public string EarlobeRightPiercing;
			public string UpperEarLeftPiercing;
			public string UpperEarRightPiercing;
			public string TonguePiercing;
			public string LipsPiercing;
			public string EyebrowLeftPiercing;
			public string EyebrowRightPiercing;
			public string BeneathEyeLeftPiercing;
			public string BeneathEyeRightPiercing;
			public string NosePiercing;
			public string SeptumPiercing;
			public string RightNipplePiercing;
			public string LeftNipplePiercing;
			public string ClitPiercing;
			public string PenisHeadPiercing;
			public string PenisShaftPiercing;
			public string BallsackPiercing;
			public string PerineumPiercing;
			public string LabiaPiercing;
			public string AnusPiercing;

			public string FacialTattoo;
			public string BackTattoo;
			public string ChestTattoo;
			public string StomachTattoo;
			public string RightSleeveTattoo; //Have both sleeves and arms so somewhere in the creator I will need a logic check for this.
			public string LeftSleeveTattoo;
			public string RightShoulderTattoo;
			public string LeftShoulderTattoo;
			public string RightArmTattoo;
			public string LeftArmTattoo;
			public string RightHandTattoo;
			public string LeftHandTattoo;
			public string ButtTattoo;
			public string AnusPiercingTattoo;
			public string PelvicTattoo;
			public string PenisTattoo;
			public string RightLegTattoo;
			public string LeftLegTattoo;
			public string RightFootTattoo;
			public string LeftFootTattoo;

			public int MaxHealth;
			public int CurrentHealth;
			public int MaxLust;
			public int CurrentLust;
			public int Strength;
			public int Dexterity;
			public int Constitution;
			public int Intelligence;
			public int Willpower;
			public int Charisma;
			public int TempStrengthBonus;
			public int TempDexterityBonus;
			public int TempConstitutionBonus;
			public int TempIntelligenceBonus;
			public int TempWillpowerBonus;
			public int TempCharismaBonus;
			public int StrengthDamage;
			public int DexterityDamage;
			public int ConstitutionDamage;
			public int IntelligenceDamage;
			public int WillpowerDamage;
			public int CharismaDamage;
			public int StrengthDrain;
			public int DexterityDrain;
			public int ConstitutionDrain;
			public int IntelligenceDrain;
			public int WillpowerDrain;
			public int CharismaDrain;
			//holy fuck pathfinder has alot of variables for 6 stats...
			public int FortitudeBase;
			public int ReflexBase;
			public int WillBase;
			public int InitiativeMiscModifier;

			public int Acrobatics;
			public int Appraise;
			public int Bluff;
			public int Climb;
			public int CraftAlchemy;
			public int CraftArmor;
			public int CraftWeapon;
			public int CraftTrap;
			public int CraftMagic;
			public int Diplomacy;
			public int DisableDevice;
			public int Disguise;
			public int EscapeArtist;
			public int Fly;
			public int HandleAnimal;
			public int Heal;
			public int Intimidate;
			public int KnowledgeArcana;
			public int KnowledgeEngineering;
			public int KnowledgeGeography;
			public int KnowledgeLocal;
			public int KnowledgeNature;
			public int Linguistics;
			public int Perception;
			public int PerformVocal;
			public int PerformFlute;
			public int PerformLute;
			public int Ride;
			public int SenseMotive;
			public int SleightOfHand;
			public int Spellcraft;
			public int Stealth;
			public int Survival;
			public int Swim;
			public int UseMagicDevice;
			//So some of these will probably never be implemented, and Ive taken out some skills... I hope that doesnt come back to bite me
			public int MeleeProficiency;
			public int RangedProficiency;
			public int VaginalSex;
			public int AnalSex;
			public int OralSex;
			public int Seduction;

			//Counts
			public int VaginalSexCount; //so virginity for rnd characters will be random but the counts will start at 0, so it will only show encounters since game start
			public int AnalSexCount;
			public int OralSexCount;
			public int Money;
			public int FightCount;
			public int DaysSinceLastCum;
			public int DaysSinceAnusStretched;
			public int DaysSinceVaginaStretched;
		public Person(){} //blank constructor for manually added persons.... god I hope I dont have to use this.. probably only or char creation. cause the amount of variables in this class is stupid
		public Person (string _FirstName, string _LastName, int _age) //Im kinda embarressed to admit how long I worked on this before I realized I could do logic in the constructor...
		{
			FirstName = _FirstName; //so when the constructor is called it will need to be given a first and last name and an age. For this iteration of the class that is
			// all I want to pass. Hopefully this lets me tie in a rnd name gen.
			LastName = _LastName;
			Age = _age;

			Random rnd = new Random (); //So the idea is each person created gets a rnd seed, which will be used to generate the values that decide properties
			{
				int _gender = rnd.Next (1, 9); //m/f have equal chance, h has a 1 in 9 chance.
				if (_gender <= 4) {
					Gender = "Male";
				} else if (_gender <= 8) {
					Gender = "Female";
				} else {
					Gender = "Hermaphrodite";
				}
			}// this bracket should ensure that gender goes away after it is used, just a memory precaution
			{
				int _race = rnd.Next (1, 7);
				if (_race == 1) {
					Race = "Dwarf";
				}
				else if
					(_race == 2) {
					Race = "Elf";
				}
				else if
					(_race == 3) {
					Race = "Gnome";
				}
				else if
					(_race == 4) {
					Race = "Half Elf";
				}
				else if
					(_race == 5) {
					Race = "Half Orc";
				}
				else if
					(_race == 6) {
					Race = "Halfling";
				}
				else if
					(_race == 7) {
					Race = "Human";
				}
			}
			{
				//alignment
				int _alignment = rnd.Next(1,9);
				switch (_alignment) {
				case 1:
					Alignment = "Lawful Good";
					break;
				case 2:
					Alignment = "Neutral Good";
					break;
				case 3:
					Alignment = "Chaotic Good";
					break;
				case 4:
					Alignment = "Lawful Neutral";
					break;
				case 5:
					Alignment = "True Neutral";
					break;
				case 6:
					Alignment = "Chaotic Neutral";
					break;
				case 7:
					Alignment = "Lawful Evil";
					break;
				case 8:
					Alignment = "Neutral Evil";
					break;
				case 9:
					Alignment = "Chaotic Evil";
					break;
				}
			}

			{
				//diety, hmm i dont really want an even spread accross the diety list, so I am making the rnd a multiple of the dieties and assigning more values to
				// good/common dieties
				//edit no ive decided to use two rnd variables to cut down on the logic
				//edit2 so this diety list doesnt let me sort by alignment so I am going to use a different/limited pantheon, looks like base asgard pantheon right now
				// took list from the panakos gods list : http://www.d20pfsrd.com/extras/community-creations/panakos-lab/world-overview/deities
				int _diety1 = rnd.Next(1,18); //number to pick alignment of god, 18 so i can give higher chance to good/common
				int _diety2 = rnd.Next(1,5);
				if (_diety1 == 1 ||_diety1 == 2 ||_diety1 == 3 ||_diety1 == 18) { //CG
					switch (_diety2){
					case 1:
						Diety = "Idun";
						break;
					case 2:
						Diety = "Magni";
						break;
					case 3:
						Diety = "Modi";
						break;
					case 4:
						Diety = "Sif";
						break;
					case 5:
						Diety = "Thor";
						break;
					}
					}
					
				if (_diety1 == 4 ||_diety1 == 5 ||_diety1 == 6) { //NG
					switch (_diety2){
					case 1:
						Diety = "Odin";
						break;
					case 2:
						Diety = "Balder";
						break;
					case 3:
						Diety = "Bragi";
						break;
					case 4:
						Diety = "Frey";
						break;
					case 5:
						Diety = "Freya";
						break;
					}
				}
				if (_diety1 == 7 ||_diety1 == 8 ||_diety1 == 17) { //LG
					switch (_diety2){
					case 1:
						Diety = "Forseti";
						break;
					case 2:
						Diety = "Heimdall";
						break;
					case 3:
						Diety = "Tyr";
						break;
					case 4:
						Diety = "Tyr";
						break;
					case 5:
						Diety = "Heimdall";
						break;
					}
				}
				if (_diety1 == 9) { //CN
					switch (_diety2){
					case 1:
						Diety = "Aegir";
						break;
					case 2:
						Diety = "Aegir";
						break;
					case 3:
						Diety = "Uller";
						break;
					case 4:
						Diety = "Uller";
						break;
					case 5:
						Diety = "Uller";
						break;
					}
				}
				if (_diety1 == 10 ||_diety1 == 15) { //TN
					switch (_diety2){
					case 1:
						Diety = "Myketa";
						break;
					case 2:
						Diety = "Myketa";
						break;
					case 3:
						Diety = "Myketa";
						break;
					case 4:
						Diety = "Myketa";
						break;
					case 5:
						Diety = "Myketa";
						break;
					}
				}
				if (_diety1 == 11) { //LN
					switch (_diety2){
					case 1:
						Diety = "Frigga";
						break;
					case 2:
						Diety = "Frigga";
						break;
					case 3:
						Diety = "Frigga";
						break;
					case 4:
						Diety = "Frigga";
						break;
					case 5:
						Diety = "Frigga";
						break;
					}
				}
				if (_diety1 == 12) { //CE
					switch (_diety2){
					case 1:
						Diety = "Loki";
						break;
					case 2:
						Diety = "Loki";
						break;
					case 3:
						Diety = "Loki";
						break;
					case 4:
						Diety = "Loki";
						break;
					case 5:
						Diety = "Loki";
						break;
					}
				}
				if (_diety1 == 13 ||_diety1 == 16) { //NE
					switch (_diety2){
					case 1:
						Diety = "Hel";
						break;
					case 2:
						Diety = "Hel";
						break;
					case 3:
						Diety = "Hel";
						break;
					case 4:
						Diety = "Vydar";
						break;
					case 5:
						Diety = "Vydar";
						break;
					}
				}
				if (_diety1 == 14) { //LE
					Diety = "Hecate";
				}
			}
			{ //homeland, by race
				int _homeland = rnd.Next(1,100);
				switch (Race){
				case "Dwarf":
					if (_homeland <= 40) {
						Homeland = "Mountains";
					} else if (_homeland <= 80) {
						Homeland = "Underground";
					} else if (_homeland <= 87) {
						Homeland = "Human Town";
					} else if (_homeland <= 95) {
						Homeland = "Elven Metropolis";
					} else {
						Homeland = "Tundra";
					}
					break;
				case "Elf":
					if (_homeland <= 60) {
						Homeland = "Forest";
					} else if (_homeland <= 80) {
						Homeland = "Human Metropolis";
					} else if (_homeland <= 95) {
						Homeland = "Human Village";
					} else {
						Homeland = "Sea";
					}
					break;
				case "Gnome":
					if (_homeland <= 30) {
						Homeland = "Forest";
					} else if (_homeland <= 65) {
						Homeland = "Human Village";
					} else if (_homeland <= 95) {
						Homeland = "Elven City";
					} else {
						Homeland = "Desert";
					}
					break;
				case "Half Elf":
					if (_homeland <= 25) {
						Homeland = "Sea";
					} else if (_homeland <= 75) {
						Homeland = "Frontier";
					} else if (_homeland <= 95) {
						Homeland = "Forest";
					} else {
						Homeland = "Plains";
					}
					break;
				case "Half Orc":
					if (_homeland <= 25) {
						Homeland = "Subterranean";
					} else if (_homeland <= 60) {
						Homeland = "Orc Settlement";
					} else if (_homeland <= 75) {
						Homeland = "Human Village";
					} else if (_homeland <= 90) {
						Homeland = "Nomad";
					} else {
						Homeland = "Sea";
					}
					break;

				case "Halfling":
					if (_homeland <= 50) {
						Homeland = "Halfling Settlement";
					} else if (_homeland <= 80) {
						Homeland = "Human Town";
					} else if (_homeland <= 95) {
						Homeland = "Nomad";
					} else {
						Homeland = "Tundra";
					}
					break;
				case "Human":
					if (_homeland <= 50) {
						Homeland = "Human Town";
					} else if (_homeland <= 85) {
						Homeland = "Human City";
					} else if (_homeland <= 95) {
						Homeland = "Frontier";
					} else {
						Homeland = "Human Metropolis";
					}
					break;
				}
			}
			{//eye color and iris type, (not doing funky colors for gen'd npcs, and type will be normal) blue, green, brown, hazel, silver, amber
				int _eyecolor = rnd.Next(1,6);
				switch (_eyecolor) {
				case 1:
					EyeColor = "Blue";
					break;
				case 2:
					EyeColor = "Green";
					break;
				case 3:
					EyeColor = "Brown";
					break;
				case 4:
					EyeColor = "Hazel";
					break;
				case 5:
					EyeColor = "Silver";
					break;
				case 6:
					EyeColor = "Amber";
					break;
				}
				IrisType = "Normal";
			}
			{ //hair style/length by gender, f/h are the same
				int _hairstyle = rnd.Next(1,6);   //bob, ponytail, pigtails, bun, loose, shaved side (might need to change these to adjectives)
				switch (Gender) {
				case "Female":
					switch (_hairstyle) {
					case 1:
						HairStyle = "Bob";
						HairLength = "Short";
						break;
					case 2:
						HairStyle = "Ponytail";
						HairLength = "Shoulder length";
						break;
					case 3:
						HairStyle = "Pigtails";
						HairLength = "Shoulder length";
						break;
					case 4:
						HairStyle = "Bun";
						HairLength = "Short";
						break;
					case 5:
						HairStyle = "Loose";
						HairLength = "Shoulder length";
						break;
					case 6:
						HairStyle = "Shaved side";
						HairLength = "Short";
						break;
					}
					break;
				case "Hermaphrodite":
					switch (_hairstyle) {
					case 1:
						HairStyle = "Bob";
						HairLength = "Short";
						break;
					case 2:
						HairStyle = "Ponytail";
						HairLength = "Shoulder length";
						break;
					case 3:
						HairStyle = "Pigtails";
						HairLength = "Shoulder length";
						break;
					case 4:
						HairStyle = "Bun";
						HairLength = "Short";
						break;
					case 5:
						HairStyle = "Loose";
						HairLength = "Shoulder length";
						break;
					case 6:
						HairStyle = "Shaved side";
						HairLength = "Short";
						break;
					}
					break;

				case "Male":
					switch (_hairstyle) {
					case 1:
						HairStyle = "Fade";
						HairLength = "Short";
						break;
					case 2:
						HairStyle = "Crew cut";
						HairLength = "Short";
						break;
					case 3:
						HairStyle = "Man Bun";
						HairLength = "Shoulder length";
						break;
					case 4:
						HairStyle = "Loose";
						HairLength = "Shoulder length";
						break;
					case 5:
						HairStyle = "Undercut";
						HairLength = "Short";
						break;
					case 6:
						HairStyle = "Mohawk";
						HairLength = "Medium";
						break;
					}
					break;

				}

			}
			{// hair color and highlights
				int _haircolor = rnd.Next(1,8); //brown, black, blonde, red, purple, green, pink, blue
				switch(_haircolor){
				case 1:
					HairColor = "Brown";
					break;
				case 2:
					HairColor = "Black";
					break;
				case 3:
					HairColor = "Blonde";
					break;
				case 4:
					HairColor = "Red";
					break;
				case 5:
					HairColor = "Purple";
					break;
				case 6:
					HairColor = "Green";
					break;
				case 7:
					HairColor = "Pink";
					break;
				case 8:
					HairColor = "Blue";
					break;
				}
				int _highlight = rnd.Next (1, 8);
				switch(_highlight){
				case 1:
					HairHighlights = "Brown";
					break;
				case 2:
					HairHighlights = "Black";
					break;
				case 3:
					HairHighlights = "Blonde";
					break;
				case 4:
					HairHighlights = "Red";
					break;
				case 5:
					HairHighlights = "Purple";
					break;
				case 6:
					HairHighlights = "Green";
					break;
				case 7:
					HairHighlights = "Pink";
					break;
				case 8:
					HairHighlights = "Blue";
					break;
				}
				if (HairColor == HairHighlights) { //logic to get rid of like colored highlights
					HairHighlights = "None";
				}
			}
			{
				//Facial hair and color
				if(Gender == "Female" || Gender == "Hermaphrodite"){
					FacialHairStyle = "None";
					FacialHairColor = "None"; //may need to set color to hair color in the future if there are transformations
				}
				else{
					int _FacialHairColor = rnd.Next(1,8);
					int _FacialHairStyle = rnd.Next(1,7); //clean shaven, stubble, goatee, soul patch, Super Trooper, stache and beard, full beard
					switch(_FacialHairColor){
					case 1:
						FacialHairColor = "Brown";
						break;
					case 2:
						FacialHairColor = "Black";
						break;
					case 3:
						FacialHairColor = "Blonde";
						break;
					case 4:
						FacialHairColor = "Red";
						break;
					case 5:
						FacialHairColor = "Purple";
						break;
					case 6:
						FacialHairColor = "Green";
						break;
					case 7:
						FacialHairColor = "Pink";
						break;
					case 8:
						FacialHairColor = "Blue";
						break;
					}
					switch(_FacialHairStyle){
					case 1:
						FacialHairStyle = "Clean shaven";
						break;
					case 2:
						FacialHairStyle = "Light stubble";
						break;
					case 3:
						FacialHairStyle = "Goatee";
						break;
					case 4:
						FacialHairStyle = "Soul patch";
						break;
					case 5:
						FacialHairStyle = "Sherrif mustache";
						break;
					case 6:
						FacialHairStyle = "mustache and beard";
						break;
					case 7:
						FacialHairStyle = "Full beard";
						break;
					}
				}
			}
			{ //height and weight,,,, this is gonna be fun /s, doing based off pf random hw table, inches and pounds
				switch(Race){
				case "Human":
					if (Gender == "Male") {
						Height = rnd.Next(58, 78);
						Weight = 120 + rnd.Next (2, 20) * 5; //so min 130 max 220
					} else {
						Height = rnd.Next(53, 73);
						Weight = 85 + rnd.Next (2, 20) * 5; 
					}
					break;
				case "Dwarf":
					if (Gender == "Male") {
						Height = rnd.Next(45, 53);
						Weight = 150 + rnd.Next (2, 8) * 7;
					} else {
						Height = rnd.Next(43, 51);
						Weight = 120 + rnd.Next (2, 8) * 7;
					}
					break;
				case "Elf":
					if (Gender == "Male") {
						Height = rnd.Next(64, 80);
						Weight = 100 + rnd.Next (2, 16) * 3;
					} else {
						Height = rnd.Next(64, 76);
						Weight = 90 + rnd.Next (2, 12) * 3;
					}
					break;
				case "Gnome":
					if (Gender == "Male") {
						Height = rnd.Next(36, 44);
						Weight = 35 + rnd.Next (2, 8) * 1;
					} else {
						Height = rnd.Next(34, 42);
						Weight = 30 + rnd.Next (2, 8) * 1;
					}
					break;
				case "Half Elf":
					if (Gender == "Male") {
						Height = rnd.Next(62, 78);
						Weight = 110 + rnd.Next (2, 16) * 5;
					} else {
						Height = rnd.Next(60, 76);
						Weight = 90 + rnd.Next (2, 16) * 5;
					}
					break;
				case "Half Orc":
					if (Gender == "Male") {
						Height = rnd.Next(58, 82);
						Weight = 150 + rnd.Next (2, 24) * 7;
					} else {
						Height = rnd.Next(53, 77);
						Weight = 110 + rnd.Next (2, 24) * 7;
					}
					break;
				case "Halfling":
					if (Gender == "Male") {
						Height = rnd.Next(32, 40);
						Weight = 30 + rnd.Next (2, 8) * 1;
					} else {
						Height = rnd.Next(30, 53);
						Weight = 25 + rnd.Next (2, 8) * 1;
					}
					break;
				}
				//body type, some function of height weight and max... literally sitting here trying to think of a single way I can do it for all races
				// k for example the median height and weight for a halfling male is 38 inches, 34 pounds, which gives us a value of 0.895
				// so that will be the average type body? anything 90% of 0.895 will be fit, anything 80 of 0.895 will be thin, 70% malnourished. similarily
				// 110% is chubby, 120 is fat 130 is obese... simplified I know but there are no built in rules for body type in pf and i hesitate to make this a function
				// of height, weight, strength and dexterity since this should just be an aesthetic.. shit just realized that doesnt take height into account...

				//k height minus median height times multiplied by the race weight multiplier (last digit on weight calcs above) added to base weight gives that height's median weight... i think
				// then I use the percentages to get the body type...

				int _bodycalc = 0;
				switch(Race){
				case "Human":
					if (Gender == "Male") {
						_bodycalc = 120 + ((Height - 58) * 5);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 85 + ((Height - 53) * 5);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Dwarf":
					if (Gender == "Male") {
						_bodycalc = 150 + ((Height - 45) * 7);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 120 + ((Height - 43) * 7);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Elf":
					if (Gender == "Male") {
						_bodycalc = 100 + ((Height - 64) * 3);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 90 + ((Height - 64) * 3);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Gnome":
					if (Gender == "Male") {
						_bodycalc = 35 + ((Height - 36) * 1);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 30 + ((Height - 34) * 1);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Half Elf":
					if (Gender == "Male") {
						_bodycalc = 110 + ((Height - 62) * 5);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 90 + ((Height - 60) * 5);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Half Orc":
					if (Gender == "Male") {
						_bodycalc = 150 + ((Height - 58) * 7);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 110 + ((Height - 53) * 7);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				case "Halfling":
					if (Gender == "Male") {
						_bodycalc = 30 + ((Height - 32) * 1);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					} else {
						_bodycalc = 25 + ((Height - 30) * 1);
						if (Weight / _bodycalc <= 0.70) {
							BodyType = "Malnourished";
						}
						else if (Weight / _bodycalc <= 0.80) {
							BodyType = "Thin";
						}
						else if (Weight / _bodycalc <= 0.90) {
							BodyType = "Fit";
						}
						else if (Weight / _bodycalc <= 1.10) {
							BodyType = "Average";
						}
						else if (Weight / _bodycalc <= 1.20) {
							BodyType = "Chubby";
						}
						else if (Weight / _bodycalc <= 1.30) {
							BodyType = "Fat";
						}
						else {
							BodyType = "Obese";
						}
					}
					break;
				}


			}
			{//skin type and color
				SkinType = "Normal";
				int _SkinColor = rnd.Next(1, 7); //pale, light, rosy, tan. light brown, bronze, chocolate
				switch(_SkinColor){
				case 1:
					SkinColor = "Pale";
					break;
				case 2:
					SkinColor = "Light";
					break;
				case 3:
					SkinColor = "Rosy";
					break;
				case 4:
					SkinColor = "Tan";
					break;
				case 5:
					SkinColor = "Light brown";
					break;
				case 6:
					SkinColor = "Bronze";
					break;
				case 7:
					SkinColor = "Chocolate";
					break;
				}
			}
			{
				
			}


				
			





		}
	
	}


	}


