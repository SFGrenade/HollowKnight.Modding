﻿using MonoMod;
using System;
using UnityEngine;

// ReSharper disable All
#pragma warning disable 1591, 0108, 0169, 0649, 114, 0414,0162, CS0626, IDE1005, IDE1006

namespace GlobalEnums
{
    // These changes fix NREs that happen in this class when pre-processing scenes without a hero in them
    [MonoModEnumReplace]
    public enum SupportedLanguages
	{
        N,
        AA,
        AB,
        AF,
        AM,
        AR,
        AR_SA,
        AR_EG,
        AR_DZ,
        AR_YE,
        AR_JO,
        AR_KW,
        AR_BH,
        AR_IQ,
        AR_MA,
        AR_LY,
        AR_OM,
        AR_SY,
        AR_LB,
        AR_AE,
        AR_QA,
        AS,
        AY,
        AZ,
        BA,
        BE,
        BG,
        BH,
        BI,
        BN,
        BO,
        BR,
        CA,
        CO,
        CS,
        CY,
        DA,
        DE,
        DE_AT,
        DE_LI,
        DE_CH,
        DE_LU,
        DZ,
        EL,
        EN,
        EN_US,
        EN_AU,
        EN_NZ,
        EN_ZA,
        EN_CB,
        EN_TT,
        EN_GB,
        EN_CA,
        EN_IE,
        EN_JM,
        EN_BZ,
        EO,
        ES,
        ES_MX,
        ES_CR,
        ES_DO,
        ES_CO,
        ES_AR,
        ES_CL,
        ES_PY,
        ES_SV,
        ES_NI,
        ES_GT,
        ES_PA,
        ES_VE,
        ES_PE,
        ES_EC,
        ES_UY,
        ES_BO,
        ES_HN,
        ES_PR,
        ET,
        EU,
        FA,
        FI,
        FJ,
        FO,
        FR,
        FR_BE,
        FR_CH,
        FR_CA,
        FR_LU,
        FY,
        GA,
        GD,
        GL,
        GN,
        GU,
        HA,
        HI,
        HE,
        HR,
        HU,
        HY,
        IA,
        ID,
        IE,
        IK,
        IN,
        IS,
        IT,
        IT_CH,
        IU,
        IW,
        JA,
        JI,
        JW,
        KA,
        KK,
        KL,
        KM,
        KN,
        KO,
        KS,
        KU,
        KY,
        LA,
        LN,
        LO,
        LT,
        LV,
        MG,
        MI,
        MK,
        ML,
        MN,
        MO,
        MR,
        MS,
        MT,
        MY,
        NA,
        NE,
        NL,
        NL_BE,
        NO,
        OC,
        OM,
        OR,
        PA,
        PL,
        PS,
        PT,
        PT_BR,
        QU,
        RM,
        RN,
        RO,
        RO_MO,
        RU,
        RU_MO,
        RW,
        SA,
        SD,
        SG,
        SH,
        SI,
        SK,
        SL,
        SM,
        SN,
        SO,
        SQ,
        SR,
        SS,
        ST,
        SU,
        SV,
        SV_FI,
        SW,
        TA,
        TE,
        TG,
        TH,
        TI,
        TK,
        TL,
        TN,
        TO,
        TR,
        TS,
        TT,
        TW,
        UG,
        UK,
        UR,
        UZ,
        VI,
        VO,
        WO,
        XH,
        YI,
        YO,
        ZA,
        ZH,
        ZH_TW,
        ZH_HK,
        ZH_CN,
        ZH_SG,
        ZU
	}
}
