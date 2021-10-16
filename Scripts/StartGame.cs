using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class StartGame : MonoBehaviour {



    // global variables for trigger detection
    public static bool paused = false;
    public static bool oegerCollided = false;
    public static bool crystalsCollided = false;
    public static bool fleetCollided = false;
    public static bool locationCollided = false;
    public static bool location1Collided = false;
    public static bool location2Collided = false;
    public static bool location3Collided = false;
    public static bool location4Collided = false;
    public static bool location5Collided = false;
    public static bool location6Collided = false;

	// UI ELEMENTS 
	// =================================
	// screens
	public GameObject gameHomeScreen;
	public GameObject startGameScreen;
	public GameObject startNewGameScreen;
	public GameObject termsScreen;
	public GameObject loadGameScreen;
	public GameObject forgotPasswordScreen;
	public GameObject highscoresScreen;
	public GameObject backstoryScreen;
	public GameObject gameplayScreen;
	public GameObject FAQscreen;
	public GameObject introScreen;
	public GameObject chooseCompanyScreen;
	public GameObject chooseLocationScreen;
	public GameObject levelAimScreen;
	public GameObject customiseDashboardScreen;
	public GameObject endGameStartFeedbackScreen;
	public GameObject levelSummaryScreen;

    public GameObject demographicsScreen;
    public GameObject factorFiveScreen;
    public GameObject bartleScreen;
    public GameObject knowledgeTestScreen;
    public GameObject feedbackScreen;
    public GameObject endDemoScreen;

    public GameObject confirmQuitScreen;
    public GameObject quitPleaseGiveFeedbackScreen;

    public GameObject newHighscoreScreen;

    public GameObject gameTipScreen;

    public GameObject toolTipGamefeed;
    public GameObject toolTipCompany;
    public GameObject toolTipColony;
    public GameObject toolTipStatus;
    public GameObject toolTipDashboard;

	// back buttons
	public UnityEngine.UI.Button backButtonStartNewGame;
	public UnityEngine.UI.Button backButtonTerms;
	public UnityEngine.UI.Button backButtonLoadGame;
	public UnityEngine.UI.Button backButtonForgotPassword;
	public UnityEngine.UI.Button backButtonHighscores;
	public UnityEngine.UI.Button backButtonBackstory;
	public UnityEngine.UI.Button backButtonGameplay;
	public UnityEngine.UI.Button backButtonFAQ;

	// buttons to load screens
	public UnityEngine.UI.Button playNowButton;
	public UnityEngine.UI.Button termsAndConditionsButton;
	public UnityEngine.UI.Button startNewGameButton;
	public UnityEngine.UI.Button loadGameButton;
	public UnityEngine.UI.Button highscoresButton;
	public UnityEngine.UI.Button backstoryButton;
	public UnityEngine.UI.Button gameplayButton;
	public UnityEngine.UI.Button FAQButton;
	public UnityEngine.UI.Button createNewProfileButton;
	public UnityEngine.UI.Button loadButton;
	public UnityEngine.UI.Button forgotPasswordButton;
	public UnityEngine.UI.Button submitSecurityAnswerButton;
	public UnityEngine.UI.Button okBackToLoadScreenButton;
	public UnityEngine.UI.Button startGameAfterIntroButton;
	public UnityEngine.UI.Button selectCompanyButton;
	public UnityEngine.UI.Button selectLocationButton;
	public UnityEngine.UI.Button startLevelButton;

	public UnityEngine.UI.Button dashboardSettingsButton;
	public UnityEngine.UI.Button applyDashboardChangesButton;

	public UnityEngine.UI.Button levelSummaryContinueButton;
    public UnityEngine.UI.Button continueToFeedbackButton;
	public UnityEngine.UI.Button endDemoQuitButton;

    public UnityEngine.UI.Button submitDemographicsButton;
    public UnityEngine.UI.Button submitFactorFiveButton;
    public UnityEngine.UI.Button submitBartleButton;
    public UnityEngine.UI.Button submitKnowledgeButton;
    public UnityEngine.UI.Button submitFeedbackButton;
    
    public UnityEngine.UI.Button quitGameButton;
    public UnityEngine.UI.Button confirmQuitButton;
    public UnityEngine.UI.Button confirmNoQuitButton;
    public UnityEngine.UI.Button quitFeedbackHelpButton;
    public UnityEngine.UI.Button quitFeedbackNoButton;

    public UnityEngine.UI.Button continueFromNewHighscoreButton;

    public UnityEngine.UI.Button gameTipButton;

    public UnityEngine.UI.Button toolTipGamefeedButton;
    public UnityEngine.UI.Button toolTipCompanyButton;
    public UnityEngine.UI.Button toolTipColonyButton;
    public UnityEngine.UI.Button toolTipStatusButton;
    public UnityEngine.UI.Button toolTipDashboardButton;

    // tab selection buttons
    public UnityEngine.UI.Button tabsHighscoresEconomyButton;
	public UnityEngine.UI.Button tabsHighscoresProgressionButton;
	public UnityEngine.UI.Button tabsHighscoresSkillsButton;
	public UnityEngine.UI.Button tabsHighscoresProfitsButton;

	public UnityEngine.UI.Button tabsGameplayTheBasicsButton;
	public UnityEngine.UI.Button tabsGameplayStartingBusinessButton;
	public UnityEngine.UI.Button tabsGameplayTheEconomyButton;
	public UnityEngine.UI.Button tabsGameplayWinningButton;

	public UnityEngine.UI.Button tabsFAQGeneralButton;
	public UnityEngine.UI.Button tabsFAQGameplayButton;
	public UnityEngine.UI.Button tabsFAQTechnicalButton;
	public UnityEngine.UI.Button tabsFAQCreatorsButton;
	public UnityEngine.UI.Button tabsFAQMoreButton;
	public UnityEngine.UI.Button faqSubmitQuestionButton;

	public UnityEngine.UI.Button nextIntroPieceButton;
	public UnityEngine.UI.Button previousIntroPieceButton;

	public UnityEngine.UI.Button nextCompanyButton;
	public UnityEngine.UI.Button previousCompanyButton;

	public UnityEngine.UI.Button nextLocationButton;
	public UnityEngine.UI.Button previousLocationButton;

    // user input fields
    public UnityEngine.UI.InputField newUsernameInput;
	public UnityEngine.UI.InputField newPasswordInput;
	public UnityEngine.UI.InputField newSecurityAnswerInput;
	public UnityEngine.UI.InputField loadUsernameInput;
	public UnityEngine.UI.InputField loadPasswordInput;
	public UnityEngine.UI.InputField forgotUsernameInput;
	public UnityEngine.UI.InputField forgotSecurityAnswerInput;
	public UnityEngine.UI.InputField faqNewQuestionInput;

	// changeable text items
	public UnityEngine.UI.Text usernameAlreadyExistsText;
	public UnityEngine.UI.Text wrongUsernamePasswordText;
    public UnityEngine.UI.Text notAvailableInDemoText;
	public UnityEngine.UI.Text yourPasswordText;
	public UnityEngine.UI.Text incorrectForgottenEntryText;
    public UnityEngine.UI.Text thanksForYourSubmissionText;

	public UnityEngine.UI.Text highscoresHeadingText;
	public UnityEngine.UI.Text highscoresEconomyRankText;
	public UnityEngine.UI.Text highscoresProgressionRankText;
	public UnityEngine.UI.Text highscoresSkillsRankText;
	public UnityEngine.UI.Text highscoresProfitsRankText;
    public UnityEngine.UI.Text highscoresEconomyPlayerText;
    public UnityEngine.UI.Text highscoresProgressionPlayerText;
    public UnityEngine.UI.Text highscoresSkillsPlayerText;
    public UnityEngine.UI.Text highscoresProfitsPlayerText;
    public UnityEngine.UI.Text highscoresEconomyScoreText;
    public UnityEngine.UI.Text highscoresProgressionScoreText;
    public UnityEngine.UI.Text highscoresSkillsScoreText;
    public UnityEngine.UI.Text highscoresProfitsScoreText;

    public UnityEngine.UI.Text gameplayHeadingText;
	public UnityEngine.UI.Text gameplayBasicsText;
	public UnityEngine.UI.Text gameplayStartingBusinessText;
	public UnityEngine.UI.Text gameplayEconomyText;
	public UnityEngine.UI.Text gameplayWinningText;

	public UnityEngine.UI.Text faqHeadingText;
	public UnityEngine.UI.Text faqGeneralText;
	public UnityEngine.UI.Text faqGameplayText;
	public UnityEngine.UI.Text faqTechnicalText;
	public UnityEngine.UI.Text faqCreatorsText;
	public UnityEngine.UI.Text faqMoreText;

	public UnityEngine.UI.Text introHeadingText;
	public UnityEngine.UI.Text introLandingText;
	public UnityEngine.UI.Text introEncounterText;
	public UnityEngine.UI.Text introColonyText;
	public UnityEngine.UI.Text introHomeText;
	public UnityEngine.UI.Text introAimText;

	public UnityEngine.UI.Text companyHeadingText;
	public UnityEngine.UI.Text companyConsumablesText;
	public UnityEngine.UI.Text companyLifestyleText;
	public UnityEngine.UI.Text companyBuildingText;
	public UnityEngine.UI.Text companyResearchText;
	public UnityEngine.UI.Text companyTechText;
	public UnityEngine.UI.Text companyCostText;
	public UnityEngine.UI.Text companyYourCurrentCashText;

	public UnityEngine.UI.Text locationHeadingText;
	public UnityEngine.UI.Text locationEasyAccessText;
	public UnityEngine.UI.Text locationEasyAccess2Text;
	public UnityEngine.UI.Text locationSecludedText;
	public UnityEngine.UI.Text locationResourcesText;
	public UnityEngine.UI.Text locationResources2Text;
	public UnityEngine.UI.Text locationCentralText;
	public UnityEngine.UI.Text locationCostText;
	public UnityEngine.UI.Text locationYourCurrentCashText;

	public UnityEngine.UI.Text levelSummaryText;

    public UnityEngine.UI.Text newHighscoreTypeText;
    public UnityEngine.UI.Text newHighscoreRankText;
    public UnityEngine.UI.Text newHighscoreScoreText;

    public UnityEngine.UI.Text demographicsNumberText;
    public UnityEngine.UI.Text factorFiveNumberText;
    public UnityEngine.UI.Text bartleNumberText;
    public UnityEngine.UI.Text knowledgeNumberText;

    public UnityEngine.UI.Text gameTipHeadingText;
    public UnityEngine.UI.Text gameTipIntroText;
    public UnityEngine.UI.Text gameTipCrystalsText;
    public UnityEngine.UI.Text gameTipFleetText;
    public UnityEngine.UI.Text gameTipCompanyText;
    public UnityEngine.UI.Text gameTipLocationIntroText;
    public UnityEngine.UI.Text gameTipLocation1Text;
    public UnityEngine.UI.Text gameTipLocation2Text;
    public UnityEngine.UI.Text gameTipLocation3Text;
    public UnityEngine.UI.Text gameTipLocation4Text;
    public UnityEngine.UI.Text gameTipLocation5Text;
    public UnityEngine.UI.Text gameTipLocationFinalText;


    // changeable image items
    public UnityEngine.UI.Image introLandingImage;
	public UnityEngine.UI.Image introEncounterImage;
	public UnityEngine.UI.Image introColonyImage;
	public UnityEngine.UI.Image introHomeImage;
	public UnityEngine.UI.Image introAimImage;

	public UnityEngine.UI.Image companyConsumablesImage;
	public UnityEngine.UI.Image companyLifestyleImage;
	public UnityEngine.UI.Image companyBuildingImageLocked;
	public UnityEngine.UI.Image companyResearchImageLocked;
	public UnityEngine.UI.Image companyTechImageLocked;

	public UnityEngine.UI.Image locationEasyAccessImage;
	public UnityEngine.UI.Image locationEasyAccess2Image;
	public UnityEngine.UI.Image locationSecludedImage;
	public UnityEngine.UI.Image locationResourcesImage;
	public UnityEngine.UI.Image locationResources2Image;
	public UnityEngine.UI.Image locationCentralImage;

	public UnityEngine.UI.Image [] taxShortTermImages;
	public UnityEngine.UI.Image [] borrowShortTermImages;
	public UnityEngine.UI.Image [] harvestShortTermImages;
	public UnityEngine.UI.Image [] taxLongTermImages;
	public UnityEngine.UI.Image [] borrowLongTermImages;
	public UnityEngine.UI.Image [] harvestLongTermImages;
	public UnityEngine.UI.Image [] taxBorrowImages;
	public UnityEngine.UI.Image [] taxHarvestImages;
	public UnityEngine.UI.Image [] borrowHarvestImages;

	// toggle fields
	public UnityEngine.UI.Toggle acceptTermsToggle;

    //  WWW fields
    WWWForm userForm;
    WWW userWeb;

    // private variables
    private string newUsername;
	private string newPassword;
	private string newSecurityAnswer;

	private string loadUsername;
	private string loadPassword;

	private int currentLever = 0;

	private string [] users;
	private string [] highscoresEconomy;
	private string [] highscoresProgression;
	private string [] highscoresSkills;
	private string [] highscoresProfits;
	private string [] highscoresEconomySaved;
	private string [] highscoresProgressionSaved;
	private string [] highscoresSkillsSaved;
	private string [] highscoresProfitsSaved;

	private string levelSummary;

	private int userID = 0;
	private int companyChoice = 0;
	private int locationChoice = 0;

    private int set; // to keep track of which set of questions user is on
    

	// GAMEPLAY ELEMENTS 
	// =================================
	// game objects
	public GameObject environment;
	public GameObject [] companyBuildings;
    public GameObject [] companyBuildingIcons;
	public GameObject gameFeed;
	public GameObject oeger;

    public GameObject astronaut;

	public GameObject companyStatusEmpty;
	public GameObject colonyStatusEmpty;
	public GameObject levelStatusEmpty;

	public GameObject slider1Empty;
	public GameObject slider2Empty;

	public Slider slider1;
	public Slider slider2;

    public GameObject skyRain;

    public GameObject oegerCharacter;
    public GameObject introIconOeger;
    public GameObject introIconCrystals;
    public GameObject introIconFleet;
    public GameObject introIconCompany;
    public GameObject introIconLocation;
    public GameObject introIconLocation1;
    public GameObject introIconLocation2;
    public GameObject introIconLocation3;
    public GameObject introIconLocation4;
    public GameObject introIconLocation5;
    public GameObject introIconLocation6;

    // particle systems
    public ParticleSystem [] buildEffects;
    public ParticleSystem [] smokeEffects;

	// company / colony variables
	public int startingCash;
	public int buildingStartValue;
	public int researchStartValue;
	public int techStartValue;

	public int consLifeStartEmployees;
	public int buildStartEmployees;
	public int researchStartEmployees;
	public int techStartEmployees;

	public int consumablesIncomeMin;
	public int consumablesIncomeMax;
	public float consumablesMargin;
	public int lifestyleIncomeMin;
	public int lifestyleIncomeMax;
	public float lifestyleMarginMin;
	public float lifestyleMarginMax;

	public int buildingIncome;
	public int buildingOut;
	public int researchIncomeMin;
	public int researchIncomeMax;
	public int researchOut;
	public int techIncomeMin;
	public int techIncomeMax;
	public int techOut;

	private int currentLevel; 
	private int currentCash;

	private int userLever1;
	private int userLever2;
	private float userValueTax;
	private float userValueLoan;
	private float userValueHarvest;

	// initialise the variables where always same upon game start 
	private int companyCrystalsIn = 0;
	private int companyCrystalsOut = 0;
	private float companyProfits = 0.0f;
	private int companyEmployees;
	private int companyEmployeeHealth = 100;

	private int colonyValue = 21000;
	private int colonyCrystalsIn = 0;
	private int colonyCrystalOut = 0;
	private float colonyProfits =0.0f;
	private float colonyGrowth = 0;
	private int colonyCompanies = 5;
	private int colonyEmployees = 15;
	private int colonyEmployeeHealth = 100;

	private float incomeProportion = 1.0f;
	private float costProportion = 1.0f;

    private int yourStartingCash = 2000;
	private int colonyStartingCash = 21000; // will be dynamic in full game
	private int colonyStartingCompanies = 5; // will be dynamic in full game
	private int colonyStartingEmployees = 15; // will be dynamic in full game

	private int [] randomEvent1Month = new int[0];
	private int [] randomEvent2Month = new int[0];
	private int [] randomEvent3Month = new int[0];
	private int [] randomEvent4Month = new int[0];
	private int [] randomEvent5Month = new int[0];
	private int [] randomEvent6Month = new int[0];
	private int [] randomEvent7Month = new int[0];
	private int [] randomEvent8Month = new int[0];

	// assessment and learning path variables
	private List<int> leversAttempted = new List<int>();
	private List<int> leversCompleted = new List<int>();
	private List<int> leverAttempts = new List<int>();
	private List<float> leverValues = new List<float> ();
	private List<float> leverGrowth = new List<float>();

	private bool recommendationGiven = false;
	private int recommendedLever;
	private bool recommendationFollowedDirectly = true;
	private bool recommendationFollowedIndirectly = false;
	public int attemptsBeforeHelpShortTerm;
	public int attemptsBeforeHelpLongTerm;

	private int helpTaxGiven = 0;
	private int helpTaxTaken = 0;
	private int helpBorrowGiven = 0;
	private int helpBorrowTaken = 0;
	private int helpHarvestGiven = 0;
	private int helpHarvestTaken = 0;

	private string graph1Chosen = "";
	private string graph2Chosen = "";

	private bool leverIsComplete;
    private bool triedToLoadGame = false;


    // testing variables
    private int extraversionScore;
    private int agreeablenessScore;
    private int ConscientiousnessScore;
    private int neuroticismScore;
    private int opennessScore;

    private int socializerScore;
    private int achieverScore;
    private int explorerScore;
    private int killerScore;

    private string[] knowledgeAnswers = new string[6];

	// arrays
	public Vector3 [] companyLocations;
	public UnityEngine.UI.Button[] oegerButtons;
	public UnityEngine.UI.Text[] oegerButtonTexts;
	public string [] levelAims;
	public string[] months;
	public int [] levelAimGrowth;
	public int [] levelAimTimeFrame;

	public string [] eventDescriptions;

    public UnityEngine.UI.Text[] demographicsQuestionTexts;
    public UnityEngine.UI.Text[] factorFiveQuestionTexts;
    public UnityEngine.UI.Text[] bartleQuestionTexts;
    public UnityEngine.UI.Text[] bartleAnswerTexts;
    public UnityEngine.UI.Text knowledgeText;

    public Toggle[] demographicsToggles;
    public Toggle[] factorFiveAnswerToggles;
    public Toggle[] bartleAnswerToggles;
   
    public string[] factorFiveQuestions1;
    public string[] factorFiveQuestions2;
    public string[] factorFiveQuestions3;

    public string[] bartleQuestions1;
    public string[] bartleQuestions2;

    public string[] bartleAnswers1;
    public string[] bartleAnswers2;

    private List<int> factorFiveAnswersList = new List<int>(); // to store answers
    private List<int> bartleAnswersList = new List<int>();

    private int[] demographicsAnswers = new int[5]; // to store which toggle is selected by user
    private int [] factorFiveAnswer = new int [3]; 
    private int[] bartleAnswer = new int[2];

    public string [] knowledgeQuestions;
    public UnityEngine.UI.InputField knowledgeAnswerInput;
    public UnityEngine.UI.InputField [] feedbackInputs;

    public string [] feedbackQuestions;
    public string [] feedbackOpenQuestions;

	// UI elements
	public UnityEngine.UI.Text oegerTipText;
	public UnityEngine.UI.Text oegerLevelTipText;

	public UnityEngine.UI.Text gamefeedText;
	public UnityEngine.UI.Text levelAimText;

	public UnityEngine.UI.Text slider1Heading;
	public UnityEngine.UI.Text slider2Heading;
	public UnityEngine.UI.Text slider1ValueText;
	public UnityEngine.UI.Text slider2ValueText;

	public UnityEngine.UI.Text companyStatusCrystalsInText;
	public UnityEngine.UI.Text companyStatusCrystalsOutText;
	public UnityEngine.UI.Text companyStatusProfitsText;
	public UnityEngine.UI.Text companyStatusEmployeeNumbersText;
	public UnityEngine.UI.Text companyStatusEmployeeHealthText;

	public UnityEngine.UI.Text colonyStatusValueText;
	public UnityEngine.UI.Text colonyStatusCrystalsInText;
	public UnityEngine.UI.Text colonyStatusCrystalsOutText;
	public UnityEngine.UI.Text colonyStatusProfitsText;
	public UnityEngine.UI.Text colonyStatusGrowthText;
	public UnityEngine.UI.Text colonyStatusCompaniesText;
	public UnityEngine.UI.Text colonyStatusEmployeeNumbersText;
	public UnityEngine.UI.Text colonyStatusEmployeeHealthText;

	public UnityEngine.UI.Text levelStatusAimText;
	public UnityEngine.UI.Text levelStatusStatusText;

	public GameObject cashEmpty;
	public UnityEngine.UI.Text gameplayMonth;
	public UnityEngine.UI.Text gameplayCash;

	public UnityEngine.UI.Button startYearButton;

	public GameObject taxShortTerm;
	public GameObject borrowShortTerm;
	public GameObject harvestShortTerm;
	public GameObject taxLongTerm;
	public GameObject borrowLongTerm;
	public GameObject harvestLongTerm;
	public GameObject taxBorrow;
	public GameObject taxHarvest;
	public GameObject borrowHarvest;

	// graphs
	public GameObject statusLevelGraph;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererStatusXAxis;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererStatusGraph;
	public UnityEngine.UI.Text labelXAxis;
	public GameObject target1;
	public GameObject target1Check;
	public GameObject target2;
	public GameObject labelsXAxisMonths;
	public GameObject labelsXAxisYears;
	private Vector2 point;
	private Vector2 xAxisPoint;
	private List<Vector2> pointList;
	private List<Vector2> pointxAxisList;

	private bool inCustomise = false;
    private bool newHighscore = false;

	// dashboard preview graphs
	public string [] graphDescriptions;
	public UnityEngine.UI.Text previewOption1Description;
	public UnityEngine.UI.Text previewOption2Description;

	public GameObject [] previewGraphs1;
	public GameObject[] previewGraphs2;

	public Transform [] dashboardPositionTransform;

	// player dashboard graphs
	public GameObject dashboard;
	public UnityEngine.UI.Dropdown dashboardOption1;
	public UnityEngine.UI.Dropdown dashboardOption2;

	public GameObject graphProgress;
	public GameObject graphAttempts;
	public GameObject graphTop3Progress;
	public GameObject graphTop3Growth;

	private int [] graphs = new int[2];

	// OWN PRORGESS GRAPH
	public Slider sliderProgress1;
	public Slider sliderProgress2;
	public Slider sliderProgress3;

	// OWN ATTEMPTS GRAPH
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererLevelAttempts;

	// TOP 3 PROGRESS GRAPH
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererProgressTop1;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererProgressTop2;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererProgressTop3;
	public UnityEngine.UI.Image yourProgressPositionImage;

	// TOP 3 GROWTH IN LEVEL GRAPH
	private string [] levelAttemptsAndGrowth;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererGrowthTop1;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererGrowthTop2;
	public UnityEngine.UI.Extensions.UILineRenderer lineRendererGrowthTop3;

	// audio
	public AudioSource gamefeedAudioSource;
	public AudioSource oegerAudioSource;
	public AudioSource buildingAudioSource;
	public AudioSource docAudioSource;
	public AudioSource monthEndSource;

    public AudioSource[] constructionSoundsAudioSource;
    public AudioSource rainThunderSource;

    // camera
    public Camera mainCamera;

    private int currentMonth;
    


    // FUNCTION
    // START
    // ===========================
    void Start()
    {
        demographicsToggles[0].onValueChanged.AddListener((value) => this.setDemographicsToggles(0));
        demographicsToggles[1].onValueChanged.AddListener((value) => this.setDemographicsToggles(1));
        demographicsToggles[2].onValueChanged.AddListener((value) => this.setDemographicsToggles(2));
        demographicsToggles[3].onValueChanged.AddListener((value) => this.setDemographicsToggles(3));
        demographicsToggles[4].onValueChanged.AddListener((value) => this.setDemographicsToggles(4));
        demographicsToggles[5].onValueChanged.AddListener((value) => this.setDemographicsToggles(5));
        demographicsToggles[6].onValueChanged.AddListener((value) => this.setDemographicsToggles(6));
        demographicsToggles[7].onValueChanged.AddListener((value) => this.setDemographicsToggles(7));
        demographicsToggles[8].onValueChanged.AddListener((value) => this.setDemographicsToggles(8));
        demographicsToggles[9].onValueChanged.AddListener((value) => this.setDemographicsToggles(9));
        demographicsToggles[10].onValueChanged.AddListener((value) => this.setDemographicsToggles(10));
        demographicsToggles[11].onValueChanged.AddListener((value) => this.setDemographicsToggles(11));
        demographicsToggles[12].onValueChanged.AddListener((value) => this.setDemographicsToggles(12));
        demographicsToggles[13].onValueChanged.AddListener((value) => this.setDemographicsToggles(13));
        demographicsToggles[14].onValueChanged.AddListener((value) => this.setDemographicsToggles(14));
        demographicsToggles[15].onValueChanged.AddListener((value) => this.setDemographicsToggles(15));
        demographicsToggles[16].onValueChanged.AddListener((value) => this.setDemographicsToggles(16));
        demographicsToggles[17].onValueChanged.AddListener((value) => this.setDemographicsToggles(17));
        demographicsToggles[18].onValueChanged.AddListener((value) => this.setDemographicsToggles(18));
        demographicsToggles[19].onValueChanged.AddListener((value) => this.setDemographicsToggles(19));
        demographicsToggles[20].onValueChanged.AddListener((value) => this.setDemographicsToggles(20));
        demographicsToggles[21].onValueChanged.AddListener((value) => this.setDemographicsToggles(21));
        demographicsToggles[22].onValueChanged.AddListener((value) => this.setDemographicsToggles(22));

        factorFiveAnswerToggles[0].onValueChanged.AddListener((value) => this.setFactorFiveToggles(0));
        factorFiveAnswerToggles[1].onValueChanged.AddListener((value) => this.setFactorFiveToggles(1));
        factorFiveAnswerToggles[2].onValueChanged.AddListener((value) => this.setFactorFiveToggles(2));
        factorFiveAnswerToggles[3].onValueChanged.AddListener((value) => this.setFactorFiveToggles(3));
        factorFiveAnswerToggles[4].onValueChanged.AddListener((value) => this.setFactorFiveToggles(4));
        factorFiveAnswerToggles[5].onValueChanged.AddListener((value) => this.setFactorFiveToggles(5));
        factorFiveAnswerToggles[6].onValueChanged.AddListener((value) => this.setFactorFiveToggles(6));
        factorFiveAnswerToggles[7].onValueChanged.AddListener((value) => this.setFactorFiveToggles(7));
        factorFiveAnswerToggles[8].onValueChanged.AddListener((value) => this.setFactorFiveToggles(8));
        factorFiveAnswerToggles[9].onValueChanged.AddListener((value) => this.setFactorFiveToggles(9));
        factorFiveAnswerToggles[10].onValueChanged.AddListener((value) => this.setFactorFiveToggles(10));
        factorFiveAnswerToggles[11].onValueChanged.AddListener((value) => this.setFactorFiveToggles(11));
        factorFiveAnswerToggles[12].onValueChanged.AddListener((value) => this.setFactorFiveToggles(12));
        factorFiveAnswerToggles[13].onValueChanged.AddListener((value) => this.setFactorFiveToggles(13));
        factorFiveAnswerToggles[14].onValueChanged.AddListener((value) => this.setFactorFiveToggles(14));

        bartleAnswerToggles[0].onValueChanged.AddListener((value) => this.setBartleToggles(0));
        bartleAnswerToggles[1].onValueChanged.AddListener((value) => this.setBartleToggles(1));
        bartleAnswerToggles[2].onValueChanged.AddListener((value) => this.setBartleToggles(2));
        bartleAnswerToggles[3].onValueChanged.AddListener((value) => this.setBartleToggles(3));

        quitGameButton.onClick.AddListener(() => this.confirmQuit());

        mainCamera.gameObject.SetActive(true);

        StartCoroutine(loadHomeScreen());
        dashboardSettingsButton.onClick.AddListener(() => this.loadCustomiseYourDashboard());
    }

    // FUNCTION
    // LOAD HOME SCREEN
    // ===========================
    IEnumerator loadHomeScreen(){
        // load existing users from database
        WWW userData = new WWW("http://www.jupiterourfinalhope.a2hosted.com/userData.php");
        yield return userData; // wait until database has been loaded

        // Get the highscores data from database
        // economy
        WWW leaderboardDataEconomy = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresEconomyData.php");
        yield return leaderboardDataEconomy;
        string leaderboardDataEconomyString = leaderboardDataEconomy.text;
        highscoresEconomy = leaderboardDataEconomyString.Split(';');
        // progression
        WWW leaderboardDataProgression = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresProgressionData.php");
        yield return leaderboardDataProgression;
        string leaderboardDataProgressionString = leaderboardDataProgression.text;
        highscoresProgression = leaderboardDataProgressionString.Split(';');
        // skills
        WWW leaderboardDataSkills = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresSkillsData.php");
        yield return leaderboardDataSkills;
        string leaderboardDataSkillsString = leaderboardDataSkills.text;
        highscoresSkills = leaderboardDataSkillsString.Split(';');
        // profits
        WWW leaderboardDataProfits = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresProfitsData.php");
        yield return leaderboardDataProfits;
        string leaderboardDataProfitsString = leaderboardDataProfits.text;
        highscoresProfits = leaderboardDataProfitsString.Split(';');
 
        string userDataString = userData.text;
        users = userDataString.Split (';');

		gameHomeScreen.SetActive (true);
		playNowButton.gameObject.SetActive (true);
		playNowButton.onClick.AddListener (() => this.loadStartGameScreen ());
	}
    // ===========================

    // FUNCTION
    // LOAD START GAME SCREEN
    // ===========================
    void loadStartGameScreen(){
		gameHomeScreen.SetActive (false);
		startNewGameScreen.SetActive (false);
		loadGameScreen.SetActive (false);
		highscoresScreen.SetActive (false);
		backstoryScreen.SetActive (false);
		gameplayScreen.SetActive (false);
		FAQscreen.SetActive (false);

		startGameScreen.SetActive (true);
		startNewGameButton.gameObject.SetActive (true);
		loadGameButton.gameObject.SetActive (true);
		highscoresButton.gameObject.SetActive (true);
		backstoryButton.gameObject.SetActive (true);
		gameplayButton.gameObject.SetActive (true);
		FAQButton.gameObject.SetActive (true);

		startNewGameButton.onClick.RemoveAllListeners ();
		loadGameButton.onClick.RemoveAllListeners ();
		highscoresButton.onClick.RemoveAllListeners ();
		backstoryButton.onClick.RemoveAllListeners ();
		gameplayButton.onClick.RemoveAllListeners ();
		FAQButton.onClick.RemoveAllListeners ();

		startNewGameButton.onClick.AddListener (() => this.WrapperStartNewGame (true));
		loadGameButton.onClick.AddListener(()=>this.loadLoadGameScreen(false));
        highscoresButton.onClick.AddListener(() => this.loadHighscoresScreen(1));
        backstoryButton.onClick.AddListener (() => this.loadBackstoryScreen ());
		gameplayButton.onClick.AddListener(()=>this.loadGameplayScreen(1));
		FAQButton.onClick.AddListener (() => this.loadFAQScreen (1));
	}
    // ===========================

    // FUNCTION
    // WRAPPER START NEW GAME
    // ===========================
    void WrapperStartNewGame(bool first){
		StartCoroutine (loadStartNewGameScreen (first));
	}
    // ===========================


    // FUNCTION
    // LOAD START NEW GAME SCREEN
    // ===========================
    IEnumerator loadStartNewGameScreen(bool firstEntry){
		startGameScreen.SetActive (false);
		termsScreen.gameObject.SetActive (false);
		startNewGameScreen.SetActive (true);

		//  set toggle default as false - user must accept terms
		acceptTermsToggle.isOn = false;

		if (!firstEntry) {
			usernameAlreadyExistsText.gameObject.SetActive (true);
		} else {
			usernameAlreadyExistsText.gameObject.SetActive (false);
		}

		backButtonStartNewGame.gameObject.SetActive(true);
		termsAndConditionsButton.gameObject.SetActive (true);
		createNewProfileButton.gameObject.SetActive (false);

		backButtonStartNewGame.onClick.RemoveAllListeners ();
		termsAndConditionsButton.onClick.RemoveAllListeners ();

		backButtonStartNewGame.onClick.AddListener (() => this.loadStartGameScreen ());
		termsAndConditionsButton.onClick.AddListener (() => this.loadTermsScreen ());

		// wait until the user has filled out all 3 fields
		yield return new WaitUntil(() => newUsernameInput.text!="" && newPasswordInput.text !="" && newSecurityAnswerInput.text!="" && acceptTermsToggle.isOn == true);
		// if all fields have been filled out by user and terms accepted - activate button
		// cannot store user's data here - else reads in values as soon as you've typed a single letter - you may still want to change something
		createNewProfileButton.gameObject.SetActive (true);
		createNewProfileButton.onClick.RemoveAllListeners ();
		createNewProfileButton.onClick.AddListener(()=> this.addNewUser());
	}
    // ===========================

    // FUNCTION
    // LOAD HIGHSCORES SCREEN
    // ===========================
    void loadHighscoresScreen(int tab){
        // Add headings
        highscoresEconomyRankText.text = "RANK \n ====== \n";
        highscoresProgressionRankText.text = "RANK \n ====== \n";
        highscoresSkillsRankText.text = "RANK \n ====== \n";
        highscoresProfitsRankText.text = "RANK \n ====== \n";
        highscoresEconomyPlayerText.text = "PLAYER \n ======= \n";
        highscoresProgressionPlayerText.text = "PLAYER \n ======= \n";
        highscoresSkillsPlayerText.text = "PLAYER \n ======= \n";
        highscoresProfitsPlayerText.text = "PLAYER \n ======= \n";
        highscoresEconomyScoreText.text = "ECONOMIC GROWTH (%) \n ======================= \n";
        highscoresProgressionScoreText.text = "PROGRESSION (HIGHEST LEVEL) \n ============================== \n";
        highscoresSkillsScoreText.text = "SKILLS (# SKILLS) \n ================ \n";
        highscoresProfitsScoreText.text = "COMPANY PROFITS (CRYSTALS) \n ============================= \n";
        // Add content of highscores

        for (int i = 0; i < highscoresEconomy.Length-1; i++) {
            highscoresEconomyRankText.text = highscoresEconomyRankText.text + getDataValue(highscoresEconomy[i], "Position:") + "\n";
            highscoresEconomyPlayerText.text = highscoresEconomyPlayerText.text + getDataValue(highscoresEconomy[i], "Username:") + "\n";
            highscoresEconomyScoreText.text = highscoresEconomyScoreText.text + getDataValue(highscoresEconomy[i], "EconomicGrowth:") + "\n";
        }
		for (int i = 0; i < highscoresProgression.Length-1; i++) {
            highscoresProgressionRankText.text = highscoresProgressionRankText.text + getDataValue(highscoresProgression[i], "Position:") + "\n";
            highscoresProgressionPlayerText.text = highscoresProgressionPlayerText.text + getDataValue(highscoresProgression[i], "Username:") + "\n";
            highscoresProgressionScoreText.text = highscoresProgressionScoreText.text + getDataValue(highscoresProgression[i], "Progression:") + "\n";
        }
		for (int i = 0; i < highscoresSkills.Length-1; i++) {
            highscoresSkillsRankText.text = highscoresSkillsRankText.text + getDataValue(highscoresSkills[i], "Position:") + "\n";
            highscoresSkillsPlayerText.text = highscoresSkillsPlayerText.text + getDataValue(highscoresSkills[i], "Username:") + "\n";
            highscoresSkillsScoreText.text = highscoresSkillsScoreText.text + getDataValue(highscoresSkills[i], "Skills:") + "\n";
        }
		for (int i = 0; i < highscoresProfits.Length-1; i++) {
            highscoresProfitsRankText.text = highscoresProfitsRankText.text + getDataValue(highscoresProfits[i], "Position:") + "\n";
            highscoresProfitsPlayerText.text = highscoresProfitsPlayerText.text + getDataValue(highscoresProfits[i], "Username:") + "\n";
            highscoresProfitsScoreText.text = highscoresProfitsScoreText.text + getDataValue(highscoresProfits[i], "CompanyProfits:") + "\n";
        }

		startGameScreen.SetActive (false);
		highscoresScreen.SetActive (true);
		highscoresHeadingText.gameObject.SetActive (true);

		if (tab == 1) {
			// economy
			highscoresEconomyRankText.gameObject.SetActive (true);
			highscoresProgressionRankText.gameObject.SetActive (false);
			highscoresSkillsRankText.gameObject.SetActive (false);
			highscoresProfitsRankText.gameObject.SetActive (false);

            highscoresEconomyPlayerText.gameObject.SetActive(true);
            highscoresProgressionPlayerText.gameObject.SetActive(false);
            highscoresSkillsPlayerText.gameObject.SetActive(false);
            highscoresProfitsPlayerText.gameObject.SetActive(false);

            highscoresEconomyScoreText.gameObject.SetActive(true);
            highscoresProgressionScoreText.gameObject.SetActive(false);
            highscoresSkillsScoreText.gameObject.SetActive(false);
            highscoresProfitsScoreText.gameObject.SetActive(false);

            highscoresHeadingText.text = "ECONOMY";
		} else if (tab == 2) {
            // progression
            highscoresEconomyRankText.gameObject.SetActive(false);
            highscoresProgressionRankText.gameObject.SetActive(true);
            highscoresSkillsRankText.gameObject.SetActive(false);
            highscoresProfitsRankText.gameObject.SetActive(false);

            highscoresEconomyPlayerText.gameObject.SetActive(false);
            highscoresProgressionPlayerText.gameObject.SetActive(true);
            highscoresSkillsPlayerText.gameObject.SetActive(false);
            highscoresProfitsPlayerText.gameObject.SetActive(false);

            highscoresEconomyScoreText.gameObject.SetActive(false);
            highscoresProgressionScoreText.gameObject.SetActive(true);
            highscoresSkillsScoreText.gameObject.SetActive(false);
            highscoresProfitsScoreText.gameObject.SetActive(false);
            highscoresHeadingText.text = "PROGRESSION";
		} else if (tab == 3) {
            // skills
            highscoresEconomyRankText.gameObject.SetActive(false);
            highscoresProgressionRankText.gameObject.SetActive(false);
            highscoresSkillsRankText.gameObject.SetActive(true);
            highscoresProfitsRankText.gameObject.SetActive(false);

            highscoresEconomyPlayerText.gameObject.SetActive(false);
            highscoresProgressionPlayerText.gameObject.SetActive(false);
            highscoresSkillsPlayerText.gameObject.SetActive(true);
            highscoresProfitsPlayerText.gameObject.SetActive(false);

            highscoresEconomyScoreText.gameObject.SetActive(false);
            highscoresProgressionScoreText.gameObject.SetActive(false);
            highscoresSkillsScoreText.gameObject.SetActive(true);
            highscoresProfitsScoreText.gameObject.SetActive(false);
            highscoresHeadingText.text = "SKILLS";
		} else {
            // profits
            highscoresEconomyRankText.gameObject.SetActive(false);
            highscoresProgressionRankText.gameObject.SetActive(false);
            highscoresSkillsRankText.gameObject.SetActive(false);
            highscoresProfitsRankText.gameObject.SetActive(true);

            highscoresEconomyPlayerText.gameObject.SetActive(false);
            highscoresProgressionPlayerText.gameObject.SetActive(false);
            highscoresSkillsPlayerText.gameObject.SetActive(false);
            highscoresProfitsPlayerText.gameObject.SetActive(true);

            highscoresEconomyScoreText.gameObject.SetActive(false);
            highscoresProgressionScoreText.gameObject.SetActive(false);
            highscoresSkillsScoreText.gameObject.SetActive(false);
            highscoresProfitsScoreText.gameObject.SetActive(true);
            highscoresHeadingText.text = "PROFITS";
		}

		backButtonHighscores.gameObject.SetActive (true);
		tabsHighscoresEconomyButton.gameObject.SetActive (true);
		tabsHighscoresProfitsButton.gameObject.SetActive (true);
		tabsHighscoresProgressionButton.gameObject.SetActive (true);
		tabsHighscoresSkillsButton.gameObject.SetActive(true);

		backButtonHighscores.onClick.RemoveAllListeners ();
		tabsHighscoresEconomyButton.onClick.RemoveAllListeners ();
		tabsHighscoresProfitsButton.onClick.RemoveAllListeners ();
		tabsHighscoresProgressionButton.onClick.RemoveAllListeners ();
		tabsHighscoresSkillsButton.onClick.RemoveAllListeners ();

		backButtonHighscores.onClick.AddListener (() => this.loadStartGameScreen ());

        tabsHighscoresEconomyButton.onClick.AddListener(() => this.loadHighscoresScreen(1));
        tabsHighscoresProgressionButton.onClick.AddListener(() => this.loadHighscoresScreen(2));
        tabsHighscoresSkillsButton.onClick.AddListener(() => this.loadHighscoresScreen(3));
        tabsHighscoresProfitsButton.onClick.AddListener(() => this.loadHighscoresScreen(4));
    }
    // ===========================

    // FUNCTION
    // LOAD FAQs SCREEN
    // ===========================
    void loadFAQScreen(int tab)
    {
        startGameScreen.SetActive(false);
        FAQscreen.SetActive(true);

        faqHeadingText.gameObject.SetActive(true);
        faqNewQuestionInput.gameObject.SetActive(false);
        faqSubmitQuestionButton.gameObject.SetActive(false);

        if (tab == 1)
        {
            // general
            faqGeneralText.gameObject.SetActive(true);
            faqGameplayText.gameObject.SetActive(false);
            faqTechnicalText.gameObject.SetActive(false);
            faqCreatorsText.gameObject.SetActive(false);
            faqMoreText.gameObject.SetActive(false);
            thanksForYourSubmissionText.gameObject.SetActive(false);
            faqHeadingText.text = "GENERAL";
        }
        else if (tab == 2)
        {
            // gameplay
            faqGeneralText.gameObject.SetActive(false);
            faqGameplayText.gameObject.SetActive(true);
            faqTechnicalText.gameObject.SetActive(false);
            faqCreatorsText.gameObject.SetActive(false);
            faqMoreText.gameObject.SetActive(false);
            thanksForYourSubmissionText.gameObject.SetActive(false);
            faqHeadingText.text = "GAMEPLAY";
        }
        else if (tab == 3)
        {
            // technical
            faqGeneralText.gameObject.SetActive(false);
            faqGameplayText.gameObject.SetActive(false);
            faqTechnicalText.gameObject.SetActive(true);
            faqCreatorsText.gameObject.SetActive(false);
            faqMoreText.gameObject.SetActive(false);
            thanksForYourSubmissionText.gameObject.SetActive(false);
            faqHeadingText.text = "TECHNICAL";
        }
        else if (tab == 4)
        {
            // creators
            faqGeneralText.gameObject.SetActive(false);
            faqGameplayText.gameObject.SetActive(false);
            faqTechnicalText.gameObject.SetActive(false);
            faqCreatorsText.gameObject.SetActive(true);
            faqMoreText.gameObject.SetActive(false);
            thanksForYourSubmissionText.gameObject.SetActive(false);
            faqHeadingText.text = "CREATORS";
        }
        else
        {
            // option to submit new question
            faqGeneralText.gameObject.SetActive(false);
            faqGameplayText.gameObject.SetActive(false);
            faqTechnicalText.gameObject.SetActive(false);
            faqCreatorsText.gameObject.SetActive(false);
            faqMoreText.gameObject.SetActive(true);
            faqHeadingText.text = "MORE";

            // activate user input field and submission button
            faqNewQuestionInput.gameObject.SetActive(true);
            faqSubmitQuestionButton.gameObject.SetActive(true);
            faqSubmitQuestionButton.onClick.RemoveAllListeners();
            faqSubmitQuestionButton.onClick.AddListener(() => this.addNewQuestion());
        }

        backButtonFAQ.gameObject.SetActive(true);
        tabsFAQGeneralButton.gameObject.SetActive(true);
        tabsFAQGameplayButton.gameObject.SetActive(true);
        tabsFAQTechnicalButton.gameObject.SetActive(true);
        tabsFAQCreatorsButton.gameObject.SetActive(true);
        tabsFAQMoreButton.gameObject.SetActive(true);

        backButtonFAQ.onClick.RemoveAllListeners();
        tabsFAQGeneralButton.onClick.RemoveAllListeners();
        tabsFAQGameplayButton.onClick.RemoveAllListeners();
        tabsFAQTechnicalButton.onClick.RemoveAllListeners();
        tabsFAQCreatorsButton.onClick.RemoveAllListeners();
        tabsFAQMoreButton.onClick.RemoveAllListeners();

        backButtonFAQ.onClick.AddListener(() => this.loadStartGameScreen());
        tabsFAQGeneralButton.onClick.AddListener(() => this.loadFAQScreen(1));
        tabsFAQGameplayButton.onClick.AddListener(() => this.loadFAQScreen(2));
        tabsFAQTechnicalButton.onClick.AddListener(() => this.loadFAQScreen(3));
        tabsFAQCreatorsButton.onClick.AddListener(() => this.loadFAQScreen(4));
        tabsFAQMoreButton.onClick.AddListener(() => this.loadFAQScreen(5));
    }
    // ===========================

    // FUNCTION
    // ADD NEW QUESTION
    // ===========================
    void addNewQuestion()
    {
        userForm = new WWWForm();
        userForm.AddField("questionPost", faqNewQuestionInput.text);
        userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/addQuestion.php", userForm);

        // display message to user
        thanksForYourSubmissionText.gameObject.SetActive(true);

        // reset user input field
        faqNewQuestionInput.text = "";
        this.loadFAQScreen(5);
    }
    // ===========================

    // FUNCTION
    // LOAD GAMEPLAY SCREEN
    // ===========================
    void loadGameplayScreen(int tab)
    {
        startGameScreen.SetActive(false);
        gameplayScreen.SetActive(true);
        gameplayHeadingText.gameObject.SetActive(true);

        if (tab == 1)
        {
            // the basics
            gameplayBasicsText.gameObject.SetActive(true);
            gameplayStartingBusinessText.gameObject.SetActive(false);
            gameplayEconomyText.gameObject.SetActive(false);
            gameplayWinningText.gameObject.SetActive(false);
            gameplayHeadingText.text = "THE BASICS";
        }
        else if (tab == 2)
        {
            // starting your business
            gameplayBasicsText.gameObject.SetActive(false);
            gameplayStartingBusinessText.gameObject.SetActive(true);
            gameplayEconomyText.gameObject.SetActive(false);
            gameplayWinningText.gameObject.SetActive(false);
            gameplayHeadingText.text = "STARTING YOUR BUSINESS";
        }
        else if (tab == 3)
        {
            // the economy
            gameplayBasicsText.gameObject.SetActive(false);
            gameplayStartingBusinessText.gameObject.SetActive(false);
            gameplayEconomyText.gameObject.SetActive(true);
            gameplayWinningText.gameObject.SetActive(false);
            gameplayHeadingText.text = "THE ECONOMY";
        }
        else
        {
            // winning the game
            gameplayBasicsText.gameObject.SetActive(false);
            gameplayStartingBusinessText.gameObject.SetActive(false);
            gameplayEconomyText.gameObject.SetActive(false);
            gameplayWinningText.gameObject.SetActive(true);
            gameplayHeadingText.text = "WINNING THE GAME";
        }

        backButtonGameplay.gameObject.SetActive(true);
        tabsGameplayTheBasicsButton.gameObject.SetActive(true);
        tabsGameplayStartingBusinessButton.gameObject.SetActive(true);
        tabsGameplayTheEconomyButton.gameObject.SetActive(true);
        tabsGameplayWinningButton.gameObject.SetActive(true);

        backButtonGameplay.onClick.RemoveAllListeners();
        tabsGameplayTheBasicsButton.onClick.RemoveAllListeners();
        tabsGameplayStartingBusinessButton.onClick.RemoveAllListeners();
        tabsGameplayTheEconomyButton.onClick.RemoveAllListeners();
        tabsGameplayWinningButton.onClick.RemoveAllListeners();

        backButtonGameplay.onClick.AddListener(() => this.loadStartGameScreen());
        tabsGameplayTheBasicsButton.onClick.AddListener(() => this.loadGameplayScreen(1));
        tabsGameplayStartingBusinessButton.onClick.AddListener(() => this.loadGameplayScreen(2));
        tabsGameplayTheEconomyButton.onClick.AddListener(() => this.loadGameplayScreen(3));
        tabsGameplayWinningButton.onClick.AddListener(() => this.loadGameplayScreen(4));
    }
    // ===========================

    // FUNCTION
    // LOAD BACKSTORY SCREEN
    // ===========================
    void loadBackstoryScreen()
    {
        startGameScreen.SetActive(false);
        backstoryScreen.SetActive(true);
        backButtonBackstory.gameObject.SetActive(true);

        backButtonBackstory.onClick.RemoveAllListeners();
        backButtonBackstory.onClick.AddListener(() => this.loadStartGameScreen());
    }
    // ===========================


    // FUNCTION
    // LOAD LOAD GAME SCREEN
    // ===========================
    void loadLoadGameScreen(bool incorrectEntry)
    {
        startGameScreen.SetActive(false);
        forgotPasswordScreen.SetActive(false);
        loadGameScreen.SetActive(true);
        notAvailableInDemoText.gameObject.SetActive(false);
        // reset input fields
        loadUsernameInput.text = "";
        loadPasswordInput.text = "";

        if (!incorrectEntry)
        {
            wrongUsernamePasswordText.gameObject.SetActive(false);
            if(triedToLoadGame == true)
            {
                notAvailableInDemoText.gameObject.SetActive(true);
            }
        }
        else
        {
            notAvailableInDemoText.gameObject.SetActive(false);
            wrongUsernamePasswordText.gameObject.SetActive(true);
        }

        backButtonLoadGame.gameObject.SetActive(true);
        forgotPasswordButton.gameObject.SetActive(true);

        backButtonLoadGame.onClick.RemoveAllListeners();
        forgotPasswordButton.onClick.RemoveAllListeners();

        backButtonLoadGame.onClick.AddListener(() => this.loadStartGameScreen());
        forgotPasswordButton.onClick.AddListener(() => this.getForgottenPassword(true, false));

        loadUsername = loadUsernameInput.text;
        loadPassword = loadPasswordInput.text;

        loadButton.gameObject.SetActive(true);
        loadButton.onClick.RemoveAllListeners();

        loadButton.onClick.AddListener(() => this.checkUserAccount(false));
    }
    // ===========================

    // FUNCTION
    // CHECK USER ACCOUNT
    // ===========================
    void checkUserAccount(bool forgotPassword)
    {
        bool userExists = false;
        if (!forgotPassword)
        {
            // if just trying to load user account
            triedToLoadGame = true;
            loadUsername = loadUsernameInput.text;
            loadPassword = loadPasswordInput.text;

            for (int i = 0; i < users.Length - 1; i++)
            {
                // need to go to length-1 since last line is an empty (";" results in \n)
                if (loadUsername == getDataValue(users[i], "Username:"))
                {
                    userExists = true;
                    userID = i;
                    i = users.Length - 1; // exit loop
                }
            }

            if (userExists == true)
            {
                // if username exists - check if the password is correct
                if (loadPassword == getDataValue(users[userID], "Password:"))
                {
                    // LOAD THE USER'S GAME - not available in demo
                    this.loadLoadGameScreen(false);
                }
                else
                {
                    // incorrect password
                    this.loadLoadGameScreen(true); // go back to loadScreen but display error
                }
            }
            else
            {
                // username does not exist
                this.loadLoadGameScreen(true); // go back to loadScreen but display error
            }
        }
        else
        {
            // check forgotten password
            for (int i = 0; i < users.Length - 1; i++)
            {
                // need to go to length-1 since last line is an empty (";" results in \n)
                if (forgotUsernameInput.text == getDataValue(users[i], "Username:"))
                {
                    userExists = true;
                    userID = i;
                    i = users.Length - 1; // exit loop
                }
            }
            if (userExists)
            {
                // if username exists - check if security question's answer is correct
                if (forgotSecurityAnswerInput.text == getDataValue(users[userID], "SecurityAnswer:"))
                {
                    this.getForgottenPassword(false, true); // go back to getPasswordScreen and display password
                }
                else
                {
                    this.getForgottenPassword(false, false); // go back to getPasswordScreen but display error
                }
            }
            else
            {
                // username does not exist
                this.getForgottenPassword(false, false); // go back to getPasswordScreen but display error
            }
        }
    }
    // ===========================

    // FUNCTION
    // GET FORGOTTEN PASSWORD
    // ===========================
    void getForgottenPassword(bool firstEntry, bool display)
    {
        loadGameScreen.SetActive(false);
        forgotPasswordScreen.SetActive(true);

        backButtonForgotPassword.gameObject.SetActive(true);
        backButtonForgotPassword.onClick.RemoveAllListeners();
        backButtonForgotPassword.onClick.AddListener(() => this.loadLoadGameScreen(false));

        if (firstEntry)
        {
            // reset input fields
            forgotUsernameInput.text = "";
            forgotSecurityAnswerInput.text = "";

            yourPasswordText.gameObject.SetActive(false);
            incorrectForgottenEntryText.gameObject.SetActive(false);

            okBackToLoadScreenButton.gameObject.SetActive(false);
            submitSecurityAnswerButton.gameObject.SetActive(true);

            submitSecurityAnswerButton.onClick.RemoveAllListeners();
            submitSecurityAnswerButton.onClick.AddListener(() => this.checkUserAccount(true));
        }
        else
        {
            if (display)
            {
                // if security answer was correct - display user's password
                submitSecurityAnswerButton.gameObject.SetActive(false);
                okBackToLoadScreenButton.gameObject.SetActive(true);

                incorrectForgottenEntryText.gameObject.SetActive(false);
                yourPasswordText.gameObject.SetActive(true);
                yourPasswordText.text = "Your password is: " + getDataValue(users[userID], "Password:");

                okBackToLoadScreenButton.onClick.RemoveAllListeners();
                okBackToLoadScreenButton.onClick.AddListener(() => this.loadLoadGameScreen(false));
            }
            else
            {
                yourPasswordText.gameObject.SetActive(false);
                incorrectForgottenEntryText.gameObject.SetActive(true);

                // re-activate submit button
                submitSecurityAnswerButton.gameObject.SetActive(true);

                submitSecurityAnswerButton.onClick.RemoveAllListeners();
                submitSecurityAnswerButton.onClick.AddListener(() => this.checkUserAccount(true));
            }
        }
    }
    // ===========================


    // FUNCTION
    // LOAD TERMS SCREEN
    // ===========================
    void loadTermsScreen()
    {
        termsScreen.SetActive(true);
        startNewGameScreen.SetActive(false);

        backButtonTerms.gameObject.SetActive(true);
        backButtonTerms.onClick.RemoveAllListeners();
        backButtonTerms.onClick.AddListener(() => this.WrapperStartNewGame(true));
    }

    string getDataValue(string data, string index){
		string value = data.Substring (data.IndexOf (index) + index.Length);
		if (value.Contains ("|"))
			value = value.Remove (value.IndexOf ("|"));
		return value;
	}
    // ===========================

    // FUNCTION
    // ADD NEW USER
    // ===========================
    void addNewUser()
    {
        bool alreadyExists = false;
        // save the data entered by user
        newUsername = newUsernameInput.text;
        newPassword = newPasswordInput.text;
        newSecurityAnswer = newSecurityAnswerInput.text;

        for (int i = 0; i < users.Length - 1; i++)
        {
            // need to go to length-1 since last line is an empty (";" results in \n)
            if (newUsername == getDataValue(users[i], "Username:"))
            {
                // if the username already exists - reset input fields
                newUsernameInput.text = "";
                newPasswordInput.text = "";
                newSecurityAnswerInput.text = "";
                alreadyExists = true;
                this.WrapperStartNewGame(false);
                i = users.Length - 1; // exit loop (only need one to be identicle)
            }
        }
        if (!alreadyExists)
        {
            // add the user's data to users table in database
            userForm = new WWWForm();
            userForm.AddField("namePost", newUsername);
            userForm.AddField("passwordPost", newPassword);
            userForm.AddField("securityAnswerPost", newSecurityAnswer);
            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/addUser.php", userForm);
            this.WrapperLoadDemographicsScreen(0);
        }
    }
    // ===========================

    // FUNCTION
    // WRAPPER LOAD DEMOGRAPHICS SCREEN
    // ===========================
    void WrapperLoadDemographicsScreen(int set)
    {
        StartCoroutine(loadDemographicsScreen(set));
    }
    // ===========================

    // FUNCTION
    // LOAD DEMOGRAPHICS SCREEN
    // ===========================
    IEnumerator loadDemographicsScreen(int set)
    {
        startNewGameScreen.gameObject.SetActive(false);
        demographicsScreen.gameObject.SetActive(true);

        if(set > 0)
        {
            // get user's previous answers
            for (int i = 0; i < 5; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[0] = i + 1; // store answer in 1-5 range
                    i = 5; // exit loop
                }
            }
            for (int i = 5; i < 7; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[1] = i - 5 + 1; // store answer in 1-2 range
                    i = 7; // exit loop
                }
            }
            for (int i = 7; i < 12; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[2] = i - 7 + 1; // store answer in 1-5 range
                    i = 12; // exit loop 
                }
            }
            for (int i = 0; i < 12; i++)
            {
                demographicsToggles[i].gameObject.SetActive(false);
            }
            for (int i = 12; i < 23; i++)
            {
                demographicsToggles[i].gameObject.SetActive(true);
                demographicsToggles[i].isOn = false; // set all toggles to false
            }

            demographicsQuestionTexts[0].gameObject.SetActive(false);
            demographicsQuestionTexts[1].gameObject.SetActive(false);
            demographicsQuestionTexts[2].gameObject.SetActive(false);
            demographicsQuestionTexts[3].gameObject.SetActive(true);
            demographicsQuestionTexts[4].gameObject.SetActive(true);

        }
        else
        {
            // first time screen is loaded
            for (int i = 0; i < 12; i++)
            {
                demographicsToggles[i].gameObject.SetActive(true);
                demographicsToggles[i].isOn = false; // set all toggles to false
            }
            for (int i = 12; i < 23; i++)
            {
                demographicsToggles[i].gameObject.SetActive(false);
            }
            demographicsQuestionTexts[0].gameObject.SetActive(true);
            demographicsQuestionTexts[1].gameObject.SetActive(true);
            demographicsQuestionTexts[2].gameObject.SetActive(true);
            demographicsQuestionTexts[3].gameObject.SetActive(false);
            demographicsQuestionTexts[4].gameObject.SetActive(false);

        }

        for(int i = 0; i < 12; i++)
        {
            demographicsToggles[i].isOn = false; // set all toggles off initially
        }

        // set number for progress e.g. set 1/2
        int number = set + 1;
        demographicsNumberText.text = "(" + number.ToString() + "/2)";
                
        submitDemographicsButton.onClick.RemoveAllListeners();
        submitDemographicsButton.gameObject.SetActive(false); // only activate once all questions have been answered
        if(set == 0)
        {
            yield return new WaitUntil(() => (demographicsToggles[0].isOn == true || demographicsToggles[1].isOn == true || demographicsToggles[2].isOn == true || demographicsToggles[3].isOn == true || demographicsToggles[4].isOn == true) && (demographicsToggles[5].isOn == true || demographicsToggles[6].isOn == true) && (demographicsToggles[7].isOn == true || demographicsToggles[8].isOn == true || demographicsToggles[9].isOn == true || demographicsToggles[10].isOn == true || demographicsToggles[11].isOn == true));
            submitDemographicsButton.gameObject.SetActive(true);

            submitDemographicsButton.onClick.AddListener(() => this.WrapperLoadDemographicsScreen(1));
        }
        else
        {
            yield return new WaitUntil(() => (demographicsToggles[12].isOn == true || demographicsToggles[13].isOn == true || demographicsToggles[14].isOn == true) && (demographicsToggles[15].isOn == true || demographicsToggles[16].isOn == true || demographicsToggles[17].isOn == true || demographicsToggles[18].isOn == true || demographicsToggles[19].isOn == true || demographicsToggles[20].isOn == true || demographicsToggles[21].isOn == true || demographicsToggles[22].isOn == true));
            submitDemographicsButton.gameObject.SetActive(true);

            submitDemographicsButton.onClick.AddListener(() => this.WrapperLoadFactorFiveTest(0));
        }
        
    }
    // ===========================

    // FUNCTION
    // SET DEMOGRAPHICS TOGGLES
    // =======================
    void setDemographicsToggles(int toggle)
    {
        if(demographicsToggles[toggle].isOn == true) // only if value was changed to true (else will also run if a toggle was deselected - i.e. every time another one is selected)
        {
            // ensure that only 1 toggle in answer group is selected at all times
            if (toggle <= 4)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (i != toggle)
                    {
                        demographicsToggles[i].isOn = false;
                    }
                }
            }
            else if (toggle <= 6)
            {
                for (int i = 5; i <= 6; i++)
                {
                    if (i != toggle)
                    {
                        demographicsToggles[i].isOn = false;
                    }
                }
            }
            else if (toggle <= 11)
            {
                for (int i = 7; i <= 11; i++)
                {
                    if (i != toggle)
                    {
                        demographicsToggles[i].isOn = false;
                    }
                }
            }
            else if (toggle <= 14)
            {
                for (int i = 12; i <= 14; i++)
                {
                    if (i != toggle)
                    {
                        demographicsToggles[i].isOn = false;
                    }
                }
            }
            else
            {
                for (int i = 15; i <= 22; i++)
                {
                    if (i != toggle)
                    {
                        demographicsToggles[i].isOn = false;
                    }
                }
            }
        }
        
    }
    // ==========================

    // FUNCTION
    // WRAPPER LOAD FACTOR FIVE SCREEN
    // ===========================
    void WrapperLoadFactorFiveTest(int num)
    {
        StartCoroutine(loadFactorFiveTest(num));
    }

    // ===========================

    // FUNCTION
    // LOAD FACTOR FIVE SCREEN
    // ===========================
    IEnumerator loadFactorFiveTest(int set)
    {
        demographicsScreen.SetActive(false);
        factorFiveScreen.SetActive(true);
        submitFactorFiveButton.gameObject.SetActive(false); // turn off until user has selected an answer for each question

        if (set > 0)
        {
            // get user's previous answers
            for(int i = 0; i < 5; i++)
            {
                if(factorFiveAnswerToggles[i].isOn == true)
                {
                    factorFiveAnswer[0] = i + 1; // store user's previous answer as per 1-5 range
                    i = 5; // exit loop
                }
            }
            for(int i = 5; i < 10; i++)
            {
                if(factorFiveAnswerToggles[i].isOn == true)
                {
                    factorFiveAnswer[1] = i - 5 + 1; // store user's previous answer as per 1-5 range
                    i = 10; // exit loop
                }
            }
            for (int i = 10; i < 15; i++)
            {
                if (factorFiveAnswerToggles[i].isOn == true)
                {
                    factorFiveAnswer[2] = i - 10 + 1; // store user's previous answer as per 1-5 range
                    i = 15; // exit loop
                }
            }
            factorFiveAnswersList.Add(factorFiveAnswer[0]); // store user's previous answers in list
            factorFiveAnswersList.Add(factorFiveAnswer[1]);
            factorFiveAnswersList.Add(factorFiveAnswer[2]);

            factorFiveQuestionTexts[0].gameObject.SetActive(true); // activate question text fields
            factorFiveQuestionTexts[1].gameObject.SetActive(true);
        }
        else
        {
            // get user's final answers in demographics the first time this test is called
            for (int i = 12; i < 15; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[3] = i - 12 + 1; // store answer in 1-3 range
                    i = 15; // exit loop
                }
            }
            for (int i = 15; i < 23; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[4] = i - 15 + 1; // store answer in 1-2 range
                    i = 23; // exit loop
                }
            }

            // write demographics data to database
            userForm = new WWWForm();
            userForm.AddField("agePost", demographicsAnswers[0]);
            userForm.AddField("genderPost", demographicsAnswers[1]);
            userForm.AddField("gamingExperiencePost", demographicsAnswers[2]);
            userForm.AddField("experiencePost", demographicsAnswers[3]);
            userForm.AddField("qualificationPost", demographicsAnswers[4]);
            userForm.AddField("namePost", newUsername);
            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateDemographics.php", userForm);


            for (int i = 0; i < 5; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[0] = i + 1; // store answer in 1-5 range
                    i = 5; // exit loop
                }
            }
            for (int i = 5; i < 7; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[1] = i - 5 + 1; // store answer in 1-2 range
                    i = 75; // exit loop
                }
            }
            for (int i = 7; i < 12; i++)
            {
                if (demographicsToggles[i].isOn == true)
                {
                    demographicsAnswers[2] = i - 7 + 1; // store answer in 1-5 range
                    i = 12; // exit loop 
                }
            }
            // write demographics data to database
            userForm = new WWWForm();
            userForm.AddField("agePost", demographicsAnswers[0]);
            userForm.AddField("genderPost", demographicsAnswers[1]);
            userForm.AddField("gamingExperiencePost", demographicsAnswers[2]);
            userForm.AddField("namePost", newUsername);
            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateDemographics.php", userForm);
        }
        for (int i = 0; i < 15; i++)
        {
            factorFiveAnswerToggles[i].gameObject.SetActive(true);
            factorFiveAnswerToggles[i].isOn = false; // set all toggles to false
        }

        if(set == 14)
        {
            for (int i = 10; i < 15; i++)
            {
                factorFiveAnswerToggles[i].gameObject.SetActive(false);
            }
               
        }
        factorFiveQuestionTexts[0].text = factorFiveQuestions1[set];
        factorFiveQuestionTexts[1].text = factorFiveQuestions2[set];
        if (set != 14)
        {
            factorFiveQuestionTexts[2].text = factorFiveQuestions3[set];
        }
        else
        {
            factorFiveQuestionTexts[2].gameObject.SetActive(false); // no third question in final set
        }

        // set number for progress e.g. set 2/15
        int number = set + 1;
        factorFiveNumberText.text = "(" + number.ToString() + "/15)";

        submitFactorFiveButton.onClick.RemoveAllListeners();

        // only activate submit button when all questions have been answered
        if (set != 14)
        {
            yield return new WaitUntil(() => (factorFiveAnswerToggles[0].isOn == true || factorFiveAnswerToggles[1].isOn == true || factorFiveAnswerToggles[2].isOn == true || factorFiveAnswerToggles[3].isOn == true || factorFiveAnswerToggles[4].isOn == true) && (factorFiveAnswerToggles[5].isOn == true || factorFiveAnswerToggles[6].isOn == true || factorFiveAnswerToggles[7].isOn == true || factorFiveAnswerToggles[8].isOn == true || factorFiveAnswerToggles[9].isOn == true) && (factorFiveAnswerToggles[10].isOn == true || factorFiveAnswerToggles[11].isOn == true || factorFiveAnswerToggles[12].isOn == true || factorFiveAnswerToggles[13].isOn == true || factorFiveAnswerToggles[14].isOn == true));
            submitFactorFiveButton.gameObject.SetActive(true);
            submitFactorFiveButton.onClick.AddListener(() => this.WrapperLoadFactorFiveTest(set + 1)); // load next questions
        }
        else
        {
            // only wait for answers to 2 questions (there is no third)
            yield return new WaitUntil(() => (factorFiveAnswerToggles[0].isOn == true || factorFiveAnswerToggles[1].isOn == true || factorFiveAnswerToggles[2].isOn == true || factorFiveAnswerToggles[3].isOn == true || factorFiveAnswerToggles[4].isOn == true) && (factorFiveAnswerToggles[5].isOn == true || factorFiveAnswerToggles[6].isOn == true || factorFiveAnswerToggles[7].isOn == true || factorFiveAnswerToggles[8].isOn == true || factorFiveAnswerToggles[9].isOn == true));
            submitFactorFiveButton.gameObject.SetActive(true);
            submitFactorFiveButton.onClick.AddListener(() => this.WrapperLoadBartleTest(0)); // load next test
        }
    }
    // ===========================


        // FUNCTION
        // SET FACTOR FIVE TOGGLES
        // =======================
        void setFactorFiveToggles(int toggle)
    {
        if(factorFiveAnswerToggles[toggle].isOn == true) // only if value was changed to true (else will also run if a toggle was deselected - i.e. every time another one is selected)
        {
            // ensure that only 1 toggle in answer group is selected at all times
            if (toggle <= 4)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (i != toggle)
                    {
                        factorFiveAnswerToggles[i].isOn = false;
                    }
                }
            }
            else if (toggle <= 9)
            {
                for (int i = 5; i <= 9; i++)
                {
                    if (i != toggle)
                    {
                        factorFiveAnswerToggles[i].isOn = false;
                    }
                }
            }
            else
            {
                for (int i = 10; i <= 14; i++)
                {
                    if (i != toggle)
                    {
                        factorFiveAnswerToggles[i].isOn = false;
                    }
                }
            }
        }
        
    }
    // ==========================

    // FUNCTION 
    // WRAPPER LOAD BARTLE TEST
    // ==========================
        void WrapperLoadBartleTest (int num)
    {
        if(num > 0)
        {
            StartCoroutine(loadBartleTest(num));
        }
        else
        {
            // get user's final answers in Factor Five test the first time this test is called
            for (int i = 0; i < 5; i++)
            {
                if (factorFiveAnswerToggles[i].isOn == true)
                {
                    factorFiveAnswer[0] = i + 1; // store user's answer as per 1-5 range
                    i = 5; // exit loop
                }
            }
            for (int i = 5; i < 10; i++)
            {
                if (factorFiveAnswerToggles[i].isOn == true)
                {
                    factorFiveAnswer[1] = i - 5 + 1; // store user's answer as per 1-5 range
                    i = 10; // exit loop
                }
            }

            // store user's final answers in list
            factorFiveAnswersList.Add(factorFiveAnswer[0]);
            factorFiveAnswersList.Add(factorFiveAnswer[1]);

            // calculate outcome of Factor Five test
            string userAnswers = "";
            for (int i = 0; i < 44; i++)
            {
                userAnswers = userAnswers + factorFiveAnswersList[i].ToString();
            }
            // Extraversion
            extraversionScore = factorFiveAnswersList[0] + getReverseScore(factorFiveAnswersList[5]) + factorFiveAnswersList[10] + +factorFiveAnswersList[15] + getReverseScore(factorFiveAnswersList[20]) + factorFiveAnswersList[25] + getReverseScore(factorFiveAnswersList[30]) + factorFiveAnswersList[35];
            // Agreeableness
            agreeablenessScore = getReverseScore(factorFiveAnswersList[1]) + factorFiveAnswersList[6] + getReverseScore(factorFiveAnswersList[11]) + factorFiveAnswersList[16] + factorFiveAnswersList[21] + getReverseScore(factorFiveAnswersList[26]) + factorFiveAnswersList[31] + getReverseScore(factorFiveAnswersList[36]) + factorFiveAnswersList[41];
            // Conscientiousness
            ConscientiousnessScore = factorFiveAnswersList[2] + getReverseScore(factorFiveAnswersList[7]) + factorFiveAnswersList[12] + getReverseScore(factorFiveAnswersList[17]) + getReverseScore(factorFiveAnswersList[21]) + factorFiveAnswersList[27] + factorFiveAnswersList[32] + factorFiveAnswersList[37] + getReverseScore(factorFiveAnswersList[42]);
            // Neuoticism
            neuroticismScore = factorFiveAnswersList[3] + getReverseScore(factorFiveAnswersList[8]) + factorFiveAnswersList[13] + factorFiveAnswersList[18] + getReverseScore(factorFiveAnswersList[23]) + factorFiveAnswersList[28] + getReverseScore(factorFiveAnswersList[33]) + factorFiveAnswersList[38];
            // Openness
            opennessScore = factorFiveAnswersList[4] + factorFiveAnswersList[9] + factorFiveAnswersList[14] + factorFiveAnswersList[19] + factorFiveAnswersList[24] + factorFiveAnswersList[29] + getReverseScore(factorFiveAnswersList[34]) + factorFiveAnswersList[39] + getReverseScore(factorFiveAnswersList[40]) + factorFiveAnswersList[42];

            // write personality outcomes to database
            userForm = new WWWForm();
            userForm.AddField("personalityRawPost", userAnswers);
            userForm.AddField("extraversionPost", extraversionScore);
            userForm.AddField("agreeablenessPost", agreeablenessScore);
            userForm.AddField("conscientiousnessPost", ConscientiousnessScore);
            userForm.AddField("neuroticismPost", neuroticismScore);
            userForm.AddField("opennessPost", opennessScore);
            userForm.AddField("namePost", newUsername);
            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updatePersonality.php", userForm);

            // call next test
            StartCoroutine(loadBartleTest(num));
        }
    }

    // FUNCTION
    // GET REVERSE SCORE
    // ==========================
    int getReverseScore(int score)
    {
        int reverseScore;
        if (score == 1)
        {
            reverseScore = 5;
        }
        else if (score == 2)
        {
            reverseScore = 4;
        }
        else if (score == 3)
        {
            reverseScore = 3;
        }
        else if (score == 4)
        {
            reverseScore = 2;
        }
        else
        {
            reverseScore = 1;
        }
        return reverseScore;
    }
    // ==========================

    // ==========================

    // FUNCTION 
    // LOAD BARTLE TEST
    // ==========================
    IEnumerator loadBartleTest(int set)
    {
        startNewGameScreen.gameObject.SetActive(false);
        factorFiveScreen.SetActive(false);
        bartleScreen.gameObject.SetActive(true);
        submitBartleButton.gameObject.SetActive(false); // turn off until user has selected an answer for each question
        if (set > 0)
        {
            // get user's previous answers
            for (int i = 0; i < 2; i++)
            {
                if (bartleAnswerToggles[i].isOn == true)
                {
                    bartleAnswer[0] = i + 1; // store user's previous answer as per 1-2 range
                    i = 2; // exit loop
                }
            }
            for (int i = 2; i < 4; i++)
            {
                if (bartleAnswerToggles[i].isOn == true)
                {
                    bartleAnswer[1] = i - 2 + 1; // store user's previous answer as per 1-2 range
                    i = 4; // exit loop
                }
            }

            bartleAnswersList.Add(bartleAnswer[0]); // store user's previous answers in list
            bartleAnswersList.Add(bartleAnswer[1]);

            bartleQuestionTexts[0].gameObject.SetActive(true); // activate question text fields
            bartleQuestionTexts[1].gameObject.SetActive(true); 
        }

        // set number for progress e.g. set 2/20
        int number = set + 1;
        bartleNumberText.text = "(" + number.ToString() + "/20)";

        for (int i = 0; i < 4; i++)
        {
            bartleAnswerToggles[i].gameObject.SetActive(true);
            bartleAnswerToggles[i].isOn = false; // set all toggles to false
        }

        if (set == 19)
        {
            for (int i = 2; i < 4; i++)
            {
                bartleAnswerToggles[i].gameObject.SetActive(false);
            }
        }

        bartleQuestionTexts[0].text = bartleQuestions1[set];
        bartleAnswerTexts[0].text = bartleAnswers1[set * 2];
        bartleAnswerTexts[1].text = bartleAnswers1[set * 2 + 1];

        if (set != 19)
        {
            bartleQuestionTexts[1].text = bartleQuestions2[set];
            bartleAnswerTexts[2].text = bartleAnswers2[set * 2];
            bartleAnswerTexts[3].text = bartleAnswers2[set * 2 + 1];

        }
        else
        {
            bartleQuestionTexts[1].gameObject.SetActive(false); // no second question in final set
        }
        
        submitBartleButton.onClick.RemoveAllListeners();

        // only activate submit button when all questions have been answered
        if (set != 19)
        {
            yield return new WaitUntil(() => (bartleAnswerToggles[0].isOn == true || bartleAnswerToggles[1].isOn == true) && (bartleAnswerToggles[2].isOn == true || bartleAnswerToggles[3].isOn == true));
            submitBartleButton.gameObject.SetActive(true);
            submitBartleButton.onClick.AddListener(() => this.WrapperLoadBartleTest(set + 1)); // load next questions
        }
        else
        {
            // only wait for answers to 2 questions (there is no third)
            yield return new WaitUntil(() => (bartleAnswerToggles[0].isOn == true || bartleAnswerToggles[1].isOn == true));
            submitBartleButton.gameObject.SetActive(true);
            submitBartleButton.onClick.AddListener(() => this.WrapperLoadPretest(0, true)); // load next test
        }
    }

    // ==========================

    // FUNCTION
    // SET BARTLE TOGGLES
    // =======================
    void setBartleToggles(int toggle)
    {
        if(bartleAnswerToggles[toggle].isOn == true) // only if value was changed to true (else will also run if a toggle was deselected - i.e. every time another one is selected)
        {
            // ensure that only 1 toggle in answer group is selected at all times
            if (toggle <= 1)
            {
                for (int i = 0; i <= 1; i++)
                {
                    if (i != toggle)
                    {
                        bartleAnswerToggles[i].isOn = false;
                    }
                }
            }
            else
            {
                for (int i = 2; i <= 3; i++)
                {
                    if (i != toggle)
                    {
                        bartleAnswerToggles[i].isOn = false;
                    }
                }
            }
        }
    }
    // ==========================

    // FUNCTION
    // WRAPPER LOAD PRETEST
    // ==========================
    void WrapperLoadPretest(int num, bool preTest)
    {
        if (num > 0)
        {
            StartCoroutine(loadPretest(num, preTest));
        }
        else
        {
            if (preTest == true)
            {
                // get user's final answer in Bartle test the first time this test is called
                for (int i = 0; i < 2; i++)
                {
                    if (bartleAnswerToggles[i].isOn == true)
                    {
                        bartleAnswer[0] = i + 1; // store user's previous answer as per 1-2 range
                        i = 2; // exit loop
                    }
                }
                // store user's final answer in list
                bartleAnswersList.Add(bartleAnswer[0]);

                // calculate outcome of Bartle test
                string userAnswers = "";
                for (int i = 0; i < 39; i++)
                {
                    userAnswers = userAnswers + bartleAnswersList[i].ToString();
                }
                // Socializer
                socializerScore = getBartleScore(0, 1) + getBartleScore(1, 2) + getBartleScore(2, 1) + getBartleScore(3, 2) + getBartleScore(4, 1) + getBartleScore(5, 1) + getBartleScore(6, 1) + getBartleScore(7, 1) + getBartleScore(8, 1) + getBartleScore(9, 1) + getBartleScore(10, 1) + getBartleScore(11, 1) + getBartleScore(12, 1) + getBartleScore(13, 2) + getBartleScore(14, 1) + getBartleScore(15, 1) + getBartleScore(16, 2) + getBartleScore(17, 2) + getBartleScore(18, 2) + getBartleScore(19, 1);
                // Achiever
                achieverScore = getBartleScore(0, 2) + getBartleScore(1, 1) + getBartleScore(2, 2) + getBartleScore(3, 1) + getBartleScore(4, 2) + getBartleScore(5, 2) + getBartleScore(6, 2) + getBartleScore(20, 2) + getBartleScore(21, 2) + getBartleScore(22, 1) + getBartleScore(23, 2) + getBartleScore(24, 2) + getBartleScore(25, 2) + getBartleScore(33, 1) + getBartleScore(34, 2) + getBartleScore(35, 2) + getBartleScore(36, 1) + getBartleScore(37, 1) + getBartleScore(38, 1);
                // Explorer
                explorerScore = getBartleScore(7, 2) + getBartleScore(8, 2) + getBartleScore(9, 2) + getBartleScore(10, 2) + getBartleScore(11, 2) + getBartleScore(12, 2) + getBartleScore(20, 1) + getBartleScore(21, 1) + getBartleScore(22, 2) + getBartleScore(23, 1) + getBartleScore(24, 1) + getBartleScore(25, 1) + getBartleScore(26, 1) + getBartleScore(27, 1) + getBartleScore(28, 1) + getBartleScore(29, 1) + getBartleScore(30, 2) + getBartleScore(31, 1) + getBartleScore(32, 1);
                // Killer
                killerScore = getBartleScore(13, 1) + getBartleScore(14, 2) + getBartleScore(15, 2) + getBartleScore(16, 1) + getBartleScore(17, 1) + getBartleScore(18, 1) + getBartleScore(19, 2) + getBartleScore(26, 2) + getBartleScore(27, 2) + getBartleScore(28, 2) + getBartleScore(29, 2) + getBartleScore(30, 1) + getBartleScore(31, 2) + getBartleScore(32, 2) + getBartleScore(33, 2) + getBartleScore(34, 1) + getBartleScore(35, 1) + getBartleScore(36, 2) + getBartleScore(37, 2) + getBartleScore(38, 2);

                // write player outcomes to database
                userForm = new WWWForm();
                userForm.AddField("playerRawPost", userAnswers);
                userForm.AddField("socializerPost", socializerScore);
                userForm.AddField("achieverPost", achieverScore);
                userForm.AddField("explorerPost", explorerScore);
                userForm.AddField("killerPost", killerScore);
                userForm.AddField("namePost", newUsername);
                userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updatePlayer.php", userForm);
                // call next test
            }
            else
            {
                quitPleaseGiveFeedbackScreen.gameObject.SetActive(false);
            }

            StartCoroutine(loadPretest(num, preTest));
        }
        
    }
    // ==========================

    // FUNCTION
    // GET BARTLE SCORE
    // ==========================
    int getBartleScore(int question, int answer)
    {
        int score = 0;
        if (bartleAnswersList[question] == answer) // checks for answer in 1-2 range
        {
            score = 1;
        }
        return score;
    }
    // ==========================

    // FUNCTION
    // LOAD PRETEST
    // ==========================
    IEnumerator loadPretest(int set, bool prior)
    {
        startNewGameScreen.gameObject.SetActive(false);
        endGameStartFeedbackScreen.gameObject.SetActive(false);
        factorFiveScreen.SetActive(false);
        bartleScreen.gameObject.SetActive(false);
        knowledgeTestScreen.gameObject.SetActive(true);
        submitKnowledgeButton.gameObject.SetActive(false); // turn off until user has answered question
        if (set > 0)
        {
           knowledgeAnswers[set - 1] = knowledgeAnswerInput.text; // get user's previous answer
           knowledgeText.gameObject.SetActive(true); // activate question
        }

        // set number for progress e.g. set 2/6
        int number = set + 1;
        knowledgeNumberText.text = "(" + number.ToString() + "/6)";

        knowledgeAnswerInput.text = ""; // reset input field
        knowledgeText.text = knowledgeQuestions[set];

        submitKnowledgeButton.onClick.RemoveAllListeners();
        yield return new WaitUntil(() => knowledgeAnswerInput.text != ""); // only activate submit button when question has been answered

        if (set != 5)
        {
            submitKnowledgeButton.gameObject.SetActive(true);
            submitKnowledgeButton.onClick.AddListener(() => this.WrapperLoadPretest(set + 1, prior)); // load next question
        }
        else
        {
            submitKnowledgeButton.gameObject.SetActive(true);

            if (prior)
            {
                submitKnowledgeButton.onClick.AddListener(() => this.loadIntroScreen(1, true)); // load game intro
            }
            else
            {
                // completed post-test
                submitKnowledgeButton.onClick.AddListener(() => this.WrapperLoadFeedback()); // load feedback screen
            }
        }
    }
    // ==========================

    // FUNCTION
    // WRAPPER LOAD FEEDBACK SCREEN
    // ===========================
        void WrapperLoadFeedback()
    {
        StartCoroutine(loadFeedback());
    }
    // ===========================

    // FUNCTION
    // LOAD FEEDBACK SCREEN
    // ===========================
    IEnumerator loadFeedback ()
    {
        // store player's final knowledge test answer
        knowledgeAnswers[5] = knowledgeAnswerInput.text; // get user's previous answer
        // write the results of the pretest to the database
        userForm = new WWWForm();
        userForm.AddField("question1Post", knowledgeAnswers[0]);
        userForm.AddField("question2Post", knowledgeAnswers[1]);
        userForm.AddField("question3Post", knowledgeAnswers[2]);
        userForm.AddField("question4Post", knowledgeAnswers[3]);
        userForm.AddField("question5Post", knowledgeAnswers[4]);
        userForm.AddField("question6Post", knowledgeAnswers[5]);
        userForm.AddField("namePost", newUsername);
        userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updatePosttest.php", userForm);
        knowledgeTestScreen.gameObject.SetActive(false);
        feedbackScreen.gameObject.SetActive(true);
        
        submitFeedbackButton.gameObject.SetActive(false);
        submitFeedbackButton.onClick.RemoveAllListeners();
        yield return new WaitUntil(() => feedbackInputs[0].text != "" && feedbackInputs[1].text != "" && feedbackInputs[2].text != ""); // only activate submit button when question has been answered
        submitFeedbackButton.gameObject.SetActive(true);
        submitFeedbackButton.onClick.AddListener(() => this.finishGame());
    }
    // ===========================

    // FUNCTION
    // FINISH SCREEN
    // ===========================
    void finishGame()
    {
        knowledgeTestScreen.gameObject.SetActive(false);
        feedbackScreen.gameObject.SetActive(false);
        endDemoScreen.gameObject.SetActive(true);

        // write the results of the feedback to the database
        userForm = new WWWForm();
        userForm.AddField("question1Post", feedbackInputs[0].text);
        userForm.AddField("question2Post", feedbackInputs[1].text);
        userForm.AddField("question3Post", feedbackInputs[2].text);
        userForm.AddField("namePost", newUsername);
        userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateFeedback.php", userForm);

        endDemoQuitButton.gameObject.SetActive(true);
        endDemoQuitButton.onClick.RemoveAllListeners();
        endDemoQuitButton.onClick.AddListener(() => Application.Quit());
    }
    // ===========================


    // FUNCTION
    // LOAD INTRO SCREEN
    // ===========================
    void loadIntroScreen(int piece, bool firstEntry){
        if (firstEntry)
        {
            // store player's final knowledge test answer
            knowledgeAnswers[5] = knowledgeAnswerInput.text; // get user's previous answer

            // write the results of the pretest to the database
            userForm = new WWWForm();
            userForm.AddField("question1Post", knowledgeAnswers[0]);
            userForm.AddField("question2Post", knowledgeAnswers[1]);
            userForm.AddField("question3Post", knowledgeAnswers[2]);
            userForm.AddField("question4Post", knowledgeAnswers[3]);
            userForm.AddField("question5Post", knowledgeAnswers[4]);
            userForm.AddField("question6Post", knowledgeAnswers[5]);
            userForm.AddField("namePost", newUsername);
            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updatePretest.php", userForm);
        }

        knowledgeTestScreen.SetActive(false);
		introScreen.SetActive (true);

		currentCash = startingCash; // initialise to starting cash value
		companyEmployees = consLifeStartEmployees;
		colonyEmployees = consLifeStartEmployees * 2 + buildStartEmployees + researchStartEmployees + techStartEmployees;

		introHeadingText.gameObject.SetActive (true);
		startGameAfterIntroButton.gameObject.SetActive (false);

		if (piece == 1) {
			// the landing
			introLandingText.gameObject.SetActive (true);
			introEncounterText.gameObject.SetActive (false);
			introColonyText.gameObject.SetActive (false);
			introHomeText.gameObject.SetActive (false);
			introAimText.gameObject.SetActive (false);
			introHeadingText.text = "THE LANDING";

			introLandingImage.gameObject.SetActive (true);
			introEncounterImage.gameObject.SetActive (false);
			introColonyImage.gameObject.SetActive (false);
			introHomeImage.gameObject.SetActive (false);
			introAimImage.gameObject.SetActive (false);

			// previous piece and next piece buttons
			previousIntroPieceButton.gameObject.SetActive(false);

			nextIntroPieceButton.gameObject.SetActive (true);
			nextIntroPieceButton.onClick.RemoveAllListeners();
			nextIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (2, false));
		} else if (piece == 2) {
			// a first encounter
			introLandingText.gameObject.SetActive (false);
			introEncounterText.gameObject.SetActive (true);
			introColonyText.gameObject.SetActive (false);
			introHomeText.gameObject.SetActive (false);
			introAimText.gameObject.SetActive (false);
			introHeadingText.text = "A FIRST ENCOUNTER";

			introLandingImage.gameObject.SetActive (false);
			introEncounterImage.gameObject.SetActive (true);
			introColonyImage.gameObject.SetActive (false);
			introHomeImage.gameObject.SetActive (false);
			introAimImage.gameObject.SetActive (false);

			// previous piece and next piece buttons
			previousIntroPieceButton.gameObject.SetActive(true);
			previousIntroPieceButton.onClick.RemoveAllListeners ();
			previousIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (1, false));

			nextIntroPieceButton.onClick.RemoveAllListeners();
			nextIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (3, false));
		} else if (piece == 3) {
			// the new colony
			introLandingText.gameObject.SetActive (false);
			introEncounterText.gameObject.SetActive (false);
			introColonyText.gameObject.SetActive (true);
			introHomeText.gameObject.SetActive (false);
			introAimText.gameObject.SetActive (false);
			introHeadingText.text = "THE NEW COLONY";

			introLandingImage.gameObject.SetActive (false);
			introEncounterImage.gameObject.SetActive (false);
			introColonyImage.gameObject.SetActive (true);
			introHomeImage.gameObject.SetActive (false);
			introAimImage.gameObject.SetActive (false);

			previousIntroPieceButton.onClick.RemoveAllListeners ();
			previousIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (2, false));

			nextIntroPieceButton.onClick.RemoveAllListeners();
			nextIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (4, false));
		} else if (piece == 4) {
			// your new home
			introLandingText.gameObject.SetActive (false);
			introEncounterText.gameObject.SetActive (false);
			introColonyText.gameObject.SetActive (false);
			introHomeText.gameObject.SetActive (true);
			introAimText.gameObject.SetActive (false);
			introHeadingText.text = "YOUR NEW HOME";

			introLandingImage.gameObject.SetActive (false);
			introEncounterImage.gameObject.SetActive (false);
			introColonyImage.gameObject.SetActive (true);
			introHomeImage.gameObject.SetActive (true);
			introAimImage.gameObject.SetActive (false);

			previousIntroPieceButton.onClick.RemoveAllListeners ();
			previousIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (3, false));

			nextIntroPieceButton.gameObject.SetActive(true); // re-activate incase you came back from final intro piece where it was disabled
			nextIntroPieceButton.onClick.RemoveAllListeners();
			nextIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (5, false));
		}else {
			// your aim
			introLandingText.gameObject.SetActive (false);
			introEncounterText.gameObject.SetActive (false);
			introColonyText.gameObject.SetActive (false);
			introHomeText.gameObject.SetActive (false);
			introAimText.gameObject.SetActive (true);
			introHeadingText.text = "YOUR AIM";

			introLandingImage.gameObject.SetActive (false);
			introEncounterImage.gameObject.SetActive (false);
			introColonyImage.gameObject.SetActive (false);
			introHomeImage.gameObject.SetActive (false);
			introAimImage.gameObject.SetActive (true);

			// deactivate next button (last piece)
			nextIntroPieceButton.gameObject.SetActive(false);
			previousIntroPieceButton.onClick.RemoveAllListeners ();
			previousIntroPieceButton.onClick.AddListener (() => this.loadIntroScreen (4, false));

			// activate start game button only once reached final intro piece
			startGameAfterIntroButton.gameObject.SetActive (true);
			startGameAfterIntroButton.onClick.RemoveAllListeners ();
			startGameAfterIntroButton.onClick.AddListener (() => this.loadGame ());
		}
	}
    // ===========================

    // FUNCTION
    // LOAD GAME
    // ===========================
    void loadGame()
    {
        mainCamera.gameObject.SetActive(false); // turn off main camera
        astronaut.SetActive(true); // turn on player (with player cam)
        quitGameButton.gameObject.SetActive(true);
        startGameScreen.SetActive(false);
        startNewGameScreen.SetActive(false);
        loadGameScreen.SetActive(false);

        introScreen.SetActive(false);
        environment.SetActive(true);
        gameFeed.SetActive(true);
        this.WrapperAddGameFeed("You've arrived at your new home!",true);
        
        introIconOeger.SetActive(true);
    }
    // ===========================

    // FUNCTION
    // LOAD COMPANY CHOICE SCREEN
    // ===========================
    void loadCompanyChoiceScreen(int choice){
		oeger.SetActive (false);
		gameFeed.SetActive (false);
        gameTipScreen.SetActive(false);
		chooseCompanyScreen.SetActive (true);

        companyHeadingText.gameObject.SetActive (true);
		companyCostText.gameObject.SetActive (true);
		companyYourCurrentCashText.text = startingCash.ToString();

		if (choice == 1) {
			// consumables
			companyConsumablesText.gameObject.SetActive (true);
			companyLifestyleText.gameObject.SetActive (false);
			companyBuildingText.gameObject.SetActive (false);
			companyResearchText.gameObject.SetActive (false);
			companyTechText.gameObject.SetActive (false);
			companyHeadingText.text = "CONSUMABLES PROVIDER (1/5)";
			companyCostText.text = "500";

			companyConsumablesImage.gameObject.SetActive (true);
			companyLifestyleImage.gameObject.SetActive (false);
			companyBuildingImageLocked.gameObject.SetActive (false);
			companyResearchImageLocked.gameObject.SetActive (false);
			companyTechImageLocked.gameObject.SetActive (false);

			selectCompanyButton.gameObject.SetActive (true);

			// previous piece and next piece buttons
			previousCompanyButton.gameObject.SetActive(false);

			nextCompanyButton.gameObject.SetActive (true);
			nextCompanyButton.onClick.RemoveAllListeners();
			nextCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (2));

		} else if (choice == 2) {
			// lifestyle goods
			companyConsumablesText.gameObject.SetActive (false);
			companyLifestyleText.gameObject.SetActive (true);
			companyBuildingText.gameObject.SetActive (false);
			companyResearchText.gameObject.SetActive (false);
			companyTechText.gameObject.SetActive (false);
			companyHeadingText.text = "LIFESTYLE GOODS PROVIDER (2/5)";
			companyCostText.text = "500";

			companyConsumablesImage.gameObject.SetActive (false);
			companyLifestyleImage.gameObject.SetActive (true);
			companyBuildingImageLocked.gameObject.SetActive (false);
			companyResearchImageLocked.gameObject.SetActive (false);
			companyTechImageLocked.gameObject.SetActive (false);

			selectCompanyButton.gameObject.SetActive (true);
			
			// previous piece and next piece buttons
			previousCompanyButton.gameObject.SetActive(true);
			previousCompanyButton.onClick.RemoveAllListeners ();
			previousCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (1));

			nextCompanyButton.onClick.RemoveAllListeners();
			nextCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (3));
		} else if (choice == 3) {
			// building contractor
			companyConsumablesText.gameObject.SetActive (false);
			companyLifestyleText.gameObject.SetActive (false);
			companyBuildingText.gameObject.SetActive (true);
			companyResearchText.gameObject.SetActive (false);
			companyTechText.gameObject.SetActive (false);
			companyHeadingText.text = "BUILDING CONTRACTOR (3/5)";
			companyCostText.text = "1500";

			companyConsumablesImage.gameObject.SetActive (false);
			companyLifestyleImage.gameObject.SetActive (false);
			companyBuildingImageLocked.gameObject.SetActive (true);
			companyResearchImageLocked.gameObject.SetActive (false);
			companyTechImageLocked.gameObject.SetActive (false);

			selectCompanyButton.gameObject.SetActive (false);

			previousCompanyButton.onClick.RemoveAllListeners ();
			previousCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (2));

			nextCompanyButton.onClick.RemoveAllListeners();
			nextCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (4));
		} else if (choice == 4) {
			// research lab
			companyConsumablesText.gameObject.SetActive (false);
			companyLifestyleText.gameObject.SetActive (false);
			companyBuildingText.gameObject.SetActive (false);
			companyResearchText.gameObject.SetActive (true);
			companyTechText.gameObject.SetActive (false);
			companyHeadingText.text = "RESEARCH LAB (4/5)";
			companyCostText.text = "3000";

			companyConsumablesImage.gameObject.SetActive (false);
			companyLifestyleImage.gameObject.SetActive (false);
			companyBuildingImageLocked.gameObject.SetActive (false);
			companyResearchImageLocked.gameObject.SetActive (true);
			companyTechImageLocked.gameObject.SetActive (false);

			selectCompanyButton.gameObject.SetActive (false);

			previousCompanyButton.onClick.RemoveAllListeners ();
			previousCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (3));

			nextCompanyButton.gameObject.SetActive(true); // re-activate incase you came back from final intro piece where it was disabled
			nextCompanyButton.onClick.RemoveAllListeners();
			nextCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (5));
		}else {
			// tech company
			companyConsumablesText.gameObject.SetActive (false);
			companyLifestyleText.gameObject.SetActive (false);
			companyBuildingText.gameObject.SetActive (false);
			companyResearchText.gameObject.SetActive (false);
			companyTechText.gameObject.SetActive (true);
			companyHeadingText.text = "TECH COMPANY (5/5)";
			companyCostText.text = "4000";

			companyConsumablesImage.gameObject.SetActive (false);
			companyLifestyleImage.gameObject.SetActive (false);
			companyBuildingImageLocked.gameObject.SetActive (false);
			companyResearchImageLocked.gameObject.SetActive (false);
			companyTechImageLocked.gameObject.SetActive (true);

			selectCompanyButton.gameObject.SetActive (false);

			// deactivate next button (last piece)
			nextCompanyButton.gameObject.SetActive(false);
			previousCompanyButton.onClick.RemoveAllListeners ();
			previousCompanyButton.onClick.AddListener (() => this.loadCompanyChoiceScreen (4));
	}
		selectCompanyButton.onClick.RemoveAllListeners ();
		selectCompanyButton.onClick.AddListener(()=>this.loadChooseLocationScreen(choice, 1, true));
	} 
    // ===========================

    // FUNCTION
    // LOAD CHOOSE LOCATION SCREEN
    // ===========================
    void loadChooseLocationScreen (int company, int choice, bool firstEntry){
		chooseCompanyScreen.SetActive (false);
		chooseLocationScreen.SetActive (true);

		companyChoice = company;

		if(firstEntry){ // only deduct once
			if (companyChoice == 1 || companyChoice == 2) { // adjust money - i.e. decrease by company cost
				currentCash = currentCash - 500;
			} else if (companyChoice == 3) {
				currentCash = currentCash - 1500;
			} else if (companyChoice == 4) {
				currentCash = currentCash - 3000;
			} else {
				currentCash = currentCash - 4000;
			}
            startingCash = currentCash; // change basis for reloading of levers
		}

		locationYourCurrentCashText.text = currentCash.ToString ();

		locationHeadingText.gameObject.SetActive (true);
		locationCostText.gameObject.SetActive (true);
		selectLocationButton.gameObject.SetActive (true);

		if (choice == 1) {
			// easy access location
			locationEasyAccessText.gameObject.SetActive (true);
			locationEasyAccess2Text.gameObject.SetActive (false);
			locationSecludedText.gameObject.SetActive (false);
			locationResourcesText.gameObject.SetActive (false);
			locationResources2Text.gameObject.SetActive (false);
			locationCentralText.gameObject.SetActive (false);
			locationHeadingText.text = "EASY ACCESS";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (true);
			locationEasyAccess2Image.gameObject.SetActive (false);
			locationSecludedImage.gameObject.SetActive (false);
			locationResourcesImage.gameObject.SetActive (false);
			locationResources2Image.gameObject.SetActive (false);
			locationCentralImage.gameObject.SetActive (false);

			// previous piece and next piece buttons
			previousLocationButton.gameObject.SetActive(false);

			nextLocationButton.gameObject.SetActive (true);
			nextLocationButton.onClick.RemoveAllListeners();
			nextLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 2, false));
		} else if (choice == 2) {
			// easy access2 location
			locationEasyAccessText.gameObject.SetActive (false);
			locationEasyAccess2Text.gameObject.SetActive (true);
			locationSecludedText.gameObject.SetActive (false);
			locationResourcesText.gameObject.SetActive (false);
			locationResources2Text.gameObject.SetActive (false);
			locationCentralText.gameObject.SetActive (false);
			locationHeadingText.text = "EASY ACCESS";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (false);
			locationEasyAccess2Image.gameObject.SetActive (true);
			locationSecludedImage.gameObject.SetActive (false);
			locationResourcesImage.gameObject.SetActive (false);
			locationResources2Image.gameObject.SetActive (false);
			locationCentralImage.gameObject.SetActive (false);

			// previous piece and next piece buttons
			previousLocationButton.gameObject.SetActive(true);
			previousLocationButton.onClick.RemoveAllListeners ();
			previousLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 1, false));

			nextLocationButton.onClick.RemoveAllListeners();
			nextLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 3, false));
		} else if (choice == 3) {
			// secluded location
			locationEasyAccessText.gameObject.SetActive (false);
			locationEasyAccess2Text.gameObject.SetActive (false);
			locationSecludedText.gameObject.SetActive (true);
			locationResourcesText.gameObject.SetActive (false);
			locationResources2Text.gameObject.SetActive (false);
			locationCentralText.gameObject.SetActive (false);
			locationHeadingText.text = "SECLUDED";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (false);
			locationEasyAccess2Image.gameObject.SetActive (false);
			locationSecludedImage.gameObject.SetActive (true);
			locationResourcesImage.gameObject.SetActive (false);
			locationResources2Image.gameObject.SetActive (false);
			locationCentralImage.gameObject.SetActive (false);

			previousLocationButton.onClick.RemoveAllListeners ();
			previousLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 2, false));

			nextLocationButton.onClick.RemoveAllListeners();
			nextLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 4, false));
		} else if (choice == 4) {
			// resources location
			locationEasyAccessText.gameObject.SetActive (false);
			locationEasyAccess2Text.gameObject.SetActive (false);
			locationSecludedText.gameObject.SetActive (false);
			locationResourcesText.gameObject.SetActive (true);
			locationResources2Text.gameObject.SetActive (false);
			locationCentralText.gameObject.SetActive (false);
			locationHeadingText.text = "RESOURCE RICH";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (false);
			locationEasyAccess2Image.gameObject.SetActive (false);
			locationSecludedImage.gameObject.SetActive (false);
			locationResourcesImage.gameObject.SetActive (true);
			locationResources2Image.gameObject.SetActive (false);
			locationCentralImage.gameObject.SetActive (false);

			previousLocationButton.onClick.RemoveAllListeners ();
			previousLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 3, false));

			nextLocationButton.onClick.RemoveAllListeners();
			nextLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 5, false));
		} else if (choice == 5) {
			// resources2 location
			locationEasyAccessText.gameObject.SetActive (false);
			locationEasyAccess2Text.gameObject.SetActive (false);
			locationSecludedText.gameObject.SetActive (false);
			locationResourcesText.gameObject.SetActive (false);
			locationResources2Text.gameObject.SetActive (true);
			locationCentralText.gameObject.SetActive (false);
			locationHeadingText.text = "RESOURCE RICH";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (false);
			locationEasyAccess2Image.gameObject.SetActive (false);
			locationSecludedImage.gameObject.SetActive (false);
			locationResourcesImage.gameObject.SetActive (false);
			locationResources2Image.gameObject.SetActive (true);
			locationCentralImage.gameObject.SetActive (false);

			previousLocationButton.onClick.RemoveAllListeners ();
			previousLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 4, false));

			nextLocationButton.gameObject.SetActive(true); // re-activate incase you came back from final intro piece where it was disabled
			nextLocationButton.onClick.RemoveAllListeners();
			nextLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 6, false));
		} else {
			// central location
			locationEasyAccessText.gameObject.SetActive (false);
			locationEasyAccess2Text.gameObject.SetActive (false);
			locationSecludedText.gameObject.SetActive (false);
			locationResourcesText.gameObject.SetActive (false);
			locationResources2Text.gameObject.SetActive (false);
			locationCentralText.gameObject.SetActive (true);
			locationHeadingText.text = "CENTRAL HUB";
			locationCostText.text = "300";

			locationEasyAccessImage.gameObject.SetActive (false);
			locationEasyAccess2Image.gameObject.SetActive (false);
			locationSecludedImage.gameObject.SetActive (false);
			locationResourcesImage.gameObject.SetActive (false);
			locationResources2Image.gameObject.SetActive (false);
			locationCentralImage.gameObject.SetActive (true);

			// deactivate next button (last piece)
			nextLocationButton.gameObject.SetActive(false);
			previousLocationButton.onClick.RemoveAllListeners ();
			previousLocationButton.onClick.AddListener (() => this.loadChooseLocationScreen (companyChoice, 5, false));
		}
		selectLocationButton.onClick.RemoveAllListeners ();
		selectLocationButton.onClick.AddListener(()=> this.WrapperActivateCompanies(choice));
	}
    // ===========================

    // FUNCTION
    // WRAPPER ACTIVATE COMPANIES
    // ===========================
    void WrapperActivateCompanies(int location){
        paused = false;
        astronaut.SetActive(false); // disable the player
        mainCamera.gameObject.SetActive(true); // activate the main camera
		StartCoroutine (activateCompanies (location));
	}
    // ===========================

    // FUNCTION 
    // ACTIVATE COMPANIES
    // ===========================
    IEnumerator activateCompanies(int location){
        paused = false;
		locationChoice = location;
        
        this.addCompanyAndLocation(); // update database with user choice of company and location
		chooseLocationScreen.SetActive (false);
		gameFeed.SetActive (true);

		currentCash = currentCash - 300; // price of all locations is the same

		// activate actual cash display in gameplay
		cashEmpty.SetActive(true);
		gameplayCash.text = currentCash.ToString();

        // set to user's choice of location
        companyBuildings[companyChoice - 1].transform.position = companyLocations[locationChoice - 1];
        buildEffects[companyChoice - 1].transform.position = companyLocations[locationChoice - 1];
        companyBuildingIcons[companyChoice - 1].transform.position = new Vector3(companyLocations[locationChoice - 1].x, 145.0f, companyLocations[locationChoice - 1].z);

        // start construction of user's company
        buildEffects[companyChoice - 1].gameObject.SetActive(true);
        constructionSoundsAudioSource[companyChoice - 1].Play();

        yield return new WaitForSeconds(3);
        buildEffects[companyChoice - 1].gameObject.SetActive(false);
        
        // activate user's choice of company with player icon
        companyBuildings[companyChoice - 1].SetActive(true);
        companyBuildingIcons[companyChoice - 1].SetActive(true);
		
        //buildingAudioSource.Play ();

        this.WrapperAddGameFeed("Check out your new business",false);

		yield return new WaitForSeconds (2);

		this.WrapperAddGameFeed("It seems there are a few more getting started",false);

		// activate remaining companies
		int j  = 0;
        float randomWait;
		for (int i = 0; i < companyBuildings.Length; i++) {
			if (i != companyChoice - 1) {

                if (j != locationChoice - 1)
                {
                    companyBuildings[i].transform.position = companyLocations[j];
                    buildEffects[i].transform.position = companyLocations[j];
                    
                    j = j + 1;
                }
                else
                {
                    j = j + 1;
                    companyBuildings[i].transform.position = companyLocations[j];
                    buildEffects[i].transform.position = companyLocations[j];
                    j = j + 1;
                }
                
                buildEffects[i].gameObject.SetActive(true);
                constructionSoundsAudioSource[i].Play();

                randomWait = UnityEngine.Random.Range(0.5f, 2);
                yield return new WaitForSeconds(randomWait); // slight delay between remaining companies starting
                buildEffects[i].gameObject.SetActive(false);

                companyBuildings [i].SetActive (true);
                companyBuildingIcons[i].SetActive(false); // set all other "blibs" false - not current user's building
				
				//buildingAudioSource.Play ();
				//randomWait = UnityEngine.Random.Range (0.5f, 2);
				//yield return new WaitForSeconds (randomWait); // slight delay between remaining companies starting
			}
		}
		this.WrapperOegerHelp ("That sounds like Enzer! I wonder what he wants from you...", "Let's hear him out", "", "");
	}
    // ===========================

    // FUNCTION
    // ADD COMPANY AND LOCATION
    // ===========================
    void addCompanyAndLocation()
    {
        userForm = new WWWForm();
        userForm.AddField("companyPost", companyChoice);
        userForm.AddField("locationPost", locationChoice);
        userForm.AddField("namePost", newUsername);
        userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/addCompanyLocation.php", userForm);
    }

    // FUNCTION
    // WRAPPER OEGER HELP
    // ===========================
    void WrapperOegerHelp(string tip, string option1, string option2, string option3){
		StartCoroutine (oegerHelp (tip, option1, option2, option3));
	}
    // ===========================

    // FUNCTION
    // OEGER HELP
    // ===========================
    IEnumerator oegerHelp(string tip, string option1, string option2, string option3) {
        yield return new WaitForSeconds(1.0f);

        levelSummaryScreen.SetActive(false);
        oeger.SetActive(true);

        for (int i = 0; i < oegerButtons.Length; i++) {
            oegerButtons[i].gameObject.SetActive(true);
        }
        oegerTipText.text = tip;
        oegerButtonTexts[0].text = option1;
        oegerButtonTexts[1].text = option2;
        oegerButtonTexts[2].text = option3;

        if (tip == "Hello. The first companies are being built. It's time to start your own empire.") {
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.loadCompanyChoiceScreen(1));
        } else if (tip == "That sounds like Enzer! I wonder what he wants from you...") {
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.WrapperLoadLevelAim(1));
        } else if (tip == "I hope you're up to the challenge! We're all depending on you. What do you think we should do, you haven't got enough crystals for 12 months?") {
            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();
            oegerButtons[2].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false)); // lever2 reserved for tax check
            oegerButtons[2].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));

            
            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusAimText.text = levelAimGrowth[currentLevel - 1] + "% growth";

           

            

        } else if (tip == "Here is a dashboard that may help you on your journey. Use the settings button on the right to customise what it displays.") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            
            yield return new WaitForSeconds(1.5f);
            oeger.SetActive(false);

            dashboard.SetActive(true);
            toolTipDashboard.SetActive(true);
            toolTipDashboardButton.onClick.RemoveAllListeners();
            toolTipDashboardButton.onClick.AddListener(() => this.WrapperCloseToolTip(6));
            yield return new WaitWhile(toolTipDashboardButton.IsActive);

        } else if (tip == "Hey, that seemed easy. Let's make sure you know what you're doing before Enzer comes back. Try again, this time to achieve a 3.5% growth.") {
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            levelStatusAimText.text = "3.5% growth"; // only for tax check level

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 2, true)); // if checking tax - lever 2
        } else if (tip == "Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! Which do you want to try?") {
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();
            levelStatusAimText.text = "4% growth";

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
        } else if (tip == "Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! I would suggest harvesting some crystals.") {
            recommendationGiven = true;
            recommendedLever = 4; // used to check if recommendation followed indirectly
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperOegerHelp("", "Harvest more crystals", "Increase tax", ""));
        } else if (tip == "I think I've got this figured out. Need some help?") {
            oegerButtons[2].gameObject.SetActive(false);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++) {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            if (currentLever == 1 || currentLever == 2) { // tax
                helpTaxGiven = 1;
                oegerButtons[0].onClick.AddListener(() => this.WrapperOegerHelp("If the tax rate is too high, companies lose too much of their profits and have to cut salaries or close down. But if it's too low, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground.", "Ok, let me try again", "", ""));
            } else if (currentLever == 3) { // borrow
                helpBorrowGiven = 1;
                oegerButtons[0].onClick.AddListener(() => this.WrapperOegerHelp("If the loan is too high, the colony can't repay it and your resource costs increase. But if it's too low, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground.", "Ok, let me try again", "", ""));
            } else { // harvest
                helpHarvestGiven = 1;
                oegerButtons[0].onClick.AddListener(() => this.WrapperOegerHelp("If you harvest too many crystals, everyone has more to spend. This means that companies can charge more for products because people have more money, until eventually they can't afford the prices. But if you harvest too little, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground.", "Ok, let me try again", "", ""));
            }
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, currentLever, true));
        } else if (tip == "If the tax rate is too high, companies lose too much of their profits and have to cut salaries or close down. But if it's too low, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground." || tip == "If the loan is too high, the colony can't repay it and your resource costs increase. But if it's too low, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground." || tip == "If you harvest too many crystals, everyone has more to spend. This means that companies can charge more for products because people have more money, until eventually they can't afford the prices. But if you harvest too little, Enzer won't have money to invest in new infrastructure so production costs increase. You need to find some middle ground.") {
            oegerTipText.text = "";
            oegerLevelTipText.text = tip;

            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            if (currentLever == 1 || currentLever == 2) {
                helpTaxTaken = 1;
            } else if (currentLever == 3) {
                helpBorrowTaken = 1;
            } else {
                helpHarvestTaken = 1;
            }

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, currentLever, true));
        } else if (tip == "Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! I would suggest borrowing some crystals from us.") {
            recommendationGiven = true;
            recommendedLever = 3; // used to check if recommendation followed indirectly
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperOegerHelp("", "Borrow crystals from you", "Increase tax", ""));
        } else if (tip == "") {
            recommendationFollowedDirectly = false; // did not take recommendation without even looking at options
            oegerButtons[1].gameObject.SetActive(false); // first set to false so that isn't selected
            oegerButtons[0].gameObject.SetActive(true);
            oegerButtons[1].gameObject.SetActive(true);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            if (recommendedLever == 3) {
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            } else {
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
            }
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
        } else if (tip == "Good job! Let's see if you can get the hang of the last one too!") {
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            if (!leversCompleted.Contains(1)) {
                // only tax remains
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            } else if (!leversCompleted.Contains(3)) {
                // only borrow remains
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            } else {
                // only harvest remains
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
            }
        } else if (tip == "Your colony is bankrupt! Growth is sub-zero..."){
            
            oegerButtons[0].gameObject.SetActive(true);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            oegerButtons[0].onClick.RemoveAllListeners();
            
            oegerButtons[0].onClick.AddListener(() => this.displayLevelSummary());
            yield return new WaitForSeconds(3.0f);
            yield return new WaitWhile(oegerButtons[0].IsActive);

        } else if (tip == "That sounds daunting! But you seem to be in the swing of things! You select your weapon of choice, and I'll do the rest!"){
			oegerButtons [0].onClick.RemoveAllListeners ();
			oegerButtons [1].onClick.RemoveAllListeners ();
			oegerButtons [2].onClick.RemoveAllListeners ();
			oegerButtons [0].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 1, false));
			oegerButtons [1].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 3, false)); // lever2 reserved for tax check
			oegerButtons [2].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 4, false));

			companyStatusEmpty.SetActive (true);
			colonyStatusEmpty.SetActive (true);
			levelStatusEmpty.SetActive (true);

			// RESET VARIABLES AS THEY WERE AT START OF LEVEL
			slider1.value = 0.0f;
			slider2.value = 0.0f;
			currentCash = yourStartingCash;
			companyCrystalsIn = 0;
			companyCrystalsOut = 0;
			companyProfits = 0.0f;
			companyEmployeeHealth = 100;

			costProportion = 1.0f;
			incomeProportion = 1.0f;

			randomEvent1Month = new int[0];
			randomEvent2Month = new int[0];
			randomEvent3Month = new int[0];
			randomEvent4Month = new int[0];
			randomEvent5Month = new int[0];
			randomEvent6Month = new int[0];
			randomEvent7Month = new int[0];
			randomEvent8Month = new int[0];

			colonyValue = colonyStartingCash;
			colonyCrystalsIn = 0;
			colonyCrystalOut = 0;
			colonyProfits = 0.0f;
			colonyGrowth = 0.0f;
			colonyCompanies = colonyStartingCompanies;
			colonyEmployees = colonyStartingEmployees;
			colonyEmployeeHealth = 100;

			companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
			companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
			companyStatusProfitsText.text = companyProfits.ToString ();
			companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
			companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

			colonyStatusValueText.text = colonyValue.ToString ();
			colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
			colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
			colonyStatusProfitsText.text = colonyProfits.ToString ();
			colonyStatusGrowthText.text = colonyGrowth.ToString ();
			colonyStatusCompaniesText.text = colonyCompanies.ToString ();
			colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
			colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

			levelStatusStatusText.text = "0";

		}
        // FAILS SECOND LT LEVER - ONLY 1 REMAINS
        else if (tip == "Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything. Try the last one.")
        {
            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();

            
            if (!leversAttempted.Contains(5))
            {
                // tax still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            }
            else
            {
                // harvest still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));

            }

        } else if(tip == "It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices. Try the last one.")
        {

            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();

           
            if (!leversAttempted.Contains(5))
            {
                // tax still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            }
            else
            {
                // borrow still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));

            }
        } else if(tip == "Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close. Try the last one.")
        {

            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();

            
            if (!leversAttempted.Contains(6))
            {
                // borrow still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            }
            else
            {
                // harvest still outstanding
                oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));

            }
        } 
        // HAS ATTEMPTED 1 LT LEVER - 2 REMAIN
        else if (tip == "Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close. Maybe try another...")
        {
            // TAX COMPLETED - BORROW AND HARVEST REMAIN
            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }
            
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));

        } else if(tip == "Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything. Maybe try another...")
        {
            // BORROW COMPLETED - TAX AND HARVEST REMAIN
            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));

        }
        else if(tip == "It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices. Maybe try another...")
        {
            // HARVEST COMPLETED - TAX AND BORROW REMAIN
            colonyStatusEmpty.SetActive(true);
            levelStatusEmpty.SetActive(true);

            // RESET VARIABLES AS THEY WERE AT START OF LEVEL
            slider1.value = 0.0f;
            slider2.value = 0.0f;
            currentCash = yourStartingCash;
            companyCrystalsIn = 0;
            companyCrystalsOut = 0;
            companyProfits = 0.0f;
            companyEmployeeHealth = 100;

            costProportion = 1.0f;
            incomeProportion = 1.0f;

            randomEvent1Month = new int[0];
            randomEvent2Month = new int[0];
            randomEvent3Month = new int[0];
            randomEvent4Month = new int[0];
            randomEvent5Month = new int[0];
            randomEvent6Month = new int[0];
            randomEvent7Month = new int[0];
            randomEvent8Month = new int[0];

            colonyValue = colonyStartingCash;
            colonyCrystalsIn = 0;
            colonyCrystalOut = 0;
            colonyProfits = 0.0f;
            colonyGrowth = 0.0f;
            colonyCompanies = colonyStartingCompanies;
            colonyEmployees = colonyStartingEmployees;
            colonyEmployeeHealth = 100;

            companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
            companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
            companyStatusProfitsText.text = companyProfits.ToString();
            companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
            companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

            colonyStatusValueText.text = colonyValue.ToString();
            colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
            colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
            colonyStatusProfitsText.text = colonyProfits.ToString();
            colonyStatusGrowthText.text = colonyGrowth.ToString();
            colonyStatusCompaniesText.text = colonyCompanies.ToString();
            colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
            colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

            levelStatusStatusText.text = "0";

            for (int i = 0; i < companyBuildings.Length; i++)
            {
                companyBuildings[i].SetActive(true); // re-activate all buildings
            }

            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[1].onClick.RemoveAllListeners();

            oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
            oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
        }
        else if(option1 == "Okay. What now?")
        {
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);

            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.WrapperLoadLevelAim(3));
            }

        else if (tip == "I'm stumped! The last hope lies in the final option. Enzer will be back soon!"){
			companyStatusEmpty.SetActive (true);
			colonyStatusEmpty.SetActive (true);
			levelStatusEmpty.SetActive (true);

			// RESET VARIABLES AS THEY WERE AT START OF LEVEL
			slider1.value = 0.0f;
			slider2.value = 0.0f;
			currentCash = yourStartingCash;
			companyCrystalsIn = 0;
			companyCrystalsOut = 0;
			companyProfits = 0.0f;
			companyEmployeeHealth = 100;

			costProportion = 1.0f;
			incomeProportion = 1.0f;

			randomEvent1Month = new int[0];
			randomEvent2Month = new int[0];
			randomEvent3Month = new int[0];
			randomEvent4Month = new int[0];
			randomEvent5Month = new int[0];
			randomEvent6Month = new int[0];
			randomEvent7Month = new int[0];
			randomEvent8Month = new int[0];

			colonyValue = colonyStartingCash;
			colonyCrystalsIn = 0;
			colonyCrystalOut = 0;
			colonyProfits = 0.0f;
			colonyGrowth = 0.0f;
			colonyCompanies = colonyStartingCompanies;
			colonyEmployees = colonyStartingEmployees;
			colonyEmployeeHealth = 100;

			companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
			companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
			companyStatusProfitsText.text = companyProfits.ToString ();
			companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
			companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

			colonyStatusValueText.text = colonyValue.ToString ();
			colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
			colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
			colonyStatusProfitsText.text = colonyProfits.ToString ();
			colonyStatusGrowthText.text = colonyGrowth.ToString ();
			colonyStatusCompaniesText.text = colonyCompanies.ToString ();
			colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
			colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

			levelStatusStatusText.text = "0";

			for (int i = 0; i < companyBuildings.Length; i++) {
				companyBuildings [i].SetActive (true); // re-activate all buildings
			}

			oegerButtons [1].gameObject.SetActive (false);
			oegerButtons [2].gameObject.SetActive (false);

			oegerButtons[0].onClick.RemoveAllListeners();
			if (!leversAttempted.Contains (5)) {
				// only tax remains
				oegerButtons[0].onClick.AddListener(()=>this.WrapperGameplay(currentLevel, 2, 1, false));
			} else if (!leversAttempted.Contains(6)){
				// only borrow remains
				oegerButtons[0].onClick.AddListener(()=>this.WrapperGameplay(currentLevel, 2, 3, false));
			} else{
				// only harvest remains
				oegerButtons[0].onClick.AddListener(()=>this.WrapperGameplay(currentLevel, 2, 4, false));
			}
		} else if (tip == "This doesn't seem to be working. Maybe try one of the others..."){
			companyStatusEmpty.SetActive (true);
			colonyStatusEmpty.SetActive (true);
			levelStatusEmpty.SetActive (true);

			// RESET VARIABLES AS THEY WERE AT START OF LEVEL
			slider1.value = 0.0f;
			slider2.value = 0.0f;
			currentCash = yourStartingCash;
			companyCrystalsIn = 0;
			companyCrystalsOut = 0;
			companyProfits = 0.0f;
			companyEmployeeHealth = 100;

			costProportion = 1.0f;
			incomeProportion = 1.0f;

			randomEvent1Month = new int[0];
			randomEvent2Month = new int[0];
			randomEvent3Month = new int[0];
			randomEvent4Month = new int[0];
			randomEvent5Month = new int[0];
			randomEvent6Month = new int[0];
			randomEvent7Month = new int[0];
			randomEvent8Month = new int[0];

			colonyValue = colonyStartingCash;
			colonyCrystalsIn = 0;
			colonyCrystalOut = 0;
			colonyProfits = 0.0f;
			colonyGrowth = 0.0f;
			colonyCompanies = colonyStartingCompanies;
			colonyEmployees = colonyStartingEmployees;
			colonyEmployeeHealth = 100;

			companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
			companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
			companyStatusProfitsText.text = companyProfits.ToString ();
			companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
			companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

			colonyStatusValueText.text = colonyValue.ToString ();
			colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
			colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
			colonyStatusProfitsText.text = colonyProfits.ToString ();
			colonyStatusGrowthText.text = colonyGrowth.ToString ();
			colonyStatusCompaniesText.text = colonyCompanies.ToString ();
			colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
			colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

			levelStatusStatusText.text = "0";

			for (int i = 0; i < companyBuildings.Length; i++) {
				companyBuildings [i].SetActive (true); // re-activate all buildings
			}
            
            if(leversAttempted.Count == 5)
            {
                // attempted 1 LT lever
                if (leversAttempted.Contains(5))
                {
                    // only attempted tax
                    oegerButtons[0].onClick.RemoveAllListeners();
                    oegerButtons[1].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
                    oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
                }
                else if (leversAttempted.Contains(6))
                {
                    // only attempted borrow
                    oegerButtons[0].onClick.RemoveAllListeners();
                    oegerButtons[1].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
                    oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
                }
                else
                {
                    // only attempted harvest
                    oegerButtons[0].onClick.RemoveAllListeners();
                    oegerButtons[1].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
                    oegerButtons[1].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
                }

                oegerButtons[2].gameObject.SetActive(false);

            } else if (leversAttempted.Count == 6)
            {
                // attempted 2 LT levers - only 1 left
                if (!leversAttempted.Contains(5))
                {
                    // only tax remains
                    oegerButtons[0].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 1, false));
                }
                else if (!leversAttempted.Contains(6))
                {
                    // only borrow remains
                    oegerButtons[0].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 3, false));
                }
                else
                {
                    // only harvest remains
                    oegerButtons[0].onClick.RemoveAllListeners();

                    oegerButtons[0].onClick.AddListener(() => this.WrapperGameplay(currentLevel, 2, 4, false));
                }

                oegerButtons[1].gameObject.SetActive(false);
                oegerButtons[2].gameObject.SetActive(false);
            }

			
		} else if (tip == "I didn't even think of that! We better get moving. Which combo do you want to try first?"){
			oegerButtons [0].onClick.RemoveAllListeners ();
			oegerButtons [1].onClick.RemoveAllListeners ();
			oegerButtons [2].onClick.RemoveAllListeners ();
			oegerButtons [0].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 8, false));
			oegerButtons [1].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 9, false)); 
			oegerButtons [2].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, 10, false));

			companyStatusEmpty.SetActive (true);
			colonyStatusEmpty.SetActive (true);
			levelStatusEmpty.SetActive (true);

			// RESET VARIABLES AS THEY WERE AT START OF LEVEL
			slider1.value = 0.0f;
			slider2.value = 0.0f;
			currentCash = yourStartingCash;
			companyCrystalsIn = 0;
			companyCrystalsOut = 0;
			companyProfits = 0.0f;
			companyEmployeeHealth = 100;

			costProportion = 1.0f;
			incomeProportion = 1.0f;

			randomEvent1Month = new int[0];
			randomEvent2Month = new int[0];
			randomEvent3Month = new int[0];
			randomEvent4Month = new int[0];
			randomEvent5Month = new int[0];
			randomEvent6Month = new int[0];
			randomEvent7Month = new int[0];
			randomEvent8Month = new int[0];

			colonyValue = colonyStartingCash;
			colonyCrystalsIn = 0;
			colonyCrystalOut = 0;
			colonyProfits = 0.0f;
			colonyGrowth = 0.0f;
			colonyCompanies = colonyStartingCompanies;
			colonyEmployees = colonyStartingEmployees;
			colonyEmployeeHealth = 100;

			companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
			companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
			companyStatusProfitsText.text = companyProfits.ToString ();
			companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
			companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

			colonyStatusValueText.text = colonyValue.ToString ();
			colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
			colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
			colonyStatusProfitsText.text = colonyProfits.ToString ();
			colonyStatusGrowthText.text = colonyGrowth.ToString ();
			colonyStatusCompaniesText.text = colonyCompanies.ToString ();
			colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
			colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

			levelStatusStatusText.text = "0";


		} else if (tip == "Well done! You've succeeded!"){
			oegerButtons [0].gameObject.SetActive (false);
			oegerButtons [1].gameObject.SetActive (false);
			oegerButtons [2].gameObject.SetActive (false);
			yield return new WaitForSeconds (1.5f);

			// end of demo reached
			companyStatusEmpty.SetActive(false);
			colonyStatusEmpty.SetActive (false);
			levelStatusEmpty.SetActive (false);
			gameFeed.SetActive (false);
			dashboard.SetActive (false);
			slider1Empty.SetActive (false);
			slider2Empty.SetActive (false);
			statusLevelGraph.SetActive (false);
            
            if (newHighscore == true)
            {
                Time.timeScale = 0.0f;
                newHighscoreScreen.SetActive(true);
                continueFromNewHighscoreButton.onClick.RemoveAllListeners();
                continueFromNewHighscoreButton.onClick.AddListener(()=> this.continueToEndGameScreen());
            }
            else
            {
                endGameStartFeedbackScreen.SetActive(true);
                Time.timeScale = 0.0f;
                continueToFeedbackButton.onClick.RemoveAllListeners();
                continueToFeedbackButton.onClick.AddListener(() => WrapperLoadPretest(0, false));
            }
			
		} else if (tip == "I think the tax was too high for this company. It seems to be closing down..." || tip == "This company has run out of money. It seems to be closing down...") {
			oegerButtons [0].gameObject.SetActive (false);
			oegerButtons [1].gameObject.SetActive (false);
			oegerButtons [2].gameObject.SetActive (false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("Tax too high! A company has closed down", false);
        } else if (tip == "Enzer has stopped investing in infrastructure! Machine breakdowns are resulting in higher costs...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            
            this.WrapperAddGameFeed("Old infrastructure has increased costs!",false);
		}else if (tip == "Companies are reducing salaries to compensate for high tax rates! The colony is losing spending power...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("Salary cut to compensate tax margins!",false);
		}else if (tip == "The colony can't afford these new high prices! Sales are decreasing...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("Prices are too high. Sales are dropping!",false);
		}else if (tip == "The colony can't repay the loan! Our resource price has increased for you...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("Loan outstanding. Your cost of resources has increased!",false);
		}else if (tip == "Enzer is investing in infrastructure! New machines are reducing your costs...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("New infrastructure has decreased costs!",false);
		}else if (tip == "These lower costs mean more profits and increased salaries. The colony's spending power is increasing...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            oegerButtons[0].onClick.RemoveAllListeners();
            oegerButtons[0].onClick.AddListener(() => this.closeOeger());
            this.WrapperAddGameFeed("Lower costs mean higher profits and increased salaries. The colony has more spending power!",false);
		}else if (tip == "Demand for goods is increasing. Companies are increasing their prices...") {
            oegerButtons[0].gameObject.SetActive(false);
            oegerButtons[1].gameObject.SetActive(false);
            oegerButtons[2].gameObject.SetActive(false);
            yield return new WaitForSeconds(3.0f);
            this.WrapperAddGameFeed("Demand increase. Companies have increased their prices!",false);
		}else if (tip == "Wow, you're pretty good at this! I'm sure Enzer is going to be pleased!") {
			leversCompleted.Add (currentLever); // adds lever completed to the list
			oegerButtons [1].gameObject.SetActive (false);
			oegerButtons [2].gameObject.SetActive (false);
			oegerButtons [0].onClick.RemoveAllListeners ();
			oegerButtons [0].onClick.AddListener (() => this.WrapperLoadLevelAim (currentLevel + 1));
		} else if (tip == "Oh oh... Don't worry - lucky for you, we can time travel on Jupiter. I'll give you a do-over, but it's going to cost you...") {
			oegerButtons [1].gameObject.SetActive (false);
			oegerButtons [2].gameObject.SetActive (false);

			// RESET VARIABLES AS THEY WERE AT START OF LEVEL
			slider1.value = 0.0f;
			slider2.value = 0.0f;
			currentCash = yourStartingCash;
			companyCrystalsIn = 0;
			companyCrystalsOut = 0;
			companyProfits = 0.0f;
			companyEmployeeHealth = 100;

			costProportion = 1.0f;
			incomeProportion = 1.0f;

			randomEvent1Month = new int[0];
			randomEvent2Month = new int[0];
			randomEvent3Month = new int[0];
			randomEvent4Month = new int[0];
			randomEvent5Month = new int[0];
			randomEvent6Month = new int[0];
			randomEvent7Month = new int[0];
			randomEvent8Month = new int[0];

			colonyValue = colonyStartingCash;
			colonyCrystalsIn = 0;
			colonyCrystalOut = 0;
			colonyProfits = 0.0f;
			colonyGrowth = 0.0f;
			colonyCompanies = colonyStartingCompanies;
			colonyEmployees = colonyStartingEmployees;
			colonyEmployeeHealth = 100;

			companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
			companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
			companyStatusProfitsText.text = companyProfits.ToString ();
			companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
			companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

			colonyStatusValueText.text = colonyValue.ToString ();
			colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
			colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
			colonyStatusProfitsText.text = colonyProfits.ToString ();
			colonyStatusGrowthText.text = colonyGrowth.ToString ();
			colonyStatusCompaniesText.text = colonyCompanies.ToString ();
			colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
			colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

			levelStatusStatusText.text = "0";

			for (int i = 0; i < companyBuildings.Length; i++) {
				companyBuildings [i].SetActive (true); // re-activate all buildings
			}
			oegerButtons [0].onClick.RemoveAllListeners ();
            
			oegerButtons [0].onClick.AddListener (() => this.WrapperGameplay (currentLevel, 2, currentLever, true));
        }
		oegerAudioSource.Play ();
	}
    // ===========================

    // FUNCTION
    // Close oeger
    // ===========================
    void closeOeger()
    { 
        oeger.SetActive(false);
        oegerButtons[0].gameObject.SetActive(false);
        
    }


    // ===========================

    // FUNCTION
    // WRAPPER LOAD LEVEL AIM
    // ===========================
    void WrapperLoadLevelAim(int level)
    {
        StartCoroutine(loadLevelAim(level));
    }
    // ===========================

    // FUNCTION
    // LOAD LEVEL AIM
    // ===========================
    IEnumerator loadLevelAim(int level)
    {
        currentLevel = level;
        oeger.SetActive(false);

        companyStatusEmpty.SetActive(false);
        colonyStatusEmpty.SetActive(false);
        levelStatusEmpty.SetActive(false);
        statusLevelGraph.SetActive(false);

        slider1Empty.SetActive(false);
        slider2Empty.SetActive(false);

        // reset graph
        pointList = new List<Vector2>();
        lineRendererStatusGraph.Points = pointList.ToArray();
        target1.SetActive(false);
        target1Check.SetActive(false);
        target2.SetActive(false);

        startLevelButton.gameObject.SetActive(false);

        // reset level aim text
        levelAimText.text = "";

        levelAimScreen.SetActive(true);
        docAudioSource.Play();

        foreach (char letter in levelAims[level - 1].ToCharArray())
        {
            // type message out letter for letter
            levelAimText.text += letter;
            yield return new WaitForSeconds(0.005f);
        }

        startLevelButton.gameObject.SetActive(true);
        startLevelButton.onClick.RemoveAllListeners();

        startLevelButton.onClick.AddListener(() => this.WrapperGameplay(currentLevel, 1, currentLever, false)); // calls gameplay for 1st time after level aim is displayed
        
        
    }
    // ===========================

    // FUNCTION
    // WRAPPER GAMEPLAY
    // ===========================
    void WrapperGameplay(int level, int entryNumber, int lever, bool restart){
		StartCoroutine (gameplay (level, entryNumber, lever, restart));
	}
    // ===========================

    // FUNCTION
    // GAMEPLAY
    // ===========================
    IEnumerator gameplay(int level, int entryNumber, int lever, bool restart){
		levelAimScreen.SetActive (false);
		oeger.SetActive (false);
		yield return new WaitForSeconds (0.01f);
		currentLever = lever;
		if (level == 2 && entryNumber ==1) {
			yourStartingCash += 1000; // reward from Enzer when start level 2
		}

		oegerLevelTipText.text = "";

		// if recommendation was given and not followed directly - check if followed indirectly
		if(recommendationGiven && !recommendationFollowedDirectly){
			if(lever == recommendedLever){
				recommendationFollowedIndirectly = true; // recommendation was followed only after looking at other options
			} else {
				recommendationFollowedIndirectly = false; // recommendation was not followed at all
			}
			recommendationGiven = false; // so does not repeat this each level
			this.updateRecommendationHelp(1);
		} else if (recommendationGiven && recommendationFollowedDirectly){
			this.updateRecommendationHelp(1);
			recommendationGiven = false; // so does not repeat this each level
		}
        if (helpTaxGiven == 1){
			this.updateRecommendationHelp(2);
			helpTaxGiven = 0; // so does not repeat this each level
		}
		if(helpBorrowGiven == 1){
			this.updateRecommendationHelp(3);
			helpBorrowGiven = 0; // so does not repeat this each level
		}
		if(helpHarvestGiven == 1){
			this.updateRecommendationHelp(4);
			helpHarvestGiven = 0; // so does not repeat this each level
		}

		companyStatusEmpty.SetActive (true);
		colonyStatusEmpty.SetActive (true);
		levelStatusEmpty.SetActive (true);
		statusLevelGraph.SetActive (true);

		// RESET VARIABLES AS THEY WERE AT START OF LEVEL
		slider1.value = 0.0f;
		slider2.value = 0.0f;
		companyCrystalsIn = 0;
		companyCrystalsOut = 0;
		companyProfits = 0.0f;
		companyEmployeeHealth = 100;

		costProportion = 1.0f;
		incomeProportion = 1.0f;

		companyYourCurrentCashText.text = currentCash.ToString();

		randomEvent1Month = new int[0];
		randomEvent2Month = new int[0];
		randomEvent3Month = new int[0];
		randomEvent4Month = new int[0];
		randomEvent5Month = new int[0];
		randomEvent6Month = new int[0];
		randomEvent7Month = new int[0];
		randomEvent8Month = new int[0];

		colonyValue = colonyStartingCash;
		colonyCrystalsIn = 0;
		colonyCrystalOut = 0;
		colonyProfits = 0.0f;
		colonyGrowth = 0.0f;
		colonyCompanies = colonyStartingCompanies;
		colonyEmployees = colonyStartingEmployees;
		colonyEmployeeHealth = 100;

		companyStatusCrystalsInText.text = companyCrystalsIn.ToString ();
		companyStatusCrystalsOutText.text = companyCrystalsOut.ToString ();
		companyStatusProfitsText.text = companyProfits.ToString ();
		companyStatusEmployeeNumbersText.text = companyEmployees.ToString ();
		companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString () + "%";

		colonyStatusValueText.text = colonyValue.ToString ();
		colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString ();
		colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString ();
		colonyStatusProfitsText.text = colonyProfits.ToString ();
		colonyStatusGrowthText.text = colonyGrowth.ToString ();
		colonyStatusCompaniesText.text = colonyCompanies.ToString ();
		colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString ();
		colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString () + "%";

		for (int i = 0; i < companyBuildings.Length; i++) {
			companyBuildings [i].SetActive (true); // re-activate all buildings
		}

		if(currentLever == 2){
			levelStatusAimText.text = "3.5% growth";
		} else{
			levelStatusAimText.text = "4% growth";
		}


		levelStatusStatusText.text = "0";
		currentCash = yourStartingCash;

		// initialise status graph
		point = new Vector2 (-40.0f, -10.0f);
		pointList = new List<Vector2> ();
		pointList.Add (point);
		lineRendererStatusGraph.Points = pointList.ToArray ();

		if (levelAimTimeFrame[currentLevel-1] == 1) {
			if (currentLever == 2) { // if performing check - target is 3.5%
				target1Check.SetActive (true);
				target1.SetActive (false);
			} else {
				target1Check.SetActive (false);
				target1.SetActive (true);
			}
			target2.SetActive (false);
		} else {
			target1.SetActive (false);
			target1Check.SetActive(false);
			target2.SetActive (true);
		}

		if (levelAimTimeFrame [currentLevel - 1] == 1) {
			labelXAxis.text = "MONTH";
			labelsXAxisMonths.SetActive (true);
			labelsXAxisYears.SetActive (false);
			pointxAxisList = new List<Vector2> ();
			xAxisPoint = new Vector2 (-35.0f, -5.0f);
			pointxAxisList.Add (xAxisPoint);
			xAxisPoint = new Vector2 (45.0f, -5.0f);
			pointxAxisList.Add (xAxisPoint);

			lineRendererStatusXAxis.Points = pointxAxisList.ToArray ();
		} else {
			labelXAxis.text = "YEAR";
			labelsXAxisMonths.SetActive (false);
			labelsXAxisYears.SetActive (true);
			pointxAxisList = new List<Vector2> ();
			xAxisPoint = new Vector2 (-35.0f, -5.0f);
			pointxAxisList.Add (xAxisPoint);
			xAxisPoint = new Vector2 (130.0f, -5.0f);
			pointxAxisList.Add (xAxisPoint);

			lineRendererStatusXAxis.Points = pointxAxisList.ToArray ();
		}

		if (level == 1) {
			if (entryNumber == 1) {
                companyStatusEmpty.SetActive(true);
                toolTipCompany.SetActive(true);
                toolTipCompanyButton.onClick.RemoveAllListeners();
                toolTipCompanyButton.onClick.AddListener(() => this.WrapperCloseToolTip(2));
                yield return new WaitWhile(toolTipCompanyButton.IsActive);

                
			} else if (entryNumber == 2 || restart) {
				slider1.interactable = true;
				if (lever == 1 || lever == 2) {
					userLever1 = lever;
					slider1Heading.text = "TAX (% INCREASE)";
				} else if (lever == 3) {
					userLever1 = 3;
					slider1Heading.text = "CRYSTAL LOAN \n (% OF COLONY VALUE)";
				} else {
					userLever1 = 4;
					slider1Heading.text = "HARVEST CRYSTALS \n (% OF COLONY VALUE)";
				}
				slider1Empty.SetActive (true);

				yield return new WaitUntil (() => slider1.value > 0);
				// if the user has set a value i.e. cannot keep at 0
				startYearButton.gameObject.SetActive (true);
				startYearButton.onClick.RemoveAllListeners ();

				startYearButton.onClick.AddListener (() => this.WrapperSimulateEconomy ());
			}
		} else if (level == 2) {
			if(entryNumber == 1){
				this.WrapperOegerHelp("That sounds daunting! But you seem to be in the swing of things! You select your weapon of choice, and I'll do the rest!", "Increase tax", "Borrow crystals from you", "Harvest more crystals");
			} else if (entryNumber == 2 || restart){
				slider1.interactable = true;
				if (currentLever == 1) {
					userLever1 = 1;
					slider1Heading.text = "TAX (% INCREASE)";
				} else if (currentLever == 2) {
					userLever1 = 2;
					slider1Heading.text = "TAX (% INCREASE)"; // tax check level
				} else if(currentLever == 3){
					userLever1 = 3;
					slider1Heading.text = "CRYSTAL LOAN \n (% OF COLONY VALUE)";
				} else {
					userLever1 = 4;
					slider1Heading.text = "HARVEST CRYSTALS \n (% OF COLONY VALUE)";
				}
				slider1Empty.SetActive (true);

				yield return new WaitUntil (() => slider1.value > 0);
				// if the user has set a value i.e. cannot keep at 0
				startYearButton.gameObject.SetActive (true);
				startYearButton.onClick.RemoveAllListeners ();

				startYearButton.onClick.AddListener (() => this.WrapperSimulateEconomy ());
			}
		} else { // level 3 = multiple options
			if(entryNumber == 1){
				this.WrapperOegerHelp("I didn't even think of that! We better get moving. Which combo do you want to try first?", "Increase tax & borrow crystals", "Increase tax & harvest crystals", "Borrow crystals & harvest crystals");
			} else {
				slider1.interactable = true;
				slider2.interactable = true;
				if(currentLever == 8){
					userLever1 = 1;
					userLever2 = 3;
					slider1Heading.text = "TAX (% INCREASE)";
					slider2Heading.text = "CRYSTAL LOAN \n (% OF COLONY VALUE)";
				} else if (currentLever == 9){
					userLever1 = 1;
					userLever2 = 4;
					slider1Heading.text = "TAX (% INCREASE)";
					slider2Heading.text = "HARVEST CRYSTALS \n (% OF COLONY VALUE)";
				} else {
					userLever1 = 3;
					userLever2 = 4;
					slider1Heading.text = "CRYSTAL LOAN \n (% OF COLONY VALUE)";
					slider2Heading.text = "HARVEST CRYSTALS \n (% OF COLONY VALUE)";
				}
				slider1Empty.SetActive(true);
				slider2Empty.SetActive(true);

				yield return new WaitUntil (() => slider1.value > 0 || slider2.value > 0);
				// if the user has set a value i.e. cannot keep at 0
				startYearButton.gameObject.SetActive (true);
				startYearButton.onClick.RemoveAllListeners ();

				startYearButton.onClick.AddListener (() => this.WrapperSimulateEconomy ());
			}
		}
	}
    // ===========================

    // FUNCTION
    // WRAPPER SIMULATE ECONOMY
    // ===========================
    void WrapperSimulateEconomy(){
		StartCoroutine (simulateEconomy ());
	}
    // ===========================

    // FUNCTION
    // SIMULATE ECONOMY
    // ===========================
    IEnumerator simulateEconomy(){
		yield return new WaitForSeconds (0.01f);
		oeger.SetActive (false);
		startYearButton.gameObject.SetActive (false); // de-activate button
		gameplayMonth.gameObject.SetActive (true); // activate month display
		slider1.interactable = false; // user cannot change value during the year
		statusLevelGraph.SetActive(true);
		companyStatusEmpty.SetActive (true);
		colonyStatusEmpty.SetActive (true);
		levelStatusEmpty.SetActive (true);
        

        // reset level summary
        levelSummary = "";

		// reset bool
		leverIsComplete = false;
        int leverToAdd = 0;
		if (currentLevel == 1) {
			leverToAdd = currentLever;
		} else if (currentLevel == 2) {
			if (currentLever == 1) {
				if (!leversAttempted.Contains (currentLever + 4)) {
					leverToAdd = currentLever + 4;
				}
			} else {
				leverToAdd = currentLever + 3; // (less 1 for tax-check lever)
			}
		} else {
			leverToAdd = currentLever;
		}

		if (leverToAdd!= 0 && !leversAttempted.Contains (leverToAdd)) { // only do once for every lever
			leversAttempted.Add (leverToAdd); // add selected lever to attempted list
			leverAttempts.Add(1); // add first attempt
			leverGrowth.Add(0.0f); // add zero growth to lever

            this.updateLearningPath();
			this.WrapperGetGraphData ();
		}
        if (leversCompleted.Count == 1)
        {
            skyRain.SetActive(true);
        }

		leverValues.Add(slider1.value); // add user-set value to lever
        
        if (currentLevel < 3) {
			if (userLever1 == 1 || userLever1 == 2) {
				userValueTax = slider1.value;

				if(currentLevel == 2){
					taxShortTerm.SetActive(false);
					taxLongTerm.SetActive(true);
					for(int i = 0; i < taxLongTermImages.Length; i++){
						taxLongTermImages[i].gameObject.SetActive(false);
					}
				} else {
					taxShortTerm.SetActive(true);
					taxLongTerm.SetActive(false);
					for(int i = 0; i < taxShortTermImages.Length; i++){
						taxShortTermImages[i].gameObject.SetActive(false);
					}
				}
				borrowShortTerm.SetActive(false);
				harvestShortTerm.SetActive(false);
				borrowLongTerm.SetActive(false);
				harvestLongTerm.SetActive(false);
				taxBorrow.SetActive(false);
				taxHarvest.SetActive(false);
				borrowHarvest.SetActive(false);

				if (userValueTax > 8.0f) {
					// will fail even in short term - high possibity of multiple companies closing down
					randomEvent1Month = new int[4];
					randomEvent3Month = new int[1];
					randomEvent6Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent1Month [0] = UnityEngine.Random.Range (3, 4);
					randomEvent1Month [1] = UnityEngine.Random.Range (4, 6);
					randomEvent3Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent1Month [2] = UnityEngine.Random.Range (8, 10);
					randomEvent1Month [3] = UnityEngine.Random.Range (12, 15);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[0] + "\n"; 
					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [3] + ": " + eventDescriptions[0] + "\n"; 
						taxLongTermImages[0].gameObject.SetActive(true);
					} else {
						taxShortTermImages[0].gameObject.SetActive(true);
					}

				} else if (userValueTax > 6.0f) {
					// will fail even in short term - lower probability of multipe companies closing down
					randomEvent1Month = new int[3];
					randomEvent3Month = new int[1];
					randomEvent6Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (2, 3);
					randomEvent1Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent3Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent1Month [1] = UnityEngine.Random.Range (8, 10);
					randomEvent1Month [2] = UnityEngine.Random.Range (12, 18);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[3] + "\n"; 
						taxLongTermImages[1].gameObject.SetActive(true);
					} else {
						taxShortTermImages[1].gameObject.SetActive(true);
					}

				} else if (userValueTax > 4.5f) {
					// will fail even in short term
					randomEvent1Month = new int[2];
					randomEvent3Month = new int[1];
					randomEvent6Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent1Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent3Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent1Month [1] = UnityEngine.Random.Range (12, 22);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
						taxLongTermImages[2].gameObject.SetActive(true);
					} else{
						taxShortTermImages[2].gameObject.SetActive(true);
					}

				} else if (userValueTax > 2.0f) {
					// likely to succeed in short term
					randomEvent1Month = new int[2];
					randomEvent3Month = new int[1];
					randomEvent6Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (4, 8);
					randomEvent3Month [0] = UnityEngine.Random.Range (15, 15);
					randomEvent1Month [0] = UnityEngine.Random.Range (20, 24);
					randomEvent1Month [1] = UnityEngine.Random.Range (24, 27);

				} else {
					// too low - growth won't be reached
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent2Month = new int[1];
					randomEvent3Month = new int[1];

					randomEvent2Month [0] = UnityEngine.Random.Range (9, 10);
					randomEvent3Month [0] = UnityEngine.Random.Range (32, 34);

					levelSummary += "Month " + randomEvent2Month [0] + ": " + eventDescriptions[2] + "\n"; 
					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
						taxLongTermImages[3].gameObject.SetActive(true);
					} else{
						taxShortTermImages[3].gameObject.SetActive(true);
					}

				}
			} else if (userLever1 == 3) {
				userValueLoan = slider1.value;

				if(currentLevel == 2){
					borrowShortTerm.SetActive(false);
					borrowLongTerm.SetActive(true);
					for(int i = 0; i < borrowLongTermImages.Length; i++){
						borrowLongTermImages[i].gameObject.SetActive(false);
					}
				} else {
					borrowShortTerm.SetActive(true);
					borrowLongTerm.SetActive(false);
					for(int i = 0; i < borrowShortTermImages.Length; i++){
						borrowShortTermImages[i].gameObject.SetActive(false);
					}
				}
				taxShortTerm.SetActive(false);
				harvestShortTerm.SetActive(false);
				taxLongTerm.SetActive(false);
				harvestLongTerm.SetActive(false);
				taxBorrow.SetActive(false);
				taxHarvest.SetActive(false);
				borrowHarvest.SetActive(false);

				if (userValueLoan > 7.0f) {
					// will fail even in short term - high possibity of multiple companies closing down
					randomEvent1Month = new int[3];
					randomEvent4Month = new int[1];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent7Month [0] = UnityEngine.Random.Range (2, 4);
					randomEvent8Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent4Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent5Month [0] = UnityEngine.Random.Range (8, 9);
					randomEvent1Month [0] = UnityEngine.Random.Range (9, 10);
					randomEvent1Month [1] = UnityEngine.Random.Range (10, 11);
					randomEvent1Month [2] = UnityEngine.Random.Range (12, 14);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[1] + "\n"; 

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[1] + "\n"; 
						borrowLongTermImages[0].gameObject.SetActive(true);
					} else {
						borrowShortTermImages[0].gameObject.SetActive(true);
					}
				} else if (userValueLoan > 5.0f) {
					// will fail even in short term - lower probability of multipe companies closing down
					randomEvent1Month = new int[2];
					randomEvent4Month = new int[1];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (2, 4);
					randomEvent7Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent8Month [0] = UnityEngine.Random.Range (6, 7);
					randomEvent4Month [0] = UnityEngine.Random.Range (7, 9);
					randomEvent5Month [0] = UnityEngine.Random.Range (9, 11);
					randomEvent1Month [0] = UnityEngine.Random.Range (13, 15);
					randomEvent1Month [1] = UnityEngine.Random.Range (16, 21);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 
						levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[1] + "\n"; 
						borrowLongTermImages[0].gameObject.SetActive(true);
					} else {
						borrowShortTermImages[0].gameObject.SetActive(true);
					}
				} else if (userValueLoan > 3.0f) {
					// likely to succeed in short term
					randomEvent1Month = new int[2];
					randomEvent4Month = new int[2];
					randomEvent5Month = new int[2];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent7Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent8Month [0] = UnityEngine.Random.Range (10, 11);
					randomEvent4Month [0] = UnityEngine.Random.Range (16, 18);
					randomEvent5Month [0] = UnityEngine.Random.Range (18, 22);
					randomEvent1Month [0] = UnityEngine.Random.Range (22, 25);
					randomEvent1Month [1] = UnityEngine.Random.Range (25, 28);
					randomEvent4Month [1] = UnityEngine.Random.Range (28, 30);
					randomEvent5Month [1] = UnityEngine.Random.Range (30, 32);
				} else {
					// too low - growth won't be reached
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent2Month = new int[1];
					randomEvent1Month = new int[1];

					randomEvent2Month [0] = UnityEngine.Random.Range (9, 10);
					randomEvent1Month [0] = UnityEngine.Random.Range (32, 34);

					levelSummary += "Month " + randomEvent2Month [0] + ": " +  eventDescriptions[2] + "\n";

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 
						borrowLongTermImages[0].gameObject.SetActive(true);
					} else {
						borrowShortTermImages[0].gameObject.SetActive(true);
					}
				}
			} else {
				userValueHarvest = slider1.value;

				if(currentLevel == 2){
					harvestShortTerm.SetActive(false);
					harvestLongTerm.SetActive(true);
					for(int i = 0; i < harvestLongTermImages.Length; i++){
						harvestLongTermImages[i].gameObject.SetActive(false);
					}
				} else {
					harvestShortTerm.SetActive(true);
					harvestLongTerm.SetActive(false);
					for(int i = 0; i < harvestShortTermImages.Length; i++){
						harvestShortTermImages[i].gameObject.SetActive(false);
					}
				}
				taxShortTerm.SetActive(false);
				borrowShortTerm.SetActive(false);
				taxLongTerm.SetActive(false);
				borrowLongTerm.SetActive(false);
				taxBorrow.SetActive(false);
				taxHarvest.SetActive(false);
				borrowHarvest.SetActive(false);

				if (userValueHarvest > 7.0f) {
					// will fail even in short term - high possibity of multiple companies closing down
					randomEvent1Month = new int[3];
					randomEvent2Month = new int[1];
					randomEvent4Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent7Month [0] = UnityEngine.Random.Range (2, 3);
					randomEvent8Month [0] = UnityEngine.Random.Range (3, 4);
					randomEvent4Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent2Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent1Month [0] = UnityEngine.Random.Range (8, 9);
					randomEvent1Month [1] = UnityEngine.Random.Range (10, 11);
					randomEvent1Month [2] = UnityEngine.Random.Range (12, 14);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent2Month [0] + ": " +  eventDescriptions[2] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[1] + "\n"; 

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[1] + "\n"; 
						harvestLongTermImages[0].gameObject.SetActive(true);
					} else {
						harvestShortTermImages[0].gameObject.SetActive(true);
					}
				} else if (userValueHarvest > 5.0f) {
					// will fail even in short term - lower probability of multipe companies closing down
					randomEvent1Month = new int[2];
					randomEvent2Month = new int[1];
					randomEvent4Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (2, 4);
					randomEvent7Month [0] = UnityEngine.Random.Range (4, 6);
					randomEvent8Month [0] = UnityEngine.Random.Range (6, 7);
					randomEvent4Month [0] = UnityEngine.Random.Range (7, 8);
					randomEvent2Month [0] = UnityEngine.Random.Range (8, 9);
					randomEvent1Month [0] = UnityEngine.Random.Range (9, 10);
					randomEvent1Month [1] = UnityEngine.Random.Range (14, 18);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent2Month [0] + ": " +  eventDescriptions[2] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[1] + "\n"; 
						harvestLongTermImages[0].gameObject.SetActive(true);
					} else {
						harvestShortTermImages[0].gameObject.SetActive(true);
					}
				} else if (userValueHarvest > 3.0f) {
					// likely to succeed in short term
					randomEvent1Month = new int[3];
					randomEvent2Month = new int[1];
					randomEvent4Month = new int[2];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (6, 8);
					randomEvent7Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent8Month [0] = UnityEngine.Random.Range (10, 11);
					randomEvent4Month [0] = UnityEngine.Random.Range (16, 18);
					randomEvent2Month [0] = UnityEngine.Random.Range (18, 22);
					randomEvent1Month [0] = UnityEngine.Random.Range (22, 23);
					randomEvent1Month [1] = UnityEngine.Random.Range (23, 25);
					randomEvent4Month [1] = UnityEngine.Random.Range (25, 27);
					randomEvent1Month [2] = UnityEngine.Random.Range (27, 30);
				} else {
					// too low - growth won't be reached
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent2Month = new int[1];
					randomEvent1Month = new int[1];

					randomEvent2Month [0] = UnityEngine.Random.Range (9, 10);
					randomEvent1Month [0] = UnityEngine.Random.Range (32, 34);

					levelSummary += "Month " + randomEvent2Month [0] + ": " +  eventDescriptions[2] + "\n";

					if(currentLevel == 2){
						levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[1] + "\n"; 
						harvestLongTermImages[0].gameObject.SetActive(true);
					} else {
						harvestShortTermImages[0].gameObject.SetActive(true);
					}
				}
			}
		} else { 
			leverValues.Add(slider2.value); // add user-set value for second lever

			if (currentLever == 8) { // tax and borrow
				taxShortTerm.SetActive(false);
				borrowShortTerm.SetActive(false);
				harvestShortTerm.SetActive(false);
				taxLongTerm.SetActive(false);
				borrowLongTerm.SetActive(false);
				harvestLongTerm.SetActive(false);
				taxBorrow.SetActive(true);
				taxHarvest.SetActive(false);
				borrowHarvest.SetActive(false);

				if (slider1.value + slider2.value > 10) {
					// will fail in long term 
					randomEvent1Month = new int[3];
					randomEvent3Month = new int[1];
					randomEvent4Month = new int[1];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent7Month [0] = UnityEngine.Random.Range (4, 5);
					randomEvent8Month [0] = UnityEngine.Random.Range (5, 8);
					randomEvent3Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent4Month [0] = UnityEngine.Random.Range (10, 14);
					randomEvent5Month [0] = UnityEngine.Random.Range (14, 17);
					randomEvent1Month [0] = UnityEngine.Random.Range (22, 25);
					randomEvent1Month [1] = UnityEngine.Random.Range (32, 34);
					randomEvent1Month [2] = UnityEngine.Random.Range (34, 36);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[0] + "\n"; 
					taxBorrowImages[0].gameObject.SetActive(true);

				} else if (slider1.value + slider2.value > 4) {
					// will still fail in long term
					randomEvent1Month = new int[2];
					randomEvent3Month = new int[1];
					randomEvent4Month = new int[1];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (10, 12);
					randomEvent7Month [0] = UnityEngine.Random.Range (12, 16);
					randomEvent8Month [0] = UnityEngine.Random.Range (16, 20);
					randomEvent3Month [0] = UnityEngine.Random.Range (20, 24);
					randomEvent4Month [0] = UnityEngine.Random.Range (24, 27);
					randomEvent5Month [0] = UnityEngine.Random.Range (27, 30);
					randomEvent1Month [0] = UnityEngine.Random.Range (30, 33);
					randomEvent1Month [1] = UnityEngine.Random.Range (33, 35);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					taxBorrowImages[1].gameObject.SetActive(true);
				} else {
					// likely to succeed in long term
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent6Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (18, 24);
					randomEvent8Month [0] = UnityEngine.Random.Range (38, 42);
				}
			} else if (currentLever == 9) { // tax and harvest
				taxShortTerm.SetActive(false);
				borrowShortTerm.SetActive(false);
				harvestShortTerm.SetActive(false);
				taxLongTerm.SetActive(false);
				borrowLongTerm.SetActive(false);
				harvestLongTerm.SetActive(false);
				taxBorrow.SetActive(false);
				taxHarvest.SetActive(true);
				borrowHarvest.SetActive(false);

				if (slider1.value + slider2.value > 10) {
					// will fail in long term 
					randomEvent1Month = new int[3];
					randomEvent3Month = new int[1];
					randomEvent4Month = new int[2];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent7Month [0] = UnityEngine.Random.Range (4, 5);
					randomEvent8Month [0] = UnityEngine.Random.Range (5, 8);
					randomEvent3Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent4Month [0] = UnityEngine.Random.Range (10, 14);
					randomEvent4Month [1] = UnityEngine.Random.Range (14, 17);
					randomEvent1Month [0] = UnityEngine.Random.Range (22, 25);
					randomEvent1Month [1] = UnityEngine.Random.Range (32, 34);
					randomEvent1Month [2] = UnityEngine.Random.Range (34, 36);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [1] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[0] + "\n"; 
					taxHarvestImages[0].gameObject.SetActive(true);

				} else if (slider1.value + slider2.value > 4) {
					// will still fail in long term
					randomEvent1Month = new int[2];
					randomEvent3Month = new int[1];
					randomEvent4Month = new int[2];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (10, 12);
					randomEvent7Month [0] = UnityEngine.Random.Range (12, 16);
					randomEvent8Month [0] = UnityEngine.Random.Range (16, 20);
					randomEvent3Month [0] = UnityEngine.Random.Range (20, 24);
					randomEvent4Month [0] = UnityEngine.Random.Range (24, 27);
					randomEvent4Month [1] = UnityEngine.Random.Range (27, 30);
					randomEvent1Month [0] = UnityEngine.Random.Range (30, 33);
					randomEvent1Month [1] = UnityEngine.Random.Range (33, 35);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent3Month [0] + ": " +  eventDescriptions[3] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					taxBorrowImages[1].gameObject.SetActive(true);
				} else {
					// likely to succeed in long term
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent6Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (18, 24);
					randomEvent8Month [0] = UnityEngine.Random.Range (38, 42);
				}
			} else { // borrow and harvest
				taxShortTerm.SetActive(false);
				borrowShortTerm.SetActive(false);
				harvestShortTerm.SetActive(false);
				taxLongTerm.SetActive(false);
				borrowLongTerm.SetActive(false);
				harvestLongTerm.SetActive(false);
				taxBorrow.SetActive(false);
				taxHarvest.SetActive(false);
				borrowHarvest.SetActive(true);
				if (slider1.value + slider2.value > 10) {
					// will fail in long term 
					randomEvent1Month = new int[3];
					randomEvent4Month = new int[2];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (1, 2);
					randomEvent7Month [0] = UnityEngine.Random.Range (4, 5);
					randomEvent8Month [0] = UnityEngine.Random.Range (5, 8);
					randomEvent4Month [0] = UnityEngine.Random.Range (8, 10);
					randomEvent4Month [1] = UnityEngine.Random.Range (10, 14);
					randomEvent5Month [0] = UnityEngine.Random.Range (14, 17);
					randomEvent1Month [0] = UnityEngine.Random.Range (22, 25);
					randomEvent1Month [1] = UnityEngine.Random.Range (32, 34);
					randomEvent1Month [2] = UnityEngine.Random.Range (34, 36);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [1] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [2] + ": " +  eventDescriptions[0] + "\n"; 
					borrowHarvestImages[0].gameObject.SetActive(true);

				} else if (slider1.value + slider2.value > 4) {
					// will still fail in long term
					randomEvent1Month = new int[2];
					randomEvent4Month = new int[2];
					randomEvent5Month = new int[1];
					randomEvent6Month = new int[1];
					randomEvent7Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (10, 12);
					randomEvent7Month [0] = UnityEngine.Random.Range (12, 16);
					randomEvent8Month [0] = UnityEngine.Random.Range (16, 20);
					randomEvent4Month [0] = UnityEngine.Random.Range (20, 24);
					randomEvent4Month [1] = UnityEngine.Random.Range (24, 27);
					randomEvent5Month [0] = UnityEngine.Random.Range (27, 30);
					randomEvent1Month [0] = UnityEngine.Random.Range (30, 33);
					randomEvent1Month [1] = UnityEngine.Random.Range (33, 35);

					levelSummary += "Month " + randomEvent6Month [0] + ": " +  eventDescriptions[6] + "\n";
					levelSummary += "Month " + randomEvent7Month [0] + ": " +  eventDescriptions[7] + "\n"; 
					levelSummary += "Month " + randomEvent8Month [0] + ": " +  eventDescriptions[8] + "\n";
					levelSummary += "Month " + randomEvent4Month [0] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent4Month [1] + ": " +  eventDescriptions[4] + "\n"; 
					levelSummary += "Month " + randomEvent5Month [0] + ": " +  eventDescriptions[5] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [0] + ": " +  eventDescriptions[0] + "\n"; 
					levelSummary += "Month " + randomEvent1Month [1] + ": " +  eventDescriptions[0] + "\n"; 
					borrowHarvestImages[1].gameObject.SetActive(true);
				} else {
					// likely to succeed in long term
					incomeProportion = (float)(incomeProportion * 0.6f); // reduce incline of graph
					costProportion = (float)(costProportion * 0.6f); // reduce incline of graph

					randomEvent6Month = new int[1];
					randomEvent8Month = new int[1];

					randomEvent6Month [0] = UnityEngine.Random.Range (18, 24);
					randomEvent8Month [0] = UnityEngine.Random.Range (38, 42);
				}
			}
		}
        int randomCompany;
		int event1 = 0;
		int event2 = 0;
		int event3 = 0;
		int event4 = 0;
		int event5 = 0;
		int event6 = 0;
		int event7 = 0;
		int event8 = 0;
        int j = 0;
		for (int i = 0; i < levelAimTimeFrame[currentLevel-1]*12; i++) {

            if(currentMonth == levelAimTimeFrame[currentLevel - 1] * 12) // from Update ()
            {
                i = currentMonth; // end the simulation / exit loop - player bankrupt in LT
            }
            else
            {
                if (levelAimTimeFrame[currentLevel - 1] == 1)
                {
                    yield return new WaitForSeconds(3.0f); // seconds per month simulation
                }
                else
                {
                    yield return new WaitForSeconds(3.0f); // seconds per month simulation
                }

                monthEndSource.Play();
                if (j == 12)
                {
                    j = 0; // restart new year
                }
                gameplayMonth.text = months[j];
                j = j + 1;

                // COMPANY CLOSE CHECK
                if (event1 < randomEvent1Month.Length && i == randomEvent1Month[event1])
                {
                    // event 1 - company closes
                    randomCompany = UnityEngine.Random.Range(0, 5);
                    while (randomCompany == companyChoice - 1)
                    {
                        // not your own company
                        randomCompany = UnityEngine.Random.Range(0, 5);
                        while (companyBuildings[randomCompany].activeInHierarchy == false)
                        {
                            // a company that is still active
                            randomCompany = UnityEngine.Random.Range(0, 5);
                        }
                    }
                    if (randomCompany == 0 || randomCompany == 1)
                    {
                        colonyEmployees = colonyEmployees - 1;
                    }
                    else if (randomCompany == 2 || randomCompany == 4)
                    {
                        colonyEmployees = colonyEmployees - 5;
                    }
                    else
                    {
                        colonyEmployees = colonyEmployees - 3;
                    }

                    if (currentLever == 1 || currentLever == 2 || currentLever == 8 || currentLever == 9)
                    {
                        this.WrapperOegerHelp("I think the tax was too high for this company. It seems to be closing down...", "", "", "");
                    }
                    else
                    {
                        this.WrapperOegerHelp("This company has run out of money. It seems to be closing down...", "", "", "");
                    }

                    this.WrapperCloseCompany(randomCompany);
                    colonyCompanies = colonyCompanies - 1;
                    // less earning salary - income of others also goes down
                    incomeProportion = incomeProportion * 0.2f;

                    event1 = event1 + 1; // increment

                    // REMAINING EVENT CHCECKS
                }
                else if (event2 < randomEvent2Month.Length && i == randomEvent2Month[event2])
                {
                    // event 2 - infrastructure investment stopped - cost+80%
                    this.WrapperOegerHelp("Enzer has stopped investing in infrastructure! Machine breakdowns are resulting in higher costs...", "", "", "");
                    costProportion = costProportion * 1.8f;
                    event2 = event2 + 1; // increment

                }
                else if (event3 < randomEvent3Month.Length && i == randomEvent3Month[event3])
                {
                    // event 3 - reduced salaries - sales-80%
                    this.WrapperOegerHelp("Companies are reducing salaries to compensate for high tax rates! The colony is losing spending power...", "", "", "");
                    incomeProportion = incomeProportion * 0.2f;
                    event3 = event3 + 1; // increment

                }
                else if (event4 < randomEvent4Month.Length && i == randomEvent4Month[event4])
                {
                    // event 4 - can't afford increased prices - sales-80%
                    this.WrapperOegerHelp("The colony can't afford these new high prices! Sales are decreasing...", "", "", "");
                    incomeProportion = incomeProportion * 0.2f;
                    event4 = event4 + 1; // increment

                }
                else if (event5 < randomEvent5Month.Length && i == randomEvent5Month[event5])
                {
                    // event 5 - can't repay loan - cost+80%
                    this.WrapperOegerHelp("The colony can't repay the loan! Our resource price has increased for you...", "", "", "");
                    costProportion = costProportion * 1.8f;
                    event5 = event5 + 1; // increment

                }
                else if (event6 < randomEvent6Month.Length && i == randomEvent6Month[event6])
                {
                    // event 6 - infrastructure investment - cost-10%
                    this.WrapperOegerHelp("Enzer is investing in infrastructure! New machines are reducing your costs...", "", "", "");
                    costProportion = costProportion * 0.9f;
                    event6 = event6 + 1; // increment

                }
                else if (event7 < randomEvent7Month.Length && i == randomEvent7Month[event7])
                {
                    // event 7 - lower costs - profits - salaries - sales+10%
                    this.WrapperOegerHelp("These lower costs mean more profits and increased salaries. The colony's spending power is increasing...", "", "", "");
                    incomeProportion = incomeProportion * 1.1f;
                    event7 = event7 + 1; // increment

                }
                else if (event8 < randomEvent8Month.Length && i == randomEvent8Month[event8])
                {
                    // event 8 - increase prices - profits+10%
                    this.WrapperOegerHelp("Demand for goods is increasing. Companies are increasing their prices...", "", "", "");
                    incomeProportion = incomeProportion * 1.1f;
                    event8 = event8 + 1; // increment
                }
                // adjust company and colony parameters and update graph
                colonyStatusGrowthText.text = colonyGrowth.ToString();
                if (companyChoice == 1)
                {
                    // consumables
                    companyCrystalsIn = System.Convert.ToInt32(UnityEngine.Random.Range(consumablesIncomeMin, consumablesIncomeMax) * incomeProportion);
                    companyCrystalsOut = System.Convert.ToInt32((companyCrystalsIn / consumablesMargin) * costProportion);
                    companyCrystalsIn = System.Convert.ToInt32(companyCrystalsIn * incomeProportion); // adjust income
                    companyProfits = System.Convert.ToInt32(companyCrystalsIn - companyCrystalsOut);

                    if (companyBuildings[0].activeInHierarchy == true)
                    {
                        float margin = UnityEngine.Random.Range(lifestyleMarginMin, lifestyleMarginMax);
                        int income = System.Convert.ToInt32(UnityEngine.Random.Range(lifestyleIncomeMin, lifestyleIncomeMax) * incomeProportion);
                        int expenses = System.Convert.ToInt32((companyCrystalsIn / margin) * costProportion);
                        colonyProfits = System.Convert.ToInt32(colonyProfits + income - expenses);
                    }

                }
                else
                {
                    // lifestyle goods
                    float margin = UnityEngine.Random.Range(lifestyleMarginMin, lifestyleMarginMax);
                    companyCrystalsIn = UnityEngine.Random.Range(lifestyleIncomeMin, lifestyleIncomeMax);
                    companyCrystalsOut = System.Convert.ToInt32(companyCrystalsIn / margin);
                    companyCrystalsIn = System.Convert.ToInt32(companyCrystalsIn * incomeProportion); // adjust income
                    companyProfits = companyCrystalsIn - companyCrystalsOut;

                    if (companyBuildings[0].activeInHierarchy == true)
                    {
                        int income = System.Convert.ToInt32(UnityEngine.Random.Range(consumablesIncomeMin, consumablesIncomeMax) * incomeProportion);
                        int expenses = System.Convert.ToInt32((companyCrystalsIn / consumablesMargin) * costProportion);
                        colonyProfits = System.Convert.ToInt32(colonyProfits + income - expenses);
                    }
                }
                companyEmployeeHealth = companyEmployeeHealth - UnityEngine.Random.Range(0, 2);
                currentCash = currentCash + System.Convert.ToInt32(companyProfits); // add your monthly profits to your cash

                if (companyBuildings[3].activeInHierarchy == true)
                {
                    colonyCrystalsIn = System.Convert.ToInt32(companyCrystalsIn + UnityEngine.Random.Range(researchIncomeMin, researchIncomeMax) * incomeProportion);
                    colonyCrystalOut = System.Convert.ToInt32((companyCrystalsOut + researchOut) * costProportion);
                }

                if (companyBuildings[4].activeInHierarchy == true)
                {
                    colonyCrystalsIn = System.Convert.ToInt32((companyCrystalsIn + UnityEngine.Random.Range(techIncomeMin, techIncomeMax) * incomeProportion));
                    colonyCrystalOut = System.Convert.ToInt32((companyCrystalsOut + techOut) * costProportion);
                }

                if (i < 4 && companyBuildings[2].activeInHierarchy == true)
                {
                    // building contractor makes profits in first 4 months, thereafter none
                    colonyCrystalsIn += System.Convert.ToInt32(buildingIncome * incomeProportion);
                    colonyCrystalOut += System.Convert.ToInt32(buildingOut * costProportion);
                }
                colonyCrystalsIn = System.Convert.ToInt32(colonyCrystalsIn * incomeProportion);
                colonyProfits = colonyCrystalsIn - System.Convert.ToInt32(colonyCrystalOut * costProportion);
                colonyValue = System.Convert.ToInt32(colonyValue + companyProfits + colonyProfits);
                colonyEmployeeHealth = colonyEmployeeHealth - UnityEngine.Random.Range(0, 2);

                companyStatusCrystalsInText.text = companyCrystalsIn.ToString();
                companyStatusCrystalsOutText.text = companyCrystalsOut.ToString();
                companyStatusProfitsText.text = companyProfits.ToString();
                companyStatusEmployeeNumbersText.text = companyEmployees.ToString();
                companyStatusEmployeeHealthText.text = companyEmployeeHealth.ToString() + "%";

                colonyGrowth = (colonyValue / (float)colonyStartingCash);

                colonyStatusValueText.text = colonyValue.ToString();
                colonyStatusCrystalsInText.text = colonyCrystalsIn.ToString();
                colonyStatusCrystalsOutText.text = colonyCrystalOut.ToString();
                colonyStatusProfitsText.text = colonyProfits.ToString();
                colonyStatusGrowthText.text = colonyGrowth.ToString("F2") + "%";
                colonyStatusCompaniesText.text = colonyCompanies.ToString();
                colonyStatusEmployeeNumbersText.text = colonyEmployees.ToString();
                colonyStatusEmployeeHealthText.text = colonyEmployeeHealth.ToString() + "%";

                levelStatusStatusText.text = (colonyGrowth / levelAimGrowth[currentLevel - 1]).ToString("F2") + "%";

                // update status graph
                if (levelAimTimeFrame[currentLevel - 1] == 1)
                {
                    point = new Vector2((float)(-33.33f + i * 6.67f), (float)(-10.0f + colonyGrowth * 10.0f));
                }
                else
                {
                    point = new Vector2((float)(-38.23f + i * 3.54f), (float)(-10.0f + colonyGrowth * 10.0f));
                }
                pointList = new List<Vector2>(lineRendererStatusGraph.Points);
                pointList.Add(point);
                lineRendererStatusGraph.Points = pointList.ToArray();

                if (colonyGrowth < -2.9f)
                {
                    i = levelAimTimeFrame[currentLevel - 1] * 12; // exit the simulation - colony bankrupt
                    this.WrapperAddGameFeed("The colony is bankrupt",false);
                }
            }

		}
        

        // after simulation is done - did user succeed?
        float growthAim;
		if (currentLever == 2) {
			growthAim = 3.5f;
		} else {
			growthAim = levelAimGrowth [currentLevel - 1];
		}
		if (colonyGrowth >= growthAim) { // will only succeed in short term // if multiple levers are used
			// user succeeded
			this.WrapperGetGraphData();
			leversCompleted.Add(currentLever); // adds lever to list of completed levers
			leverGrowth[leversAttempted.IndexOf(currentLever)] = colonyGrowth; // update growth in list to that achieved in level
			leverIsComplete = true;

            this.updateLeversAttempted ();

			if (leversCompleted.Count == 1) { // if it's the first lever completed
				this.WrapperOegerHelp("Here is a dashboard that may help you on your journey. Use the settings button on the right to customise what it displays.","","","");
				yield return new WaitForSeconds (2.0f);
			}

			if (currentLevel == 1) {
				if (currentLever == 1) { // if user completed tax (short term) - perform check level
					this.WrapperOegerHelp ("Hey, that seemed easy. Let's make sure you know what you're doing before Enzer comes back. Try again, this time to achieve a 3.5% growth.", "Prove myself", "", "");
				} else {
					if (leversCompleted.Count == 4) {
						// all short term levers have been completed
						this.WrapperOegerHelp ("Wow, you're pretty good at this! I'm sure Enzer is going to be pleased!", "Thanks", "", "");
					} else {
						// suggest trying another lever
						int count = leversCompleted.Count;
						if (leversCompleted.Contains (1)) {
							count = count - 1; // remove check tax lever from counter
						}
						if (count == 1) {// only completed one of the levers
							if (leversCompleted.Contains (1)) {
								// only completed tax
								this.WrapperOegerHelp ("Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! Which do you want to try?", "Borrow crystals from you", "Harvest more crystals", "");
							} else if (leversCompleted.Contains (3)) {
								// only completed borrow
								this.WrapperOegerHelp ("Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! I would suggest harvesting some crystals.", "Harvest more crystals", "No thanks, show me the options", "");
							} else {
								// only completed harvest
								this.WrapperOegerHelp ("Hey, not too bad! Maybe you should try figure out the other options before Enzer comes back! I would suggest borrowing some crystals from us.", "Borrow some crystals", "No thanks, show me the options", "");
							}
						} else if (count == 2) { // completed two of the levers
							if (!leversCompleted.Contains (1)) {
								// only tax remains
								this.WrapperOegerHelp ("Good job! Let's see if you can get the hang of the last one too!", "Increase tax", "", "");
							} else if (!leversCompleted.Contains (3)) {
								// only borrow remains
								this.WrapperOegerHelp ("Good job! Let's see if you can get the hang of the last one too!", "Borrow crystals from you", "", "");
							} else {
								// only harvest remains
								this.WrapperOegerHelp ("Good job! Let's see if you can get the hang of the last one too!", "Harvest more crystals", "", "");
							}
						}
					}
				}
			} else { // level 3 - multi-lever option
				this.WrapperOegerHelp("Well done! You've succeeded!", "", "", "");

                // did the user achieve a new highscore?
                // need to populate tablePost, positionPost, columnNamePost, scorePost, namePost

                // Get the highscores data from database (may have changed since we checked at start of game)
                // economy
                WWW leaderboardDataEconomy = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresEconomyData.php");
                yield return leaderboardDataEconomy;
                string leaderboardDataEconomyString = leaderboardDataEconomy.text;
                highscoresEconomy = leaderboardDataEconomyString.Split(';');
                // progression
                WWW leaderboardDataProgression = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresProgressionData.php");
                yield return leaderboardDataProgression;
                string leaderboardDataProgressionString = leaderboardDataProgression.text;
                highscoresProgression = leaderboardDataProgressionString.Split(';');
                // skills
                WWW leaderboardDataSkills = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresSkillsData.php");
                yield return leaderboardDataSkills;
                string leaderboardDataSkillsString = leaderboardDataSkills.text;
                highscoresSkills = leaderboardDataSkillsString.Split(';');
                // profits
                WWW leaderboardDataProfits = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresProfitsData.php");
                yield return leaderboardDataProfits;
                string leaderboardDataProfitsString = leaderboardDataProfits.text;
                highscoresProfits = leaderboardDataProfitsString.Split(';');

                // check if user's scores beat the 10th place on leaderboard
                // economic growth
                if (colonyGrowth > float.Parse(getDataValue(highscoresEconomy[9], "EconomicGrowth:")))
                {
                    string table = "highscoresEconomy";
                    string column = "EconomicGrowth";
                    int position;

                    for (int i = 0; i < 9; i++)
                    {
                        if (colonyGrowth > float.Parse(getDataValue(highscoresEconomy[i], "EconomicGrowth:")))
                        {
                            position = i+1;

                            userForm = new WWWForm();
                            userForm.AddField("tablePost", table);
                            userForm.AddField("positionPost",position);
                            userForm.AddField("columnNamePost", column);
                            userForm.AddField("scorePost", colonyGrowth.ToString("F2"));
                            userForm.AddField("namePost", newUsername);
                            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateHighscores.php", userForm);

                            i = 9; // exit loop as soon as position is found
                            newHighscoreTypeText.text = newHighscoreTypeText.text + "\n" + "Economic Growth (%)";
                            newHighscoreRankText.text = newHighscoreRankText.text + "\n" + position;
                            newHighscoreScoreText.text = newHighscoreScoreText.text + "\n" + colonyGrowth.ToString("F2");

                            newHighscore = true; // user achieved a new highscore
                        }
                    }
                }
                // progression
                if (leversCompleted.Count > float.Parse(getDataValue(highscoresProgression[9], "Progression:")))
                {
                    string table = "highscoresProgression";
                    string column = "Progression";
                    int position;

                    for (int i = 0; i < 9; i++)
                    {
                        if (leversCompleted.Count > float.Parse(getDataValue(highscoresProgression[i], "Progression:")))
                        {
                            position = i+1;

                            userForm = new WWWForm();
                            userForm.AddField("tablePost", table);
                            userForm.AddField("positionPost", position);
                            userForm.AddField("columnNamePost", column);
                            userForm.AddField("scorePost", leversCompleted.Count.ToString("F2"));
                            userForm.AddField("namePost", newUsername);
                            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateHighscores.php", userForm);

                            i = 9; // exit loop as soon as position is found
                            newHighscoreTypeText.text = newHighscoreTypeText.text + "\n" + "Progression (highest level)";
                            newHighscoreRankText.text = newHighscoreRankText.text + "\n" + position;
                            newHighscoreScoreText.text = newHighscoreScoreText.text + "\n" + leversCompleted.Count;
                            newHighscore = true; // user achieved a new highscore
                        }
                    }
                }
                // skills
                if (leversCompleted.Count > float.Parse(getDataValue(highscoresProgression[9], "Progression:")))
                {
                    string table = "highscoresSkills";
                    string column = "Skills";
                    int position;

                    for (int i = 0; i < 9; i++)
                    {
                        if (leversCompleted.Count > float.Parse(getDataValue(highscoresProgression[i], "Progression:")))
                        {
                            position = i + 1;

                            userForm = new WWWForm();
                            userForm.AddField("tablePost", table);
                            userForm.AddField("positionPost", position);
                            userForm.AddField("columnNamePost", column);
                            userForm.AddField("scorePost", leversCompleted.Count.ToString("F2"));
                            userForm.AddField("namePost", newUsername);
                            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateHighscores.php", userForm);

                            i = 9; // exit loop as soon as position is found
                            newHighscoreTypeText.text = newHighscoreTypeText.text + "\n" + "Skills (# skills)";
                            newHighscoreRankText.text = newHighscoreRankText.text + "\n" + position;
                            newHighscoreScoreText.text = newHighscoreScoreText.text + "\n" + leversCompleted.Count;

                            newHighscore = true; // user achieved a new highscore
                        }
                    }
                }
                // profits
                if (currentCash > float.Parse(getDataValue(highscoresProfits[9], "CompanyProfits:")))
                {
                    string table = "highscoresProfits";
                    string column = "CompanyProfits";
                    int position;

                    for (int i = 0; i < 9; i++)
                    {
                        if (currentCash > float.Parse(getDataValue(highscoresProfits[i], "CompanyProfits:")))
                        {
                            position = i+1;

                            userForm = new WWWForm();
                            userForm.AddField("tablePost", table);
                            userForm.AddField("positionPost", position);
                            userForm.AddField("columnNamePost", column);
                            userForm.AddField("scorePost", currentCash.ToString("F2"));
                            userForm.AddField("namePost", newUsername);
                            userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateHighscores.php", userForm);

                            i = 9; // exit loop as soon as position is found
                            newHighscoreTypeText.text = newHighscoreTypeText.text + "\n" + "Company Profits (crystals)";
                            newHighscoreRankText.text = newHighscoreRankText.text + "\n" + position;
                            newHighscoreScoreText.text = newHighscoreScoreText.text + "\n" + currentCash;

                            newHighscore = true; // user achieved a new highscore
                        }
                    }
                }

            }

        } else {
			// user failed
			this.WrapperGetGraphData();
			this.updateLeversAttempted();
			int attempts;
			if (currentLevel == 1) { // if short term
				attempts = leverAttempts [leversAttempted.IndexOf (currentLever)]; // get # attempts already made
				attempts += 1;
				leverAttempts [leversAttempted.IndexOf (currentLever)] = attempts; // increment + update to list

				if (currentLever == 1 || currentLever == 2) {
					if (helpTaxGiven == 1) {
						attempts = 0; // already given the help
					}
				} else if (currentLever == 3) {
					if (helpBorrowGiven == 1) {
						attempts = 0; // already given the help
					}
				} else {
					if (helpHarvestGiven == 1) {
						attempts = 0; // already given the help
					}
				}

				if (attempts > attemptsBeforeHelpShortTerm) {
					// additional help
					this.WrapperOegerHelp("I think I've got this figured out. Need some help?", "Yes please", "No thanks, I'll try again", "");
				} else {
					// give level summary and let user try again
					this.displayLevelSummary();
				}

			} else if (currentLevel == 2) { // if long term (individual levers)
                if (currentLever == 1)
                {
                    attempts = leverAttempts[leversAttempted.IndexOf(currentLever + 4)]; // get # attempts already made
                    attempts += 1;
                    leverAttempts[leversAttempted.IndexOf(currentLever + 4)] = attempts; // increment + update to list
                }
                else
                {
                    attempts = leverAttempts[leversAttempted.IndexOf(currentLever + 3)]; // get # attempts already made --> less one for tax-check lever
                    attempts += 1;
                    leverAttempts[leversAttempted.IndexOf(currentLever + 3)] = attempts; // increment + update to list
                }

                if (currentMonth != levelAimTimeFrame[currentLevel - 1] * 12)
                {
                    // only if company was not declared bankrupt already
                    if (attempts > attemptsBeforeHelpLongTerm)
                    { // additional help --> suggest to try a different lever
                        this.displayLevelSummary();
                    }
                    else
                    {
                        // let user try again
                        this.WrapperOegerHelp("Oh oh... Don't worry - lucky for you, we can time travel on Jupiter. I'll give you a do-over, but it's going to cost you...", "Yes please", "", "");
                    }
                }
                else
                {
                    this.WrapperOegerHelp("Your colony is bankrupt! Growth is sub-zero...", "Declare bankruptcy", "", "");
                }

				
			} else { // multi-lever option
				// let user try again
				this.WrapperOegerHelp ("Oh oh... Don't worry - lucky for you, we can time travel on Jupiter. I'll give you a do-over, but it's going to cost you...", "Yes please", "", "");
			}
		}
	}
    // ===========================

    // FUNCTION
    // UPDATE LEARNING PATH
    // ===========================
    void updateLearningPath()
    {
        string column = "";
        int attemptIndex = leversAttempted.Count;

        if (currentLevel == 1)
        {
            if (currentLever == 1)
            {
                column = "Tax";
            }
            else if (currentLever == 2)
            {
                column = "TaxCheck";
            }
            else if (currentLever == 3)
            {
                column = "Borrow";
            }
            else if (currentLever == 4)
            {
                column = "Harvest";
            }
        }
        else
        {
            if (currentLever == 1)
            {
                column = "TaxLT";
            }
            else if (currentLever == 3)
            {
                column = "BorrowLT";
            }
            else if (currentLever == 4)
            {
                column = "HarvestLT";
            }
            else if (currentLever == 8)
            {
                column = "TaxBorrow";
            }
            else if (currentLever == 9)
            {
                column = "TaxHarvest";
            }
            else
            {
                column = "BorrowHarvest";
            }
        }

        userForm = new WWWForm();
        userForm.AddField("columnPost", column);
        userForm.AddField("attemptIndexPost", attemptIndex);
        userForm.AddField("namePost", newUsername);
        userWeb = new WWW("http://www.jupiterourfinalhope.a2hosted.com/updateLearningPath.php", userForm);
    }
    // ===========================

    // FUNCTION
    // WRAPPER GET GRAPH DATA
    // ===========================
    void WrapperGetGraphData()
    {
        StartCoroutine(getGraphData());
    }
    // ===========================

    // FUNCTION
    // GET GRAPH DATA
    // ===========================
    IEnumerator getGraphData()
    {
        if (graphs[0] == 1 || graphs[1] == 1)
        {
            // own progression
            if (leversAttempted.Count > 7 || leversCompleted.Count == 7)
            {
                // in two-option level
                sliderProgress1.value = 1;
                sliderProgress2.value = 1;
                sliderProgress3.value = 0; // current level
            }
            else if (leversAttempted.Count == 7 || leversCompleted.Count == 6)
            {
                sliderProgress1.value = 1;
                sliderProgress2.value = 0.66f;// current level - last lever
                sliderProgress3.value = 0;
            }
            else if (leversAttempted.Count == 6)
            {
                sliderProgress1.value = 1;
                sliderProgress2.value = 0.33f;// current level - second lever
                sliderProgress3.value = 0;
            }
            else if (leversAttempted.Count == 5)
            {
                sliderProgress1.value = 1;
                sliderProgress2.value = 0;// current level - first lever
                sliderProgress3.value = 0;
            }
            else if (leversAttempted.Count == 4 || leversCompleted.Count == 3)
            {
                sliderProgress1.value = 0.75f;// current level - last lever
                sliderProgress2.value = 0;
                sliderProgress3.value = 0;
            }
            else if (leversAttempted.Count == 3 || leversCompleted.Count == 2)
            {
                sliderProgress1.value = 0.5f;// current level - third lever
                sliderProgress2.value = 0;
                sliderProgress3.value = 0;
            }
            else if (leversAttempted.Count == 2 || leversCompleted.Count == 1)
            {
                sliderProgress1.value = 0.25f;// current level - second lever
                sliderProgress2.value = 0;
                sliderProgress3.value = 0;
            }
            else
            {
                sliderProgress1.value = 0;// current level - first lever
                sliderProgress2.value = 0;
                sliderProgress3.value = 0;
            }
        }
        if (graphs[0] == 2 || graphs[1] == 2)
        {
            // own attempts per level
            pointList = new List<Vector2>();
            for (int i = 0; i < leversAttempted.Count; i++)
            {
                point = new Vector2((float)(-5 + i * 7), (float)(-22.5f + leverAttempts[i] * 7.5f));
                pointList.Add(point);
            }
            lineRendererLevelAttempts.Points = pointList.ToArray();
        }
        if (graphs[0] == 3 || graphs[1] == 3)
        {
            // top 3 progression
            WWW leaderboardDataProgression = new WWW("http://www.jupiterourfinalhope.a2hosted.com/highscoresProgressionData.php");
            yield return leaderboardDataProgression;
            string leaderboardDataProgressionString = leaderboardDataProgression.text;
            highscoresProgression = leaderboardDataProgressionString.Split(';');

            int count = highscoresProgression.Length;
            if (count > 3)
            {
                count = 3; // if there are more than 3 entries, only take top 3
            }

            pointList = new List<Vector2>();
            lineRendererProgressTop1.Points = pointList.ToArray();
            int progress = 0;
            progress = System.Convert.ToInt32(getDataValue(highscoresProgression[0], "Progression:"));
            point = new Vector2((float)(-5), 8.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + progress * 7), 8.0f);
            pointList.Add(point);
            lineRendererProgressTop1.Points = pointList.ToArray();

            pointList = new List<Vector2>();
            lineRendererProgressTop2.Points = pointList.ToArray();
            progress = System.Convert.ToInt32(getDataValue(highscoresProgression[1], "Progression:"));
            point = new Vector2((float)(-5), 0.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + progress * 7), 0.0f);
            pointList.Add(point);
            lineRendererProgressTop2.Points = pointList.ToArray();

            pointList = new List<Vector2>();
            lineRendererProgressTop3.Points = pointList.ToArray();
            progress = System.Convert.ToInt32(getDataValue(highscoresProgression[2], "Progression:"));
            point = new Vector2((float)(-5), -8.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + progress * 7), -8.0f);
            pointList.Add(point);
            lineRendererProgressTop3.Points = pointList.ToArray();

            float xPosition = (float)(1063.0f + leversAttempted.Count * 8.9f); 
            if (graphs[0] == 3)
            {
                yourProgressPositionImage.rectTransform.position = new Vector3(xPosition, 258, 0);
            }
            else
            {
                yourProgressPositionImage.rectTransform.position = new Vector3(xPosition, 182, 0);
            }
        }
        if (graphs[0] == 4 || graphs[1] == 4)
        {
            // top 3 growth in level
            WWW levelDataAttempts = new WWW("http://www.jupiterourfinalhope.a2hosted.com/getTopLevelAttempts.php");
            yield return levelDataAttempts;
            string levelDataAttemptsString = levelDataAttempts.text;
            levelAttemptsAndGrowth = levelDataAttemptsString.Split('/');


            float growth1 = 0.0f;
            float growth2 = 0.0f;
            float growth3 = 0.0f;
            string column = "";
            string totalString;
            float num = 0.0f;

            if (currentLevel == 1)
            {
                if (currentLever == 1)
                {
                    column = "TaxGrowth:";
                }
                else if (currentLever == 2)
                {
                    column = "TaxCheckGrowth:";
                }
                else if (currentLever == 3)
                {
                    column = "BorrowGrowth:";
                }
                else
                {
                    column = "HarvestGrowth:";
                }
            }
            else
            {
                if (currentLever == 1)
                {
                    column = "TaxLTGrowth";
                }
                else if (currentLever == 3)
                {
                    column = "BorrowLTGrowth";
                }
                else if (currentLever == 4)
                {
                    column = "HarvestLTGrowth";
                }
                else if (currentLever == 8)
                {
                    column = "TaxBorrowGrowth:";
                }
                else if (currentLever == 9)
                {
                    column = "TaxHarvestGrowth:";
                }
                else
                {
                    column = "BorrowHarvestGrowth:";
                }
            }

            for (int i = 0; i < levelAttemptsAndGrowth.Length - 1; i++)
            {
                totalString = getDataValue(levelAttemptsAndGrowth[i], column);
                if (totalString.Length > 2)
                {
                    num = float.Parse(totalString);
                    if (num > growth1)
                    {
                        growth1 = num;
                    }
                }
            }
            for (int i = 0; i < levelAttemptsAndGrowth.Length - 1; i++)
            {
                totalString = getDataValue(levelAttemptsAndGrowth[i], column);
                if (totalString.Length > 2)
                {
                    num = float.Parse(totalString);
                    if (num > growth2 && num != growth1)
                    {
                        growth2 = num;
                    }
                }
            }
            for (int i = 0; i < levelAttemptsAndGrowth.Length - 1; i++)
            {
                totalString = getDataValue(levelAttemptsAndGrowth[i], column);
                if (totalString.Length > 2)
                {
                    num = float.Parse(totalString);
                    if (num > growth3 && num != growth1 && num != growth2)
                    {
                        growth3 = num;
                    }
                }
            }

            
            pointList = new List<Vector2>();
            lineRendererGrowthTop1.Points = pointList.ToArray();
            point = new Vector2((float)(-5), 8.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + growth1 * 7), 8.0f);
            pointList.Add(point);
            lineRendererGrowthTop1.Points = pointList.ToArray();
            

            pointList = new List<Vector2>();
            lineRendererGrowthTop2.Points = pointList.ToArray();
            point = new Vector2((float)(-5), 0.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + growth2 * 7), 0.0f);
            pointList.Add(point);
            lineRendererGrowthTop2.Points = pointList.ToArray();
            

            pointList = new List<Vector2>();
            lineRendererGrowthTop3.Points = pointList.ToArray();
            point = new Vector2((float)(-5), -8.0f);
            pointList.Add(point);
            point = new Vector2((float)(-5 + growth3 * 7), -8.0f);
            pointList.Add(point);
            lineRendererGrowthTop3.Points = pointList.ToArray();
            
        }

        yield return new WaitForSeconds(0.2f);
    }
    // ===========================   


    // FUNCTION
    // DISPLAY LEVEL SUMMARY
    // ===========================
    void displayLevelSummary(){
        oeger.SetActive(false);

		levelSummaryScreen.SetActive (true);
		levelSummaryText.text = levelSummary;

		levelSummaryContinueButton.onClick.RemoveAllListeners ();

        if(leversAttempted.Count < 5)
        {
            levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Oh oh... Don't worry - lucky for you, we can time travel on Jupiter. I'll give you a do-over, but it's going to cost you...", "Yes please", "", ""));
        }
        else if (leversAttempted.Count == 7)
        { // all long term levers attempted (short term (4) + long term (3))
            if(leversAttempted[6] == 5)
            {
                // final attempt was tax
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close.", "Okay. What now?", "", ""));
            } else if (leversAttempted[6] == 6)
            {
                // final attempt was borrow
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything.", "Okay. What now?", "", ""));
            }
            else
            {
                // final attempt was harvest
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices.", "Okay. What now?", "", ""));
            }
           }
        else if (leversAttempted.Count == 6)
        { // only one long term lever remains
            if (!leversAttempted.Contains(5))
            {
                // only tax remains
                if(leversAttempted[5] == 6)
                {
                    // just attempted borrow
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything. Try the last one.", "Increase tax", "", ""));
                }
                else
                {
                    // just attempted harvest
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices. Try the last one.", "Increase tax", "", ""));
                }

                //levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("I'm stumped! The last hope lies in the final option. Enzer will be back soon!", "Increase tax", "", ""));
            }
            else if (!leversAttempted.Contains(6))
            {
                // only borrow remains
                if (leversAttempted[5] == 5)
                {
                    // just attempted tax
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close. Try the last one.", "Borrow crystals from you", "", ""));
                }
                else
                {
                    // just attempted harvest
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices. Try the last one.", "Borrow crystals from you", "", ""));
                }
              }
            else
            {
                // only harvest remains
                if (leversAttempted[5] == 5)
                {
                    // just attempted tax
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close. Try the last one.", "Harvest more crystals", "", ""));
                }
                else
                {
                    // just attempted borrow
                    levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything. Try the last one.", "Harvest more crystals", "", ""));
                }
            }
        }
        else
        { // only attempted one long term lever

            if (leversAttempted.Contains(5))
            {
                // only attempted tax
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. People can't afford the high tax rates, forcing companies to close. Maybe try another...", "Borrow crystals from you", "Harvest more crystals", ""));
            }
            else if (leversAttempted.Contains(6))
            {
                // only attempted borrow
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("Although this may have worked in the short term by resulting in investments by Enzer, it fails in the long term. Loans are paid back with interest - prices shoot through the roof and no one can afford anything. Maybe try another...", "Increase tax", "Harvest more crystals", ""));
            }
            else
            {
                // only attempted harvest
                levelSummaryContinueButton.onClick.AddListener(() => this.WrapperOegerHelp("It seems that although this may have worked in the short term since people have more money to spend, it fails in the long term. More money means higher demand and companies start increasing their prices. Maybe try another...", "Increase tax", "Borrow crystals from you", ""));
            }
        }

	}

    // ===========================

    // FUNCTION
    // WRAPPER ADD GAME FEED
    // ===========================
    void WrapperAddGameFeed(string message, bool firstEntry)
    {
        StartCoroutine(addGameFeed(message, firstEntry));
    }


    // ===========================

    // FUNCTION
    // ADD GAME FEED
    // ===========================
    IEnumerator addGameFeed(string message, bool firstEntry){
		gamefeedAudioSource.Play ();
		DateTime dt = DateTime.Parse (DateTime.Now.ToString());
		gamefeedText.text = dt.ToString ("HH:mm") + "\n" + message + "\n\n" + gamefeedText.text;

        if (firstEntry)
        {
            toolTipGamefeed.SetActive(true);
            toolTipGamefeedButton.onClick.RemoveAllListeners();
            toolTipGamefeedButton.onClick.AddListener(() => this.WrapperCloseToolTip(1));
            yield return new WaitForSeconds(1.5f);
            Time.timeScale = 0.0f;
            yield return new WaitWhile(toolTipGamefeedButton.IsActive);
            
        }
        else
        {
            toolTipGamefeed.SetActive(false);
        }
	}
    // ==========================
    // FUNCTION
    // WRAPPER CLOSE TOOL TIP
    // ==========================
    void WrapperCloseToolTip(int tip)
    {
        StartCoroutine(closeToolTip(tip));
    }

    // ==========================
    // FUNCTION
    // CLOSE TOOL TIP
    // ==========================
    IEnumerator closeToolTip(int tip)
    {
        Time.timeScale = 1.0f;
        if (tip == 1)
        {
            toolTipGamefeed.SetActive(false);
            toolTipGamefeedButton.gameObject.SetActive(false);
        } else if(tip == 2)
        {
            toolTipCompany.SetActive(false);
            toolTipCompanyButton.gameObject.SetActive(false);

            colonyStatusEmpty.SetActive(true);
            toolTipColony.SetActive(true);
            toolTipColonyButton.onClick.RemoveAllListeners();
            toolTipColonyButton.onClick.AddListener(() => this.WrapperCloseToolTip(3));
            Time.timeScale = 0.0f;
            yield return new WaitWhile(toolTipColonyButton.IsActive);


        } else if(tip == 3)
        {
            toolTipColony.SetActive(false);
            toolTipColonyButton.gameObject.SetActive(false);

            
            levelStatusEmpty.SetActive(true);
            toolTipStatus.SetActive(true);
            toolTipStatusButton.gameObject.SetActive(true);
            toolTipStatusButton.onClick.RemoveAllListeners();
            toolTipStatusButton.onClick.AddListener(() => this.WrapperCloseToolTip(4));
            Time.timeScale = 0.0f;
            yield return new WaitWhile(toolTipStatusButton.IsActive);
        } 
        else if(tip == 4)
        {
            levelAimScreen.gameObject.SetActive(false);
            toolTipStatus.SetActive(false);
            toolTipStatusButton.gameObject.SetActive(false);
            this.WrapperOegerHelp("I hope you're up to the challenge! We're all depending on you. What do you think we should do, you haven't got enough crystals for 12 months?", "Increase tax", "Borrow crystals from you", "Harvest more crystals");
        }
        else 
        {
            toolTipDashboard.SetActive(false);
            toolTipDashboardButton.gameObject.SetActive(false);
        }
    }


    // ===========================

    // FUNCTION
    // WRAPPER CLOSE COMPANY
    // ===========================
    void WrapperCloseCompany(int company){
		StartCoroutine (closeCompany (company));
	}
    // ===========================

    // FUNCTION
    // CLOSE COMPANY
    // ===========================
    IEnumerator closeCompany(int company){
		yield return new WaitForSeconds (3.0f);
		oeger.SetActive (false);
		this.WrapperAddGameFeed("A company in the colony closed down!",false);
		buildingAudioSource.Play ();
        // remove building
		companyBuildings [company].SetActive (false);

        // get location of company closed
        int num = 0;
        for(int i = 0; i < 6; i++)
        {
            if (companyBuildings[company].transform.position == companyLocations[i])
            {
                num = i;
                i = 5; // exit the loop
            }
        }
        // activate demolition smoke
        smokeEffects[num].gameObject.SetActive(true);
	}
    // ===========================

    // FUNCTION
    // LOAD CUSTOMISE YOUR DASHBOARD
    // ===========================
    void loadCustomiseYourDashboard(){
		Time.timeScale = 0.0f; // pause gameplay
		inCustomise = true;
		dashboard.SetActive (false);

		graphProgress.SetActive (false);
		graphAttempts.SetActive (false);
		graphTop3Progress.SetActive (false);
		graphTop3Growth.SetActive (false);

		customiseDashboardScreen.SetActive (true);
	}
    // ===========================

    // FUNCTION
    // UPDATE DASHBOARD
    // ===========================
    void updateDashboard(int [] choice){
		customiseDashboardScreen.SetActive (false);
		dashboard.SetActive (true);
		for (int i = 0; i < 2; i++) {
			if (choice [i] == 1) {
				graphProgress.SetActive (true);
				graphProgress.transform.position = dashboardPositionTransform [i].position;
				graphs[i] = 1;
			} else if (choice [i] == 2) {
				graphAttempts.SetActive (true);
				graphAttempts.transform.position = dashboardPositionTransform [i].position;
				graphs[i] = 2;
			} else if (choice [i] == 3) {
				graphTop3Progress.SetActive (true);
				graphTop3Progress.transform.position = dashboardPositionTransform [i].position;
				graphs[i] = 3;
			} else {
				graphTop3Growth.SetActive (true);
				graphTop3Growth.transform.position = dashboardPositionTransform [i].position;
				graphs[i] = 4;
			}
		}
		this.updateGraphsChosen(choice);
		this.WrapperGetGraphData();
		Time.timeScale = 1.0f; // unpause time
	}
    // ===========================

    // FUNCTION
    // UPDATE
    // ===========================
    void Update () { // called once per frame
		slider1ValueText.text = slider1.value.ToString ("F2");
		slider2ValueText.text = slider2.value.ToString ("F2");
		gameplayCash.text = currentCash.ToString ();

		if (inCustomise) {
			// display correct preview graphs
			int option1 = dashboardOption1.value;
			int option2 = dashboardOption2.value;

			for (int i = 0; i < previewGraphs1.Length; i++) {
				if (i == option1) {
					previewGraphs1 [i].SetActive (true);
					previewOption1Description.text = graphDescriptions [i];
				} else {
					previewGraphs1 [i].SetActive (false);
				}
			}
			for (int i = 0; i < previewGraphs2.Length; i++) {
				if (i == option2) {
					previewGraphs2 [i].SetActive (true);
					previewOption2Description.text = graphDescriptions [i];
				} else {
					previewGraphs2 [i].SetActive (false);
				}
			}

        }
        // CHECK FOR SUB-ZERO GROWTH IN LT LEVELS
        if (currentLevel > 1 && colonyGrowth < 0)
        {
            currentMonth = levelAimTimeFrame[currentLevel - 1] * 12; // fast-forward to the end of the simulation
        }

        // add correct listener to button
        applyDashboardChangesButton.onClick.RemoveAllListeners();
        int[] graphs = new int[2];
        graphs[0] = dashboardOption1.value + 1;
        graphs[1] = dashboardOption2.value + 1;
        applyDashboardChangesButton.onClick.AddListener(() => this.updateDashboard(graphs));

        if (paused)
        {
            Time.timeScale = 0.0f;
            gameTipScreen.SetActive(true);

            if (oegerCollided)
            {
                introIconOeger.SetActive(false);
                
                gameTipHeadingText.text = "HELLO";
                oegerCharacter.SetActive(true);

                gameTipIntroText.gameObject.SetActive(true);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false);
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);
                
                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(1));
            }
            else if (crystalsCollided)
            {
                introIconCrystals.SetActive(false);

                gameTipHeadingText.text = "CRYSTALS";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(true);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false);
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(2));
            }
            else if (fleetCollided)
            {
                introIconFleet.SetActive(false);

                gameTipHeadingText.text = "YOUR FLEET";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(true);
                gameTipCompanyText.gameObject.SetActive(false);
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(3));
            }
            else if (locationCollided)
            {
                introIconLocation.SetActive(false);

                gameTipHeadingText.text = "CHOOSING YOUR BASE";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(true);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(4));
            }
            else if (location1Collided)
            {
                introIconLocation1.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(true);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(5));
            }
            else if (location2Collided)
            {
                introIconLocation2.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(true);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(6));
            }
            else if (location3Collided)
            {
                introIconLocation3.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(true);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(7));
            }
            else if (location4Collided)
            {
                introIconLocation4.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(true);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(8));
            }
            else if (location5Collided)
            {
                introIconLocation5.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(true);
                gameTipLocationFinalText.gameObject.SetActive(false);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(9));
            }
            else
            {
                introIconLocation6.SetActive(false);

                gameTipHeadingText.text = "LOCATION";

                gameTipIntroText.gameObject.SetActive(false);
                gameTipCrystalsText.gameObject.SetActive(false);
                gameTipFleetText.gameObject.SetActive(false);
                gameTipCompanyText.gameObject.SetActive(false); // not using this one for now (using original menus to select type of company since can't really "explore" this)
                gameTipLocationIntroText.gameObject.SetActive(false);
                gameTipLocation1Text.gameObject.SetActive(false);
                gameTipLocation2Text.gameObject.SetActive(false);
                gameTipLocation3Text.gameObject.SetActive(false);
                gameTipLocation4Text.gameObject.SetActive(false);
                gameTipLocation5Text.gameObject.SetActive(false);
                gameTipLocationFinalText.gameObject.SetActive(true);

                gameTipButton.gameObject.SetActive(true);
                gameTipButton.onClick.RemoveAllListeners();
                gameTipButton.onClick.AddListener(() => this.updateIntroIcon(10));
            }
        }
       
    }

    // ===========================

    // FUNCTION
    // ACTIVATE NEXT GAME TIP ICON
    // ===========================
    void updateIntroIcon(int icon)
    {
        Time.timeScale = 1.0f; // unpause game
        paused = false;
        gameTipScreen.SetActive(false);

        if (icon == 1)
        {
            oegerCharacter.gameObject.SetActive(false);
            introIconCrystals.SetActive(true);
            oegerCollided = false; // to loop past it in detection loop
        } else if (icon == 2)
        {
            introIconFleet.SetActive(true);
            crystalsCollided = false; // to loop past it in detection loop
        } else if (icon == 3)
        {
            introIconLocation.SetActive(true);
            fleetCollided = false; // to loop past it in detection loop
        } else if (icon == 4)
        {
            introIconLocation1.SetActive(true);
            locationCollided = false; // to loop past it in detection loop
        } else if (icon == 5)
        {
            introIconLocation2.SetActive(true);
            location1Collided = false; // to loop past it in detection loop
        } else if (icon == 6)
        {
            introIconLocation3.SetActive(true);
            location2Collided = false; // to loop past it in detection loop
        } else if (icon == 7)
        {
            introIconLocation4.SetActive(true);
            location3Collided = false; // to loop past it in detection loop
        } else if (icon == 8)
        {
            introIconLocation5.SetActive(true);
            location4Collided = false; // to loop past it in detection loop
        } else if (icon == 9)
        {
            introIconLocation6.SetActive(true);
            location5Collided = false; // to loop past it in detection loop
        } else
        {
            location6Collided = false; // to loop past it in detection loop
            gameTipScreen.SetActive(false);
            this.loadCompanyChoiceScreen(1);
        }
    }
    // ===========================

    // FUNCTION
    // UPDATE LEVERS ATTEMPTED
    // ===========================
    void updateLeversAttempted(){
		string column = "";
		int numLeversAttempted = leversAttempted.Count;
		string attemptsValues = leverAttempts[numLeversAttempted-1].ToString() + ";";

		for(int i = 0; i < leverAttempts[numLeversAttempted-1]; i ++){
			if(i == 0){
				attemptsValues += leverValues[numLeversAttempted-1+i].ToString("F2");
			} else {
				attemptsValues += "," + leverValues[numLeversAttempted-1+i].ToString("F2"); // add "," to separate values
			}
		}
        if (currentLevel == 1){
            if (currentLever == 1) {
                column = "Tax";
            }
            else if (currentLever == 2){
                column = "TaxCheck";
            }
            else if (currentLever == 3){
                column = "Borrow";
            } else {
                column = "Harvest";
            }
        }
        else {
            if (currentLever == 1){
                column = "TaxLT";
            }
            else if (currentLever == 3) {
                column = "BorrowLT";
            }
            else if (currentLever == 4){
                column = "HarvestLT";
            }
            else if (currentLever == 8){
                column = "TaxBorrow";
            }
            else if (currentLever == 9) {
                column = "TaxHarvest";
            }
            else{
                column = "BorrowHarvest";
            }
        }
		 
			
		userForm = new WWWForm ();
		userForm.AddField("columnPost", column);
		userForm.AddField("attemptsValuesPost", attemptsValues);
		userForm.AddField("namePost", newUsername);
		userWeb = new WWW ("http://www.jupiterourfinalhope.a2hosted.com/updateLeversAttempted.php", userForm);

		if(leverIsComplete){
			attemptsValues = colonyGrowth.ToString("F2");
			if(currentLever == 1){
				column = "TaxGrowth";
			} else if(currentLever == 2){
				column = "TaxCheckGrowth";
			} else if(currentLever == 3){
				column = "BorrowGrowth";
			} else if (currentLever == 4){
				column = "HarvestGrowth";
			} else if (currentLever == 8){ // individual LT levers left out since growth will always be 0
				column = "TaxBorrowGrowth";
			} else if (currentLever == 9){
				column = "TaxHarvestGrowth";
			} else if (currentLever == 10){
				column = "BorrowHarvestGrowth";
			}

		}
		userForm = new WWWForm (); // add second form to write growth to database
		userForm.AddField("columnPost", column);
		userForm.AddField("attemptsValuesPost", attemptsValues);
		userForm.AddField("namePost", newUsername);
		userWeb = new WWW ("http://www.jupiterourfinalhope.a2hosted.com/updateLeversAttempted.php", userForm);
	}
    // ===========================

    // FUNCTION
    // UPDATE GRAPHS CHOSEN
    // ===========================
    void updateGraphsChosen(int [] choice){
		graph1Chosen += choice [0].ToString ();
		graph2Chosen += choice [1].ToString ();
		userForm = new WWWForm ();
		userForm.AddField("graph1Post", graph1Chosen);
		userForm.AddField("graph2Post", graph2Chosen);
		userForm.AddField("namePost", newUsername);
		userWeb = new WWW ("http://www.jupiterourfinalhope.a2hosted.com/updateGraphsChosen.php", userForm);
	}
    // ===========================

    // FUNCTION
    // UPDATE RECOMMENDATIONS HELP
    // ===========================
    void updateRecommendationHelp(int item){
		string column = "";
		string input = "";
		if (item == 1) {
			column = "Recommendation1GivenTakenDirectlyIndirectly";
			if (recommendationFollowedDirectly) {
				// recommendation followed directly without viewing all options
				input = "1;1";
			} else if (recommendationFollowedIndirectly) {
				// recommendation followed after viewing all options
				input = "1;0;1";
			} else {
				// recommendation not followed at all
				input = "1;0;0";
			}
		} else if (item == 2) {
            column = "HelpTaxGivenTaken";
            if (helpTaxTaken == 1) {
				// help taken 
				input = "1;1";
			} else {
				// help not taken
				input = "1;0";
			}
		} else if (item == 3) {
			column = "HelpBorrowGivenTaken";
			if (helpBorrowTaken == 1) {
				// help taken 
				input = "1;1";
			} else {
				// help not taken
				input = "1;0";
			}
		} else {
			column = "HelpHarvestGivenTaken";
			if (helpHarvestTaken == 1) {
				// help taken 
				input = "1;1";
			} else {
				// help not taken
				input = "1;0";
			}
		} 
		userForm = new WWWForm ();
		userForm.AddField("columnPost", column);
		userForm.AddField("inputPost", input);
		userForm.AddField("namePost", newUsername);
		userWeb = new WWW ("http://www.jupiterourfinalhope.a2hosted.com/updateRecommendHelp.php", userForm);
	}
    // ===========================

    // FUNCTION
    // CONTINUE TO END GAME SCREEN
    // ===========================
    void continueToEndGameScreen()
    {
        newHighscoreScreen.gameObject.SetActive(false);
        endGameStartFeedbackScreen.SetActive(true);
        continueToFeedbackButton.onClick.RemoveAllListeners();
        continueToFeedbackButton.onClick.AddListener(() => WrapperLoadPretest(0, false));
    }
    // ===========================

    // FUNCTION
    // CONFIRM QUIT
    // ===========================
    void confirmQuit()
    {
        Time.timeScale = 0.0f;
        confirmQuitScreen.gameObject.SetActive(true);

        confirmQuitButton.onClick.RemoveAllListeners();
        confirmNoQuitButton.onClick.RemoveAllListeners();

        confirmNoQuitButton.onClick.AddListener(() => this.unpause());
        confirmQuitButton.onClick.AddListener(() => this.quitGiveFeedback());
       
    }
    // ===========================

    // FUNCTION
    // UNPAUSE
    // ===========================
    void unpause()
    {
        confirmQuitScreen.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
    // ===========================

    // FUNCTION
    // QUIT GIVE FEEDBACK
    // ===========================
    void quitGiveFeedback()
    {
        confirmQuitScreen.gameObject.SetActive(false);
        quitPleaseGiveFeedbackScreen.SetActive(true);

        quitFeedbackHelpButton.onClick.RemoveAllListeners();
        quitFeedbackNoButton.onClick.RemoveAllListeners();
        
        quitFeedbackHelpButton.onClick.AddListener(() => this.WrapperLoadPretest(0, false));
        quitFeedbackNoButton.onClick.AddListener(() => Application.Quit());
    }
    // ===========================


}
