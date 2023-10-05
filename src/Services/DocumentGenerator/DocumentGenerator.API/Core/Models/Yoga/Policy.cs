namespace DocumentGenerator.API.Core.Models.Yoga
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
    public string[] required { get; set; }
    public Properties6 properties { get; set; }
    public Dependencies1 dependencies { get; set; }
  }

  public class Definitions
  {
    public Modalitiesperformenum modalitiesPerformEnum { get; set; }
    public Stateenum stateEnum { get; set; }
    public Countryenum countryEnum { get; set; }
    public Registeredaddress registeredAddress { get; set; }
    public Pilenum PILEnum { get; set; }
    public Pllenum PLLEnum { get; set; }
    public Smallbusinessnswstampduty smallBusinessNSWStampDuty { get; set; }
    public Smallbusinessnswstampdutycovertext smallBusinessNSWStampDutyCoverText { get; set; }
    public Nswstampdutygroup nswStampDutyGroup { get; set; }
    public Gpicovertext gpiCoverText { get; set; }
    public Purchaseextraquestions purchaseExtraQuestions { get; set; }
    public Email email { get; set; }
    public Billingaddress billingAddress { get; set; }
  }

  public class Modalitiesperformenum
  {
    public string type { get; set; }
    public string[] _enum { get; set; }
  }

  public class Stateenum
  {
    public string type { get; set; }
    public string title { get; set; }
    public string[] _enum { get; set; }
  }

  public class Countryenum
  {
    public string type { get; set; }
    public string title { get; set; }
    public string _default { get; set; }
    public string[] _enum { get; set; }
  }

  public class Registeredaddress
  {
    public string type { get; set; }
    public string title { get; set; }
    public Properties1 properties { get; set; }
    public string columnTitle { get; set; }
  }

  public class Properties1
  {
    public Addressline addressLine { get; set; }
    public Addressline2 addressLine2 { get; set; }
    public Addressstate addressState { get; set; }
    public Addresspostcode addressPostcode { get; set; }
    public Addresscountry addressCountry { get; set; }
    public Fulladdress fullAddress { get; set; }
  }

  public class Addressline
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addressline2
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addressstate
  {
    public string _ref { get; set; }
  }

  public class Addresspostcode
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addresscountry
  {
    public string _ref { get; set; }
  }

  public class Fulladdress
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Pilenum
  {
    public string type { get; set; }
    public string[] _enum { get; set; }
  }

  public class Pllenum
  {
    public string type { get; set; }
    public string[] _enum { get; set; }
  }

  public class Smallbusinessnswstampduty
  {
    public string type { get; set; }
    public bool[] _enum { get; set; }
    public string[] enumNames { get; set; }
  }

  public class Smallbusinessnswstampdutycovertext
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Nswstampdutygroup
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Gpicovertext
  {
    public string title { get; set; }
    public string description { get; set; }
    public string type { get; set; }
  }

  public class Purchaseextraquestions
  {
    public string type { get; set; }
    public string title { get; set; }
    public Properties2 properties { get; set; }
    public Dependencies dependencies { get; set; }
  }

  public class Properties2
  {
    public Answeredyes answeredYes { get; set; }
    public Waslast5years wasLast5Years { get; set; }
    public Amountexceed2500 amountExceed2500 { get; set; }
  }

  public class Answeredyes
  {
    public string title { get; set; }
    public string description { get; set; }
    public string type { get; set; }
  }

  public class Waslast5years
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof[] oneOf { get; set; }
  }

  public class Oneof
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Amountexceed2500
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof1[] oneOf { get; set; }
  }

  public class Oneof1
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Dependencies
  {
    public Waslast5years1 wasLast5Years { get; set; }
    public Amountexceed25001 amountExceed2500 { get; set; }
  }

  public class Waslast5years1
  {
    public Oneof2[] oneOf { get; set; }
  }

  public class Oneof2
  {
    public Properties3 properties { get; set; }
  }

  public class Properties3
  {
    public Waslast5years2 wasLast5Years { get; set; }
    public Weneedmoreinfo weNeedMoreInfo { get; set; }
  }

  public class Waslast5years2
  {
    public bool[] _enum { get; set; }
  }

  public class Weneedmoreinfo
  {
    public string title { get; set; }
    public string description { get; set; }
    public string type { get; set; }
  }

  public class Amountexceed25001
  {
    public Oneof3[] oneOf { get; set; }
  }

  public class Oneof3
  {
    public Properties4 properties { get; set; }
  }

  public class Properties4
  {
    public Amountexceed25002 amountExceed2500 { get; set; }
    public Weneedmoreinfo1 weNeedMoreInfo { get; set; }
  }

  public class Amountexceed25002
  {
    public bool[] _enum { get; set; }
  }

  public class Weneedmoreinfo1
  {
    public string title { get; set; }
    public string description { get; set; }
    public string type { get; set; }
  }

  public class Email
  {
    public string type { get; set; }
    public string pattern { get; set; }
  }

  public class Billingaddress
  {
    public string type { get; set; }
    public string title { get; set; }
    public string columnTitle { get; set; }
    public Properties5 properties { get; set; }
  }

  public class Properties5
  {
    public Addressline1 addressLine { get; set; }
    public Addressline21 addressLine2 { get; set; }
    public Addressstate1 addressState { get; set; }
    public Addresspostcode1 addressPostcode { get; set; }
    public Addresscountry1 addressCountry { get; set; }
    public Fulladdress1 fullAddress { get; set; }
  }

  public class Addressline1
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addressline21
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addressstate1
  {
    public string _ref { get; set; }
  }

  public class Addresspostcode1
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Addresscountry1
  {
    public string _ref { get; set; }
  }

  public class Fulladdress1
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Properties6
  {
    public Mypracticeheader MyPracticeHeader { get; set; }
    public Membershipheader membershipHeader { get; set; }
    public Membernumber memberNumber { get; set; }
    public Confirmmembernumber confirmMemberNumber { get; set; }
    public Practiceheader practiceHeader { get; set; }
    public Modalitiespractice modalitiesPractice { get; set; }
    public Modalitiesperform modalitiesPerform { get; set; }
    public Statepractice statePractice { get; set; }
    public Registeredaddress1 registeredAddress { get; set; }
    public Declareemploylessthan25 declareEmployLessThan25 { get; set; }
    public Contactdetailsheader contactDetailsHeader { get; set; }
    public Mobilenumber mobileNumber { get; set; }
    public Worknumber workNumber { get; set; }
    public Homenumber homeNumber { get; set; }
    public Email1 email { get; set; }
    public Premiumbreakdowntablesection premiumBreakdownTableSection { get; set; }
    public Coverageheader CoverageHeader { get; set; }
    public Policyheader policyHeader { get; set; }
    public Policystartdate policyStartDate { get; set; }
    public Coveragedetailsheader coverageDetailsHeader { get; set; }
    public Pil pil { get; set; }
    public Pll pll { get; set; }
    public Gpi gpi { get; set; }
    public Policyholderdetailsheader policyholderDetailsHeader { get; set; }
    public Insuredname insuredName { get; set; }
    public Firstname firstName { get; set; }
    public Middlename middleName { get; set; }
    public Surname surname { get; set; }
    public Reviewheader ReviewHeader { get; set; }
    public Mypracticeheader1 myPracticeHeader { get; set; }
    public Declarationtopheader declarationTopHeader { get; set; }
    public Claimshistoryheader claimsHistoryHeader { get; set; }
    public Claimsorcomplaints claimsOrComplaints { get; set; }
    public Awareofcircumstances awareOfCircumstances { get; set; }
    public Insurerdeclineorcancelled insurerDeclineOrCancelled { get; set; }
    public Engagedincivilproceeding engagedInCivilProceeding { get; set; }
    public Purchasetopheader purchaseTopHeader { get; set; }
    public Yourquotenoheader yourQuoteNoHeader { get; set; }
    public Billingdetailsheader billingDetailsHeader { get; set; }
    public Confirmemail confirmEmail { get; set; }
    public Usepracticeaddress usePracticeAddress { get; set; }
    public Paymentsection paymentSection { get; set; }
    public Paymentdetails paymentDetails { get; set; }
    public Purchasecompletiontopheader purchaseCompletionTopHeader { get; set; }
    public Purchasecompletionheader purchaseCompletionHeader { get; set; }
    public Quotenumber quoteNumber { get; set; }
    public Contactdetails contactDetails { get; set; }
    public Paymentmethods paymentMethods { get; set; }
    public Makepaymentsection makePaymentSection { get; set; }
  }

  public class Mypracticeheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Membershipheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Membernumber
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Confirmmembernumber
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Practiceheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Modalitiespractice
  {
    public string type { get; set; }
    public string title { get; set; }
    public bool[] _enum { get; set; }
    public string[] enumNames { get; set; }
  }

  public class Modalitiesperform
  {
    public string type { get; set; }
    public string title { get; set; }
    public bool uniqueItems { get; set; }
    public Items items { get; set; }
  }

  public class Items
  {
    public string _ref { get; set; }
  }

  public class Statepractice
  {
    public string type { get; set; }
    public string title { get; set; }
    public string _ref { get; set; }
  }

  public class Registeredaddress1
  {
    public string _ref { get; set; }
    public string[] required { get; set; }
  }

  public class Declareemploylessthan25
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof4[] oneOf { get; set; }
  }

  public class Oneof4
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Contactdetailsheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Mobilenumber
  {
    public string type { get; set; }
    public string title { get; set; }
    public int minLength { get; set; }
    public int maxLength { get; set; }
    public string pattern { get; set; }
  }

  public class Worknumber
  {
    public string type { get; set; }
    public string title { get; set; }
    public int minLength { get; set; }
    public int maxLength { get; set; }
    public string pattern { get; set; }
  }

  public class Homenumber
  {
    public string type { get; set; }
    public string title { get; set; }
    public int minLength { get; set; }
    public int maxLength { get; set; }
    public string pattern { get; set; }
  }

  public class Email1
  {
    public string type { get; set; }
    public string title { get; set; }
    public string pattern { get; set; }
  }

  public class Premiumbreakdowntablesection
  {
    public string type { get; set; }
  }

  public class Coverageheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Policyheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Policystartdate
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Coveragedetailsheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Pil
  {
    public string type { get; set; }
    public string title { get; set; }
    public string _ref { get; set; }
  }

  public class Pll
  {
    public string type { get; set; }
    public string title { get; set; }
    public string _ref { get; set; }
  }

  public class Gpi
  {
    public string type { get; set; }
    public string title { get; set; }
    public bool[] _enum { get; set; }
    public string[] enumNames { get; set; }
    public Oneof5[] oneOf { get; set; }
  }

  public class Oneof5
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Policyholderdetailsheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Insuredname
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Firstname
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Middlename
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Surname
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Reviewheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Mypracticeheader1
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Declarationtopheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Claimshistoryheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Claimsorcomplaints
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof6[] oneOf { get; set; }
  }

  public class Oneof6
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Awareofcircumstances
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof7[] oneOf { get; set; }
  }

  public class Oneof7
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Insurerdeclineorcancelled
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof8[] oneOf { get; set; }
  }

  public class Oneof8
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Engagedincivilproceeding
  {
    public string type { get; set; }
    public string title { get; set; }
    public Oneof9[] oneOf { get; set; }
  }

  public class Oneof9
  {
    public bool _const { get; set; }
    public string title { get; set; }
  }

  public class Purchasetopheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Yourquotenoheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Billingdetailsheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Confirmemail
  {
    public string type { get; set; }
    public string title { get; set; }
    public string pattern { get; set; }
  }

  public class Usepracticeaddress
  {
    public string type { get; set; }
    public string title { get; set; }
    public bool _default { get; set; }
  }

  public class Paymentsection
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Paymentdetails
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Purchasecompletiontopheader
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Purchasecompletionheader
  {
    public string type { get; set; }
    public string title { get; set; }
    public string description { get; set; }
  }

  public class Quotenumber
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Contactdetails
  {
    public string title { get; set; }
    public string _ref { get; set; }
  }

  public class Paymentmethods
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Makepaymentsection
  {
    public string type { get; set; }
    public string title { get; set; }
  }

  public class Dependencies1
  {
    public Statepractice1 statePractice { get; set; }
    public Gpi1 gpi { get; set; }
    public Claimsorcomplaints1 claimsOrComplaints { get; set; }
    public Awareofcircumstances1 awareOfCircumstances { get; set; }
    public Insurerdeclineorcancelled1 insurerDeclineOrCancelled { get; set; }
    public Engagedincivilproceeding1 engagedInCivilProceeding { get; set; }
    public Usepracticeaddress1 usePracticeAddress { get; set; }
  }

  public class Statepractice1
  {
    public Oneof10[] oneOf { get; set; }
  }

  public class Oneof10
  {
    public Properties7 properties { get; set; }
  }

  public class Properties7
  {
    public Statepractice2 statePractice { get; set; }
    public Nswstampdutygroup1 nswStampDutyGroup { get; set; }
  }

  public class Statepractice2
  {
    public string[] _enum { get; set; }
  }

  public class Nswstampdutygroup1
  {
    public string _ref { get; set; }
    public Properties8 properties { get; set; }
    public string[] required { get; set; }
    public Dependencies2 dependencies { get; set; }
  }

  public class Properties8
  {
    public Smallbusinessnswstampduty1 smallBusinessNSWStampDuty { get; set; }
  }

  public class Smallbusinessnswstampduty1
  {
    public string _ref { get; set; }
    public bool hideReset { get; set; }
    public string title { get; set; }
  }

  public class Dependencies2
  {
    public Smallbusinessnswstampduty2 smallBusinessNSWStampDuty { get; set; }
  }

  public class Smallbusinessnswstampduty2
  {
    public Oneof11[] oneOf { get; set; }
  }

  public class Oneof11
  {
    public Properties9 properties { get; set; }
  }

  public class Properties9
  {
    public Smallbusinessnswstampduty3 smallBusinessNSWStampDuty { get; set; }
    public Smallbusinessnswstampdutycovertext1 smallBusinessNSWStampDutyCoverText { get; set; }
  }

  public class Smallbusinessnswstampduty3
  {
    public bool?[] _enum { get; set; }
  }

  public class Smallbusinessnswstampdutycovertext1
  {
    public string _ref { get; set; }
    public string description { get; set; }
  }

  public class Gpi1
  {
    public Oneof12[] oneOf { get; set; }
  }

  public class Oneof12
  {
    public Properties10 properties { get; set; }
  }

  public class Properties10
  {
    public Gpi2 gpi { get; set; }
    public Gpicovertext1 gpiCoverText { get; set; }
  }

  public class Gpi2
  {
    public bool?[] _enum { get; set; }
  }

  public class Gpicovertext1
  {
    public string _ref { get; set; }
  }

  public class Claimsorcomplaints1
  {
    public Oneof13[] oneOf { get; set; }
  }

  public class Oneof13
  {
    public Properties11 properties { get; set; }
  }

  public class Properties11
  {
    public Claimsorcomplaints2 claimsOrComplaints { get; set; }
    public Purchaseextraquestions1 purchaseExtraQuestions { get; set; }
  }

  public class Claimsorcomplaints2
  {
    public bool[] _enum { get; set; }
  }

  public class Purchaseextraquestions1
  {
    public string _ref { get; set; }
  }

  public class Awareofcircumstances1
  {
    public Oneof14[] oneOf { get; set; }
  }

  public class Oneof14
  {
    public Properties12 properties { get; set; }
  }

  public class Properties12
  {
    public Awareofcircumstances2 awareOfCircumstances { get; set; }
    public Purchaseextraquestions2 purchaseExtraQuestions { get; set; }
  }

  public class Awareofcircumstances2
  {
    public bool[] _enum { get; set; }
  }

  public class Purchaseextraquestions2
  {
    public string _ref { get; set; }
  }

  public class Insurerdeclineorcancelled1
  {
    public Oneof15[] oneOf { get; set; }
  }

  public class Oneof15
  {
    public Properties13 properties { get; set; }
  }

  public class Properties13
  {
    public Insurerdeclineorcancelled2 insurerDeclineOrCancelled { get; set; }
    public Purchaseextraquestions3 purchaseExtraQuestions { get; set; }
  }

  public class Insurerdeclineorcancelled2
  {
    public bool[] _enum { get; set; }
  }

  public class Purchaseextraquestions3
  {
    public string _ref { get; set; }
  }

  public class Engagedincivilproceeding1
  {
    public Oneof16[] oneOf { get; set; }
  }

  public class Oneof16
  {
    public Properties14 properties { get; set; }
  }

  public class Properties14
  {
    public Engagedincivilproceeding2 engagedInCivilProceeding { get; set; }
    public Purchaseextraquestions4 purchaseExtraQuestions { get; set; }
  }

  public class Engagedincivilproceeding2
  {
    public bool[] _enum { get; set; }
  }

  public class Purchaseextraquestions4
  {
    public string _ref { get; set; }
  }

  public class Usepracticeaddress1
  {
    public Oneof17[] oneOf { get; set; }
  }

  public class Oneof17
  {
    public Properties15 properties { get; set; }
  }

  public class Properties15
  {
    public Usepracticeaddress2 usePracticeAddress { get; set; }
    public Billingaddress1 billingAddress { get; set; }
  }

  public class Usepracticeaddress2
  {
    public string type { get; set; }
    public bool[] _enum { get; set; }
  }

  public class Billingaddress1
  {
    public string _ref { get; set; }
    public bool readOnly { get; set; }
  }

  public class Formuischema1
  {
    public Membernumber1 memberNumber { get; set; }
    public Confirmmembernumber1 confirmMemberNumber { get; set; }
    public Modalitiespractice1 modalitiesPractice { get; set; }
    public Modalitiesperform1 modalitiesPerform { get; set; }
    public Declareemploylessthan251 declareEmployLessThan25 { get; set; }
    public Statepractice3 statePractice { get; set; }
    public Registeredaddress2 registeredAddress { get; set; }
    public Nswstampdutygroup2 nswStampDutyGroup { get; set; }
    public Mobilenumber1 mobileNumber { get; set; }
    public Worknumber1 workNumber { get; set; }
    public Homenumber1 homeNumber { get; set; }
    public Email2 email { get; set; }
    public Premiumbreakdowntablesection1 premiumBreakdownTableSection { get; set; }
    public Policystartdate1 policyStartDate { get; set; }
    public Pil1 pil { get; set; }
    public Pll1 pll { get; set; }
    public Gpi3 gpi { get; set; }
    public Middlename1 middleName { get; set; }
    public Mypracticeheader2 myPracticeHeader { get; set; }
    public Contactdetailsheader1 contactDetailsHeader { get; set; }
    public Policyholderdetailsheader1 policyholderDetailsHeader { get; set; }
    public Claimsorcomplaints3 claimsOrComplaints { get; set; }
    public Awareofcircumstances3 awareOfCircumstances { get; set; }
    public Insurerdeclineorcancelled3 insurerDeclineOrCancelled { get; set; }
    public Engagedincivilproceeding3 engagedInCivilProceeding { get; set; }
    public Purchaseextraquestions5 purchaseExtraQuestions { get; set; }
    public Yourquotenoheader1 yourQuoteNoHeader { get; set; }
    public Paymentdetails1 paymentDetails { get; set; }
    public Makepaymentsection1 makePaymentSection { get; set; }
    public Usepracticeaddress3 usePracticeAddress { get; set; }
    public Billingaddress2 billingAddress { get; set; }
  }

  public class Membernumber1
  {
    public string uiwidget { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class Confirmmembernumber1
  {
    public string uiwidget { get; set; }
    public string uiplaceholder { get; set; }
    public string uihelp { get; set; }
  }

  public class Modalitiespractice1
  {
    public string uiwidget { get; set; }
    public UiOptions2 uioptions { get; set; }
  }

  public class UiOptions2
  {
    public Condition condition { get; set; }
  }

  public class Condition
  {
    public string value { get; set; }
    public string errorMessage { get; set; }
  }

  public class Modalitiesperform1
  {
    public string uiwidget { get; set; }
    public string uiplaceholder { get; set; }
    public string uihelp { get; set; }
  }

  public class Declareemploylessthan251
  {
    public string uiwidget { get; set; }
  }

  public class Statepractice3
  {
    public string uiplaceholder { get; set; }
  }

  public class Registeredaddress2
  {
    public Addressline3 addressLine { get; set; }
    public Addressline22 addressLine2 { get; set; }
    public Addressstate2 addressState { get; set; }
    public Addresspostcode2 addressPostcode { get; set; }
    public Addresscountry2 addressCountry { get; set; }
    public Fulladdress2 fullAddress { get; set; }
    public UiOptions9 uioptions { get; set; }
  }

  public class Addressline3
  {
    public string uiplaceholder { get; set; }
    public UiOptions3 uioptions { get; set; }
  }

  public class UiOptions3
  {
    public bool label { get; set; }
    public bool required { get; set; }
  }

  public class Addressline22
  {
    public UiOptions4 uioptions { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class UiOptions4
  {
    public bool label { get; set; }
  }

  public class Addressstate2
  {
    public string uiplaceholder { get; set; }
    public UiOptions5 uioptions { get; set; }
  }

  public class UiOptions5
  {
    public bool label { get; set; }
    public bool required { get; set; }
  }

  public class Addresspostcode2
  {
    public string uiplaceholder { get; set; }
    public UiOptions6 uioptions { get; set; }
  }

  public class UiOptions6
  {
    public bool label { get; set; }
    public bool required { get; set; }
  }

  public class Addresscountry2
  {
    public UiOptions7 uioptions { get; set; }
  }

  public class UiOptions7
  {
    public bool label { get; set; }
  }

  public class Fulladdress2
  {
    public string uiwidget { get; set; }
    public UiOptions8 uioptions { get; set; }
  }

  public class UiOptions8
  {
    public bool label { get; set; }
  }

  public class UiOptions9
  {
    public bool label { get; set; }
  }

  public class Nswstampdutygroup2
  {
    public Smallbusinessnswstampduty4 smallBusinessNSWStampDuty { get; set; }
  }

  public class Smallbusinessnswstampduty4
  {
    public string uiwidget { get; set; }
    public UiOptions10 uioptions { get; set; }
  }

  public class UiOptions10
  {
    public bool affectPremium { get; set; }
  }

  public class Mobilenumber1
  {
    public string uiwidget { get; set; }
    public UiOptions11 uioptions { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class UiOptions11
  {
    public string classNames { get; set; }
  }

  public class Worknumber1
  {
    public string uiwidget { get; set; }
    public UiOptions12 uioptions { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class UiOptions12
  {
    public string classNames { get; set; }
  }

  public class Homenumber1
  {
    public string uiwidget { get; set; }
    public UiOptions13 uioptions { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class UiOptions13
  {
    public string classNames { get; set; }
  }

  public class Email2
  {
  }

  public class Premiumbreakdowntablesection1
  {
    public string uiwidget { get; set; }
    public UiOptions14 uioptions { get; set; }
  }

  public class UiOptions14
  {
    public bool label { get; set; }
  }

  public class Policystartdate1
  {
    public string uiwidget { get; set; }
    public string uihelp { get; set; }
    public string uiplaceholder { get; set; }
    public UiOptions15 uioptions { get; set; }
  }

  public class UiOptions15
  {
    public string format { get; set; }
    public string startDate { get; set; }
    public string endDate { get; set; }
    public bool defaultToToday { get; set; }
  }

  public class Pil1
  {
    public string uihelp { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class Pll1
  {
    public string uiplaceholder { get; set; }
  }

  public class Gpi3
  {
    public string uiwidget { get; set; }
    public UiOptions16 uioptions { get; set; }
  }

  public class UiOptions16
  {
    public bool affectPremium { get; set; }
  }

  public class Middlename1
  {
    public string uiplaceholder { get; set; }
  }

  public class Mypracticeheader2
  {
    public Editableview editableView { get; set; }
  }

  public class Editableview
  {
    public string location { get; set; }
    public string sectionId { get; set; }
  }

  public class Contactdetailsheader1
  {
    public Editableview1 editableView { get; set; }
  }

  public class Editableview1
  {
    public string location { get; set; }
    public string sectionId { get; set; }
  }

  public class Policyholderdetailsheader1
  {
    public Editableview2 editableView { get; set; }
  }

  public class Editableview2
  {
    public string location { get; set; }
    public string sectionId { get; set; }
  }

  public class Claimsorcomplaints3
  {
    public string uiwidget { get; set; }
  }

  public class Awareofcircumstances3
  {
    public string uiwidget { get; set; }
  }

  public class Insurerdeclineorcancelled3
  {
    public string uiwidget { get; set; }
  }

  public class Engagedincivilproceeding3
  {
    public string uiwidget { get; set; }
  }

  public class Purchaseextraquestions5
  {
    public Waslast5years3 wasLast5Years { get; set; }
    public Amountexceed25003 amountExceed2500 { get; set; }
  }

  public class Waslast5years3
  {
    public string uiwidget { get; set; }
  }

  public class Amountexceed25003
  {
    public string uiwidget { get; set; }
  }

  public class Yourquotenoheader1
  {
    public Editableview3 editableView { get; set; }
  }

  public class Editableview3
  {
    public string location { get; set; }
    public string sectionId { get; set; }
    public string extCommitButtons { get; set; }
  }

  public class Paymentdetails1
  {
    public string uiwidget { get; set; }
    public UiOptions17 uioptions { get; set; }
  }

  public class UiOptions17
  {
    public bool showTable { get; set; }
    public string[] displayFields { get; set; }
  }

  public class Makepaymentsection1
  {
    public string uiwidget { get; set; }
    public UiOptions18 uioptions { get; set; }
  }

  public class UiOptions18
  {
    public string receiptEmailField { get; set; }
  }

  public class Usepracticeaddress3
  {
    public string uiwidget { get; set; }
    public UiOptions19 uioptions { get; set; }
  }

  public class UiOptions19
  {
    public string copyFrom { get; set; }
    public string copyTo { get; set; }
  }

  public class Billingaddress2
  {
    public Addressline4 addressLine { get; set; }
    public Addressline23 addressLine2 { get; set; }
    public Addressstate3 addressState { get; set; }
    public Addresspostcode3 addressPostcode { get; set; }
    public Addresscountry3 addressCountry { get; set; }
    public Fulladdress3 fullAddress { get; set; }
  }

  public class Addressline4
  {
    public string uiplaceholder { get; set; }
    public UiOptions20 uioptions { get; set; }
  }

  public class UiOptions20
  {
    public bool label { get; set; }
  }

  public class Addressline23
  {
    public UiOptions21 uioptions { get; set; }
    public string uiplaceholder { get; set; }
  }

  public class UiOptions21
  {
    public bool label { get; set; }
  }

  public class Addressstate3
  {
    public string uiplaceholder { get; set; }
    public UiOptions22 uioptions { get; set; }
  }

  public class UiOptions22
  {
    public bool label { get; set; }
  }

  public class Addresspostcode3
  {
    public string uiplaceholder { get; set; }
    public UiOptions23 uioptions { get; set; }
  }

  public class UiOptions23
  {
    public bool label { get; set; }
  }

  public class Addresscountry3
  {
    public UiOptions24 uioptions { get; set; }
  }

  public class UiOptions24
  {
    public bool label { get; set; }
  }

  public class Fulladdress3
  {
    public string uiwidget { get; set; }
    public UiOptions25 uioptions { get; set; }
  }

  public class UiOptions25
  {
    public bool label { get; set; }
  }

  public class Subformschemas1
  {
    public Premiumbreakdowntablesection2 premiumBreakdownTableSection { get; set; }
  }

  public class Premiumbreakdowntablesection2
  {
    public string logoUrl { get; set; }
    public string companyName { get; set; }
    public string header { get; set; }
    public string headerDescription { get; set; }
    public string headerDescriptionReady { get; set; }
  }

  public class Formuischemagroup1
  {
    public object[] titleStep01descriptionMypractice { get; set; }
    public object[] title02descriptionCoverage { get; set; }
    public object[] title03descriptionReview { get; set; }
    public object[] title04descriptionPurchase { get; set; }
    public string uitemplate { get; set; }
    public object[] title01descriptionMypractice { get; set; }
    public object[] titleStep02descriptionCoverage { get; set; }
    public object[] titleStep03descriptionReview { get; set; }
    public TitleStep04DescriptionPurchase[] titleStep04descriptionPurchase { get; set; }
  }

  public class TitleStep04DescriptionPurchase
  {
    public object[] page1 { get; set; }
    public object[] page2 { get; set; }
    public object[] page3 { get; set; }
    public object[] page4 { get; set; }
    public object[] page5 { get; set; }
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
