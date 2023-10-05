using System;

namespace DocumentGenerator.API.Core.Models.Test
{
    public class Policy
    {
        public int QuoteID { get; set; }
        public string QuoteNumber { get; set; }
        public object PolicyID { get; set; }
        public string PolicyLifecycleState { get; set; }
        public string PolicyTransactionState { get; set; }
        public Periodofinsurance PeriodOfInsurance { get; set; }
        public Broker Broker { get; set; }
        public Client Client { get; set; }
        public Insured Insured { get; set; }
        public Premiumoption[] PremiumOptions { get; set; }
        public Driver[] Drivers { get; set; }
        public string IsStampDutyExempt { get; set; }
        public Underwritingacceptancecriteria UnderwritingAcceptanceCriteria { get; set; }
        public Vehicle[] Vehicles { get; set; }
    }

    public class Periodofinsurance
    {
        public DateTime InceptionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime EffectiveDate { get; set; }
    }

    public class Broker
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public object TradingName { get; set; }
    }

    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public object TradingName { get; set; }
    }

    public class Insured
    {
        public string Name { get; set; }
    }

    public class Underwritingacceptancecriteria
    {
        public string HasBeenDeclined { get; set; }
        public string HasUnacceptableVehicleUse { get; set; }
    }

    public class Premiumoption
    {
        public float BasePremium { get; set; }
        public float BasicExcess { get; set; }
        public float Commission { get; set; }
        public float CommissionGST { get; set; }
        public float FSL { get; set; }
        public float GST { get; set; }
        public string OptionName { get; set; }
        public float StampDuty { get; set; }
        public float TotalPayable { get; set; }
        public float UWFee { get; set; }
        public float UWFeeGST { get; set; }
    }

    public class Driver
    {
        public Vehiclesdriven[] VehiclesDriven { get; set; }
    }

    public class Vehiclesdriven
    {
        public string VehicleDriven { get; set; }
    }

    public class Vehicle
    {
        public float AgreedValue { get; set; }
        public string CoverType { get; set; }
        public string HasHailDamage { get; set; }
        public string HireCarOption { get; set; }
        public string IsFinanced { get; set; }
        public string Make { get; set; }
        public float MarketValue { get; set; }
        public string Model { get; set; }
        public string OvernightAddress { get; set; }
        public string Registration { get; set; }
        public string Usage { get; set; }
        public string WindscreenOption { get; set; }
        public float Year { get; set; }
        public string Image { get; set; }
        public byte[] Photo
        {
            get
            {
                if (String.IsNullOrEmpty(Image))
                {
                    return null;
                }

                return System.IO.File.ReadAllBytes(Image);
            }
        }
    }
}

