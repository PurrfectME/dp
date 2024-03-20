using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.Extensions;

internal static class ModelsExtensions
{
    public static string GetStringValue(this GrantType grantType)
    {
        if (Constants.GrandTypeMap.TryGetValue(grantType, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this ResponseType responseType)
    {
        if (Constants.ResponseTypeMap.TryGetValue(responseType, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this TokenTypeHint tokenTypeHint)
    {
        if (Constants.TokenTypeHintMap.TryGetValue(tokenTypeHint, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this Intent intent)
    {
        if (Constants.IntentMap.TryGetValue(intent, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this Currency currency)
    {
        if (Constants.CurrencyCodesMap.TryGetValue(currency, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this ItemCategory itemCategory)
    {
        if (Constants.ItemCategoryMap.TryGetValue(itemCategory, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this DisbursementMode disbursementMode)
    {
        if (Constants.DisbursementModeMap.TryGetValue(disbursementMode, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this ShippingType shippingType)
    {
        if (Constants.ShippingTypeMap.TryGetValue(shippingType, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this UserCheckoutAction userCheckoutAction)
    {
        if (Constants.UserCheckoutActionMap.TryGetValue(userCheckoutAction, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PaymentMethod paymentMethod)
    {
        if (Constants.PaymentMethodMap.TryGetValue(paymentMethod, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this SecCode secCode)
    {
        if (Constants.SecCodeMap.TryGetValue(secCode, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PatchOperation patchOperation)
    {
        if (Constants.PatchOperationMap.TryGetValue(patchOperation, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this Country country)
    {
        if (Constants.CountryAddressOptionsMap.TryGetValue(country, out var countryAddressOptions))
        {
            return countryAddressOptions.Code;
        }

        return null;
    }

    public static string GetStringValue(this Locale locale)
    {
        if (Constants.LanguageTagMap.TryGetValue(locale, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this TokenizationMethod tokenizationMethod)
    {
        if (Constants.TokenizationMethodMap.TryGetValue(tokenizationMethod, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this CardBrand cardBrand)
    {
        if (Constants.CardBrandMap.TryGetValue(cardBrand, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PaymentInitiator paymentInitiator)
    {
        if (Constants.PaymentInitiatorMap.TryGetValue(paymentInitiator, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PaymentType paymentType)
    {
        if (Constants.PaymentTypeMap.TryGetValue(paymentType, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PaymentUsage paymentUsage)
    {
        if (Constants.PaymentUsageMap.TryGetValue(paymentUsage, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this ProcessingInstruction processingInstruction)
    {
        if (Constants.ProcessingInstructionMap.TryGetValue(processingInstruction, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this PaymentInstrumentType paymentInstrumentType)
    {
        if (Constants.PaymentInstrumentTypeMap.TryGetValue(paymentInstrumentType, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this BalanceAffectingRecordsOnly balanceAffectingRecordsOnly)
    {
        if (Constants.BalanceAffectingRecordsOnlyMap.TryGetValue(balanceAffectingRecordsOnly, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this TransactionField transactionField)
    {
        if (Constants.TransactionFieldMap.TryGetValue(transactionField, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }

    public static string GetStringValue(this TransactionStatus transactionStatus)
    {
        if (Constants.TransactionStatusMap.TryGetValue(transactionStatus, out var stringValue))
        {
            return stringValue;
        }

        return null;
    }
}
