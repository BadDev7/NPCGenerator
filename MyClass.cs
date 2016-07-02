//Written by BadDev7 : BadDev7@gmail.com
//02JUL16
using System;

//The purpose of this class is to define every property that I want a person to dsiplay, and hopefully after I am done
// with this I can make a generator that fills in each property to randomly gen NPCs..

namespace PersonClass
{
	public class Person
	{
		public string FirstName; //So hopefully any objects made from this class will start with placeholder values and reduce any errors... maybe...
		public string LastName;
		public string Gender;
		public string Race;
		public string Home;
		public string Work;
		public string CurrentLocation;
		public int Crush;
		public int Likes;
		public int Dislikes;
		public string Alignment;
		public string Diety;
		public string Homeland;
			
		// Body Properties

		public int Height;
		public int Weight;
		public string BodyType;
		public string EyeColor;
		public string IrisType;
		public string SkinType;
		public string SkinColor;
		public string HairStyle;
		public string HairLength; //Making this a string because I don't want to deal with a number for hair length. 
		//Figure it will sound better in a description. Subject to Change(SoC)
		public string HairColor;
		public string HairHighlights;
		public string FacialHairColor;
		public string FacialHairStyle;
		public string PubicHairColor;
		public string PubicHairStyle;
		public string FingerNailPolish;
		public string ToeNailPolish;
		public string BreastSize;
		public string BreastType; //Pillow, perky, Fake, Droopy, Flat... probably gonna be a function of size/implants
		public int BreastImplantSize;
		public string AreolaType; //normal, flat, puffy, inverted
		public int AreolaSize; 
		public string NippleType; //this will probably be for very not vanilla stuff like dicknips, cuntnips etc....
		public int NippleSize;
		public string StomachDescriptor;
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

		// Piercings

		//All strings to describe the jewelry
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

		//Tattoos

		//Same thing with strings
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

		//Stats

		//So this is probably gonna be the section with the most changes, since I am unsure what kind of game I am making

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


		//Skills
		//Well Ive made it this far down the list I made and I am not happy with the current skills/stats stuff... I may just use *cough*Pathfinder*cough* rules for this....but I will probably have to OGL it
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
		public int Age;
		public int VaginalSexCount;
		public int AnalSexCount;
		public int OralSexCount;
		public int Money;
		public int FightCount;
		public int DaysSinceLastCum;
		public int DaysSinceAnusStretched;
		public int DaysSinceVaginaStretched;

		//Equipment... gonna leave this undone, i think i want gear to be in classes so they are objects not properties



	}


}

/* public string FirstName { get; set; } = "PlaceHolderFirstName"; //So hopefully any objects made from this class will start with placeholder values and reduce any errors... maybe...
public string LastName { get; set; } = "PlaceHolderLastName";
public string Gender { get; set; } = "Mayonnaise";
public string Race;

// Body Properties

public int Height { get; set; } = 72;
public int Weight { get; set; } = 180;
public string BodyType { get; set; } = "Athletic";
public string SkinType;
public string SkinColor { get; set; } = "Pale";
public string HairStyle { get; set; } = "Mohawk";
public string HairLength { get; set; } = "Shoulder length"; //Making this a string because I don't want to deal with a number for hair length. 
//Figure it will sound better in a description. Subject to Change(SoC)
public string HairColor {get; set; } = "Brown";
public string HairHighlights { get; set; } = "Neon purple";
public string FacialHairColor { get; set; } = "Brown";
public string FacialHairStyle { get; set; } = "Clean Shaved";
public string PubicHairColor { get; set; }  = "Brown";
public string PubicHairStyle { get; set; }  = "Waxed";
public string FingerNailPolish { get; set; }  = "None";
public string ToeNailPolish { get; set; }  = "None";
public string BreastSize { get; set; }  = "B Cups";
public string BreastType { get; set; }  = "Perky"; //Pillow, perky, Fake, Droopy, Flat... probably gonna be a function of size/implants
public int BreastImplantSize {get; set; } = 0;
public string AreolaType { get; set; }  = "Normal"; //normal, flat, puffy, inverted
public int AreolaSize; 
public string NippleType { get; set; }  = "Normal"; //this will probably be for very not vanilla stuff like dicknips, cuntnips etc....
public int NippleSize { get; set; }  = 0.5;
public string StomachDescriptor { get; set; }  = "Toned";
public string AssSize { get; set; }  = "Shapely";
public string AssType { get; set; }  = "Firm";
public string VaginaType;
public bool Virgin;
public bool AnalVirgin;
public string AnusDescriptor { get; set; }  = "Bleached"; //This will either be for bleaching or transformation.... guys this is literally the first thing i have written for this project...
public string PenisType; 
public bool Circumcised; //this may be changed to a string to describe heads better (flared etc)
public int PenisLength { get; set; }  = 7;
public int PenisWidth.5;
public string BallSize { get; set; } = "Hefty";

// Piercings

//All strings to describe the jewelry
public string EarlobeLeft;
public string EarlobeRight;
public string UpperEarLeft;
public string UpperEarRight;
public string Tongue;
public string Lips;
public string EyebrowLeft;
public string EyebrowRight;
public string BeneathEyeLeft;
public string BeneathEyeRight;
public string Nose;
public string Septum;
public string RightNipple;
public string LeftNipple;
public string Clit;
public string PenisHead;
public string PenisShaft;
public string Ballsack;
public string Perineum;
public string Labia;
public string Anus;

//Tattoos

//Same thing with strings
public string Facial;
public string Back;
public string Chest;
public string Stomach;
public string RightSleeve; //Have both sleeves and arms so somewhere in the creator I will need a logic check for this.
public string LeftSleeve;
public string RightShoulder;
public string LeftShoulder;
public string RightArm;
public string LeftArm;
public string RightHand;
public string LeftHand;
public string Butt;
public string Anus;
public string Pelvic;
public string Penis;
public string RightLeg;
public string LeftLeg;
public string RightFoot;
public string LeftFoot;

//Personality

//So this is probably gonna be the section with the most changes, since I am unsure what kind of game I am making
public string Home;
public string Work;
public string CurrentLocation;
public int MaxHealth0;
public int CurrentHealth0;
public int MaxLust0;
public int CurrentLust0;
public int MaxStamina0;
public int CurrentStamina0;
public int Strength;
public int Dexterity;
public int Constitution;
public int Intelligence;
public int Willpower;
public int Charisma;
public int Alignment;
public int Crush;
public int Likes;
public int Dislikes;
*/