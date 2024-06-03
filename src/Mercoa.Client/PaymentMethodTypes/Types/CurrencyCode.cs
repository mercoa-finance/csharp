using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

[JsonConverter(typeof(StringEnumSerializer<CurrencyCode>))]
public enum CurrencyCode
{
    [EnumMember(Value = "AED")]
    Aed,

    [EnumMember(Value = "AFN")]
    Afn,

    [EnumMember(Value = "ALL")]
    All,

    [EnumMember(Value = "AMD")]
    Amd,

    [EnumMember(Value = "ANG")]
    Ang,

    [EnumMember(Value = "AOA")]
    Aoa,

    [EnumMember(Value = "ARS")]
    Ars,

    [EnumMember(Value = "AUD")]
    Aud,

    [EnumMember(Value = "AWG")]
    Awg,

    [EnumMember(Value = "AZN")]
    Azn,

    [EnumMember(Value = "BAM")]
    Bam,

    [EnumMember(Value = "BBD")]
    Bbd,

    [EnumMember(Value = "BDT")]
    Bdt,

    [EnumMember(Value = "BGN")]
    Bgn,

    [EnumMember(Value = "BHD")]
    Bhd,

    [EnumMember(Value = "BIF")]
    Bif,

    [EnumMember(Value = "BMD")]
    Bmd,

    [EnumMember(Value = "BND")]
    Bnd,

    [EnumMember(Value = "BOB")]
    Bob,

    [EnumMember(Value = "BOV")]
    Bov,

    [EnumMember(Value = "BRL")]
    Brl,

    [EnumMember(Value = "BSD")]
    Bsd,

    [EnumMember(Value = "BTN")]
    Btn,

    [EnumMember(Value = "BWP")]
    Bwp,

    [EnumMember(Value = "BYN")]
    Byn,

    [EnumMember(Value = "BZD")]
    Bzd,

    [EnumMember(Value = "CAD")]
    Cad,

    [EnumMember(Value = "CDF")]
    Cdf,

    [EnumMember(Value = "CHE")]
    Che,

    [EnumMember(Value = "CHF")]
    Chf,

    [EnumMember(Value = "CHW")]
    Chw,

    [EnumMember(Value = "CLF")]
    Clf,

    [EnumMember(Value = "CLP")]
    Clp,

    [EnumMember(Value = "COP")]
    Cop,

    [EnumMember(Value = "COU")]
    Cou,

    [EnumMember(Value = "CRC")]
    Crc,

    [EnumMember(Value = "CUC")]
    Cuc,

    [EnumMember(Value = "CUP")]
    Cup,

    [EnumMember(Value = "CVE")]
    Cve,

    [EnumMember(Value = "CZK")]
    Czk,

    [EnumMember(Value = "DJF")]
    Djf,

    [EnumMember(Value = "DKK")]
    Dkk,

    [EnumMember(Value = "DOP")]
    Dop,

    [EnumMember(Value = "DZD")]
    Dzd,

    [EnumMember(Value = "EGP")]
    Egp,

    [EnumMember(Value = "ERN")]
    Ern,

    [EnumMember(Value = "ETB")]
    Etb,

    [EnumMember(Value = "EUR")]
    Eur,

    [EnumMember(Value = "FJD")]
    Fjd,

    [EnumMember(Value = "FKP")]
    Fkp,

    [EnumMember(Value = "GBP")]
    Gbp,

    [EnumMember(Value = "GEL")]
    Gel,

    [EnumMember(Value = "GHS")]
    Ghs,

    [EnumMember(Value = "GIP")]
    Gip,

    [EnumMember(Value = "GMD")]
    Gmd,

    [EnumMember(Value = "GNF")]
    Gnf,

    [EnumMember(Value = "GTQ")]
    Gtq,

    [EnumMember(Value = "GYD")]
    Gyd,

    [EnumMember(Value = "HKD")]
    Hkd,

    [EnumMember(Value = "HNL")]
    Hnl,

    [EnumMember(Value = "HTG")]
    Htg,

    [EnumMember(Value = "HUF")]
    Huf,

    [EnumMember(Value = "IDR")]
    Idr,

    [EnumMember(Value = "ILS")]
    Ils,

    [EnumMember(Value = "INR")]
    Inr,

    [EnumMember(Value = "IQD")]
    Iqd,

    [EnumMember(Value = "IRR")]
    Irr,

    [EnumMember(Value = "ISK")]
    Isk,

    [EnumMember(Value = "JMD")]
    Jmd,

    [EnumMember(Value = "JOD")]
    Jod,

    [EnumMember(Value = "JPY")]
    Jpy,

    [EnumMember(Value = "KES")]
    Kes,

    [EnumMember(Value = "KGS")]
    Kgs,

    [EnumMember(Value = "KHR")]
    Khr,

    [EnumMember(Value = "KMF")]
    Kmf,

    [EnumMember(Value = "KPW")]
    Kpw,

    [EnumMember(Value = "KRW")]
    Krw,

    [EnumMember(Value = "KWD")]
    Kwd,

    [EnumMember(Value = "KYD")]
    Kyd,

    [EnumMember(Value = "KZT")]
    Kzt,

    [EnumMember(Value = "LAK")]
    Lak,

    [EnumMember(Value = "LBP")]
    Lbp,

    [EnumMember(Value = "LKR")]
    Lkr,

    [EnumMember(Value = "LRD")]
    Lrd,

    [EnumMember(Value = "LSL")]
    Lsl,

    [EnumMember(Value = "LYD")]
    Lyd,

    [EnumMember(Value = "MAD")]
    Mad,

    [EnumMember(Value = "MDL")]
    Mdl,

    [EnumMember(Value = "MGA")]
    Mga,

    [EnumMember(Value = "MKD")]
    Mkd,

    [EnumMember(Value = "MMK")]
    Mmk,

    [EnumMember(Value = "MNT")]
    Mnt,

    [EnumMember(Value = "MOP")]
    Mop,

    [EnumMember(Value = "MRU")]
    Mru,

    [EnumMember(Value = "MUR")]
    Mur,

    [EnumMember(Value = "MVR")]
    Mvr,

    [EnumMember(Value = "MWK")]
    Mwk,

    [EnumMember(Value = "MXN")]
    Mxn,

    [EnumMember(Value = "MXV")]
    Mxv,

    [EnumMember(Value = "MYR")]
    Myr,

    [EnumMember(Value = "MZN")]
    Mzn,

    [EnumMember(Value = "NAD")]
    Nad,

    [EnumMember(Value = "NGN")]
    Ngn,

    [EnumMember(Value = "NIO")]
    Nio,

    [EnumMember(Value = "NOK")]
    Nok,

    [EnumMember(Value = "NPR")]
    Npr,

    [EnumMember(Value = "NZD")]
    Nzd,

    [EnumMember(Value = "OMR")]
    Omr,

    [EnumMember(Value = "PAB")]
    Pab,

    [EnumMember(Value = "PEN")]
    Pen,

    [EnumMember(Value = "PGK")]
    Pgk,

    [EnumMember(Value = "PHP")]
    Php,

    [EnumMember(Value = "PKR")]
    Pkr,

    [EnumMember(Value = "PLN")]
    Pln,

    [EnumMember(Value = "PYG")]
    Pyg,

    [EnumMember(Value = "QAR")]
    Qar,

    [EnumMember(Value = "RON")]
    Ron,

    [EnumMember(Value = "RSD")]
    Rsd,

    [EnumMember(Value = "CNY")]
    Cny,

    [EnumMember(Value = "RUB")]
    Rub,

    [EnumMember(Value = "RWF")]
    Rwf,

    [EnumMember(Value = "SAR")]
    Sar,

    [EnumMember(Value = "SBD")]
    Sbd,

    [EnumMember(Value = "SCR")]
    Scr,

    [EnumMember(Value = "SDG")]
    Sdg,

    [EnumMember(Value = "SEK")]
    Sek,

    [EnumMember(Value = "SGD")]
    Sgd,

    [EnumMember(Value = "SHP")]
    Shp,

    [EnumMember(Value = "SLE")]
    Sle,

    [EnumMember(Value = "SLL")]
    Sll,

    [EnumMember(Value = "SOS")]
    Sos,

    [EnumMember(Value = "SRD")]
    Srd,

    [EnumMember(Value = "SSP")]
    Ssp,

    [EnumMember(Value = "STN")]
    Stn,

    [EnumMember(Value = "SVC")]
    Svc,

    [EnumMember(Value = "SYP")]
    Syp,

    [EnumMember(Value = "SZL")]
    Szl,

    [EnumMember(Value = "THB")]
    Thb,

    [EnumMember(Value = "TJS")]
    Tjs,

    [EnumMember(Value = "TMT")]
    Tmt,

    [EnumMember(Value = "TND")]
    Tnd,

    [EnumMember(Value = "TOP")]
    Top,

    [EnumMember(Value = "TRY")]
    Try,

    [EnumMember(Value = "TTD")]
    Ttd,

    [EnumMember(Value = "TWD")]
    Twd,

    [EnumMember(Value = "TZS")]
    Tzs,

    [EnumMember(Value = "UAH")]
    Uah,

    [EnumMember(Value = "UGX")]
    Ugx,

    [EnumMember(Value = "USD")]
    Usd,

    [EnumMember(Value = "USN")]
    Usn,

    [EnumMember(Value = "UYI")]
    Uyi,

    [EnumMember(Value = "UYU")]
    Uyu,

    [EnumMember(Value = "UYW")]
    Uyw,

    [EnumMember(Value = "UZS")]
    Uzs,

    [EnumMember(Value = "VED")]
    Ved,

    [EnumMember(Value = "VES")]
    Ves,

    [EnumMember(Value = "VND")]
    Vnd,

    [EnumMember(Value = "VUV")]
    Vuv,

    [EnumMember(Value = "WST")]
    Wst,

    [EnumMember(Value = "XAF")]
    Xaf,

    [EnumMember(Value = "XAG")]
    Xag,

    [EnumMember(Value = "XAU")]
    Xau,

    [EnumMember(Value = "XBA")]
    Xba,

    [EnumMember(Value = "XBB")]
    Xbb,

    [EnumMember(Value = "XBC")]
    Xbc,

    [EnumMember(Value = "XBD")]
    Xbd,

    [EnumMember(Value = "XCD")]
    Xcd,

    [EnumMember(Value = "XDR")]
    Xdr,

    [EnumMember(Value = "XOF")]
    Xof,

    [EnumMember(Value = "XPD")]
    Xpd,

    [EnumMember(Value = "XPF")]
    Xpf,

    [EnumMember(Value = "XPT")]
    Xpt,

    [EnumMember(Value = "XSU")]
    Xsu,

    [EnumMember(Value = "XTS")]
    Xts,

    [EnumMember(Value = "XUA")]
    Xua,

    [EnumMember(Value = "XXX")]
    Xxx,

    [EnumMember(Value = "YER")]
    Yer,

    [EnumMember(Value = "ZAR")]
    Zar,

    [EnumMember(Value = "ZMW")]
    Zmw,

    [EnumMember(Value = "ZWL")]
    Zwl
}
