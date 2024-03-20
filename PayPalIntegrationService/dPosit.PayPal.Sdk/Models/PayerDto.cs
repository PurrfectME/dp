namespace dPosit.PayPal.Sdk.Models;

public sealed class PayerDto
{
    /// <summary>
    /// The email address of the payer.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// The PayPal-assigned ID for the payer.
    /// </summary>
    public string PayerId { get; set; }

    /// <summary>
    /// The address of the payer. Supports only the <c>address_line_1</c>, <c>address_line_2</c>, <c>admin_area_1</c>, <c>admin_area_2</c>,
    /// <c>postal_code</c>, and <c>country_code</c> properties. Also referred to as the billing address of the customer.
    /// </summary>
    public AddressPortableDto Address { get; set; }

    /// <summary>
    /// The birth date of the payer in <c>YYYY-MM-DD</c> format.
    /// </summary>
    public string BirthDate { get; set; }

    /// <summary>
    /// The name of the payer. Supports only the <c>given_name</c> and <c>surname</c> properties.
    /// </summary>
    public NameDto Name { get; set; }

    /// <summary>
    /// The phone number of the customer. Available only when you enable the <b>Contact Telephone Number</b> option in the
    /// <b>Profile & Settings</b> for the merchant's PayPal account. The <c>phone.phone_number</c> supports only <c>national_number</c>.
    /// </summary>
    public PhoneWithTypeDto Phone { get; set; }

    /// <summary>
    /// The tax information of the payer. Required only for Brazilian payer's. Both <c>tax_id</c> and <c>tax_id_type</c> are required.
    /// </summary>
    public TaxInfoDto TaxInfo { get; set; }
}
