﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
  /// <summary>
  /// Describes the scan of a masterbarcode
  /// </summary>
  [DisplayName("Masterbarcodescan")]
  [Description("Describes the scan of a masterbarcode")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties]
  public class EdiMasterBarcodeScan : EdiPatternPropertiesBase
  {
    /// <summary>
    /// Contains the singlebarcodes that are associated to the masterbarcode
    /// </summary>
    [DisplayName("Singlescans")]
    [Description("Contains the singlebarcodes that are associated to the masterbarcode")]
    [JsonProperty("singleScans")]
    public List<EdiMasterBarcodeSingleScan> SingleScans { get; set; }

    /// <summary>
    /// Describes stacking of the masterbarcodes
    /// </summary>
    [DisplayName("MasterBarcodeStacking")]
    [Description("Describes stacking of the masterbarcodes")]
    [JsonProperty("masterBarcodeStacking")]
    public List<string> MasterBarcodeStacking { get; set; }
  }

  /// <summary>
  /// Describes the scan of a masterbarcode
  /// </summary>
  [DisplayName("Masterbarcodescan")]
  [Description("Describes the scan of a masterbarcode")]
  [ConiziAdditionalProperties(false)]
  [ConiziAllowXProperties]
  public class EdiMasterBarcodeSingleScan : EdiPatternPropertiesBase
  {
    /// <summary>
    /// Describes how he Barcode/Package was scanned
    /// </summary>
    [JsonProperty("scanType")]
    [JsonConverter(typeof(StringEnumConverter))]
    public BarcodeScanType? ScanType { get; set; }

    /// <summary>
    /// SingleBarcode that is associated with the masterbarcode
    /// </summary>
    [JsonProperty("singleBarcode", Required = Required.Always)]
    [DisplayName("Single Barcode")]
    [Description("SingleBarcode that is associated with the masterbarcode")]
    public string SingleBarcode { get; set; }

    /// <summary>
    /// Describes if a barcode is scanned or "un"-scanned
    /// </summary>
    [JsonProperty("scanned", Required = Required.Always)]
    [DisplayName("Scanned")]
    [Description("Describes if a barcode is scanned or \"un\"-scanned")]
    public bool Scanned { get; set; }

    /// <summary>
    /// Events occurred while pickup the package
    /// </summary>
    //[DisplayName("Pickup by the sender")]
    //[Description("Events occurred while pickup the package")]
    public EdiPackageEvent PickupSender { get; set; }

    /// <summary>
    /// Events occurred while unloading the package by the shipping partner
    /// </summary>
    //[DisplayName("Unloading by the shipping partner")]
    //[Description("Events occurred while unloading the package by the shipping partner")]
    public EdiPackageEvent UnloadingShippingPartner { get; set; }

    /// <summary>
    /// Events occurred while loading the package by the shipping partner
    /// </summary>
    //[DisplayName("Loading by the shipping partner")]
    //[Description("Events occurred while loading the package by the shipping partner")]
    public EdiPackageEvent LoadingShippingPartner { get; set; }

    /// <summary>
    /// Events occurred while unloading the package by the receiving partner
    /// </summary>
    //[DisplayName("Unloading by the receiving partner")]
    //[Description("Events occurred while unloading the package by the receiving partner")]
    public EdiPackageEvent UnloadingReceivingPartner { get; set; }

    /// <summary>
    /// Events occured while loading the package by the receiving partner
    /// </summary>
    //[DisplayName("Loading by the receiving partner")]
    //[Description("Events occured while loading the package by the receiving partner")]
    public EdiPackageEvent LoadingReceivingPartner { get; set; }

    /// <summary>
    /// Events occurred while delivery the package
    /// </summary>
    //[DisplayName("Events occured while delivery the package")]
    //[Description("Events occurred while delivery the package")]
    public EdiPackageEvent DeliveryReceiver { get; set; }

    /// <summary>
    /// A list of document items
    /// </summary>
    public List<EdiDocumentItem> Documents { get; set; }

    /// <summary>
    /// A list of status images
    /// </summary>
    public List<EdiStatusImage> Images { get; set; }
  }
}
