﻿using System.ComponentModel;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;

namespace Conizi.Model.Shared.Definitions
{
    /// <summary>
    /// Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...
    /// </summary>
    [Description(
        "Determines how the current message should be handled, e.g. whether the stops / consignments should be added removed, ...")]
    [ConiziAdditionalProperties(false)]
    public enum EdiMessageFunctionCode
    {
        /// <summary>
        /// Add a new tour
        /// </summary>
        [EnumMember(Value = "add")] Add = 1,

        /// <summary>
        /// Update a tour
        /// </summary>
        [EnumMember(Value = "update")] Update = 2,

        /// <summary>
        /// Remove a tour
        /// </summary>
        [EnumMember(Value = "remove")] Remove = 3,

        /// <summary>
        /// Add a part of a tour
        /// </summary>
        [EnumMember(Value = "add_partial")] AddPartial = 11,

        /// <summary>
        /// Update a part of a tour
        /// </summary>
        [EnumMember(Value = "update_partial")] UpdatePartial = 12,

        /// <summary>
        /// Remove a part of a tour
        /// </summary>
        [EnumMember(Value = "remove_partial")] RemovePartial = 13
    }

    /// <summary>
    /// Determines the unit in which a given property is measured
    /// Default kilometers per hour
    /// </summary>
    [Description("Determines the unit of a given property. Default kilometers per hour")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public enum MeasurementUnitCode
    {
        /// <summary>
        /// Values are measured in kilometers
        /// </summary>
        [Description("Distance Values are measured in kilometers")]
        [EnumMember(Value = "KMT")]
        Kilometer,

        /// <summary>
        /// Values are measured in nautical miles
        /// </summary>
        [Description("Distance Values are measured in nautical miles")]
        [EnumMember(Value = "NMI")]
        NauticalMile,

        /// <summary>
        /// Values are measured in miles
        /// </summary>
        [Description("Distance Values are measured in (Statute/English) miles")]
        [EnumMember(Value = "SMI")]
        StatuteMile
    }

    /// <summary>
    /// Determines a priority of a given message
    /// </summary>
    [Description("Determines a priority of a given message")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public enum UrgencyCode
    {
        /// <summary>
        /// Describes a normal priority
        /// </summary>
        [Description("Message has a normal priority")]
        [EnumMember(Value = "normal")]
        Normal,

        /// <summary>
        /// Describes a high priority
        /// </summary>
        [Description("Message has a high priority")]
        [EnumMember(Value = "high")]
        High,

        /// <summary>
        /// Describes a low priority
        /// </summary>
        [Description("Message has a low priority")]
        [EnumMember(Value = "low")]
        Low,
    }

    /// <summary>
    /// Types of loading equipment
    /// </summary>
    [Description("Types of loading equipment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public enum LoadingEquipmentType
    {
        /// <summary>
        /// EUR Pallets as defined by European Pallet Association (EPAL)
        /// </summary>
        [Description("EUR Pallets as defined by European Pallet Association (EPAL)")]
        [EnumMember(Value = "eurPallets")]
        EurPallets,

        /// <summary>
        /// EUR Boxes as defined by European Pallet Association (EPAL)
        /// </summary>
        [Description("EUR Boxes as defined by European Pallet Association (EPAL)")]
        [EnumMember(Value = "eurBoxes")]
        EurBoxes,

        /// <summary>
        /// H1 Pallets
        /// </summary>
        [Description("H1 Pallets")]
        [EnumMember(Value = "h1Pallets")]
        H1Pallets,

        /// <summary>
        /// E2 Pallets
        /// </summary>
        [Description("E2 Pallets")]
        [EnumMember(Value = "e2Pallets")]
        E2Pallets,

        /// <summary>
        /// OneWayPallets like Chep pallets
        /// </summary>
        [Description("OneWayPallets like Chep pallets")]
        [EnumMember(Value = "oneWayPallets")]
        OneWayPallets,

        /// <summary>
        /// Knauf Pallets
        /// </summary>
        [Description("Knauf Pallets")]
        [EnumMember(Value = "knaufPallets")]
        KnaufPallets,

        /// <summary>
        /// Düsseldorfer Pallets
        /// </summary>
        [Description("Düsseldorfer Pallets")]
        [EnumMember(Value = "DuesseldorferPallets")]
        DuesseldorferPallets,
    }
}