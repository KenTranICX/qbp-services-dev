namespace DocumentGenerator.API.Core.Models.RAV.Individuals
{
  public class Rootobject
  {
    public Rootschema rootSchema { get; set; }
    public Mainschemas mainSchemas { get; set; }
    public Appconfigurations appConfigurations { get; set; }
    public Formdatatemplate formDataTemplate { get; set; }
  }

  public class Rootschema
  {
  }

  public class Mainschemas
  {
    public Dodformschema dodFormSchema { get; set; }
    public Purchaseschema[] purchaseSchema { get; set; }
  }

  public class Dodformschema
  {
    public Formschema formSchema { get; set; }
    public Formuischemagroup[] formUiSchemaGroup { get; set; }
    public Formuischema formUiSchema { get; set; }
    public Subformschemas subFormSchemas { get; set; }
  }

  public class Formschema
  {
    public string type { get; set; }
    public Properties properties { get; set; }
  }

  public class Properties
  {
    public Pageheader pageHeader { get; set; }
    public Disclosureagreementsection disclosureAgreementSection { get; set; }
    public Iagreebutton iAgreeButton { get; set; }
  }

  public class Pageheader
  {
    public string type { get; set; }
  }

  public class Disclosureagreementsection
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Iagreebutton
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Formuischema
  {
    public Iagreebutton1 iAgreeButton { get; set; }
    public Pageheader1 pageHeader { get; set; }
  }

  public class Iagreebutton1
  {
    public string uiwidget { get; set; }
    public UiOptions uioptions { get; set; }
  }

  public class UiOptions
  {
    public bool label { get; set; }
    public string classNames { get; set; }
  }

  public class Pageheader1
  {
    public string uiwidget { get; set; }
    public UiOptions1 uioptions { get; set; }
  }

  public class UiOptions1
  {
    public bool label { get; set; }
    public string classNames { get; set; }
  }

  public class Subformschemas
  {
    public Pageheader2 pageHeader { get; set; }
  }

  public class Pageheader2
  {
    public string logoUrl { get; set; }
    public string companyName { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Formuischemagroup
  {
    public ColMdOffset2ColMd8Pl1Pr1Pt3[] colmdoffset2colmd8pl1pr1pt3 { get; set; }
    public string uitemplate { get; set; }
  }

  public class ColMdOffset2ColMd8Pl1Pr1Pt3
  {
    public string[] _ { get; set; }
    public string uitemplate { get; set; }
  }

  public class Purchaseschema
  {
    public Formschema1 formSchema { get; set; }
    public Formuischemagroup1[] formUiSchemaGroup { get; set; }
    public Formuischema1 formUiSchema { get; set; }
    public Subformschemas1 subFormSchemas { get; set; }
  }

  public class Formschema1
  {
    public Definitions definitions { get; set; }
    public string type { get; set; }
    public Properties1 properties { get; set; }
    public Dependencies dependencies { get; set; }
    public string[] required { get; set; }
  }

  public class Definitions
  {
  }

  public class Properties1
  {
    public Insinfoheader InsInfoHeader { get; set; }
    public Membinfoheader MembInfoHeader { get; set; }
    public Businfoheader BusInfoHeader { get; set; }
    public Memb Memb { get; set; }
    public Membnum MembNum { get; set; }
    public Insuredname InsuredName { get; set; }
    public Email Email { get; set; }
    public Phonenumber PhoneNumber { get; set; }
    public Principaladdress PrincipalAddress { get; set; }
    public Statesandterritoriesoperated StatesAndTerritoriesOperated { get; set; }
    public Businessactivities BusinessActivities { get; set; }
    public Numberofyearsoperating NumberOfYearsOperating { get; set; }
    public Entitytype EntityType { get; set; }
    public Totalgrossrevenue TotalGrossRevenue { get; set; }
    public Engvolunteer EngVolunteer { get; set; }
    public Lstyearvolunteer LstYearVolunteer { get; set; }
    public Minagevolunteer MinAgeVolunteer { get; set; }
    public Maxagevolunteer MaxAgeVolunteer { get; set; }
    public Busactivityheader BusActivityHeader { get; set; }
    public Numberofeventsheld NumberOfEventsHeld { get; set; }
    public Averageattendeesperevent AverageAttendeesPerEvent { get; set; }
    public Engagecontractorsorsubcontractors EngageContractorsOrSubcontractors { get; set; }
    public Assumeliabilityundercontractorholdharmless AssumeLiabilityUnderContractOrHoldHarmless { get; set; }
    public Contractorshaveliabilityinsurance ContractorsHaveLiabilityInsurance { get; set; }
    public Maintainstrictqualitycontrolprogram MaintainStrictQualityControlProgram { get; set; }
    public Performworkoutsideaustralia PerformWorkOutsideAustralia { get; set; }
    public Detailsofworkoutsideaustralia DetailsOfWorkOutsideAustralia { get; set; }
    public Carryordistributehazardousitems CarryOrDistributeHazardousItems { get; set; }
    public Hazardousitems hazardousItems { get; set; }
    public Suspbrkinfoheader SuspBrkInfoHeader { get; set; }
    public Abilitytomeetdebts abilityToMeetDebts { get; set; }
    public Undergoingemployeechanges undergoingEmployeeChanges { get; set; }
    public Convictedofcriminaloffense convictedOfCriminalOffense { get; set; }
    public Declaredbankrupt declaredBankrupt { get; set; }
    public Claimsmadeinpast5years claimsMadeInPast5Years { get; set; }
    public Madeclaimoninsurance madeClaimOnInsurance { get; set; }
    public Experiencedfraudorcrime experiencedFraudOrCrime { get; set; }
    public Insurerdeclinedinsurance insurerDeclinedInsurance { get; set; }
    public Subjectofcomplaint subjectOfComplaint { get; set; }
    public Subjecttotaxaudit subjectToTaxAudit { get; set; }
    public Awareofclaimrisks awareOfClaimRisks { get; set; }
    public Formcompletedheader formCompletedHeader { get; set; }
  }

  public class Insinfoheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Membinfoheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Businfoheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Memb
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Membnum
  {
  }

  public class Insuredname
  {
    public string type { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Email
  {
    public string type { get; set; }
    public string format { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Phonenumber
  {
    public string type { get; set; }
    public string title { get; set; }
    public int minLength { get; set; }
    public int maxLength { get; set; }
    public string pattern { get; set; }
  }

  public class Principaladdress
  {
    public string type { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Statesandterritoriesoperated
  {
    public string type { get; set; }
    public string title { get; set; }
    public bool uniqueItems { get; set; }
    public Items items { get; set; }
  }

  public class Items
  {
    public string[] _enum { get; set; }
  }

  public class Businessactivities
  {
    public string type { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Numberofyearsoperating
  {
    public string type { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Entitytype
  {
    public string type { get; set; }
    public string title { get; set; }
    public string[] _enum { get; set; }
  }

  public class Totalgrossrevenue
  {
    public string type { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Engvolunteer
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Lstyearvolunteer
  {
  }

  public class Minagevolunteer
  {
  }

  public class Maxagevolunteer
  {
  }

  public class Busactivityheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Numberofeventsheld
  {
    public string type { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Averageattendeesperevent
  {
    public string type { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Engagecontractorsorsubcontractors
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Assumeliabilityundercontractorholdharmless
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Contractorshaveliabilityinsurance
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Maintainstrictqualitycontrolprogram
  {
    public string type { get; set; }
    public string title { get; set; }
    public string[] _enum { get; set; }
  }

  public class Performworkoutsideaustralia
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Detailsofworkoutsideaustralia
  {
  }

  public class Carryordistributehazardousitems
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Hazardousitems
  {
  }

  public class Suspbrkinfoheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Abilitytomeetdebts
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Undergoingemployeechanges
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Convictedofcriminaloffense
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Declaredbankrupt
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Claimsmadeinpast5years
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Madeclaimoninsurance
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Experiencedfraudorcrime
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Insurerdeclinedinsurance
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Subjectofcomplaint
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Subjecttotaxaudit
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Awareofclaimrisks
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Formcompletedheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Dependencies
  {
    public Memb1 Memb { get; set; }
    public Engvolunteer1 EngVolunteer { get; set; }
    public Performworkoutsideaustralia1 PerformWorkOutsideAustralia { get; set; }
    public Carryordistributehazardousitems1 CarryOrDistributeHazardousItems { get; set; }
  }

  public class Memb1
  {
    public Oneof[] oneOf { get; set; }
  }

  public class Oneof
  {
    public Properties2 properties { get; set; }
  }

  public class Properties2
  {
    public Memb2 Memb { get; set; }
    public Membnum1 MembNum { get; set; }
  }

  public class Memb2
  {
    public bool[] _enum { get; set; }
  }

  public class Membnum1
  {
    public string type { get; set; }
    public bool hideReset { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Engvolunteer1
  {
    public Oneof1[] oneOf { get; set; }
  }

  public class Oneof1
  {
    public Properties3 properties { get; set; }
    public string[] required { get; set; }
  }

  public class Properties3
  {
    public Engvolunteer2 EngVolunteer { get; set; }
    public Lstyearvolunteer1 LstYearVolunteer { get; set; }
    public Minagevolunteer1 MinAgeVolunteer { get; set; }
    public Maxagevolunteer1 MaxAgeVolunteer { get; set; }
  }

  public class Engvolunteer2
  {
    public bool[] _enum { get; set; }
  }

  public class Lstyearvolunteer1
  {
    public string type { get; set; }
    public bool hideReset { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Minagevolunteer1
  {
    public string type { get; set; }
    public bool hideReset { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Maxagevolunteer1
  {
    public string type { get; set; }
    public bool hideReset { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
    public string title { get; set; }
  }

  public class Performworkoutsideaustralia1
  {
    public Oneof2[] oneOf { get; set; }
  }

  public class Oneof2
  {
    public Properties4 properties { get; set; }
    public string[] required { get; set; }
  }

  public class Properties4
  {
    public Performworkoutsideaustralia2 PerformWorkOutsideAustralia { get; set; }
    public Detailsofworkoutsideaustralia1 DetailsOfWorkOutsideAustralia { get; set; }
  }

  public class Performworkoutsideaustralia2
  {
    public bool[] _enum { get; set; }
  }

  public class Detailsofworkoutsideaustralia1
  {
    public string type { get; set; }
    public bool hideReset { get; set; }
    public int maxLength { get; set; }
    public string title { get; set; }
  }

  public class Carryordistributehazardousitems1
  {
    public Oneof3[] oneOf { get; set; }
  }

  public class Oneof3
  {
    public Properties5 properties { get; set; }
    public string[] required { get; set; }
  }

  public class Properties5
  {
    public Carryordistributehazardousitems2 CarryOrDistributeHazardousItems { get; set; }
    public Hazardousitems1 hazardousItems { get; set; }
  }

  public class Carryordistributehazardousitems2
  {
    public bool[] _enum { get; set; }
  }

  public class Hazardousitems1
  {
    public string type { get; set; }
    public Items1 items { get; set; }
    public bool uniqueItems { get; set; }
    public bool hideReset { get; set; }
    public string title { get; set; }
  }

  public class Items1
  {
    public string[] _enum { get; set; }
  }

  public class Formuischema1
  {
    public Memb3 Memb { get; set; }
    public Engvolunteer3 EngVolunteer { get; set; }
    public Membnum2 MembNum { get; set; }
    public Lstyearvolunteer2 LstYearVolunteer { get; set; }
    public Minagevolunteer2 MinAgeVolunteer { get; set; }
    public Maxagevolunteer2 MaxAgeVolunteer { get; set; }
    public Insuredname1 InsuredName { get; set; }
    public Email1 Email { get; set; }
    public Phonenumber1 PhoneNumber { get; set; }
    public Principaladdress1 PrincipalAddress { get; set; }
    public Businessactivities1 BusinessActivities { get; set; }
    public Statesandterritoriesoperated1 StatesAndTerritoriesOperated { get; set; }
    public Numberofyearsoperating1 NumberOfYearsOperating { get; set; }
    public Totalgrossrevenue1 TotalGrossRevenue { get; set; }
    public Numberofeventsheld1 NumberOfEventsHeld { get; set; }
    public Averageattendeesperevent1 AverageAttendeesPerEvent { get; set; }
    public Engagecontractorsorsubcontractors1 EngageContractorsOrSubcontractors { get; set; }
    public Assumeliabilityundercontractorholdharmless1 AssumeLiabilityUnderContractOrHoldHarmless { get; set; }
    public Contractorshaveliabilityinsurance1 ContractorsHaveLiabilityInsurance { get; set; }
    public Performworkoutsideaustralia3 PerformWorkOutsideAustralia { get; set; }
    public Detailsofworkoutsideaustralia2 DetailsOfWorkOutsideAustralia { get; set; }
    public Carryordistributehazardousitems3 CarryOrDistributeHazardousItems { get; set; }
    public Hazardousitems2 hazardousItems { get; set; }
    public Abilitytomeetdebts1 abilityToMeetDebts { get; set; }
    public Convictedofcriminaloffense1 convictedOfCriminalOffense { get; set; }
    public Declaredbankrupt1 declaredBankrupt { get; set; }
    public Claimsmadeinpast5years1 claimsMadeInPast5Years { get; set; }
    public Madeclaimoninsurance1 madeClaimOnInsurance { get; set; }
    public Experiencedfraudorcrime1 experiencedFraudOrCrime { get; set; }
    public Insurerdeclinedinsurance1 insurerDeclinedInsurance { get; set; }
    public Subjectofcomplaint1 subjectOfComplaint { get; set; }
    public Subjecttotaxaudit1 subjectToTaxAudit { get; set; }
    public Undergoingemployeechanges1 undergoingEmployeeChanges { get; set; }
    public Awareofclaimrisks1 awareOfClaimRisks { get; set; }
  }

  public class Memb3
  {
    public string uiwidget { get; set; }
  }

  public class Engvolunteer3
  {
    public string uiwidget { get; set; }
  }

  public class Membnum2
  {
    public string uiwidget { get; set; }
  }

  public class Lstyearvolunteer2
  {
    public string uiwidget { get; set; }
  }

  public class Minagevolunteer2
  {
    public string uiwidget { get; set; }
  }

  public class Maxagevolunteer2
  {
    public string uiwidget { get; set; }
  }

  public class Insuredname1
  {
    public string uiwidget { get; set; }
  }

  public class Email1
  {
    public string uiwidget { get; set; }
  }

  public class Phonenumber1
  {
    public string uiwidget { get; set; }
  }

  public class Principaladdress1
  {
    public string uiwidget { get; set; }
  }

  public class Businessactivities1
  {
    public string uiwidget { get; set; }
  }

  public class Statesandterritoriesoperated1
  {
    public string uiwidget { get; set; }
  }

  public class Numberofyearsoperating1
  {
    public string uiwidget { get; set; }
  }

  public class Totalgrossrevenue1
  {
    public string uiwidget { get; set; }
  }

  public class Numberofeventsheld1
  {
    public string uiwidget { get; set; }
  }

  public class Averageattendeesperevent1
  {
    public string uiwidget { get; set; }
  }

  public class Engagecontractorsorsubcontractors1
  {
    public string uiwidget { get; set; }
  }

  public class Assumeliabilityundercontractorholdharmless1
  {
    public string uiwidget { get; set; }
    public string uihelp { get; set; }
  }

  public class Contractorshaveliabilityinsurance1
  {
    public string uiwidget { get; set; }
  }

  public class Performworkoutsideaustralia3
  {
    public string uiwidget { get; set; }
  }

  public class Detailsofworkoutsideaustralia2
  {
    public string uiwidget { get; set; }
  }

  public class Carryordistributehazardousitems3
  {
    public string uiwidget { get; set; }
  }

  public class Hazardousitems2
  {
    public string uiwidget { get; set; }
  }

  public class Abilitytomeetdebts1
  {
    public string uiwidget { get; set; }
  }

  public class Convictedofcriminaloffense1
  {
    public string uiwidget { get; set; }
  }

  public class Declaredbankrupt1
  {
    public string uiwidget { get; set; }
  }

  public class Claimsmadeinpast5years1
  {
    public string uiwidget { get; set; }
  }

  public class Madeclaimoninsurance1
  {
    public string uiwidget { get; set; }
  }

  public class Experiencedfraudorcrime1
  {
    public string uiwidget { get; set; }
  }

  public class Insurerdeclinedinsurance1
  {
    public string uiwidget { get; set; }
  }

  public class Subjectofcomplaint1
  {
    public string uiwidget { get; set; }
  }

  public class Subjecttotaxaudit1
  {
    public string uiwidget { get; set; }
  }

  public class Undergoingemployeechanges1
  {
    public string uiwidget { get; set; }
  }

  public class Awareofclaimrisks1
  {
    public string uiwidget { get; set; }
  }

  public class Subformschemas1
  {
  }

  public class Formuischemagroup1
  {
    public TitleStep01DescriptionBusinessInformation[] titleStep01descriptionBusinessInformation { get; set; }
    public object[] title02descriptionBusinessActivity { get; set; }
    public object[] title03descriptionDeclaration { get; set; }
    public string uitemplate { get; set; }
    public object[] title01descriptionBusinessInformation { get; set; }
    public TitleStep02DescriptionBusinessActivity[] titleStep02descriptionBusinessActivity { get; set; }
    public TitleStep03DescriptionDeclaration[] titleStep03descriptionDeclaration { get; set; }
  }

  public class TitleStep01DescriptionBusinessInformation
  {
    public string[] MembInfoSection { get; set; }
    public string uitemplate { get; set; }
    public string[] BusinessInfoSection { get; set; }
    public string[] BusinessInfoSection2 { get; set; }
  }

  public class TitleStep02DescriptionBusinessActivity
  {
    public string[] membershipSection { get; set; }
    public string uitemplate { get; set; }
  }

  public class TitleStep03DescriptionDeclaration
  {
    public Page1[] page1 { get; set; }
    public Page2[] page2 { get; set; }
  }

  public class Page1
  {
    public string[] DeclarationSection { get; set; }
    public string uitemplate { get; set; }
  }

  public class Page2
  {
    public string[] completed { get; set; }
    public string uitemplate { get; set; }
  }

  public class Appconfigurations
  {
    public Purchasingflow purchasingFlow { get; set; }
  }

  public class Purchasingflow
  {
    public bool useDefaultFlow { get; set; }
    public string[] buttonLabels { get; set; }
    public string[] purchasingStages { get; set; }
  }

  public class Formdatatemplate
  {
  }

}
