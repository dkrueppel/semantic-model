﻿using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiServices : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Packaging Options
        /// </summary>
        public EdiPackagingOptions PackagingOptions { get; set; }

        /// <summary>
        /// The transport is produced via special run (and with special fares)
        /// </summary>
        [DisplayName("Special Run")]
        [Description("The transport is produced via special run (and with special fares)")]
        public string SpecialRun { get; set; }

        /// <summary>
        /// Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications, ...
        /// </summary>
        public EdiNotifications Notifications { get; set; }

        /// <summary>
        /// Neutral addresses which are shown to the shipper or consignee in order to conceal the actual shipper or recipient of the goods
        /// </summary>
        public EdiAnonymity Anonymity { get; set; }

        /// <summary>
        /// Information about time slots which need to be booked or are already booked for the pickup or the following consignment
        /// </summary>
        public EdiTimeSlotBooking TimeSlotBooking { get; set; }

        /// <summary>
        /// Requirements for the delivery or pickup time
        /// </summary>
        public EdiTimeOptions TimeOptions { get; set; }

        /// <summary>
        /// Requirements for special services or equipment for the delivery
        /// </summary>
        public EdiDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// Information about the loading of the main haul
        /// </summary>
        public EdiLoadingOptions LoadingOptions { get; set; }

        public EdiUnloadingOptions UnloadingOptions { get; set; }

        public EdiGateway Gateway { get; set; }

        public EdiHandlingInstructions HandlingInstructions { get; set; }

        public EdiReturnOfGoods ReturnOfGoods { get; set; }

    }

    /// <summary>
    /// Special services which can be requested by the ordering party (or the shipping partner) for this pickup order
    /// </summary>
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner) for this pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupServices : EdiServices
    {
        /// <summary>
        /// Special options needed to process this pickup order
        /// </summary>
        public EdiPickupOptions PickupOptions { get; set; }

        /// <summary>
        /// Notifications which should be sent while processing the shipment, e.g. notifications about successful delivery, advance notifications for the pickup order
        /// </summary>
        public new EdiPickupNotifications Notifications { get; set; }

    }


    /// <summary>
    /// Special options needed to process this pickup order
    /// </summary>
    [JsonObject("pickupOptions")]
    [DisplayName("Pickup Options")]
    [Description("Special options needed to process this pickup order")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupOptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The pickup order can only be picked up with a vehicle equipped with a lifting platform
        /// </summary>
        [DisplayName("Lifting Platform")]
        [Description("The pickup order can only be picked up with a vehicle equipped with a lifting platform")]
        public bool LiftingPlatform { get; set; }

        /// <summary>
        /// Delivery Note is following later by post or driver post
        /// </summary>
        [DisplayName("Delivery Note following by post")]
        [Description("Delivery Note is follwing later by post or driver post")]
        public bool DeliveryNoteFollowingByPost { get; set; }

        /// <summary>
        /// Driver has to bring empty pallets for exchange
        /// </summary>
        [DisplayName("Empty pallets for exchange")]
        [Description("Driver has to bring empty pallets for exchange")]
        public bool EmptyPallets { get; set; }

        /// <summary>
        /// The pickup contains unknown dangerous goods
        /// </summary>
        [DisplayName("Unknown dangerous goods")]
        [Description("The pickup contains unknown dangerous goods")]
        public bool UnknownDangerousGoods { get; set; }

        /// <summary>
        /// The goods must be picked up from the point of use with one man handling. Usually in case of returning old goods
        /// </summary>
        [DisplayName("Point of use pickup - 1 man handling")]
        [Description("The goods must be picked up from the point of use with one man handling. Usually in case of returning old goods")]
        public bool PointOfUsePickup1Person { get; set; }

        /// <summary>
        /// The goods must be picked up from the point of use with two man handling. Usually in case of returning old goolds
        /// </summary>
        [DisplayName("Point of use pickup - 2 man handling")]
        [Description("The goods must be picked up from the point of use with two man handling. Usually in case of returning old goolds")]
        public bool PointOfUsePickup2Persons { get; set; }

        /// <summary>
        /// A given last mile provider must be used
        /// </summary>
        [DisplayName("Pickup by specific last mile provider")]
        [Description("A given last mile provider must be used")]
        public bool UseSpecificLastMileProvider { get; set; }

        /// <summary>
        /// The pickup is for attention of the given company
        /// </summary>
        [DisplayName("For attention")]
        [Description("The pickup is for attention of the given company")]
        public bool ForAttentionOf { get; set; }

    }


    [JsonObject("gateway")]
    [DisplayName("Gateway-Options")]
    [Description("Special requirements for the handling of the goods at intermediate hubs / gateways")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGateway : EdiPatternPropertiesBase
    {
        [DisplayName("Priority")]
        [Description("The consignment must be processed with priority")]
        public bool Priority { get; set; }
    }

    [JsonObject("handlingInstructions")]
    [DisplayName("Handling instructions")]
    [Description("Handling instructions for the goods, e.g. to prevent damage")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiHandlingInstructions : EdiPatternPropertiesBase
    {
        [DisplayName("Customs Goods")]
        [Description("The goods are subject to customs processing and must be processed according the rules of the local authorities")]
        public bool CustomsGoods { get; set; }

        [DisplayName("Customs Goods resubmission date")]
        [Description("The resubmission date for the customs goods")]
        [ConiziDateOnly]
        public DateTime CustomsGoodsResubmissionDate { get; set; }

        [DisplayName("Handle with care")]
        [Description("The goods must be handeled with care to prevent damage")]
        public bool HandleWithCare { get; set; }

        [DisplayName("Empties exchange required")]
        [Description("Specifies whether empties should be exchanged with the consignee")]
        public bool EmptiesExchange { get; set; }

        public EdiOrientation Orientation { get; set; }

        public EdiStacking Stacking { get; set; }

        public EdiFood Food { get; set; }
        public EdiTemperatureRestrictions TemperatureRestrictions { get; set; }
    }
    
    [JsonObject("orientation")]
    [DisplayName("Orientation")]
    [Description("The goods must be transported in a given orientatien and may not be flipped over")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiOrientation : EdiPatternPropertiesBase
    {
        [DisplayName("Upright")]
        [Description("The goods must be transported upright")]
        public bool Vertical { get; set; }

        [DisplayName("Horizontal")]
        [Description("The goods must be transported flat down")]
        public bool Horizontal { get; set; }
    }

    [JsonObject("returnOfGoods")]
    [DisplayName("Return of goods")]
    [Description("Services for the return of goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReturnOfGoods : EdiPatternPropertiesBase
    {
        [DisplayName("Packaging disposal")]
        [Description("The packaging of the goods is taken back and dispose")]
        public bool EmptyPackaging { get; set; }
    }

    [JsonObject("stacking")]
    [DisplayName("Stacking")]
    [Description("Indicated wheter the goods may or may not be stacked")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiStacking : EdiPatternPropertiesBase
    {
        [DisplayName("Stacking forbidden")]
        [Description("The goods must not be stacked")]
        public bool Forbidden { get; set; }

        [DisplayName("Stacking possible")]
        [Description("Stacking of the goods is safely possible")]
        public bool Allowed { get; set; }
    }

    [JsonObject("food")]
    [DisplayName("Food related regulatory restrictions")]
    [Description("Special requirements for transporting food")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFood : EdiPatternPropertiesBase
    {
        [DisplayName("Stacking forbidden")]
        [Description("The HACCP regulations apply")]
        public bool Haccp { get; set; }

    }

    [JsonObject("temperatureRestrictions")]
    [DisplayName("Temperature restrictions")]
    [Description("Restrictions about the minimum and maximum temperature during the transport and special equipment to be used")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTemperatureRestrictions : EdiPatternPropertiesBase
    {
        [DisplayName("Minimum temperature (°C)")]
        [Description("The temperature must not drop below the given value during the transport")]
        public decimal TemperatureMinCelsius { get; set; }

        [DisplayName("Maximum temperature (°C)")]
        [Description("The temperature must not get greater than the given value")]
        public decimal TemperatureMaxCelsius { get; set; }
    }
}